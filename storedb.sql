create database store
use store

create table employee(
id int primary key identity(1,1),
nom nvarchar(50),
prenom nvarchar(50),
username nvarchar(50),
passwd nvarchar(50),
role_u nvarchar(50),
salaire decimal)
create proc add_user 
@nom nvarchar(50),@prenom nvarchar(50),@passwd nvarchar(50),@username nvarchar(50),@role_u nvarchar(50),@salaire decimal
as
insert into employee(nom,prenom,username,passwd,role_u,salaire) values(@nom,@prenom,@username,@passwd,@role_u,@salaire)
create proc search_user 
@username nvarchar(50),@passwd nvarchar(50)
as select e.id,e.username,e.passwd,e.role_u  from employee as e where e.username=@username and e.passwd=@passwd
create proc show_empl
as select e.id,e.nom+''+e.prenom as 'Nom et prénom',e.username as 'Utilisateur', e.passwd as 'mot de passe',e.role_u as 'Role',e.salaire,'salaire'  from employee as e
create proc update_user 
@nom nvarchar(50),@prenom nvarchar(50),@passwd nvarchar(50),@username nvarchar(50),@role_u nvarchar(50),@salaire decimal,@id int
as
update employee set nom=@nom,prenom=@prenom,username=@username,passwd=@passwd,role_u=@role_u,salaire=@salaire where employee.id=@id
insert into employee(nom,prenom,username,passwd,role_u) values('admin','admin','admin','admin','admin')
--------------------------------------------FIN POUR EMPLOYEE---------------------------
create table client (
id int primary key identity(1,1),
nom nvarchar(50),	
prenom nvarchar(50))
create proc add_client 
@nom nvarchar(50),@prenom nvarchar(50)
as
insert into client(nom,prenom) values(@nom,@prenom)
create proc search_clt 
@nom nvarchar(50)
as select c.id,nom+''+prenom as 'Nom et prénom' from client as c where nom+''+prenom like @nom
create proc show_clt
as select c.id,nom+''+prenom as 'Nom et prénom' from client as c
insert into client(nom,prenom) values('client','comptoir')
create table fournisseur (
id int primary key identity(1,1),
nom nvarchar(50),
prenom nvarchar(50),
telephone varchar(50))
create proc add_four 
@nom nvarchar(50),@prenom nvarchar(50)
as
insert into fournisseur(nom,prenom) values(@nom,@prenom)
create proc search_four 
@nom nvarchar(50)
as select f.id,f.nom+''+f.prenom as 'Nom et prénom', f.telephone as 'telephone' from fournisseur as f where f.nom+''+f.prenom like @nom
create proc show_four
as select f.id,f.nom+''+f.prenom as 'Nom et prénom' from fournisseur as f
insert into fournisseur(nom,prenom) values('moi','meme')
-----------------------------FIN POUR FOURNISSEUR--------------------
create table facture_clt (
id int primary key identity(1,1),
id_c int foreign key references client(id),
id_u int foreign key references employee(id),
montant decimal,
versé decimal,
reste decimal,
date_fact date)
create proc add_facture_clt
@id_c int ,@id_u int,@montant decimal,@versé decimal,@reste decimal,@date_fact date
as begin
insert into facture_clt(id_c,id_u,montant,versé,reste,date_fact) 
values (@id_c  ,@id_u ,@montant ,@versé ,@reste ,@date_fact)
end
create proc show_facture_clt
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',fc.date_fact as 'Date',
c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' from facture_clt as fc,client as c , employee as e
where c.id=fc.id_c and e.id=fc.id_u
end
create proc show_facture_clt_byId
@id int 
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' 
from facture_clt as fc,client as c , employee as e 
where fc.id=@id and c.id=fc.id_c and e.id=fc.id_u
end
create proc show_facture_clt_byDate
@date1 date,@date2 date 
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' 
from facture_clt as fc,client as c , employee as e where fc.date_fact between @date1 and @date2 and (c.id=fc.id_c and e.id=fc.id_u)
end
create proc show_facture_clt_byNameC
@nom nvarchar(50)
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',fc.id_u as 'Vendeur' 
from facture_clt as fc,client as c , employee as e where c.nom+''+c.prenom like @nom and (c.id=fc.id_c and e.id=fc.id_u)
end
create proc update_facture_clt
@id int ,@montant decimal,@versé decimal,@reste decimal
as begin
update facture_clt  set montant=@montant,versé=@versé,reste=@reste
where  id=@id
end
--------------------------FIN POUR FACTURE CLIENT---------------------
create table facture_four (
id int primary key identity(1,1),
id_f int foreign key references fournisseur(id),
montant decimal,
versé decimal,
reste decimal,
date_fact date)
create proc add_facture_four
@id_c int ,@montant decimal,@versé decimal,@reste decimal,@date_fact date
as begin
insert into facture_four(id_f,montant,versé,reste,date_fact) 
values (@id_c ,@montant ,@versé ,@reste ,@date_fact)
end
create proc show_facture_four
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',ff.date_fact as 'Date',
f.nom+''+f.prenom as 'Fournisseur' from facture_four as ff,fournisseur as f 
where f.id=ff.id_f 
end
create proc show_facture_four_byId
@id int 
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',
ff.date_fact as 'Date',f.nom+''+f.prenom as 'Fournisseur'
from facture_four as ff,fournisseur as f 
where ff.id=@id and f.id=ff.id_f
end
create proc update_facture_four
@id int ,@montant decimal,@versé decimal,@reste decimal
as begin
update facture_four  set montant=@montant,versé=@versé,reste=@reste
where  id=@id
end
create proc show_facture_four_byDate
@date1 date,@date2 date 
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',
ff.date_fact as 'Date',f.nom+''+f.prenom as 'Fournisseur'
from facture_four as ff,fournisseur as f 
where (f.id=ff.id_f) and ff.date_fact between @date1 and @date2  
end
create proc show_facture_four_byNameC
@nom nvarchar(50)
as begin
select ff.id as 'N° bon',ff.montant as 'Total',ff.versé as 'Versé',ff.reste as 'Reste',
ff.date_fact as 'Date',f.nom+''+f.prenom as 'Fournisseur'
from facture_four as ff,fournisseur as f 
where (f.id=ff.id_f) and  f.nom+''+f.prenom like @nom 
end
----------------------FIN POUR FACTURE FOURNISSEUR-------------------

create table produit(
id int primary key identity(1,1),
code varchar(100),
designation nvarchar(200),
prix_v decimal,
prix_u decimal,
prix_r decimal,
qte int)
create proc add_produit 
@code varchar(100),@designation nvarchar(200),@prix_v decimal,@prix_u decimal,@prix_r decimal,@qte int
as insert into produit(code ,designation ,prix_v ,prix_u ,prix_r ,qte ) 
values (@code,@designation ,@prix_v ,@prix_u ,@prix_r ,@qte)
create proc update_produit 
@id int,@prix_v decimal,@prix_u decimal,@prix_r decimal,@qte int
as update produit set  prix_v=@prix_v ,prix_u=@prix_u ,prix_r=@prix_r ,qte=+@qte
where produit.id=@id

create proc show_prod 
as 
select p.id,p.code as 'Code bare',p.designation as 'Désignation',p.prix_v as 'Prix d"achat',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' from produit as p
create proc get_prod 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code
end
create proc search_prod 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end
create proc search_full_prod 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',p.prix_v as 'Prix d"achat',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end
create proc show_prod_without_code_barre 
as begin
select p.id,p.designation as 'Désignation',prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null
end
create proc show_prod_withouut_code_barre_by_name
@des nvarchar(200)
as begin
select p.id,p.designation as 'Désignation',prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null and p.designation like '%'+@des+'%'
end
create proc get_prod_by_code 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code 
end
---------------------Fin pour Produit--------
create table achat(
id int primary key identity(1,1),
id_f int foreign key references facture_four(id),
id_p int foreign key references produit(id),
prix_a decimal,
prix_v decimal,
prix_r decimal,
qte int,
date_a date)

create proc add_achat 
@id_f int ,@id_p int ,@prix_a decimal,@prix_v decimal,@prix_r decimal,@qte int,@date_a date
as begin
insert into achat(id_f,id_p,prix_a,prix_v,prix_r,qte,date_a) values (@id_f ,@id_p ,@prix_a ,@prix_v ,@prix_r ,@qte ,@date_a )
end

create proc show_achat_by_date 
@date_d date,@date_f date
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' ,a.date_a as 'date'
from achat as a , produit as p
where a.date_a between @date_d and @date_f
and   p.id=a.id_p
end
create proc show_achat_by_facture
@id int
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' ,a.date_a as 'date'
from achat as a , produit as p
where a.id_f=@id
and   p.id=a.id_p
end
alter proc show_achat_by_prod
@id int
as begin
select a.id,a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte' 
from achat as a , produit as p
where a.id_p=@id
and   p.id=a.id_p
and   a.qte <> 0
end
create proc sale__from_achat
@id int,@id_p int,@qte int
as begin
update achat set qte=-@qte where achat.id=@id
end

---------------------------------Fin Pour Achat-----------------
create table vente(
id int primary key identity(1,1),
id_f int foreign key references facture_clt(id),
id_p int foreign key references produit(id),
prix_u decimal,
qte int)

create proc add_vente 
@id_f int ,@id_p int ,@prix_u decimal,@qte int
as begin
insert into vente(id_f,id_p,prix_u,qte) values (@id_f ,@id_p ,@prix_u,@qte )
end

create proc show_vente_full
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',v.prix_u as 'Prix ',v.qte as 'Qte' 
from vente as v , produit as p
where  p.id=v.id_p
end
create proc show_vente_by_facture
@id int
as begin
select p.code as 'Code Barre',p.designation as 'Désignation',v.prix_u as 'Prix ',v.qte as 'Qte' 
from vente as v , produit as p
where  p.id=v.id_p
and    v.id_f=@id
end

---------------------Fin pour vente--------------------
create table charge(
id int primary key identity(1,1),
id_u int foreign key references employee(id),
charge_desc varchar(200),
montant decimal,
date_charge date)

create proc add_charge
@id_u int ,@charge_desc varchar(200),@montant decimal,@date_charge date
as begin
insert into charge(id_u ,charge_desc ,montant ,date_charge) values(@id_u  ,@charge_desc,@montant ,@date_charge)
end

create proc show_charge_bydate
@date_d date,@date_f date
as begin
select  c.id,c.charge_desc as 'Description',c.montant as 'Montant',c.date_charge as 'date',e.nom as 'Utilisateur' from charge as c , employee as e
where c.date_charge between @date_d and @date_f
and   c.id_u=e.id
end

create proc update_charge
@id int,@description varchar(200),@montant decimal
as begin
update charge set charge_desc=@description,montant=@montant where charge.id=@id
end

----------------Fin pour charge----------------
Create proc return_to_stock
@id int,@qte int
as
update produit set qte+=@qte where produit.id=@id


---------Fin des procedure blk nes7a9ouhoum--------------
create table reglement_facture_clt (
id int primary key identity(1,1),
id_c int foreign key references facture_clt(id),
versé decimal,
date_reg_clt date)

create proc add_reg_clt
@id int,@versé decimal,@date_reg_clt date
as begin 
insert into reglement_facture_clt (id_c ,versé ,date_reg_clt ) values(@id ,@versé ,@date_reg_clt)
end

create  proc show_reglement_by_id_clt
@id int 
as begin
select r.versé as 'Versé' ,r.date_reg_clt 'Date' from reglement_facture_clt as r,facture_clt as f 
where  r.id_c=f.id
and    f.id=@id
end
----------------Fin pour reglement facture client---------------
create table reglement_facture_four (
id int primary key identity(1,1),
id_f int foreign key references facture_four(id),
versé decimal,
date_reg_four date)

create proc add_reg_four
@id int,@versé decimal,@date_reg_four date
as begin 
insert into reglement_facture_four(id_f ,versé ,date_reg_four ) values(@id ,@versé ,@date_reg_four)
end

create  proc show_reglement_by_id_four
@id int 
as begin
select rf.versé as 'Versé' ,rf.date_reg_four 'Date' from reglement_facture_four as rf,facture_four as f 
where  rf.id_f=f.id
and    f.id=@id
end

create index IndexOfProduct_Des 
on produit(designation)
create index IndexOfProduct_Code 
on produit(code)
create index IndexOfFacture_Client 
on facture_clt(date_fact)
create index IndexOfFacture_four 
on facture_four(date_fact)
create index IndexOfachat 
on achat(id_p)
create index IndexOfvente
on vente(id_p)
--------------------03/03/2022 time: 23:18---------------
alter proc add_four 
@nom nvarchar(50),@prenom nvarchar(50),@phone varchar(50)
as
insert into fournisseur(nom,prenom,telephone) values(@nom,@prenom,@phone)
alter proc search_four 
@nom nvarchar(50)
as select f.id,f.nom+' '+f.prenom as 'Nom et prénom', f.telephone as 'telephone' from fournisseur as f where f.nom+' '+f.prenom like '%'+@nom+'%'
alter proc show_four
as select f.id,f.nom+' '+f.prenom as 'Nom et prénom', f.telephone as 'telephone' from fournisseur as f
--------------------04/03/2022 time: 02:18---------------
create proc get_last_id_four
as Select Ident_Current('fournisseur') as 'Id'
alter table achat
add qte_vendue int
----- qte vendu nes7a9ha bach na3raf wach mn sel3a tba3t mn stock gdim en cas win kayn produit gdim w 3awed jbnah-----
---------04/03/2022 time: 11:30----------
alter proc show_achat_by_prod
@id int
as begin
select a.id,p.designation as 'Désignation',a.prix_a as 'Prix Achat',a.prix_v as 'Prix Vente',a.prix_r 'Prix Remise',a.qte as 'Qte',a.qte-a.qte_vendue as 'reste' 
from achat as a , produit as p
where a.id_p=@id
and   p.id=a.id_p
and   (a.qte-a.qte_vendue) <> 0
end
----------------04/03/2022 time: 11:39---------------
alter proc get_prod_by_code 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code 
end
---------- 18:37 05/03/2022----
alter proc show_prod_without_code_barre 
as begin
select p.id,p.designation as 'Désignation',prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null or p.code =''
end

alter proc search_full_prod 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Achat',p.prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end
alter proc show_prod_withouut_code_barre_by_name
@des nvarchar(200)
as begin
select p.id,p.designation as 'Désignation',prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null and p.designation like '%'+@des+'%'
end
---------- 14:31 04/03/2022--
alter proc get_prod_by_code 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code 
end


alter proc search_full_prod 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',p.prix_v as 'Prix d"achat',
prix_u as 'Prix Unitaire',p.prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end

alter proc show_prod_without_code_barre_by_name
@des nvarchar(200)
as begin
select p.id,p.designation as 'Désignation',prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null and p.designation like '%'+@des+'%'
end

ALTER proc [dbo].[show_prod_without_code_barre] 
as begin
select p.id,p.designation as 'Désignation', p.prix_u as 'Prix d"achat'  ,p.prix_v as 'Prix vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null
end

alter proc search_full_prod 
@code varchar(100),@des nvarchar(200)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',
prix_u as 'Prix Achat',p.prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code or p.designation=@des
end
ALTER proc [dbo].[show_prod_withouut_code_barre_by_name]
@des nvarchar(200)
as begin
select p.id,p.designation as 'Désignation',p.prix_u as 'prix d"achat',p.prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null and p.designation like '%'+@des+'%'
end
---------------04/03/2022 time:17:36--------------
create proc sale__from_achat
@id int,@id_p int,@qte int
as begin
update achat set qte_vendue=-@qte where achat.id=@id
end
begin
update produit set qte=-@qte where produit.id=@id_p
end
-----------22:55 04/03/2022--------
alter proc show_prod_without_code_barre 
as begin
select p.id,p.designation as 'Désignation',prix_u as 'Prix Unitaire',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where p.code is null or p.code =''
end
alter proc show_prod_withouut_code_barre_by_name
@des nvarchar(200)
as begin
select p.id,p.designation as 'Désignation',prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte'
from produit as p
where (p.code is null or p.code='') and p.designation like '%'+@des+'%'
end
---------05/03/2022 13:48-------
create proc get_last_id_clt
as Select Ident_Current('client') as 'Id'
alter proc search_clt 
@nom nvarchar(50)
as select c.id,nom+''+prenom as 'Nom et prénom' from client as c where nom+''+prenom like '%'+@nom+'%'

create proc get_id_achat_by_prod
@id int
as 
begin
select   MAX(a.id) as 'id'
from achat as a , produit as p
where a.id_p=@id
and   p.id=a.id_p
and   (a.qte-a.qte_vendue) <> 0
end

alter proc get_prod_by_code 
@code varchar(100)
as begin
select p.id,p.code as 'Code bare',p.designation as 'Désignation',prix_u as 'Prix Achat',
prix_v as 'Prix Vente',p.prix_r as 'Prix de Remise' , p.qte as 'Qte' 
from produit as p
where p.code=@code 
end

----------------------02:17 06/03/2022---------
alter table facture_clt add remise decimal
alter proc add_facture_clt
@id_c int ,@id_u int,@montant decimal,@versé decimal,@reste decimal,@remise decimal,@date_fact date
as begin
insert into facture_clt(id_c,id_u,montant,versé,reste,remise,date_fact) 
values (@id_c  ,@id_u ,@montant ,@versé ,@reste ,@remise,@date_fact)
end

alter proc show_facture_clt
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.remise as 'remise',fc.reste as 'Reste',fc.date_fact as 'Date',
c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' from facture_clt as fc,client as c , employee as e
where c.id=fc.id_c and e.id=fc.id_u
end

alter proc show_facture_clt_byId
@id int 
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.remise as 'remise',fc.reste as 'Reste',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' 
from facture_clt as fc,client as c , employee as e 
where fc.id=@id and c.id=fc.id_c and e.id=fc.id_u
end

alter proc show_facture_clt_byDate
@date1 date,@date2 date 
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',fc.remise as 'remise',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',e.nom as 'Vendeur' 
from facture_clt as fc,client as c , employee as e where fc.date_fact between @date1 and @date2 and (c.id=fc.id_c and e.id=fc.id_u)
end

alter proc show_facture_clt_byNameC
@nom nvarchar(50)
as begin
select fc.id as 'N° bon',fc.montant as 'Total',fc.versé as 'Versé',fc.reste as 'Reste',fc.remise as 'remise',
fc.date_fact as 'Date',c.nom+''+c.prenom as 'Client',fc.id_u as 'Vendeur' 
from facture_clt as fc,client as c , employee as e where c.nom+''+c.prenom like @nom and (c.id=fc.id_c and e.id=fc.id_u)
end
