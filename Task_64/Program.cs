void printNatural(int m, int n) {
    if (m <= n) {
        Console.Write(m + " ");
        printNatural(m + 1, n);
	}
}

Console.WriteLine("Enter the first natural number:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second natural number greater than the first one:");
int n = int.Parse(Console.ReadLine());

// Call recursive method with two parameters	
printNatural(m, n);