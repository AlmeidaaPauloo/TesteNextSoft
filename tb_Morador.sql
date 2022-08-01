USE [db_ProvaPratica]
GO

/****** Object:  Table [dbo].[tb_morador]    Script Date: 31/07/2022 23:35:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_morador](
	[Id] [int] NOT NULL,
	[FK_familia] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Idade] [int] NOT NULL,
 CONSTRAINT [PK_tb_morador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tb_morador]  WITH CHECK ADD  CONSTRAINT [FK_tb_morador_tb_familia] FOREIGN KEY([FK_familia])
REFERENCES [dbo].[tb_familia] ([Id])
GO

ALTER TABLE [dbo].[tb_morador] CHECK CONSTRAINT [FK_tb_morador_tb_familia]
GO


