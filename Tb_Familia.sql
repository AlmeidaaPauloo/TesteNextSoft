USE [db_ProvaPratica]
GO

/****** Object:  Table [dbo].[tb_familia]    Script Date: 31/07/2022 23:35:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_familia](
	[Id] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[FK_condominio] [int] NOT NULL,
	[Apto] [int] NOT NULL,
	[areaAPTO] [decimal](18, 2) NULL,
	[IPTUprop] [decimal](18, 2) NULL,
	[fracaoIdeal] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tb_familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tb_familia]  WITH CHECK ADD  CONSTRAINT [FK_tb_familia_tb_condominio] FOREIGN KEY([FK_condominio])
REFERENCES [dbo].[tb_condominio] ([Id])
GO

ALTER TABLE [dbo].[tb_familia] CHECK CONSTRAINT [FK_tb_familia_tb_condominio]
GO


