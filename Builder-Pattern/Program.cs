using System.Text;
using Builder_Pattern.builder_concreate;
using Builder_Pattern.director;
using Builder_Pattern.product_concreate;

internal class Program
{
    private static void Main(string[] args)
    {
        var showRoom = new List<StringBuilder>();
        var director = new Director();
        var msiBuilder = new MsiBuilder();
        var macBuilder = new MacBuilder();
        director.BuildMsiHome(msiBuilder);
        showRoom.Add(msiBuilder.showProduct());
        var msiHome = msiBuilder.GetProduct();
        director.BuildMacbookAir(macBuilder);
        showRoom.Add(macBuilder.showProduct());
        var macbookAir = macBuilder.GetProduct();
        director.BuildMsiGaming(msiBuilder);
        showRoom.Add(msiBuilder.showProduct());
        var msiGaming = msiBuilder.GetProduct();
        director.BuildMacbookPro(macBuilder);
        showRoom.Add(macBuilder.showProduct());
        var macbookPro = macBuilder.GetProduct();
        director.BuildMacPro(macBuilder);
        showRoom.Add(macBuilder.showProduct());
        var macPro = macBuilder.GetProduct();
        //You can use the products as you want
        var products = new Product[] { msiHome, macbookAir, msiGaming, macbookPro, macPro };
        foreach (var show in showRoom)
        {
            Console.WriteLine(show);
        }
    }
}