CREATE TABLE [dbo].[Groups] (
    [Id]        INT        NOT NULL IDENTITY,
    [GroupName] NVARCHAR(50) NOT NULL,
    [Course]    INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

