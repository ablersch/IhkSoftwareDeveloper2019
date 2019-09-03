# Übung 8 - Sekunden speichern

Erstellen Sie eine Klasse namens „Sekunden“. Diese Klasse soll Sekunden speichern können.

Folgenden Methoden sollen implementiert werden:

* `public ulong GetSeconds()`
* `public ulong GetMinutes()`
* `public ulong GetHours()`
* `public ulong GetDays()`

Die Sekunden sollen dabei in die entsprechenden Formate umgerechnet werden. (xx Sekunden entsprechen xx Minuten).

Verwenden Sie alle Methoden der Klasse mindestens einmal. Zum "Speichern" der Sekunden benutzen Sie bitte die Variable "sekunden". Die Variable soll mit dem **Konstruktor** der Klasse befüllt werden.

## Bemerkung

Die Sekunden können fest vorgegeben werden oder auch per Eingabe abgefragt werden. Es sollen nur ganze Minuten, Stunden und Tage angezeigt werden.

* Minute 	= 60 Sekunden
* Stunde 	= 60 * 60 = 3600 Sekunden
* Tag 	= 3600 * 24 = 86400 Sekunden


## Beispiel Ausgabe

```bash
Sekunden eingeben:
888

Sekunden: 888
Minuten: 14
Stunden: 0
Tage: 0
```

# Erweiterung (optional)

Ändern bzw. erweitern Sie Ihr Programm, damit die Sekunden nicht umgerechnet werden, sondern immer die Restwerte ([Modulo](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-)) angezeigt werden. Hierzu muss mit dem Rest weiter gerechnet werden!

## Beispiel Ausgabe

```bash
Sekunden eingeben:
888

Tage: 0 Stunden: 0 Minuten: 14 Sekunden: 48
```

```bash
Sekunden eingeben:
7771516

Tage: 89 Stunden: 22 Minuten: 45 Sekunden: 16
```