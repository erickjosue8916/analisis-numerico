# Actividad : Consultas SQL

1. Inserte 10 nuevos productos en la tabla products
> ```sql
>
>```

2. 
> ```sql
>
>```

3. 
> ```sql
>
>```

4. 
> ```sql
>
>```

5. 
> ```sql
>
>```

6. 
> ```sql
>
>

7. 
> ```sql
>
>

8. 
> ```sql
>
> 

9. 
> ```sql
>
>

10. 
> ```sql
>
>

11. Muestre un listado de ordenes (order) el cual debe contener lo siguiente el código
de orden (orderID), el nombre del cliente (contactName) y la fecha de orden
(OrderDate)

> ```sql
>select O.OrderID as codigo, C.CompanyName as cliente, O.OrderDate as fechaCompra from Orders as O inner join Customers C on O.CustomerID = C.CustomerID;
>```
![result](images/query.png)

