# Actividad : Consultas SQL

1. Inserte 10 nuevos productos en la tabla products
> ```sql
>
>```
![](images/query_11.png)

2. 
> ```sql
>
>```
![](images/query_11.png)

3. 
> ```sql
>
>```
![](images/query_11.png)

4. 
> ```sql
>
>```
![](images/query_11.png)

5. 
> ```sql
>
>```
![](images/query_11.png)

6. 
> ```sql
>
>
![](images/query_11.png)

7. 
> ```sql
>
>
![](images/query_11.png)

8. 
> ```sql
>
> 
![](images/query_11.png)

9. 
> ```sql
>
>
![](images/query_11.png)

10. 
> ```sql
>
>
![](images/query_11.png)

11. Muestre un listado de ordenes (order) el cual debe contener lo siguiente el código
de orden (orderID), el nombre del cliente (contactName) y la fecha de orden
(OrderDate)

> ```sql
>select O.OrderID as codigo, C.CompanyName as cliente, O.OrderDate as fechaCompra from Orders as O inner join Customers C on O.CustomerID = C.CustomerID;
>```

![](images/query_11.png)
