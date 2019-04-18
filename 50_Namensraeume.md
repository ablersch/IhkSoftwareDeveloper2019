# Namensräume

Schon oft genutzt doch warum werden diese benötigt?


<!-- .slide: class="left" -->
## Allgemein

Klassen und Methoden können in sogenannten Namensräumen (engl. Namespaces) hierarchisch geordnet werden.

* Der Code wird übersichtlicher, weil Namensräume die erstellten Klassen nach Themen oder Aufgaben ordnen.

* Namen müssen innerhalb eines Namensraums eindeutig sein:<br/>
&rarr; Der gleiche Bezeichner kann in verschiedenen Namensräumen verwendet werden.

* Namensräume können eingebunden werden: <br/>
&rarr; Zugriff auf Klassen wird einfacher und kürzer (keine Qualifizierung der Elemente).

* Namenskollision in globalen Namensräumen vermeiden (z.B. Dürfen zwei Klassen den gleichen Namen in verschiedenen Namensräumen verwenden. Zugriff aber dann mit voll qualifiziertem Name)

Note: Wie eine Art Ordnerstruktur damit passenden Methoden gefunden werden können.

Kategorisieren


<!-- .slide: class="left" -->
## Eigenen Namensraum einrichten

* Es ist üblich, die Namespace Struktur anhand der Projektstruktur zu gliedern z.B. **Firma.ProjektName.UnterProjekt**.

* Man fasst in der Regel funktional verwandet Klassen in einem Namensraum zusammen.

* Innerhalb dieser Hierarchie können weitere Namespaces eingerichtet werden, mit denen Klassen nach Themen sortiert werden können.

![Namespace](Images/Namespace.png)


<!-- .slide: class="left" -->
### Syntax

```csharp
namespace NameOfNamespace
{
    class NameOfClass // Definitionen der Klassen
    {
    ...
    }
...
//Ende Namespace
}
```


<!-- .slide: class="left" -->
## Zugriff auf Namensräume

* Damit auf Klassen eines Namensraums zugegriffen werden kann, muss ein Verweis auf den Namensraum bestehen.

* Standardmäßig besitzen neue Projekte bereits mehrere Verweise auf Namensräume.

* Im Projektmappen-Explorer erhält man eine Übersicht über eingebundene Verweise und kann neue hinzufügen.

![Verweise](Images/VerweiseAnzeigen.png)


<!-- .slide: class="left" -->
## Namensräume einbinden

Um einen Namensraum einzubinden wird `using` verwendet:

```csharp
using meinNamespace;

// ohne using:
meinNamespace.MeineKlasse.MeineFunktion();

// mit using
MeineKlasse.MeineFunktion();
```

Note: ÜBUNG Wetterstation