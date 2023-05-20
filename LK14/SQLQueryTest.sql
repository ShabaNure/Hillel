begin transaction
    select g.Group_Id, g.GroupName ,s.FirstName, sm.Marks
    from students s
    join Groups g on g.Group_Id = s.Group_Id
    join StudentMarks sm on s.Student_Id = sm.Student_Id
    join (
      select g.Group_Id, Max(sm.Marks) as max 
      from Students s
      join StudentMarks sm on s.Student_Id = sm.Student_Id
      join Groups g on s.Group_Id = g.Group_Id
      group by g.Group_Id
      ) m on g.Group_Id = m.Group_Id
    where sm.Marks = m.max


    select g.Group_Id, g.GroupName, s.FirstName, s.Mark
    from StudentsWithMarks s
    join Groups g on g.Group_Id = s.Group_Id
    join( 
        select g.Group_Id, max(s.Mark) as max
        from StudentsWithMarks s
        join Groups g on s.Group_Id=g.Group_Id
        group by g.Group_Id
        ) m on g.Group_Id = m.Group_Id
    where s.Mark=m.max

commit