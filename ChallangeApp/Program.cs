int number = 1234567890;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
var counter0 = 0;
var counter1 = 0;
var counter2 = 0;
var counter3 = 0;
var counter4 = 0;
var counter5 = 0;
var counter6 = 0;
var counter7 = 0;
var counter8 = 0;
var counter9 = 0;
foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    if (letter == '1')
    {
        counter1++;
    }
    if (letter == '2')
    {
        counter2++;
    }
    if (letter == '3')
    {
        counter3++;
    }
    if (letter == '4')
    {
        counter4++;
    }
    if (letter == '5')
    {
        counter5++;
    }
    if (letter == '6')
    {
        counter6++;
    }
    if (letter == '7')
    {
        counter7++;
    }
    if (letter == '8')
    {
        counter8++;
    }
    if (letter == '9')
    {
        counter9++;
    }
}
Console.WriteLine("tyle zer " + counter0);
Console.WriteLine("tyle jedynek " + counter1);
Console.WriteLine("tyle dwojek " + counter2);
Console.WriteLine("tyle trojek " + counter3);
Console.WriteLine("tyle czworek " + counter4);
Console.WriteLine("tyle piatek " + counter5);
Console.WriteLine("tyle szostek " + counter6);
Console.WriteLine("tyle siodemek " + counter7);
Console.WriteLine("tyle ósemek " + counter8);
Console.WriteLine("tyle dziewiatek " + counter9);
