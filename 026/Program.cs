﻿// Задача_№26 Программа проверяет пятизначное число на палидромом. Например 12321
int z=12321;
int d0,d1,d2,d3,d4;
int x,y;

d0=z%10;
d1=z/10%10;
d2=z/100%10;
d3=z/1000%10;
d4=z/10000%10;

x=d0-d4;
y=d1-d3;

 if(x-y+d2==d2)
   {
       System.Console.WriteLine($"{d4}{d3}{d2}{d1}{d0}=={d0}{d1}{d2}{d3}{d4} введённое число палидромм!");
   }
else
      System.Console.WriteLine($"Число {d4}{d3}{d2}{d1}{d0} Не равняется числу {d0}{d1}{d2}{d3}{d4} и не является палидромом!");






 


