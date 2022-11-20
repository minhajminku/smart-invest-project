Drop table[dbo].[Investment_Idea]
CREATE TABLE [dbo].[Investment_Idea]
(
[Investment_Idea_Id] [int] NOT NULL IDENTITY(1, 1),
[Investment_Idea_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Investment_Category_Id] [int] NULL,
[Country_Id] [int] NULL,
[Sector_Id] [int] NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NOT NULL CONSTRAINT [DF_Investment_Ideas_Created_Date] DEFAULT (getdate()),
[Updated_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Updated_Date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Investment_Idea] ADD CONSTRAINT [PK_Investment_Ideas] PRIMARY KEY CLUSTERED ([Investment_Idea_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Investment_Idea] ADD CONSTRAINT [FK_Investment_Idea_Investment_Category] FOREIGN KEY ([Investment_Category_Id]) REFERENCES [dbo].[Investment_Category] ([Investment_Category_Id])
GO
ALTER TABLE [dbo].[Investment_Idea] ADD CONSTRAINT [FK_Investment_Idea_Country] FOREIGN KEY ([Country_Id]) REFERENCES [dbo].[Country] ([Country_Id])
GO
ALTER TABLE [dbo].[Investment_Idea] ADD CONSTRAINT [FK_Investment_Idea_Sectors] FOREIGN KEY ([Sector_Id]) REFERENCES [dbo].[Sectors] ([Sector_Id])
GO