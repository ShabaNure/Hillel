begin transaction;
	insert into Groups(GroupName,Course)
	values('First group',1)
	insert into Groups(GroupName,Course)
	values('Second group',2)
	insert into Groups(GroupName,Course)
	values('Third group',3)
	insert into Groups(GroupName,Course)
	values('Fourth group',4)
commit;

begin transaction;
	insert into Students(FirstName,LastName)
	values('Mike','Brown')
	insert into Students(FirstName,LastName)
	values('Albert','Brown')
	insert into Students(FirstName,LastName)
	values('John','Smith')
	insert into Students(FirstName,LastName)
	values('Jack','Smith')
	insert into Students(FirstName,LastName)
	values('Albert','Flores')
commit;


