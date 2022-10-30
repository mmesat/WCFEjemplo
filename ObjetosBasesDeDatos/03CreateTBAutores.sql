USE [Libreria]
GO

/****** Object:  Table [dbo].[autores]    Script Date: 7/10/2020 10:27:27 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[autores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NULL,
	[apellidos] [varchar](45) NULL,
 CONSTRAINT [PK_autores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


