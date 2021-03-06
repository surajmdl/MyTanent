USE [myTanent]
GO
/****** Object:  Table [dbo].[tblRooms]    Script Date: 12/12/2016 18:52:38 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblRooms]  WITH CHECK ADD  CONSTRAINT [FK_tblRooms_tblUser1] FOREIGN KEY([UserId])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblRooms] CHECK CONSTRAINT [FK_tblRooms_tblUser1]
GO
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'3416f488-1ae5-48f5-aacc-8246fa9bae00', N'3bdf25a0-ee19-474c-a58b-061ec7b3009e', 303, 1, 1, CAST(0x0000A6D2012789C7 AS DateTime))
INSERT [dbo].[tblRooms] ([Id], [UserId], [RoomNumber], [FloorNumber], [Status], [CreatedOn]) VALUES (N'e3ca30f7-c909-4c89-8378-e0f9f55f1443', N'3bdf25a0-ee19-474c-a58b-061ec7b3009e', 302, 1, 1, CAST(0x0000A6D201278093 AS DateTime))
