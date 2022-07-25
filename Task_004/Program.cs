using System.Globalization;
using Task_004;

Check check = new Check(new Product[] 
{     
    new Product("Кроссовки", 2920), 
    new Product("Сандали", 3922), 
    new Product("Туфли", 1220)
});

var col = check.Show();

foreach (var item in col)
{
    Console.WriteLine("Product [Default PC Culture] = {0}", item);
    Console.WriteLine("Product [Custom US Culture] = {0}", item.ToString("B", CultureInfo.CreateSpecificCulture("en-US")));
    Console.WriteLine(new String('-', 3));
}