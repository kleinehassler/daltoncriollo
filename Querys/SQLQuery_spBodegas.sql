SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dalton Criollo
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spLisBodegas
AS
BEGIN
	SELECT b.nombrebodega AS NombreBodega,
		b.direccion AS Direccion,
		s.nombresujeto as Responsable,
		b.idebodega as ID
	FROM bodega b LEFT JOIN sujeto s ON (b.responsable = s.idesujeto)
	ORDER BY b.nombrebodega
END
GO

