USE [QuoteDB]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 31-10-2018 13:22:56 ******/
DROP TABLE [dbo].[Author]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 31-10-2018 13:22:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([Id], [Name]) VALUES (1, N'Abigail Van Buren')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (2, N'Abraham Lincoln')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (3, N'Albert Einstein')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (4, N'Alice Walker')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (5, N'Amelia Earhart')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (6, N'Anais Nin')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (7, N'Ancient Indian Proverb')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (8, N'Ann Landers')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (9, N'Anne Frank')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (10, N'Aristotle')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (11, N'Arthur Ashe')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (12, N'Audrey Hepburn')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (13, N'Ayn Rand')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (14, N'Babe Ruth')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (15, N'Benjamin Franklin')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (16, N'Beverly Sills')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (17, N'Bill Cosby')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (18, N'Bob Dylan')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (19, N'Booker T. Washington')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (20, N'Buddha')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (21, N'Charles Swindoll')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (22, N'Chinese Proverb')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (23, N'Christopher Columbus')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (24, N'Confucius')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (25, N'Dalai Lama')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (26, N'Earl Nightingale')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (27, N'Eleanor Roosevelt')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (28, N'Erica Jong')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (29, N'Erma Bombeck')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (30, N'Farrah Gray')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (31, N'Florence Nightingale')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (32, N'Frank Sinatra')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (33, N'George Addair')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (34, N'George Eliot')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (35, N'Gloria Steinem')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (36, N'Grandma Moses')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (37, N'Helen Keller')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (38, N'Henry David Thoreau')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (39, N'Henry Ford')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (40, N'Jamie Paolinetti')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (41, N'Japanese Proverb')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (42, N'Jesse Owens')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (43, N'Jesus')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (44, N'Jim Rohn')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (45, N'Johann Wolfgang von Goethe')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (46, N'John Lennon')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (47, N'Joshua J. Marine')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (48, N'Kevin Kruse')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (49, N'Lao Tzu')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (50, N'Latin Proverb')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (51, N'Leonardo da Vinci')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (52, N'Les Brown')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (53, N'Mae Jemison')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (54, N'Maimonides')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (55, N'Marie Curie')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (56, N'Mark Twain')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (57, N'Martin Luther King Jr.')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (58, N'Maya Angelou')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (59, N'Michael Jordan')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (60, N'Napoleon Hill')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (61, N'Norman Vaughan')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (62, N'Norman Vincent Peale')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (63, N'Oprah Winfrey')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (64, N'Pablo Picasso')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (65, N'Plato')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (66, N'Ralph Waldo Emerson')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (67, N'Ravindra Gaikawad')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (68, N'Roger Staubach')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (69, N'Rosa Parks')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (70, N'Sheryl Sandberg')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (71, N'Sir Claus Moser')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (72, N'Socrates')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (73, N'Stephen Covey')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (74, N'Steve Jobs')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (75, N'Teddy Roosevelt')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (76, N'Theodore Roosevelt')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (77, N'Tony Robbins')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (78, N'Unknown')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (79, N'Vince Lombardi')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (80, N'Vincent Van Gogh')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (81, N'W. Clement Stone')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (82, N'Wayne Gretzky')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (83, N'Woody Allen')
INSERT [dbo].[Author] ([Id], [Name]) VALUES (84, N'Zig Ziglar')
SET IDENTITY_INSERT [dbo].[Author] OFF
