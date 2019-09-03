# Übung 13 - Medienverwaltung Aufgabe 4

## Objekte speichern

Nun können mehrere Objekte einer Klasse existieren. Z.b. 2 Video und 3 Bücher Objekte. Der Bestand der Bibliothek soll in einer „Collection“ temporär (nur zur Laufzeit des Programms) gespeichert werden.

**Die Collection beinhaltet alle Objekte.**

## Prüfen und Vergabe der Signatur

Als weiterer Schritt soll die Signatur automatisch (Zufallszahlen) erstellt werden. Nutzen Sie die Klasse Random.

```csharp
Random random = new Random();
int signatur = random.Next(Zahlen von, Zahlen bis);
```

Prüfen Sie ob eine Signatur bereits existiert. Wenn ja eine neue Zufallszahl generieren.

Ebenfalls soll beim Entleihen und Rückgeben geprüft werden ob die eingegebene Signatur überhaupt existiert.

## zusätzliche Kommandos

|Kommando    | Aktion
-------------|----------
|„a“| Titel können eine beliebige Länge haben. Bei der Ausgabe soll die Spaltenstruktur aber erhalten bleiben. Schneiden Sie die Titel bei der Ausgabe entsprechend ab.|
|„l Signatur“| Löschen des durch die Signatur bezeichneten Objekts. z.B. d 2234|
