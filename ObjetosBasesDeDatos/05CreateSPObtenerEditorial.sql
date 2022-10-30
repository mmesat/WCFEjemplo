USE [Libreria]
GO

/****** Object:  StoredProcedure [dbo].[SP_ObtenerEditorial]    Script Date: 7/10/2020 10:28:29 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Miguel Mesa
-- Create date: <7-10-2020>
-- Description:	<SP de consulta.>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ObtenerEditorial]

AS
BEGIN
	SELECT 	[id] as Id ,[nombre] as Nombre,[sede] as Sede from editoriales
END
GO


