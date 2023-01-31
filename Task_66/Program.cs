int sumOfNatural(int m, int n) {
	if (m <= 0 || n <= 0)
		throw new ArgumentException("Both numbers should be natural numbers");
	else if (m > n)
		throw new ArgumentException("The second number should be greater than the first one");
	if (m == n)
		return m;
	return n + sumOfNatural(m, n - 1);
}

try {
	Console.WriteLine("Enter the first natural number:");
	int m = int.Parse(Console.ReadLine());
	Console.WriteLine("Enter the second natural number greater than the first one:");
	int n = int.Parse(Console.ReadLine());
	Console.WriteLine(sumOfNatural(m, n));
} catch (ArgumentException e) {
	Console.WriteLine(e.Message);
}
