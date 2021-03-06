USE [mytanent]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 12/31/2016 10:37:52 PM ******/
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
	[UserPhoto] [varchar](500) NULL,
	[AllotedRoomNo] [varchar](50) NULL,
	[Status] [varchar](10) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[AllotedFloorNo] [varchar](50) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy], [AllotedFloorNo]) VALUES (N'cdbdd574-37e1-462c-8506-03d370a55219', N'Suraj', N'Mad', N'9718024390', N'22222222', N'skm@email.com', N'9718024390', N'skm@123', N'HouseOwner', NULL, N'6', N'442', N'Sushant lok', N'gorakhpur', N'http://localhost:9900/Content/ProfilePic/9f7f713f-994e-42b3-bc18-d879e88e411f.jpg', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy], [AllotedFloorNo]) VALUES (N'64aa927b-f09e-4d09-b433-03fd634dceab', N'Rohan', NULL, N'98765', NULL, N'skm@email.com', N'98765', NULL, N'Tanent', NULL, N'6', N'458', NULL, N'gkp', N'http://localhost:9900/Content/ProfilePic/2b873315-bf81-4e9a-b126-f6a917889d5a.jpg', N'501', N'True', CAST(0x0000A6DE01623D8C AS DateTime), N'cdbdd574-37e1-462c-8506-03d370a55219', NULL)
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy], [AllotedFloorNo]) VALUES (N'535b5850-ae22-40b9-a0b8-3fb42dd95951', N'mahira', N'jj', N'9989898', N'89989', N'jjkj', N'9989898', NULL, N'Tanent', NULL, N'6', N'442', N'mn', N'mn', N'~/Content/ProfilePic/93f30508-fc51-49ec-85c1-9b0511298e15.PNG', NULL, N'True', CAST(0x0000A6E0016EE6F4 AS DateTime), N'cdbdd574-37e1-462c-8506-03d370a55219', N'1')
INSERT [dbo].[tblUser] ([Id], [Firstname], [Lastname], [Mobile1], [Mobile2], [EmailId], [UserId], [password], [UserType], [Country], [State], [City], [Locality], [PermanentAddress], [UserPhoto], [AllotedRoomNo], [Status], [CreatedOn], [CreatedBy], [AllotedFloorNo]) VALUES (N'208aa82c-e9ae-4f86-8e39-65deef4515a8', N'Rohit', N'k', N'98765', NULL, NULL, NULL, N'CS8VH', N'Tanent', NULL, N'6', N'442', N'Sector 14', N'GKP', NULL, N'7', NULL, NULL, NULL, NULL)
