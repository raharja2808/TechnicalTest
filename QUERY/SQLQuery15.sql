USE [TechnicalTest]
GO
/****** Object:  StoredProcedure [dbo].[SEARCH_PRODUCT]    Script Date: 11/23/2023 12:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UPDATE_PRODUCT] 
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
