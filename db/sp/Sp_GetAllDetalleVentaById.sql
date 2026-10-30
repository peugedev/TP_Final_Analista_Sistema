USE [clickventa]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertVenta]    Script Date: 26/10/2026 13:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[Sp_GetAllDetalleVentaById]
@ventaId Uniqueidentifier
as
Begin
	SET NOCOUNT ON;
    SET XACT_ABORT ON;  -- Automatically rollback on error

	BEGIN TRY
		BEGIN TRANSACTION;

			select dt.ventaId as Id, prod.nombre,dt.ProductoId, dt.cantidad, dt.precio, dt.subTotal 
			from detalleventa dt inner join producto prod on prod.id = dt.ProductoId
			where dt.ventaId = @ventaId
				
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		-- Si hay error, deshacer cambios
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;

		-- Capture error details
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState    INT = ERROR_STATE();

        -- Re-raise the error to the caller (C# will see it as an SqlException)
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
