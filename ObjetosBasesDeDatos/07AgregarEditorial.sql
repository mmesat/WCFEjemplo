USE [Libreria]
GO

/****** Object:  StoredProcedure [dbo].[AgregarEditorial]    Script Date: 7/10/2020 10:29:28 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Miguel Mesa
-- Create date: <07-11-2019>
-- Description:	<SP de insert.>
-- =============================================
CREATE PROCEDURE [dbo].[AgregarEditorial](

	@Nombre varchar(max),
	@Sede varchar(max)
)
AS
BEGIN
	insert into dbo.editoriales(
      nombre
      ,sede
       ) values (@Nombre,@Sede)
END
GO


