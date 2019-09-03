# Übung 7 - Intervall

Implementieren Sie die Klasse **Intervall** zur Darstellung von int-Zahlenintervallen mit folgenden Eigenschaften:

* Attribute (min und max) für die Unter- und die Obergrenze welche nur in der Intervallklasse sichtbar/zugreifbar (private) sind

* Mit einem Konstruktor mit Parametern um initial die Werte für Min und Max zu setzen

* Methode „Size“ zur Berechnung der Intervallgröße (max–min) `public int Size()`

* Methode „Avg“ zur Berechnung des Intervall-Mittelwertes ((max-min)/2) `public int Avg()`

* Methode „Move“ zur Verschiebung des Intervalls (max + Verschiebung ; min + Verschiebung) `public void Move(int verschiebung)`

* Methode „Scale“ zum Skalieren des Intervalls (max * Skalierungswert; min * Skalierungswert) `public void Scale(int offset)`

* Methode „IntervallAusgabe“ zum Ausgeben der Intervallwerte (max und min)

Schreiben Sie eine ``Main()`` in der ein Intervall-Objekt (mit festen Werten instanziiert und die genannten Methoden mindestens einmal aufgerufen und die Werte ausgegeben werden.

## Beispiel Ausgabe

```bash
Werte:
Max = 111
Min = 11

Intervallgroesse:
100

Mittelwert:
50

Verschiebung:
Max = 121
Min = 21

Skalieren:
Max = 1210
Min = 210

```