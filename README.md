# **Задача**
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

## **Примеры**

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# **Порядок выполнения работы**
1. Создание репозитория на GitHub.
2. Создание блок-схемы алгоритма и добавление её в репозиторий. 
3. Создание оформленного текстового описания решения (файл README.md) и добавление его в репозиторий.
4. Написание программы, решающей поставленную задачу и добавление её в репозиторий.
5. Добавление в репозиторий файла gitignore.

# **Описание решения задачи**
1. Подготовить основные функции.
    * Создать функцию, формирующую массив строк 
    (элементы массива будут вводиться пользователем с консоли через запятую).
    * Создать функцию, формирующую новый массив строк, заполненный удовлетворяющими условию задачи элементами (длина строки 3 символа и меньше). (Если таких элементов нет – задать массив с единственным элементом с контрольным значением “null”.)
    * Создать функцию, выводящую массив на экран.
2. Оформить ввод данных пользователем с консоли.
3. Использовать функцию формирования массива из данных пользователя.
4. Использовать функцию формирования нового массива, удовлетворяющего условию.
5. Использовать функцию вывода массива на экран.
6. Провести тестирование полученной программы, используя примеры из условия задачи.