CREATE TABLE [dbo].[Investment_Category]
(
[Investment_Category_Id] [int] NOT NULL IDENTITY(1, 1),
[Investment_Category_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NOT NULL CONSTRAINT [DF_Investment_Category_Created_Date] DEFAULT (getdate()),
[Updated_by] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Updated_Date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Investment_Category] ADD CONSTRAINT [PK_Investment_Category] PRIMARY KEY CLUSTERED ([Investment_Category_Id]) ON [PRIMARY]
GO
