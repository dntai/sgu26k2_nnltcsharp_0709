docker run -d --name mssql -v 'D:\ws:/ws' -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SqlServer@2026"  -e "MSSQL_PID=Developer"   -p 1433:1433 mcr.microsoft.com/mssql/server:2022-latest


BULK INSERT dbo.Xe
FROM '/ws/git3/Tuan06/SimpleDatabaseViewer/DB/XE.csv'
WITH (
    FORMAT = 'CSV',
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',
    FIELDQUOTE = '"',
    ROWTERMINATOR = '0x0a',
    TABLOCK
);