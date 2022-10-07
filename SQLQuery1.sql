alter table Orders alter column 訂單是否成立 bit not null;

alter table OrderDetailTest add 單價 int;

alter table Orders add ProductID int;
alter table Orders add 訂單是否成立 bit;

ALTER TABLE Orders drop column 訂單是否成立;

ALTER TABLE Customers ADD UNIQUE (Phone);

DELETE FROM Customers WHERE Name='123';

insert into ShoppingCar values(1)



use trytry
EXEC sp_rename 'Orders.姓名', '收件人', 'COLUMN';    /*更改欄位名稱*/

EXEC sp_rename 'Products.ID', 'ProductID', 'COLUMN';

EXEC sp_rename 'myHW.dbo.Visitor', 'Visitors'   /*更改table名稱*/


INSERT INTO Customers
              (name, Email)
select name,price from Products where id=6 

select Email,密碼 from Customers where Email='123' and 密碼='123';

select Email,密碼 from Customers

select * from Products where Pname='義式芒果奶酪';

select sum(數量)as 單品總數量 from ShoppingCar where CustomerID='5'

select sum(金額)as 總金額 from ShoppingCar where CustomerID='5'  /*抓總金額*/

delete from ShoppingCar where CustomerID=5 and ProductID=4;

select * from OrderDetailTest
select * from ShoppingCar
insert into Orders(CustomerID,是否為會員,收件人,電話,Email,地址,Orderdate,總金額,備註,訂單是否成立) values(3,1,'大中天',0938538538,'gigi@gigi.com','高雄市',GETDATE(),1000,'他不加麻辣',1);

select top 1 OrderID from Orders order by OrderID desc;    /*會抓到這次的orderID*/
/*抓到的orderID弄成一個static變數*/

insert into OrderDetailTest(OrderID,ProductID,數量,金額,單價) values(1003,(select ProductID from ShoppingCar where CustomerID =5 and ProductID=2),(select 數量 from ShoppingCar where CustomerID =5 and ProductID=2),(select 金額 from ShoppingCar where CustomerID =5 and ProductID=2),(select 單價 from ShoppingCar where CustomerID =5 and ProductID=2));
/*用static再帶8次?*/

INSERT INTO OrderDetailTest(OrderID,ProductID,數量)
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
  數量 int null,
  會員點數折抵 int null,
  折抵金額 int null,
  金額 int null,
  CONSTRAINT pk_shoppingCar_Id PRIMARY KEY (CustomerID, ProductID)
);

use Northwind
select * from Orders
select Count(OrderID) from Orders  /*算全部幾筆*/
select top 1 OrderID from Orders order by OrderID desc  /*抓最後一筆*/

select * from [Order Details]


use myHW
insert into Orders(Orderdate)
values (GETDATE());
INSERT INTO OrderDetailTest(OrderID,ProductID,數量)
values (1,1,1)
INSERT INTO OrderDetailTest(OrderID,ProductID,數量)
values (1,2,2)
/*--------------------------------------------------------------------------------------------------------*/
insert into Orders(Orderdate) values (GETDATE());              
/*新增orderID數量並先加入日期*/---何時觸發?---不使用這串---

insert into Orders(訂單是否成立)            /*新增orderID因為未結帳所以先否定成立*/---用點擊button觸發增加感覺會一直按一直新增---用form load觸發新增
values (0);      /*bit 0=false，1=true*/
select top 1 OrderID from Orders order by OrderID desc    /*會抓到這次的orderID*/
/*抓到的orderID弄成一個static變數*/

/*如何預防惡意灌單?---設定刪除購物車按鈕刪除個別產品資料資料。*/                  /*設定刪除訂單按鈕(也會有前面刪除產品資料功能)才能離開??---有點不合常理*/
/*Orders裡面設定最後是否有成立訂單，如果沒有就設定維護工作刪除沒有成立的訂單。*/

insert into OrderDetailTest(OrderID,ProductID,數量,金額)            /*輸入數量加入購物車*/
values((select top 1 OrderID from Orders order by OrderID desc),2,1,((select Price from Products where ProductID=2)*1))
/*這邊的orderID就用static變數代，不要用抓最新的語法代，避免不同使用者撞單*/

DELETE FROM OrderDetailTest WHERE ProductID=2 and OrderID=(select top 1 OrderID from Orders order by OrderID desc);
/*購物車刪除產品，oderID=static變數*/

select * from Products
select * from Orders
select * from OrderDetailTest

select Orders.OrderID as 訂單編號,Products.Pname as 商品名稱,數量,單價,金額,總金額 as 訂單總金額,收件人,電話,Email,地址,Orderdate as 訂購時間,備註
from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID=Products.ProductID)
inner join Orders on OrderDetailTest.OrderID=Orders.OrderID
where Orders.CustomerID=5 and Orders.OrderID=(select top 1 Orders.OrderID from Orders where Orders.CustomerID=5 order by OrderID desc)
order by Orders.OrderID desc

SELECT ShoppingCar.ProductID ,Products.Pname,Products.Price, ShoppingCar.數量 ,ShoppingCar.金額    /*購物車秀出來給客人看得*/
FROM ShoppingCar
INNER JOIN Products
ON ShoppingCar.ProductID=Products.ProductID
where ShoppingCar.CustomerID=5

SELECT ShoppingCar.CustomerID,ShoppingCar.ProductID,Products.Pname,Products.Pdesc,Products.Price, ShoppingCar.數量 ,ShoppingCar.金額,Products.Pimage    /*購物車秀出來給客人看得*/
FROM ShoppingCar
INNER JOIN Products
ON ShoppingCar.ProductID=Products.ProductID
where ShoppingCar.CustomerID=5 and Products.Pname='義式芒果奶酪';



update ShoppingCar set 數量= 5,金額=150  where CustomerID=5 and ProductID=2;

select * 
from Orders inner join OrderDetailTest on Orders.OrderID = OrderDetailTest.OrderID where Orders.OrderID=1 and OrderDetailTest.OrderID=1;

update OrderDetailTest set 金額=((select Price from Products where ProductID=2)*OrderDetailTest.數量)
where OrderDetailTest.OrderID=3 and OrderDetailTest.ProductID=2;
/*如何用子查詢(加join)去update資料*/
/*購物車變更數量update金額*/

SELECT OrderDetailTest.OrderID, OrderDetailTest.ProductID , Products.Pname,Products.Price, OrderDetailTest.數量 ,OrderDetailTest.金額,Orders.總金額
from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID=Products.ProductID)
inner join Orders on OrderDetailTest.OrderID=Orders.OrderID
where OrderDetailTest.OrderID=3

/*1.首頁的form商品圖片點擊顯示另一個form，show出ProductTable的商品資訊*/
/*-----------------------------------------------------------------------------------------------------------------------*/
/*2.架構是點加入購物車時觸發新增Orders的OrderID*/
insert into Orders(訂單是否成立)            /*新增orderID因為未結帳所以先否定成立*/
values (0);      /*bit 0=false，1=true*/
select top 1 OrderID from Orders order by OrderID desc    /*會抓到這次的orderID*/
/*抓到的orderID弄成一個static變數*/
/*-----------------------------------------------------------------------------------------------------------------------*/
/*3.並在OrderDetail新增OrderID,ProductID,數量,金額，以及form裡的購物車lbl數字增加*/
insert into OrderDetailTest(OrderID,ProductID,數量,金額)            /*輸入數量加入購物車*/
values((select top 1 OrderID from Orders order by OrderID desc),2,1,((select Price from Products where ProductID=2)*1))
/*這邊的orderID(select top 1 OrderID from Orders order by OrderID desc)就用static變數代，不要用抓最新的語法代，避免不同使用者撞單*/
/*-----------------------------------------------------------------------------------------------------------------------*/
/*4.在購物車from裡，左邊是新增給Orders的訂單資料，右邊用listview跑OrderDetail的資訊給使用者(只有show這次OrderID的相關資訊)，並讓使用者更改數量及刪除*/
SELECT OrderDetailTest.OrderID, OrderDetailTest.ProductID , Products.Pname,Products.Price, OrderDetailTest.數量 ,OrderDetailTest.金額    /*購物車秀出來給客人看得*/
FROM OrderDetailTest
INNER JOIN Products
ON OrderDetailTest.ProductID=Products.ProductID
where OrderDetailTest.OrderID=3
/*join兩個table 沒有總金額*/
SELECT OrderDetailTest.OrderID, OrderDetailTest.ProductID , Products.Pname,Products.Price, OrderDetailTest.數量 ,OrderDetailTest.金額,Orders.總金額
from(OrderDetailTest INNER JOIN Products ON OrderDetailTest.ProductID=Products.ProductID)
inner join Orders on OrderDetailTest.OrderID=Orders.OrderID
where OrderDetailTest.OrderID=3
/*Orders的總金額應該抓OrderDetail裡的同OrderID去SUM*/

DELETE FROM OrderDetailTest WHERE ProductID=2 and OrderID=(select top 1 OrderID from Orders order by OrderID desc);
/*購物車刪除產品，oderID=static變數*/

update OrderDetailTest set 金額=((select Price from Products where ProductID=2)*OrderDetailTest.數量)
where OrderDetailTest.OrderID=3 and OrderDetailTest.ProductID=2;
/*購物車變更數量update金額*/

select CustomerID from Customers where Email='123'
select CustomerID,Name,Phone,住址 from Customers where Email='123'

