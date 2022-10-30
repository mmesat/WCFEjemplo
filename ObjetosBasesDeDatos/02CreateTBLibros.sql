USE [Libreria]
GO

/****** Object:  Table [dbo].[libros]    Script Date: 7/10/2020 10:26:59 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[libros](
	[ISBN] [int] IDENTITY(1,1) NOT NULL,
	[editoriales_id] [int] NULL,
	[titulo] [varchar](45) NULL,
	[sinopsis] [text] NULL,
	[n_paginas] [varchar](45) NULL,
 CONSTRAINT [PK_libros] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[libros]  WITH CHECK ADD  CONSTRAINT [FK_libros_libros] FOREIGN KEY([editoriales_id])
REFERENCES [dbo].[editoriales] ([id])
GO

ALTER TABLE [dbo].[libros] CHECK CONSTRAINT [FK_libros_libros]
GO


