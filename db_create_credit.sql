/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     26/10/2014 20:14:21                          */
/*==============================================================*/


/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT
(
   CLIENT_ID int identity,
   CLIENT_TYPE char(1) not null,
   CLIENT_EGN_BULSTAT nvarchar(13) not null,
   CLIENT_FULLNAME nvarchar(400) not null,
   EMAIL nvarchar(400) null,
   TELEPHONE nvarchar(400) null,
   ADRESS_TEXT nvarchar(400) not null,
   CLIENT_NOTE nvarchar(400) null,
   MODIF_DATE datetime null,
   constraint PK_CLIENT primary key (CLIENT_ID)
)
go

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
create table USERS
(
   USER_ID int identity,
   USERNAME nvarchar(50) not null,
   PASSWORD nvarchar(50) not null,
   constraint PK_USERS primary key (USER_ID)
)
go

/*==============================================================*/
/* Index: IDX_CLIENT_EGN_BULSTAT_UQ                             */
/*==============================================================*/
create unique index IDX_CLIENT_EGN_BULSTAT_UQ on CLIENT (
CLIENT_TYPE ASC,
CLIENT_EGN_BULSTAT ASC
)
go

/*==============================================================*/
/* Table: CREDIT                                                */
/*==============================================================*/
create table CREDIT
(
   CREDIT_ID int identity,
   CREDIT_NO nvarchar(50) not null,
   CREDIT_DATE datetime not null,
   CREDIT_PERIOD int not null,
   CREDIT_END_DATE datetime not null,
   CREDIT_BEGIN_DATE datetime not null,
   CLIENT_ID int not null,
   PROD_CODE int null,
   CREDIT_SUM numeric(10,2) not null,
   CREDIT_NOTE nvarchar(400) null,
   MODIF_DATE datetime null,
   constraint PK_CREDIT primary key (CREDIT_ID)
)
go

/*==============================================================*/
/* Index: IDX_CREDIT_NO_UQ                                      */
/*==============================================================*/
create unique index IDX_CREDIT_NO_UQ on CREDIT (
CREDIT_NO ASC
)
go

/*==============================================================*/
/* Table: CREDIT_PLAN                                           */
/*==============================================================*/
create table CREDIT_PLAN
(
   MATURITY_ID int identity,
   CREDIT_ID int null,
   MATURITY_DATE datetime not null,
   MATURITY_SUM numeric(15,2) not null,
   MATURITY_NOTE nvarchar(400) not null,
   MODIF_DATE datetime null,
   constraint PK_CREDIT_PLAN primary key (MATURITY_ID)
)
go

/*==============================================================*/
/* Index: IDX_MATURITY_UQ                                       */
/*==============================================================*/
create unique index IDX_MATURITY_UQ on CREDIT_PLAN (
MATURITY_DATE ASC
)
go

/*==============================================================*/
/* Table: CREDIT_PRODUCT                                        */
/*==============================================================*/
create table CREDIT_PRODUCT
(
   PROD_CODE int identity,
   PROD_NAME nvarchar(100) not null,
   PROD_ACTIVE char(1) not null default 'N'
      constraint CKC_PROD_ACTIVE_CREDIT_P check (PROD_ACTIVE in ('Y','N')),
   PROD_SUM_FROM numeric(10,2) not null
      constraint CKC_PROD_SUM_FROM_CREDIT_P check (PROD_SUM_FROM >= 0),
   PROD_SUM_TO numeric(10,2) not null,
   MODIF_DATE datetime null,
   constraint PK_CREDIT_PRODUCT primary key (PROD_CODE)
)
go

/*==============================================================*/
/* Index: IDX_PROD_NAME_UQ                                      */
/*==============================================================*/
create unique index IDX_PROD_NAME_UQ on CREDIT_PRODUCT (
PROD_NAME ASC
)
go

/*==============================================================*/
/* Table: INTEREST                                              */
/*==============================================================*/
create table INTEREST
(
   PROD_CODE int not null,
   PROD_PERIOD int not null,
   SUM_FROM numeric(10,2) not null,
   SUM_TO numeric(10,2) not null,
   INTEREST_RATE numeric(10,2) not null,
   constraint PK_INTEREST primary key (PROD_CODE, PROD_PERIOD, SUM_FROM, SUM_TO)
)
go

/*==============================================================*/
/* Table: PROD_PERIODS                                          */
/*==============================================================*/
create table PROD_PERIODS
(
   PROD_CODE int not null,
   PROD_PERIOD int not null,
   constraint PK_PROD_PERIODS primary key (PROD_CODE, PROD_PERIOD)
)
go

alter table CREDIT
   add constraint FK_CREDIT_REFERENCE_CREDIT_P foreign key (PROD_CODE)
      references CREDIT_PRODUCT (PROD_CODE)
go

alter table CREDIT
   add constraint FK_CREDIT_REFERENCE_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go


alter table CREDIT_PLAN
   add constraint FK_CREDIT_P_REFERENCE_CREDIT foreign key (CREDIT_ID)
      references CREDIT (CREDIT_ID)
go

alter table INTEREST
   add constraint FK_INTEREST_REFERENCE_PROD_PER foreign key (PROD_CODE, PROD_PERIOD)
      references PROD_PERIODS (PROD_CODE, PROD_PERIOD)
         on delete cascade
go

alter table PROD_PERIODS
   add constraint FK_PROD_PER_REFERENCE_CREDIT_P foreign key (PROD_CODE)
      references CREDIT_PRODUCT (PROD_CODE)
         on delete cascade
go

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


