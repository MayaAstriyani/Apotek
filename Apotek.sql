USE [Apotek]
GO
/****** Object:  Table [dbo].[User_apotek]    Script Date: 11/19/2019 11:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User_apotek]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User_apotek](
	[id_user] [char](10) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User_apotek] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transaksi_apotek]    Script Date: 11/19/2019 11:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transaksi_apotek]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Transaksi_apotek](
	[no_transaksi] [char](15) NOT NULL,
	[tanggal_transaksi] [datetime] NOT NULL,
	[pembayaran] [int] NOT NULL,
	[kembalian] [int] NOT NULL,
	[pembayaran_pelanggan] [int] NOT NULL,
 CONSTRAINT [PK_Transaksi_apotek] PRIMARY KEY CLUSTERED 
(
	[no_transaksi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier_apotek]    Script Date: 11/19/2019 11:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Supplier_apotek]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Supplier_apotek](
	[kode_supplier] [char](10) NOT NULL,
	[nama_supplier] [varchar](50) NOT NULL,
	[alamat_supplier] [varchar](200) NOT NULL,
	[nohp_supplier] [varchar](13) NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[kode_supplier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Obat_apotek]    Script Date: 11/19/2019 11:15:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Obat_apotek]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Obat_apotek](
	[kode_obat] [char](10) NOT NULL,
	[nama_obat] [varchar](50) NOT NULL,
	[nama_supplier] [varchar](50) NULL,
	[satuan_obat] [varchar](20) NOT NULL,
	[harga_obat] [int] NOT NULL,
	[jumlah_stok] [int] NULL,
	[harga_modal] [int] NOT NULL,
 CONSTRAINT [PK_Obat_apotek] PRIMARY KEY CLUSTERED 
(
	[kode_obat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item_transaksi]    Script Date: 11/19/2019 11:15:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Item_transaksi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Item_transaksi](
	[kode_obat] [char](10) NOT NULL,
	[no_transaksi] [char](15) NOT NULL,
	[jumlah] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
