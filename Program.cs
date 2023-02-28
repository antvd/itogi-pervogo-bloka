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
            Console.WriteLine($"Вы еще можете ввести {size-i} элементов"); 
        } 
        else 
        { 
            Console.WriteLine($"Все"); 
        } 
    } 
    return arr; 
} 
