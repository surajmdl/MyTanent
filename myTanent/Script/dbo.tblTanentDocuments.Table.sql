USE [mytanent]
GO
/****** Object:  Table [dbo].[tblTanentDocuments]    Script Date: 12/31/2016 10:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTanentDocuments](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[Documents] [varchar](500) NULL,
 CONSTRAINT [PK_tblTanentDocuments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'43a7fdef-a808-4310-a10c-16c115932c2b', N'cdbdd574-37e1-462c-8506-03d370a55219', N'~/Content/Documents/ae25a48a-1015-407b-aadb-3340ae978443.PNG')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'a5780a11-dfda-493b-9d1b-28120f723b6b', N'cdbdd574-37e1-462c-8506-03d370a55219', N'~/Content/Documents/4ca5f065-c6be-462d-8b4c-77660a0a65ab.pdf')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'b38fbe17-6926-4345-a979-304d6534fdb0', N'cdbdd574-37e1-462c-8506-03d370a55219', N'~/Content/Documents/a1f9ac4b-95b6-42c4-ae6e-bdf7b7ed3b59.PNG')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'c728b31e-1d33-4217-85d2-40954b02b93b', N'cdbdd574-37e1-462c-8506-03d370a55219', N'~/Content/Documents/7735ed75-6580-48a5-a7b3-38cfedbc5275.pdf')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'd5babc32-2985-4be9-8f2d-4bce6e3abe6a', N'208aa82c-e9ae-4f86-8e39-65deef4515a8', N'~/Content/Documents/c0e222ce-7dbb-459c-8ca1-ee9b62458910.JPG')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'3693974f-ef9b-4665-b7cb-8ebc82d820d7', N'cdbdd574-37e1-462c-8506-03d370a55219', N'E:\Projects\myTanent\MyTannent.Web\MyTannent.Web\Content\Documents\8edc85d8-6171-453f-b7a7-3547ab644689.txt')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'8f78acd1-9b2d-4604-9b00-9c6fc4fb58de', N'cdbdd574-37e1-462c-8506-03d370a55219', N'~/Content/Documents/3396455d-bbdd-4cfe-b12a-aad84c72d8ab.pdf')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'e035f190-7d97-4fbc-9c5e-a218df3a4fac', N'cdbdd574-37e1-462c-8506-03d370a55219', N'E:\Projects\myTanent\MyTannent.Web\MyTannent.Web\Content\Documents\d6aa873e-72c4-41f6-8cf2-267dafc32382.PNG')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'f882a393-9518-4ea5-92aa-c89d4eac6911', N'535b5850-ae22-40b9-a0b8-3fb42dd95951', N'~/Content/Documents/4dfd517c-5551-4490-a148-54da72af46ee.jpg')
INSERT [dbo].[tblTanentDocuments] ([Id], [UserId], [Documents]) VALUES (N'9eacf319-2726-4a1e-9e09-d9f58f57e3ee', N'cdbdd574-37e1-462c-8506-03d370a55219', N'~/Content/Documents/250f6104-3974-4598-911f-b63341815b03.txt')
ALTER TABLE [dbo].[tblTanentDocuments]  WITH CHECK ADD  CONSTRAINT [FK_tblTanentDocuments_tblUser1] FOREIGN KEY([UserId])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblTanentDocuments] CHECK CONSTRAINT [FK_tblTanentDocuments_tblUser1]
GO
