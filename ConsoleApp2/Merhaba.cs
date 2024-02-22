
public class Merhaba
{

    public Task<int> myTask;
    public Merhaba(Task<string> task)
    {
        myTask = GetNumber(task);
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Bir selam ver: ");
        string Selam = await Selamla();
        Console.WriteLine($"Al sana selam: {Selam}");
        Console.WriteLine($"Sen merhaba diyorsan bende senin doğduğun şehrin plakasını veririm:");
        Task<int> Plaka = GetNumber(Selamla());
        Console.WriteLine(Plaka);
    }

    static async Task<string> Selamla()
    {

        Console.WriteLine("biraz bekle be!");
        await Task.Delay(2000);

        return "merhaba";


    }

    static async Task<int> GetNumber(Task<string> selamTask)
    {
        if (Selamla()== selamTask)
        {
            
            return 01;
        }
        Console.WriteLine("Selamı doğru dürüst vermezsen sana cevabım İstanbul Plakası olur:");
        await Task.Delay(1000);
        
        return 34;
    }



}