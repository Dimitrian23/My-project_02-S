// Задача_№25 Задать номер четверти, показать диапазоны для возможных координат
  
int quarter;
        System.Console.WriteLine("Введите через терминал номер четверти, а я покажу диапозон возможных координат (x)(y)");
         quarter=Convert.ToInt32(Console.ReadLine());

    if (quarter==1) 
       {
        System.Console.WriteLine($"Диапазон возможных координат для ({quarter})_й четверти x>0 and y>0");
       }
    if (quarter==2)
       {
        System.Console.WriteLine($"Диапазон возможных координат для ({quarter})_й четверти  x<0 and y>0");
       }
    if (quarter==3) 
       {
        System.Console.WriteLine($"Диапазон возможных координат для ({quarter})_й четверти x<0 and y<0");
       }
    if (quarter==4) 
       {
        System.Console.WriteLine($"Диапазон возможных координат для ({quarter}) четверти x>0 and y<0");
       }
    if (quarter<=0 || quarter>=5)
       {
        System.Console.WriteLine("Неверно задали номер четверти! Значения должны быть в диапазоне (от 1 до 4)");
       }