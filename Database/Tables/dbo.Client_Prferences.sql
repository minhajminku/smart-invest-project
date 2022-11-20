CREATE TABLE [dbo].[Client_Prferences]
(
[Client_Prference_Id] [int] NOT NULL IDENTITY(1, 1),
[Client_Id] [int] NULL,
[Preference_Type_Id] [int] NULL,
[Preference_Type_Sub_Id] [int] NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NOT NULL CONSTRAINT [DF_Client_Prferences_Created_Date] DEFAULT (getdate()),
[Updated_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Updated_Date] [date] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client_Prferences] ADD CONSTRAINT [PK_Client_Prferences] PRIMARY KEY CLUSTERED ([Client_Prference_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client_Prferences] ADD CONSTRAINT [FK_Client_Prferences_Client] FOREIGN KEY ([Client_Id]) REFERENCES [dbo].[Client] ([Client_Id])
GO
ALTER TABLE [dbo].[Client_Prferences] ADD CONSTRAINT [FK_Client_Prferences_Preference_Type] FOREIGN KEY ([Preference_Type_Id]) REFERENCES [dbo].[Preference_Type] ([Preference_Type_Id])
GO

