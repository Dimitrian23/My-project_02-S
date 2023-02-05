// Задача_№24 Определить номер четверти плоскости, в которой находится точка с координатами(x)и(y), причём x!=0 и y!=0

int x,y;
        System.Console.WriteLine("Введите через терминал значение для координаты (x):");
             x=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Теперь для для координаты (y):");
             y=Convert.ToInt32(Console.ReadLine());
         
 if(x==0|y==0)
   {
        System.Console.WriteLine($"Error____ Вы нарушили правила!!! Переменные (x) и (y) не должны равняться Нулю!!!");
   }
else

 if(x>=1)
  if(y>=1)
    {
        System.Console.WriteLine($"Значения переменных при x=({x}),а y=({y}) находятся в первой четверти!");
    }

 if(x<=-1)
  if(y>=1)
    {
        System.Console.WriteLine($"Значения переменных при x=({x}),а y=({y}) находятся во второй четверти!");
    }

 if(x<=-1)
  if(y<=-1)
    {
        System.Console.WriteLine($"Значения переменных при x=({x}),а y=({y}) находятся в третий четверти!");
    }

 if(x>=1)
  if(y<=-1)
    {
        System.Console.WriteLine($"Значения переменных при x=({x}),а y=({y}) находятся в четвертой четверти!");
    }
