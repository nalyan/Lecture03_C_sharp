Console.Clear();
// Метод 1: ничего не возвращает и не принимает
void Method1()
{
    Console.WriteLine("1. Автор...");
}
Method1();

// Метод 2: ничего не возвращает, но принимает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1("2. Текст сообщения 2 раза", 2); //вариант вывода 1
Method2_1(count: 3, msg: "2.1. Текст сообщения 3 раза"); // вариант вывода 2 (позволяет менять местами запись вводных данных в любом порядке)

// Метод 3: возвращает, но не принимает

int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine("3. "+year);

// Метод 4: принимает и возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // result изначально будет пустой строкой
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(3, "4. Текст метода 4");
Console.WriteLine(res);