# Fehlerbehandlung

Fehler abfangen und behandeln


<!-- .slide: class="left" -->
## Fehlerarten

* **Syntaxfehler:** Syntaxfehler entstehen, wenn sich der Programmierer nicht an die Syntax von C\# hält. Dies passiert durch vertippen oder wenn reservierte Wörter und Methoden in einem falschen Zusammenhang verwendet werden.

* **Laufzeitfehler:** Treten während der Ausführung auf, nachdem das Programm kompiliert worden ist. Typische Laufzeitfehler sind:

  * Es soll eine Datei gelesen werden, die aber nicht vorhanden ist.

  * Wenn für eine Berechnung ein Wert benötigt wird, dieser ab nicht eingegeben wurde.

* **Logische Fehler:** Logische Fehler werden vom Compiler nicht erkannt, da es sich hierbei um Fehler in der Programmlogik handelt. Sie entstehen durch fehlerhafte Berechnungsformeln oder Fehler in der Anwendungslogik.


<!-- .slide: class="left" -->
## Strukturierte Fehlerbehandlung

Die strukturierte Ausnahmebehandlung ermöglicht während der Laufzeit
eine stabile und umfassende Fehlerbehandlung.

* **try:** Mit der try-Anweisung wird der unsichere Programmcode, der Programmcode, der möglicherweise zu einem Fehler führen kann, gekapselt.

* **catch:** Dem Try Codeblock werden dann ein oder mehrere catch-Blöcke zur Fehlerbehandlung zugewiesen, die beim Eintreten eines bestimmten Fehlers abgearbeitet werden sollen.

* **finally:** In einem abschließenden finally-Block, der in jedem Fall ausgeführt wird (immer), lassen sich Bereinigungsaufgaben durchführen oder Ressourcen freigeben (das Schließen von Dateien).


<!-- .slide: class="left" -->
## Ablauf Fehlerbehandlung

![Fehlerbehandlung ](Images/Fehlerbehandlung.png)


<!-- .slide: class="left" -->
### Syntax für try-catch-finally

```csharp
try
{
  ...
}
catch (ExceptionType ExceptionName)
{
  ...
}
[finally]
{
  ...
}]
```

Mehr zum Thema [Try-Catch](https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/try-catch) und [Best practices für Fehlerbehandlung](https://docs.microsoft.com/de-de/dotnet/standard/exceptions/best-practices-for-exceptions)


<!-- .slide: class="left" -->
### Beispiel

```csharp
static void Main(string[] args)
{
  int x = 10;
  int y = 0;

  try
  {
    x = x / y;
  }
  catch (DivideByZeroException e)
  {
    Console.WriteLine(e.Message);
  }
  catch (Exception ex)
  {
    Console.WriteLine(ex.ToString());
  }
  finally
  {
    Console.WriteLine("Der finally-Block wurde aufgerufen.");
  }
}
```


<!-- .slide: class="left" -->
## Übersicht Exceptions

![image](Images/ExceptionUebersicht.png)

Liste über [System-Exceptions](https://www.completecsharptutorial.com/basic/complete-system-exception.php)


<!-- .slide: class="left" -->
## Eigene Ausnahmen erstellen

In bestimmten Situationen kann es sinnvoll sein, eigene Ausnahmen zu erzeugen.

```csharp
string message = "Mein Fehler";
throw new NameOfException (message);
```

Dabei sollte immer ein Name verwendet werden, der mit einer Beschreibung
der Funktionalität beginnt und mit dem Wort **Exception** abschließt.


<!-- .slide: class="left" -->
## Konstruktoren einer Exception-Klasse

Innerhalb einer Exception-Klasse sollten immer drei Konstruktoren deklariert werden, um die Instanzen mit unterschiedlichen Parametern initialisieren zu können.

**Syntax:**

```csharp
public ExceptionClassName() : base()
{
}

public ExceptionClassName(string message) : base(message)
{
}

public ExceptionClassName(string message, Exception ex) : base(message, ex)
{
}
```


<!-- .slide: class="left" -->
## Beispiel: Eigene Exception Klasse

```csharp
public class EmptyStringException : Exception
{
    public EmptyStringException() : base()
    {
    }
    public EmptyStringException(string meldung) : base(meldung)
    {
    }
    public EmptyStringException(string meldung, Exception ex) : base(meldung, ex)
    {
    }
}

class Test
{
    public string Plus(string txt1, string txt2)
    {
      if (txt1.Length == 0 || txt2.Length == 0) {
        throw new EmptyStringException("Mindestens einer der Strings ist leer!");
      }
      else {
        return txt1 + txt2;
      }
    }
}

class Program
{
  static void Main(string[] args)
  {
    Test eineInstanz = new Test();

    try
    {
      Console.WriteLine(eineInstanz.Plus("Zusammen", ""));
    }

    catch (EmptyStringException e)
    {
      Console.WriteLine(e.Message);
    }

    finally
    {
      Console.WriteLine("finally-Block ausgeführt.");
    }
  }
}
```
