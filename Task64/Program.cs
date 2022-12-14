string NaturalNumsFromMToN(int M, int N) {
    if (N == M) return $"{N}";
    if (N == 1) return "1";
    return NaturalNumsFromMToN(M, N - 1) + ", " + N;
}

try {
    Console.Write("Введите первое целое число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"M = {m}; N = {n}. -> ");
    if (m < n) {
        Console.WriteLine($"\"\"{NaturalNumsFromMToN(m, n)}\"\"");
    } else {
        Console.WriteLine();
    }
} catch (FormatException) {
    Console.WriteLine("Вы ввели не целое число.");
}