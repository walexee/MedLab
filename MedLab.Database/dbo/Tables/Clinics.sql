CREATE TABLE [dbo].[Clinics]
(
	[Id] INT NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(256) NULL, 
    [Email] NVARCHAR(256) NULL, 
    [PhoneNumber] NVARCHAR(20) NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT sysutcdatetime(), 
    [CreatedById] NVARCHAR(128) NULL, 
    CONSTRAINT [PK_Clinics] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Clinics_AspNetUsers] FOREIGN KEY ([CreatedById]) REFERENCES [AspNetUsers]([Id]) 
)
