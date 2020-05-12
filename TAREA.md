# Actividad : Consultas SQL

1. Inserte 10 nuevos productos en la tabla products
> ```sql
>INSERT INTO `products` VALUES (null,"Arroz",1,2,"36 boxe",12,20,3,0,0),(null,"Frijoles",2,2,"26 oz",12,20,3,0,0),(null,"Azucar",3,2,"10 lb",12,20,3,0,0),(null,"Pan",4,2,"10 box",12,20,3,0,0),(null,"Sal",5,2,"10 lb",12,20,3,0,0), (null,"Consome",6,2,"20 oz",12,20,3,0,0), (null,"Leche",7,2,"6 bo",12,20,3,0,0), (null,"Salsa",8,2,"13 box",12,20,3,0,0),(null,"Spagety",9,2,"6 box",12,20,3,0,0),(null,"Maizena",10,2,"10 lb",12,20,3,0,0)
>```
![](images/query_01.png)

2. 
> ```sql
>
> ```
![](images/query_11.png)

3. 
> ```sql
>
> ```
![](images/query_11.png)

4. 
> ```sql
>
> ```
![](images/query_11.png)

5. 
> ```sql
>
> ```
![](images/query_11.png)

6. 
> ```sql
>
> ```
![](images/query_11.png)

7. 
> ```sql
>
> ```
![](images/query_11.png)

8. 
> ```sql
>
> ```
![](images/query_11.png)

9. 
> ```sql
>
> ```
![](images/query_11.png)

10. 
> ```sql
>
> ```
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
>
> ```

![](images/query_11.png)

14.  

> ```sql
>
> ```

![](images/query_11.png)

15. 

> ```sql
>
> ```

![](images/query_11.png)

16. 

> ```sql
>
> ```

![](images/query_11.png)

17. 

> ```sql
>
> ```

![](images/query_11.png)

18. 

> ```sql
>
> ```

![](images/query_11.png)

19. 

> ```sql
>
> ```

![](images/query_11.png)

20. 

> ```sql
>
> ```

![](images/query_11.png)