-- Вывести менеджеров у которых имеется номер телефона
SELECT Fio
FROM Menegers
WHERE Phone IS NOT NULL
GO

-- Вывести кол-во продаж за 20 июня 2021
SELECT SUM('Count') AS 'Count products as 2021-06-20'
FROM Sells
WHERE 'Date' = '2021-06-20'
GO

-- Вывести среднюю сумму продажи с товаром 'Фанера'
SELECT AVG('Sum') AS 'Average sale amount of "Фанера"'
FROM Sells AS s
INNER JOIN Products AS p ON s.ID_Prod = p.ID
WHERE p.Name = 'Фанера'
GO

-- Вывести фамилии менеджеров и общую сумму продаж для каждого с товаром 'ОСБ'
SELECT Fio, SUM('Sum') AS 'Sun products of "ОСБ"'
FROM Managers AS m
INNER JOIN Sells AS s ON m.ID = s.ID_Manag
INNER JOIN Products AS p ON s.ID_Prod = p.ID
WHERE p.Name = 'ОСБ'
GROUP BY Fio
Go

-- Вывести менеджера и товар, который продали 22 августа 2021
SELECT Fio, 'Name'
FROM Managers AS m
INNER JOIN Sells AS s ON m.ID = s.ID_Manag
INNER JOIN Products AS p ON s.ID_Prod = p.ID
WHERE 'Data' = '2021-08-22'
GROUP BY Fio
GO

-- Вывести все товары, у которых в названии имеется 'Фанера' и цена не ниже 1750
SELECT 'Name'
FROM Products AS p
WHERE 'Name' LIKE '%Фанера%' AND Cost >= 1750

-- Вывести историю продаж товаров, группируя по месяцу продажи и наименованию товара
SELECT DATEADD(month, DATEDIFF(month, 0, 'Data'), 0) AS 'Month',
    'Name'
FROM Sells AS s
INNER JOIN Products AS p ON s.ID_Prod = p.ID
GROUP BY DATEADD(month, DATEDIFF(month, 0, 'Data'), 0), 'Name'
GO

-- Вывести количество повторяющихся значений и сами значения из таблицы 'Товары', где количество повторений больше 1
SELECT COUNT('Name'), 'Name'
FROM Product
GROUP BY 'Name'
HAVING COUNT('Name') > 1;