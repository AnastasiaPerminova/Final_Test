*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

*Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*


Данная задача решается следующим образом:
1.  Создается первоначальный массив **array1** из заданного количества элементов **number**(вводится пользователем). 
Вводится счетчик **count** равный 0.
При введении элементов массива определяется длина строковых элементов, считается количество элементов **count**, длина которых меньше, либо равна 3 символам.
Первоначальный массив выводится на экран.

2. Создается новый массив **array2**, количество элементов в котором равно **count**. Вводится счетчик **count2** равный 0, который определяет позицию элемента в массиве **array2**.

3. Выполняется проход по массиву **array1**. Определяются строки, длина которых меньше, либо равна 3 символам. Такая строка вносится в массив **array2** на позицию **count2**, счетчик **count2** увеличивается на 1.
Сформированный массив **array2**  выводится на экран.
