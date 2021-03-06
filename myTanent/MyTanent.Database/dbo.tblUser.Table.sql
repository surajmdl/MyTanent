USE [myTanent]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 12/12/2016 18:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUser](
	[Id] [uniqueidentifier] NOT NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Mobile1] [varchar](50) NULL,
	[Mobile2] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[UserId] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[UserType] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Locality] [varchar](500) NULL,
	[PermanentAddress] [varchar](500) NULL,
	[UserPhoto] [varchar](50) NULL,
	[AllotedRoomNo] [varchar](50) NULL,
	[Status] [varchar](10) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'00000000-0000-0000-0000-000000000000', N'jkk', N'kjk', N'9898', N'98989', N'jkj', N'kjk', N'j', N'jkj', N'kj', N'kj', N'k', N'jk', N'jk', N'jkj', N'89', NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'3bdf25a0-ee19-474c-a58b-061ec7b3009e', N'Suraj', N'Kumar', N'9718024390', N'8527848691', N'skm@email.com', N'9718024390', N'skm@123', NULL, N'India', N'UP', N'Noida', N'Sector 22', N'Mehdawal', N'none', N'302', NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'aeaaf240-5485-4ebe-bc6f-286438cf9a92', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'6d74522e-bbac-40da-a595-546c332f46a8', N'Suraj', N'Kumar', N'9718024390', N'8527848691', N'skm@email.com', N'9718024390', N'skm@123', NULL, N'India', N'UP', N'Noida', N'Sector 22', NULL, N'none', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'eebeda24-f342-4ad0-9e35-6910eac102de', N'kklkl', N'lkl', N'999989', N'989', N'jjj', N'kjkjk', N'jkjkjk', N'jkjk', N'jk', N'jkj', N'jk', N'jkkj', N'kkj', N'jk', N'98', NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'4e4f4b83-fb4b-42fe-a5cd-97c308d9cd29', N'Suraj', N'Kumar', N'9718024390', N'8527848691', N'skm@email.com', N'9718024390', N'skm@123', NULL, N'India', N'UP', N'Noida', N'Sector 22', NULL, N'none', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'4c969376-8691-479a-a4fd-afb8d7cf2a1d', NULL, NULL, NULL, NULL, NULL, N'4c969376-8691-479a-a4fd-afb8d7cf2a1d', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'd70f330e-852a-4d00-a102-c6eebd9a74ba', NULL, NULL, NULL, NULL, NULL, N'd70f330e-852a-4d00-a102-c6eebd9a74ba', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'4e1f304a-c70d-423b-99ad-d98b482ce366', N'Suraj', N'Kumar', N'9718024390', N'8527848691', N'skm@email.com', N'9718024390', N'skm@123', NULL, NULL, N'25', N'1278', N'Sector 22', N'Mehdawal', N'none', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy]) VALUES (N'4e1e1223-5ee8-429e-a8c0-e9a50cb335c5', N'jk', N'kj', N'87787878', N'878', N'7878', N'nnmnm', N'nm', N'nm', N'nmn', N'm', N'nm', N'nm', N'nm', N'nm', N'78', NULL, NULL, NULL)
