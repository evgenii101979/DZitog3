// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
string[] startArray = new string[n];
System.Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < n; i++)
{
    startArray[i] = Console.ReadLine();
}
Console.Write("Введенный массив: ");
for (int i = 0; i < n; i++)
{
    Console.Write(startArray[i] + ", ");
}
string[] endArray = new string[n];

void FinalArrayResult(string[] startArray, string[] endArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
            endArray[count] = startArray[i];
            count++;
        }
    }
}