# Actividad : Consultas SQL
## Keny Listbeth Chavez Torres - CT18009
## Erick Josué Saravia Aragón - SA18004
1. Inserte 10 nuevos productos en la tabla products
```sql
INSERT INTO `products` VALUES (null,"Arroz",1,2,"36 boxe",12,20,3,0,0),(null,"Frijoles",2,2,"26 oz",12,20,3,0,0),(null,"Azucar",3,2,"10 lb",12,20,3,0,0),(null,"Pan",4,2,"10 box",12,20,3,0,0),(null,"Sal",5,2,"10 lb",12,20,3,0,0), (null,"Consome",6,2,"20 oz",12,20,3,0,0), (null,"Leche",7,2,"6 bo",12,20,3,0,0), (null,"Salsa",8,2,"13 box",12,20,3,0,0),(null,"Spagety",9,2,"6 box",12,20,3,0,0),(null,"Maizena",10,2,"10 lb",12,20,3,0,0)
```
![](images/query_01.png)

2. 
```sql
```
![](images/query_11.png)

3. 
```sql
```
![](images/query_11.png)

4. 
```sql
```
![](images/query_11.png)

5. 
```sql
```
![](images/query_11.png)

6. 
```sql
```
![](images/query_11.png)

7. 
```sql
```
![](images/query_11.png)

8. 
```sql
```
![](images/query_11.png)

9. 
```sql
```
![](images/query_11.png)

10. 
```sql
```
![](images/query_11.png)

11. Muestre un listado de ordenes (order) el cual debe contener lo siguiente el código
de orden (orderID), el nombre del cliente (contactName) y la fecha de orden
(OrderDate)

> ```sql
>select O.OrderID as codigo, C.CompanyName as cliente, O.OrderDate as fechaCompra from Orders as O inner join Customers C on O.CustomerID = C.CustomerID;
> ```

![](images/query_11.png)

12. Muestre un listado de ordenes (order) el cual debe contener lo siguiente el código
de orden (orderID), el nombre del cliente (contactName) y la fecha de orden
(OrderDate).

> ```sql
>select O.OrderID as codigo, C.CompanyName as cliente, O.OrderDate as fechaCompra from Orders as O inner join Customers C on O.CustomerID = C.CustomerID;
> ```

![](images/query_11.png)

13. Cree una consulta que muestre el numero de ordenes por cliente

> ```sql
> select C.CompanyName as cliente, COUNT(O.CustomerID) as ordenes from Orders as O inner join Customers C on O.CustomerID = C.CustomerID group by O.CustomerID;
> ```

![](images/query_13.png)

14. Cree una consulta que muestre el listdo de productos cuyo nombre empiece con M

> ```sql
>
> ```

![](images/query_14.png)

15. Cree una consulta que muestre el listado de productos cuyo nombre termine en una
vocal

 ```sql
 select * from Products where ProductName LIKE '%a' or ProductName LIKE '%e' or ProductName LIKE '%i' or ProductName LIKE '%o' or ProductName LIKE '%u';
 ```

![](images/query_15.png)

16. Cree una consulta que muestre un listado de productos cuyo nombre tenga una u

```sql
select * from Products where ProductName LIKE '%u%';
```

![](images/query_16.png)

17. Cree una consulta que muestre un listado de productos cuyo UnitsInStock sea igual
a 0

```sql

```

![](images/query_17.png)

18. Cree una consulta que muestre el detalle de una orden en específico, deberá
contener los siguientes campos: el código de la orden (OrderID), nombre del
empleado (firstName), nombre del producto (productName), precio unitario del
producto (UnitPrice), cantidad (Quantity) y el descuento (Discount). Cada campo
deberá tener el alias que se indica en el enunciado, el filtro se deberá aplicar según
él código de la orden 

```sql
select
       O.OrderID as codigoOrden,
       E.FirstName as empleado,
       P.ProductName as producto,
       OD.UnitPrice as precioUnitario,
       OD.Quantity as cantidad,
       OD.Discount as descuento
from Orders O
    inner join Employees E on O.EmployeeID = E.EmployeeID
    inner join OrderDetails OD on O.OrderID = OD.OrderID
    inner join Products P on OD.ProductID = P.ProductID
where O.OrderID = 10258;
```

![](images/query_18.png)

19. Cree una consulta que permita visualizar el total por orden deberá mostrar los
campos. OrderID, total de la orden

```sql
select O.OrderID as codigo, SUM((OD.Quantity * OD.UnitPrice) * (1 - OD.Discount)) as total from Orders as O join OrderDetails OD on O.OrderID = OD.OrderID group by O.OrderID;
```

![](images/query_19.png)

20. Cree una consulta que permita visualizar un reporte de órdenes, queda bajo su
criterio mostrar los campos más representativos para su reporte

```sql
select O.OrderID as codigo,
       C.CompanyName as cliente,
       CONCAT(E.FirstName, ' ', E.LastName) as vendedor,
       O.ShipCountry as country,
       O.ShipCity as city,
       O.ShipAddress as direccion,
       O.OrderDate as fechaVenta,
       SUM(OD.Quantity) as cantidadProductos,
       SUM((OD.Quantity * OD.UnitPrice) * (1 - OD.Discount)) as total
from Orders as O
    join OrderDetails OD on O.OrderID = OD.OrderID
    join Customers C on O.CustomerID = C.CustomerID
    join Employees E on O.EmployeeID = E.EmployeeID
group by O.OrderID;
```

![](images/query_20.png)