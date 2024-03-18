var name = "Franek";
var age = 15;
var isMale = true;
if (isMale == false)
{
    if (age < 30)
    {
        Console.WriteLine("kobieta przed 30");
    }
    if (age == 30 && name == "Ewa")
    {
        Console.WriteLine("Ewa lat 30");
    }
}
if (isMale == true && age < 18)
{
    Console.WriteLine("niepelnoletni mezczyzna");
}
