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

            #region Monster Auswahl

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
                Console.Write("Choose Character 1 (1-3): ");
                while (!int.TryParse(Console.ReadLine(), out choice1) || choice1 < 1 || choice1 > 3)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    Console.Write("Choose Character 1 (1-3): ");
                }

                // Hier das Arme Schwein das gegen das erste Monster antreten muss.
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Choose Character 2 (1-3): ");
                while (!int.TryParse(Console.ReadLine(), out choice2) || choice2 < 1 || choice2 > 3)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                    Console.Write("Choose Character 2 (1-3): ");
                }

                // Choice 1 (Monster 1) wird mit Choice 2 (Monster 2) verglichen und geprüft, ob es Idioten gibt, die nicht lesen können und zweimal den selben ausgewählt haben.
                if (choice1 == choice2)
                {
                    // Wenn es eine Doppelung gibt, wird diese Fehlermeldung ausgegeben.
                    Console.WriteLine("The monsters cannot be the same race. Please select again.");
                    Console.ReadKey();
                    Console.Clear();
                }
                // Wenn es eine Doppelung gibt, wird die Auswahl wiederholt.
            } while (choice1 == choice2);

            #endregion

            #region Attribute Vergabe

            float hp1, ap1, dp1, s1, hp2, ap2, dp2, s2;

            // Hier wird das erste Monster mit Werten vollgestopft, die für den Kampf zwingend benötigt werden.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter the attributes for Monster 1 (Life points (HP), Attack strength (AP), Defense points (DP), Speed (S)): ");

            // Eingabe für Monster 1
            #region HP
            Console.Write("HP = ");
            while (!float.TryParse(Console.ReadLine(), out hp1) || hp1 < 0 || hp1 != Math.Floor(hp1))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("HP = ");
            }
            #endregion

            #region AP
            Console.Write("AP = ");
            while (!float.TryParse(Console.ReadLine(), out ap1) || ap1 < 0 || ap1 != Math.Floor(ap1))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("AP = ");
            }
            #endregion

            #region DP
            Console.Write("DP = ");
            while (!float.TryParse(Console.ReadLine(), out dp1) || dp1 < 0 || dp1 != Math.Floor(dp1))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("DP = ");
            }
            #endregion

            #region S
            Console.Write("S = ");
            while (!float.TryParse(Console.ReadLine(), out s1) || s1 < 0 || s1 != Math.Floor(s1))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("S = ");
            }
            #endregion

            Console.WriteLine();

            // Hier das zweite Monster mit Werten vollgestopft.
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter the attributes for Monster 2 (Life points (HP), Attack strength (AP), Defense points (DP), Speed (S)): ");

            // Eingabe für Monster 2
            #region HP
            Console.Write("HP = ");
            while (!float.TryParse(Console.ReadLine(), out hp2) || hp2 < 0 || hp2 != Math.Floor(hp2))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("HP = ");
            }
            #endregion

            #region AP
            Console.Write("AP = ");
            while (!float.TryParse(Console.ReadLine(), out ap2) || ap2 < 0 || ap2 != Math.Floor(ap2))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("AP = ");
            }
            #endregion

            #region DP
            Console.Write("DP = ");
            while (!float.TryParse(Console.ReadLine(), out dp2) || dp2 < 0 || dp2 != Math.Floor(dp2))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("DP = ");
            }
            #endregion

            #region S
            Console.Write("S = ");
            while (!float.TryParse(Console.ReadLine(), out s2) || s2 < 0 || s2 != Math.Floor(s2))
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer without decimals.");
                Console.Write("S = ");
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.White;

            #endregion

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
