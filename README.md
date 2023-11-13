# Projeket-Dokumentation Budegt-Assistent


Auftrag 2 Budget-Assistent; Aeschliman, Albrecht, Kaderli

| Datum | Version | Zusammenfassung |
| --- | --- | --- |
|25.09.2023   | 0.0.1  | Heute haben wir das Projekt kennengelernt und uns mit diesem auseinandergesetzt, wir haben eine Mindmap erstellt mit: den im Porjektauftrag erwähnten Meilensteinen, den Anforderungen, den Rollen und einem Möglichen Mockup. |
|  30.10.2023   | 0.0.2 |  Heute haben wir die Anfrderungen für das Programm, die Testfälle, Plannung und die Aufteilung bei Programmieren gemacht. Dannach haben wir mit dem Ersten Code gestartet.   |
| 06.11.2023    | 1.0.0 |   Heute haben wir mit dem Coden angefangen und sind relativ weit gekommen aber manschmal hat es fassen gegeben bei denen wir keine ahnug hatten und uns toutoriels reine ziehen mussten um die Sachen zu verstehen.  |

## 1 Informieren

### 1.1 Ihr Projekt

![image](https://github.com/Joel-kaderli/Budgetassistent/assets/111046353/5b1f47a0-f2aa-4929-ace5-e5f44b8db76d)

In unserem Programmierprojekt, programmieren wir eine WinForms-Applikation bei welcher man sein Budget planen kann.

### 1.2 Anforderungen

| №   | Verbindlichkeit | Typ | Beschreibung |
| --- | --- | --- | --- |
| 1   |    Muss |   Funktional  | Aufnahme von den wichtigten Eckwerten der Finanziellen Situation des Nutzers  |
| 2   |    Muss | Funktional    | Wiederkehrebde ausgaben und einnahmen speichern    |
| 3   |    Muss |   Funktional  | Der Nutzer soll unerwartetde weitere einnahemen und ausgaben eintragen und so eine übersicht über das gegenwärtige Budget erhalten.   |
|  4  |  Kann   | Funktional |In einer erweiterung kann der Nutzersparziele festlegen, es kann auch berechnet werden wie lange es brauchen kann die Spar Ziele zu erreichen. |
|   5  |   Muss   |    Qualität    | Soll ausgaben innert einer Sekunde machen |
|   6  |   Muss   |    Qualität    | In Winform gute anordnung genacht sein und die Gleicheschriftart|

### 1.3 Testfälle

| TC-№ | Vorbereitung (*given*) | Eingabe (*when*) | Erwartete Ausgabe (*then*) |
| --- | --- | --- | --- |
| 1.1 |  Programm gestartet   | 2. Falls nicht Ja/Nein 5. Ja 7. 7500  |  1. Möchten sie ein Bugdetplanung machen? Ja/Nein? 3. Ihre eingabe ist Falsch! 4. 6. Geben sie hier ihr regelmässiges einkommen ein.   |
| 1.2 |  1.1   | 2. 5500 4. Im Menu auswählen, feste ausgaben   | 1. Was sind Ihre festen ausgaben im Monat? 3. Menu poppt auf mit auswahl an festen ausgaben.   |
| 1.3 | 1.2    | 2. Benuzer wählt aus liste aus.     | 1. Ein weiteres Menü, mit unerwartet ausgaben, poppt auf, mit einer Liste mit verschieden unerwarteten fällen.   |
|  1.4   |  1.3   | 2. Ja  4. 1000 6. Auswahl des Benutzers 8. Unbekannt | 1. Benutzer kann sagen ob er sparzeiel festlegen Ja/Nein 3. Wie viel man sparen will im Monat? 5. Was man sich davon kaufen will wider poppt ein Menu auf. 7. Bis wann man das sparziel erreichen will? 9. Wird ins Budget eingeplant   |
|     |     |     |     |
|     |     |     |     |







### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung |
| --- | --- | --- | --- |
|1|30.10.2023 |Joel|  Testfälle dokumentieren |
|2|3.11.2023  |Christian|  Meilenstein 1   |
|3|30.10.2023 | Mathieu|  Helfen bei Testefällen und Meilenstein 1  |
|4|10.11.2023 | Alle| Lernatteliel in Winform einarbeiten     |
|5|3.11.2023  | Alle| Winform einarbeiten |
|6|12.11.2023 | Alle|  Meilenstein 2    |
|7|14.11.2023 | Alle|  Besprechung mit Auftraggeber    |
|8|21.11.2023 | Alle|   Zweite Besprechung mit Auftraggeber  |
|9|     |     |     |

Meilenstein 1: Mit dem Auftraggeber(Frau Klink) fehlende Details abklären, Testfälle zeigen.
Meilenstein 2: Fertigstellen des Prototyps.

Wer programmiert was? 
- Christian: Gui
- Mathieu: Berechnung des Budgets mit regelmässigen Ein- und Ausgaben
- Joel: Programm das Benutzer abfragt(Einnahem, ausgaben usw.)

✍️ Total: bspw. 26 Arbeitspakete

## Fein Plannung 6.11.2023
- [ ] Dateien auslesen und einlesen programmieren (Joel)
- [x] Digramm in winform erstellen (Mathieu)
- [x] Programm kann Beträge in Variabeln speichern welche über das dafür vorgesehenen TextFeld eingegeben wurden. (Christian)

## Fein Planung 13.11.2023
- [ ] Fragen vorbereiten für das Gespräch mit dem Kunden(Joel, Mathieu)
- [ ] Dateien mit Inputinformationen einlesen und auslesen(Joel, Mathieu)
- [ ] Icons im UI zu Buttons hinzufügen(Christian)
- [ ] Das kreisdiagramm soll die Daten aus einem Array nehmen(Joel, Mathieu)

![image](https://github.com/Joel-kaderli/Budgetassistent/assets/142605851/b7381956-1ae8-4e2d-a351-0cddffa477b2)


## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | tatsächliche Zeit |
| --- | --- | --- |
| 1.A |     |     |
| ... |     |     |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| --- | --- | --- | --- |
| 1.1 |     |     |     |
| ... |     |     |     |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Beschreiben Sie, was gut an Ihrem Projekt ging, und was Sie nächstes Mal anders machen würden.
