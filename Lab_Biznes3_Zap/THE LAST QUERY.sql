USE [master]
GO
/****** Object:  Database [Session2_03_Perepelkin]    Script Date: 08.12.2022 21:15:43 ******/
CREATE DATABASE [Session2_03_Perepelkin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Session2_03_Perepelkin', FILENAME = N'D:\DataBases\Session2_03_Perepelkin.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Session2_03_Perepelkin_log', FILENAME = N'D:\DataBases\Session2_03_Perepelkin_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Session2_03_Perepelkin] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Session2_03_Perepelkin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ARITHABORT OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET RECOVERY FULL 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET  MULTI_USER 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Session2_03_Perepelkin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Session2_03_Perepelkin] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Session2_03_Perepelkin', N'ON'
GO
ALTER DATABASE [Session2_03_Perepelkin] SET QUERY_STORE = OFF
GO
USE [Session2_03_Perepelkin]
GO
/****** Object:  Table [dbo].[LastLogin]    Script Date: 08.12.2022 21:15:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LastLogin](
	[Id] [int] NOT NULL,
	[Email] [nvarchar](150) NULL,
	[Password] [nvarchar](50) NULL,
	[Remember] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SessionTime]    Script Date: 08.12.2022 21:15:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SessionTime](
	[Session_timeId] [int] IDENTITY(1,1) NOT NULL,
	[Id] [int] NOT NULL,
	[Date_login] [date] NOT NULL,
	[Login_time] [time](7) NOT NULL,
	[Logout_time] [time](7) NULL,
	[Time_spent] [time](7) NULL,
	[Unsuccessful_logout] [nvarchar](50) NULL,
 CONSTRAINT [PK_session] PRIMARY KEY CLUSTERED 
(
	[Session_timeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08.12.2022 21:15:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Role] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Birthdate] [date] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[LastLogin] ([Id], [Email], [Password], [Remember]) VALUES (1, N'j.doe@amonic.com', N'123', 1)
GO
SET IDENTITY_INSERT [dbo].[SessionTime] ON 

INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (1, 2, CAST(N'2022-11-12' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (2, 3, CAST(N'2022-11-13' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (3, 4, CAST(N'2022-11-14' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (4, 5, CAST(N'2022-11-15' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (5, 6, CAST(N'2022-11-16' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (6, 7, CAST(N'2022-11-17' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (7, 8, CAST(N'2022-11-18' AS Date), CAST(N'20:12:22' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:18' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (8, 2, CAST(N'2022-11-13' AS Date), CAST(N'20:12:00' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:40' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (9, 8, CAST(N'2022-11-20' AS Date), CAST(N'20:12:20' AS Time), CAST(N'20:12:40' AS Time), CAST(N'00:00:20' AS Time), N'Power outage')
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (10, 2, CAST(N'2022-12-08' AS Date), CAST(N'17:59:30' AS Time), NULL, NULL, N'Power outage')
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (11, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:19:22' AS Time), CAST(N'19:19:34' AS Time), CAST(N'00:00:12' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (12, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:23:52' AS Time), CAST(N'19:23:58' AS Time), CAST(N'00:00:06' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (13, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:32:10' AS Time), CAST(N'19:32:35' AS Time), CAST(N'00:00:25' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (14, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:40:36' AS Time), CAST(N'19:40:40' AS Time), CAST(N'00:00:04' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (15, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:44:14' AS Time), CAST(N'19:44:18' AS Time), CAST(N'00:00:04' AS Time), NULL)
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (16, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:46:44' AS Time), NULL, NULL, N'Power outage')
INSERT [dbo].[SessionTime] ([Session_timeId], [Id], [Date_login], [Login_time], [Logout_time], [Time_spent], [Unsuccessful_logout]) VALUES (17, 2, CAST(N'2022-12-08' AS Date), CAST(N'19:46:51' AS Time), CAST(N'19:46:54' AS Time), CAST(N'00:00:03' AS Time), NULL)
SET IDENTITY_INSERT [dbo].[SessionTime] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (1, N'Administrator', N'j.doe@amonic.com', N'123', N'John', N'Doe', N'Abu dhabi', CAST(N'1983-01-13' AS Date), 1)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (2, N'User', N'k.omar@amonic.com', N'4258', N'Karim', N'Omar', N'Riyadh', CAST(N'1980-03-19' AS Date), 1)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (3, N'User', N'h.saeed@amonic.com', N'2020', N'Hannan', N'Saeed', N'Cairo', CAST(N'1989-12-20' AS Date), 1)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (4, N'User', N'a.hobart@amonic.com', N'6996', N'Andrew', N'Hobart', N'Riyadh', CAST(N'1990-01-30' AS Date), 1)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (5, N'User', N'k.anderson@amonic.com', N'4570', N'Katrin', N'Anderson', N'Riyadh', CAST(N'1992-11-10' AS Date), 0)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (6, N'User', N'h.wyrick@amonic.com', N'1199', N'Hava', N'Wyrick', N'Abu dhabi', CAST(N'1988-08-08' AS Date), 1)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (7, N'User', N'marie.horn@amonic.com', N'55555', N'Marie', N'Horn', N'Bahrain', CAST(N'1981-06-04' AS Date), 0)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (8, N'User', N'm.osteen@amonic.com', N'9800', N'Milagros', N'Osteen', N'Abu dhabi', CAST(N'1991-03-02' AS Date), 1)
INSERT [dbo].[Users] ([Id], [User_Role], [Email], [Password], [FirstName], [LastName], [Title], [Birthdate], [Active]) VALUES (9, N'Administrator', N'Zond@z', N'808', N'Zond', N'MotherFucker', N'Cairo', CAST(N'2005-01-06' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[SessionTime]  WITH CHECK ADD  CONSTRAINT [FK_Session] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[SessionTime] CHECK CONSTRAINT [FK_Session]
GO
USE [master]
GO
ALTER DATABASE [Session2_03_Perepelkin] SET  READ_WRITE 
GO
