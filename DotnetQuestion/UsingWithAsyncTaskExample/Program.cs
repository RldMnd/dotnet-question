/*
 * Что произойдёт? Почему так не стоит делать? Как починить?
 */

Console.WriteLine(await ReadFirstLine("data.txt"));
Console.WriteLine(await ReadFirstLine("data.txt"));

Task<string?> ReadFirstLine(string path)
{
    using (var file = new StreamReader(path))
    {
        return file.ReadLineAsync();
    }
}