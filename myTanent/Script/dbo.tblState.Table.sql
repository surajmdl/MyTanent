USE [mytanent]
GO
/****** Object:  Table [dbo].[tblState]    Script Date: 12/31/2016 10:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblState](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](100) NULL,
	[CountryId] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblState] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblState] ON 

INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (1, N'ANDHRA PRADESH', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (2, N'ASSAM', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (3, N'ARUNACHAL PRADESH', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (4, N'BIHAR', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (5, N'GUJRAT', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (6, N'HARYANA', 1, 1)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (7, N'HIMACHAL PRADESH', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (8, N'JAMMU & KASHMIR', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (9, N'KARNATAKA', 1, 1)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (10, N'KERALA', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (11, N'MADHYA PRADESH', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (12, N'MAHARASHTRA', 1, 1)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (13, N'MANIPUR', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (14, N'MEGHALAYA', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (15, N'MIZORAM', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (16, N'NAGALAND', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (17, N'ORISSA', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (18, N'PUNJAB', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (19, N'RAJASTHAN', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (20, N'SIKKIM', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (21, N'TAMIL NADU', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (22, N'TRIPURA', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (23, N'UTTAR PRADESH', 1, 1)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (24, N'WEST BENGAL', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (25, N'DELHI', 1, 1)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (26, N'GOA', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (27, N'PONDICHERY', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (28, N'LAKSHDWEEP', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (29, N'DAMAN & DIU', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (30, N'DADRA & NAGAR', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (31, N'CHANDIGARH', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (32, N'ANDAMAN & NICOBAR', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (33, N'UTTARANCHAL', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (34, N'JHARKHAND', 1, 0)
INSERT [dbo].[tblState] ([id], [StateName], [CountryId], [IsActive]) VALUES (35, N'CHATTISGARH', 1, 0)
SET IDENTITY_INSERT [dbo].[tblState] OFF
