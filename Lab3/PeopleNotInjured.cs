using System.Text;

namespace Lab3;

internal class PeopleNotInjured : ILoggable
{
    //public void LogAsync() => Console.WriteLine("Оформление по европротоколу, т.к. не пострадали люди");

    public async void LogAsync()
    {
        using FileStream fstream = new FileStream("PeopleNotInjuredOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Оформление по европротоколу, т.к. не пострадали люди");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}
