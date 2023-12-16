using System.Text;

namespace Lab3;

internal class PeopleInjured : ILoggable
{
    //public void Log() => Console.WriteLine("Оформление не по евро протоколу");

    public async void LogAsync()
    {
        using FileStream fstream = new FileStream("PeopleInjuredOutput.txt", FileMode.OpenOrCreate);
        // преобразуем строку в байты
        byte[] buffer = Encoding.Default.GetBytes("Оформление не по евро протоколу");
        // запись массива байтов в файл
        await fstream.WriteAsync(buffer);
        Console.WriteLine("Текст записан в файл");
    }
}
