USE [master]
GO
/****** Object:  Database [store]    Script Date: 03/03/2022 21:58:42 ******/
CREATE DATABASE [store] ON  PRIMARY 
( NAME = N'store', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'store_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\store_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [store].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [store] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [store] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [store] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [store] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [store] SET ARITHABORT OFF 
GO
ALTER DATABASE [store] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [store] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [store] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [store] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [store] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [store] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [store] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [store] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [store] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [store] SET  DISABLE_BROKER 
GO
ALTER DATABASE [store] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [store] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [store] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [store] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [store] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [store] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [store] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [store] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [store] SET  MULTI_USER 
GO
ALTER DATABASE [store] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [store] SET DB_CHAINING OFF 
GO
USE [store]
GO
/****** Object:  Table [dbo].[achat]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[achat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_f] [int] NULL,
	[id_p] [int] NULL,
	[prix_a] [decimal](18, 0) NULL,
	[prix_v] [decimal](18, 0) NULL,
	[prix_r] [decimal](18, 0) NULL,
	[qte] [int] NULL,
	[date_a] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[charge]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[charge](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_u] [int] NULL,
	[charge_desc] [varchar](200) NULL,
	[montant] [decimal](18, 0) NULL,
	[date_charge] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[passwd] [nvarchar](50) NULL,
	[role_u] [nvarchar](50) NULL,
	[salaire] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facture_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facture_clt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_c] [int] NULL,
	[id_u] [int] NULL,
	[montant] [decimal](18, 0) NULL,
	[versé] [decimal](18, 0) NULL,
	[reste] [decimal](18, 0) NULL,
	[date_fact] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facture_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facture_four](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_f] [int] NULL,
	[montant] [decimal](18, 0) NULL,
	[versé] [decimal](18, 0) NULL,
	[reste] [decimal](18, 0) NULL,
	[date_fact] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fournisseur]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fournisseur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[telephone] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produit]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](100) NULL,
	[designation] [nvarchar](200) NULL,
	[prix_v] [decimal](18, 0) NULL,
	[prix_u] [decimal](18, 0) NULL,
	[prix_r] [decimal](18, 0) NULL,
	[qte] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reglement_facture_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reglement_facture_clt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_c] [int] NULL,
	[versé] [decimal](18, 0) NULL,
	[date_reg_clt] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reglement_facture_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reglement_facture_four](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_f] [int] NULL,
	[versé] [decimal](18, 0) NULL,
	[date_reg_four] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vente]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_f] [int] NULL,
	[id_p] [int] NULL,
	[prix_u] [decimal](18, 0) NULL,
	[qte] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[client] ON 
GO
INSERT [dbo].[client] ([id], [nom], [prenom]) VALUES (1, N'client', N'comptoir')
GO
SET IDENTITY_INSERT [dbo].[client] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([id], [nom], [prenom], [username], [passwd], [role_u], [salaire]) VALUES (1, N'admin', N'admin', N'admin', N'admin', N'admin', NULL)
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[fournisseur] ON 
GO
INSERT [dbo].[fournisseur] ([id], [nom], [prenom], [telephone]) VALUES (1, N'moi', N'meme', NULL)
GO
SET IDENTITY_INSERT [dbo].[fournisseur] OFF
GO
/****** Object:  Index [IndexOfachat]    Script Date: 03/03/2022 21:58:42 ******/
CREATE NONCLUSTERED INDEX [IndexOfachat] ON [dbo].[achat]
(
	[id_p] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IndexOfFacture_Client]    Script Date: 03/03/2022 21:58:42 ******/
CREATE NONCLUSTERED INDEX [IndexOfFacture_Client] ON [dbo].[facture_clt]
(
	[date_fact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IndexOfFacture_four]    Script Date: 03/03/2022 21:58:42 ******/
CREATE NONCLUSTERED INDEX [IndexOfFacture_four] ON [dbo].[facture_four]
(
	[date_fact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IndexOfProduct_Code]    Script Date: 03/03/2022 21:58:42 ******/
CREATE NONCLUSTERED INDEX [IndexOfProduct_Code] ON [dbo].[produit]
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IndexOfProduct_Des]    Script Date: 03/03/2022 21:58:42 ******/
CREATE NONCLUSTERED INDEX [IndexOfProduct_Des] ON [dbo].[produit]
(
	[designation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IndexOfvente]    Script Date: 03/03/2022 21:58:42 ******/
CREATE NONCLUSTERED INDEX [IndexOfvente] ON [dbo].[vente]
(
	[id_p] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[achat]  WITH CHECK ADD FOREIGN KEY([id_f])
REFERENCES [dbo].[facture_four] ([id])
GO
ALTER TABLE [dbo].[achat]  WITH CHECK ADD FOREIGN KEY([id_p])
REFERENCES [dbo].[produit] ([id])
GO
ALTER TABLE [dbo].[charge]  WITH CHECK ADD FOREIGN KEY([id_u])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[facture_clt]  WITH CHECK ADD FOREIGN KEY([id_c])
REFERENCES [dbo].[client] ([id])
GO
ALTER TABLE [dbo].[facture_clt]  WITH CHECK ADD FOREIGN KEY([id_u])
REFERENCES [dbo].[employee] ([id])
GO
ALTER TABLE [dbo].[facture_four]  WITH CHECK ADD FOREIGN KEY([id_f])
REFERENCES [dbo].[fournisseur] ([id])
GO
ALTER TABLE [dbo].[reglement_facture_clt]  WITH CHECK ADD FOREIGN KEY([id_c])
REFERENCES [dbo].[facture_clt] ([id])
GO
ALTER TABLE [dbo].[reglement_facture_four]  WITH CHECK ADD FOREIGN KEY([id_f])
REFERENCES [dbo].[facture_four] ([id])
GO
ALTER TABLE [dbo].[vente]  WITH CHECK ADD FOREIGN KEY([id_f])
REFERENCES [dbo].[facture_clt] ([id])
GO
ALTER TABLE [dbo].[vente]  WITH CHECK ADD FOREIGN KEY([id_p])
REFERENCES [dbo].[produit] ([id])
GO
/****** Object:  StoredProcedure [dbo].[add_achat]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_achat] 
@id_f int ,@id_p int ,@prix_a decimal,@prix_v decimal,@prix_r decimal,@qte int,@date_a date
as begin
insert into achat(id_f,id_p,prix_a,prix_v,prix_r,qte,date_a) values (@id_f ,@id_p ,@prix_a ,@prix_v ,@prix_r ,@qte ,@date_a )
end
GO
/****** Object:  StoredProcedure [dbo].[add_charge]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_charge]
@id_u int ,@charge_desc varchar(200),@montant decimal,@date_charge date
as begin
insert into charge(id_u ,charge_desc ,montant ,date_charge) values(@id_u  ,@charge_desc,@montant ,@date_charge)
end
GO
/****** Object:  StoredProcedure [dbo].[add_client]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_client] 
@nom nvarchar(50),@prenom nvarchar(50)
as
insert into client(nom,prenom) values(@nom,@prenom)
GO
/****** Object:  StoredProcedure [dbo].[add_facture_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_facture_clt]
@id_c int ,@id_u int,@montant decimal,@versé decimal,@reste decimal,@date_fact date
as 
begin
insert into facture_clt(id_c,id_u,montant,versé,reste,date_fact) 
values (@id_c  ,@id_u ,@montant ,@versé ,@reste ,@date_fact)
end
GO
/****** Object:  StoredProcedure [dbo].[add_facture_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_facture_four]
@id_c int ,@montant decimal,@versé decimal,@reste decimal,@date_fact date
as begin
insert into facture_four(id_c,montant,versé,reste,date_fact) 
values (@id_c ,@montant ,@versé ,@reste ,@date_fact)
end
GO
/****** Object:  StoredProcedure [dbo].[add_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_four] 
@nom nvarchar(50),@prenom nvarchar(50)
as
insert into fournisseur(nom,prenom) values(@nom,@prenom)
GO
/****** Object:  StoredProcedure [dbo].[add_produit]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_produit] 
@code varchar(100),@designation nvarchar(200),@prix_v decimal,@prix_u decimal,@prix_r decimal,@qte int
as insert into produit(code ,designation ,prix_v ,prix_u ,prix_r ,qte ) 
values (@code,@designation ,@prix_v ,@prix_u ,@prix_r ,@qte)
GO
/****** Object:  StoredProcedure [dbo].[add_reg_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_reg_clt]
@id int,@versé decimal,@date_reg_clt date
as begin 
insert into reglement_facture_clt (id_c ,versé ,date_reg_clt ) values(@id ,@versé ,@date_reg_clt)
end
GO
/****** Object:  StoredProcedure [dbo].[add_reg_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_reg_four]
@id int,@versé decimal,@date_reg_four date
as begin 
insert into reglement_facture_four(id_f ,versé ,date_reg_four ) values(@id ,@versé ,@date_reg_four)
end
GO
/****** Object:  StoredProcedure [dbo].[add_user]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_user] 
@nom nvarchar(50),@prenom nvarchar(50),@passwd nvarchar(50),@username nvarchar(50),@role_u nvarchar(50),@salaire decimal
as
insert into employee(nom,prenom,username,passwd,role_u,salaire) values(@nom,@prenom,@username,@passwd,@role_u,@salaire)
GO
/****** Object:  StoredProcedure [dbo].[add_vente]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[add_vente] 
@id_f int ,@id_p int ,@prix_u decimal,@qte int
as begin
insert into vente(id_f,id_p,prix_u,qte) values (@id_f ,@id_p ,@prix_u,@qte )
end
GO
/****** Object:  StoredProcedure [dbo].[get_prod]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_prod] 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code
end
GO
/****** Object:  StoredProcedure [dbo].[get_prod_by_code]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_prod_by_code] 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code 
end
GO
/****** Object:  StoredProcedure [dbo].[return_to_stock]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[return_to_stock]
@id int,@qte int
as
update produit set qte+=@qte where produit.id=@id
GO
/****** Object:  StoredProcedure [dbo].[search_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_clt] 
@nom nvarchar(50)
as select c.id,nom+''+prenom as 'Nom et prénom' from client as c where nom+''+prenom like @nom
GO
/****** Object:  StoredProcedure [dbo].[search_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_four] 
@nom nvarchar(50)
as select f.id,f.nom+''+f.prenom as 'Nom et prénom', f.telephone as 'telephone' from fournisseur as f where f.nom+''+f.prenom like @nom
GO
/****** Object:  StoredProcedure [dbo].[search_full_prod]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_full_prod] 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',p.prix_v as 'Prix d"achat',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end
GO
/****** Object:  StoredProcedure [dbo].[search_prod]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_prod] 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end
GO
/****** Object:  StoredProcedure [dbo].[search_user]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_user] 
@username nvarchar(50),@passwd nvarchar(50)
as select e.id,e.username,e.passwd,e.role_u  from employee as e where e.username=@username and e.passwd=@passwd
GO
/****** Object:  StoredProcedure [dbo].[show_achat_all]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_achat_all] 
@date_d date,@date_f date
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' ,a.date_a as 'date'
from achat as a , produit as p
where  p.id=a.id_p
end
GO
/****** Object:  StoredProcedure [dbo].[show_achat_by_date]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_achat_by_date] 
@date_d date,@date_f date
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' ,a.date_a as 'date'
from achat as a , produit as p
where a.date_a between @date_d and @date_f
and   p.id=a.id_p
end
GO
/****** Object:  StoredProcedure [dbo].[show_achat_by_facture]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_achat_by_facture]
@id int
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' ,a.date_a as 'date'
from achat as a , produit as p
where a.id_f=@id
and   p.id=a.id_p
end
GO
/****** Object:  StoredProcedure [dbo].[show_achat_by_prod]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[show_achat_by_prod]
@id int
as begin
select a.id,a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' 
from achat as a , produit as p
where a.id_p=@id
and   p.id=a.id_p
and   a.qte <> 0
end
GO
/****** Object:  StoredProcedure [dbo].[show_charge_bydate]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_charge_bydate]
@date_d date,@date_f date
as begin
select  c.id,c.charge_desc as 'Description',c.montant as 'Montant',c.date_charge as 'date',e.nom as 'Utilisateur' from charge as c , employee as e
where c.date_charge between @date_d and @date_f
and   c.id_u=e.id
end
GO
/****** Object:  StoredProcedure [dbo].[show_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_clt]
as select c.id,nom+''+prenom as 'Nom et prénom' from client as c
GO
/****** Object:  StoredProcedure [dbo].[show_empl]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_empl]
as select e.id,e.nom+''+e.prenom as 'Nom et prénom',e.username as 'Utilisateur', e.passwd as 'mot de passe',e.role_u as 'Role',e.salaire,'salaire'  from employee as e
GO
/****** Object:  StoredProcedure [dbo].[show_facture_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_clt]
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',fc.date_fact as 'Date',
c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' from facture_clt as fc,client as c , employee as e
where c.id=fc.id_c and e.id=fc.id_u
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_clt_byDate]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_clt_byDate]
@date1 date,@date2 date 
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' 
from facture_clt as fc,client as c , employee as e where fc.date_fact between @date1 and @date2 and (c.id=fc.id_c and e.id=fc.id_u)
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_clt_byId]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_clt_byId]
@id int 
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' 
from facture_clt as fc,client as c , employee as e 
where fc.id=@id and c.id=fc.id_c and e.id=fc.id_u
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_clt_byNameC]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_clt_byNameC]
@nom nvarchar(50)
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',fc.id_u as 'Vendeur' 
from facture_clt as fc,client as c , employee as e where c.nom+''+c.prenom like @nom and (c.id=fc.id_c and e.id=fc.id_u)
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_four]
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',ff.date_fact as 'Date',
f.nom+''+f.prenom as 'Fournisseur' from facture_four as ff,fournisseur as f 
where f.id=ff.id_f 
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_four_byDate]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_four_byDate]
@date1 date,@date2 date 
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',
ff.date_fact as 'Date',f.nom+''+f.prenom as 'Fournisseur'
from facture_four as ff,fournisseur as f 
where (f.id=ff.id_f) and ff.date_fact between @date1 and @date2  
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_four_byId]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_four_byId]
@id int 
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',
ff.date_fact as 'Date',f.nom+''+f.prenom as 'Fournisseur'
from facture_four as ff,fournisseur as f 
where ff.id=@id and f.id=ff.id_f
end
GO
/****** Object:  StoredProcedure [dbo].[show_facture_four_byNameC]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_facture_four_byNameC]
@nom nvarchar(50)
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',
ff.date_fact as 'Date',f.nom+''+f.prenom as 'Fournisseur'
from facture_four as ff,fournisseur as f 
where (f.id=ff.id_f) and  f.nom+''+f.prenom like @nom 
end
GO
/****** Object:  StoredProcedure [dbo].[show_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_four]
as select f.id,f.nom+''+f.prenom as 'Nom et prénom' from fournisseur as f
GO
/****** Object:  StoredProcedure [dbo].[show_prod]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_prod] 
as 
select p.id,p.code as 'Code bare',p.designation as 'Désignation',p.prix_v as 'Prix d"achat',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' from produit as p
GO
/****** Object:  StoredProcedure [dbo].[show_prod_without_code_barre]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_prod_without_code_barre] 
as begin
select p.id,p.designation as 'Désignation',prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null
end
GO
/****** Object:  StoredProcedure [dbo].[show_prod_withouut_code_barre_by_name]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_prod_withouut_code_barre_by_name]
@des nvarchar(200)
as begin
select p.id,p.designation as 'Désignation',prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null and p.designation like '%'+@des+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[show_reglement_by_id_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[show_reglement_by_id_clt]
@id int 
as begin
select r.versé as 'Versé' ,r.date_reg_clt 'Date' from reglement_facture_clt as r,facture_clt as f 
where  r.id_c=f.id
and    f.id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[show_reglement_by_id_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[show_reglement_by_id_four]
@id int 
as begin
select rf.versé as 'Versé' ,rf.date_reg_four 'Date' from reglement_facture_four as rf,facture_four as f 
where  rf.id_f=f.id
and    f.id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[show_vente_full]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[show_vente_full]
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',v.prix_u as 'Prix ',v.qte as 'Qte' 
from vente as v , produit as p
where  p.id=v.id_p
end
GO
/****** Object:  StoredProcedure [dbo].[update_charge]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_charge]
@id int,@description varchar(200),@montant decimal
as begin
update charge set charge_desc=@description,montant=@montant where charge.id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[update_facture_clt]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_facture_clt]
@id int ,@montant decimal,@versé decimal,@reste decimal
as begin
update facture_clt  set montant=@montant,versé=@versé,reste=@reste
where  id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[update_facture_four]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_facture_four]
@id int ,@montant decimal,@versé decimal,@reste decimal
as begin
update facture_four  set montant=@montant,versé=@versé,reste=@reste
where  id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[update_produit]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_produit] 
@id int,@prix_v decimal,@prix_u decimal,@prix_r decimal,@qte int
as update produit set  prix_v=@prix_v ,prix_u=@prix_u ,prix_r=@prix_r ,qte=+@qte
where produit.id=@id
GO
/****** Object:  StoredProcedure [dbo].[update_user]    Script Date: 03/03/2022 21:58:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_user] 
@nom nvarchar(50),@prenom nvarchar(50),@passwd nvarchar(50),@username nvarchar(50),@role_u nvarchar(50),@salaire decimal,@id int
as
update employee set nom=@nom,prenom=@prenom,username=@username,passwd=@passwd,role_u=@role_u,salaire=@salaire where employee.id=@id
GO
USE [master]
GO
ALTER DATABASE [store] SET  READ_WRITE 
GO
