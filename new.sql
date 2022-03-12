ALTER PROC verify_login
@usrname NVARCHAR(30),
@pwd NVARCHAR(30)
AS
SELECT id,nom,prenom,role_u FROM employee 
WHERE username = @usrname and passwd = @pwd
----------NEW-----------
--------------------------------------------

ALTER PROC show_empl
AS
SELECT id,nom,prenom,role_u,salaire,date_of_join,date_of_departure,username,passwd from employee
---------------------------------------------------------------------

alter table employee
add date_of_join date;

alter table employee
add date_of_departure date;
-------------------New------------
---------------------------

ALTER PROC	search_worker
@value NVARCHAR(100)
as
SELECT id,nom,prenom,role_u,salaire,date_of_join,date_of_departure,username,passwd FROM employee
where CONVERT(nvarchar(100),id)=@value or nom=@value or prenom=@value or role_u=@value
-----------NEW-----------
--------------------------------------------------------------------------------------------

ALTER PROC	search_worker_by_oui
as
SELECT id,nom,prenom,role_u,salaire,date_of_join,date_of_departure,username,passwd FROM employee
where CONVERT(nvarchar(100),date_of_departure) is null
-----------NEW-----------
-----------------------------------------------------

ALTER PROC search_worker_by_non
as
SELECT id,nom,prenom,role_u,salaire,date_of_join,date_of_departure,username,passwd FROM employee
where CONVERT(nvarchar(100),date_of_departure) is not null
-----------NEW-----------
---------------------------------------------------------

ALTER proc verify_username
@username nvarchar(30)
as
select id from employee where username = @username
-----------NEW-----------
--------------------------------------------------

ALTER PROC add_user
@first_name_worker NVARCHAR(30),
@last_name_worker NVARCHAR(30),
@role_worker NVARCHAR(15),
@salary_worker decimal,
@username_worker NVARCHAR(30),
@password_worker NVARCHAR(30),
@date_of_join_worker DATE
AS
insert into employee(nom,prenom,username,passwd,role_u,salaire,date_of_join) 
values(@first_name_worker,@last_name_worker,@username_worker,@password_worker,@role_worker,@salary_worker,@date_of_join_worker) 
-------------------------------------------------------------------------------------------------------------------------------

ALTER PROC update_user
@id INT,
@first_name_worker NVARCHAR(30),
@last_name_worker NVARCHAR(30),
@role_worker NVARCHAR(15),
@salary_worker decimal,
@username_worker NVARCHAR(30),
@password_worker NVARCHAR(30),
@date_of_join_worker DATE
AS
UPDATE employee SET
nom=@first_name_worker, prenom=@last_name_worker, role_u=@role_worker, salaire=@salary_worker, username=@username_worker, 
passwd=@password_worker, date_of_join=@date_of_join_worker
WHERE id=@id 
------------

CREATE proc firing_worker
@id int,
@date date
as
update employee
set date_of_departure=@date where id=@id
----------NEW---------
----------------------------------------

ALTER PROC show_charge_bydate
@date1 date,
@date2 date
as
select charge.id,charge_desc,montant,date_charge,employee.id,nom,prenom from charge,employee
where charge.id_u=employee.id
and (date_charge >= @date1 and date_charge <= @date2)
---------------------------------------------------

ALTER PROC add_charge
@desc NVARCHAR(100),
@amount decimal,
@date date,
@id int
AS
insert into charge(charge_desc,montant,date_charge,id_u) 
values(@desc,@amount,@date,@id) 
--------------------------------

ALTER PROC update_charge
@id int,
@desc NVARCHAR(100),
@amount decimal,
@date date
AS
UPDATE charge 
SET charge_desc=@desc, montant=@amount, date_charge=@date
where id=@id
-------------

CREATE PROC delete_fee
@id int
AS
delete from charge where id=@id
-------NEW-----------
-------------------------------

ALTER PROC search_fees
@value NVARCHAR(100),
@date1 date,
@date2 date
as
select charge.id,charge_desc,montant,date_charge,employee.id,nom,prenom from charge,employee
where (CONVERT(nvarchar(100),charge.id)=@value or charge_desc like @value +'%' or CONVERT(nvarchar(100),date_charge)=@value) 
and charge.id_u=employee.id
and (date_charge >= @date1 and date_charge <= @date2)
-------NEW------
-------------------------------------------------------

ALTER proc show_prod 
as
select p.id,p.code as 'Code bare', p.designation as 'Désignation', p.prix_u as 'Prix d"achat',
prix_v as 'Prix Unitaire', p.prix_r as 'Prix de Remise',p.qte as 'Qte' from produit as p
where p.qte>0
-----------------------------------------------------------------------------------------

ALTER proc search_full_prod 
@code nvarchar(200)
as 
begin
select p.id,p.code as 'Code bare', p.designation as 'Désignation', p.prix_u as 'Prix d"achat',
prix_v as 'Prix Unitaire', p.prix_r as 'Prix de Remise',p.qte as 'Qte' from produit as p
where p.code=@code or p.designation like @code + '%' 
end
---

CREATE proc search_stock_by_finished 
as
select p.id,p.code as 'Code bare', p.designation as 'Désignation', p.prix_u as 'Prix d"achat',
prix_v as 'Prix Unitaire', p.prix_r as 'Prix de Remise',p.qte as 'Qte' from produit as p
where p.qte=0
----------------NEW----------------
-------------

CREATE proc search_stock_by_tout
as
select p.id,p.code as 'Code bare', p.designation as 'Désignation', p.prix_u as 'Prix d"achat',
prix_v as 'Prix Unitaire', p.prix_r as 'Prix de Remise',p.qte as 'Qte' from produit as p
-----------------NEW--------------
-----------------------------------------------------------------------------------------

alter table achat
add qte_vendue int;
-------------------

create proc show_full_details_achat_by_prod
@id int
as begin
select a.id,p.designation as 'Désignation', a.prix_a as 'Prix Achat', a.prix_v as'Prix Vente', a.prix_r as 'Prix Remise',
a.qte as 'Qte', a.qte-a.qte_vendue as 'reste', f.nom+' '+f.prenom as 'Fournisseur'
from achat as a , produit as p,fournisseur f , facture_four as ft
where a.id_p=@id
and   p.id=a.id_p
and	  ft.id=a.id_f	
and   f.id=ft.id_f
end
---

alter proc search_product
@id int,
@value NVARCHAR(100)
as begin
select a.id,p.designation as 'Désignation', a.prix_a as 'Prix Achat', a.prix_v as'Prix Vente', a.prix_r as 'Prix Remise',
a.qte as 'Qte', a.qte-a.qte_vendue as 'reste', f.nom+' '+f.prenom as 'Fournisseur'
from achat as a , produit as p,fournisseur f , facture_four as ft
where a.id_p=@id
and   p.id=a.id_p
and	  ft.id=a.id_f	
and   f.id=ft.id_f
and (CONVERT(nvarchar(100),a.id)=@value or p.designation like @value + '%'  or f.nom=@value or f.prenom=@value)
end
----------------NEW-------------
---

alter table charge
alter column charge_desc NVARCHAR(100);
---------------NEW----------------
-----------------------------------------

create proc nbr_fact_clt
@date1 date, @date2 date
as
begin
select COUNT(c.id) from facture_clt as c 
where c.date_fact between @date1 and @date2
end
------------NEW--------------------
---

create proc nbr_fact_four
@date1 date, @date2 date
as
begin
select COUNT(f.id) from facture_four as f 
where f.date_fact between @date1 and @date2
end
------------NEW--------------------
---
select * from charge