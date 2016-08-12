USE [Test]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 05-08-2016 01:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[appointment](
	[appointmentId] [int] IDENTITY(1,1) NOT NULL,
	[studentid] [int] NOT NULL,
	[counselorid] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[time] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[counselor]    Script Date: 05-08-2016 01:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[counselor](
	[counselorid] [int] IDENTITY(1,1) NOT NULL,
	[couselorname] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[counselorid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CounselRequest]    Script Date: 05-08-2016 01:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CounselRequest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[studentid] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[time] [time](7) NOT NULL,
	[isaccept] [varchar](10) NOT NULL,
	[updatedby] [varchar](50) NULL,
 CONSTRAINT [PK_CounselRequest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student]    Script Date: 05-08-2016 01:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[studentid] [int] IDENTITY(1,1) NOT NULL,
	[studentname] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[studentid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user]    Script Date: 05-08-2016 01:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](250) NOT NULL,
	[type] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[appointment] ON 

INSERT [dbo].[appointment] ([appointmentId], [studentid], [counselorid], [date], [time]) VALUES (1, 1, N'1', CAST(0x01150B00 AS Date), CAST(0x070008D6E8290000 AS Time))
SET IDENTITY_INSERT [dbo].[appointment] OFF
SET IDENTITY_INSERT [dbo].[counselor] ON 

INSERT [dbo].[counselor] ([counselorid], [couselorname]) VALUES (1, N'Nilkhil')
INSERT [dbo].[counselor] ([counselorid], [couselorname]) VALUES (2, N'Charlie')
SET IDENTITY_INSERT [dbo].[counselor] OFF
SET IDENTITY_INSERT [dbo].[CounselRequest] ON 

INSERT [dbo].[CounselRequest] ([id], [studentid], [name], [date], [time], [isaccept], [updatedby]) VALUES (1, 2, N'student', CAST(0xB83B0B00 AS Date), CAST(0x0700D088C3100000 AS Time), N'false', N'student')
INSERT [dbo].[CounselRequest] ([id], [studentid], [name], [date], [time], [isaccept], [updatedby]) VALUES (2, 2, N'student', CAST(0xB83B0B00 AS Date), CAST(0x0700D088C3100000 AS Time), N'false', N'student')
SET IDENTITY_INSERT [dbo].[CounselRequest] OFF
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([studentid], [studentname]) VALUES (1, N'Ammy')
INSERT [dbo].[student] ([studentid], [studentname]) VALUES (2, N'Belly')
INSERT [dbo].[student] ([studentid], [studentname]) VALUES (3, N'Nancy')
INSERT [dbo].[student] ([studentid], [studentname]) VALUES (4, N'Sara')
SET IDENTITY_INSERT [dbo].[student] OFF
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password], [type]) VALUES (1, N'admin', N'123', N'admin')
INSERT [dbo].[user] ([id], [username], [password], [type]) VALUES (2, N'student', N'123', N'student')
INSERT [dbo].[user] ([id], [username], [password], [type]) VALUES (4, N'counseler', N'123', N'counseler')
SET IDENTITY_INSERT [dbo].[user] OFF
