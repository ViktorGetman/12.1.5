public class Program
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте представьтесь");
        string name = Console.ReadLine();
        string[] array = { "Tom", "Sam", "Bob" };
        if (array.Contains(name))
        {
            Console.WriteLine("Вам доступен премимум материал");
        }
        else
        {
            ShowAds();
        }
    }
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }

}
