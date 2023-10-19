using System; 
using System.Collections.Generic;

var array = new List<int>();

long number = 45123124155425;

    for (long i = 2; i < number; i++)
    {
        if(number % i == 0 && i * i !< number )
        {
            Console.WriteLine (i + "*" + number / i);
        }
    }