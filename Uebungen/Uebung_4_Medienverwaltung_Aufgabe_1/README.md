# Übung - Medienverwaltung Aufgabe 1

Gegenstand der Übungsaufgaben ist es, den Bestand einer Bibliothek an Literatur und sonstigen Medien durch einen objektorientierten Entwurf zu repräsentieren.
Das Programm soll so entworfen werden, dass es keine detaillierten Kenntnisse über die Attribute der Medienklasse besitzt. Wenn insbesondere das Medium weitere Eigenschaften erhalten soll, müssen sich die notwendigen Änderungen am Programm auf die Medien Klasse beschränken.

## Teil 1

Erstellen Sie eine Konsolenanwendung mit einer weiteren Klasse "Medien" (neue Datei). Diese Klasse soll folgende Variablen haben:

* Leihstatus
* Signatur
* Titel

Jedes Medium soll eine ganzzahlige Signatur, einen Titel und ein Attribut für den Leihstatus (präsent/entliehen) besitzen.

Außerdem soll die Klasse folgende Methoden haben (weitere Beschreibung siehe Tabelle):

* `Anlegen()`
* `List()`
* `Entleihen()`
* `Rueckgabe()`

## Teil 2

Erstellen Sie in der Main Methode ein Menü welches die Methoden aus der "Medien" Klasse aufruft. Aufbau des Menüs bitte aus der Tabelle entnehmen. Es genügt, wenn aktuell nur ein Medium Objekt existieren kann.

**Folgende Funktionen/Menüpunkte sollen zur Verfügung stehen:**

|Kommando    | Aktion
-------------|----------
|„m“| Anlegen und Initialisieren des Mediums. Der Benutzer soll Signatur und Titel eingeben. Die Signatur darf nur aus Zahlen bestehen.|
|„l“| Anzeigen der Medieneigenschaften in tabellarischer Form mit einer Spaltenüberschrift. In dieser Aufgabe ist die Typbezeichnung immer „Medium“.|
|„e“| Entleihen des zuletzt angelegten Mediums. Es soll eine Plausibilitätskontrolle erfolgen, ob das Medium überhaupt präsent ist und ggf. eine Warnung ausgegeben werden.|
|„r“| Rückgabe des zuletzt angelegten Mediums. Es soll eine Plausibilitätskontrolle erfolgen, ob das Medium überhaupt entliehen ist und ggf. eine Warnung ausgegeben werden.|
|„q“|Programm beenden|

## Beispiel

```bash
Medienbestand
Signatur                Titel             Leihstatus
123                     Test              präsent
```

## Hinweis

Diese Anwendung wird in weiteren Aufgaben stetig ausgebaut. Insbesondere fügen wir eine Listenverwaltung für den Medienbestand und weitere Medientypen hinzu.
