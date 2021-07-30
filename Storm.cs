// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
        { get; private set; }
        public bool IsStrong
        { get; private set; }
        public string Caster
        { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }
        public void Annouce()
        {
            string IsStrongString = "";
            if (IsStrong == true)
            {
                IsStrongString = "strong";
            }
            else
            {
                IsStrongString = "weak";
            }

            Console.WriteLine($"{Caster} cast a {IsStrongString} {Essence}");
        }

    }
}
