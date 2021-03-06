USE [mytanent]
GO
/****** Object:  Table [dbo].[tblTanentRoomsDetail]    Script Date: 12/31/2016 10:37:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTanentRoomsDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[RoomNumber] [varchar](50) NULL,
	[TanentId] [uniqueidentifier] NULL,
	[SecurityRentPaidAmount] [varchar](50) NULL,
 CONSTRAINT [PK_tblTanentRoomsDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblTanentRoomsDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblTanentRoomsDetail_tblUser] FOREIGN KEY([Id])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblTanentRoomsDetail] CHECK CONSTRAINT [FK_tblTanentRoomsDetail_tblUser]
GO
