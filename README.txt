This project consist of two types controllers, API & Web.

API Controller are used for exposing APIs, while Web controllers are used to display user interfaces.

The project are hosted locally, in local MSSQL database hosted in local IIS Server.

The database name is EtiqaCDN.

The Freelancer create table query is:
	USE [EtiqaCDN]
	GO

	/****** Object:  Table [dbo].[Freelancer]    Script Date: 17/10/2023 2:54:35 PM ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[Freelancer](
		[Id] [uniqueidentifier] NOT NULL,
		[UserName] [nvarchar](255) NULL,
		[FirstName] [nvarchar](255) NULL,
		[LastName] [nvarchar](255) NULL,
		[Email] [nvarchar](255) NULL,
		[PhoneNum] [nvarchar](255) NULL,
		[Hobby] [nvarchar](max) NULL,
		[SkillSet] [nvarchar](max) NULL,
	 CONSTRAINT [PK_Freelancers] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
	GO
	
The Stored Procedure script for data insertion is:
	USE [EtiqaCDN]
	GO
	/****** Object:  StoredProcedure [dbo].[SP_INSERT_Freelancer]    Script Date: 17/10/2023 3:00:30 PM ******/
	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO
	ALTER PROCEDURE [dbo].[SP_INSERT_Freelancer] 

		@UserName NVARCHAR(255)
		, @FirstName NVARCHAR(255)
		, @LastName NVARCHAR(255)
		, @Email NVARCHAR(255)
		, @PhoneNum NVARCHAR(255)
		, @Hobby NVARCHAR(255)
		, @SkillSet NVARCHAR(MAX)

	AS 

		INSERT INTO Freelancer
		(Id, UserName, FirstName, LastName, Email, PhoneNum, Hobby, SkillSet)
		VALUES
		(NEWID(), @UserName, @FirstName, @LastName, @Email, @PhoneNum, @Hobby, @SkillSet)

