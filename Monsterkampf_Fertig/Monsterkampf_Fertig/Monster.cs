using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsterkampf_Fertig
{
    class Monster
    {
        // Das sind Konstrukoren um Attribute der Monster zu erstellen.
        public float HP { get; set; } // Lebenspunkte / Health-Points
        public float AP { get; set; } // Angriffspunkte / Attack-Points
        public float DP { get; set; } // Abwehrpunkte / Defense-Points
        public float S { get; set; } // Geschwindigkeit / Speed
        public string Race { get; set; } // Rasse / Race

        public Monster(float hP, float aP, float dP, float s, string race)
        // Hier werden die angegebenen Werte des Monsters eingetragen.
        {
            HP = hP;
            AP = aP;
            DP = dP;
            S = s;
            Race = race;
        }

        public void Attack(Monster target)
        // Die Methode sorgt dafür das sich die Monster aufs Maul hauen können.
        {
            float damage = AP - target.DP; // Hier wird die Höhe des Schadens berechnet.
            damage = Math.Max(damage, 0); // es wird dafür gesorgt das der Wert nicht negativ sein kann.

            target.HP -= damage; // Hier passiert das, was man als Gamer hasst. die Lebenspunkte schwinden dahin.
            Console.WriteLine($"{Race} attacks and deals {damage} damage to {target.Race}."); // Bisschen Text um es lesbarer zu machen.
        }
    }
}
