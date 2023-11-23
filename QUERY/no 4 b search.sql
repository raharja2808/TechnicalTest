USE [TechnicalTest]
GO

ALTER PROCEDURE SEARCH_PRODUCT 
	-- Add the parameters for the stored procedure here
	@KODE_BARANG varchar(50)
AS
BEGIN
SELECT [id]
      ,[nama_barang]
      ,[kode_barang]
      ,[jumlah_barang]
      ,[tanggal]
  FROM [dbo].[product]
  WHERE kode_barang = @KODE_BARANG
END
GO
