USE [master]
GO
/****** Object:  Database [moj_novcanik]    Script Date: 05-Feb-20 1:24:15 PM ******/
CREATE DATABASE [moj_novcanik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'moj_novcanik', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\moj_novcanik.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'moj_novcanik_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\moj_novcanik_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [moj_novcanik] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [moj_novcanik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [moj_novcanik] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [moj_novcanik] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [moj_novcanik] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [moj_novcanik] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [moj_novcanik] SET ARITHABORT OFF 
GO
ALTER DATABASE [moj_novcanik] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [moj_novcanik] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [moj_novcanik] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [moj_novcanik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [moj_novcanik] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [moj_novcanik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [moj_novcanik] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [moj_novcanik] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [moj_novcanik] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [moj_novcanik] SET  DISABLE_BROKER 
GO
ALTER DATABASE [moj_novcanik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [moj_novcanik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [moj_novcanik] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [moj_novcanik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [moj_novcanik] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [moj_novcanik] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [moj_novcanik] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [moj_novcanik] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [moj_novcanik] SET  MULTI_USER 
GO
ALTER DATABASE [moj_novcanik] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [moj_novcanik] SET DB_CHAINING OFF 
GO
ALTER DATABASE [moj_novcanik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [moj_novcanik] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [moj_novcanik] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [moj_novcanik] SET QUERY_STORE = OFF
GO
USE [moj_novcanik]
GO
/****** Object:  Table [dbo].[kategorija_transakcije]    Script Date: 05-Feb-20 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategorija_transakcije](
	[kategorija_id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](100) NOT NULL,
	[arhivirana] [bit] NOT NULL,
 CONSTRAINT [PK_kategorija_transakcije] PRIMARY KEY CLUSTERED 
(
	[kategorija_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 05-Feb-20 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[korisnik_id] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[mesto_id] [int] NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[korisnik_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesto]    Script Date: 05-Feb-20 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesto](
	[mesto_id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Mesto] PRIMARY KEY CLUSTERED 
(
	[mesto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[novcanik]    Script Date: 05-Feb-20 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[novcanik](
	[novcanik_id] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](100) NOT NULL,
	[bilans] [decimal](18, 2) NOT NULL,
	[korisnik_id] [int] NOT NULL,
 CONSTRAINT [PK_novcanik] PRIMARY KEY CLUSTERED 
(
	[novcanik_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transakcija]    Script Date: 05-Feb-20 1:24:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transakcija](
	[transakcija_id] [int] IDENTITY(1,1) NOT NULL,
	[iznos] [decimal](18, 0) NOT NULL,
	[datum] [datetime] NOT NULL,
	[ponavljanje] [bit] NOT NULL,
	[vreme_ponavljanja] [datetime] NULL,
	[vrsta_transakcije] [bit] NOT NULL,
	[kategorija_id] [int] NOT NULL,
	[novcanik_id] [int] NOT NULL,
 CONSTRAINT [PK_transakcija] PRIMARY KEY CLUSTERED 
(
	[transakcija_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[novcanik] ADD  CONSTRAINT [DF_novcanik_bilans]  DEFAULT ((0)) FOR [bilans]
GO
ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD  CONSTRAINT [FK_Korisnik_Mesto] FOREIGN KEY([mesto_id])
REFERENCES [dbo].[Mesto] ([mesto_id])
GO
ALTER TABLE [dbo].[Korisnik] CHECK CONSTRAINT [FK_Korisnik_Mesto]
GO
ALTER TABLE [dbo].[novcanik]  WITH CHECK ADD  CONSTRAINT [FK_novcanik_Korisnik] FOREIGN KEY([korisnik_id])
REFERENCES [dbo].[Korisnik] ([korisnik_id])
GO
ALTER TABLE [dbo].[novcanik] CHECK CONSTRAINT [FK_novcanik_Korisnik]
GO
ALTER TABLE [dbo].[transakcija]  WITH CHECK ADD  CONSTRAINT [FK_transakcija_kategorija_transakcije] FOREIGN KEY([kategorija_id])
REFERENCES [dbo].[kategorija_transakcije] ([kategorija_id])
GO
ALTER TABLE [dbo].[transakcija] CHECK CONSTRAINT [FK_transakcija_kategorija_transakcije]
GO
ALTER TABLE [dbo].[transakcija]  WITH CHECK ADD  CONSTRAINT [FK_transakcija_novcanik] FOREIGN KEY([novcanik_id])
REFERENCES [dbo].[novcanik] ([novcanik_id])
GO
ALTER TABLE [dbo].[transakcija] CHECK CONSTRAINT [FK_transakcija_novcanik]
GO
USE [master]
GO
ALTER DATABASE [moj_novcanik] SET  READ_WRITE 
GO
