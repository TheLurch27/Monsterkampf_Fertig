namespace Monsterkampf_Fertig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ist das Kunst oder kann das weg?
            Console.WriteLine(" __  __  ____  _   _  _____ _______ ______ _____  _  __          __  __ _____  ______ \n|  \\/  |/ __ \\| \\ | |/ ____|__   __|  ____|  __ \\| |/ /    /\\   |  \\/  |  __ \\|  ____|\n| \\  / | |  | |  \\| | (___    | |  | |__  | |__) | ' /    /  \\  | \\  / | |__) | |__   \n| |\\/| | |  | | . ` |\\___ \\   | |  |  __| |  _  /|  <    / /\\ \\ | |\\/| |  ___/|  __|  \n| |  | | |__| | |\\  |____) |  | |  | |____| | \\ \\| . \\  / ____ \\| |  | | |    | |     \n|_|  |_|\\____/|_| \\_|_____/   |_|  |______|_|  \\_\\_|\\_\\/_/    \\_\\_|  |_|_|    |_|");
            Console.ReadKey();
            Console.Clear();

            // Viel Bla Bla... Kurze erklärung halt.
            Console.WriteLine("let two monsters fight each other and see who wins!");
            Console.ReadKey();
            Console.Clear();

            // Es wird erklärt angezeigt welche Ziffer zu welchem Monster gehört. Die der Spieler dann hoffentlich Ordnungsgemäß eingeben kann!
            Console.WriteLine("Choose 2 Characters for the fight (BUT: The same monsters are not allowed twice!): ");

            Console.WriteLine("1 - Troll");
            Console.WriteLine("2 - Wizard");
            Console.WriteLine("3 - Goblin");

            int choice1, choice2;
            do
            {
                // Hier wird das erste Monster ausgewählt.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Choose Character 1: ");
                choice1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // Hier das Arme Schwein das gegen das erste Monster antreten muss.
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Choose Character 2: ");
                choice2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // Choice 1 (Monster 1) wird mit Choice 2 (Monster 2) verglichen und geprüft ob es idioten gibt die nicht lesen können und zwei mal den selben ausgewählt haben.
                if (choice1 == choice2)
                {
                    // Wenn es eine Doppelung gibt, wird diese Fehlermeldung ausgegeben.
                    Console.WriteLine("The monsters cannot be the same race. Please select again.");
                    Console.ReadKey();
                    Console.Clear();
                }
                // Wenn es eine Doppelung gibt, wird die Auswahl wiederholt.
            } while (choice1 == choice2);

            // Hier wird das erste Monster mit Werten vollgestopft, die für den Kampf zwingend benötigt werden.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the attributes for Monster 1 (Life points (HP), Attack strength (AP), Defense points (DP), Speed (S)): ");
            Console.Write("HP = ");
            float hp1 = float.Parse(Console.ReadLine());
            Console.Write("AP = ");
            float ap1 = float.Parse(Console.ReadLine());
            Console.Write("DP = ");
            float dp1 = float.Parse(Console.ReadLine());
            Console.Write("S = ");
            float s1 = float.Parse(Console.ReadLine());
            Console.WriteLine();

            // und hier das zweite....
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the attributes for Monster 2 (Life points (HP), Attack strength (AP), Defense points (DP), Speed (S)): ");
            Console.Write("HP = ");
            float hp2 = float.Parse(Console.ReadLine());
            Console.Write("AP = ");
            float ap2 = float.Parse(Console.ReadLine());
            Console.Write("DP = ");
            float dp2 = float.Parse(Console.ReadLine());
            Console.Write("S = ");
            float s2 = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            // Hier wird die Variable für das Erste Monster Initalisiert.
            Monster monster1 = null;
            // Joa und hier für das Zweite.
            Monster monster2 = null;

            // Das erste arme Schwein ähh Monster wird erstellt basierend auf die Eingabe die der Nutzer getätigt hat.
            switch (choice1)
            {
                case 1:
                    monster1 = new Monster(hp1, ap1, dp1, s1, "Troll");
                    break;
                case 2:
                    monster1 = new Monster(hp1, ap1, dp1, s1, "Wizard");
                    break;
                case 3:
                    monster1 = new Monster(hp1, ap1, dp1, s1, "Goblin");
                    break;
            }

            // Hier wird das zweite Monster für den Kampf erstellt. (Macht ja sonst auch keinen Sinn) ^^
            switch (choice2)
            {
                case 1:
                    monster2 = new Monster(hp2, ap2, dp2, s2, "Troll");
                    break;
                case 2:
                    monster2 = new Monster(hp2, ap2, dp2, s2, "Wizard");
                    break;
                case 3:
                    monster2 = new Monster(hp2, ap2, dp2, s2, "Goblin");
                    break;
            }

            int round = 1; // DING DING DING... Hier wir die Erste Runde Initailisiert.
            while (monster1.HP > 0 && monster2.HP > 0) // Hier wird der Kampf immer weiter geführt solange niemand abgenippelt ist.
            {
                Console.WriteLine($"Round {round}:"); // <- Hier würde in Amerika beim Boxen eine Dame mit dem Schild durch den Ring laufen, hier nur leider nicht so Ästhetisch. Die Runden werden ausgegeben.

                if (monster1.S >= monster2.S) // "Wer zuerst kommt, mahlt zuerst" oder wie war das? Hier wird geschaut welches Monster am schnellsten, der Schnellste fängt an.
                {
                    monster1.Attack(monster2); // Hier bekommt Monster 2 von Monster 1 eins auf die Zwölf...
                    if (monster2.HP > 0) // Lebt Monster 2 noch? Wenn ja, gibts die Passende antwort darauf.
                    {
                        monster2.Attack(monster1); // und zwar hier!
                    }
                }
                else // Hier ist das selbe nur umgekehrt (falls Monster 2 der schnellere ist)
                {
                    monster2.Attack(monster1);
                    if (monster1.HP > 0)
                    {
                        monster1.Attack(monster2);
                    }
                }

                round++; // Hier wird die Runden Anzahl immer weiter erhöht, solange beide Monster noch Leben.
            }
            if (monster1.HP <= 0) // Es wird gecheckt ob Monster 1 den Löffel abgegeben hat.
            {
                // In diesem Block wird Monster 2 als Sieger gekührt, weil man in der if (monster1.HP <= 0) festgestellt hat das Monster 1 ein Looser ist.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{monster2.Race} wins the fight in {round - 1} Rounds!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                // Hier genau umgekehrt.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{monster1.Race} wins the fight in {round - 1} Rounds!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
