--yorum satırı yazmak için kullanılır.
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

--where demek koşul demektir.
Select * from Customers where City = 'London'  -- Bana tüm customers ları tüm kolonlarıyla getir ama Şehri Londro olanları getir demektir.
--Metinler ANSII standartında tek tırnakla yazılıyor.
--case insensitive : SQL büyük küçük harf duyarsızdır.
select * from Products where CategoryID=1 --Ürünler tablosunu tüm kolonlarıyla kategori ıdsi 1 olanları getir demek.
--or yada demek
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>10 
--order by : sırala demektir.
select * from Products order by ProductName  --Bütün ürünleri seç ama ürün ismine göre sırala demektir.

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice asc  --ascending den geliyor.: Artan demektir. Artan şekilde sıralanıyor.

select * from Products order by UnitPrice desc  --descending: azalan düşen demektir.

select * from Products where CategoryID=1 order by UnitPrice desc
--Kategori ıdsi 1 olanları filtrele onları unitprice göre azalan şekilde getir.

--count: adet demek.
select count(*) from Products  
--Tüm satırları sayısını ver demek. Prodoct tablosunda kaç data var

select count(*) Adet from Products where CategoryID=2
--Ürünlerin sayısını ver ama ürünlerden ıdsi 2 olanları say demektir.
--count(*) dan sonra yanına adet yazarak isim verebiliriz.

--group: grupla demek.
select CategoryID, count(*) from Products group by CategoryID 

--having: group by a konu olan kümülatif sorguya yazılır. count sayısı, avg ortalama ,sum toplamı demektir.
select CategoryID, count(*) from Products group by CategoryID having count(*)<10
--içerisinde ürünü 10 dan az olan kategorileri ver demektir.

--ÖNCE HER ZAMAN WHERE ÇALIŞIR. --HAVİNG KÜMÜLATİFLERE UYGULANIR.
select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
--Fiyatı 20 den fazla olan ürünleri, kategoriıd'ye göre grupla, 
--o gruplardan da sayısı 10 dan küçük olanları ver demektir.

 --JOİN--

 select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName  --Bunlar gelecek olan kolonlar.
 from Products inner join Categories  --hem ürünlerin hemde kategorilerin bir araya gelme şekli.
 on Products.CategoryID=Categories.CategoryID
 where Products.UnitPrice>10 --on :durumunda şartında demek. --products tablosundaki 
 --kategoriıd'ye göre eşittir kategoriler tablosundaki kategoriıdye göre.Yani onlar eşitse onları yanyana getir demektir.
 --on dan sonra neye göre birleştireceğimizi yazarız.
-- where Products.UnitPrice>10 --ürünlerden fiyatı 10'dan büyük olanları kategorlerle birleştirerek getir demek.



 --inner join: Sadece 2 tabloda eşleşenleri bir araya getirir Eşleşmeyen datayı getirmez.
 --left join :sol da olup sağda olmayanlarıda getir demek.
select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID  --ürünlerde olup sipariş detayında olmayan ürünleri getir dmektir.

select * from Customers c left join Orders o  --Müşteri bilgisi siparişte olur çünkü siparişin bir müşterisi olur.
on c.CustomerID=o.CustomerID
where o.CustomerID is null -- null'lar is ile yazılır. sağda olmayanlar null olarak gösterilir.

--2 den fazla tabloyu join etmek istersek
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID 
inner join Orders o
on o.OrderID= od.OrderID
