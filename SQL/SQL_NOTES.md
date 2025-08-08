# SQL NOTES

## 1. Database

### Database Create
```sql
1. CREATE DATABASE myDB
2. SHOW DATABASES 
3. USE myDB
```
---
### Multiple database
```sql
    CREATE DATABASE myDB_1;
    CREATE DATABASE myDB_2;
    CREATE DATABASE myDB_3;
```

### Drop database
```sql
    DROP DATABASE myDB_2;
```



## MySQL Database backup and restore

### Types of Backups in SQL
```sql
1. Full Backup
2. Differential Backup 
3. Transaction Log(T-log) backup

1. --> Full backup
BACKAUP DATABASE database_name
TO medium = 'filepath'
GO

2. --> Differential backup
BACKAUP DATABASE my_db
TO medium = 'filepath'
WITH DIFFRENTIAL;
GO

3. --> Transaction Log(T-log) backup
BACKAUP LOG database_name
TO medium = 'filepath'
GO
```
## RESTORE Database from Backup
RESTORE DATABASE database_name
FROM DISK = 'filepath';
GO

## Database Backup

1. mysqldump - create a temp file like 'test.sql' and  dump the database whole content in it.
```sql
mysqldump -u username -p'password' -R testDB > testDB.sql
```

2. mysqladmin - create a 'new DB' file like 'Prashant.sql'.
```bash
mysqldump -u username -p'password' create 'Prashant.sql';
```

2. mysqladmin - createed 'new DB' file 'Prashant.sql' put testDB.sql (temp) in it.
```bash
mysqldump -u username -p'password' create 'Prashant.sql > testDB.sql';
```

