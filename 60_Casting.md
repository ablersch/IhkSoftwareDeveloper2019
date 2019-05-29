# Casting

Werte umwandeln


<!-- .slide: class="left" -->
## Casting (Umwandlung bzw. Typkonvertierung):

* **is Schlüsselwort:** Prüft ob ein Objekt mit einem bestimmten Typ kompatibel ist.

* **as Schlüsselwort:** Führt eine Konvertierung in den angegebenen Datentyp durch. Bei einem Fehler ist das Objekt null.

* **Klassische Konvertierung:** Um eine Umwandlung durchzuführen, legen Sie den Typ, in den Sie umwandeln, in Klammern vor dem zu konvertierenden Wert/Variable. Bei einem Fehler wird eine Exception geworfen.

```csharp
double d = 1234.7;
int zahl;
// Cast double to int
zahl = (int)d;    -> Ergebnis: 1234
```

Note:
int -> Double implizit (autom vom Compiler)

zahl = (int)d; explizit (auch mit Convert möglich)


<!-- .slide: class="left" -->
## Beispiel

```csharp
Person person;
Object myObject = new Person();
if (myObject is Person) // Prüft ob myObject mit Person kompatibel ist
{
    person = (Person)myObject; // Alternativ:  ((Person)myObject).GetName();
    person.GetName();
}

```

```csharp
person = myObject as Person; // Führt eine Konvertierung aus
if (person != null) // Erfolgreich wenn person nicht null ist
{
    person.GetName();
}
```

Note: **VS** Casting, Collections2, Static

ÜBUNG Medienverwaltung 3

Erklärung zu statisch