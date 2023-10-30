# Final_Task_1Quater
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.  
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Элементы массива задаются на старте.
1) Создан первый массив.
2) Задан второй массив с количеством элементов, равным количеству элементов (длине) первого массива.
3) Далее создан метод для изменения первого массива во второй.
   В этом методе используется функция for для того, чтобы перебрать все элементы массива по очереди. Ограничитель - длина массива.
   Использована функция if, условия которой следующие: если длина конкретно взятого элемента первого массива больше либо равна 3 (как в задании), то этот элемент становится элементом второго массива.
   Далее программа проверяет следующий элемент.
4) Далее необходимо вывести второй массив на печать. Для этого создан свой метод.
5) Примечание: создан отдельный метод и для печати первого массива, чтобы пользователь мог сравнить первую и вторую версии. Очевидно, два метода для печати - это избыточно, но пока я не решила эту проблему.
6) Задавая параметры первого массива, попробовала изменить длину, элементы. Программа работает с измененными параметрами.
7) Проблема: пока не могу разобраться, как сделать так, чтобы первый массив строк заполнял пользователь. Комманды знакомы, но не складываются в общую картину.
8) Возможно, стоит сделать версию со случайным заполнением массива.
    
