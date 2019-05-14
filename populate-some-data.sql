USE [PersonalLoanOffer]
GO

INSERT INTO [dbo].[CLIENT]
           ([CLIENT_TYPE]
           ,[CLIENT_EGN_BULSTAT]
           ,[CLIENT_FULLNAME]
           ,[EMAIL]
           ,[TELEPHONE]
           ,[ADRESS_TEXT]
           ,[CLIENT_NOTE]
           ,[MODIF_DATE])
     VALUES
           ('N'
           ,'9612250000'
           ,'Group 4'
           ,'group4.unwe@gmail.com'
           ,'088888888'
           ,'SOFIA'
           ,'No Note'
           ,NULL)
GO

--DELETE FROM [dbo].[PROD_PERIODS]
--GO
INSERT INTO [dbo].[PROD_PERIODS]
           ([PROD_CODE]
           ,[PROD_PERIOD])
     VALUES
           (1,1),
		   (1, 2),
		   (1, 3),
		   (1, 4),
		   (1, 5),
		   (1, 6),
		   (1, 7),
		   (1, 8),
		   (1, 9),
		   (1, 10),
		   (2, 1),
		   (2, 2),
		   (2, 3),
		   (2, 4),
		   (2, 5),
		   (2, 6),
		   (2, 7),
		   (2, 8),
		   (2, 9),
		   (2, 10)
GO

INSERT INTO [dbo].[INTEREST]
           ([PROD_CODE]
           ,[PROD_PERIOD]
           ,[SUM_FROM]
           ,[SUM_TO],
		   [INTEREST_RATE])
     VALUES
           (1 , 1 ,1000,10000, 7.67),
		   (1 , 2 ,1000,10000, 7.47),
		   (1 , 3 ,1000,10000, 7.37),
		   (1 , 4 ,1000,10000, 7.27),
		   (1 , 5 ,1000,10000, 7.07),
		   (1 , 6 ,1000,10000, 6.67),
		   (2 , 1 ,3000,12000, 7.67),
		   (2 , 2 ,3000,12000, 7.47),
		   (2 , 3 ,3000,12000, 7.37),
		   (2 , 4 ,3000,12000, 7.27),
		   (2 , 5 ,3000,12000, 7.07),
		   (2 , 6 ,3000,12000, 6.67)
GO