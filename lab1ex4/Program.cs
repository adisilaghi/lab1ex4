/*Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”*/

Console.WriteLine("Introduceti numarul");
int Numar = Convert.ToInt32(Console.ReadLine());
if (Numar > 0)
{
    Console.WriteLine("+");
}
else if (Numar < 0)
{
    Console.WriteLine("-");
}
else if (Numar == 0)
{
    Console.WriteLine("0");
}