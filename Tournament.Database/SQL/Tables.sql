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
	CONSTRAINT FK_Match_Team1 FOREIGN KEY (Team1) REFERENCES Team (TeamId),
	CONSTRAINT FK_Match_Team2 FOREIGN KEY (Team2) REFERENCES Team (TeamId),
	CONSTRAINT FK_Match_Winner FOREIGN KEY (Winner) REFERENCES Team (TeamId)
)

CREATE TABLE Position(
	IdPosition bigint IDENTITY(1,1),
	NamePosition VARCHAR(200),
	
	CONSTRAINT PK_Position PRIMARY KEY (IdPosition)
)

INSERT INTO Position (NamePosition) VALUES ('TopLaner')
INSERT INTO Position (NamePosition) VALUES ('Jungle')
INSERT INTO Position (NamePosition) VALUES ('MidLaner')
INSERT INTO Position (NamePosition) VALUES ('ADCarry')
INSERT INTO Position (NamePosition) VALUES ('Suport')

CREATE TABLE Player(

	PlayerId bigint IDENTITY(1,1),
	TeamId bigint,
	IdPosition bigint,
	[Name] VARCHAR(200),
	BirthDate DATETIME,
	Genre VARCHAR(1),

	CONSTRAINT PK_Player PRIMARY KEY (PlayerId),
	CONSTRAINT FK_Player_Team FOREIGN KEY (TeamId) REFERENCES Team (TeamId),
	CONSTRAINT FK_Player_Position FOREIGN KEY (IdPosition) REFERENCES Position (IdPosition),
	CONSTRAINT CHK_Player_Sex CHECK (Genre = 'H' or Genre = 'M')
)