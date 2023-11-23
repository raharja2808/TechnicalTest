USE [TechnicalTest]
GO

CREATE PROCEDURE UPDATE_PRODUCT 
	-- Add the parameters for the stored procedure here
	@KODE_BARANG varchar(50),
	@JUMLAH_BARANG int
AS
BEGIN
UPDATE [dbo].[product]
   SET 
      [jumlah_barang] = @JUMLAH_BARANG
      ,[tanggal] = getdate()
 WHERE kode_barang = @KODE_BARANG
END
GO
