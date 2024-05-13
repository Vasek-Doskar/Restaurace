namespace RestaurantExmpl
{
    internal class Program
    {
        static Toast UpecToast()
        {
            Console.WriteLine("Začínám péct toast");
            Task.Delay(2000).Wait();
            Console.WriteLine("Toast je hotov!");
            return new Toast();
        }

        static Slanina UsmazSlaninu()
        {
            Console.WriteLine("Začínám smažit slaninu");
            Task.Delay(5000).Wait();
            Console.WriteLine("Slanina je hotová!");
            return new Slanina();
        }

        static Vajicka UpecVajicka()
        {
            Console.WriteLine("Začínám smažit vajíčka");
            Task.Delay(2500).Wait();
            Console.WriteLine("Vajíčka jsou hotová!");
            return new Vajicka();
        }

        static Caj UvarCaj()
        {
            Console.WriteLine("Dávám vařit čaj");
            Task.Delay(5000).Wait();
            Console.WriteLine("Čaj je hotový!");
            return new Caj();

        }

        static Kava UvarKafe()
        {
            Console.WriteLine("Dávám vařit kávu");
            Task.Delay(6000).Wait();
            Console.WriteLine("Káva je hotová");
            return new Kava();
        }


        static void Main(string[] args)
        {
            TimeOnly start = TimeOnly.FromDateTime(DateTime.Now);
            var cajik = UvarCaj();
            var toust = UpecToast();
            var kafe = UvarKafe();
            var slanina = UsmazSlaninu();
            var vajca = UpecVajicka();
            TimeOnly konec = TimeOnly.FromDateTime(DateTime.Now);
            TimeSpan vysledek = konec - start;
            Console.WriteLine($"Doba trvání: {vysledek.Seconds}s");
            Console.ReadKey();

        }
    }
}
