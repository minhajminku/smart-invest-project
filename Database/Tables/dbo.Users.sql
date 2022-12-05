CREATE TABLE [dbo].[Users]
(
[User_Id] [int] NOT NULL IDENTITY(1, 1),
[First_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Last_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[User_Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Email] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Password] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Created_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Created_Date] [date] NULL,
[Updated_By] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Update_Date] [date] NULL,
[Is_RM] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([User_Id]) ON [PRIMARY]
GO