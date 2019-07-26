# Übung 13 - Logger

# Teil 1

Ziel ist es eine Logger DLL zu erstellen, die es ermöglicht **ohne Instanz** dieser Klasse Daten in eine Logdatei zu schreiben. D.h. die Klasse und alle ihre Methoden sollen static sein.

Erstellen Sie wie gewohnt ein Konsolenprojekt und nutzen Sie die Main Methode zum Testen Ihres Loggers, indem Sie von dort ihre Logger Methoden aufrufen. Später kann die Main Methode gelöscht und das Projekt auf eine Klassenbibliothek umgestellt werden um eine DLL zu erhalten.

**Achtung:** Nehmen Sie nicht den gleichen Namen für den Namespace und die Klasse.

![Projekteinstellungen](ProjectSettings.png)

Erstellen Sie mindestens zwei Methoden:

* Mit der ersten Methode übergeben Sie den Pfad zu der Stelle an der die Logdatei gespeichert werden soll und den Namen der Datei. Wenn der Ordner  nicht existieren diesen anlegen.

* Mit der zweiten Methode schreiben Sie in die Logdatei.

Außerdem ist folgendes zu beachten:

* Die Logdatei darf nicht größer wie 5MB werden. Wird die Datei größer soll sie gelöscht werden.

* Der Logdateieintrag soll Datum, Uhrzeit und einen Fehlertyp (z.B. Error, Warning, Information ...) beinhalten.

* Kapseln sie alle möglichen Fehlerquellen (vor allem Datei Lese- und Schreibzugriffe) mit using und einem try/catch Block.

## Beispiel Log Eintrag

```bash
02.07.2017 11:31:52 - ERROR: das ist ein logger text
02.07.2017 11:31:52 - ERROR: das ist ein logger text
02.07.2017 11:31:52 - ERROR: das ist ein logger text
```

# Teil 2

Erstellen Sie ein weiteres kleines Konsolenprogramm wo Sie die DLL einbinden, aufrufen und die Funktionalität testen.
