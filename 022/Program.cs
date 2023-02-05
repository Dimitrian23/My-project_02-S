// Задача_№22 По двум числам проверить является ли одно квадратом другого.

int a,b,s;

        System.Console.WriteLine("Введите в терминал последовательно два числа, подтверждая ввод каждого нажатием клавиши 'Enter' ");
             a=Convert.ToInt32(Console.ReadLine());
             b=Convert.ToInt32(Console.ReadLine());
 
s=a/b;
  if(b==s) 
    {
       System.Console.WriteLine($"Число ({a}) является квадратом числа ({b})"); 
    }
  else
    { 
       System.Console.WriteLine($"Число ({a}) не является квадратом числа ({b})");
    }
       System.Console.WriteLine("Не забудь протестировать меня введя и другие числа!");
       
