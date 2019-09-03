# Übung 15 - Medienverwaltung Aufgabe 5

# Teil 1

Bei jedem Auftreten eines Leih-/Rückgabefehlers soll automatisch ein Protokolleintrag in eine Log-Datei _Error.log_ geschrieben werden. Dort soll der gleiche Fehlertext wie in der Konsole eingefügt werden. Nutzen sie dazu Ihre selbst erstellte Klassenbibliothek aus der „Logger Übung“.

Um eine Klassenbibliothek einzubinden müssen Sie dem Projekt einen Verweis auf die DLL hinzufügen. Außerdem sollten Sie den Namespace der DLL in Ihr Projekt einbinden („using“).

# Teil 2

Die Methoden für das Entleihen und Rückgeben sollen bei Fehlschlag der Plausibilitätskontrolle keinerlei Meldung mehr ausgeben sondern stattdessen eine eigene Exception „StatusErrorException“ werfen. Beim Auslösen wird dieser Exception die ganzzahlige Signatur (als String) des betroffenen Mediums übergeben.
Das Hauptprogramm fängt diese Exception ab und sorgt nun selbst für die Fehlermeldung. Da das Hauptprogramm keine Kenntnis von den Details des Fehlers haben soll, beschafft es den passenden Fehlertext über die Eigenschaft „Message“ der Exception-Klasse. D.h. die Message Eigenschaft muss in der Exception Klasse überschrieben werden. Diese Eigenschaft liefert einen Fehlertext mit folgendem Aufbau als String zurück:

```bash
	Fehler beim Leihen/Rueckgeben von Signatur 25265.
```