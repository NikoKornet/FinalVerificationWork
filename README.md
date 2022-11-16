
# Итоговая проверочная работа 

## Выполнил: Николай Корнетов

### Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых маньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте через выполнение алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)" ] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science" ] -> ["-2"]

["Russia", "Denmark", "Kazan" ] -> []

Решение:

1. Добавляем новый массив строк, заполненый элементами с разным колличеством символов.

2. Находим длину будующего массива:

    - задаем счетчик, присваеваем нулевое значение;
    - проходим по заданному массиву, если длина строки меньше либо равна трем, прибавляем счетчик;

3. Наполнение сформированного массива данными:
    - создаем новый массив, длину определям по счетчику из пункта 2;
    - задаем счетчик значений нового массива, присваеваем значение 0;
    - проходим по заданному массиву, проверяем длину строк, если длина строки меньше или равна трем - соответсвующему элементу нового массива присваеваем значение из заданного, прибавляем счетчик значений нового массива;
    - заполняем новый массив;

4. Печатаем заданный массив.

5. Печатаем полученный массив.