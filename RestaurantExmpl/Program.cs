namespace RestaurantExmpl
{
    internal class Program
    {
        static async Task<Toast> UpecToast()
        {
            Console.WriteLine("Začínám péct toast");
            await Task.Delay(2000);
            Console.WriteLine("Toast je hotov!");
            return new Toast();
        }

        static async Task<Slanina> UsmazSlaninu()
        {
            Console.WriteLine("Začínám smažit slaninu");
            await Task.Delay(5000);
            Console.WriteLine("Slanina je hotová!");
            return new Slanina();
        }

        static async Task<Vajicka> UpecVajicka()
        {
            Console.WriteLine("Začínám smažit vajíčka");
            await Task.Delay(2500);
            Console.WriteLine("Vajíčka jsou hotová!");
            return new Vajicka();
        }

        static async Task<Caj> UvarCaj()
        {
            Console.WriteLine("Dávám vařit čaj");
            await Task.Delay(5000);
            Console.WriteLine("Čaj je hotový!");
            return new Caj();

        }

        static async Task<Kava> UvarKafe()
        {
            Console.WriteLine("Dávám vařit kávu");
            await Task.Delay(6000);
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
            Task.WhenAll(cajik, toust, kafe, slanina, vajca).GetAwaiter().OnCompleted(() =>
            {
                TimeOnly konec = TimeOnly.FromDateTime(DateTime.Now);
                TimeSpan vysledek = konec - start;
                Console.WriteLine($"Doba trvání: {vysledek.Seconds}s");
            });
            Console.ReadKey();
           
            

        }
    }
}
