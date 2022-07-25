using System.Text.RegularExpressions;

string text = "Мы ехали на машине и увидели на дороге знак там";
string patern = @"\b[а-яА-Я]{1,3}\b";
string target = "ГАВ!";

Regex regex = new Regex(patern);
string result = regex.Replace(text, target);

Console.WriteLine(result); 
