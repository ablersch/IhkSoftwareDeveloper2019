# C# Grundlagen

Grundlagen, Programmaufbau, Codekonventionen, Kommentare, Strings, Methoden, Operatoren, Iterationen


<!-- .slide: class="left" -->
## C Sharp

* C\# (gesprochen "C Sharp") wurde bei Microsoft von Anders Hejlsberg 2001 entwickelt.

* Die aktuelle Version C\# 7.3 wurde 2018 mit dem Microsoft .NET Framework 4.7 bzw .NET Core veröffentlicht.

* Die Programmiersprache ist voll objektorientiert und beinhaltet verschiedene Elemente aus den Sprachen C, C++, Java, Pascal und Basic.

* C\# wurde wie Java auf Hardwareunabhängigkeit entwickelt (.NET Framework und .NET Core).

* [TOP 20 Programmiersprachen](https://fossbytes.com/most-popular-programming-languages/)


<!-- .slide: class="left" -->
## Programmaufbau

```csharp
using System; // Assemblies einbinden
using System.Linq;

namespace Programmaufbau //Projektteile werden in Namensräumen zusammengefasst
{
    class Program // Bauplan für Abbildung von realen Objekten
    {
        static void Main(string[] args) // Einstiegspunkt mit Parameter Array
        {
            string text = "IHK";
            text += " Software Developer";

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine(text.ElementAt(j));
                }
                Console.Write("\n");
            }

            Console.WriteLine("Taste drücken um zu beenden...");
            Console.ReadKey();
        }
    }
}
```

Note: Static kann ausgeführt werden ohne Instanz einer Klasse. Daraus können selbst nur statische Methoden aufgerufen werden.

Zeigen in **VS**


<!-- .slide: class="left" -->
## Codekonventionen

* Generell sind nur Buchstaben erlaubt, keine Zahlen oder Sonderzeichen.
* Pascal-Schreibweise (jeden Anfangsbuchstaben eines Wortes groß)
    * bei Klassen- und Methodennamen
    * **WriteToErrorLog()**
* Camel-Schreibweise (jeden, außer den ersten Anfangsbuchstaben eines Wortes groß)
    * bei Variablen
    * **string exportFilePath**
* Großbuchstaben
    * bei Konstanten
    * **APPLICATIONPATH = "xxxx"**
* aussagekräftige Namen verwenden
* Mehr zum Thema [Namenskonvention](https://docs.microsoft.com/de-de/dotnet/standard/design-guidelines/naming-guidelines)


<!-- .slide: class="left" -->
## Codekonventionen

* Einrückungen immer nur per Tab (4 Zeichen) nicht mit Leerzeichen
* ein Namespace und eine Klasse pro Datei
* nur eine Variable auf einmal deklarieren
* nicht selbsterklärende Stellen im Code kommentieren
* zum Kommentieren nicht /\* \...\*/ benutzen sondern // oder ///


<!-- .slide: class="left" -->
## XML-Kommentare

* Durch die Verwendung von XML Tags kann der Code kommentiert und diese Kommentare auch mit Intelli-Sense angezeigt werden.
* Ein Export zu Dokumentationszwecken ist möglich.
* Das Grundgerüst wird automatisch generiert.
* Mehr zum Thema [XML-Kommentare](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)

```csharp
/// <summary>
/// Beschreibung der Methode
/// </summary>
/// <param name="args">Parameter beschreiben</param>
/// <returns>Return Wert beschreiben</returns>
```

Note: In VS zeigen

* VS Layout umstellen
* Projekt anlegen
* Methoden autom erstellen
* Codevervollständigung
* Intelli Sense


<!-- .slide: class="left" -->
## String

Bei [**string**](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/string) handelt es sich um eine Klasse mit Methoden. Damit kann mit Zeichenketten gearbeitet werden.

```csharp
string zeichenKette;

zeichenKette = "Hallo C#";
Console.Write(zeichenKette);

zeichenKette = zeichenKette + " - Fans\n";
Console.Write(zeichenKette);

Ausgabe:
========
Hallo C#
Hallo C# - Fans
```


<!-- .slide: class="left" -->
### String Methoden

* String Vergleich

```csharp
string text = "IHK Ulm";
if (text == "IHK Ulm")   => true
if (text.Equals("IHK Ulm"))  => true
if (text.Equals("ihk ulm", StringComparison.OrdinalIgnoreCase))  => true
```

* Länge eines Strings ermitteln

```csharp
int i = text.Length;
```

* Umwandeln in String

```csharp
text = text + i;     //.ToString()
text += i;
```

* Teilstring von Index 0 bis Index 2

```csharp
text = text.Substring(0, text.IndexOf("K") +1); // Array Index beginnt bei 0
```

* Teile eines Strings ersetzen

```csharp
text = text.Replace("H", "A");
 ```

Note: weitere Methoden zeigen in **VS**. z.B. IsNullOrEmpty, Trim, Remove, ...


<!-- .slide: class="left" -->
### String Formatierung

```csharp
// 00001234
int value = 12345;
Console.WriteLine(value.ToString("D8"));

// [1-23-45]
Console.WriteLine(value.ToString("[##-##-##]"));
 ```

Mehr zum Thema [String Formatierung](https://docs.microsoft.com/de-de/dotnet/standard/base-types/formatting-types)


<!-- .slide: class="left" -->
### String Konvertierung

* Konvertierung eines Strings in int mit der Klasse **Convert**

```csharp
string text = "580";
int zahl = Convert.ToInt32(text);
```

* Konvertierung mit **Parse**

```csharp
zahl = Int32.Parse(text);
```

* Prüfen ob Konvertierung möglich ist mit **TryParse**

```csharp
//Ref Parameter
bool result = Int32.TryParse(text, out var zahlVariable);  
if (!result) {
    Console.WriteLine("Umwandlung fehlgeschlagen");
}
```

* Konvertierung von **double** nach int

```csharp
double zahl = 12.66789;
int intZahl = Convert.ToInt32(zahl);  // gerundet 13
```

Mehr zum Thema [String Konvertierung](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number)

Note: Bei Convert und Parse Fehler abfangen


<!-- .slide: class="left" -->
## Ein- & Ausgabe

Die wichtigsten Methoden zur Ausgabe gehören zur Klasse [Console](https://docs.microsoft.com/de-de/dotnet/api/system.console?view=netframework-4.7.2) im
Namespace System. Sie lauten:

| Methode      | Beschreibung
| -------------|-------------|
| `Read()`     | Liest ein Zeichen von der Standardeingabe ein.
| `ReadLine()` | Liest eine Zeile als **String** von der Standardeingabe.
| `Write()`    | Gibt einen String auf der Standardausgabe ohne Zeilenumbruch aus.
| `WriteLine()`| Entspricht Write() nur mit Zeilenumbruch.

Es gibt mehrere Möglichkeiten, um eine bestimmte Ausgabe zu erzeugen.

**Beispiel:** Es soll die Ausgabe *"Die Summe von 1500 plus 500 ist
2000"* erzeugt werden.

Note: cw (if, for, ...) + tab + Tab in **VS**


<!-- .slide: class="left" -->
### Lösung (String Verkettung)

* Verkettung mit "+"-Operator

```csharp
Console.WriteLine("Die Summe von "+ a + " plus " + b + " ist " + sum);
```

* Einsatz von Platzhaltern

```csharp
Console.WriteLine("Die Summe von {0} plus {1} ist {2}", a, b, sum);
Console.WriteLine($"Die Summe von {a} plus {b} ist {sum}");
```

* Einsatz von Platzhaltern (erweiterte Formatierung)

```csharp
// Festkomma ,0 ,00 ,000
Console.WriteLine("Die Summe von {0:F1} plus {1:F2} ist {2:F3}", a, b, sum); 
```

* Einsatz von Platzhaltern (erweiterte Formatierung)

```csharp
Console.WriteLine("Die Summe von {a,-20:D} plus {b,-20:D} ist {sum,-20:D}");
```

Mehr zum Thema [String Verkettung](https://docs.microsoft.com/de-de/dotnet/csharp/how-to/concatenate-multiple-strings)

Note: Platzhalter können mehrfach verwendet werden.

{0,-20:D}  rechts der Zahl 20 Stellen frei

**ÜBUNG** Array


<!-- .slide: class="left" -->
# Methoden

## Methodendefinition

* Methoden können definierte Parameter entgegennehmen.
* Eine Methode kann nur einen oder auch keinen (void) Wert zurückgeben.
* Methoden werden innerhalb der Klasse ausformuliert.
* Methoden gehören immer zu einer Klasse.
* Eine Klasse kann mehrere Methoden enthalten, wobei die Methoden in
* beliebiger Reihenfolge deklariert werden können.
* Mit Methoden wird eine Aktion ausgeführt, Daten verändert oder ausgegeben.
* Mehr zum Thema [Methoden](https://docs.microsoft.com/de-de/dotnet/csharp/methods)

Note: In C# wird nur von Methoden gesprochen. Keine Unterscheidung wie in C von Funktion (mit Rückgabewert) oder Prozedur (void)


<!-- .slide: class="left" -->
## Syntax der Methodendefinition

Methoden werden innerhalb einer Klasse oder Struktur definiert. Mit:

**Zugriffsebene, Rückgabewert, Name und Parameter**

```csharp
using System;

namespace Programmaufbau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ergebnis: " + Addition(12, 10));

            int result = Addition(10, 10);

            Console.WriteLine("Taste drücken um zu beenden...");
            Console.ReadKey();
        }

        private static int Addition(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
    }
}
```


<!-- .slide: class="left" -->
## Überladen (Overloading)

Von **Überladen** spricht man, wenn mehrere Methoden den gleichen Namen
aber eine unterschiedliche Anzahl an Parametern oder unterschiedliche
Parametertypen haben.

```csharp
void Multiplikation(double) {}
void Multiplikation(int) {}
void Multiplikation(int, int) {}
void Multiplikation(float, float, int) {}
int Multiplikation(float, float, int) {} --> Fehler, nicht möglich
```


<!-- .slide: class="left" -->
## Ref Parameter

Es gibt zwei Möglichkeiten um Parameter an eine Methode zu übergeben:

* Parameterübergabe als Wert (**call by value**)
* Parameterübergabe als Verweis (**call by reference**)

Normalerweise wird **call by value** verwendet. Der Wert wird als **Kopie
übergeben** und kann bearbeitet werden. Der ursprünglich übergebene Wert
wird dabei nicht verändert.

Damit der ursprüngliche Wert ebenfalls
geändert werden kann, kann der Wert als **Verweis** (Reference) übergeben
werden. Dazu wird das Schlüsselwort [ref](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/ref) verwendet.

```csharp
int zahl = 2;
Addiere(ref zahl);
...
Addiere(ref int zahlTemp) {
    // die Variable Zahl wird überschrieben
    zahlTemp = zahlTemp + 5;
}
```


<!-- .slide: class="left" -->
## Out Parameter (Ausgabeparameter)

Ausgabeparameter ([out](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/out-parameter-modifier)) verhalten sich genau wie ref-Parameter, nur dass diesen nicht initialisierte Variablen übergeben werden können.

Dieser Parameter wurden spezielle für den Fall entwickelt das eine
Methode mehrere Werte zurückgeben soll. Dieser Parameter übergibt der
Methode keinen Wert, sondern teilt ihr mit, in welcher Variable sie
einen bestimmten Wert speichern soll z.B. wird dies bei TryParse verwendet.

```csharp
Addiere(10, 5, out int result);

bool Addiere(int zahl1, int zahl2, out int result) {
    result = zahl1 + zahl2;

    if (result > 10){
         return true;
    } else {
        return false;
    }
}
```

Note: **VS** Sichtbarkeit und Methoden


<!-- .slide: class="left" -->
# Operatoren

Mehr zum Thema [Operatoren](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/)

Note: z.B. Postfix Operator zeigen


<!-- .slide: class="left" -->
# Enumeration

[Enumerations](https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/enumeration-types) helfen Programme leichter lesbar zu gestalten. Meist werden
Konstanten oder Optionen damit abgebildet.

```csharp
using System;

class Program
{
    enum ErrorStatus
    {
        None=100,  
        Trivial=200,  
        Important=300,  
        Critical=900
    };

    static void Main()
    {
        ErrorStatus eStatus = ErrorStatus.Critical;

        if (eStatus == ErrorStatus.Trivial)
        {
            Console.WriteLine("Not true");
        }
        else if (eStatus == ErrorStatus.Critical)
        {
            Console.WriteLine("True");
        }
        Console.WriteLine($"Der Status Code ist {eStatus} mit dem Wert {eStatus.GetHashCode()}"); // oder (int)eStatus)
         }
     }
```

Note: **VS** Enum


<!-- .slide: class="left" -->
# Kontrollstrukturen

Durch [Kontrollstrukturen](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/selection-statements) sind wir in der Lage, Programme nicht nur sequentiell, also Zeile für Zeile, ablaufen zu lassen. Wir haben die
Möglichkeit Programme sinnvoll zu strukturieren und zu steuern.


<!-- .slide: class="left" -->
## IF-ELSE - Anweisung

```csharp
int testValue = 1;
string text;

if (testValue == 0)
{
    text = "Bedingung erfüllt";
}
else  
{
    text = "Bedingung nicht erfüllt"
}
```

[Bedingungsoperator (Frageoperator)](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/conditional-operator) liefert immer einen Ausdruck bzw. eine Wertzuweisung: **?:**

```csharp
string text = (testValue == 0) ? "erfüllt" : "nicht erfüllt";
```

Mehr zum Thema [IF-ELSE](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/if-else)

Note: if(else) + tab + tab


<!-- .slide: class="left" -->
## SWITCH-CASE - Anweisung

Bei der SWITCH-Anweisung wird der Ausdruck in der Anweisung ausgewertet
und in Abhängigkeit des ganzzahligen Ausdrucks zum entsprechenden CASE
gesprungen.

```csharp
int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        Console.WriteLine("Case 1");
        break;
    case 2:
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}
```

Note: switch + tab + tab


<!-- .slide: class="left" -->
**NEU:** C\# erlaubt auch **Strings** als Switch-Variable:

```csharp
string str = "Stuttgart";
switch (str)
{
   case "Ulm":
        Console.WriteLine("Case 1");
        break;
    case "Stuttgart":
        Console.WriteLine("Case 2");
        break;
    default:
        Console.WriteLine("Default case");
        break;
}
```

Mehr zum Thema [SWITCH-CASE](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/switch)


<!-- .slide: class="left" -->
# Schleifen (Iterationen)
## For-Schleife

```csharp
for( int i=0; i < 10; i++ )
{
    Console.WriteLine("i hat den Wert: " + i);
}
```

Mehr zum Thema [For-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/for)

Note: for (aufsteigender Counter) fore (absteigender Counter) + tab + tab


<!-- .slide: class="left" -->
## While-Schleife

```csharp
int i = 0;
while( i < 99 )
{
    Console.WriteLine("i hat den Wert: " + i);
    i++;
}
```
Mehr zum Thema [While-Schleifen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/while)


<!-- .slide: class="left" -->
## Foreach-Anweisung

Die [foreach-Anweisung](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/foreach-in)) kann auf Arrays und für jede Klasse eingesetzt
werden, die die Schnittstelle IEnumerable implementiert. Fehler mit
falscher Indexierung sind nicht mehr möglich.

**For Schleife:**

```csharp
double [] meinArray = new double [] { 1.1, 1.2, 1.3, 1.4, 1.5 };
for(int i=0; i < meinArray.Length; i++)
{
    Console.WriteLine($"{meinArray[i]}\n");
}
```

**Foreach:**

```csharp
foreach (double meinWert in meinArray)
{
    Console.WriteLine($"{meinWert}\n");
}
```

**Achtung:** Der foreach-Bezeichner "meinWert" ist schreibgeschützt. Er
kann also nicht zur Zuweisung von Arraywerten verwendet werden!

Note: Sinnvoll wenn alle Werte durchlaufen werden sollen aber kein Index benötigt wird.

GetEnumerator() Index abgerufen und bearbeitet werden

foreach + tab + tab


<!-- .slide: class="left" -->
# Sprunganweisungen

## Break und Continue

```csharp
// Schleife komplett beenden, Execute nie ausführen
for (int i = 0; i < 10; i++) {
    if (i == 0) break;
    Execute("DoSomething");
}
```

```csharp
// Execute nur beim ersten Durchlauf nicht ausführen.
// Continue beginnt nächste Iteration
for (int i = 0; i < 10; i++) {
    if (i == 0) continue;
    Execute("DoSomething");
}
```

Mehr zum Thema [Sprunganweisungen](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/jump-statements)

Note: ÜBUNG Fakultät und Palindrom (wdh von C)
