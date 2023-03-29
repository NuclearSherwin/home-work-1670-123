namespace day_1{
    public class Program {
        public static void Main(string[] args){
            Console.WriteLine("Start App");

            IHostBuilder builder = Host.CreateDefaultBuilder(args);

            builder.ConfigureWebHostDefaults((IWebHostBuilder webBuilder) => {
                // tuy bien them ve host
                // webBuilder.
                webBuilder.UseStartup<MyStartUp>();
            });
        }
    }   
}

