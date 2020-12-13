SET IDENTITY_INSERT [dbo].[Ranking] ON
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Player_Name], [Test], [ODI], [T20], [Player_ID], [Player_objPlayer_Id]) VALUES (1, N'Virat Kohli', N'2', N'3', N'2', 25, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Player_Name], [Test], [ODI], [T20], [Player_ID], [Player_objPlayer_Id]) VALUES (2, N'Hardik Pandya', N'3', N'4', N'1', 27, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Player_Name], [Test], [ODI], [T20], [Player_ID], [Player_objPlayer_Id]) VALUES (3, N'Manik', N'1', N'2', N'1', 30, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Player_Name], [Test], [ODI], [T20], [Player_ID], [Player_objPlayer_Id]) VALUES (4, N'MSDhoni', N'6', N'5', N'3', 34, NULL)
INSERT INTO [dbo].[Ranking] ([Ranking_Id], [Player_Name], [Test], [ODI], [T20], [Player_ID], [Player_objPlayer_Id]) VALUES (5, N'Rohit', N'7', N'1', N'1', 22, NULL)
SET IDENTITY_INSERT [dbo].[Ranking] OFF


SET IDENTITY_INSERT [dbo].[Players] ON
INSERT INTO [dbo].[Players] ([Player_Id], [Player_Name], [Player_Address], [Player_Mobile], [Player_Email], [Player_Age]) VALUES (1, N'Virat Kohli', N'66 Fow Street, Hamilton East', N'022768996657', N'Virat01212india@gmail.com', N'40')
INSERT INTO [dbo].[Players] ([Player_Id], [Player_Name], [Player_Address], [Player_Mobile], [Player_Email], [Player_Age]) VALUES (2, N'Hardik Pandya', N'89 Abbotsford Street', N'05646785478', N'Hardik675India@gmail.com', N'29')
INSERT INTO [dbo].[Players] ([Player_Id], [Player_Name], [Player_Address], [Player_Mobile], [Player_Email], [Player_Age]) VALUES (3, N'Manik', N'MEMORIAL DRIVE', N'0221007447', N'manik7696591290@gmail.com', N'20')
INSERT INTO [dbo].[Players] ([Player_Id], [Player_Name], [Player_Address], [Player_Mobile], [Player_Email], [Player_Age]) VALUES (4, N'MSDhoni', N'9 Higgins Road', N'647964589907', N'Dhoni7657India@gmail.com', N'45')
INSERT INTO [dbo].[Players] ([Player_Id], [Player_Name], [Player_Address], [Player_Mobile], [Player_Email], [Player_Age]) VALUES (5, N'Rohit', N'34 Cambridge Road', N'64468754799', N'Rohit56India@gmail.com', N'35')
SET IDENTITY_INSERT [dbo].[Players] OFF


SET IDENTITY_INSERT [dbo].[Fixtures] ON
INSERT INTO [dbo].[Fixtures] ([Fixture_Id], [vs_Team], [Country], [Date], [Ground_Name], [Player_ID], [Player_objPlayer_Id]) VALUES (1, N'Australia', N'India', N'2020-12-18 21:00:00', N'Eden Gardens', 25, NULL)
INSERT INTO [dbo].[Fixtures] ([Fixture_Id], [vs_Team], [Country], [Date], [Ground_Name], [Player_ID], [Player_objPlayer_Id]) VALUES (2, N'South AFrica', N'South Africa', N'2020-12-26 10:00:00', N'Super sport Park', 22, NULL)
INSERT INTO [dbo].[Fixtures] ([Fixture_Id], [vs_Team], [Country], [Date], [Ground_Name], [Player_ID], [Player_objPlayer_Id]) VALUES (3, N'West Indies', N'India', N'2020-12-31 08:00:00', N'Jawahar Lal Nehru Stadium', 33, NULL)
INSERT INTO [dbo].[Fixtures] ([Fixture_Id], [vs_Team], [Country], [Date], [Ground_Name], [Player_ID], [Player_objPlayer_Id]) VALUES (4, N'Zimbawe', N'Zimbawe', N'2021-01-02 07:00:00', N'Harare Sports Club', 34, NULL)
INSERT INTO [dbo].[Fixtures] ([Fixture_Id], [vs_Team], [Country], [Date], [Ground_Name], [Player_ID], [Player_objPlayer_Id]) VALUES (5, N'England', N'England', N'2021-01-08 23:00:00', N'The Oval', 29, NULL)
SET IDENTITY_INSERT [dbo].[Fixtures] OFF


SET IDENTITY_INSERT [dbo].[Events] ON
INSERT INTO [dbo].[Events] ([Event_Id], [ICC_WTC], [IPL], [T20_WC], [Fixture_ID], [Fixture_objFixture_Id]) VALUES (1, N'Australia', N'MI vs CSK', N'south Africa', 22, NULL)
INSERT INTO [dbo].[Events] ([Event_Id], [ICC_WTC], [IPL], [T20_WC], [Fixture_ID], [Fixture_objFixture_Id]) VALUES (2, N'England', N'KXIP vs RR', N'New Zealand', 29, NULL)
INSERT INTO [dbo].[Events] ([Event_Id], [ICC_WTC], [IPL], [T20_WC], [Fixture_ID], [Fixture_objFixture_Id]) VALUES (3, N'West Indies', N'RR vs DC', N'Australia', 30, NULL)
SET IDENTITY_INSERT [dbo].[Events] OFF
