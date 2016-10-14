declare 
@orderId int,    
@bookId int,    
@userId int
 
if not exists (select * from [User] where Username = 'bhogg')   
   INSERT into [dbo].[User] ([Firstname], [Lastname], [Username])         
   VALUES (N'Boss', N'Hogg', N'bhogg')
 
if not exists (select * from [User] where Username = 'jbob')    
   INSERT into [dbo].[User] ([Firstname], [Lastname], [Username])         
   VALUES (N'Jim', N'Bob', N'jbob')
 
if not exists (select * from [User] where Username = 'jdoe')    
   INSERT into [dbo].[User] ([Firstname], [Lastname], [Username])         
   VALUES (N'John', N'Doe', N'jdoe')
 
if not exists(select * from dbo.Order where Subject = 'Test Order') 
     begin    
	 select top 1 @bookId = BookId from Book order by BookId;    
	 select top 1 @userId = UserId from [User] order by UserId;
 
    insert into dbo.Order(Subject, StartDate, StatusId, CreatedDate, CreatedUserId)        
	    values('Test Task', getdate(), @bookId, getdate(), @userId);
 
    set @taskId = SCOPE_IDENTITY();         INSERT [dbo].[TaskUser] ([TaskId], [UserId])         VALUES (@taskId, @userId) end
 