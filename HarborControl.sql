USE [master]
GO
/****** Object:  Database [DecisionIncAssessment]    Script Date: 2020/11/27 10:53:23 ******/
CREATE DATABASE [DecisionIncAssessment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DecisionIncAssessment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.JUANDREPC\MSSQL\DATA\DecisionIncAssessment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DecisionIncAssessment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.JUANDREPC\MSSQL\DATA\DecisionIncAssessment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DecisionIncAssessment] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DecisionIncAssessment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DecisionIncAssessment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET ARITHABORT OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DecisionIncAssessment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DecisionIncAssessment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DecisionIncAssessment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DecisionIncAssessment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET RECOVERY FULL 
GO
ALTER DATABASE [DecisionIncAssessment] SET  MULTI_USER 
GO
ALTER DATABASE [DecisionIncAssessment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DecisionIncAssessment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DecisionIncAssessment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DecisionIncAssessment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DecisionIncAssessment] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DecisionIncAssessment', N'ON'
GO
ALTER DATABASE [DecisionIncAssessment] SET QUERY_STORE = OFF
GO
USE [DecisionIncAssessment]
GO
/****** Object:  Table [dbo].[WindDetails]    Script Date: 2020/11/27 10:53:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WindDetails](
	[weatherID] [int] IDENTITY(100,1) NOT NULL,
	[WindSpeed] [float] NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_WindDetails] PRIMARY KEY CLUSTERED 
(
	[weatherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WindDetails] ON 

INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (100, 7.7, CAST(N'2020-11-26T13:32:38.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (101, 7.7, CAST(N'2020-11-26T13:32:58.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (102, 7.2, CAST(N'2020-11-26T14:56:59.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (103, 7.2, CAST(N'2020-11-26T14:59:58.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (104, 7.2, CAST(N'2020-11-26T15:00:55.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (105, 7.2, CAST(N'2020-11-26T15:01:41.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (106, 7.2, CAST(N'2020-11-26T15:03:14.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (107, 7.2, CAST(N'2020-11-26T15:04:44.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (108, 7.2, CAST(N'2020-11-26T15:05:31.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (109, 7.2, CAST(N'2020-11-26T15:07:15.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (110, 7.2, CAST(N'2020-11-26T15:07:56.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (111, 1.5, CAST(N'2020-11-26T20:09:54.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (112, 1.5, CAST(N'2020-11-26T20:11:14.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (113, 2.1, CAST(N'2020-11-26T20:20:47.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (114, 2.1, CAST(N'2020-11-26T20:35:48.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (115, 2.1, CAST(N'2020-11-26T20:37:24.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (116, 2.1, CAST(N'2020-11-26T20:43:43.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (117, 2.1, CAST(N'2020-11-26T20:45:15.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (118, 2.1, CAST(N'2020-11-26T20:46:44.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (119, 2.1, CAST(N'2020-11-26T20:48:10.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (120, 2.1, CAST(N'2020-11-26T20:50:39.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (121, 2.1, CAST(N'2020-11-26T20:51:23.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (122, 2.1, CAST(N'2020-11-26T20:52:07.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (123, 2.1, CAST(N'2020-11-26T20:54:59.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (124, 2.1, CAST(N'2020-11-26T20:56:11.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (125, 2.1, CAST(N'2020-11-26T20:59:29.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (126, 2.1, CAST(N'2020-11-26T21:01:30.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (127, 2.1, CAST(N'2020-11-26T21:02:58.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (128, 2.1, CAST(N'2020-11-26T21:03:20.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (129, 2.1, CAST(N'2020-11-26T21:03:33.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (130, 2.1, CAST(N'2020-11-26T21:07:15.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (131, 2.1, CAST(N'2020-11-26T21:08:37.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (132, 6.7, CAST(N'2020-11-26T21:14:33.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (133, 6.7, CAST(N'2020-11-26T21:15:45.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (134, 6.7, CAST(N'2020-11-26T21:19:58.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (135, 6.7, CAST(N'2020-11-26T21:23:22.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (136, 6.7, CAST(N'2020-11-26T21:26:08.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (137, 6.7, CAST(N'2020-11-26T21:30:59.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (138, 6.7, CAST(N'2020-11-26T21:31:40.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (139, 6.7, CAST(N'2020-11-26T21:32:31.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (140, 6.7, CAST(N'2020-11-26T21:32:49.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (141, 6.7, CAST(N'2020-11-26T21:33:15.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (142, 6.7, CAST(N'2020-11-26T21:39:07.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (143, 6.7, CAST(N'2020-11-26T21:39:47.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (144, 6.7, CAST(N'2020-11-26T21:42:29.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (145, 6.7, CAST(N'2020-11-26T21:45:11.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (146, 6.7, CAST(N'2020-11-26T21:46:04.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (147, 6.7, CAST(N'2020-11-26T21:50:49.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (148, 6.7, CAST(N'2020-11-26T21:55:50.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (149, 6.7, CAST(N'2020-11-26T22:00:52.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (150, 6.7, CAST(N'2020-11-26T22:18:33.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (151, 6.7, CAST(N'2020-11-26T22:18:46.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (152, 6.7, CAST(N'2020-11-26T22:19:25.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (153, 6.7, CAST(N'2020-11-26T22:20:39.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (154, 6.7, CAST(N'2020-11-26T22:20:48.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (155, 6.7, CAST(N'2020-11-26T22:21:45.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (156, 6.7, CAST(N'2020-11-26T22:22:04.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (157, 6.7, CAST(N'2020-11-26T22:23:35.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (158, 6.7, CAST(N'2020-11-26T22:23:54.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (159, 6.7, CAST(N'2020-11-26T22:24:24.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (160, 4.6, CAST(N'2020-11-27T10:43:31.000' AS DateTime))
INSERT [dbo].[WindDetails] ([weatherID], [WindSpeed], [Time]) VALUES (161, 4.6, CAST(N'2020-11-27T10:44:03.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[WindDetails] OFF
USE [master]
GO
ALTER DATABASE [DecisionIncAssessment] SET  READ_WRITE 
GO
