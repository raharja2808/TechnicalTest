USE [TechnicalTest]
GO

/****** Object:  Table [dbo].[product]    Script Date: 11/23/2023 11:29:31 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama_barang] [varchar](200) NOT NULL,
	[kode_barang] [varchar](50) NOT NULL,
	[jumlah_barang] [int] NOT NULL,
	[tanggal] [datetime] NOT NULL
) ON [PRIMARY]
GO


