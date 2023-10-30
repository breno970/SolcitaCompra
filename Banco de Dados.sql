USE [master]
GO
/****** Object:  Database [dbControleEstoque]    Script Date: 30/10/2023 04:32:07 ******/
CREATE DATABASE [dbControleEstoque]
 
CREATE TABLE [dbo].[Fornecedores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[CEP] [varchar](10) NOT NULL,
	[Rua] [varchar](60) NOT NULL,
	[Numero] [varchar](60) NULL,
	[Bairro] [varchar](60) NOT NULL,
	[Cidade] [varchar](60) NOT NULL,
	[Estado] [varchar](60) NOT NULL,
	[Complemento] [text] NULL,
	[Email] [varchar](70) NOT NULL,
	[CNPJ] [varchar](20) NOT NULL,
	[IncricaoEstadual] [varchar](20) NOT NULL,
	[IncricaoMunicipal] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Fornecedores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicos]    Script Date: 30/10/2023 04:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdFornecedor] [int] NOT NULL,
	[servico] [varchar](80) NOT NULL,
	[descricao] [varchar](max) NOT NULL,
	[prazo] [datetime] NOT NULL,
 CONSTRAINT [PK_Servicos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_ServicoFornecedor]    Script Date: 30/10/2023 04:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_ServicoFornecedor]
AS

SELECT f.ID, f.Nome, s.servico,s.descricao,s.prazo FROM Servicos S
inner join Fornecedores F on F.ID = S.IdFornecedor
GO
/****** Object:  Table [dbo].[ControleProduto]    Script Date: 30/10/2023 04:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControleProduto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NOT NULL,
	[entrada] [datetime] NOT NULL,
	[saida] [datetime] NOT NULL,
 CONSTRAINT [PK_ControleProduto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 30/10/2023 04:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Produto] [varchar](100) NOT NULL,
	[Descricao] [varchar](max) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[ValorQtd] [money] NOT NULL,
	[QtdMin] [varchar](100) NOT NULL,
	[QtdEstoque] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 30/10/2023 04:32:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Departamento] [varchar](100) NOT NULL,
	[Matricula] [varchar](20) NOT NULL,
	[Email] [varchar](70) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ControleProduto]  WITH CHECK ADD  CONSTRAINT [FK_ControleProdutos] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produtos] ([ID])
GO
ALTER TABLE [dbo].[ControleProduto] CHECK CONSTRAINT [FK_ControleProdutos]
GO
ALTER TABLE [dbo].[Servicos]  WITH CHECK ADD  CONSTRAINT [FK_ServicosFornecedores] FOREIGN KEY([IdFornecedor])
REFERENCES [dbo].[Fornecedores] ([ID])
GO
ALTER TABLE [dbo].[Servicos] CHECK CONSTRAINT [FK_ServicosFornecedores]
GO
USE [master]
GO
ALTER DATABASE [dbControleEstoque] SET  READ_WRITE 
GO
