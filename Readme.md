# AMANA IFP Client f�r den Digitalen Finanzbericht

## Installation

Die aktuellste Version des Clients steht unter folgender Adresse zum Download zur Verf�gung: [GitHub Releases](https://github.com/amanaconsulting/DiFin-Client/releases)

Die ZIP-Datei muss entpackt und die AMANA.IFP.WinClient.exe gestartet werden. Grunds�tzlich lassen sich die DLL's aber auch als API in Drittanwendungen verwenden.

Zur Versendung wird ein Zertifikat ben�tigt. Nach Vorliegen der Teilnahme- und Verbindlichkeitserkl�rung (https://digitaler-finanzbericht.de/files/Digitaler-Finanzbericht_Teilnahme-und-Verbindlichkeitserklaerung.pdf) 
erfolgt die Beantragung des Zertifikats �ber den Zertifikate-Client der Schufa (http://downloads.amana-consulting.de/xbrl/Difin/Kurzanleitung_SCHUFA%20Zertifikate.pdf). Die Zertifikatsdatei sollte dann als Benutzerzertifikat unter Windows
installiert werden (als Computerzertifikat installiert muss die WinClient.exe im Admin-Modus ausgef�hrt bzw. explizit Berechtigungen zum Verarbeiten des Zertikats f�r das entsprechende Benutzerkonto gesetzt werden). Das Zertifikat muss dann einmalig 
unter "Allgemeine Einstellungen" im Tool ausgew�hlt werden.

Zum automatischen Download der Routing Tabelle muss einmalig Benutzername/Passwort f�r den Schufa SFTP Zugang in "Allgemeine Einstellungen" gesetzt werden. Die Zugangsdaten hierf�r werden von der Schufa bereitgestellt.

## Systemvoraussetzungen

* Windows-Betriebssystem
* .NET Framework 4.5.1

## Leistungsmerkmale

![Der IFP Client bietet eine kofortable Benutzeroberfl�che mit Validierung.](https://amana-consulting.de/files/_theme/uploads/graphics/ifp_client.png "Der IFP Client bietet eine kofortable Benutzeroberfl�che mit Validierung.")

### Open Source

Die Leistungen der hier angebotenen Open Source Variante:

* Einfache Benutzeroberfl�che
* Stammdateneingabe
* Stammdatenvalidierung
* Versendung mittels Routing an beliebige Banken
* Anzeige der Versendungsr�ckmeldung
* Automatische �bernahme der Stammdaten aus XBRL in die IFP Header
* Automatischer Download der Routing Tabelle (Institutsmapping)

### Professional (kostenpflichtig)

Zus�tzlich zu den Leistungen der Open Source Variante bietet die Professional Edition:

* XBRL �Checker�-Validierung vor dem Absenden
* Support und Gew�hrleistung durch AMANA
* Konverter: Excel/CSV -> XBRL und XBRL -> Excel/HTML/PDF

### Enterprise XBRL Portal (kostenpflichtig)

Zus�tzlich zu den Leistungen der Open Source und der Professional Variante bietet die Enterprise XBRL Portal Edition:

* Datenbankgest�tzte Verwaltung von Mandanten und Abschl�ssen
* Excel-Visualisierung der XBRL-Meldungen
* Workflow-gesteuerte Mehrbenutzerf�higkeit
* Berechnung und Anzeige von Kennzahlen
* Datenextraktion und Schnittstellen zu Data Warehouse Systemen
* Vollst�ndiger Audit-Trail und Ablage der Versendungsergebnisse
* Server f�r den Digitalen Finanzbericht
* XBRL Web-Editor 

## Lizenzinformationen

Dieses Programm ist freie Software. Sie k�nnen es unter den Bedingungen der GNU General Public License, Version 3, wie von der Free Software Foundation ver�ffentlicht, weitergeben und/oder modifizieren. Link zu den GPL: https://www.gnu.org/licenses/gpl-3.0.txt

Es wird hierzu auch eine unverbindliche Deutsche �bersetzung angeboten: http://www.gnu.de/documents/gpl.de.html 

Sollten sich aus der Deutschen �bersetzung Unklarheiten ergeben, gilt im Zweifel die Englische Originalfassung. Sollten Sie mit den Lizenzbedingungen nicht einverstanden sein, sind Sie nicht berechtigt, den AMANA Client f�r den Digitalen Finanzbericht in der Open-Source-Variante zu nutzen.

Selbstverst�ndlich k�nnen Sie das Programm im Rahmen der Lizenzbedingungen in beliebiger Weise nutzen. Wir w�rden uns aber besonders freuen, wenn Sie mit uns in einen interaktiven Prozess eintreten, welcher die Open-Source-Variante des AMANA Clients f�r den Digitalen Finanzbericht besser macht. Sie erreichen uns elektronisch unter info@amana-consulting.de oder per Telefon unter +49 (0)201 94622 800.
