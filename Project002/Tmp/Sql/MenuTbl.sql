/*
MenuTblテーブル使用スクリプト
*/

use mydatabase
go

create table MenuTbl(
	MenuId int NOT NULL,
	MenuName nvarchar(255) NULL,
 CONSTRAINT [PK_MenuTbl] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

insert into MenuTbl values
(101,N'人事部'),
(201,N'経理部'),
(301,N'営業部'),
(401,N'開発部'),
(501,N'事業部'),
(601,N'製造部'),
(701,N'その他'),
(801,N'管理者'),
(901,N'総務部')

select * from [myDatabase].[dbo].[MenuTbl]