--1) Crear secuencia (ejecutar UNA sola vez)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM sys.sequences WHERE name = 'SeqVentaNroTicket')
    DECLARE @ultimoTicket INT = (SELECT top 1 nroTicket FROM dbo.Venta order by fechaventa desc);
    DECLARE @seed         INT = ISNULL(@ultimoTicket, 0) + 1;
DECLARE @sql NVARCHAR(MAX) =
    N'CREATE SEQUENCE dbo.SeqVentaNroTicket
         AS INT
         START WITH ' + CAST(@seed AS NVARCHAR(20)) + N'
         INCREMENT BY 1
         MINVALUE 1
         NO CYCLE
         CACHE 50;';
EXEC sp_executesql @sql;

-- ============================================================
-- 2) Constraint UNIQUE en Venta.nroTicket (red de seguridad)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'UX_Venta_nroTicket' AND object_id = OBJECT_ID('dbo.Venta'))
BEGIN
    CREATE UNIQUE INDEX UX_Venta_nroTicket ON dbo.Venta(nroTicket);
END
GO