USE [master]
GO
/****** Object:  Database [GerenciadorFinancasPessoaisBD]    Script Date: 31/03/2023 20:16:25 ******/
CREATE DATABASE [GerenciadorFinancasPessoaisBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinancasPessoaisBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\FinancasPessoaisBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinancasPessoaisBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\FinancasPessoaisBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GerenciadorFinancasPessoaisBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET  MULTI_USER 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET QUERY_STORE = OFF
GO
USE [GerenciadorFinancasPessoaisBD]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] NOT NULL,
	[Descricao] [varchar](200) NULL,
	[IdTipoMovimento] [int] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Despesas]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Despesas](
	[Id] [int] NOT NULL,
	[DataVencimento] [date] NULL,
	[IdCategoriaDespesas] [int] NULL,
	[Descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Despesas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Investimentos]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investimentos](
	[Id] [int] NOT NULL,
	[IdCategoria] [int] NULL,
	[Descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Investimentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovimentoCaixa]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimentoCaixa](
	[Id] [int] NOT NULL,
	[Data] [datetime] NULL,
	[valor] [float] NULL,
	[IdTipoMovimento] [int] NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_MovimentoCaixa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receitas]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receitas](
	[Id] [int] NOT NULL,
	[IdCategoriaReceita] [int] NULL,
	[Descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Receitas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMovimento]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMovimento](
	[Id] [int] NOT NULL,
	[Descricao] [varchar](100) NULL,
 CONSTRAINT [PK_TipoMovimento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 31/03/2023 20:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] NOT NULL,
	[Nome] [varchar](100) NULL,
	[CPF] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Login] [varchar](50) NULL,
	[Senha] [varchar](16) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categorias]  WITH CHECK ADD  CONSTRAINT [FK_Categorias_TipoMovimento] FOREIGN KEY([IdTipoMovimento])
REFERENCES [dbo].[TipoMovimento] ([Id])
GO
ALTER TABLE [dbo].[Categorias] CHECK CONSTRAINT [FK_Categorias_TipoMovimento]
GO
ALTER TABLE [dbo].[Despesas]  WITH CHECK ADD  CONSTRAINT [FK_Despesas_Categorias] FOREIGN KEY([IdCategoriaDespesas])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Despesas] CHECK CONSTRAINT [FK_Despesas_Categorias]
GO
ALTER TABLE [dbo].[Investimentos]  WITH CHECK ADD  CONSTRAINT [FK_Investimentos_Categorias1] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Investimentos] CHECK CONSTRAINT [FK_Investimentos_Categorias1]
GO
ALTER TABLE [dbo].[MovimentoCaixa]  WITH CHECK ADD  CONSTRAINT [FK_MovimentoCaixa_TipoMovimento] FOREIGN KEY([IdTipoMovimento])
REFERENCES [dbo].[TipoMovimento] ([Id])
GO
ALTER TABLE [dbo].[MovimentoCaixa] CHECK CONSTRAINT [FK_MovimentoCaixa_TipoMovimento]
GO
ALTER TABLE [dbo].[MovimentoCaixa]  WITH CHECK ADD  CONSTRAINT [FK_MovimentoCaixa_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[MovimentoCaixa] CHECK CONSTRAINT [FK_MovimentoCaixa_Usuario]
GO
ALTER TABLE [dbo].[Receitas]  WITH CHECK ADD  CONSTRAINT [FK_Receitas_Categorias] FOREIGN KEY([IdCategoriaReceita])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Receitas] CHECK CONSTRAINT [FK_Receitas_Categorias]
GO
USE [master]
GO
ALTER DATABASE [GerenciadorFinancasPessoaisBD] SET  READ_WRITE 
GO
