USE [Libreria]
GO

/****** Object:  Table [dbo].[autores_has_libros]    Script Date: 7/10/2020 10:27:50 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[autores_has_libros](
	[autores_id] [int] NOT NULL,
	[libros_ISBN] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[autores_has_libros]  WITH CHECK ADD  CONSTRAINT [FK_autores_has_libros_autores] FOREIGN KEY([autores_id])
REFERENCES [dbo].[autores] ([id])
GO

ALTER TABLE [dbo].[autores_has_libros] CHECK CONSTRAINT [FK_autores_has_libros_autores]
GO

ALTER TABLE [dbo].[autores_has_libros]  WITH CHECK ADD  CONSTRAINT [FK_autores_has_libros_libros] FOREIGN KEY([libros_ISBN])
REFERENCES [dbo].[libros] ([ISBN])
GO

ALTER TABLE [dbo].[autores_has_libros] CHECK CONSTRAINT [FK_autores_has_libros_libros]
GO


