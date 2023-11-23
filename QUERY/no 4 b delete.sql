USE [TechnicalTest]
GO

CREATE PROCEDURE DELETE_PRODUCT 
	-- Add the parameters for the stored procedure here
	@KODE_BARANG varchar(50)
AS
BEGIN
DELETE FROM [dbo].[product]
      WHERE kode_barang = @KODE_BARANG
END
GO
