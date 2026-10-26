/* ============================================================
   SCRIPT DE INSERCIÓN DE DATOS DE PRUEBA
   15 registros por tabla | IDs: uniqueidentifier
   ============================================================ */

SET NOCOUNT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    /* ------------------------------------------------------------
       (OPCIONAL) Limpiar tablas antes de insertar
       Respetar orden por FKs
    ------------------------------------------------------------ */
    -- DELETE FROM ProveedorProducto;
    -- DELETE FROM Lote;
    -- DELETE FROM Producto;
    -- DELETE FROM Proveedor;
    -- DELETE FROM Presentacion;
    -- DELETE FROM Categoria;

    /* ============================================================
       1) CATEGORIA  (15 registros)
       ============================================================ */
    INSERT INTO Categoria ([id],[nombre],[descripcion],[fechaCreacion],[estado]) VALUES
    ('11111111-1111-1111-1111-111111111101','Analgésicos','Medicamentos para aliviar dolor y fiebre',          DATEADD(DAY,-180,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111102','Antibióticos','Medicamentos para infecciones bacterianas',        DATEADD(DAY,-175,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111103','Antiinflamatorios','Medicamentos para reducir inflamación',       DATEADD(DAY,-170,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111104','Antihistamínicos','Medicamentos para alergias',                 DATEADD(DAY,-165,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111105','Vitaminas','Suplementos vitamínicos',                              DATEADD(DAY,-160,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111106','Antigripales','Medicamentos para resfríos',                       DATEADD(DAY,-155,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111107','Dermatológicos','Productos para el cuidado de la piel',          DATEADD(DAY,-150,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111108','Gastrointestinales','Medicamentos digestivos',                  DATEADD(DAY,-145,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111109','Cardiovasculares','Medicamentos para el corazón',               DATEADD(DAY,-140,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111110','Diabetes','Medicamentos para diabetes',                          DATEADD(DAY,-135,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111111','Respiratorios','Medicamentos para vías respiratorias',         DATEADD(DAY,-130,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111112','Pediatría','Productos pediátricos',                              DATEADD(DAY,-125,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111113','Oftalmológicos','Productos para los ojos',                       DATEADD(DAY,-120,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111114','Vitaminas y Minerales','Suplementos alimenticios',              DATEADD(DAY,-115,GETDATE()),1),
    ('11111111-1111-1111-1111-111111111115','Otros','Otros productos no clasificados',                      DATEADD(DAY,-110,GETDATE()),0);


    /* ============================================================
       2) PRESENTACION  (15 registros)
       ============================================================ */
    INSERT INTO Presentacion ([id],[nombre],[descripcion],[fechaCreacion],[estado]) VALUES
    ('22222222-2222-2222-2222-222222222201','Caja x 10 comprimidos','Envase con 10 comprimidos',            DATEADD(DAY,-180,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222202','Caja x 20 comprimidos','Envase con 20 comprimidos',            DATEADD(DAY,-178,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222203','Caja x 30 comprimidos','Envase con 30 comprimidos',            DATEADD(DAY,-176,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222204','Blíster x 10','Blíster con 10 unidades',                        DATEADD(DAY,-174,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222205','Frasco x 100 ml','Frasco con 100 mililitros',                   DATEADD(DAY,-172,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222206','Frasco x 250 ml','Frasco con 250 mililitros',                   DATEADD(DAY,-170,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222207','Tubo x 30 g','Tubo con 30 gramos de crema/pomada',               DATEADD(DAY,-168,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222208','Ampollas x 5','Pack de 5 ampollas',                             DATEADD(DAY,-166,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222209','Sobre x 1 g','Sobre con 1 gramo de polvo',                     DATEADD(DAY,-164,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222210','Caja x 50 comprimidos','Envase con 50 comprimidos',            DATEADD(DAY,-162,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222211','Frasco x 500 ml','Frasco con 500 mililitros',                   DATEADD(DAY,-160,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222212','Gotas x 20 ml','Frasco gotero de 20 mililitros',                DATEADD(DAY,-158,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222213','Jeringa prellenada','Jeringa con dosis única',                  DATEADD(DAY,-156,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222214','Supositorios x 10','Pack de 10 supositorios',                    DATEADD(DAY,-154,GETDATE()),1),
    ('22222222-2222-2222-2222-222222222215','Parche x 5','Pack de 5 parches transdérmicos',                   DATEADD(DAY,-152,GETDATE()),0);


    /* ============================================================
       3) PROVEEDOR  (15 registros)
       ============================================================ */
    INSERT INTO Proveedor
        ([id],[fechaBaja],[fechaCreacion],[Cuit_Cuil],[razonSocial],[email],[telefono],[direccion],[web],[estado])
    VALUES
    ('33333333-3333-3333-3333-333333333301',NULL,DATEADD(DAY,-200,GETDATE()),'30-71234567-1','Farmacéutica del Sur S.A.','contacto@farmaciasur.com','011-4555-1001','Av. Rivadavia 1234, CABA','www.farmaciasur.com',1),
    ('33333333-3333-3333-3333-333333333302',NULL,DATEADD(DAY,-195,GETDATE()),'30-71234568-2','Distribuidora Norte SRL','ventas@distnorte.com','011-4555-1002','San Martín 567, Rosario','www.distnorte.com',1),
    ('33333333-3333-3333-3333-333333333303',NULL,DATEADD(DAY,-190,GETDATE()),'30-71234569-3','Laboratorios Andinos S.A.','info@labandinos.com','011-4555-1003','Belgrano 890, Córdoba','www.labandinos.com',1),
    ('33333333-3333-3333-3333-333333333304',NULL,DATEADD(DAY,-185,GETDATE()),'30-71234570-4','Medicamentos Express SRL','pedidos@medexpress.com','011-4555-1004','Mitre 1122, Mendoza','www.medexpress.com',1),
    ('33333333-3333-3333-3333-333333333305',NULL,DATEADD(DAY,-180,GETDATE()),'30-71234571-5','Pharma Global S.A.','contacto@pharmaglobal.com','011-4555-1005','9 de Julio 445, CABA','www.pharmaglobal.com',1),
    ('33333333-3333-3333-3333-333333333306',NULL,DATEADD(DAY,-175,GETDATE()),'30-71234572-6','Droguería Central SRL','ventas@drocentral.com','011-4555-1006','Rivadavia 3321, CABA','www.drocentral.com',1),
    ('33333333-3333-3333-3333-333333333307',NULL,DATEADD(DAY,-170,GETDATE()),'30-71234573-7','Salud Total Distribuidora','info@saludtotal.com','011-4555-1007','Sarmiento 2210, La Plata','www.saludtotal.com',1),
    ('33333333-3333-3333-3333-333333333308',NULL,DATEADD(DAY,-165,GETDATE()),'30-71234574-8','BioFarma Argentina S.A.','contacto@biofarma.com','011-4555-1008','Callao 678, CABA','www.biofarma.com',1),
    ('33333333-3333-3333-3333-333333333309',NULL,DATEADD(DAY,-160,GETDATE()),'30-71234575-9','Distribuciones del Litoral','ventas@distlitoral.com','011-4555-1009','Urquiza 998, Santa Fe','www.distlitoral.com',1),
    ('33333333-3333-3333-3333-333333333310',NULL,DATEADD(DAY,-155,GETDATE()),'30-71234576-0','Laboratorios del Plata S.A.','info@labplata.com','011-4555-1010','Moreno 1456, CABA','www.labplata.com',1),
    ('33333333-3333-3333-3333-333333333311',NULL,DATEADD(DAY,-150,GETDATE()),'30-71234577-1','Farmacéutica Buenos Aires','contacto@farba.com','011-4555-1011','Corrientes 2100, CABA','www.farba.com',1),
    ('33333333-3333-3333-3333-333333333312',NULL,DATEADD(DAY,-145,GETDATE()),'30-71234578-2','Droguería del Oeste SRL','ventas@drooeste.com','011-4555-1012','Rivadavia 8900, Morón','www.drooeste.com',1),
    ('33333333-3333-3333-3333-333333333313',NULL,DATEADD(DAY,-140,GETDATE()),'30-71234579-3','MedSupply S.A.','info@medsupply.com','011-4555-1013','Av. La Plata 1234, CABA','www.medsupply.com',1),
    ('33333333-3333-3333-3333-333333333314',NULL,DATEADD(DAY,-135,GETDATE()),'30-71234580-4','Grupo Farmacéutico Sur','contacto@gfsur.com','011-4555-1014','San Juan 456, Bahía Blanca','www.gfsur.com',1),
    ('33333333-3333-3333-3333-333333333315',DATEADD(DAY,-30,GETDATE()),DATEADD(DAY,-130,GETDATE()),'30-71234581-5','Droguería Antigua SRL','info@droantigua.com','011-4555-1015','Belgrano 100, CABA','www.droantigua.com',0);


    /* ============================================================
       4) PRODUCTO  (15 registros)
       Ref: categoriaId (1111...) / presentacionId (2222...)
       ============================================================ */
    INSERT INTO Producto
        ([id],[categoriaId],[presentacionId],[estado],[descripcion],[codigoBarra],[nombre],[precioCompra],[fechaCreacion],[fechaBaja])
    VALUES
    ('44444444-4444-4444-4444-444444444401','11111111-1111-1111-1111-111111111101','22222222-2222-2222-2222-222222222201',1,'Analgésico y antipirético','7791234567891','Paracetamol 500mg',       150.00,DATEADD(DAY,-120,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444402','11111111-1111-1111-1111-111111111101','22222222-2222-2222-2222-222222222202',1,'Antiinflamatorio no esteroide','7791234567892','Ibuprofeno 400mg',        180.00,DATEADD(DAY,-118,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444403','11111111-1111-1111-1111-111111111102','22222222-2222-2222-2222-222222222203',1,'Antibiótico de amplio espectro','7791234567893','Amoxicilina 500mg',      320.00,DATEADD(DAY,-116,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444404','11111111-1111-1111-1111-111111111102','22222222-2222-2222-2222-222222222201',1,'Antibiótico macrólido','7791234567894','Azitromicina 500mg',           450.00,DATEADD(DAY,-114,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444405','11111111-1111-1111-1111-111111111103','22222222-2222-2222-2222-222222222207',1,'Antiinflamatorio tópico','7791234567895','Diclofenac gel 30g',            290.00,DATEADD(DAY,-112,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444406','11111111-1111-1111-1111-111111111104','22222222-2222-2222-2222-222222222204',1,'Antihistamínico para alergias','7791234567896','Loratadina 10mg',         210.00,DATEADD(DAY,-110,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444407','11111111-1111-1111-1111-111111111105','22222222-2222-2222-2222-222222222205',1,'Suplemento de vitamina C','7791234567897','Vitamina C 1000mg',             180.00,DATEADD(DAY,-108,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444408','11111111-1111-1111-1111-111111111106','22222222-2222-2222-2222-222222222202',1,'Antigripal en comprimidos','7791234567898','Antigripal Forte',              260.00,DATEADD(DAY,-106,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444409','11111111-1111-1111-1111-111111111107','22222222-2222-2222-2222-222222222207',1,'Crema dermatológica','7791234567899','Hidrocortisona crema 30g',             340.00,DATEADD(DAY,-104,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444410','11111111-1111-1111-1111-111111111108','22222222-2222-2222-2222-222222222201',1,'Protector gástrico','7791234567900','Omeprazol 20mg',                       220.00,DATEADD(DAY,-102,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444411','11111111-1111-1111-1111-111111111109','22222222-2222-2222-2222-222222222210',1,'Antihipertensivo','7791234567901','Enalapril 10mg',                          190.00,DATEADD(DAY,-100,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444412','11111111-1111-1111-1111-111111111110','22222222-2222-2222-2222-222222222210',1,'Antidiabético oral','7791234567902','Metformina 850mg',                    250.00,DATEADD(DAY,-98,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444413','11111111-1111-1111-1111-111111111111','22222222-2222-2222-2222-222222222211',1,'Jarabe para la tos','7791234567903','Jarabe Expectorante 500ml',              310.00,DATEADD(DAY,-96,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444414','11111111-1111-1111-1111-111111111112','22222222-2222-2222-2222-222222222205',1,'Pediculicida infantil','7791234567904','Shampoo Pediculicida 100ml',                   275.00,DATEADD(DAY,-94,GETDATE()),NULL),
    ('44444444-4444-4444-4444-444444444415','11111111-1111-1111-1111-111111111113','22222222-2222-2222-2222-222222222212',0,'Gotas oftálmicas','7791234567905','Lágrimas Artificiales 20ml',                         200.00,DATEADD(DAY,-92,GETDATE()),DATEADD(DAY,-10,GETDATE()));


    /* ============================================================
       5) LOTE  (15 registros)
       Ref: productoId (4444...)
       ============================================================ */
    INSERT INTO Lote
        ([id],[productoId],[fechaCreacion],[fechaVencimiento],[stock],[precioVenta],[precioCompra],[fechaBaja],[estado])
    VALUES
    ('55555555-5555-5555-5555-555555555501','44444444-4444-4444-4444-444444444401',DATEADD(DAY,-100,GETDATE()),DATEADD(MONTH,18,GETDATE()), 200, 250.00,150.00,NULL,1),
    ('55555555-5555-5555-5555-555555555502','44444444-4444-4444-4444-444444444402',DATEADD(DAY,-98, GETDATE()),DATEADD(MONTH,17,GETDATE()), 150, 300.00,180.00,NULL,1),
    ('55555555-5555-5555-5555-555555555503','44444444-4444-4444-4444-444444444403',DATEADD(DAY,-96, GETDATE()),DATEADD(MONTH,16,GETDATE()), 100, 500.00,320.00,NULL,1),
    ('55555555-5555-5555-5555-555555555504','44444444-4444-4444-4444-444444444404',DATEADD(DAY,-94, GETDATE()),DATEADD(MONTH,15,GETDATE()), 120, 700.00,450.00,NULL,1),
    ('55555555-5555-5555-5555-555555555505','44444444-4444-4444-4444-444444444405',DATEADD(DAY,-92, GETDATE()),DATEADD(MONTH,14,GETDATE()),  80, 450.00,290.00,NULL,1),
    ('55555555-5555-5555-5555-555555555506','44444444-4444-4444-4444-444444444406',DATEADD(DAY,-90, GETDATE()),DATEADD(MONTH,13,GETDATE()), 180, 320.00,210.00,NULL,1),
    ('55555555-5555-5555-5555-555555555507','44444444-4444-4444-4444-444444444407',DATEADD(DAY,-88, GETDATE()),DATEADD(MONTH,12,GETDATE()), 250, 280.00,180.00,NULL,1),
    ('55555555-5555-5555-5555-555555555508','44444444-4444-4444-4444-444444444408',DATEADD(DAY,-86, GETDATE()),DATEADD(MONTH,11,GETDATE()),  90, 400.00,260.00,NULL,1),
    ('55555555-5555-5555-5555-555555555509','44444444-4444-4444-4444-444444444409',DATEADD(DAY,-84, GETDATE()),DATEADD(MONTH,10,GETDATE()),  60, 500.00,340.00,NULL,1),
    ('55555555-5555-5555-5555-555555555510','44444444-4444-4444-4444-444444444410',DATEADD(DAY,-82, GETDATE()),DATEADD(MONTH, 9,GETDATE()), 220, 330.00,220.00,NULL,1),
    ('55555555-5555-5555-5555-555555555511','44444444-4444-4444-4444-444444444411',DATEADD(DAY,-80, GETDATE()),DATEADD(MONTH, 8,GETDATE()), 140, 290.00,190.00,NULL,1),
    ('55555555-5555-5555-5555-555555555512','44444444-4444-4444-4444-444444444412',DATEADD(DAY,-78, GETDATE()),DATEADD(MONTH, 7,GETDATE()), 160, 380.00,250.00,NULL,1),
    ('55555555-5555-5555-5555-555555555513','44444444-4444-4444-4444-444444444413',DATEADD(DAY,-76, GETDATE()),DATEADD(MONTH, 6,GETDATE()),  75, 480.00,310.00,NULL,1),
    ('55555555-5555-5555-5555-555555555514','44444444-4444-4444-4444-444444444414',DATEADD(DAY,-74, GETDATE()),DATEADD(MONTH, 5,GETDATE()),  50, 420.00,275.00,NULL,1),
    ('55555555-5555-5555-5555-555555555515','44444444-4444-4444-4444-444444444415',DATEADD(DAY,-72, GETDATE()),DATEADD(MONTH,-2,GETDATE()),  30, 300.00,200.00,DATEADD(DAY,-10,GETDATE()),0);


    /* ============================================================
       6) PROVEEDORPRODUCTO  (15 registros)
       Ref: proveedorId (3333...) / productoId (4444...)
       ============================================================ */
    INSERT INTO ProveedorProducto
        ([id],[proveedorId],[productoId],[fechaCreacion],[fechaBaja],[estado])
    VALUES
    ('66666666-6666-6666-6666-666666666601','33333333-3333-3333-3333-333333333301','44444444-4444-4444-4444-444444444401',DATEADD(DAY,-100,GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666602','33333333-3333-3333-3333-333333333302','44444444-4444-4444-4444-444444444402',DATEADD(DAY,-98, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666603','33333333-3333-3333-3333-333333333303','44444444-4444-4444-4444-444444444403',DATEADD(DAY,-96, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666604','33333333-3333-3333-3333-333333333304','44444444-4444-4444-4444-444444444404',DATEADD(DAY,-94, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666605','33333333-3333-3333-3333-333333333305','44444444-4444-4444-4444-444444444405',DATEADD(DAY,-92, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666606','33333333-3333-3333-3333-333333333306','44444444-4444-4444-4444-444444444406',DATEADD(DAY,-90, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666607','33333333-3333-3333-3333-333333333307','44444444-4444-4444-4444-444444444407',DATEADD(DAY,-88, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666608','33333333-3333-3333-3333-333333333308','44444444-4444-4444-4444-444444444408',DATEADD(DAY,-86, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666609','33333333-3333-3333-3333-333333333309','44444444-4444-4444-4444-444444444409',DATEADD(DAY,-84, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666610','33333333-3333-3333-3333-333333333310','44444444-4444-4444-4444-444444444410',DATEADD(DAY,-82, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666611','33333333-3333-3333-3333-333333333311','44444444-4444-4444-4444-444444444411',DATEADD(DAY,-80, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666612','33333333-3333-3333-3333-333333333312','44444444-4444-4444-4444-444444444412',DATEADD(DAY,-78, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666613','33333333-3333-3333-3333-333333333313','44444444-4444-4444-4444-444444444413',DATEADD(DAY,-76, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666614','33333333-3333-3333-3333-333333333314','44444444-4444-4444-4444-444444444414',DATEADD(DAY,-74, GETDATE()),NULL,1),
    ('66666666-6666-6666-6666-666666666615','33333333-3333-3333-3333-333333333315','44444444-4444-4444-4444-444444444415',DATEADD(DAY,-72, GETDATE()),DATEADD(DAY,-10,GETDATE()),0);


    COMMIT TRANSACTION;
    PRINT '>> Inserción completada correctamente: 15 registros por tabla.';
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    PRINT '>> ERROR al insertar: ' + ERROR_MESSAGE();
    PRINT '>> Línea: ' + CAST(ERROR_LINE() AS VARCHAR(10));
    THROW;
END CATCH;
