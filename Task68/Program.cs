int Ackermann(int m, int n) {
    if (m == 0) {
        return n + 1;
    }
    if (n == 0) {
        return Ackermann(m - 1, 1);
    }
    return Ackermann(m - 1, Ackermann(m, n - 1));  
}

try {
    Console.Write("Введите первое неотрицательное целое число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (m >= 0) {
        Console.Write("Введите второе неотрицательное целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n >= 0) {
            Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackermann(m, n)}");
        } else {
            Console.WriteLine("Вы ввели отрицательное число.");
        }
    } else {
        Console.WriteLine("Вы ввели отрицательное число.");
    }
} catch (FormatException) {
    Console.WriteLine("Вы ввели не целое число.");
}