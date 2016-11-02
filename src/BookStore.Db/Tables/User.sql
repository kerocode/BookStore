CREATE TABLE [dbo].[User](  
    [UserId] BIGINT  IDENTITY (1, 1) NOT NULL,  
    [Firstname] [nvarchar](50) NOT NULL,    
	[Lastname] [nvarchar](50) NOT NULL,    
	[Username] NVARCHAR(50) NOT NULL,        
	[Email] NVARCHAR(50) NOT NULL, 
    [Password] VARCHAR(225) NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL, 
    [UpdatedAt] DATETIME2 NOT NULL, 
    [IsEnabled] BIT NOT NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId]) );
 
 GO