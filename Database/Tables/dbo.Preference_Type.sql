CREATE TABLE [dbo].[Preference_Type]
(
[Preference_Type_Id] [int] NOT NULL IDENTITY(1, 1),
[Preference_Type_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NOT NULL CONSTRAINT [DF_Preference_Type_Created_Date] DEFAULT (getdate()),
[Updated_by] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Updated_Date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Preference_Type] ADD CONSTRAINT [PK_Preference_Type] PRIMARY KEY CLUSTERED ([Preference_Type_Id]) ON [PRIMARY]
GO
