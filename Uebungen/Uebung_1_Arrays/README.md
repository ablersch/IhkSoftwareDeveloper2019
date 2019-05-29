# Übung 1 - Arrays

Schreiben Sie ein Konsolenprogramm welches zwei Arrays beinhaltet. In zwei verschachtelten Schleifen soll unten aufgeführte Ausgabe erzeugt werden. Eines der Arrays steht für die Spalten, das andere für die Zeilen.

Die Arrays folgendermaßen definieren:

```csharp
int[] zeile = new int[] { 0, 1, 2, 3 };
int[] spalte = new int[] { 5, 6, 7, 8, 9 };
```

Die Werte können folgendermaßen berechnet werden:

`Zeile[i] * Spalte[j]`

In der Ersten Spalte soll zusätzlich noch die Spaltennummer ausgegeben werden.

Beispiel:  i=2 * j=3 --> 6

## Ergebnis

```bash
Zeile [0]: 0 0 0 0 0
Zeile [1]: 5 6 7 8 9
Zeile [2]: 10 12 14 16 18
Zeile [3]: 15 18 21 24 27

Taste drücken um zu beenden
```