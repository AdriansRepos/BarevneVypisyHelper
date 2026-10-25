# BarevneVypisyHelper

Knihovna pro barevné výpisy zpráv a hlášení v konzolových aplikacích.

## Filozofie

Metody v knihovně, například `VypisInformaci` vypíše text určený jako informaci žlutou barvou. Stejně tak jsou zde i další metody pro barevné odlišení úspěchu (zelená), varování (červená), zvýraznění (fialová), hlavičky menu, těla menu (hlavička i tělo modrá) a výzvy k zadání volby (bílá), včetně samotné zadané volby. Barvy se snadno upraví v knihovně, čím se zamezí opakování `Console.ForegroundColor = ConsoleColor.Xxx;` a `Console.ResetColor();` na mnoha místech programu. Dodrží se tak pravidlo DRY a zamezí se nežádoucímu opomenutí změny barvy při požadavku na tuto změnu.

## Metoda

### `VypisInformaci`

```csharp
public static void VypisInformaci(string zprava)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(zprava);
            Console.ResetColor();
        }
```

## Použití

```csharp
using BarevneVypisyHelper;

if (prodeje.Count > 0)
{
    VypisyDoKonzole.VypisUspech($"Celkový příjem z prodejů: {celkovyPrijemZProdeju:0.##} Kč");
}

if (storna.Count > 0)
{
    VypisyDoKonzole.VypisVarovani($"Celkové storno:           {celkoveStorno:0.##} Kč");
}

VypisyDoKonzole.VypisZvyrazneni($"Čistý příjem:             {cistyPrijem:0.##} Kč");
```

## Instalace jako NuGet balíček

Tato knihovna je dostupná také jako balíček v **GitHub Packages**. Můžete si ji snadno přidat do svého projektu:

1. Nastavte si jako zdroj balíčků váš GitHub (pokud ho ještě nemáte v NuGet.config).
2. V **Package Manager Console** spusťte příkaz:
   ```powershell
   Install-Package BarevneVypisyHelper
   ```
