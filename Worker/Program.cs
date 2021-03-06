using Worker;
using Newtonsoft.Json;

namespace Worker;
public class Program
{

    public static void Main(string[] args)
    {
        // Console.WriteLine("ARGS----------------------------------------------------------------");
        // foreach (var a in args)
        // {
        //     Console.WriteLine($"[{a}]");
        // }
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<Worker>();
            });

    // IHost host = Host.CreateDefaultBuilder(args)
    //     .ConfigureServices(services =>
    //     {
    //         services.AddHostedService<Worker>();
    //     })
    //     .Build();

    // await host.RunAsync();
}
