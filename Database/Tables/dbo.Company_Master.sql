CREATE TABLE [dbo].[Company_Master]
(
[Company_Id] [int] NOT NULL IDENTITY(1, 1),
[Company_Name] [nvarchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Stock_Value] [decimal] (18, 0) NULL,
[Previous_Month_Stock_Value] [decimal] (18, 0) NULL,
[RiskId] [int] NULL,
[CategoryId] [int] NULL,
[SectorId] [int] NULL,
[CountryId] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Company_Master] ADD CONSTRAINT [PK_Company_Master] PRIMARY KEY CLUSTERED ([Company_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Company_Master] ADD CONSTRAINT [FK_Company_Master_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Country_Id])
GO
ALTER TABLE [dbo].[Company_Master] ADD CONSTRAINT [FK_Company_Master_Investment_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Investment_Category] ([Investment_Category_Id])
GO
ALTER TABLE [dbo].[Company_Master] ADD CONSTRAINT [FK_Company_Master_Risk] FOREIGN KEY ([RiskId]) REFERENCES [dbo].[Risk] ([Risk_Id])
GO
ALTER TABLE [dbo].[Company_Master] ADD CONSTRAINT [FK_Company_Master_Sectors] FOREIGN KEY ([SectorId]) REFERENCES [dbo].[Sectors] ([Sector_Id])
GO
