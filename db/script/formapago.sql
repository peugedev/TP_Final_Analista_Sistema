USE [clickventa];
GO

SET NOCOUNT ON;

/* 
   estado: 1 = Activo, 0 = Inactivo (ajusta según tu convención)
   fechaBaja: NULL si está activo, fecha si está dado de baja
*/

INSERT INTO [dbo].[FormaPago] ([id], [nombre], [descripcion], [fechaCreacion], [estado], [fechaBaja])
SELECT v.id, v.nombre, v.descripcion, v.fechaCreacion, v.estado, v.fechaBaja
FROM (VALUES
    (NEWID(), 'Efectivo',            'Pago en efectivo en caja',                     DATEADD(DAY, -30, GETDATE()), 1, NULL),
    (NEWID(), 'Tarjeta de Crédito',  'Pago con tarjeta de crédito (Visa/Master)',    DATEADD(DAY, -30, GETDATE()), 1, NULL),
    (NEWID(), 'Tarjeta de Débito',   'Pago con tarjeta de débito',                   DATEADD(DAY, -30, GETDATE()), 1, NULL),
    (NEWID(), 'Transferencia',       'Transferencia bancaria / CBU / CVU',           DATEADD(DAY, -25, GETDATE()), 1, NULL),
    (NEWID(), 'Mercado Pago',        'Pago mediante billetera virtual',              DATEADD(DAY, -20, GETDATE()), 1, NULL),
    (NEWID(), 'Cheque',              'Cheque físico o e-cheq',                       DATEADD(DAY, -15, GETDATE()), 1, NULL),
    (NEWID(), 'Crédito Interno',     'Cuenta corriente del cliente',                 DATEADD(DAY, -10, GETDATE()), 1, NULL),
    (NEWID(), 'Tarjeta Regalo',      'Voucher / gift card (descontinuado)',          DATEADD(DAY, -90, GETDATE()), 0, DATEADD(DAY, -5, GETDATE()))
) AS v(id, nombre, descripcion, fechaCreacion, estado, fechaBaja)
WHERE NOT EXISTS (
    SELECT 1 FROM [dbo].[FormaPago] fp WHERE fp.nombre = v.nombre
);

SELECT * FROM [dbo].[FormaPago] ORDER BY fechaCreacion DESC;
GO
