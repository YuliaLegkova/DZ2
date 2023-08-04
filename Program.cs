// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;



Stopwatch stopwatch = new Stopwatch();
List<int> numbers1 = new List<int>(1000000);
stopwatch.Start();
for (int i = 1; i <= 1000000; i++)
    numbers1.Add(i);
stopwatch.Stop();
Console.WriteLine("время заполнения List значениями от 1 до 1000000: " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("поиск элемента с индексом 496753 в List: ");

stopwatch.Start();
var elem496753l = numbers1.ElementAt(496753);
Console.WriteLine(elem496753l);
stopwatch.Stop();
Console.WriteLine("время поиска элемента с индексом 496753 в List " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);

Console.WriteLine("делятся на 777 в List: ");
stopwatch.Start();
List<int> divisibleby777 = numbers1.FindAll(i => i % 777 == 0);
divisibleby777.ForEach(Console.WriteLine);
stopwatch.Stop();
Console.WriteLine("время поиска элементов, которые делятся на 777 в List " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("-----------");

ArrayList numbers2 = new ArrayList();
stopwatch.Start();
for (int i = 1; i <= 1000000; i++)
    numbers2.Add(i);
stopwatch.Stop();
Console.WriteLine("время заполнения ArrayList " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("Поиск элемента с индексом 496753 в ArrayList: ");
stopwatch.Start();
var elem496753al = numbers2[496753];
Console.WriteLine(elem496753al);
stopwatch.Stop();
Console.WriteLine("время поиска элемента с индексом 496753 в ArrayList" + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);

Console.WriteLine("делятся на 777 в ArrayList: ");
stopwatch.Start();
foreach (object obj in numbers2)
    if (obj is int number && number % 777 == 0)
        Console.WriteLine(number);
stopwatch.Stop();
Console.WriteLine("время поиска элементов, которые делятся на 777 в ArrayList " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("-----------");


LinkedList<int> numbers3 = new LinkedList<int>(); ;
stopwatch.Start();
for (int i = 1; i <= 1000000; i++)
    numbers3.AddLast(i);
stopwatch.Stop();
Console.WriteLine("время заполнения LinkedList: " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("Поиск элемента с индексом 496753: ");
stopwatch.Start();
var elem496753ll = numbers3.ElementAt(496753);
Console.WriteLine(elem496753ll);
stopwatch.Stop();
Console.WriteLine("время поиска элемента с индексом 496753 в LinkedList: " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("делятся на 777 в LinkedList: ");
List<int> divisibleBy777ll = new List<int>();
stopwatch.Start();
foreach (int num in numbers3)
    if (num % 777 == 0)
    divisibleBy777ll.Add(num);
stopwatch.Stop();
Console.WriteLine("Числа, делящиеся на 777 в LinkedList: ");
foreach (int num in divisibleBy777ll)
    Console.WriteLine(num);
Console.WriteLine("время поиска элементов, которые делятся на 777 в LinkedList: " + stopwatch.ElapsedMilliseconds + " ms, Ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("-----------");
