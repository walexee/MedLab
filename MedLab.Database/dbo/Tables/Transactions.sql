CREATE TABLE [dbo].[Transactions]
(
	[Id] INT NOT NULL , 
    [PatientId] INT NOT NULL, 
    [TestId] INT NOT NULL, 
	[Amount] MONEY NOT NULL DEFAULT 0, 
    [PercentDiscount] DECIMAL(5, 2) NOT NULL,
    [Created] DATETIME2 NOT NULL DEFAULT sysutcdatetime(), 
    [CreatedById] NVARCHAR(128) NULL, 
    CONSTRAINT [PK_Transactions] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Transactions_Patients] FOREIGN KEY ([PatientId]) REFERENCES [Patients]([Id]), 
    CONSTRAINT [FK_Transactions_Tests] FOREIGN KEY ([TestId]) REFERENCES [Tests]([Id]), 
    CONSTRAINT [FK_Transactions_AspNetUsers] FOREIGN KEY ([CreatedById]) REFERENCES [AspNetUsers]([Id]), 
)
