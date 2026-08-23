namespace BarevneVypisyHelper
{
    public static class VypisyDoKonzole
    {
        public static void VypisVarovani(string zprava)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(zprava);
            Console.ResetColor();
        }

        public static void VypisUspech(string zprava)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(zprava);
            Console.ResetColor();
        }

        public static void VypisInformaci(string zprava)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(zprava);
            Console.ResetColor();
        }
	
	    // Zvýrazněné výsledky / Souhrny / Čistý příjem (Azurová)
        public static void VypisZvyrazneni(string zprava)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(zprava);
            Console.ResetColor();
        }
	
	    // Vypíše modrou hlavičku menu
        public static void VypisHlavickuMenu(string titulek)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n=== {titulek} ===");
            Console.ResetColor();
        }

        // Vypíše samotný text / možnosti menu (modře)
        // Položky menu s využitím PARAMS
        public static void VypisTeloMenu(params string[] polozky)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var polozka in polozky)
            {
                Console.WriteLine($"\t{polozka}");
            }
            Console.ResetColor();
        }

        // Vypíše výzvu k zadání (neodřádkuje, aby se psalo hned za výzvu)
        public static void VypisVyzvuKZadani(string zadani = "Vyber možnost: ")
        {
            Console.ForegroundColor = ConsoleColor.White; // Nebo jiná barva dle volby
            Console.Write(zadani);
            Console.ResetColor();
        }
    }
}
