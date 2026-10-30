CREATE FUNCTION DevolverUltimoNroTiket()
RETURNS int
AS
BEGIN
	DECLARE @result int;
	SET @result =(SELECT COUNT(*) + 1 FROM dbo.venta);
	return @result;
END;
GO