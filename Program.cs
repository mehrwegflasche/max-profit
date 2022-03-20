// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

KnapSackSolver k = new KnapSackSolver();

int[] profits = new int[] { 1, 6, 10, 16 };
int[] weights = new int[] { 1, 2, 3, 5 };
Console.WriteLine(k.GetMax(weights, profits, 7));
