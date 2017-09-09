USE [VWallet]
GO
/****** Object:  Table [dbo].[LIQ_CAB]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIQ_CAB](
	[COD_TRX] [numeric](10, 0) NOT NULL,
	[FEC_TRX] [datetime] NOT NULL,
	[COD_CLI] [nvarchar](10) NOT NULL,
	[IMP_TRX] [numeric](12, 2) NULL,
 CONSTRAINT [PK_LIQ_CAB] PRIMARY KEY CLUSTERED 
(
	[COD_TRX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LIQ_DET]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIQ_DET](
	[COD_TRX] [numeric](10, 0) NOT NULL,
	[NUM_ITEM] [numeric](2, 0) NOT NULL,
	[COD_CLI_ORI] [nvarchar](10) NULL,
	[COD_CLI_DES] [nvarchar](10) NULL,
	[TIP_OPE] [nvarchar](1) NULL,
	[COD_OPE] [nvarchar](2) NULL,
	[IMP_TRX] [numeric](12, 2) NULL,
 CONSTRAINT [PK_LIQ_DET] PRIMARY KEY CLUSTERED 
(
	[COD_TRX] ASC,
	[NUM_ITEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[log_perdidas]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log_perdidas](
	[id] [int] NULL,
	[onzas] [int] NULL,
	[motivo] [nchar](10) NULL,
	[idcontenedor] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAE_CLIENTES]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAE_CLIENTES](
	[COD_CLI] [nvarchar](10) NOT NULL,
	[TIP_CLI] [nvarchar](1) NULL,
	[TIP_DOC_IDENT] [nvarchar](1) NULL,
	[NRO_DOC_IDENT] [nvarchar](20) NULL,
	[DES_RAZON_SOCIAL] [nvarchar](200) NULL,
	[APE_PATERNO] [nvarchar](100) NULL,
	[APE_MATERNO] [nvarchar](100) NULL,
	[NOM_CLIENTE] [nvarchar](100) NULL,
	[TIP_SEXO] [nvarchar](1) NULL,
	[DES_DIRECCION] [nvarchar](150) NULL,
	[COD_UBIGEO] [nvarchar](6) NULL,
	[NUM_TELEFONO] [nvarchar](10) NULL,
	[DES_EMAIL] [nvarchar](100) NULL,
	[NUM_CUENTA] [nvarchar](15) NULL,
	[IMP_SALDO] [decimal](18, 2) NULL,
 CONSTRAINT [PK_MAE_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[COD_CLI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAE_OPE]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAE_OPE](
	[COD_OPE] [nvarchar](2) NOT NULL,
	[DES_OPE] [nvarchar](100) NULL,
	[COD_OPE_REL] [nvarchar](2) NULL,
 CONSTRAINT [PK_MAE_OPE] PRIMARY KEY CLUSTERED 
(
	[COD_OPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAE_UBIGEO]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAE_UBIGEO](
	[COD_UBIGEO] [nvarchar](6) NOT NULL,
	[DES_UBIGEO] [nvarchar](100) NULL,
 CONSTRAINT [PK_MAE_UBIGEO] PRIMARY KEY CLUSTERED 
(
	[COD_UBIGEO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MAE_USUARIO]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAE_USUARIO](
	[COD_USR] [nvarchar](8) NOT NULL,
	[DES_USR] [nvarchar](500) NULL,
	[TIP_USR] [nvarchar](1) NOT NULL,
	[DES_PSSW] [nvarchar](50) NOT NULL,
	[COD_CLI] [nvarchar](10) NULL,
	[COD_EST] [bit] NULL,
 CONSTRAINT [PK_MAE_USUARIO] PRIMARY KEY CLUSTERED 
(
	[COD_USR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_asesor]    Script Date: 09/09/2017 14:33:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_asesor](
	[nu_dni] [int] NULL,
	[tx_nombre] [varchar](50) NULL,
	[tx_estado] [varchar](50) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[MAE_USUARIO] ADD  CONSTRAINT [DF_MAE_USUARIO_TIP_USR]  DEFAULT (N'U') FOR [TIP_USR]
GO
ALTER TABLE [dbo].[LIQ_CAB]  WITH CHECK ADD  CONSTRAINT [LIQ_CAB_MAE_CLIENTES_FK] FOREIGN KEY([COD_CLI])
REFERENCES [dbo].[MAE_CLIENTES] ([COD_CLI])
GO
ALTER TABLE [dbo].[LIQ_CAB] CHECK CONSTRAINT [LIQ_CAB_MAE_CLIENTES_FK]
GO
ALTER TABLE [dbo].[LIQ_DET]  WITH CHECK ADD  CONSTRAINT [LIQ_DET_LIQ_DET_FK] FOREIGN KEY([COD_TRX])
REFERENCES [dbo].[LIQ_CAB] ([COD_TRX])
GO
ALTER TABLE [dbo].[LIQ_DET] CHECK CONSTRAINT [LIQ_DET_LIQ_DET_FK]
GO
ALTER TABLE [dbo].[LIQ_DET]  WITH CHECK ADD  CONSTRAINT [LIQ_DET_MAE_OPE_FK] FOREIGN KEY([COD_OPE])
REFERENCES [dbo].[MAE_OPE] ([COD_OPE])
GO
ALTER TABLE [dbo].[LIQ_DET] CHECK CONSTRAINT [LIQ_DET_MAE_OPE_FK]
GO
ALTER TABLE [dbo].[MAE_OPE]  WITH CHECK ADD  CONSTRAINT [MAE_OPE_MAE_OPE_FK] FOREIGN KEY([COD_OPE_REL])
REFERENCES [dbo].[MAE_OPE] ([COD_OPE])
GO
ALTER TABLE [dbo].[MAE_OPE] CHECK CONSTRAINT [MAE_OPE_MAE_OPE_FK]
GO
ALTER TABLE [dbo].[MAE_USUARIO]  WITH CHECK ADD  CONSTRAINT [MAE_USUARIO_MAE_CLIENTES_FK] FOREIGN KEY([COD_CLI])
REFERENCES [dbo].[MAE_CLIENTES] ([COD_CLI])
GO
ALTER TABLE [dbo].[MAE_USUARIO] CHECK CONSTRAINT [MAE_USUARIO_MAE_CLIENTES_FK]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Transaccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_CAB', @level2type=N'COLUMN',@level2name=N'COD_TRX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha / Hora de la Transaccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_CAB', @level2type=N'COLUMN',@level2name=N'FEC_TRX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_CAB', @level2type=N'COLUMN',@level2name=N'COD_CLI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Importe de la Transaccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_CAB', @level2type=N'COLUMN',@level2name=N'IMP_TRX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla de Transacciones - Cabecera' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_CAB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Transaccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'COD_TRX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Item de la Transaccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'NUM_ITEM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Cliente Origen' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'COD_CLI_ORI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Cliente Destino' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'COD_CLI_DES'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Operacion ( E = Entrada  /  S = Salida )' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'TIP_OPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Operacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'COD_OPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Importe de la Transaccion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET', @level2type=N'COLUMN',@level2name=N'IMP_TRX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla del Detalle de Liquidacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LIQ_DET'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'COD_CLI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Cliente ( P = Persona   E = Establecimiento )' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'TIP_CLI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Documento de Identidad' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'TIP_DOC_IDENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de documento de identidad' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'NRO_DOC_IDENT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Razon Social' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'DES_RAZON_SOCIAL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido Paterno' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'APE_PATERNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellido Materno' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'APE_MATERNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombres del Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'NOM_CLIENTE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Sexo ( M = Masculino   F = Femenino )' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'TIP_SEXO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Direccion del Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'DES_DIRECCION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Ubigeo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'COD_UBIGEO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Numero de Celular' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'NUM_TELEFONO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Correo Electronico del Cliente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'DES_EMAIL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Saldo de la Cuenta' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES', @level2type=N'COLUMN',@level2name=N'IMP_SALDO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla de Clientes' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_CLIENTES'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Operaciones' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_OPE', @level2type=N'COLUMN',@level2name=N'COD_OPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion de Operacion' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_OPE', @level2type=N'COLUMN',@level2name=N'DES_OPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Maestro de Transacciones' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_OPE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de Ubigeo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_UBIGEO', @level2type=N'COLUMN',@level2name=N'COD_UBIGEO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Descripcion de Ubigeo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_UBIGEO', @level2type=N'COLUMN',@level2name=N'DES_UBIGEO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla de Ubigeos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_UBIGEO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Codigo de usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_USUARIO', @level2type=N'COLUMN',@level2name=N'COD_USR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre del Usuario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_USUARIO', @level2type=N'COLUMN',@level2name=N'DES_USR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tipo de Usuario ( U = Usuario   A = Administrador )' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_USUARIO', @level2type=N'COLUMN',@level2name=N'TIP_USR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Password' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_USUARIO', @level2type=N'COLUMN',@level2name=N'DES_PSSW'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla de Usuarios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MAE_USUARIO'
GO
