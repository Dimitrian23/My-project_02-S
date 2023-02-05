// Задача_№21 Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
int day;
int d;
      System.Console.WriteLine("Введите пожалуйста число любого дня недели (от 1 до 7)");
      System.Console.WriteLine("Посмотрим смогу ли я определить является ли данный день недели выходным днём!?)");
           d=Convert.ToInt32(Console.ReadLine());
day=d;
   if(day==6 || day==7 )
      System.Console.WriteLine($"({day})_й день недели является выходным днём!");
      else

   if (day>=1 && day<=5) System.Console.WriteLine($"({day})_й день недели является будним днём!");
      else 
      System.Console.WriteLine("Вы ввели некоректные данные! Внимательно прочтите условие и повторите попытку!");
