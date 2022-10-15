// Вид 1 Методы нияего не возвращают и ничего не принимают   
void Method1() // Кдючевое слово "void" и в скобках нет никаких аргументов  
{
    Console.WriteLine("Автор ... "); // тело метода которое может что-то показывать на экран! 
}
//Method1(); // Вариант как вызываются подобного рода методы. Указываеться идентификатор этого метода и круглые скобки!!!

// Вид 2 // Методы, которые ничего не возвращают но могут принимать какие-то аргументы
void Method2(string msg) // "void" - ключевое слово, "Method2" - идентификатор, (string ms) и какоето кол-во аргументов
{
    Console.WriteLine(msg); // Выводим сообщение
}
//Method2("Текст сообщения"); // Вызываем метод
//Method2(msg: "Текст сообщения"); //Вызываем метод. Бывают именованные аргументы где явно указывается какому аргументу какое значение мы хотим указать.


void Method21(string msg, int count) // "void" - ключевое слово, "Method2" - идентификатор, (string ms) и какоето кол-во аргументов
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method2("Текст сообщения"); // Вызываем метод
//Method21("Текст", 4); //Вызываем метод. Бывают именованные аргументы где явно указывается какому аргументу какое значение мы хотим указать.
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый Текст");

// 3 Вид  Что-то возвращают  но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int yaer = Method3(); // "yaer" идентификатор переменной через оператор присваивания положим нужное значение
//Console.WriteLine(yaer); // используем значение которое нам вернул метод

// 4 Вид  Что-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {

//         result = result + text;
//         i++;
//     }
//     return result;
// }
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;

    }
    return result;
}

string res = Method4(10, "z ");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    }

    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);