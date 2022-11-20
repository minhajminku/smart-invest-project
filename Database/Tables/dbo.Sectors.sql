CREATE TABLE [dbo].[Sectors]
(
[Sector_Id] [int] NOT NULL IDENTITY(1, 1),
[Sector_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Sector_Code] [nvarchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NOT NULL CONSTRAINT [DF_Sector_Created_Date] DEFAULT (getdate()),
[Updated_by] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Updated_Date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sectors] ADD CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED ([Sector_Id]) ON [PRIMARY]
GO
