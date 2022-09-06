// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


/* void RandomArray(int[] a)
{
	Random random = new Random();
	for(int i = 0; i < a.Length; i++) a[i] = random.Next(100, 1000);
	Console.WriteLine(String.Join(", ", a));
}

int EvenNumber(int[] a)
{
	int count = 0;
	for(int i=0; i < a.Length; i++)
    {
		if(a[i] % 2 == 0) count++;
	}
	return count;
}

int[] array = new int[10];
RandomArray(array);
Console.WriteLine(EvenNumber(array)); */


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/* void RandomArray(int[] a)
{
	Random random = new Random();
	for(int i = 0; i < a.Length; i++) a[i] = random.Next(1, 100);
	Console.WriteLine(String.Join(", ", a));
}

int Summ(int[] a)
{
	int summ = 0;
	for(int i = 1; i < a.Length; i += 2){
		summ += a[i];
	}
	return summ;
}

int[] array = new int[10];
RandomArray(array);
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях массива равна: " + Summ(array)); */



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void RandomArray(int[] a)
{
	Random random = new Random();
	for(int i = 0; i < a.Length; i++) a[i] = random.Next(1, 100);
	Console.WriteLine(String.Join(", ", a));
}


int[] array = new int[10];
RandomArray(array);
int result = array.Max() - array.Min();
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна: " + result);