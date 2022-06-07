//Гребенюк А., 21-ИСП-2, 9-я лабораторная, высокий уровень, 2-й вариант. 
Console.WriteLine("Введите двоичное число: ");
var str = Console.ReadLine();
try
{
    long Two = Convert.ToInt32(str, 2);
    string Eight = Convert.ToString(Two, 8);
    Console.WriteLine(Eight);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}