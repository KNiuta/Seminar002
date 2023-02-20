// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//            семизначного числа или сообщает, что третьей цифры нет.

//            78 -> третьей цифры нет

//            3267900 -> 6

Console.WriteLine("Введи семизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if(number<100)
{
              Console.WriteLine("Третьей цифры нет.");
}
else if ((number>999999) && (number<10000000)) 
{
              result = (number%100000-number%10000)/10000;
              Console.WriteLine($"Третья цифра числа равна: {result}");
}            
else   Console.WriteLine("Введенное число не явлеятся семизначным числом.");               
 
              
