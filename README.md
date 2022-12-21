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

<details><summary>## Изображения форм</summary>

   <summary>1. Вход</summary>
<p><img src=https://user-images.githubusercontent.com/69691273/208926287-3b49b76d-fa67-4448-b7ce-e709f3965475.jpg></p>
   <summary>2. Магазин, библиотека</summary>

   <summary>3. Профиль, корзина</summary>
   <summary>4. Оплата</summary>

</details>

![SharedScreenshot](https://user-images.githubusercontent.com/69691273/208926287-3b49b76d-fa67-4448-b7ce-e709f3965475.jpg)
![SharedScreenshot1](https://user-images.githubusercontent.com/69691273/208926301-3db77275-d289-43d5-987e-e8093f2733a4.jpg)
![SharedScreenshot2](https://user-images.githubusercontent.com/69691273/208926305-535abade-8b45-4cd3-b7db-8b37890d826a.jpg)


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
