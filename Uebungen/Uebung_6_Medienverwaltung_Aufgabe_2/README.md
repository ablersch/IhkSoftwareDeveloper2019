# Übung 6 - Medienverwaltung Aufgabe 2

Bitte die Aufgabe von oben beginnend bearbeiten!

## Teil 1 - Buch-Klasse

Ändern Sie die Medienverwaltung Aufgabe 1 so ab damit alle Daten welche ein Buch betreffen in einer **Buch-Klasse** zusammengefasst sind.

Ändern Sie auch die anderen Teile so ab das die neue Buch-Klasse verwendet wird. Das Programm soll sich nach der Änderung noch genau gleich verhalten wie davor.

## Teil 2 - Video-Klasse

Erweitern Sie ihr Programm um die Klasse Video.

Die Klasse soll folgende Attribute haben:

* Titel
* Signatur
* Leihstatus (enum)
* Laufzeit (double, soll bei der Ausgabe mit 2 Nachkommastellen angezeigt werden)

Außerdem soll die Klasse Video die gleichen Methoden haben wie Buch.

## Teil 3 - Menü

Das Menü soll nach den obigen Änderung folgende Funktionen bieten:

|Kommando    | Aktion
-------------|----------
|„b“| Hinzufügen und Initialisieren eines neuen Buches|
|„v“| Hinzufügen und Initialisieren eines neuen Videos|
|„a“| Anzeigen der Eigenschaften von Buch und Video|
|„e Signatur“| Entleihen des durch die Signatur bezeichneten Objekts. z.B. e 5776|
|„r Signatur“| Rückgabe des durch die Signatur bezeichneten Objekts
|„q“|Programm beenden|

### Signatur

Die Signatur muss mindestens 4 Zeichen beinhalten. Eine Prüfung ob die Signatur bereits vorhanden ist, ist nicht notwendig.

### Entleihen und Rückgeben Methoden

Es müssen die Methoden für das Entleihen und Rückgeben angepasst werden da dort nun überprüft werden muss (anhand der Signatur) ob dieses Medium ausgeliehen/zurückgegeben werden soll.

## Teil 3

Beide Klassen erhalten noch eine enum Variable welche den Typ kennzeichnet. Also ein enum mit den Werten (Buch und Video).

## Beispiel Menü und Ausgabe

```bash
#### Menue ####
Anlegen eines neuen Buch 'b'
Anlegen eines neuen Video 'v'
Ausgabe der vorhandenen Medien 'a'
Entleihen des Medium 'e Signatur'
Rueckgabe des Medium 'r Signatur'
Programm beenden 'q'

Ausgabe
Signatur     Typ       Titel      Leihstatus   Laufzeit
12553        Video     Gladiator  präsent      Dauer 110.50 min
Signatur     Typ       Titel      Leihstatus   Seitenzahl
 5778        Buch      Faust      entliehen    325
```
