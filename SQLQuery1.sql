alter table Orders alter column �q��O�_���� bit not null;

alter table OrderDetailTest add ��� int;

alter table Orders add ProductID int;
alter table Orders add �q��O�_���� bit;

ALTER TABLE Orders drop column �q��O�_����;

ALTER TABLE Customers ADD UNIQUE (Phone);

DELETE FROM Customers WHERE Name='123';

insert into ShoppingCar values(1)



use trytry
EXEC sp_rename 'Orders.�m�W', '����H', 'COLUMN';    /*������W��*/

EXEC sp_rename 'Products.ID', 'ProductID', 'COLUMN';

EXEC sp_rename 'myHW.dbo.Visitor', 'Visitors'   /*���table�W��*/


INSERT INTO Customers
              (name, Email)
select name,price from Products where id=6 

select Email,�K�X from Customers where Email='123' and �K�X='123';

select Email,�K�X from Customers

select * from Products where Pname='�q���~�G���T';

select sum(�ƶq)as ��~�`�ƶq from ShoppingCar where CustomerID='5'

select sum(���B)as �`���B from ShoppingCar where CustomerID='5'  /*���`���B*/

delete from ShoppingCar where CustomerID=5 and ProductID=4;

select * from OrderDetailTest
select * from ShoppingCar
insert into Orders(CustomerID,�O�_���|��,����H,�q��,Email,�a�},Orderdate,�`���B,�Ƶ�,�q��O�_����) values(3,1,'�j����',0938538538,'gigi@gigi.com','������',GETDATE(),1000,'�L���[�»�',1);

select top 1 OrderID from Orders order by OrderID desc;    /*�|���o����orderID*/
/*��쪺orderID�˦��@��static�ܼ�*/

insert into OrderDetailTest(OrderID,ProductID,�ƶq,���B,���) values(1003,(select ProductID from ShoppingCar where CustomerID =5 and ProductID=2),(select �ƶq from ShoppingCar where CustomerID =5 and ProductID=2),(select ���B from ShoppingCar where CustomerID =5 and ProductID=2),(select ��� from ShoppingCar where CustomerID =5 and ProductID=2));
/*��static�A�a8��?*/

INSERT INTO OrderDetailTest(OrderID,ProductID,�ƶq)
values (1,1,1)


CREATE TABLE Message_Board (
  MessageID INT not NULL,
  StoreID int not null,
  CustomerID int  not NULL,
  Content nvarchar,
  CONSTRAINT pk_Message_Id PRIMARY KEY (MessageID, StoreID,CustomerID)
);

CREATE TABLE ShoppingCar (
  CustomerID INT not NULL,
  ProductID int  not NULL,
  �ƶq int null,
  �|���I�Ƨ�� int null,
  �����B int null,
  ���B int null,
  CONSTRAINT pk_shoppingCar_Id PRIMARY KEY (CustomerID, ProductID)
);

use Northwind
select * from Orders
select Count(OrderID) from Orders  /*������X��*/
select top 1 OrderID from Orders order by OrderID desc  /*��̫�@��*/

select * from [Order Details]


use myHW
insert into Orders(Orderdate)
values (GETDATE());
INSERT INTO OrderDetailTest(OrderID,ProductID,�ƶq)
values (1,1,1)
INSERT INTO OrderDetailTest(OrderID,ProductID,�ƶq)
values (1,2,2)
/*--------------------------------------------------------------------------------------------------------*/
insert into Orders(Orderdate) values (GETDATE());              
/*�s�WorderID�ƶq�å��[�J���*/---���Ĳ�o?---���ϥγo��---

insert into Orders(�q��O�_����)            /*�s�WorderID�]�������b�ҥH���_�w����*/---���I��buttonĲ�o�W�[�Pı�|�@�����@���s�W---��form loadĲ�o�s�W
values (0);      /*bit 0=false�A1=true*/
select top 1 OrderID from Orders order by OrderID desc    /*�|���o����orderID*/
/*��쪺orderID�˦��@��static�ܼ�*/

/*�p��w���c�N���?---�]�w�R���ʪ������s�R���ӧO���~��Ƹ�ơC*/                  /*�]�w�R���q����s(�]�|���e���R�����~��ƥ\��)�~�����}??---���I���X�`�z*/
/*Orders�̭��]�w�̫�O�_�����߭q��A�p�G�S���N�]�w���@�u�@�R���S�����ߪ��q��C*/

insert into OrderDetailTest(OrderID,ProductID,�ƶq,���B)            /*��J�ƶq�[�J�ʪ���*/
values((select top 1 OrderID from Orders order by OrderID desc),2,1,((select Price from Products where ProductID=2)*1))
/*�o�䪺orderID�N��static�ܼƥN�A���n�Χ�̷s���y�k�N�A�קK���P�ϥΪ̼���*/

DELETE FROM OrderDetailTest WHERE ProductID=2 and OrderID=(select top 1 OrderID from Orders order by OrderID desc);
/*�ʪ����R�����~�AoderID=static�ܼ�*/

select * from Products
select * from Orders
select * from OrderDetailTest

select Orders.OrderID as �q��s��,Products.Pname as �ӫ~�W��,�ƶq,���,���B,�`���B as �q���`���B,����H,�q��,Email,�a�},Orderdate as �q�ʮɶ�,�Ƶ�
from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID=Products.ProductID)
inner join Orders on OrderDetailTest.OrderID=Orders.OrderID
where Orders.CustomerID=5 and Orders.OrderID=(select top 1 Orders.OrderID from Orders where Orders.CustomerID=5 order by OrderID desc)
order by Orders.OrderID desc

SELECT ShoppingCar.ProductID ,Products.Pname,Products.Price, ShoppingCar.�ƶq ,ShoppingCar.���B    /*�ʪ����q�X�ӵ��ȤH�ݱo*/
FROM ShoppingCar
INNER JOIN Products
ON ShoppingCar.ProductID=Products.ProductID
where ShoppingCar.CustomerID=5

SELECT ShoppingCar.CustomerID,ShoppingCar.ProductID,Products.Pname,Products.Pdesc,Products.Price, ShoppingCar.�ƶq ,ShoppingCar.���B,Products.Pimage    /*�ʪ����q�X�ӵ��ȤH�ݱo*/
FROM ShoppingCar
INNER JOIN Products
ON ShoppingCar.ProductID=Products.ProductID
where ShoppingCar.CustomerID=5 and Products.Pname='�q���~�G���T';



update ShoppingCar set �ƶq= 5,���B=150  where CustomerID=5 and ProductID=2;

select * 
from Orders inner join OrderDetailTest on Orders.OrderID = OrderDetailTest.OrderID where Orders.OrderID=1 and OrderDetailTest.OrderID=1;

update OrderDetailTest set ���B=((select Price from Products where ProductID=2)*OrderDetailTest.�ƶq)
where OrderDetailTest.OrderID=3 and OrderDetailTest.ProductID=2;
/*�p��Τl�d��(�[join)�hupdate���*/
/*�ʪ����ܧ�ƶqupdate���B*/

SELECT OrderDetailTest.OrderID, OrderDetailTest.ProductID , Products.Pname,Products.Price, OrderDetailTest.�ƶq ,OrderDetailTest.���B,Orders.�`���B
from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID=Products.ProductID)
inner join Orders on OrderDetailTest.OrderID=Orders.OrderID
where OrderDetailTest.OrderID=3

/*1.������form�ӫ~�Ϥ��I����ܥt�@��form�Ashow�XProductTable���ӫ~��T*/
/*-----------------------------------------------------------------------------------------------------------------------*/
/*2.�[�c�O�I�[�J�ʪ�����Ĳ�o�s�WOrders��OrderID*/
insert into Orders(�q��O�_����)            /*�s�WorderID�]�������b�ҥH���_�w����*/
values (0);      /*bit 0=false�A1=true*/
select top 1 OrderID from Orders order by OrderID desc    /*�|���o����orderID*/
/*��쪺orderID�˦��@��static�ܼ�*/
/*-----------------------------------------------------------------------------------------------------------------------*/
/*3.�æbOrderDetail�s�WOrderID,ProductID,�ƶq,���B�A�H��form�̪��ʪ���lbl�Ʀr�W�[*/
insert into OrderDetailTest(OrderID,ProductID,�ƶq,���B)            /*��J�ƶq�[�J�ʪ���*/
values((select top 1 OrderID from Orders order by OrderID desc),2,1,((select Price from Products where ProductID=2)*1))
/*�o�䪺orderID(select top 1 OrderID from Orders order by OrderID desc)�N��static�ܼƥN�A���n�Χ�̷s���y�k�N�A�קK���P�ϥΪ̼���*/
/*-----------------------------------------------------------------------------------------------------------------------*/
/*4.�b�ʪ���from�̡A����O�s�W��Orders���q���ơA�k���listview�]OrderDetail����T���ϥΪ�(�u��show�o��OrderID��������T)�A�����ϥΪ̧��ƶq�ΧR��*/
SELECT OrderDetailTest.OrderID, OrderDetailTest.ProductID , Products.Pname,Products.Price, OrderDetailTest.�ƶq ,OrderDetailTest.���B    /*�ʪ����q�X�ӵ��ȤH�ݱo*/
FROM OrderDetailTest
INNER JOIN Products
ON OrderDetailTest.ProductID=Products.ProductID
where OrderDetailTest.OrderID=3
/*join���table �S���`���B*/
SELECT OrderDetailTest.OrderID, OrderDetailTest.ProductID , Products.Pname,Products.Price, OrderDetailTest.�ƶq ,OrderDetailTest.���B,Orders.�`���B
from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID=Products.ProductID)
inner join Orders on OrderDetailTest.OrderID=Orders.OrderID
where OrderDetailTest.OrderID=3
/*Orders���`���B���ӧ�OrderDetail�̪��POrderID�hSUM*/

DELETE FROM OrderDetailTest WHERE ProductID=2 and OrderID=(select top 1 OrderID from Orders order by OrderID desc);
/*�ʪ����R�����~�AoderID=static�ܼ�*/

update OrderDetailTest set ���B=((select Price from Products where ProductID=2)*OrderDetailTest.�ƶq)
where OrderDetailTest.OrderID=3 and OrderDetailTest.ProductID=2;
/*�ʪ����ܧ�ƶqupdate���B*/

select CustomerID from Customers where Email='123'
select CustomerID,Name,Phone,��} from Customers where Email='123'

