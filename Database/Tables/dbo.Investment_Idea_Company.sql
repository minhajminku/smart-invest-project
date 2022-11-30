CREATE TABLE [dbo].[Investment_Idea_Company]
(
[Investment_Idea_Company_Id] [int] NOT NULL IDENTITY(1, 1),
[IdeaId] [int] NULL,
[CompanyId] [int] NULL,
[CreatedBy] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[CreatedDate] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Investment_Idea_Company] ADD CONSTRAINT [PK_Investment_Idea_Company] PRIMARY KEY CLUSTERED ([Investment_Idea_Company_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Investment_Idea_Company] ADD CONSTRAINT [FK_Investment_Idea_Company_Company_Master] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company_Master] ([Company_Id])
GO
ALTER TABLE [dbo].[Investment_Idea_Company] ADD CONSTRAINT [FK_Investment_Idea_Company_Investment_Idea] FOREIGN KEY ([IdeaId]) REFERENCES [dbo].[Investment_Idea] ([Investment_Idea_Id])
GO
