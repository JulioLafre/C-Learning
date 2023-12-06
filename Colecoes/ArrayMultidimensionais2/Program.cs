int[,] n = { 
    { 11, 22, 33 }, 
    { 44, 55, 66 }, 
    { 77, 88, 99 } 
};

Console.WriteLine("For\n");
for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i, j]} ");
    }
    Console.WriteLine();
}



Console.WriteLine("\nForeach\n");
foreach (var k in n)
{
    Console.Write($"{k} ");
}


Console.ReadLine();