-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE INSERT_PRODUCT 
	-- Add the parameters for the stored procedure here
	@KODE_BARANG varchar(50),
	@NAMA_BARANG varchar(200), 
	@JUMLAH_BARANG int
AS
BEGIN
INSERT INTO [dbo].[product]
           ([nama_barang]
           ,[kode_barang]
           ,[jumlah_barang]
           ,[tanggal])
     VALUES
           (@NAMA_BARANG
           ,@KODE_BARANG
           ,@JUMLAH_BARANG
           ,getdate())
END
GO
