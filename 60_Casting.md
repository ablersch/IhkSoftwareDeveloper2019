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


<!-- .slide: class="left" -->
## Beispiel

```csharp
Person person;
Object myObject = new Person();
if (myObject is Person)
{
    person = (Person)myObject; -> ((Person)myObject).GetName();
    person.GetName();
}

-------------------------------------

person = myObject as Person;
if (person != null)
{
    person.GetName();
}
```