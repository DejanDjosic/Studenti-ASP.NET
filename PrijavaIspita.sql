USE [PrijavaIspita]
GO
/****** Object:  Table [dbo].[Smer]    Script Date: 30-Aug-23 16:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Smer](
	[idSmer] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Smer] PRIMARY KEY CLUSTERED 
(
	[idSmer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 30-Aug-23 16:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[idStudent] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[godinaUpisa] [int] NOT NULL,
	[idSmer] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[idStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Smer] ON 

INSERT [dbo].[Smer] ([idSmer], [naziv]) VALUES (1, N'Multimedija')
INSERT [dbo].[Smer] ([idSmer], [naziv]) VALUES (2, N'IT')
INSERT [dbo].[Smer] ([idSmer], [naziv]) VALUES (3, N'Ekonomija')
SET IDENTITY_INSERT [dbo].[Smer] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (1, N'Marija', N'Bosnic', 2016, 1)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (3, N'Milos ', N'Milosevic', 2016, 2)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (4, N'Milica', N'Maric', 2017, 1)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (5, N'Marko', N'Markovic', 2017, 3)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (6, N'Sava', N'Savic', 2017, 3)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (7, N'Igor', N'Berbatovic', 2018, 2)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (8, N'Igor', N'Milic', 2023, 3)
INSERT [dbo].[Student] ([idStudent], [ime], [prezime], [godinaUpisa], [idSmer]) VALUES (10, N'Ilija', N'Jovanovic', 2016, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Smer] FOREIGN KEY([idSmer])
REFERENCES [dbo].[Smer] ([idSmer])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Smer]
GO
