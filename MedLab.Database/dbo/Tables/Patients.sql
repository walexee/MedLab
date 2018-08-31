CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL , 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [ClinicId] INT NULL,
	[Address] NVARCHAR(256) NULL, 
    [PhoneNumber] NVARCHAR(20) NULL, 
    [Email] NVARCHAR(256) NULL, 
    [Created] DATETIME2 NOT NULL DEFAULT sysutcdatetime(), 
    [CreatedById] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [FK_Patients_Clinics] FOREIGN KEY ([ClinicId]) REFERENCES [Clinics]([Id]), 
    CONSTRAINT [PK_Patients] PRIMARY KEY ([Id])
)
