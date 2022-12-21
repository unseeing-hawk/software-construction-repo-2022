# software-construction-repo-2022

## Тема
Магазин игр

## Описание 
Написанный программный продукт обеспечивает пользователя графическим интерфейсом игрового магазина, в который можно войти, имея аккаунт (есть возможность регистрации). В магазине пользователь может просматривать каталог имеющихся игр, добавлять их в корзину, оплачивать покупки (аутентификация посредством связи с банковской базой данных), и скачивать игры из своей библиотеки в формате .zip архива.

## Участники проекта (группа 3530904/00101)
- Панкова Полина
- Кочкина Альбина 
- Каймакан Полина
- Баталова Евгения

<details><summary>##Изображения форм</summary>

   <summary>1. Вход</summary>
   ![SharedScreenshot](https://user-images.githubusercontent.com/69691273/208925554-10b4c860-7ddf-45a9-a015-009b482131c2.jpg)
![SharedScreenshot1](https://user-images.githubusercontent.com/69691273/208925572-1cd57cc0-547b-458d-b58a-475a8f578422.jpg)
![SharedScreenshot2](https://user-images.githubusercontent.com/69691273/208925573-2e10c5ec-5216-4215-8700-c7b38e18b6ad.jpg)

   <summary>2. Магазин, библиотека</summary>

   <summary>3. Профиль, корзина</summary>
   <summary>4. Оплата</summary>

</details>

# Диаграммы
## Контекстная диаграмма
![scheme](https://user-images.githubusercontent.com/69691273/208886043-6b8da13c-895e-42f9-8a9d-7954191c6e5c.svg)
## Диаграмма базы данных shop
![image](https://user-images.githubusercontent.com/69691273/208887869-354b5344-583b-4492-a6d0-df98a7a2b141.png)
## Диаграмма базы данных bank
![image](https://user-images.githubusercontent.com/69691273/208887485-0fec9da0-9baa-43aa-87ad-efef9efcd55d.png)

# Сборка и запуск
## Сборка
Приложение упаковано средствами VisualStudio через windows application packaging project. Для сборки запустите через PowerShell файл Add-AppDevPackage.ps1. 

## Запуск
В меню пуск найдите созданное приложение ShopApplication и запустите его.
