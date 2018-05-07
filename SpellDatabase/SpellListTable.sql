CREATE TABLE [dbo].[SpellListTable]
(
	[Id] INT NOT NULL PRIMARY KEY DEFAULT 0, 
    [Range] INT NOT NULL DEFAULT 0, 
    [Level] INT NOT NULL DEFAULT 0, 
    [Name] NVARCHAR(MAX) NOT NULL , 
    [Duration] NVARCHAR(50) NULL, 
    [CastTime] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [PlayerClass] NVARCHAR(50) NOT NULL, 
    [ComponentType] NVARCHAR(MAX) NOT NULL, 
    [School] NCHAR(10) NOT NULL, 
    [Concentration] BIT NOT NULL DEFAULT 0,
    [spellCanOvercharge] BIT NOT NULL DEFAULT 0,
    [Ritual] BIT NOT NULL DEFAULT 0,
    [AreaOfEffect] BIT NOT NULL DEFAULT 0,
    [IsPermanent] BIT NOT NULL DEFAULT 0,
    [DamageOverTime] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_SpellListTable_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])

)
