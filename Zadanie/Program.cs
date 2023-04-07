﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < n; i++)
{array[i] = Console.ReadLine();}

string[] newArray = new string[n];
int count = 0;

for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {newArray[count] = array[i];
        count++;}}

Array.Resize(ref newArray, count);

Console.WriteLine("Новый массив:");
for (int i = 0; i < count; i++)
{Console.WriteLine(newArray[i]);}