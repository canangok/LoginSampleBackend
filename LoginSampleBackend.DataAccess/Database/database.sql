USE [LoginSample]
GO
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 1.07.2020 12:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccounts](
	[CustomerId] [nvarchar](250) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[LastLoginTime] [datetime] NULL,
	[UserState] [int] NULL,
	[LastUpdateDate] [datetime] NULL,
	[RecordState] [int] NULL,
	[HashType] [nvarchar](100) NULL,
	[TrialCount] [int] NULL CONSTRAINT [DF_UserAccounts_TrialCount]  DEFAULT ((0)),
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[UserAccounts] ([CustomerId], [Username], [PasswordHash], [LastLoginTime], [UserState], [LastUpdateDate], [RecordState], [HashType], [TrialCount]) VALUES (N'61e95646-0a08-4c90-9ba2-d67f89cedb3f', N'HandeEbrar', N'd9b16061b0ecf9b515324ea4a3c54263724a6f7ca03705304a922151c9b2a34c', CAST(N'2020-07-01 12:20:57.813' AS DateTime), 2, CAST(N'2020-07-01 12:21:18.257' AS DateTime), 1, N'SHA256', 3)
INSERT [dbo].[UserAccounts] ([CustomerId], [Username], [PasswordHash], [LastLoginTime], [UserState], [LastUpdateDate], [RecordState], [HashType], [TrialCount]) VALUES (N'6f21424d-b188-4377-925b-7bbd067ec49f', N'FundaEse', N'd9b16061b0ecf9b515324ea4a3c54263724a6f7ca03705304a922151c9b2a34c', CAST(N'2020-07-01 12:19:46.977' AS DateTime), 1, CAST(N'2020-07-01 12:19:46.977' AS DateTime), 1, N'SHA256', 0)
INSERT [dbo].[UserAccounts] ([CustomerId], [Username], [PasswordHash], [LastLoginTime], [UserState], [LastUpdateDate], [RecordState], [HashType], [TrialCount]) VALUES (N'873ecbdf-10b0-41a3-ab52-86c2819d70e3', N'CananGok3', N'd9b16061b0ecf9b515324ea4a3c54263724a6f7ca03705304a922151c9b2a34c', CAST(N'2020-07-01 00:27:09.860' AS DateTime), 2, CAST(N'2020-07-01 00:27:51.270' AS DateTime), 1, N'SHA256', 3)
INSERT [dbo].[UserAccounts] ([CustomerId], [Username], [PasswordHash], [LastLoginTime], [UserState], [LastUpdateDate], [RecordState], [HashType], [TrialCount]) VALUES (N'bcb25966-984a-44bb-85da-01b037c2e6ca', N'CananGok4', N'43799ae6979e24a92aaa30abae36a06ae797e0c6ece6d1fad6923cd1cee61434', CAST(N'2020-06-30 23:00:07.507' AS DateTime), 2, CAST(N'2020-06-30 23:05:56.883' AS DateTime), 1, N'SHA256', 3)
INSERT [dbo].[UserAccounts] ([CustomerId], [Username], [PasswordHash], [LastLoginTime], [UserState], [LastUpdateDate], [RecordState], [HashType], [TrialCount]) VALUES (N'E19CD835-D18F-4B78-A831-08D81CFBD565', N'CananGok2', N'd9b16061b0ecf9b515324ea4a3c54263724a6f7ca03705304a922151c9b2a34c', CAST(N'2020-07-01 01:50:39.940' AS DateTime), 1, CAST(N'2020-07-01 01:50:32.610' AS DateTime), 1, N'SHA256', 0)
INSERT [dbo].[UserAccounts] ([CustomerId], [Username], [PasswordHash], [LastLoginTime], [UserState], [LastUpdateDate], [RecordState], [HashType], [TrialCount]) VALUES (N'EDFF18C7-533E-4C9F-8A0F-08D81CF80F84', N'CananGok', N'd9b16061b0ecf9b515324ea4a3c54263724a6f7ca03705304a922151c9b2a34c', CAST(N'2020-07-01 01:50:39.940' AS DateTime), 1, CAST(N'2020-07-01 01:50:32.610' AS DateTime), 1, N'SHA256', 0)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__UserAcco__536C85E497E9ECB2]    Script Date: 1.07.2020 12:42:47 ******/
ALTER TABLE [dbo].[UserAccounts] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
