USE [mytanent]
GO
/****** Object:  Table [dbo].[tblUserBankDetail]    Script Date: 12/31/2016 10:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUserBankDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[BankName] [varchar](50) NULL,
	[AccountName] [varchar](50) NULL,
	[AccountNumber] [varchar](50) NULL,
	[IFSCCode] [varchar](50) NULL,
 CONSTRAINT [PK_tblUserBankDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblUserBankDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblUserBankDetail_tblUser] FOREIGN KEY([Id])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblUserBankDetail] CHECK CONSTRAINT [FK_tblUserBankDetail_tblUser]
GO
