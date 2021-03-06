USE [master]
GO
/****** Object:  Database [kkt_base]    Script Date: 26.11.2017 17:42:00 ******/
CREATE DATABASE [kkt_base]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kkt_base', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQL2012\MSSQL\DATA\kkt_base.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'kkt_base_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQL2012\MSSQL\DATA\kkt_base_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [kkt_base] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kkt_base].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kkt_base] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kkt_base] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kkt_base] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kkt_base] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kkt_base] SET ARITHABORT OFF 
GO
ALTER DATABASE [kkt_base] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kkt_base] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [kkt_base] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kkt_base] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kkt_base] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kkt_base] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kkt_base] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kkt_base] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kkt_base] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kkt_base] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kkt_base] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kkt_base] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kkt_base] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kkt_base] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kkt_base] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kkt_base] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kkt_base] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kkt_base] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kkt_base] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [kkt_base] SET  MULTI_USER 
GO
ALTER DATABASE [kkt_base] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kkt_base] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kkt_base] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kkt_base] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [kkt_base]
GO
/****** Object:  User [kkt-user]    Script Date: 26.11.2017 17:42:00 ******/
CREATE USER [kkt-user] FOR LOGIN [kkt-user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [kkt-user]
GO
/****** Object:  Table [dbo].[doc_head]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doc_head](
	[id] [int] IDENTITY(85,1) NOT NULL,
	[number] [int] NOT NULL,
	[year] [smallint] NOT NULL,
	[data_start] [datetime] NULL,
	[data_end] [datetime] NULL,
	[unactive_client] [bit] NULL,
	[name] [nvarchar](255) NOT NULL,
	[inn] [bigint] NULL,
	[kpp] [bigint] NULL,
	[address] [nvarchar](255) NULL,
	[phone] [nvarchar](50) NULL,
	[fax] [nvarchar](50) NULL,
	[member] [nvarchar](255) NULL,
	[member base] [nvarchar](255) NULL,
	[ogrn] [nvarchar](100) NULL,
	[bank] [nvarchar](255) NULL,
	[bank_account] [nvarchar](100) NULL,
	[bank_account_cor] [nvarchar](100) NULL,
	[bik] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[payment_status_id] [int] NULL,
	[period] [nvarchar](100) NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK__doc_head__0000000000000251] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__doc_head__0000000000000256] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doc_kkm]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doc_kkm](
	[id] [int] IDENTITY(73,1) NOT NULL,
	[location] [nvarchar](250) NULL,
	[model_id] [int] NULL,
	[master_id] [int] NULL,
	[number] [nvarchar](100) NULL,
	[registration_number] [nvarchar](100) NULL,
	[data_release] [datetime] NULL,
	[data_registration] [datetime] NULL,
	[fn_num_id] [int] NULL,
	[data_activation] [datetime] NULL,
	[data_change] [datetime] NULL,
	[ofd_id] [int] NULL,
	[login] [nvarchar](100) NULL,
	[password] [nvarchar](100) NULL,
	[mp_id] [int] NULL,
	[description] [nvarchar](255) NULL,
	[doc_id] [int] NOT NULL,
	[service_type_id] [int] NULL,
	[price_id] [int] NULL,
	[unactive_kkm] [bit] NULL,
 CONSTRAINT [PK_doc_kkm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__doc_kkm__0000000000000211] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fn_mp_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fn_mp_dir](
	[id] [int] IDENTITY(23,1) NOT NULL,
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[kkm_id] [int] NULL,
 CONSTRAINT [PK_fn_mp_dir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__fn_mp_dir__00000000000001CD] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fn_number_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fn_number_dir](
	[id] [int] IDENTITY(16,1) NOT NULL,
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[kkm_id] [int] NULL,
 CONSTRAINT [PK_fn_number_dir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__fn_number_dir__00000000000001BB] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[masters_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[masters_dir](
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[id] [int] IDENTITY(12,1) NOT NULL,
 CONSTRAINT [PK__masters_dir__00000000000000D9] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__masters_dir__00000000000000D4] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[model_kkm_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[model_kkm_dir](
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[id] [int] IDENTITY(10,1) NOT NULL,
 CONSTRAINT [PK__model_kkm_dir__00000000000000EC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__model_kkm_dir__00000000000000E7] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ofd_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ofd_dir](
	[id] [int] IDENTITY(5,1) NOT NULL,
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
 CONSTRAINT [PK_ofd_dir] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__ofd_dir__00000000000001E5] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[payment_status_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment_status_dir](
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[id] [int] IDENTITY(13,1) NOT NULL,
 CONSTRAINT [PK__payment_status_dir__0000000000000103] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__payment_status_dir__00000000000000FE] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[price_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[price_dir](
	[value] [numeric](6, 2) NOT NULL,
	[description] [nvarchar](100) NULL,
	[id] [int] IDENTITY(9,1) NOT NULL,
 CONSTRAINT [PK__price_dir__0000000000000116] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__price_dir__0000000000000111] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[service_type_dir]    Script Date: 26.11.2017 17:42:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service_type_dir](
	[value] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NULL,
	[id] [int] IDENTITY(9,1) NOT NULL,
 CONSTRAINT [PK__service_type_dir__000000000000012D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__service_type_dir__0000000000000128] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[doc_head]  WITH CHECK ADD  CONSTRAINT [pay_fk] FOREIGN KEY([payment_status_id])
REFERENCES [dbo].[payment_status_dir] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[doc_head] CHECK CONSTRAINT [pay_fk]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [doc_head_ref] FOREIGN KEY([doc_id])
REFERENCES [dbo].[doc_head] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [doc_head_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [fn_num_ref] FOREIGN KEY([fn_num_id])
REFERENCES [dbo].[fn_number_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [fn_num_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [master_ref] FOREIGN KEY([master_id])
REFERENCES [dbo].[masters_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [master_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [model_kkm_ref] FOREIGN KEY([model_id])
REFERENCES [dbo].[model_kkm_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [model_kkm_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [mp_ref] FOREIGN KEY([mp_id])
REFERENCES [dbo].[fn_mp_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [mp_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [ofd_ref] FOREIGN KEY([ofd_id])
REFERENCES [dbo].[ofd_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [ofd_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [price_ref] FOREIGN KEY([price_id])
REFERENCES [dbo].[price_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [price_ref]
GO
ALTER TABLE [dbo].[doc_kkm]  WITH CHECK ADD  CONSTRAINT [service_type_ref] FOREIGN KEY([service_type_id])
REFERENCES [dbo].[service_type_dir] ([id])
GO
ALTER TABLE [dbo].[doc_kkm] CHECK CONSTRAINT [service_type_ref]
GO
USE [master]
GO
ALTER DATABASE [kkt_base] SET  READ_WRITE 
GO
