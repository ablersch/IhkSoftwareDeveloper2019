# Übung 5 - Medienverwaltung Aufgabe 1

Erstellen Sie ein Konsolenprogramm welches über ein Menü Daten zu einem Buch anlegen, entleihen, rückgeben und ausgeben kann.

## Buchdaten

* Titel
* Signatur
* Leihstatus (enum)
* Seitenzahl

Jedes Buch soll eine ganzzahlige Signatur, einen Titel, eine Seitenzahl und ein Attribut für den Leihstatus (präsent/entliehen) besitzen.

## Methoden

Die Anwendung soll folgende Methoden haben (weitere Beschreibung siehe Tabelle):

* `Anlegen()`
* `Ausgabe()`
* `Entleihen()`
* `Rueckgabe()`

## Menü

Erstellen Sie in der Main Methode ein Menü welches die oben aufgeführten Methoden aufruft. Aufbau des Menüs bitte aus der Tabelle entnehmen. 

**Folgende Funktionen/Menüpunkte sollen zur Verfügung stehen:**

|Kommando    | Aktion
-------------|----------
|„b“| Anlegen eines Buches. Der Benutzer soll Signatur und Titel eingeben. Die Signatur darf nur aus Zahlen bestehen.|
|„a“| Ausgabe der Bücherdaten in tabellarischer Form mit einer Spaltenüberschrift.|
|„e“| Entleihen des Buches. Es soll eine Plausibilitätskontrolle erfolgen, ob das Buch überhaupt präsent ist und ggf. eine Warnung ausgegeben werden.|
|„r“| Rückgabe des Buches. Es soll eine Plausibilitätskontrolle erfolgen, ob das Buch überhaupt entliehen ist und ggf. eine Warnung ausgegeben werden.|
|„q“|Programm beenden|

## Beispiel

```bash
Medienverwaltung

#### Menue ####
Anlegen eines neuen Buch 'b'
Ausgabe des vorhandenen Buch 'a'
Entleihen des angelegten Buch 'e'
Rueckgabe des Buch 'r'
Programm beenden 'q'

b

Signatur eingeben:
12345
Titel eingeben:
C# Grundlagen
Buch erfolgreich angelegt!
Seitenzahl eingeben:
150

#### Menue ####
Anlegen eines neuen Buch 'b'
Ausgabe des vorhandenen Buch 'a'
Entleihen des angelegten Buch 'e'
Rueckgabe des Buch 'r'
Programm beenden 'q'

e

C# Grundlagen erfolgreich ausgeliehen.

#### Menue ####
Anlegen eines neuen Buch 'b'
Ausgabe des vorhandenen Buch 'a'
Entleihen des angelegten Buch 'e'
Rueckgabe des Buch 'r'
Programm beenden 'q'

a

Ausgabe
Signatur        Titel           Leihstatus           Seitenzahl
12345           C# Grundlagen   entliehen            150

#### Menue ####
Anlegen eines neuen Buch 'b'
Ausgabe des vorhandenen Buch 'l'
Entleihen des angelegten Buch 'e'
Rueckgabe des Buch 'r'
Programm beenden 'q'
```

## Hinweis

Diese Anwendung wird in weiteren Aufgaben stetig ausgebaut.
