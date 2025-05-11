// запуск через node task.js
function printNumbersFromArray(array)
{
    for (value of array) 
    {
        if (Array.isArray(value))
        {
            printNumbersFromArray(value);
        }
        else
        {
            console.log(value);
        }
    }
}
let array = [
        1,
        2,
        3,
        [4, 5, 6],
        7,
        [8, [9, 10, 11, [12, 13, 14]]],
        [15, 16, 17, 18, 19, [20, 21, 22, [23, 24, 25, [26, 27, 28, 29], 30, 31]], 32],
        33,
    ];
printNumbersFromArray(
    array
);