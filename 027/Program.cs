// Задача_№27 Найти расстояние между точками в пространстве 2D
double x1, y1, x2, y2; 
System.Console.WriteLine("Введите в терминал последовательно значения для координат (x1,y1,x2,y2)");
            System.Console.WriteLine("подтверждая ввод каждого нажатием клавиши 'Enter' ");
             System.Console.Write("x1=");
             x1=Convert.ToInt32(Console.ReadLine());
              System.Console.Write("y1=");
             y1=Convert.ToInt32(Console.ReadLine());
              System.Console.Write("x2=");
             x2=Convert.ToInt32(Console.ReadLine());
              System.Console.Write("y2=");
             y2=Convert.ToInt32(Console.ReadLine());
double distanse=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
System.Console.WriteLine($"Растояние между двумя точками на 2D пространстве равно: {distanse}");



















