USE [mytanent]
GO
/****** Object:  Table [dbo].[tblRooms]    Script Date: 12/31/2016 10:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRooms](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[RoomNumber] [int] NULL,
	[FloorNumber] [int] NULL,
	[Status] [bit] NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_tblRooms_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'273664f6-4dc1-4a6d-b517-047f433e23b8', N'cdbdd574-37e1-462c-8506-03d370a55219', 501, 2, 1, CAST(0x0000A6DE0162789B AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'95fd7a16-ccd5-4f38-ab41-24467063e3b8', N'cdbdd574-37e1-462c-8506-03d370a55219', 500, 1, 1, CAST(0x0000A6DD016BECE5 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'bc74217f-7d0d-412b-b0cd-41fe506108ed', N'cdbdd574-37e1-462c-8506-03d370a55219', 503, 1, 1, CAST(0x0000A6DD016E2A29 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'6d4c915f-16e6-428f-8cb0-5a76527f8d2d', N'cdbdd574-37e1-462c-8506-03d370a55219', 504, 1, 1, CAST(0x0000A6DD016F2CF8 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'71bd3196-a2b3-4263-9e6c-6bd9321a9dc6', N'cdbdd574-37e1-462c-8506-03d370a55219', 501, 1, 0, CAST(0x0000A6DD016CFD2F AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'570e8ba3-ac24-4ae8-a339-82bb3c827f0a', N'cdbdd574-37e1-462c-8506-03d370a55219', 501, 3, 1, CAST(0x0000A6DE01628336 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'b825f6aa-ba0a-4a71-82e0-abeed107c89f', N'cdbdd574-37e1-462c-8506-03d370a55219', 501, 10, 0, CAST(0x0000A6DE0179BF13 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'562b43bf-1176-4d4a-84e6-d3aa3617d882', N'cdbdd574-37e1-462c-8506-03d370a55219', 502, 4, 0, CAST(0x0000A6DE01629455 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'9035cd2a-c1c0-4930-be09-d6c7254c2397', N'cdbdd574-37e1-462c-8506-03d370a55219', 505, 1, 0, CAST(0x0000A6DD016F472D AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'66ab4d99-bfa2-4eee-9167-f028a4e59989', N'cdbdd574-37e1-462c-8506-03d370a55219', 501, 4, 0, CAST(0x0000A6DE01628B67 AS DateTime))
ALTER TABLE [dbo].[tblRooms]  WITH CHECK ADD  CONSTRAINT [FK_tblRooms_tblUser1] FOREIGN KEY([UserId])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblRooms] CHECK CONSTRAINT [FK_tblRooms_tblUser1]
GO
