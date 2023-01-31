int Akkerman(int m, int n) {
    if (m == 0)
		return n + 1;
    else if (n == 0 && m > 0)
		return Akkerman(m - 1, 1);
	else
		return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

Console.Write("Enter the first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Akkerman(m, n));