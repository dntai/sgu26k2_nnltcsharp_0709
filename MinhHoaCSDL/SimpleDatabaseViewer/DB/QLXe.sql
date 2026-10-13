/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     21/04/2014 2:57:35 CH                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHANCONG') and o.name = 'FK_PHANCONG_PHANCONG_XE')
alter table PHANCONG
   drop constraint FK_PHANCONG_PHANCONG_XE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHANCONG') and o.name = 'FK_PHANCONG_PHANCONG2_NHANVIEN')
alter table PHANCONG
   drop constraint FK_PHANCONG_PHANCONG2_NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHANCONG')
            and   name  = 'PHANCONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHANCONG.PHANCONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHANCONG')
            and   name  = 'PHANCONG2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHANCONG.PHANCONG2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHANCONG')
            and   type = 'U')
   drop table PHANCONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('XE')
            and   type = 'U')
   drop table XE
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 nvarchar(5)          not null,
   HO                   nvarchar(20)         null,
   TEN                  nvarchar(20)         null,
   NGAYVAOLAM           datetime             null,
   MATKHAU              nvarchar(20)         null,
   constraint PK_NHANVIEN primary key nonclustered (MANV)
)
go

/*==============================================================*/
/* Table: PHANCONG                                              */
/*==============================================================*/
create table PHANCONG (
   MANV                 nvarchar(5)          not null,
   BANGSO               nvarchar(10)         not null,
   NGAYLAMVIEC          datetime             null,
   DOANHSO              int                  null,
   constraint PK_PHANCONG primary key nonclustered (MANV, BANGSO)
)
go

/*==============================================================*/
/* Index: PHANCONG2_FK                                          */
/*==============================================================*/
create index PHANCONG2_FK on PHANCONG (
MANV ASC
)
go

/*==============================================================*/
/* Index: PHANCONG_FK                                           */
/*==============================================================*/
create index PHANCONG_FK on PHANCONG (
BANGSO ASC
)
go

/*==============================================================*/
/* Table: XE                                                    */
/*==============================================================*/
create table XE (
   BANGSO               nvarchar(10)         not null,
   HANGXE               nvarchar(20)         null,
   NGAYSUDUNG           datetime             null,
   NGAYSUACHUA          datetime             null,
   constraint PK_XE primary key nonclustered (BANGSO)
)
go

alter table PHANCONG
   add constraint FK_PHANCONG_PHANCONG_XE foreign key (BANGSO)
      references XE (BANGSO)
go

alter table PHANCONG
   add constraint FK_PHANCONG_PHANCONG2_NHANVIEN foreign key (MANV)
      references NHANVIEN (MANV)
go

