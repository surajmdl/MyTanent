USE [myTanent]
GO
/****** Object:  Table [dbo].[tblTanentDocuments]    Script Date: 12/12/2016 18:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTanentDocuments](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[Documents] [varchar](50) NULL,
 CONSTRAINT [PK_tblTanentDocuments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblTanentDocuments]  WITH CHECK ADD  CONSTRAINT [FK_tblTanentDocuments_tblUser1] FOREIGN KEY([UserId])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblTanentDocuments] CHECK CONSTRAINT [FK_tblTanentDocuments_tblUser1]
GO
