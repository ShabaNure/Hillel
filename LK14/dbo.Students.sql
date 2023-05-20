CREATE TABLE [dbo].[Students] (
    [Student_Id]        INT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NCHAR (10) NOT NULL,
    [LastName]  NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Student_Id] ASC), 
    CONSTRAINT [FK_Students_Group] FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Groups]([Group_Id])
);

