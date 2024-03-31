using System;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sabraniPari = decimal.Parse(Console.ReadLine());

            decimal podShirochina = decimal.Parse(Console.ReadLine());
            decimal podDaljina = decimal.Parse(Console.ReadLine());

            decimal triagalnikStrana = decimal.Parse(Console.ReadLine());
            decimal triagalnikVisochina = decimal.Parse(Console.ReadLine());

            decimal cenaNaPlochka = decimal.Parse(Console.ReadLine());

            decimal cenaZaMaistor = decimal.Parse(Console.ReadLine());



            decimal ploshtNa1Plochka = triagalnikStrana * triagalnikVisochina / 2m;
            decimal ploshtNa1Poda = podShirochina * podDaljina;

            int broiPlochki = (int)Math.Ceiling(ploshtNa1Poda / ploshtNa1Plochka) + 5;

            decimal cenaZaPlochki = cenaNaPlochka * broiPlochki;
            decimal obshtaCena = cenaZaPlochki + cenaZaMaistor;

            if (sabraniPari >= obshtaCena)
            {
                Console.WriteLine($"{(sabraniPari - obshtaCena):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(obshtaCena - sabraniPari):F2} lv more.");
            }

        }
    }
}
