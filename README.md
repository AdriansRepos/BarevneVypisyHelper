## 🌐 Jazyk / Language Selection

*Klikněte na sekci níže pro zobrazení v češtině nebo angličtině.*
*Click on a section below to toggle between Czech and English.*

---

<details open>
<summary>🇨🇿 <strong>ČEŠTINA (Czech Version)</strong></summary>

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

</details>

---

<details>
<summary>🇺🇸 <strong>ENGLISH (English Version)</strong></summary>

# BarevneVypisyHelper

A library for colored message and report outputs in console applications.

## Philosophy

The methods in the library, such as `VypisInformaci`, print text designated as information in yellow. Similarly, there are other methods for color-coding success (green), warning (red), highlighting (purple), menu headers, menu bodies (both header and body are blue), and choice prompts (white), including the entered choice itself. Colors can be easily customized within the library, which prevents repeating `Console.ForegroundColor = ConsoleColor.Xxx;` and `Console.ResetColor();` across many places in the program. This adheres to the DRY principle and avoids unintended omissions of color changes when a color change is requested[cite: 1].

## Method

### `VypisInformaci`

```csharp
public static void VypisInformaci(string zprava)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(zprava);
            Console.ResetColor();
        }
```

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

## nstallation as a NuGet Package
This library is also available as a package in GitHub Packages. You can easily add it to your project[cite: 1]:

1. Set up your GitHub as a package source (if you don't have it in NuGet.config yet).

2. In the Package Manager Console, run the command:
```powershell
Install-Package BarevneVypisyHelper
```

</details>