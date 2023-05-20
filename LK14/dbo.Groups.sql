CREATE TABLE [dbo].[Groups] (
    [Group_Id]        INT           IDENTITY (1, 1) NOT NULL,
    [GroupName] NVARCHAR (50) NOT NULL,
    [Course]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Group_Id] ASC)
);

