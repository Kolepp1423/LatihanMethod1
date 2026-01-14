int a = 10, b = 2, c = 0;

void Tambah()
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

void Kurang()
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
void Kali()
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void Bagi()
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

Tambah();
Kurang();
Tambah();
Kali();
Bagi();