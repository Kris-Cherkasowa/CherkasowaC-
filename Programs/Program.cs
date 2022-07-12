// Написать программу, которая из имеющегося массива строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
void MethodArray (string [] array)
{
    string[] newarr = new string[array.Length];
    Console.Write("[ ");
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3)
        {
        newarr[i]=array[i];;
        Console.Write($"{newarr[i]}, "); 
        }
     }
     Console.Write("] ");
}

void PrintArray(string [] ArrayToo)
{
    Console.Write("[ ");
    for (int i=0; i<ArrayToo.Length; i++)
    {
        Console.Write($"{ArrayToo[i]}, ");
    }
    Console.Write("] ");
    Console.Write("--> ");
}

string [] array = {"gik", "7856", "hello", ":-)", "-7", "result"};

PrintArray(array);
MethodArray(array);