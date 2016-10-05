if not exists(select * from dbo.Books where Name = 'Not Started')    
insert into dbo.Books(Name, Descriptions) values('Not Started', 0); 
if not exists(select * from dbo.Users where Name = 'In Progress')    
insert into dbo.Users(FirstName, LastName) values('In Progress', 1); 
if not exists(select * from dbo.Category where Name = 'Completed')    
insert into dbo.Category(Name, Descriptions) values('Completed', 2);