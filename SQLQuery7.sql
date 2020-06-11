USE [master]
GO
/****** Object:  Database [CROS]    Script Date: 08/06/2020 04:49:20 PM ******/
CREATE DATABASE [CROS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CROS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CROS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CROS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CROS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CROS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CROS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CROS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CROS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CROS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CROS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CROS] SET ARITHABORT OFF 
GO
ALTER DATABASE [CROS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CROS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CROS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CROS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CROS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CROS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CROS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CROS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CROS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CROS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CROS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CROS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CROS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CROS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CROS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CROS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CROS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CROS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CROS] SET  MULTI_USER 
GO
ALTER DATABASE [CROS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CROS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CROS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CROS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CROS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CROS] SET QUERY_STORE = OFF
GO
USE [CROS]
GO
/****** Object:  Table [dbo].[TblCity]    Script Date: 08/06/2020 04:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](100) NULL,
 CONSTRAINT [PK_TblCity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEmployee]    Script Date: 08/06/2020 04:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEmployee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[DOB] [date] NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_TblEmployee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblCity] ON 
GO
INSERT [dbo].[TblCity] ([id], [CityName]) VALUES (1, N'Delhi')
GO
INSERT [dbo].[TblCity] ([id], [CityName]) VALUES (2, N'Mumbai')
GO
INSERT [dbo].[TblCity] ([id], [CityName]) VALUES (3, N'Navi-Mumbai')
GO
INSERT [dbo].[TblCity] ([id], [CityName]) VALUES (4, N'New-Delhi')
GO
SET IDENTITY_INSERT [dbo].[TblCity] OFF
GO
SET IDENTITY_INSERT [dbo].[TblEmployee] ON 
GO
INSERT [dbo].[TblEmployee] ([EmployeeId], [FirstName], [LastName], [DOB], [CityId]) VALUES (3, N'abc', N'abc', CAST(N'2020-06-19' AS Date), 1)
GO
INSERT [dbo].[TblEmployee] ([EmployeeId], [FirstName], [LastName], [DOB], [CityId]) VALUES (4, N'mayur', N'test', CAST(N'2020-03-05' AS Date), 1)
GO
INSERT [dbo].[TblEmployee] ([EmployeeId], [FirstName], [LastName], [DOB], [CityId]) VALUES (5, N'mayur', N'tes', CAST(N'2020-03-05' AS Date), 1)
GO
INSERT [dbo].[TblEmployee] ([EmployeeId], [FirstName], [LastName], [DOB], [CityId]) VALUES (6, N'Vishal', N'Shinde', CAST(N'2018-01-05' AS Date), 1)
GO
INSERT [dbo].[TblEmployee] ([EmployeeId], [FirstName], [LastName], [DOB], [CityId]) VALUES (7, N'Bhupendra', N'Tiwari', CAST(N'1985-01-01' AS Date), 2)
GO
INSERT [dbo].[TblEmployee] ([EmployeeId], [FirstName], [LastName], [DOB], [CityId]) VALUES (8, N'mayur', N'shinde', CAST(N'2012-03-01' AS Date), 3)
GO
SET IDENTITY_INSERT [dbo].[TblEmployee] OFF
GO
/****** Object:  StoredProcedure [dbo].[spAddUpdateEmployee]    Script Date: 08/06/2020 04:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE procedure  [dbo].[spAddUpdateEmployee]  --spAddUpdateEmployee 0,'assb','sdd','2020-06-06',1
 @EmployeeId varchar(100),
 @FirstName varchar(100),
 @LastName varchar(100),
 @DOB varchar(100),
 @CityId varchar(100) 
 as
 begin
		if exists(select 1 from TblEmployee where EmployeeId= @EmployeeId)
		begin
				update	TblEmployee 
				set		FirstName=@FirstName,
						LastName = @LastName,
						DOB =cast( @DOB as date),
						CityId = cast(@CityId as int)
				where	EmployeeId=  cast( @EmployeeId as int) ;
		end
		else 
		begin
			insert into TblEmployee(FirstName,LastName,DOB,CityId)
			Values(@FirstName,@LastName,cast( @DOB as date),cast(@CityId as int));
			set @EmployeeId = @@IDENTITY ; 
		end

		select EmployeeId,FirstName,LastName,cast(DOB as datetime) as DOB,CityId  from TblEmployee where	EmployeeId= @EmployeeId
 end

  
GO
USE [master]
GO
ALTER DATABASE [CROS] SET  READ_WRITE 
GO
