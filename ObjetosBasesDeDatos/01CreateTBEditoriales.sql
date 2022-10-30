USE [Libreria]
GO

/****** Object:  Table [dbo].[editoriales]    Script Date: 7/10/2020 10:26:34 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[editoriales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NULL,
	[sede] [varchar](45) NULL,
 CONSTRAINT [PK_editoriales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


