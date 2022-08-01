USE [db_ProvaPratica]
GO

/****** Object:  Table [dbo].[tb_condominio]    Script Date: 31/07/2022 23:32:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_condominio](
	[Id] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Bairro] [varchar](50) NOT NULL,
	[areaTotal] [decimal](18, 2) NULL,
	[valorIPTU] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tb_condominio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


