# Übung 9 - Versandhandel

Für das Beispiel Versandhandel soll folgende Annahme getroffen werden:

Die Firma bietet verschiedene Waren an.

Die Ware hat Attribute (private), wie:

* Bezeichnung
* Nummer
* Preis
* Menge

Auf die Attribute soll nur mit Properties (Eigenschaften) zugegriffen werden können.

Wir schreiben eine Klasse, die den Namen „Artikel“ trägt und die genannten Attribute abbildet. Von dieser Klasse darf keine Instanz erstellt werden dürfen, sondern sie soll nur als **Basisklasse** dienen. Welches Schlüsselwort ist dafür nötig?

Folgende Methode muss von den Kindklassen implementiert und angepasst werden (auch hier ist ein bestimmtes Schlüsselwort notwendig!):

* `void Ausgabe()`

In einem weiteren Schritt soll eine Klasse „Buch“ hinzugefügt werden, die von der Klasse „Artikel“ abgeleitet wird. Dadurch werden der Klasse „Buch“ die Eigenschaften der Klasse „Artikel“ vererbt.

Die Klasse „Buch“ soll folgende zusätzliche Eigenschaften beinhalten:

* BuchTitel
* Author
* Seiten

Folgende Methode soll überschrieben werden:

* `void Ausgabe()`

In der `Ausgabe()` sollen alle Eigenschaften von „Buch“ und „Artikel“ ausgegeben werden. In der `static void Main()` soll von Buch eine Instanz erzeugt und alle Eigenschaften mit einem Wert fest belegt werden und diese mit der `Ausgabe()` ausgegeben werden.

## Beispiel Ausgabe

```bash
Der Titel lautet: Der Herr der Ringe
Der Author ist: J. R. R. Tolkien
Der Buch hat: 1344 Seiten

Die Bezeichnung lautet: BUCH-Der Herr der Ringe
Die Anzahl ist: 4
Die Nummer ist: 542684169
Der Preis ist: 88
```
