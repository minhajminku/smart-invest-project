SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE   PROCEDURE [dbo].[GetClientPreferenceDropDownData]
    -- Add the parameters for the stored procedure here
    @Preference_Type_Id INT,
    @Client_Id INT = NULL
AS
BEGIN
    DECLARE @SQL_Query NVARCHAR(MAX) = N'',
            @Preference_Table_Name NVARCHAR(50) = N'',
            @Preference_Table_Coulmns NVARCHAR(MAX) = N'',
            @Preferece_Table_Join_Column NVARCHAR(100) = N'';

    SELECT @Preference_Table_Name = CASE
                                        WHEN @Preference_Type_Id = 1 THEN
                                            'dbo.Investment_Category'
                                        WHEN @Preference_Type_Id = 2 THEN
                                            'dbo.Sectors'
                                        WHEN @Preference_Type_Id = 3 THEN
                                            'dbo.Risk'
                                        WHEN @Preference_Type_Id = 4 THEN
                                            'dbo.Country'
                                        ELSE
                                            'dbo.Investment_Category'
                                    END;

    SELECT @Preference_Table_Coulmns = CASE
                                           WHEN @Preference_Type_Id = 1 THEN
                                               ' PT.Investment_Category_Id,PT.Investment_Category_Name'
                                           WHEN @Preference_Type_Id = 2 THEN
                                               'PT.Sector_Id,PT.Sector_Name'
                                           WHEN @Preference_Type_Id = 3 THEN
                                               'PT.Risk_Id,PT.Risk_Name'
                                           WHEN @Preference_Type_Id = 4 THEN
                                               'PT.Country_Id,PT.Country_Name'
                                           ELSE
                                               'PT.Investment_Category_Id,PT.Investment_Category_Name'
                                       END;

    SELECT @Preferece_Table_Join_Column = CASE
                                              WHEN @Preference_Type_Id = 1 THEN
                                                  ' PT.Investment_Category_Id'
                                              WHEN @Preference_Type_Id = 2 THEN
                                                  'PT.Sector_Id'
                                              WHEN @Preference_Type_Id = 3 THEN
                                                  'PT.Risk_Id'
                                              WHEN @Preference_Type_Id = 4 THEN
                                                  'PT.Country_Id'
                                              ELSE
                                                  'PT.Investment_Category_Id'
                                          END;

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;
    SET @SQL_Query
        = @SQL_Query + N'SELECT ' + @Preference_Table_Coulmns
          + N',IIF(CP.Client_Prference_Id IS NULL,0,1) AS IsSelected' + N' FROM ' + @Preference_Table_Name
          + N' PT
			LEFT JOIN dbo.Client_Prferences CP ON ' + @Preferece_Table_Join_Column + N' = CP.Preference_Type_Sub_Id'+
			' AND CP.Preference_Type_Id = '+CAST(@Preference_Type_Id AS NVARCHAR(25)) 
          + IIF(@Client_Id IS NOT NULL, ' AND CP.Client_Id = ' + CAST(@Client_Id AS NVARCHAR(50)), '');
    
	EXEC sp_executesql @SQL_Query;

END;
GO
