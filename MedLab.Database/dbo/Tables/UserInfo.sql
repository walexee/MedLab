CREATE TABLE [dbo].[UserInfo]
(
	[Id] NVARCHAR(128) NOT NULL , 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [DoB] DATE NULL, 
    [Email] NVARCHAR(256) NULL, 
    [PhoneNumber] NVARCHAR(20) NULL, 
    [Address] NVARCHAR(256) NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT sysutcdatetime(), 
    CONSTRAINT [PK_UserInfo] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_UserInfo_AspNetUsers] FOREIGN KEY ([Id]) REFERENCES [AspNetUsers]([Id])
)
