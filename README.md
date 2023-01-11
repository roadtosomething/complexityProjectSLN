# Задача об оптимальной одномерной упаковке
  В данном проекте проводится анализ различных алгоритмов решения NP-полной задачи об упаковке в контейнеры
## Структура кода
- В коде присутствует консольный интерфейс для взаимодействия с пользователем
- Описаны 3 алгоритма
  - Точный алгоритм поиска решения
  - Алгоритм FFI (или первый подходящий) для приближенного решения 
  - Алгоритм FFS второй алгоритм с сортировкой
- Реализован метод сравнения двух реализаций (рекурсионная и итерационная) подходов к приближенному решению для тестирования системы на количественную возможность подсчета тем или иным способом
## Выводы по анализу сложности алгоритмов
После проверки работы всех реализованных алгоритмов на данных различных объёмов было определенно, что самым медленным алгоритмом является точный алгоритм, при количестве входных элементов 10 программа алгоритм отрабатывает за 16 минут, в связи с чем максимальный объем входных данных определить достаточно сложно.

1) Для приближенных алгоритмов проведено нагрузочное тестирование и выявлено что рекурсионная реализация нвыполняется свыше:

| Алгоритм | Количество входных| Ошибка остановка |
| -------- |:------------------:| ---------------:|
| FFD      | 6373               | StackOverflow   |
| FFS      | 6377               | StackOverflow   |

2) График зависимости времени от количества входных данных точного алгоритма

| Количество вводных (n) | Время выполнения (тиков) |
| ---------------------- | :----------------------: |
| 1	                     | 170                      |
| 2	                     | 250                      |
| 3	                     | 320                      |
| 4	                     | 712                      |
| 5	                     | 2643                     |
| 6	                     | 25212                    |
| 7	                     | 142143                   |
| 8	                     | 1669755                  |
| 9	                     | 19706379                 |
| 10	                   | 203397164                |
| 11	                   | 30899280321              |

![image](https://user-images.githubusercontent.com/87961032/211726953-dc17f4c7-44df-4a19-b91d-d27405e701d1.png)

3) Алгоритм FFD:

|Количество вводных (n) |	Время выполнения (мс)|
|-|:-:|
|1	|0|
501	|5
1001	|23
1501	|64
2001	|182
2501	|312
3001	|513
3501	|827
4001	|1251
4501	|1795
5001	|2469
5501	|3375
6001	|4459

![image](https://user-images.githubusercontent.com/87961032/211727571-881fab12-2a1a-4bcc-91a5-9c3de3498086.png)

4) Алгоритм FFS:

|Количество вводных (n) |	Время выполнения (мс)|
|-|:-:|
1	|0
501|	6
1001|	21
1501|	61
2001|	131
2501|	243
3001|	412
3501|	662
4001|	995
4501|	1415
5001|	1939
5501|	2601
6001|	3426

![image](https://user-images.githubusercontent.com/87961032/211728139-14356ab7-e333-453d-bd34-f4c78e053b5d.png)

##Вывод по проведенному анализу

👨‍🦼 - Точный алгоритм

🏎️ - FFD (первый подходящий)

🚀 - FFS (первый подходящий с сортировкой)
