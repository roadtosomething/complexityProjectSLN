# The problem of optimal one-dimensional packing
  This project analyzes various algorithms for solving the NP-complete problem of packing into containers
## Code structure
- The code has a console interface for user interaction
- 3 algorithms are described
  - Accurate solution search algorithm
  - FFD algorithm (or first fit) for approximate solution
  - Algorithm FFS second algorithm with sorting
- Implemented a method for comparing two implementations (recursion and iteration) of approaches to an approximate solution to test the system for the quantitative possibility of counting in one way or another
## Conclusions on the analysis of the complexity of algorithms
After checking the operation of all implemented algorithms on data of various sizes, it was determined that the slowest algorithm is the exact algorithm, with the number of input elements 10, the program completes the algorithm in 16 minutes, and therefore it is quite difficult to determine the maximum amount of input data.

1) For approximate algorithms, load testing was carried out and it was found that the recursion implementation is not performed above:

| Algorithm | Number of input| Stop error |
| -------- |:--------------------------------:| ---------------:|
| FFD | 6373 | stackoverflow |
| FFS | 6377 | stackoverflow |

2) Graph of the dependence of time on the number of input data of the exact algorithm

| Number of introductory (n) | Execution time (ticks) |
| ---------------------- | :----------------------: |
| 1 | 170 |
| 2 | 250 |
| 3 | 320 |
| 4 | 712 |
| 5 | 2643 |
| 6 | 25212 |
| 7 | 142143 |
| 8 | 1669755 |
| 9 | 19706379 |
| 10 | 203397164 |
| 11 | 30899280321 |

![image](https://user-images.githubusercontent.com/87961032/211726953-dc17f4c7-44df-4a19-b91d-d27405e701d1.png)

3) Algorithm FFD:

|Number of introductory (n) | Execution time (ms)|
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

4) Algorithm FFS:

|Number of introductory (n) | Execution time (ms)|
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

##Conclusion on the analysis


👨‍🦼 - Accurate solution search algorithm

🏎️ - FFD (first fit)

🚀 - FFS (first fit with sort)
