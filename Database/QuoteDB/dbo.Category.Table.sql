USE [QuoteDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 31-10-2018 13:22:56 ******/
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 31-10-2018 13:22:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Title]) VALUES (1, N'Motivational')
INSERT [dbo].[Category] ([Id], [Title]) VALUES (2, N'Inspirational')
INSERT [dbo].[Category] ([Id], [Title]) VALUES (3, N'Leadership')
SET IDENTITY_INSERT [dbo].[Category] OFF
