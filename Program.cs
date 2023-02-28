string[] fillarr(int size) 
{ 
    string[] arr = new string[size]; 
    Console.WriteLine("Введите элементы массива через enter"); 
    for (int i = 0; i < size;) 
    { 
        string num = Console.ReadLine(); 
        arr[i] = num; 
        i++; 
        if (size-i !=0) 
        { 
            Console.WriteLine($"Осталось ввести элементов: {size-i}"); 
        } 
        else 
        { 
            Console.WriteLine($"Все"); 
        } 
    } 
    return arr; 
} 

string[] itog(string[] array) 
{ 
    string[] final = new string[array.Length]; 
    int m = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i].Length <4) 
        { 
            final[m]=array[i]; 
            m++; 
        } 
    } 
    string[] final2 = new string[m]; 
    for (int i = 0; i < final2.Length; i++) 
    { 
        final2[i] = final[i]; 
    } 
    return final2; 
} 

Console.WriteLine("Введите длину массива"); 
int m = Convert.ToInt32(Console.ReadLine()); 
string[] array = fillarr(m); 
Console.WriteLine($"[{String.Join(",", array)}]"); 
array = itog(array); 
Console.WriteLine($"[{String.Join(",", array)}]");