"""
Crea il database Delsy di PROVA in un SQL Server su Docker e lo riempie con i dati di esempio.

  python3 prepara_database.py            # avvia il container 'delsy-sql' (porta 14330) se serve, poi carica tutto

Stringa di connessione per i test:
  Server=localhost,14330;Database=DELSYLOG91_LUCART;User ID=sa;Password=Delsy!Prova2026;TrustServerCertificate=True

Lo schema (schema_delsy.sql) contiene solo strutture, nessun dato. Le chiavi esterne non vengono create
(alcune sono circolari) e le funzioni assenti dallo script sono ricostruite in funzioni_mancanti.sql.
"""
import os, re, subprocess, sys, time

QUI = os.path.dirname(os.path.abspath(__file__))
PWD = "Delsy!Prova2026"
DB = "DELSYLOG91_LUCART"
IMG = "mcr.microsoft.com/mssql/server:2022-CU14-ubuntu-22.04"

def sqlcmd(sql, db="master"):
    p = subprocess.run(["docker", "exec", "-i", "delsy-sql", "/opt/mssql-tools18/bin/sqlcmd", "-C", "-S", "localhost", "-U", "sa", "-P", PWD, "-d", db, "-b", "-I"],
                       input=sql, capture_output=True, text=True)
    return p.returncode == 0, (p.stdout + p.stderr).strip()

def avvia():
    out = subprocess.run(["docker", "ps", "-a", "--filter", "name=delsy-sql", "--format", "{{.Status}}"], capture_output=True, text=True).stdout
    if not out:
        subprocess.run(["docker", "run", "-d", "--name", "delsy-sql", "-e", "ACCEPT_EULA=Y", "-e", "MSSQL_SA_PASSWORD=" + PWD,
                        "-e", "MSSQL_COLLATION=SQL_Latin1_General_CP1_CI_AS", "-p", "14330:1433", IMG], check=True)
    elif not out.startswith("Up"):
        subprocess.run(["docker", "start", "delsy-sql"], check=True)
    for _ in range(90):
        if sqlcmd("SELECT 1")[0]:
            return
        time.sleep(2)
    sys.exit("SQL Server non risponde")

def oggetti():
    testo = open(os.path.join(QUI, "schema_delsy.sql"), encoding="utf-8", errors="replace").read().replace("\r", "")
    parti = re.split(r"^-- (?:\w+\.)?(\w+)\.(\w+) (definition|source)\s*$", testo, flags=re.M)
    tabelle, viste = [], []
    for i in range(1, len(parti), 4):
        nome, tipo, corpo = parti[i + 1], parti[i + 2], parti[i + 3]
        if tipo == "definition":
            corpo = re.sub(r"(?im)^\s*CREATE SCHEMA dbo;\s*$", "", corpo)
            corpo = re.sub(r",\s*CONSTRAINT \w+ FOREIGN KEY [^\n]*?(?=,\s*\n|\s*\n\);)", "", corpo)
            tabelle.append((nome, corpo.strip() + "\nGO\n"))
        else:
            viste.append((nome, re.sub(r"(?i)\bALTER\s+VIEW\b", "CREATE OR ALTER VIEW", corpo, count=1).strip() + "\nGO\n"))
    return tabelle, viste

def carica(etichetta, gruppo):
    in_sospeso = gruppo
    for _ in range(12):
        falliti = [(n, s) for n, s in in_sospeso if not sqlcmd(s, DB)[0]]
        if not falliti or len(falliti) == len(in_sospeso):
            in_sospeso = falliti
            break
        in_sospeso = falliti
    print(f"{etichetta}: create {len(gruppo) - len(in_sospeso)} su {len(gruppo)}")

def main():
    avvia()
    sqlcmd(f"IF DB_ID('{DB}') IS NOT NULL BEGIN ALTER DATABASE {DB} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE {DB}; END; CREATE DATABASE {DB} COLLATE SQL_Latin1_General_CP1_CI_AS;")
    tabelle, viste = oggetti()
    carica("tabelle", tabelle)
    # eventuali chiavi esterne rimaste: i dati di prova non rispettano tutte le anagrafiche
    sqlcmd("DECLARE @s nvarchar(max) = N''; SELECT @s += N'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + N'.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + N' DROP CONSTRAINT ' + QUOTENAME(name) + N';' FROM sys.foreign_keys; EXEC sp_executesql @s;", DB)
    ok, out = sqlcmd(open(os.path.join(QUI, "funzioni_mancanti.sql")).read(), DB)
    if not ok: sys.exit(out)
    carica("viste", viste)
    for script in sorted(f for f in os.listdir(QUI) if f.startswith("dati_") and f.endswith(".sql")):
        ok, out = sqlcmd(open(os.path.join(QUI, script)).read(), DB)
        print(script, "ok" if ok else "ERRORE\n" + out)
        if not ok: sys.exit(1)

if __name__ == "__main__":
    main()
