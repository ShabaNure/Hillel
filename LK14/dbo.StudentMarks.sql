CREATE TABLE [dbo].[StudentMarks] (
    [Student_Id] INT NOT NULL,
    [Marks]      INT NOT NULL,
    CONSTRAINT [FK_StudentMarks_Id] FOREIGN KEY ([Student_Id]) REFERENCES [dbo].[Students] ([Student_Id])
);

