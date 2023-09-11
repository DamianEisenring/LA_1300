# Projekt-Dokumentation

Damian Eisenring

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.2023      | 0.0.1   | die Grundlagen für das Projekt funktionieren.|
| 30.08.2023| 1.0.0   | das Projekt ist fertig gestellt.|
|       | ...     |                                                              |


## 1 Informieren

### 1.1 Ihr Projekt

Ich habe ein Zahlenratespiel in WPF programmiert. 
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss |Funktional| Der Computer speichert eine Zufallszahl zwischen und mit 1 bis 100 als Geheimzahl.|
| 2    |Muss |Funktional| Der Benutzer kann Zahlen raten. |
| 3    |Muss |Qualitität| Für jede der geratenen Zahlen gibt der Computer einen Hinweis aus.v|
| 4    |Muss |Qualitität| Wenn die Geheimzahl erraten wurde, soll die Anzahl der Rateversuche ausgegeben werden.|
| 5    |Muss |Qualitität| Das Programm soll mit Fehleingaben umgehen oder sie vermeiden können.|
| 6    |Muss |Qualitität| Das Programm sollte Hintergrundmusik abspielen. |
| 7   |Muss |Qualitität| Das Programm sollte ein GUI haben|
| ...  |                 |      |                                    |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Zahl wird generiert   |  Zahl eingabe      |   Zahl ausgabe  |
| 2.1  | Zahl eingegeben (weite verkürzt)      |  Zahl  | Resultat, ob weiter gespielt wird.|
| 3.1  |  Zahl wird generiert | 80 |  Zahl ist zu gross |
| 3.2  |  Zahl wird generiert |   15 |  Zahl ist zu klein |
| 4.1  |  Zahl wird erraten | 50 (X) | Anzahl Versuche(Y): Y  |
| 5.1  | Programm startet| sechsunddreissig(allgemein Zeichen/Buchstaben) |  Ungültige Eingabe!  |
| 6.1  | Zahl wurde erraten |   35   | Gratuliere du hast es geschafft!|
| ...  |              |         |                   |

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung |
| ---- | ----- | --------- | ------------ | 
| 1.A  |    23.08.2023   |Damian Eisenring|      5min, Der Computer speichert eine Zufallszahl zwischen und mit 1 bis 100 als Geheimzahl.       | 
|  2.A  |     23.08.2023    |Damian Eisenring           | 5min, Der Benutzer kann Zahlen raten.             |
|  3.A  |   23.08.2023      |     Damian Eisenring      |     1 Lektionen, Für jede der geratenen Zahlen gibt der Computer einen Hinweis aus         |
|  4.A |    30.08.2023     |        Damian Eisenring   |   30min, die Rateversuche werden ausgegeben.            |
|  5.A |    30.08.2023     |          Damian Eisenring |    60min, Das Programm soll mit Fehleingaben umgehen können.          |
|  6.A  |  06.09.2023     |      Damian Eisenring     |   3 Lektionen, Gui gestallten           |
|  7.A  |    06.09.2023   |      Damian Eisenring     |      1 Lektion, Hintergrundmusik finden und einfügen.        |
| ... |       |           |              |



## 3 Entscheiden

Ich habe mich entschieden das Projekt mit WPF zu machen und alle User Stories in Visual Studio 2022 zu realisieren. 

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 2.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 3.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 3.2  |   06.09.2023  | funktioniert|Damian Eisenring|
| 4.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 5.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 6.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| ...  |       |          |        |

Ich konnte alle User-Stories implementieren und somit funktionierten auch alle Testfälle so wie sie sollten. 




