USE [Libreria]
GO

/****** Object:  StoredProcedure [dbo].[AgregarLibro]    Script Date: 7/10/2020 10:29:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Miguel Mesa
-- Create date: <07-11-2019>
-- Description:	<SP de insert.>
-- =============================================
CREATE PROCEDURE [dbo].[AgregarLibro](
	@EditorialId int,
	@Titulo varchar(max),
	@Sinopsis varchar(max),
	@NPaginas varchar(max)
)
AS
BEGIN
	insert into dbo.libros(
      editoriales_id
      ,titulo
      ,sinopsis
      ,n_paginas) values (@EditorialId,@Titulo,@Sinopsis,@NPaginas)
END
GO


