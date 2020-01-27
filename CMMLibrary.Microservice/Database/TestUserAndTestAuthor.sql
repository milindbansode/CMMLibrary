USE [CMMLibrary]
GO

Insert into Users Values('System', 'System', 1, '7049150707', 'milind.bansode@gmail.com', 'test address'
, 1, 'milind.bansode@gmail.com', 'milind123', 1, '1234', getdate(), 1, getdate(), 1)
 
 go

INSERT INTO [dbo].[Authors]
           ([Name]
           ,[Decription]
           ,[RegionalDecription]
           ,[TotalBooksWritten]
           ,[email]
           ,[CreatedDate]
           ,[CreatedBy]
           ,[ModifiedDate]
           ,[ModifiedBy])
     VALUES
           ('Test'
           ,'Test'
           ,'Test'
           ,5
           ,'Test@test.com'
           ,getdate()
           ,1
           ,getdate()
           ,1
		   )
GO


