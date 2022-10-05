# Final test

### ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Алгоритм выполнения задания:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)
<br>
<br>

## Задание 2. Создание алгоритма решения задачи
В папке BS находится файл с изображением блок-схемы.

## Задание 3. Описание алгоритма решения задачи
Объявляются два массива. Стартовый и итоговый одинаковой длины. Заполняем стартовый массив строковыми данными (заранее ввели в тело программы). Потом выполняем функцию по вычислению длины каждой ячейки - выборка массива (SelectionArray). Так как заполняем строковыми данными (string) - каждая строка может считаться как одномерный массив - если длина строки 3 символа или меньше - присваиваем данное значение в итоговый массив в ячейку, равную счетчку (индексу) в цикле функции, после этого - инкремент индекса и снова цикл, пока индекс не станет равен размеру массива. В противном случае (если длина строки больше 3 символов) - то сразу инкремент индекса и проверка следующей ячейки стартового массива. После окончание работы функции по выборке массива (SelectionArray) - удаляем из итогового массива пустые ячейки и после - запускаем функцию вывода на экран обоих массивов - стартового и итогового (PrintArray) - печатаем первый массив, потом стрелку и второй массив.

## Задание 4. Решение задачи на C#
В папке Programm решение задачи на C#. <br>
