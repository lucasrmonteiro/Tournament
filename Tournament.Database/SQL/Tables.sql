Create Table Tournament(
	
	TournamentId bigint IDENTITY(1,1),
	[Name] varchar(100),
	StartDate Datetime,
	EndDate Datetime,

	CONSTRAINT PK_Tournament PRIMARY KEY (TournamentId)

)

CREATE TABLE Team(

	TeamId bigint IDENTITY(1,1),
	[Name] VARCHAR(100),

	CONSTRAINT PK_Team PRIMARY KEY (TeamId)
)


CREATE TABLE Match(

	MatchId Bigint IDENTITY(1,1),
	TournamentId bigint,
	RoundNum int,
	Team1 bigint ,
	Team2 bigint ,
	IsFinal bit,
	Winner bigint ,

	CONSTRAINT PK_Match PRIMARY KEY (MatchId),
	CONSTRAINT FK_Match_Tournament FOREIGN KEY (TournamentId) REFERENCES Tournament (TournamentId),
	CONSTRAINT FK_Match_Team1 FOREIGN KEY (Team1) REFERENCES Tournament (TeamId),
	CONSTRAINT FK_Match_Team2 FOREIGN KEY (Team2) REFERENCES Tournament (TeamId),
	CONSTRAINT FK_Match_Winner FOREIGN KEY (Winner) REFERENCES Tournament (TeamId)
)