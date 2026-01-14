int c = 0;

void Tambah(int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

void Kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
void Kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void Bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

Tambah(6, 7);
Kurang(5, 2);
Tambah(3, 10);
Kali(9, 6);
Bagi(8, 4);