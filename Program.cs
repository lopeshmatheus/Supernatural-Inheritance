using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s1 = new Storm("wind", false, "Zul'rajas");
            s1.Annouce();
            Pupil pupil1 = new Pupil("Mezil-kree");
            var windCast = pupil1.CastWindStorm();
            windCast.Annouce();

            Mage mage1 = new Mage("Gul'dan");
            var rainCast = mage1.CastRainStorm();
            rainCast.Annouce();

            Archmage archmage1 = new Archmage("Nielas Aran");
            Storm castLightning = archmage1.CastLightningStorm();
            castLightning.Annouce();

        }
    }
}