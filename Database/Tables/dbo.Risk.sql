CREATE TABLE [dbo].[Risk]
(
[Risk_Id] [int] NOT NULL IDENTITY(1, 1),
[Risk_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NOT NULL CONSTRAINT [DF_Risk_Created_Date] DEFAULT (getdate()),
[Updated_by] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Updated_Date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Risk] ADD CONSTRAINT [PK_Risk] PRIMARY KEY CLUSTERED ([Risk_Id]) ON [PRIMARY]
GO
