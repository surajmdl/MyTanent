USE [myTanent]
GO
/****** Object:  Table [dbo].[tblTanentRentDetail]    Script Date: 12/12/2016 18:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTanentRentDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[TanentId] [uniqueidentifier] NULL,
	[RoomRentAmount] [varchar](50) NULL,
	[ElectricityAmount] [varchar](50) NULL,
	[MaintananceAmount] [varchar](50) NULL,
	[OtherAmount] [varchar](50) NULL,
	[PreviousAmount] [varchar](50) NULL,
	[DiscountAmount] [varchar](50) NULL,
	[TotalPayableAmount] [varchar](50) NULL,
	[TotalPaidAmount] [varchar](50) NULL,
	[RemainingAmount] [varchar](50) NULL,
	[PaidDate] [datetime] NULL,
 CONSTRAINT [PK_tblTanentRentDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblTanentRentDetail]  WITH CHECK ADD  CONSTRAINT [FK_tblTanentRentDetail_tblUser] FOREIGN KEY([TanentId])
REFERENCES [dbo].[tblUser] ([Id])
GO
ALTER TABLE [dbo].[tblTanentRentDetail] CHECK CONSTRAINT [FK_tblTanentRentDetail_tblUser]
GO
