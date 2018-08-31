CREATE TABLE [dbo].[Tests]
(
	[Id] INT NOT NULL IDENTITY , 
    [Name] NVARCHAR(50) NOT NULL, 
    [Amount] MONEY NOT NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT sysutcdatetime(), 
    [CreatedById] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [PK_Tests] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Tests_AspNetUsers] FOREIGN KEY ([CreatedById]) REFERENCES [AspNetUsers]([Id])
)
