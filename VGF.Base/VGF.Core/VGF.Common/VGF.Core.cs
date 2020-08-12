/*#############################################################################
 * 
 * Project			:	Visual.Galaxy.Framework
 * 
 * ############################################################################
 * 
 * ----------------------------------------------------------------------------
 * Programmer       :	Project-Founder and 
 *                  :   Main-Author Christian 🧑 "Tipplin" 🧑 Kurs
 *                  :
 *                  :
 *                  :
 *                  :
 * ----------------------------------------------------------------------------
 * Part				:	VGF.Core
 * ----------------------------------------------------------------------------
 * Base Class       :	
 * ----------------------------------------------------------------------------
 * Dependencies     :   Visual.Operation.Library.dll    - C# Assembly as Friend
 *                  :   Visual.Registry.Library.dll     - C# Assembly as Friend
 *                  :   Visual.Security.Library.dll     - C# Assembly as Friend
 *                  :
 * ----------------------------------------------------------------------------
 * ;---------------------------------------------------------------------------
 * ; NOTE:
 * ;---------------------------------------------------------------------------
 * ; all outside executables like psr.exe can into Project-Solution as Resource
 * ; in Folder Resources. (psr is an windows tool - problem step recorder),
 * ;
 * ;
 * ;---------------------------------------------------------------------------
 * ;REVISION HISTORY:
 * ;---------------------------------------------------------------------------
 * ; 0.0            :   initial startup
 * ;---------------------------------------------------------------------------
 * ; 0.1            :   initial classes in Visual Galaxy Framework.
 * ;---------------------------------------------------------------------------
 * ; 0.2            :
 * ;---------------------------------------------------------------------------
 * ;
 * ;---------------------------------------------------------------------------
 * ;
 * ----------------------------------------------------------------------------
 * IMPORTANT: 
 * ==========
 * As is normal with builds early in the development cycle, 
 * these builds may contain bugs that might be painful for.
 * 
 * At 2020 we migrate this Project to .NET Core 3.0/3.1 
 * later to NEW Framework .NET 5 in Nov 2020 all in ONE !
 * 
 * Development Info:
 * 1. Microsoft Skip Head by Windows Development at Time, 
 * change the current Builds to 
 * Active Development Branch by MS Windows Engineers in develop for Fast Ring
 * -- means the Buildnumbers
 * -- 
 * ----------------------------------------------------------------------------
 * -- Windows 10 - 20h1- 2004 - May Update - Build 19041.264 - Final Release  -
 * -- 27.Mai.2020 - Service End on 14.12.2021 -
 * ----------------------------------------------------------------------------
 * -- NOTE: only the Revisionnumber change to higher after Bugs, 
 * -- Security issues, Automatic Microsoft Registry Entry is UBR in 
 * -- HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion
 * -- BuildLabEx - Windows Compiled Date and Time here: 22.05.2020 at 14:35
 * -- 19635.1.amd64fre.mn_release.200522-1435
 * ----------------------------------------------------------------------------
 * 
 * 
 * 2. Windows goes modular with an Shell Update Agent.
 * 
 * 3. Windows Operation System now written in C and Rust,
 * -- C++ make problems by safety and security parts.(secure leaks)
 * -- all security parts in Windows now written Rust.
 * -- INFO: 
 * -- RustFest in Barcelona with 2 Microsoft Windows Developer more Info.
 * -- YouTube Video - make own Rust - Microsoft Verona - Rust adpotion
 * ----------------------------------------------------------------------------
 * NOTE for Developers:
 * 2020: Visual C# and Java together in this Project, fork IKVM.NET/Java.NET
 * C# Class: and Inherit Java Class
 * private class SaveAssemblyShutdownHook : java.lang.Thread
 * 
 * 
 * 
 * ----------------------------------------------------------------------------
 * WICHTIG: Wie bei Builds zu Beginn des Entwicklungszyklus üblich, 
 * können diese Builds Fehler enthalten, die möglicherweise schmerzhaft sind
 * ----------------------------------------------------------------------------
 * NOTE: 
 * This project supports Only 64 BIT System, while 32 BIT Area goes End.
 * Same Vendors not supports 32 BIT next Time, 
 * real is IBM (all systems 64BIT, IBM old AS/400-OS/400 in 128 BIT written.
 * Father was Frank Solti, rebranding IBM i System -
 * Microsoft NT 4.0 in 64BIT written - Father Dave Cutler - 
 * now what going on? more 128BIT Structs, Enums, 
 * Functions in Windows 10 18945 SDK - 
 * I thing about Big Data comes 2020 with Factor 17 - 
 * Cray Exascale have 1 Quintillion double Prescision)
 * Nvidia, Apple,
 * ----------------------------------------------------------------------------
 * camelCase defintion: 
 * company.project.layer.commponent
 * \company\ndp\source\projectname\filename\filename.cs
 * --------new development
 * 
 * C:\Program Files (x86)\Reference Assemblies
 * \Microsoft\Framework\.NETFramework\v4.8
 * 
 * ----------------------------------------------------------------------------
 * Local time in Europe/Germany are different at seconds,
 * while US have make an leap second at 2018 - 1 minute have now 60 seconds.
 * 03:00:60 -> 03:01:00
 * 
 * Linux and Windows Time Clock have problems by local time,
 * differents UTC, Greenvich
 * ----------------------------------------------------------------------------
 * Change Project-Solution by .NET Framework 4.7.2 to 4.8.03752 Release, 
 * same by Visual Operation System Library - Windows 10 SDK 18362.0 Release Fix
 * Have skip Build by Microsoft OS Update to 2020 - 
 * OS-Build 18985.1 Insider Prelease Stable.
 * this Build have new Libraries, more networking: NIS.dll - ConnectToServer -
 * more Functions in Windows Libraries: shell32, user32, ntdll, kernel32...
 * Windows Sandbox now is stable ! two UI's WinForm and 
 * WPF Form with new Control Titlebar with resizes.
 * Windows Terminal all in one UI, Powershell, cmd, Linux bash
 * 
 * 
 * ----------------------------------------------------------------------------
 * Update Visual Studio 2019 Version 16.4.5 - 11.02.2020
 * Version 16.4 Final, Revision 5 with Bugfixes
 * ----------------------------------------------------------------------------
 * INFO: 
 * 2020 in Novembre come .NET Framework 5 one Platform for all Platforms.
 * 
 * ----------------------------------------------------------------------------
 * Tippo Tip in Visual Studio 2019:
 * ----------------------------------------------------------------------------
 * marked the Classname and then push on F12, complete Class Declaration view.
 * ----------------------------------------------------------------------------
 * right side at buttom sign Bell jar, if gray color no Feature, if color red
 * new feature or bugfixes with new Build or Revision.
 * ----------------------------------------------------------------------------
 * NEW ! For Visual C# Developers:
 * -----------------------------
 * Enumerator with only 1 char: (more not allowed !)
 * enum
 * {
 *      Euro = '€',
 *      Dollar = '$'
 * }
 * ----------------------------------------------------------------------------
 * NEW ! Visual C# 8.0 parts of features are NOT run under .NET Framework,
 * .NET Core 3.0 later .NET 5.0 (November 2020)
 * ----------------------------------------------------------------------------
 * For Support your Application by Customer and Exceptionhandlung:
 * ----------------------------------------------------------------------------
 * Visual Studio Remote Debugger install on Customer System and active
 * the Windows Tool: 
 * ----------------------------------------------------------------------------
 * psr.exe is the Problem System Recorder, all useraction
 * Exception is occured, so have optimal Handling.
 * ----------------------------------------------------------------------------
 * For pure Windows Problems like crash dumps .dmp files, use the better
 * Windows Debugger load in and show clear Information or load your .EXE
 * and show what he loads at native Libraries or .NET Assemblies,
 * 
 * Close ❌ Application, Windows automatic call Function NTTerminate()
 * 
 * ----------------------------------------------------------------------------
 * Change Assemblyname.config Section GC in this File:
 * ----------------------------------------------------------------------------
 * Runtime Block, GCWorkstation to GCServer on a 64 System and 64BIT .NET !
 * VeryLargeObjects and VeryLargeHeaps, NUMA,
 * 
 * ----------------------------------------------------------------------------
 * Visual C# 8.0
 * https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8
 * 
 * 
 * 
 * ----------------------------------------------------------------------------
 * New ‼ Windows 10 Terminal
 * -------------------------
 *  
 *  Scott Hanselman and Terminal Developer Team
 *  https://mybuild.techcommunity.microsoft.com/sessions/77293#top-anchor
 *  
 *  NEW Windows 10 Terminal
 *  make your own settings:
 *  open in \Dir
 *  profiles.json 
 *  
 *  own prompt as fix
 *  Fonts goes open source
 *  Powerline is Font Extentions - unicode -  branch symbol 
 *  GLFS not be into Fonts
 *  
 *  Video game runs under Windows Terminal Old Tennis Game
 *  
 *  Windows 10 Terminal - Menubar
 *  Powershell
 *  Ubuntu
 *  Azure Cloud Shell
 *  
 *  Settings
 *  Feedback
 *------------------------------------------------------------------------------
 *  Urban Traffic Control System have 5 Million Line of Code
 *  Luxury Car 120 Millions Line of Code
 *  
 *  Scott Hanselman
 *  next Visual Studio
 *  INT PREVIEW -  Preview
 *  122 - boold sugar
 * 
 * 
 * ----------------------------------------------------------------------------
 * Windows Operation System 10 with fix Build 18362 and running Revision,
 * at Time Revision .145 - 25.05.2019 - after cleanup bugs. 
 * NOTE: 
 * Registry Key for OS-Revision is UBR as Hexdecinal value, increment by
 * Microsoft.
 * ----------------------------------------------------------------------------
 * Copyright © 2019 by  Visual Galaxy Framework Community Kernel Developer Team
 * ----------------------------------------------------------------------------
 * by Head-Author: Christian 🧑 "TIPPO" 🧑 Kurs - 👀 Visual C# Developer - 👀
 * ----------------------------------------------------------------------------
 * Portions Copyright © 2019 by Microsoft Corporation GmbH.
 * ----------------------------------------------------------------------------
 * 
 * We are currently looking for collaborators. 
 * If you have rich experience in writing 
 * generic framework or enterprise application, 
 * 
 * please contact me at Google Mail:
 * 🧑 kurschristian@gmail.com  🧑
 * 
 * 
 * 
 * ============================================================================
 * ============================================================================
 * 
 * Developer Tippo 🧑 - 🚧 WARNING 🚧 - :
 * 
 * ----------------------------------------------------------------------------
 * ! Brand NEW ! First Microsoft Store in Europe Open in London at 11.07.2019
 * at Regent Street and Oxford Street.
 * 
 * Microsofts Flagshipstore Oxford Circus in London at 21,932 square feet 
 * on three floors, near Regent Street by Apple Store.
 * 
 * Microsoft is planning to include immersive video walls, 
 * a community theater, workshops, training areas, and 
 * even an “Answer Desk” for tech support. 
 * 
 * The site will also include Microsoft’s range of Surface hardware, 
 * Xbox consoles, and devices from other PC makers. 
 * Visitors will also be able to try devices like Microsoft’s HoloLens, 
 * alongside the company’s other Mixed Reality (VR) headsets that are available
 * 
 * old plan: Berlin, Hamburg, München, Köln
 * ----------------------------------------------------------------------------
 * Change Windows 10 Operation System at 21.05.2019 - Official -
 * to new OS-Build 18356.116 Final Release - March Update 2019, 
 * But note, Microsoft increment by Cleanup's the Revisionnumber,
 * at Time .145 25.05.2019 - Build 18362.145 -
 * ----------------------------------------------------------------------------
 * Tippo Tip:
 * At Time to Time the System Clock the system time after in seconds and 
 * milliseconds range, means the Local Time in a Country.
 * For Germany:
 * download the PTB - ATOM-Clock show Second/Millisecond on after?
 * click right side in taskbar on Date/Time,
 * open Windows Settings goes to Time and Language,
 * stand an Time Server for Time synchronization, click it.
 * Time Server for Windows: time.windows.com
 * ---------------------------------------------------------------------------- 
 * Microsoft SQL Server 2008 and SQL Server Server 2008 R2
 * will no longer be supported by Microsoft at Juli 2019.
 * ----------------------------------------------------------------------------
 * ----------------------------------------------------------------------------
 * ----------------------------------------------------------------------------
 * ! NEW ! Microsoft Windows 10 Edition Ultra Home which presumably offers up 
 * some extra perks without a full Pro upgrade.
 * ----------------------------------------------------------------------------
 * Dell announced its next XPS 13 2-in-1, and the big news is that it includes 
 * Intel's upcoming 10th-gen 'Ice Lake' processors.
 * It's particularly important because previously, the XPS 13 2-in-1 lineup 
 * used a Y-series processor, which was 5W in the last generation.
 * That means that there's a massive performance boost in the new model.
 * ----------------------------------------------------------------------------
 * Windows 10 Pro for Workstations will include the ReFS file system; 
 * persistent memory; faster file sharing using SMB Direct; 
 * and support for new hardware configurations, including server-grade 
 * Intel Xeon or AMD Opteron processors with up to four CPUs 
 * and "massive" memory, up to 6 terabytes. 
 * Today, Windows 10 is limited to two CPU and 2 TB configurations.
 *
 * Microsoft's original Windows 10 line-up included 
 * three embedded/Internet of Things (IoT) versions, 
 * plus six other Windows 10 editions: 
 * Home, Mobile, Pro, Enterprise, Education, Mobile Enterprise. 
 * 
 * Microsoft subsequently added Windows 10 S, 
 * which officials describe as a "mode" of Windows 10 Pro, to this list.
 * 
 * There are also two subscription versions of Windows 10 now, 
 * Windows 10 Enterprise E3 and E5.
 * 
 * ----------------------------------------------------------------------------
 * Intel:
 * Intel unveils 10th Gen Intel Core processors and Project Athena
 * And the company showed off its first-ever gaming processor 
 * with an all-core turbo of 5GHz.
 * 
 * The 10th Gen Intel Core chips are shipping now, 
 * but computers with the chips won’t be available until the holiday season.
 * 
 * The 10th Gen Intel Core Processors will bring high-performance 
 * artificial intelligence processing to scale with 
 * 
 * Intel Deep Learning Boost (Intel DL Boost), or 
 * special instructions aimed at streamlining AI processing.
 * 
 * The processors are built on the company’s 10-nanometer 
 * manufacturing process technology, new Sunny Cove core architecture, 
 * and its new Gen11 graphics engine.
 * 
 * 10th Gen Intel Core processors will range from Intel Core i3 to 
 * Intel Core i7, with up to four cores and eight threads,
 * up to 4.1GHz max turbo frequency, and up to 1.1GHz graphics frequency.
 * 
 * Intel is targeting the 10th Gen Intel Core processors at 
 * thin-and-light laptops and convertible 2-in-1s.
 * 
 * Intel DL Boost will deliver an estimated 2.5 
 * times improvement in AI performance for low-latency workloads.
 * 
 * Intel Iris Plus Graphics
 * The new graphics architecture delivers up to one teraflop of vector compute
 * for heavy duty inference workloads to enhance creativity, productivity,
 * and entertainment on highly mobile thin-and-light laptops.
 * 
 * For low-power AI usages on the PC, 
 * Intel Gaussian Network Accelerator (GNA) is built into the SoC.
 * 
 * Intel also said its Gen11 graphics architecture 
 * will be known as Intel Iris Plus graphics, 
 * which doubles performance compared to Gen9 graphics.
 * 
 * It also has 2 times HEVC encode and lets you watch 
 * 4K HDR in a billion colors.
 * And it will let gamers play thousands of titles in 1080p resolution.
 * 
 *-----------------------------------------------------------------------------
 * Intel Rapid Storage for Intel Processor as download Intel Download Center:
 * ----------------------------------------------------------------------------
 * see your Processor and download them, is better !
 * ----------------------------------------------------------------------------
 * Intel Microcodes input into Processor Chipset
 * Intel Tool Processor Diagnose all Information about System and Processor,
 * over the Link: HTML report about your Computer.
 *-----------------------------------------------------------------------------
 * RAID 0, 1, 5 and 10 - RAID 1 for Recovery
 * Intel® Rapid Storage-Technologie liefert erweiterte Verwaltungsfunktionen 
 * und detaillierte Statusinformationen für Serial-ATA-AHCI, 
 * PCIe-NVMe sowie RAID-Subsysteme. 
 * ----------------------------------------------------------------------------
 * INTEL Beschreibungen in deutsch:
 * Die Anwendung wird von den folgenden Betriebssystemen und 
 * Hardwarekomponenten unterstützt:
 * 
 * Unterstützte Betriebssysteme
 * ----------------------------------------------------------------------------
 * Microsoft Windows* 10 64-Bit-Edition
 * Microsoft Windows* Server 2016 64-Bit-Edition
 * 
 * Microsoft Windows* 7 32-Bit-Edition**
 * Microsoft Windows* 7 64-Bit-Edition**
 * 
 * Microsoft Windows* 8.1 32-Bit-Edition**
 * Microsoft Windows* 8.1 64-Bit-Edition**
 * 
 * Wird für die Intel® Prozessorreihe der siebten Generation nicht unterstützt.
 * Unterstützte Intel® Chipsets
 * -----------------------------------------------------------------------------
 * Lesen Sie sich die Readme-Datei durch, 
 * die mit der Software installiert wurde, 
 * oder besuchen Sie den Intel Online-Support, 
 * um mehr über die vollen Systemanforderungen und
 * die RAID-BIOS-Konfiguration zu erfahren.
 * -----------------------------------------------------------------------------
 * Intel® Chipsatz der 200er-Reihe, SATA-AHCI/RAID-Controller-Modelle
 * -----------------------------------------------------------------------------
 * E/A-ATA-AHCI/RAID-Controller der Plattform der Intel® Core 
 * Prozessorreihe der siebten Generation
 * -----------------------------------------------------------------------------
 * SATA-AHCI/RAID-Controller der Intel® Chipsatzreihe der 100er/C230er-Reihe
 * -----------------------------------------------------------------------------
 * E/A-SATA-AHCI/RAID-Controller der Plattform der 
 * Intel® Core Prozessorreihe der sechsten Generation
 * -----------------------------------------------------------------------------
 * Das Intel® Rapid Storage-Technologie-Softwarepaket enthält 
 * hochleistungsfähige PCIe-, SATA-, Caching- und 
 * RAID-Funktionen für geeignete Betriebssysteme.
 * -----------------------------------------------------------------------------
 * Lesen Sie die Systemanforderungen und die Readme-Datei, 
 * die mit der Software installiert wurde, bevor Sie Ihr System konfigurieren
 * und die Supportebene für die Funktionen einrichten. 
 * 
 * Sie können außerdem die Intel Support Website besuchen, 
 * um mehr über die vollständigen Systemanforderungen und 
 * die RAID BIOS Konfiguration zu erfahren. 
 * ------------------------------------------------------------------------------
 * (Optane/RAID)-fähige Systeme
 * ------------------------------------------------------------------------------
 * RAID (Redundant Array of Independent Drives) bezeichnet 
 * eine Reihe von unabhängigen Festplatten, 
 * die zu einem logischen Laufwerk zusammengefasst werden.
 * 
 * Der Hauptzweck dieser Technologie ist die 
 * Steigerung der Speichersystemleistung, der Datensicherheit und der erhöhten Fehlertoleranz.
 * 
 * Diese Technologie unterstützt die folgenden Funktionen:
 * Intel® Rapid Recover-Technologie
 * Diese Technologie liefert volle Datenredundanz, 
 * indem Daten vom festgelegten Quelllaufwerk 
 * (d. h. der Master-Festplatte) auf das festgelegte Ziellaufwerk
 * (d. h. die Wiederherstellungsfestplatte) kopiert werden. 
 * Datenaktualisierungen von Wiederherstellungs-Volumes 
 * können fortlaufend oder auf Anforderung erfolgen.
 * 
 * Systembeschleunigung mit Intel® Optane™ Technologie
 * Dank dieser Technologie können Computersysteme bei der Verwendung 
 * von PCIe-NVMe-Geräten mit Intel Optane-Technologie als Cache-Volume 
 * beschleunigt werden.
 * 
 * Wenn sie mit einer langsameren Festplatte mit hoher 
 * Kapazität kombiniert wird, profitiert der Nutzer von einem schnelleren System.
 * 
 * Die Leistung entspricht dabei fast der von PCIe-NVMe-SSDs 
 * unter Verwendung von sowohl Block- als auch Datei-Caching-Techniken. 
 * 
 * Intel® Smart Response-Technologie
 * Dank dieser Technologie können Computersysteme bei der Verwendung 
 * von SATA oder PCIe-SSDs als Cache beschleunigt werden.
 * 
 * Wenn sie mit einer langsameren Festplatte 
 * mit hoher Kapazität kombiniert wird, 
 * profitiert der Nutzer von einem schnelleren 
 * Systemspeicher mit hoher Kapazität.
 * Die Leistung entspricht dabei fast der von SSDs. 
 * 
 * Intel® Rapid RAID
 * -----------------
 * Diese Technologie gibt Ihnen Gelegenheit, 
 * RAID 0-, RAID 1-, RAID 5- und RAID 10-Volumes 
 * auf Desktop- und mobilen Plattformen zu erstellen.
 * 
 * Daten werden über zwei oder mehr Festplatten verteilt, 
 * um Datenredundanz zu bieten oder die Datenspeicherleistung zu steigern.
 * 
 * Intel® Matrix RAID Technology
 * -----------------------------
 * Diese Technologie ermöglicht die Erstellung 
 * zweier unabhängiger RAID-Volumes auf einem einzigen Array.
 * 
 * Das erste Volume beansprucht einen Teil des Arrays und 
 * lässt Platz für das zweite Volume.
 * 
 * Das Array kann je nach Volume-Typ zwischen zwei und sechs Festplatten enthalten.
 * 
 * Native Command Queuing (NCQ)
 * ----------------------------
 * NCQ ist eine Funktion, die es Festplatten ermöglicht, 
 * mehr als einen Befehl gleichzeitig entgegenzunehmen.
 * Sofern Sie diese Funktion mit einer oder 
 * mehreren Festplatten mit NCQ-Unterstützung verwenden, 
 * steigt die Speicherleistung in randomisierten Arbeitslasten, 
 * da die Festplatte in der Lage ist, die Befehlsreihenfolge intern zu optimieren.
 * 
 * Hotplug
 * -------
 * Diese Funktion, die auch "Hot-Swap" genannt wird, 
 * ermöglicht das Entfernen und Einfügen von Festplatten 
 * bei eingeschaltetem Computer und laufendem Betriebssystem.
 * 
 * Hotplugging wird beispielsweise beim Austausch einer ausgefallenen externen Festplatte verwendet.
 * 
 * Festplatten mit mehr als zwei Terabyte (2 TB)
 * Diese Funktion bietet Unterstützung für Festplattten und 
 * SSDs (Solid-State-Festplatten) mit einer Kapazität von mehr als 2 TB,
 * die als Pass-through-Geräte (verfügbar) angegeben oder 
 * in einer RAID-Konfiguration verwendet werden.
 * 
 * Energie- und Leistungseinstellungen
 * -----------------------------------
 * Mit diesen Funktionen können Sie die Energie- und 
 * Leistungseinstellungen des Systems an Ihre Anforderungen anpassen.
 * 
 * Link Power Management (LPM):
 * ----------------------------
 * Verwalten Sie den Stromverbrauch Ihrer SATA-Geräte 
 * während der Leerlaufzeit, wenn keine I/O-Aktivität vorliegt oder 
 * wenn Geräte fehlen oder nicht verwendet werden.
 * 
 * Mit den Einstellungen für den flüchtigen Volume-Cache 
 * können Sie für jedes RAID-Volume in Ihrem 
 * Speichersystem Cache-Richtlinien konfigurieren.
 * 
 * Schreibcachepuffer-Leerung: Konfigurieren Sie die 
 * Windows* Schreibcachepuffer-Leerung, um die Leistung zu erhöhen.
 * 
 * Cache-Modus:
 * ------------
 * Konfigurieren Sie einen Cache-Modus für flüchtiges 
 * Volume-Cache auf einem Array, 
 * um eine optimale Leistung zu erzielen.
 * 
 * Volume-Migration
 * ----------------
 * Diese Funktion unterstützt die Systemdatenkonvertierung 
 * in eine hochleistungsfähige oder 
 * datenschützende RAID-Konfiguration.
 * 
 * Volumegröße erhöhen
 * -------------------
 * Diese Funktion ermöglicht es Ihnen, 
 * die Datenspeicherkapazität eines Volumes zu erhöhen,
 * indem Sie 100% des verfügbaren Array-Speicherplatzes nutzen oder 
 * zum vorhandenen Volume eine oder mehr Festplatten hinzufügen.
 * 
 * Unsere Applikation unterstützt auch die folgenden Funktionen:
 * Kennwortgeschützte Festplatten
 * Diese Funktion bietet die höchste Datensicherheit und 
 * den besten Schutz für die Daten auf Ihren Festplatten 
 * durch Einsatz eines Kennworts, 
 * was unberechtigten Benutzern den Zugriff verweigert.
 * 
 * TRIM
 * ----
 * Diese Funktion unterstützt alle Pass-Through 
 * Solid-State-Festplatten (SSDs) in Ihrem Speichersystem, 
 * die die ATA-8 Protokollanforderungen erfüllen.
 * 
 * Ebenso werden SSDs in einem RAID 0-Array unterstützt.
 * Diese Funktion optimiert Schreibvorgänge, reduziert die Geräteabnutzung 
 * und belässt den verfügbaren Speicherplatz auf den Geräten so groß wie möglich.
 * 
 * ODD Leistungsoptimierung
 * ------------------------
 * Diese Funktion ermöglicht, dass ein unbenutztes optisches Laufwerk (ODD) 
 * automatisch ausgeschaltet wird, wenn sich im Laufwerk keine Medien wie eine CD, 
 * eine DVD oder ein Blu-Ray* Datenträger befinden und das Laufwerkfach geschlossen ist.
 * 
 * Das ODD kann wieder vom Betriebsystem, einer Interaktion vom Nutzer oder 
 * durch Drücken der Auswurf-Taste eingeschaltet werden.
 * 
 * ODD-Leistungsoptimierung ist besonders nützlich für mobile Computer, 
 * da die Akkulebensdauer negativ beeinträchigt wird, 
 * wenn ODD eingeschaltet und im Leerlaufzustand ist.
 * 
 * Diese Aktion steht nur mit folgender Systemkonfiguration zur Verfügung:
 * Intel® 6 Serie Chipset oder höher, kompatible Motherboards und kompatible ODDs. 
 * Weitere Informationen zu den Kompatibiliätsanforderungen 
 * finden Sie in den SATA-Spezifikationen unter   www.sata-io.org
 * 
 * Für Slotlaufwerke gilt die Laufwerkfachbedingung nicht.
 * 
 * PCIe-SSD-Unterstützung
 * ----------------------
 * Der RST-Treiber unterstützt den Anschluss von drei Single-Pass-Through-PCIe-SSDs, 
 * vorausgesetzt, alle folgenden Bedingungen treffen zu:
 * Die Plattform unterstützt die Intel Remapping-Technologie für PCIe-SSDs.
 * 
 * Das mit UEFi kompatible BIOS unterstützt die Intel Remapping-Technologie für PCIe SSDs.
 * Das System befindet sich im RAID-Modus, Intel RST-Modus oder 
 * 
 * Intel RST Premium-Modus 
 * -----------------------
 * (abhängig von der Plattform und dem Chipsatz des Modells).
 * 
 * Die angeschlossene PCIe SSD unterstützt die NVM Express 1.0- oder 
 * AHCI-Spezifikation für Host-Controller-Schnittstellen.
 * 
 * Die Erstellung von Cache-Volumes auf dem PCIe-SSD unter 
 * Verwendung der Intel® Smart Response-Technologie oder 
 * die Systembeschleunigung mit Intel® Optane Technologie wird unterstützt. 
 * 
 * AHCI-fähige Systeme
 * -------------------
 * AHCI (Advanced Host Controller Interface) 
 * ist eine Schnittstellenspezifikation, 
 * die es dem Speichertreiber automatisch ermöglicht, 
 * erweiterte SATA-Funktionen wie Native Command Queuing (NCQ) und 
 * Native Hot Plug auf den an Ihren Computer 
 * angeschlossenen Festplatten zu aktivieren. 
 * 
 * Die folgenden Funktionen werden von AHCI-fähigen Systemen unterstützt:
 * ----------------------------------------------------------------------------
 * Native Command Queuing (NCQ)
 * Hotplug
 * Festplatten mit mehr als zwei Terabyte (2 TB)
 * Energie- und Leistungseinstellungen
 * Kennwortgeschützte Festplatten
 * ODD Leistungsoptimierung
 * 
 * ----------------------------------------------------------------------------
 * Visual Studio 2019 Final Release 02.04.2019 - Project-Solution now!
 * (Version 16.0.3)
 * Lot of new ! Pass uff, he cancel all addins like x.vsix !, 
 * all 2017 or older not compatibel with 2019, make Error Message!.
 * (.vsix = visual studio extension) by Tools, Programming Languages,
 * Point extras is now only Installer.
 * Point Extension is only .vsix's over Visual Studio Marketplace:
 * here are FREE (without paid), FREE TRIAL (Testversion), PAID (Money)...
 * 
 * Have any Question to Windows/Visual Studio:
 * send me a mail!
 * In Summer ?! make MVP Windows 10 for Tippo!
 * 
 * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * !
 * ! SDK Blog make same Idea, more comments and samples (is commentout)
 * ! Windows 10 May Update OS-Build 18362 - 1903 - 19H1 -, 
 * !
 * ! have send blog Search Bar in Taskbar,
 * ! have set menuitem timeline show/zeitachse anzeigen, is double!.
 * ! create menuitems only documents, project-solutions, last work
 * ! Windows Sandbox make error, whats happen?
 * ! --------------------------------------------------------------------------
 * ! For all others:
 * ! --------------------------------------------------------------------------
 * ! Make sure actived the Microsoft Defender Firewall 
 * ! in Windows 10 Professional, is much better as before!
 * ! --------------------------------------------------------------------------
 * ! Make sure you are an Administrator or avantage User, one mistake at sets
 * ! in Firewall, and he can blocked everytime this.
 * ! Windows 10 Firewall for private network, domain network and public network
 * ! (Administrator set at install or later in Security Tool)
 * ! --------------------------------------------------------------------------
 * ! Windows 10 Firewall make optimal Security:
 * ! Firewall and Network Protection:
 * ! --------------------------------------------------------------------------
 * ! Domain
 * ! show active
 * ! Private
 * ! show active - Router like Gigacube or others
 * ! Public
 * ! show active
 * ! --------------------------------------------------------------------------
 * ! For Developer:
 * ! --------------------------------------------------------------------------
 * ! Kernel Integration Protection on/off,
 * ! but can set ONLY Administrator.
 * ! Is protect to injection bad code.
 * ! --------------------------------------------------------------------------
 * ! Data Protection
 * !
 * ! --------------------------------------------------------------------------
 * ! Ransom Protection
 * !
 * !
 * ! -------------------------------------------------------------------------- 
 * ! New! is AMSI.dll - 
 * ! Anti Malware Scan Interface for Windows 10 May Update 2019 -OS-Build 18362 
 * ! For Developer's: AMSI API. - amsi.h in SDK 18362
 * ! AmsiResultIsMalware
 * ! AmsiResultIsBlockedByAdmin
 * ! --------------------------------------------------------------------------
 * ! Info:
 * ! -----
 * ! Windows 10 Defender Anti Virus Scanner is now 
 * ! equavalent Commerical Anti Virus Scanners and 
 * ! have now an Anti Virus Malware Scanner,
 * ! and Anti Trojan Engine.
 * ! 
 * ! make sure! click update botton option Windows Update
 * ! every day Microsoft make update for new Defender Modules,
 * ! more and more bad Virus and Malware, Trojans.
 * ! 
 * ! Tippo download on CodeProject an .zip, directly answer from Windows Defender
 * ! part Anti Trojan Engine, Danger inside Trojan in .zip:
 * ! directly remove or quarantine the .zip file !.
 * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * !
 * ! Tippo Tip by new update set anytime over scan options full check all Files
 * ! and running app's on harddrive, but the check can run very long (hours)
 * !
 * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * ! 
 * ! Tippo Tip make from time to time, proof the random access memory RAM 
 * ! on Computer, Microsoft make tip, one part or more can broken,
 * ! system-tool on command line: mdsched.exe
 * ! bank 0, bank 1, bank 2, bank 3 are the parts of random access memory. 
 * ! But by 32BIT System only Bank 0 and Bank 1 for use, while more Adress
 * ! Processes can't use! - Standard RAM by 32BIT is 3.5 Gigabyte not more!
 * ! 64BIT to ultimo ! theoretically 16 Terabyte.
 * !
 * ! Windows 10 Professional Edition allowed by 
 * ! 2 Terabyte (RAM)random access memory.
 * ! Windows 10 Professional for Workstation Edition 4 Terabyte 4 Processors.
 * ! Windows 10 Professional Edition is a Workstation with Users and Groups,
 * ! Windows 10 is Multi User System now, one User or more on one Computer. 
 * ! Windows 10 make for each User an Account, Security ID,
 * ! On Screen LogOn any User insert User Photo.
 * !----------------------------------------------------------------------------
 * ! Network Libraries: 
 * ! (Windows 10 Professional as Clients, while is an Workstation)
 * ! ---------------------------------------------------------------------------
 * ! Windows Server - Windows 10 (for Access to Server) Client Library
 * ! but note!, you must have an Client Access License (CAL) for use them.
 * ! On Windows 10 Professional you can install the Windows Server
 * !
 * ! Windows Terminal Server public APIs - SDK 18362 - WTSAPI32.H
 * ! wlanapi.h
 * ! Definitions and data strcutures for wlan auto config client side API.
 * !
 * !
 * !
 * !
 * !
 * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
 * ----------------------------------------------------------------------------
 * Change for Assemblies the .suffixes as little save:
 * System-tool assoc.exe - association New FileSystem in Windows 10
 * .suffix=appname
 * .accdb=Access.Application.16 
 * is Microsoft Access Version 16 (Office365 64BIT)
 * see Microsoft have change .suffix from .mdb to .accdb (access database)
 * ----------------------------------------------------------------------------
 * Special!
 * Microsoft Free Suffixes: create your own .suffixes !. <Limit 255 chars:
 * appname.appinfotext
 * 
 * Microsoft Editor: save under- filetype- all files - 
 * coding - 
 * Ansi
 * UTF8
 * UTF8 with BOM - Binary Object Model
 * UTF16-LE - Low Endian
 * UTF16-BE - Big Endian
 * or better
 * UTF8 (For German developers == 'German Umlauts')
 * If not, come Message from System about German Umlauts,
 * Filetext in nirvana without German Umlauts.
 * 
 * Microsoft Editor Spell Checking in Germany use the German Dictionary File.
 * Bing Search directly
 * ----------------------------------------------------------------------------
 * Windows 10
 * system-tool: assoc.exe - association
 * .library=.dll
 * .vgfl=.dll
 * .system=.dll
 * ============================================================================
 * 
 * ============================================================================
 * Warning:
 * ============================================================================
 * This product is licensed to you pursuant to the terms of the 
 * VGF license agreement included with the original software, and is
 * protected by copyright law and international treaties.
 * 
 * Unauthorized reproduction or distribution may result in severe civil and 
 * criminal penalties, and 
 * will be prosecuted to the maximum extent possible under the law.
 * 
 * You cannot distribute a compiled version of 
 * this code without prior registration.
 * 
 * Please see the documentation supplied with 
 * the VGF Libraries for further details.
 * 
 * Authored by Copyright © 2019 by 
 * Visual Galaxy Framework Community Kernel Developer Team.
 * All rights reserved.
 * 
 * May be redistributed for free, but may not be sold without 
 * the author's explicit permission.
 * 
 * This software is Copyright © 2019 by VGF-Technologies at VGF-KernelTeam
 * You may only use this software if you are an 
 * authorized licensee of an VGF developer tools product.
 * 
 * This software is considered a Redistributable as defined under
 * the software license agreement that comes with the VGF Products
 * and is subject to that software license agreement.
 * 
 * ----------------------------------------------------------------------------
 * Microsoft make Restrictions of Export for following Countries:
 * ----------------------------------------------------------------------------
 * This software is subject to the U.S. Export Administration Regulations and 
 * other U.S.law, and may not be exported or re-exported to certain countries
 * (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or
 * to persons or entities prohibited from receiving U.S.exports
 * (including Denied Parties, Specially Designated Nationals,
 * and entities on the Bureau of Export Administration Entity List or
 * involved with missile technology or nuclear, chemical or biological weapons)
 * ----------------------------------------------------------------------------
 * © 1982 - 2018 Microsoft Corporation.All rights reserved.
 * ----------------------------------------------------------------------------
 * Same sourcecode by Microsoft, so we marked with Copyright !.
 * © 1982 - 2018 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
 * Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
 * ----------------------------------------------------------------------------
 * DON'T CHANGE OR DELETE ANYTHING IN SECTION !!!.
 * ----------------------------------------------------------------------------
 * VFGCore written by
 *                      Christian 🧑 "TIPPO" 🧑 Kurs
 *                      Nettweg 1
 *                      - G -  53498 Bad Breisig
 *                      Germany - Allemagne - Duitsland
 * ----------------------------------------------------------------------------
 * voice                02633 - 470736  
 * international phone  00-49-2633-470736
 * Skype
 * E-mail               kurschristian@gmail.de
 * Community Website    http://www.vgfc.org/community/tippo
 * 
 * -----------------------------------------------------------------------------
 * This software is supplied as is. 
 * 
 * Use it at your own  RISK !!!!.
 * 
 * Obviously I've tried to do the best job possible.
 * If you find any problem with it, let me know.
 * With any luck, Visual Galaxy Framework will make it obsolete anyway
 * ----------------------------------------------------------------------------
 * License:
 * ----------------------------------------------------------------------------
 * NO fee for NON-Commercial use our Community Website:
 * ----------------------------------------------------------------------------
 * 
 * http://www.vgfc.org/community/project/vgf/
 * 
 * ----------------------------------------------------------------------------
 * Honest Business Users, to use our compiled Versions, 
 * please call us to send you our Business Licenses.
 * or 
 * our Business Website:
 * www.vgf.com/business/vgf/License
 * 
 * 
 *############################################################################# 
 */

/*********************** Developer Disclaimer *********************************
 *
 * Copyright © 2019 by Christian 🧑'TIPPO'🧑 Kurs - Germany
 * 
 ******************************************************************************
 * English:
 *-----------------------------------------------------------------------------
 * 
 * 
 * Mariott Hotel Bonn - Restaurant KONRAD's Chief Alexander Stadler
 * https://www.youtube.com/watch?time_continue=6&v=tOl7eh2N5Ps&feature=emb_logo
 * 
 *****************************************************************************/




/* ######################### Visual.Galaxy.Framework ##########################
 * # Start Date: 2016/01/01 - 17:00 - Ground Leaning -Initial
 * #---------------------------------------------------------------------------
 * # Freeze Date:
 * # (FREEZE: like Microsoft - stopp develop, no more codes into project,
 * # - but develop goes on - compiling to R T M )
 * #---------------------------------------------------------------------------
 * # ! NOTE ! Develop are going on, new an features in later build.
 * #---------------------------------------------------------------------------
 * #
 * #
 * #
 * ############################################################################
 * ############################################################################
 * 
 * ############################################################################
 * 
 * DON'T CALL WINDOWS SYSTEM FUNCTIONS DIRECTLY WITH EXTENTION  - Ex -
 * 
 * ############################################################################
 * Windows Operation System call this permanent at Time !. 
 * ()
 * Please write Visual C# Wrapper as here !!!. (Indirect Call)
 * ############################################################################
 * 
 * ----------------------------------------------------------------------------
 * Windows Operation System - native Methods - 
 * ----------------------------------------------------------------------------
 * Windows 10 Major jump to 10, Microsoft Info: has problems with 9 as
 * major version, same install/setups programs has problems with them,
 * and see 9 as Windows 95.
 * ----------------------------------------------------------------------------
 * Same Windows API have new Flags and Functions for Windows 10: 
 * ----------------------------------------------------------------------------
 * 1. 	use the .NET Framework 4.6.2, 4.7, 4.7.1 or higher (de. to Win 10)
 * 2. 	use all NOT into .NET Framework as native Functions 
 *      in DLLImportAttribute - user32, kernel32, shell32, advapi32 and so..
 *      all this new System Dll's have more Functions.
 * ----------------------------------------------------------------------------
 * 
 * ! NOTE !:
 * 
 * ----------------------------------------------------------------------------
 * All marked Windows 10 functions, you can use ONLY on Windows 10 System !.
 * Set special #if directive for Platform - 32 BIT and 64 BIT -
 * x86 and x64 - Intel and AMD compatible(little different, but not relevant).
 * a.)  Visual Studio help us porting a 32 BIT Project to 64 BIT Project, 
 *      like a Assistant, going to Platform Option over new... 
 *      and show the Assist.
 *      Choice your Selecting new Platform 64 BIT, than 32 BIT Project......
 *      Take Solution, but your must pass on same specials for 64 BIT.
 * 
 * 
 * ----------------------------------------------------------------------------
 * 
 * ----------------------------------------------------------------------------
 * Set here Directives and namespaces (Project)
 * using System,
 * using namespacename,
 * at .NET Framework 4.6(4.6.1, 4.6.2)
 * using static - classes and Methods are written with static.
 * using static directivename.classname,
 * so you can use the Methods directly without instance !.
 * ----------------------------------------------------------------------------
 * using static System.Math,		// mathematic methods - pow(x,y),
 *                                  // power of 2 - 2^10
 *                                  // Visual C++ Runtime Library refactoring:
 *                                  // old 17 Digits on new 768 Digits.
 * ----------------------------------------------------------------------------
 * using static System.Console,	// console:
 *                              // methods, properties and one event
 * ----------------------------------------------------------------------------
 * 
 * ################ MICROSOFT INFO ############################################
//----------------------------------------------------------------------------
// <!-- Microsoft Portability, Globalization, Design automatic active! -------
// <!-- Microsoft.Interoperability -------------------------------------------
// <!-- Microsoft Portability ------------------------------------------------
// <!-------------------------------------------------------------------------
// <!-- For native unmanaged Methods, must be written in three Classes: ------
// <!-- Class NativeMethods-------- Stackwalk execute -----------------------
// <!-- NO! [SuppressUnmanagedCodeSecurityAttribute] ------------------------
// <!-------------------------------------------------------------------------
// <!-- Class SafeNativeMethods---- Stackwalk non execute
// <!-- with [SuppressUnmanagedCodeSecurityAttribute]
// <!--------- NO Security Check !, when set this Attribute, also ATTENTION!
// <!-- without  Full Security Check with Attribute
// <!-- NON! dangerous and Risk for User Calls.
// <!-----------------------------------------------------------------------------
// <!-- Class UnsafeNativeMethods-- Stackwalk non execute
// <!-- with [SuppressUnmanagedCodeSecurityAttribute]
// <!-- with Security-Risk, so  Full Security Check with Attribute.
// <!-----------------------------------------------------------------------------
// <!-- ! drag and drop from Files Microsoft Explorer into Project-Solution,
// <!-- so you can Documentation into Project-Solution, directly start the Document,
// <!-- click on Documentname, Office: Word, Excel, Powerpoint starts !.
// <!-- qualifized Filename must be less than 260 chars, and Pathname less as
// <!-- 248 Chars. -- Visual Studio make short prefix and suffix old 8.3,
// <!-- documments names Projec~1.doc whey?
// <!-----------------------------------------------------------------------------
// <!-- Make sure start migrate for any Application you create, next Years 
// <!-- Microsoft make great changes, Windows Operation System old API's removes
// <!-- more and more .NET !, at November 2020 one Platform for all.
// <!-- New Info more then 50000 .NET API's.
// <!-- .NET 5 is the Platform for Future. More source from Windows Operation
// <!-- System - parts Windows goes open source -
// <!--  use Visual C++.NET and Visual C# with Visual Studio next.
// <!-- parts unmanaged code (native) and managed code in Windows.
// <!--
//
//#################################################################################
*/

//-----------------------------------------------------------------------------
// System-Directives from .NET Framework
//-----------------------------------------------------------------------------

#region ### Standard System-Directives ###

/*-----------------------------------------------------------------------------
 * External Dependencies
 * ----------------------------------------------------------------------------
 * All System Directives Here ! - use new .NET Framework 4.8.03752 with
 * cumulative update.
 *-----------------------------------------------------------------------------
 * Guilty as Implemented System .NET Libraries
 *-----------------------------------------------------------------------------
 * .NET Framework comes with Windows Operation System automatic.
 * All classe can show members and comments with Key F12, 
 * marked classname and push F12
 *-----------------------------------------------------------------------------
*/

using System;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Security;
using System.Security.Principal;


#endregion

/*-----------------------------------------------------------------------------
* External Dependencies:
* Windows-Directives from .NET Framework
*------------------------------------------------------------------------------
*/

#region ### Standard Windows-Directives ###

/*-----------------------------------------------------------------------------
* All Windows Directives Here ! 
* All Windows Directives begins with Windows.namespace.class.winmd
* Directory:
* 
* C:\Windows\System32\WinMetadata\ all Windows Assemblies
* Windows.AI.winmd
* Windows.System.winmd
* ... more
* 
* 
* -----------------------------------------------------------------------------
* For Developer:
* -----------------------------------------------------------------------------
* all winmd are .NET Assemblies, open with Reference Manager.
* -----------------------------------------------------------------------------
* Windows Operation System Assemblies Directory:
* 
* 
* -----------------------------------------------------------------------------
* For Developer:
* all winmd are .NET Assemblies, open with Reference Manager.
*------------------------------------------------------------------------------
* 
*/

#endregion

//-----------------------------------------------------------------------------
// namespace from Project Visual Galaxy Framework,
// Directives/namespaces from Assemblies:
//-----------------------------------------------------------------------------
// NOTE! same Library's are protected with .(HIDDEN)
// For this Project Visual.Galaxy.Framework, 
// have be open with visible Attribute in they Library's.
//-----------------------------------------------------------------------------
// same in Develop ! not complete yet !:
// Visual.Operation.Library.dll, Visual.Security.dll, 
// Visual.Resource.Library.dll, Visual.Message.Library.dll,
// Visual.Form.Library.dll, Visual.Registry.Library.dll
// Visual.Exception.Engine.dll, Visual.Virtual.Engine.dll,
//-----------------------------------------------------------------------------

/*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*/

#region ### Foreign Directives - here from other Visual C# Files ###

/*-----------------------------------------------------------------------------
 * External Dependencies - but most written with FriendlyAttribute, 
 * so you can use internal classes.
 * Is not a Directive - Assembly, 
 * Is Only a namespace from a other 
 * Visual C# name.cs file in this Project-Solution.
 * -----------------------------------------------------------------------------
 * In New Visual Studio 2019 give Options:
 * 0 (checkbox) unused Directives remove, at Build run he delete all unused!
 * 0 (checkbox) unused variable remove
 * 0 (checkbox) change datatype to var (string) = "";
 * -----------------------------------------------------------------------------
 * more support by coding, online search bar
 * Yellow lamp on left side - Compiler 'under the HOOD' , 
 * precompile codeline to codeline, check syntax, semantic and more...
 * for better and faster backend compile!.
 * -----------------------------------------------------------------------------
 * use Operation System Functions
------------------------------------------------------------------------------*/
using static Visual.Operation.System.Native.NativeMethods;

// Visual C++ - Runtimes Library Functions - ! CharSet.Cdecl
using static Visual.Operation.System.Native.NativeRuntimeMethods;

/*--------------------------------------------------------------------------------
 * Project-Maintainer 'Tippo' change  the using Visual.Function.Library to 
 * Visual.Operation.System.Native.UnsafeNativeMethods,
 * thats all Wrapper Methods from VisualFunctionLibrary.dll written in C.
 * Run analysis have Proposal made unmanaged Code into Class UnsafeNativeMethods.
 *--------------------------------------------------------------------------------
 */
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// use Style for MessageBox
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

//  Utilities, means Methodcalls at Runtime for checks:
// Windows Operation System Versions, Memory, Storage, 
// Windows Membership, Accounts,


using static Visual.Operation.System.Internal.InternalOSMethods;

#endregion

#region ### set here only Project Files for use in this namespace ###

// all over Class Application
using static Visual.Galaxy.Framework.Application.VGFApplication;

// separte only URL's here in Class.
using static Visual.Galaxy.Framework.Core.VGFCoreUrls;

#endregion


/*-----------------------------------------------------------------------------
* Visual.Galaxy.Framework
* Application Framework for great Applications
*-----------------------------------------------------------------------------
* Core:
* make global constants in class head for all other Files in Project-Solution.
* make global instancevariables.
*
* -----------------------------------------------------------------------------
* Visual Studio 2019 - Visual C# 8.0 - .NET Framework 4.8.03752 - NEW's:
* Windows 10 May Update 2019 - OS-Build 18362 is fix, but comes Revisions:
* at Time Revision .86 after cleanups/Bugfixes to end of May - Final -
* some new operator's, patterns, switch pattern,
* so I' pass on some Methods...
* -----------------------------------------------------------------------------
* Have a space in codeline/comment, Visual Studio delete automatic in realtime.
* Yellow Lamp on left side is the Compiler most show by Errors.
* run 'under the Hood', no Error in Codeline, he precompile the line, 
* foreward compilation is a better backend compile.
* Live Share is realtime implementation.
* Visual Studio 2019 to GitHub Projectside in Team Explorer Connected,
* at buttom right side <Projectname click open the Windows Team Explorer
* Bell sign at buttom right side is the new Messenger for updates and more...
* if a new on MS Server the Bell change the color on green, no is gray.
* Last Update was Visual Studio 2019 Version 16.0.3 Revision update 3
*-----------------------------------------------------------------------------/


/*-----------------------------------------------------------------------------
 * NAME_SPACE_BEGIN::Visual.Galaxy.Framework.Core
 *-----------------------------------------------------------------------------
 * Use Windows Emoji's in Comment-Blocks, short comments... 
 * Emoji's in the Screen-Keyboard like me 🧑TIPPO🧑 as Developer Face
 * look below under class VGFCore.
 *-----------------------------------------------------------------------------
 * Members:
 * Class-Head:
 * Constants, Varaibles, Instances, short cut names with Lambda Operator =,
 * 
 * Class FrameworkException
 *----------------------------------------------------------------------------- 
*/
namespace Visual.Galaxy.Framework.Core
{


    /*
    #DEFINE MB_ICONSTOP             16      && Critical message
    #DEFINE MB_ICONQUESTION         32      && Warning query
    #DEFINE MB_ICONEXCLAMATION      48      && Warning message
    #DEFINE MB_ICONINFORMATION      64      && Information message

    #DEFINE MB_APPLMODAL            0       && Application modal message box
    #DEFINE MB_DEFBUTTON1           0       && First button is default
    #DEFINE MB_DEFBUTTON2           256     && Second button is default
    #DEFINE MB_DEFBUTTON3           512     && Third button is default
    #DEFINE MB_SYSTEMMODAL          4096    && System Modal

    MsgBox return values
    #DEFINE IDOK            1       && OK button pressed
    #DEFINE IDCANCEL        2       && Cancel button pressed
    #DEFINE IDABORT         3       && Abort button pressed
    #DEFINE IDRETRY         4       && Retry button pressed
    #DEFINE IDIGNORE        5       && Ignore button pressed
    #DEFINE IDYES           6       && Yes button pressed
    #DEFINE IDNO            7       && No button pressed

    
    Data-handling subset from FOXPRO.H
 
    Cursor buffering modes
    #DEFINE DB_BUFOFF               1
    #DEFINE DB_BUFLOCKRECORD        2
    #DEFINE DB_BUFOPTRECORD         3        
    #DEFINE DB_BUFLOCKTABLE         4
    #DEFINE DB_BUFOPTTABLE          5

    Update types for views/cursors
    #DEFINE DB_UPDATE               1
    #DEFINE DB_DELETEINSERT         2

    WHERE clause types for views/cursors
    #DEFINE DB_KEY                  1
    #DEFINE DB_KEYANDUPDATABLE      2
    #DEFINE DB_KEYANDMODIFIED       3
    #DEFINE DB_KEYANDTIMESTAMP      4

    Remote connection login prompt options
    #DEFINE DB_PROMPTCOMPLETE       1
    #DEFINE DB_PROMPTALWAYS         2
    #DEFINE DB_PROMPTNEVER          3

    Remote transaction modes
    #DEFINE DB_TRANSAUTO            1
    #DEFINE DB_TRANSMANUAL          2

    Source Types for CursorGetProp()
    #DEFINE DB_SRCLOCALVIEW         1
    #DEFINE DB_SRCREMOTEVIEW        2
    #DEFINE DB_SRCTABLE             3


    #DEFINE WINDOWTYPE_MODELESS   0
    #DEFINE WINDOWTYPE_MODAL      1
    #DEFINE WINDOWTYPE_READ       2
    #DEFINE WINDOWTYPE_READMODAL  3


    begin declare section ('Application')
    {



    }


    begin declare section ('Framework')
    {
        if(47)
        {

        }
        // Windows 10 Fall Creators Update 2017
        elif(471) 
        {

        }
        // Windows 10 Spring/April Creators Update 2018
        elif(472)
        {

        }
        // Windows 10 October Update 2018
        elif(473)
        {

        }
        // Windows 10 May Update 2019
        elif(474)
        {
        
        }
        // Windows 10 October Update 2019
        elif(475)
        {
        
        }
        // Windows 10 March/Spring Update 2020
        elif(476)
        {
        
        }
        // Windows 10 September/October Update 2020
        elif(477)
        {
        
        }

    }


    begin declare section ('Network')
    {



    }

    begin declare section ('Server')
    {



    }

    begin declare section ('Computer')
    {



    }

    begin declare section ('Operation System')
    {
        if(15700) // Windows 10 Creators Update 2017
        {

        }
        elif(16299) // Windows 10 Fall Creators Update 2017
        {

        }
        elif(17134) // Windows 10 Spring/April Creators Update 2018
        {

        }
        elif(17763) // Windows 10 October Update 2018
        {

        }
        elif(18862) // Windows 10 May Update 2019
        {

        }
        elif(18000) // Windows 10 October Update 2019
        {

        }
        elif(19000) // Windows 10 May Update 2020
        {

        }
        elif(19000) // Windows 10 October Update 2020
        {

        }
        elif(20000) // Windows 10 March Update 2021
        {

        }
        elif(20000) // Windows 10 October Update 2021
        {

        }


    }

    begin declare section ('Processor')
    {



    }



    */







    /* first Alternate:
     * 
     * set NamespaceBundle with Namespace inside for use in this Project.
     * using NamespaceBundle.StartUp3;
     * 
     * using have avantage to namespace, so you must write the NamespaceBundle here
     * NamespaceBundle miscellous namespaces
     * 
     * namespace Namespace_Bundle_name
     * {
     * 
     *      - namespace 1
     *      namespace StartUp1 { };
     *      - namespace 2
     *      namespace StartUp2 { };
     *      - namespace 3
     *      namespace StartUp3 { };
     *      
     * };
     * 
     */

    /* 
     * Program Code returns by end
     * 
     * standard:
     * static void main(string[] args) {...}
     * change to: (in Visual C# allowed)
     * static int main(string[] args) {...}
     * 0 - Program end successfully
     * 1 - Program end with failure
     * (Use Windows Debugger, start app.exe show you all dependencies by call
     * by end, Windows automatic call TerminatProcess()...)
     * uncheck by Tipplin
     * 2 - File not found
     * 3 - Search way not found
     * 4 - to many files open
     * 5 - Fileacess denied
     * 6 - Handle not defined
     * 12 - no guilty access code
     * 63 - Programm Description
     * 80 - File is exist
     * 255 - unknown Error
     * 
     * Help via Errorlevel.bat
     * 
     * Wenn ein Programm in Windows ausgeführt wird, wird jeder Wert, 
     * der von der Funktion Main zurückgegeben wurde, in einer Umgebungsvariable gespeichert.
     * 
     * Diese Umgebungsvariable kann abgerufen werden, 
     * indem ERRORLEVEL aus einer Batchdatei oder $LastExitCode aus PowerShell verwendet wird.
     * 
     * When a program runs in Windows, any value returned by the Main function 
     * is stored in an environment variable.This environment variable can be obtained by 
     * using ERRORLEVEL from a batch file or $ LastExitCode from PowerShell.
     */

    



    /// <summary>
    /// Class VGFCore for all Basics
    /// </summary>
    /// <!-- Author TIPPO 🧑 -->
    /// If class static declare, sealed not allowed!
    /// <!-- Author TIPPO 🧑 -->
    /// <remarks>
    /// Globals for the Project-Solution for all others Files.
    /// Bind In, thats all!
    /// using static Visual.Galaxy.Framework.Core.VGFCore;
    /// </remarks>
    /// [ClassVersion( "1.0" ), Association, Abstract, Description("Association between basics like .NET global in VGFCore")]
    internal static class VGFCore
    {
        // /** in Visual C# not allowed ! more then two asterics like /***


        // Insert EMOJI's in your Code bzw. Commentblock  🖥 here all emoji's uni color, in Office in Multi Color


        /* insert emoji's with Screen - Tastatur 👩‍🦰 - 💥💫💘💓 right mouse click on taskbar, window Screemtastatur show, right on Taskbar show the sign, click it!
         * emoji's show with click smile face, choice an emoji and click it then he insert in document or here in commentblock. 😜
         */

        /*** <!-- ⚠ **WARNING** --
        */

        /*** <!-- 👉 **NOTE** --
         */

        /*** <!-- ❌ **Crictical** --
         */

        /*** <!-- ❗ **ATTENTION** --
         */

        /*** <!-- ❔ **QUESTION** --
         */

        /*** <!-- 👁‍🗨 **FOR YOUR EYES ONLY ! --


        /*** 🚩🏴‍☠️☢🔚🗽🛠🔧⚔👀
         * 
         * chat symbols like  :)  :(  =)
         * 
         */


        // Developer Info 🧑 Performs one-time initialization 🧑


           


        /* 
         * 🧑 TIPPO-Tip: 👌 🧑 🏴
         * emoji only one colour 🧑❗, in Visual Studio Code in colors❗
         * 
         * Globals at Class-Head:
         * Class Instances fro other Classes in Project-Solution
         * Instance on Stack or Heap with new Operator.
         * Stack:
         * Struct instance
         * static Structname instancevariable;
         * Heap
         * static VGFAssemblyInfo vai = new VGFAssemblyInfo();
         * 
         * New Visual Studio Feature is intellisense window with little box
         * StringBuilder
         * sb.Capacity
         * go with mousemove at point and psuh F12 make open class StringBuilder source
         * 
         */
        #region ### Instances, instance for structs, global variables here ###

        /*---------------------------------------------------------------------
         * Developer Tipplin found by Microsoft:
         * arts of Buffers, like C++ Buffers
         * secured string,
         * --------------------------------------------------------------------
         * Class SecureString
         * For TAN, Password, PIN, LogIn Screen.
         * SecureString encrypt directly by input string with EEC, AES
         * Microsoft Cryptography API in .NET Framework.
         * If crypt, any person change device harddrive 
         * the String remains crypt. 
         * Crypted string hold in Memory only in microseconds, 
         * can't be readable, have inside an Interface IDisposable, 
         * the string is not moved to memory, most make the GC.
         * GC = Garbage Collector.
         * --------------------------------------------------------------------
         * Test String and StringBuilder following results:
         * --------------------------------------------------------------------
         * String are no changes, by any change in Memory an new object create.
         * String written with Loop code and Text by 50000 changes so any time 
         * string must allocate 50000 objects everytime new.
         * Test run by this little code 400 ms.
         * --------------------------------------------------------------------
         * StringBuilder is faster, high Performance, flexable, dynamic.
         * StringBuilder are dynamic Objects and 
         * can be change without allocation in Memory.
         * Test StringBuilder same Loop code and Text,
         * Test run by this little code 1 ms.
         * --------------------------------------------------------------------
         * StringBuilder have own Cache , StringBuilderCache.
         * Everytime set MaxCapacity, is better!, no cuts, no OutRangeException
         * make message to User, the text or any other is too long!.
         * By StringBuilder is the highest Value integer value 2147483647,
         * but set maximal value 2147483647 with minus -1, no out of range.
         * <code
         *   StringBuilder sb = new StringBuilder(255, 2147483646);
         *   if Text or other higher as 255 he expand to 
         *   highest Value automatic.
         * NOTE: 
         *   Text or other by maximal value here 2048 higher he cut's.
         *   StringBuilder sb = new StringBuilder(255, 2048);
         * </code
         * --------------------------------------------------------------------
         * In intellisense window not show
         * 
         * <code</code
         * 
         * developer info, description
         * <dev</dev
         * 
         * 
         * --------------------------------------------------------------------
         * <code
         * StringBuilder bu = new StringBuilder("Friday");
         * 
         * // index begins with 0 (here is F) - index 3 == d
         * char c = bu[3];
         * 
         * // return result = d
         * return c;
         * 
         * </code
         * --------------------------------------------------------------------
         * Developer want show you an sample code, can set in Comment Block
         * like this:
         * XML Comment Block
         * <code
         * 
         * </code
         *---------------------------------------------------------------------
         * The best for C/C++ Buffers:
         * var stringBuilder = new StringBuilder(260);
         * if (Win32Native.GetSystemDirectory(stringBuilder, 260) == 0)
         * {
         * 
         * }
         * 
         * string text = stringBuilder.ToString();
         * return text;
         *---------------------------------------------------------------------
         * The best for C/C++ Buffers:
         * var stringBuilder = new StringBuilder(256);
         * int bufferSize = 256;
         * 
         * -----------------------------------------------sizeof bufferSize
         * if (Win32Native.GetComputerName(stringBuilder, ref bufferSize) == 0)
         * {
         * 
         * }
         * 
         * return stringBuilder.ToString();
         * 
         *----------------------------------------------------------------------
         * 
         * public static string StackTrace
         * {
         *      get
         *      {
         *          new EnvironmentPermission(PermissionState.Unrestricted).Demand();
         *          return GetStackTrace(null, needFileInfo: true);
         *      }
         * }
         * 
         *  static string GetStackTrace(Exception e, bool needFileInfo)
         * {
         *      // Class Stacktrace from System.Diagnostics
         *      StackTrace stackTrace = (e != null) ? new StackTrace(e, needFileInfo) : new StackTrace(needFileInfo);
         *      return stackTrace.ToString(System.Diagnostics.StackTrace.TraceFormat.Normal);
         * }
         * 
         * --------------------------------------------------------------------
         * write own Debugger
         * System.Diagnostics.Debugger
         * 
         * --------------------------------------------------------------------
         * Visual Studio 2019 Version 16.5.0 and Visual C# 8.0 and 
         * .NET Framework 4.8.03752 (cumulative update with 18362.113)
         * 
         * --------------------------------------------------------------------
         * datatype block string, bool, int, long
         * string
         * string
         * string
         * string
         * marked string block and make it simple goto 
         * all removes with var < = "";
         * the compile see what datatype you mean.
         * 
         * --------------------------------------------------------------------
         * New in Visual C# 8.0
         * Enumerator with 1 char allowed - string laster version - 
         * Typescript with string
         * 
         * enum
         * {
         *      euro = '€',
         *      dollar = '$'
         * 
         * }
         * 
         *  string EURO = Currencies.euro.ToString();
         * 
         * --------------------------------------------------------------------
         */

        /// <summary>
        /// some constants, but only one define internal const string,
        /// the last one everytime with end semicolon ;
        /// </summary>
        internal const string SETTINGS_STORE_NAME = "vscode-edge-devtools",
                              SETTINGS_DEFAULT_USE_HTTPS = "",
                              SETTINGS_DEFAULT_HOSTNAME = "localhost",
                              SETTINGS_DEFAULT_PORT = "",
                              SETTINGS_DEFAULT_URL = "about:blank",
                              SETTINGS_WEBVIEW_NAME = "Elements",
                              SETTINGS_PREF_NAME = "devtools-preferences",
                              SETTINGS_PREF_DEFAULTS = "";

        /// <summary>
        /// Constant String for start Webbrowser Microsoft Edge directly,
        /// Microsoft-Edge official start the Webbrowser Edge:
        /// Microsoft-Edge:websitename
        /// by start with Process.Start(MSEdge, website);
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// NOTE: direct call is different to Internet Explorer,
        /// or under console the command start:
        /// start is an new console window, without start an new Window while
        /// start Website directly:
        /// start microsoft-edge:http://www.microsoft.com
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// In Windows 10 Build 10000, Microsoft Edge Web Browser 
        /// with Chrominum Engine have new place in Directory:
        /// C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
        /// direct call msedge at search or console with start msedge or
        /// go into dir click on msedge.exe.
        /// </remarks>
        internal static string MSEdge = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";


        /// <summary>
        /// Individual StringBuilderBufferSize 
        /// always have a maximum size of Chararcters.
        /// Make sure, that the String is not higher/longer as the StringBufferSize is !.
        /// StringBuffers have an strong Value, not variable or maximum Capacity.
        /// </summary>
        /// <!-- 🧑 Author Tipplin 🧑 -->
        /// SizeCharSize is the static chars for an Buffersize:
        /// SizeChar1024 are 1024 chars in maxium StringBuilder and so...
        /// maximum chars is integer value: 2.147.483.647
        /// StandardBuilder sb = new 
        /// StringBuilder(StringBuilderBufferSize.SizeChar255, 
        /// StringBuilderBufferSize.SizeChar1024);
        /// sb.Capacity - StringBuilder automatic to highest value, 
        /// if the string is higher as 255 chars.
        /// -------------------------------------------------------------------
        /// StringBuilder standard is 16 chars internal set.
        /// StringBuilder sb = new StringBuilder();
        /// -------------------------------------------------------------------
        /// <!-- 🧑 Author Tipplin 🧑-->
        /// <remarks>
        /// Use only StringBuilder is 3000x faster as string,
        ///  own CACHE.
        /// Use for: Buffers, Sorted Methods, I/O Operations...
        /// </remarks>
        public enum VGFStringBuilderBufferSize
        {


            /// <summary>
            /// Buffersize 255 chars for StringBuider
            /// </summary>
            SizeChar255 = 0x200,

            /// <summary>
            /// Buffersize 1024 chars for StringBuider
            /// </summary>
            SizeChar1024 = 0x400,
            /// <summary>
            /// Buffersize 2048 chars for StringBuider
            /// </summary>
            SizeChar2048 = 0x800,
            /// <summary>
            /// Buffersize 4096 chars for StringBuider
            /// </summary>
            SizeChar4096 = 0x1000,
            /// <summary>
            /// Buffersize 8192 chars for StringBuider
            /// </summary>
            SizeChar8192 = 0x2000,
            /// <summary>
            /// Buffersize 16384 chars for StringBuider
            /// </summary>
            SizeChar16384 = 0x4000,
            /// <summary>
            /// Buffersize 32767 chars for StringBuider
            /// </summary>
            SizeChar32767 = 0x6000,
            /// <summary>
            /// Buffersize 65535 chars for StringBuider
            /// </summary>
            SizeChar65535 = 0x8000
        }

        /// <summary>
        /// Use the BufferBaseSize for Buffers - standard always 255 -
        /// </summary>
        /// <!-- 🧑 Author Tippo 🧑 -->
        /// can use for all Buffers you need.
        /// <!-- 🧑 Author Tippo 🧑 -->
        /// <remarks>
        /// Use inside StringBuilder with baseValue, 
        /// is the better way for Buffers and C++ Buffers.
        /// StringBuilder have own Cache and 3000x faster as string.
        /// </remarks>
        /// <Return>
        /// return Value = 255
        /// </Return>
        public static int VGFBufferBaseSize
        {
            get
            {
                    int BaseValue = 255;
                    var sb = new StringBuilder(BaseValue);

                    return sb.Capacity;  
            }
        }

        /// <summary>
        /// Use the BufferBaseSizeMax for Buffers - maxium 65535
        /// </summary>
        /// <!-- Author Tippo -->
        /// can use for all Buffers you need.
        /// <!-- Author Tippo -->
        /// <remarks>
        /// Use inside StringBuilder with baseValue, 
        /// is the better way for Buffers and C++ Buffers.
        /// StringBuilder have own Cache and 3000x faster as string.
        /// </remarks>
        /// <Return>
        /// return Value = 65535
        /// </Return> 
        public static int VGFBufferBaseSizeMax
        {
            get
            {
                int BaseValueMax = 65535;
                var sb = new StringBuilder(BaseValueMax);
                return sb.Capacity;
            }
        }

        /// <summary>
        /// Set capacity for Buffers, like C++ here with 255 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// But is the given buffer capacity greather as 255, StringBuilder he cut him!
        /// <!-- Author Tipplin -->
        internal static int capacity = 255;
        /// <summary>
        /// Class StringBuilder are 3000x faster as string.
        ///  StringBuilderCache
        /// </summary>
        /// <remarks>
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access. 
        /// </remarks>
        public static StringBuilder sbb = new StringBuilder(capacity);


        /*
        * -----------------------------------------------------------------------------
        * -----------------------------------------------------------------------------
        * Set instance for StringBuilder with instancevariable sb,
        * so is global in this File.
        * -----------------------------------------------------------------------------
        * -----------------------------------------------------------------------------
        * StringBuilder(string, Int32)
        * add string/chars
        * -----------------------------------------------------------------------------
        * Buffer:
        * int capacity = 255;
        * StringBuilder sb = new StringBuilder(capacity);
        * -----------------------------------------------------------------------------
        * -----------------------------------------------------------------------------
        * string initialString = "Initial String";
        * StringBuilder sb = new StringBuilder(initialString);
        * 
        * -----------------------------------------------------------------------------
        * -----------------------------------------------------------------------------
        * The following example demonstrates how to call the StringBuilder 
        * constructor with a specified capacity and maximum capacity.
        * 
        * int capacity = 255;
        * int maxCapacity = 1024;
        * StringBuilder stringBuilder = new StringBuilder(capacity, maxCapacity);
        * ------------------------------------------------------------------------------
        * ------------------------------------------------------------------------------
        * public StringBuilder(string value, int startIndex, int length, int capacity);
        * ------------------------------------------------------------------------------
        * Parameter
        * Wert
        * ------------------------------------------------------------------------------
        * String:
        * Die Zeichenfolge, die die Teilzeichenfolge enthält, die zum Initialisieren des 
        * Werts dieser Instanz verwendet wird.Wenn valueist nullder neue 
        * String wird die leere Zeichenkette enthalten (das heißt, es enthält Leer).
        * String sind unveränderlichm das bei jeder Ändernung im Speicher ein neues
        * Objekt angelegt wird. Unabhängig davon, ob sich die Länge der Zeichenkette 
        * ändert.
        * ------------------------------------------------------------------------------
        * Test Schleife String 50000 durchläufe Änderungen an einer Zeichenkette,
        * gleich immer neue Objekte erzeugt.
        * Durchlaufzeit: 400 ms.
        * 
        * StringBuilder:
        * Einsatz gleiche Schleife, gleicher Text. Objekte sind hier dynamisch, können
        * verändert werden, ohne dass allokieren von Speicher erforderlich ist.
        * Durchlaufzeit: 1 ms.
        * Anmerkung StringBuilder hat eigenen Cache - StringBuilderCache
        * ------------------------------------------------------------------------------
        * StringBuilder vorher Kapazitäten festlegen !:
        * MaxCapacity = <value; // höchste ist integer wert -1, 
        * so läuft man nicht gefahr OutRangeException, mit Prüfung.
        * 
        * ------------------------------------------------------------------------------
        * Startindex - Int32
        * Die Position, valuean der der Teilstring beginnt.
        * Länge - Int32
        * Die Anzahl der Zeichen in der Teilzeichenfolge.
        * 
        * Kapazität - Int32
        * Die empfohlene Startgröße des StringBuilder.
        * 
        * Ausnahmen
        * ArgumentOutOfRangeException
        * capacity ist kleiner als null.
        * -oder-
        * startIndexPlus lengthist keine Position innerhalb value.
        * Der capacityParameter definiert die maximale Anzahl von Zeichen, 
        * die in dem von der aktuellen Instanz zugewiesenen Speicher gespeichert werden können. 
        * Sein Wert wird der Capacity- Eigenschaft zugewiesen.
        * Wenn die Anzahl der Zeichen, die in der aktuellen Instanz gespeichert werden sollen, 
        * diesen capacityWert überschreitet , 
        * weist das StringBuilder- Objekt zusätzlichen Speicher zum Speichern zu.
        * Wenn capacityes Null ist, wird die implementierungsspezifische Standardkapazität verwendet.        
        */


        /*
         * See section StringBuilder with different maximum values. 
         * Sets instances here in ClassHead, thats allowed in Visual C#
         * Allowed: enumerators, struct's, instances, constants, file paths,
         * 
         */


        /// <summary>
        /// StringBuilder expanded
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// String are slower as StringBuilder is very fast.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// StringBuilder(minimum integer, maximum integer);
        /// he expand automatic to highest capacity !.
        /// -------------------------------------------------------------------
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access.
        /// -------------------------------------------------------------------
        /// </remarks>
        public static StringBuilder sb = new StringBuilder(255, 4096);

        /// <summary>
        /// Global in Project-Solution.
        /// StringBuilder here as expanded, minimum 255 chars and maximum 2048 chars,
        /// if minimum string is greather than 255, he expand to maximum automatic.
        /// So we have save, that he NOT cut the string after 255 chars.
        /// Standard StringBuilder set  16 chars without use expand.
        /// StringBuilder(min integer, max integer);
        /// StringBuilder is 2000x faster as string by sorted routines.
        /// Sorted Routines in System Directive: 
        /// System.Collections.Generic
        /// Class Stack
        /// Quicksort, Bubblesort...
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// For no  conflicts, I have set other instancevariables!.
        /// If conflict the compiler make message, before at left side yellow lamp.
        /// Visual C# Compiler runs "under the Hood", check syntax and semantics, make helps!
        /// if codeline ok!, he precompile the codeline directly, faster backend compile!.
        /// If search infos about Keywords and others, push F1 - goes Online to Website.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access.
        /// while this set in Class-Head, so Global for all Classes and Methods...
        /// </remarks>
        public static StringBuilder sbr = new StringBuilder(255, 2048);

        /// <summary>
        /// Set StringBuilder with Expand, minimum 255 chars and maximum 1024 chars.
        /// if string greather than 255 chars, he automatic expand to maximum!.
        /// </summary>
        public static StringBuilder volname = new StringBuilder(255, 1024);

        /// <summary>
        /// Instancevariable fsname for native Operation System Function: GetVolumeInformation();
        /// 
        /// </summary>
        public static StringBuilder fsname = new StringBuilder(255, 1024);

        /// <summary>
        /// Instancevariable vgfai for Visual Galaxy Framework Assembly Info
        /// </summary>
        internal static VGFAssemblyInfo vgfai = new VGFAssemblyInfo();


        /// <summary>
        /// Class VOSAssemblyInfo from Visual.Operation.System.dll
        /// </summary>
        internal static VOSAssemblyInfo vos = new VOSAssemblyInfo();

        /// <summary>
        /// Class VSLAssemblyInfo from Visual.Security.Library.dll
        /// </summary>
        internal static VSLAssemblyInfo vsl = new VSLAssemblyInfo();



        /*
         * © Author Christian 🧑 Tippo 🧑 Kurs
         * 
         * Tipplin 🐻 👌Special Constants here  👌
         * 
         * 
         */




        /*---------------------------------------------------------------------
         * Class Uri from .NET Framework as instance 🧑
         * System.dll - namespace System.Uri
         * --------------------------------------------------------------------
         * public static Uri wuri = new Uri("<webadressname");
         * 
         * 
         *--------------------------------------------------------------------- 
         */

        #endregion

        #region ### Logging - Log-Files Constants - ###

        /// <summary>
        /// Constant string with Pathname and Folder for all Trace Log Files
        /// </summary>
        /// <!-- Author Tipplin -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// / forward slash, see Javascript, HTML, - by Audiocontrol, Videocontrol (Website) as directory who is the Audiofile and Videofile.
        /// <!-- Author Tipplin -->
        internal static string TraceFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\IFTTraceFiles";

        /// <summary>
        /// Constant string with Pathname and Folder for all Console Log Files
        /// </summary>
        /// <!-- Author Tipplin -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// <!-- Author Tipplin -->
        internal static string ConsoleFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\ConsoleFiles";

        /// <summary>
        /// Constant string with Pathname and Folder for all System Log Files
        /// </summary>
        /// <!-- Author Tipplin -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// <!-- Author Tipplin -->
        internal static string SystemFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.FrameworkC:\SystemFiles";

        /// <summary>
        /// Constant string with Pathname and Folder for all Framework Log Files
        /// </summary>
        /// <!-- Author Tipplin -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// <!-- Author Tipplin --> 
        internal static string FrameworkFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.FrameworkC:\FrameworkFiles";

        /// <summary>
        /// For internal Visual Galaxy Framework Log File path
        /// </summary>
        internal static string FrameworkLogFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.FrameworkC:\FrameworkLogFiles";

        /// <summary>
        /// Current Versionnumber of Visual Galaxy Framework
        /// </summary>
        internal static string VGFrameworkVersion = vgfai.VGFVersion.ToString();

        #endregion


        /*------------------- CLASS HEAD INFO ----------------------------------------------------
         * See class-instances with instance variable in Class Head, this is allowed in Visual C#,
         * make a global effect for all classes and Methods in Project-Solution and our C# Files.
         * using static VGF.Core.VGFCore;
         *----------------------------------------------------------------------------------------
         * For All Classes own or .NET, want show all Members and 
         * info marked classname and push F12
         *---------------------------------------------------------------------------------------- 
         */
        #region ### Global Class Instances - own and .NET FX ###



        /// <summary>
        /// .NET Class Process, starts Application with Process.Start(appname) and more
        /// </summary>
        internal static Process process = new Process();



        /// <summary>
        /// Global in Project-Solution  🚧
        /// Class VGFAssemblyInfo Instance with instancevariable vai, 
        /// so can use in Methods the static properties from Class VGFAssemblyInfo, 
        /// this Class VGFAssemblyInfo is NOT normally in AssemblyInfo.cs
        /// All Properties are all Information about the Assembly.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// Make different names for Class AssemblyInfo, if not the compiler make error message,
        /// set first letter the short Assemblyname:
        /// VGF = Visual Galaxy Framework   = VGFAssemblyInfo
        /// VSL = Visual Security Library   = VSLAssemblyInfo
        /// VEE = Visual Exception Engine   = VEEAssemblyInfo
        /// VFL = Visual Form Library       = VFLAssemblyInfo
        /// VRL = Visual Resource Library   = VRLAssemblyInfo    
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access.
        /// </remarks>
        public static VGFAssemblyInfo vai = new VGFAssemblyInfo();
        
        /// <summary>
        /// .NET Class DirectoryInfo - Exists Dir...
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        ///  Class Instance
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Class Directory
        /// pplies access control list (ACL) entries described by a System.Security.AccessControl.DirectorySecurity
        /// object to the directory described by the current System.IO.DirectoryInfo object.
        /// 
        /// directorySecurity:
        /// An object that describes an ACL entry to apply to 
        /// the directory described by the path parameter.
        /// SetAccessControl(DirectorySecurity directorySecurity);
        /// </remarks>
        internal static DirectoryInfo dr = new DirectoryInfo(TraceFile);
        
        /// <summary>
        /// .NET Class StreamWriter - write into File
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// .Flush() write complete Block into File.
        /// .Flush() everytime before .Close() the File !.
        /// if not he close file, but nothing write into file!.
        /// DON'T FORGET .Close(); - if so, the File continue open and no access more and can block the System.
        /// Tipplin Tip: write .Close(); into try/catch block - finally
        /// finally is ultimate free resource, If Exception ot NOT !.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// 
        /// </remarks>
        public static StreamWriter sw = new StreamWriter(fs);

        /// <summary>
        /// .NET Class StreamReader - read from a File
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        public static StreamReader sr = new StreamReader(TraceFile);

        /// <summary>
        /// .NET Class FileStream instance with instancevariable fs.
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// Provides a System.IO.Stream for a file, 
        /// supporting synchronous and asynchronous reads and writes.
        /// </remarks>
        public static FileStream fs = new FileStream(TraceFile, FileMode.OpenOrCreate | FileMode.Append);

        /// <summary>
        /// .NET Class DateTime - Problem is USA to Europe here Germany, 
        /// USA last year make leap second minute have now 60 seconds not 59 - old 12:59:59 new 12:00:60 -> 12:01:00
        /// Problem by Windows Clock must be everytime syncronize the clock with Windows Time Server -> Option Time+Language
        /// Time Server: time.windows.com - every date check the Clock and time - Germany high different was 2 seconds.
        /// Tip Tipplin: install the PTB Clock (Atomclock) written in Javascript as Website:https://uhr.ptb.de/
        /// Class DateTime:
        /// IsLeapYear(int year)
        /// DaysInMonth(int year, int month);
        /// Show all Class Members with marked classname and push F12
        /// </summary>
        public static DateTime dt = new DateTime();

        /// <summary>
        /// Set static instance for Class WindowsIdentity for all other Classes and Methods.
        /// </summary>
        internal static WindowsIdentity id = WindowsIdentity.GetCurrent();

        /// <summary>
        ///  Set static instance for Class WindowsPrincipal for all other Classes and Methods.
        /// </summary>
        internal static WindowsPrincipal p = new WindowsPrincipal(id);


        #endregion


        /// <summary>
        /// Class Constructor VGFCore
        /// <!-- Author TIPPO -->
        /// You can set Statements, Logs, Calls, Messages and Validation
        /// if class declare static, the Constructor same static, without not allowed!.
        /// <!-- Author TIPPO -->
        /// </summary>
        static VGFCore()
        {

            /*************************************************************************************
             * Tipplin Idea
             * -----------------------------------------------------------------------------------
             * ! NOTE ! - An Feature in Windows 10 Professional OS-Build 18362.116 Final Release,
             * AMSI - Anti Malware Scan Interface with API on Website, 
             * or Headerfile amsi.h in SDK 18362
             * -----------------------------------------------------------------------------------
             * AMSI Sample found in Windows Classics on GitHub in C++.
             * AMSI must write an Provider COM Library.
             * ()
             * -----------------------------------------------------------------------------------
             * AMSI Website:
             * https://docs.microsoft.com/en-us/windows/desktop/api/_amsi/
             * 
             * -----------------------------------------------------------------------------------
             * before any call at Framework, idea is check the string or call,
             * bad boy implement an Malware in our Framework.
             * -----------------------------------------------------------------------------------
             * Before use any Function initialize AMSI with Applicationname and AmsiContext:
             * -----------------------------------------------------------------------------------
             * AmsiInitialize(string AppName, System.IntPtr AmsiContext);
             * Parameter AppName:
             * The name, version, or GUID string of the app calling the AMSI API.
             * 
             * 
             * -----------------------------------------------------------------------------------
             * 
             * scan the given string, is Malware inside.
             * AmsiScanString(IntPtr.Zero, "", "", IntPtr.Zero, AMSI_RESULT.AMSI_RESULT_DETECTED);
             * 
             * -----------------------------------------------------------------------------------
             * 
             * AmsiResultIsMalware(uint Result);
             * AMSI_RESULT.AMSI_RESULT_BLOCKED_BY_ADMIN_END
             * AMSI_RESULT.AMSI_RESULT_BLOCKED_BY_ADMIN_START
             * AMSI_RESULT.AMSI_RESULT_CLEAN
             * AMSI_RESULT.AMSI_RESULT_DETECTED
             * AMSI_RESULT.AMSI_RESULT_NOT_DETECTED
             * 
             * -----------------------------------------------------------------------------------
             * Anti Trojan Scan Engine
             * 
             * -----------------------------------------------------------------------------------
             * Tippo Info:
             * Bad Boys!
             * Have download an .zip file from CodeProject, Anti Trojan Engine found Trojan inside
             * Warning: Trojan found !, Remove directly now, Quartantine...
             * Windows 10 Firewall block and the AMSI alert beeps
             * -----------------------------------------------------------------------------------
             * More Security in Windows 10 May update OS-Build 13862.116 (Official Version)
             * 21.05.2019 at time new Revision .145 increment by Microsoft for cleanup's.
             * Windows Firewall is better as before now with Extentions.
             * Network & Firewall Protection, Data Protection, Folder Protection, 
             * Device Protection, Account Protection
             * Ransom Protection save your Datas on ONEDRIVE.
             * -----------------------------------------------------------------------------------
             * Anti Virus Scanner
             * 
             * -----------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             ************************************************************************************* 
             */

            //-----------------------------------------------------------------
            // into class constructor and check is 64BIT System, 
            // if NOT terimate it.
            // X64 is short name for property set with Lambda Operator.
            //-----------------------------------------------------------------
            if (!X64)
            {
                // our Method from Visual.Operation.System.dll
                // same Functions from Windows Operation System, here VFLMsgBox from VFL.dll - C/C++ Functions.
                // Enumerator STYLES with Buttons, Icons, 
                // Flag MsgBoxSetForeground
                // Flag AppModal, TaskModal, SystemModal
                VFLMsgBox("The current Operation System is NOT 64BIT !.", "Visual Galaxy Framework - Operation System Info", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // exit C Runtime Function from mscrt.dll is an 64BIT Dynamic Link Library.
                // and Enumerator EXIT_CODES all ERROR CODES.
                NRMExit(EXIT_CODES.ERROR_OLD_WIN_VERSION);


                // Visual C++ Runtime Library Function for Exit the Program. (use msvcrt.dll only 64BIT Library.)
                // Enumerator EXIT_CODES for all ExitCodes.
                // terminate Program with Wrong Operation System.
                NRMExit(EXIT_CODES.ERROR_APP_WRONG_OS);
            }

            //
            // First set this, next with validation.
            //
            // vgfmessage as public static for all classes/files in Class VGF.Core
            vgfmessage = "Have you a License ? Master ! No than I Terminate\n\n";
            vgfmessage += "Copyright © 2019 by  Visual Galaxy Framework Community Kernel Developer Team.\n";
            vgfmessage += "Copyright © 2019 by Christian 'TIPPO' Kurs - Project-Founder and Main-Author\n";
            vgfmessage += "Portions Copyright © 2019 by Microsoft Corporation GmbH. \n";
            //
            // Our famous MessageBox with Message, Title and the enumerator STYLES for Button, Icon, StandaloneMessageBox in Foreground and System Modal
            // VFLMsgBox from Visual.Function.Library.dll - native C Function, use MessageBoxW from Windows Operation System.
            //
            VFLMsgBox(vgfmessage, "Visual Galaxy Framework - License", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

            /*-----------------------------------------------------------------
             * IDEA HERE:
             * ================================================================
             * Use our Visual Galaxy Framework, we protocol all Windows Actions
             * for more Safety first and better Exception Handling,
             * we start automatic 
             * in hidden background the Windows System Protocoller,
             * for all Windows System Events, User events and more...
             * NO UserInformation or other Information without User Permission.
             * The Windows System Protocol File is open 
             * for the current user on this Computer, for others is denied.
             * ----------------------------------------------------------------
             * For Developers:
             * Windows Operation System have an own Protocoller
             * psr.exe, must be started at runtime the System.
             * Is the Problem Step Recorder with all System and User actions:
             * Mouse move, Keyboard pushes and more...
             * Microso HTML Format saved, is filename.mhtm, 
             * can read with Webbrowser.
             * or do into .zip file and send to:
             * App Author by Exception in Application.
             * 
             *----------------------------------------------------------------- 
             */








        } // CLASS_END::VGFCore::Constructor

        /*---------------------------------------------------------------------
         * Struct as class.
         * Struct/class allowed
         * assignments,
         * Method calls,
         * Property calls,
         * 
         * --------------------------------------------------------------------
         * [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
         * struct structname
         * or
         * class Structname 
         * 
         * --------------------------------------------------------------------
         *  Assembly _foundDllAssembly;
         *  only allowed when the main Class Constructor without static
         *  Class Constructor with parameter and 
         *  base initialize an new instance od teh object class
         *  internal VGFCore(string file):base(file, null)
         *  {
         *      _foundDllAssembly = 
         *      System.Reflection.Assembly.ReflectionOnlyLoadFrom(file);
         *  }
         * 
         * --------------------------------------------------------------------
         *  by static class not allowed ! constructor with access modi public
         *  and an static class construtor must be parameterless !
         *  public VGFCore()
         *  {
         *      InitializeComponent();
         *      cmbInputFolder.Text = 
         *      Properties.Settings.Default.LastusedFolder;
         *      CallMethod();
         *  }
         * 
         * --------------------------------------------------------------------
         * .cctor = class constructor in Microsoft IL
         * .cdtor = class destructor in Microsoft IL but is hidden.
         * static class no destructor allowed !.
         * 
         * --------------------------------------------------------------------
         * NOTE:
         * ~destructor, must have statements, calls, logs or other,
         * but NOT null or empty, the destructor via GC runs in an idle.
         * the system performance goes down.
         * The GCWorkstation or GCServer destroy the last class first,
         * buttom to top.
         * GCWorkstation everytime install by .NET Framework,
         * two versions .NET Framework 32BIT and .NET Framework 64 BIT.
         * C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
         * Have .NET Framework 64BIT you can config GCServer in File:
         * nameofProjectSolution.config
         * manually into this file
         * <runtime>
         *      <gcServer enabled="true"></gcServer>
         * </runtime>
         * 
         * avantages:
         * All Windows Operation System NUMA Function (under 64 BIT) for use
         * Gets or sets a value that indicates whether a full blocking garbage 
         * collection compacts the large object heap (LOH).
         * 
         * 
         *--------------------------------------------------------------------- 
        */

        /// <summary>
        /// Class VGFRemote
        /// </summary>
        static class VGFRemote
         {

            /// <summary>
            /// 
            /// </summary>
            static VGFRemote()
            {
                // First set this, next with validation.
                vgfmessage = "Thank you for use our Framework, if any Problem or Exception,\n";
                vgfmessage += "send it us: per Website or Email. see our Methods for directly send it!.\n";
                vgfmessage += "Any Suggestion or any other welcome !.\n\n";
                vgfmessage += "Copyright © 2019 by  Visual Galaxy Framework Community Kernel Developer Team.\n";
                vgfmessage += "Copyright © 2019 by Christian 'TIPPO' Kurs - Project-Founder and Main-Author\n";
                vgfmessage += "Portions Copyright © 2019 by Microsoft Corporation GmbH. \n";

                VFLMsgBox(vgfmessage, "Visual Galaxy Framework - Remote", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }





            // Set UNC .\\.\\
            /// <summary>
            /// Remote System in Windows 10 Professional OS-Build 18362.116 Official Final Release.
            /// Remote Procedure Call - rpc32.dll
            /// Remote Server Client DLL
            /// 
            /// </summary>
            /// <!-- Author Tipplin -->
            /// 
            /// <!-- Author Tipplin -->
            public static string VGFRemoteServerName = VGFServerName("");
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteComputerName = VGFComputerName();
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteSecureKeyName = "";
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteValueName = "";
            /// <summary>
            /// 
            /// </summary>
            public static bool VGFRemoteIsReference = false;
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteAuthorDirectly = VGFToAuthorDirectly();



            /// <summary>
            /// Wrapper,  set ServerName and give returned to Classmember RemoteServerName
            /// </summary>
            /// <param name="ServerName"></param>
            /// <returns></returns>
            internal static string VGFServerName(string ServerName)
            {
                return ServerName;

            }

            /// <summary>
            ///  USE
            /// </summary>
            /// <!-- Author Tipplin -->
            /// Lock Application, means the User can't close the Application,
            /// an I/O Operation is now running, most by multi threads on 64BIT System on multiple CPUkernels
            /// CPUKernel starts by 0 to 64, but don't use CPUKernel 0 is the Operation System.
            /// GPUKernels for calculation, financial calculation, GPUKernel 1000 faster as the CPU.
            /// Move the Operation from CPU to GPU and return.
            /// <!-- Author Tipplin-->
            /// <returns>
            /// boolean as string true or false
            /// </returns>
            public static string VGFLockApplication()
            {
                try
                {
                    VGFApplicationLockRunningOperation(true);
                    return bool.TrueString;
                }
                catch(ApplicationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return bool.FalseString;

                }
            }




            /*
             * Info to sign <runtime == section runtime in xml-config
             * the sign < is not allowed in normal comment blog.
             * so i have set -runtime- for <runtime</runtime in .config file
             */


            /// <summary>
            /// Get Garbage Collection Status, 
            /// means run the GCWorkstation or GCServer.
            /// project-solution-name.config
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// NOTE! Project-Solution has more than standard file from Visual Studio automatic:
            /// but hidden, must be load into Project Solution Map, stand in Project Paths
            /// your Projectname: Asssemblynamedll.config
            /// .editorconfig
            /// app.config
            /// 
            /// 
            /// 
            /// 
            /// gcWorkstation now is standard by install .NET Framework.
            /// gcServer must be actived Asssemblynamedll.config
            /// section -runtime--/runtime-
            /// see here under File:
            /// 
            /// ❗ Visual.Galaxy.Framework.dll.config ❗
            /// in this Project-Solution.
            /// ---------------------------------------------------------------
            /// Better coding with VeryLargeObjects, VeryLargeObjectHeap, NUMA,
            /// 
            /// but must be an 64 BIT System ! and 64 BIT .NET Framework !.
            /// ---------------------------------------------------------------
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// Gets a value that indicates whether 
            /// server garbage collection is enabled.
            /// </remarks>
            /// <returns>
            /// The following example indicates whether the host computer
            /// is using server or workstation garbage collection. 
            /// </returns>
            public static string VGFGetGCState()
            {
                string result;

                // query Is gcServer Garbage Collector is set?
                if (GCSettings.IsServerGC == true)
                {
                    // ❗ ONLY ON 64BIT OS-System ❗ and 64BIT .NET FRAMEWORK.❗
                    result = "gcServer";
                }
                else
                {
                    // ‼ Is the standard by Installed .NET Framework as GC Workstation ‼
                    result = "gcWorkstation";
                }

               return string.Format("The {0} Garbage Collector is running.", result);

            }

            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * Global Const VB_LNG_FRENCH = 1
             * Global Const VB_LNG_DUTCH = 2
             * Global Const VB_LNG_GERMAN = 3
             * Global Const VB_LNG_ENGLISH = 4
             * Global Const VB_LNG_ITALIAN = 5
             * Global Const VB_LNG_SPANISH = 6
             * 
            internal static string VGFrameworkGetLanguageString(int LanguageID)
            {
        internal string RetLanguage;
    
        switch(LanguageID)
        {
      case VB_LNG_FRENCH:
         RetLanguage = "VFR";
                break;
                case VB_LNG_DUTCH:
         RetLanguage = "VNL";
                break;
      case VB_LNG_GERMAN:
         RetLanguage = "VDE";
                break;
      case VB_LNG_ENGLISH:
         RetLanguage = "VUK";
                break;
      case VB_LNG_ITALIAN:
         RetLanguage = "VIT";
                break;
      case VB_LNG_SPANISH:
         RetLanguage = "VSP";
                break;
                default
   }


        If(LanguageID > 0) Then
          Language = LanguageID
   Else
      Language = VB_LNG_ENGLISH
   End If

   mcGetLanguageID = RetLanguage

    }

*/
            /// <summary>
            /// Get NetBIOS-Computername
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// use here  Class SystemInformation from .NET Framework 4.8.03752
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// ---------------------------------------------------------------------
            /// Use Class SystemInformation from 
            /// namespace System.Windows.Forms,
            /// here are more then 300 Classes for use!.
            /// ---------------------------------------------------------------------
            /// Tip: Make your own Webbrowser
            /// Class Webbrowser...
            /// Create Form - Allows the user to navigate to web pages within a form.
            /// Method GoBack():
            /// Causes the System.Windows.Forms.WebBrowser control 
            /// to navigate to the previous page (if any) in the navigation history.
            /// ---------------------------------------------------------------------
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            internal static string VGFComputerName()
            {
                // Class SystemInformation from namespace System.Windows.Forms, have 300 classes
                return SystemInformation.ComputerName;
            }

            /// <summary>
            ///  Send directly to Author via URL
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            ///  
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// If any Problem or Exception in codeparts, 
            /// we can send later directly to Author on Website/Webserver or GitHub Connect.
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static string VGFToAuthorDirectly()
            {
                return vgfdevTipplinVGFKernelTeam.OriginalString;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static string VGFWebSiteCommunityInvestigativ()
            {
                try
                {
                    // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                    // string microsoft-edge:websitename or URL
                    // our Website Community Investigativ
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" + vgfCommunityInvestigativ.OriginalString);

                    // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                    // but must change bool in Method-declaration into string as returned datatype.
                    return true.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false.ToString();
                }



            } // END_OF_METHOD::VGFWebSiteCommunityInvestigativ

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static string VGFWebSiteCommunityHelp()
            {

                try
                {
                    // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                    // string microsoft-edge:websitename or URL
                    // Our Website Community Helpful & Respectful
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" + vgfCommunityHelp.OriginalString);

                    // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                    // but must change bool in Method-declaration into string as returned datatype.
                    return true.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false.ToString();
                }
            } // END_OF_METHOD::VGFWebSiteCommunityHelp

            /// <summary>
            /// Start Microsoft Webbrowser EDGE
            /// </summary>
            /// <returns>
            /// boolean string - True/False as string return.
            /// </returns>
            public static string VGFStartEdgePure()
            {

                try
                {
                    // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                    // string microsoft-edge:websitename or URL
                    // Our Website Community Helpful & Respectful
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");

                    // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                    // but must change bool in Method-declaration into string as returned datatype.
                    return true.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false.ToString();
                }

            }




            /// <summary>
            ///  Method ToUserDirectlyReturned
            /// </summary>
            /// <!-- Author Tipplin -->
            ///  everytime HIDDEN in this Codepart.
            /// <!-- Author Tipplin -->
            /// <param name="User"></param>
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static string VGFToUserDirectlyReturned(string User)
            {
                // Class System.Web
                // HTTP PostedFile, update file with Fixes.
                // or
                // as Remote Email with .zip file.

                return User;
            }


        } // END_OF_CLASS::VGFRemote








        /// <summary>
        /// Get the current GUID of Windows Operation Systems
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// NOTE: 
        /// found in Setup.bin is binary file, but with Windows XML Block.
        /// ATTENTION:
        /// UNCHECKED
        /// With any new update change GUID's.
        /// <!-- Author Tippo 🧑 -->
        internal static class VGFWindowsOperationSystemGUIDS
        {

            /******************************************************************
             * GUID (128BIT key)  Is a unique identifier for an application
             * Here for all Windows Operation Systems:
             * ! Sample from setup.bin is compiled !
             * 
             * GUID's in an XML block readable
             * any Windows Operation System have an GUID.
             * supportedOS operation system mit GUID-numbers:
             *
             *****************************************************************/

            /// <summary>
            /// GUID Windows 10 - General Unique Identification Key
            /// </summary>
            /// <!-- Author Tippo 🧑 -->
            /// unchecked by new updates, change the GUID by Windows Operation System 10
            /// <!-- Author Tippo 🧑 -->
            /// <remarks>
            /// Microsoft GUID's by Operation Systems and .NET Assemblies - unicate key 128 Bit.
            /// Apple UUID
            /// 
            /// </remarks>
            public const string GUIDSupportedOperationSystem10 = @"8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a";

            /// <summary>
            /// GUID Windows 8.1
            /// </summary>
            public const string GUIDSupportedOperationSystem81 = @"1f676c76-80e1-4239-95bb-83d0f6d0da78";

            /// <summary>
            /// GUID Windows 8.0
            /// </summary>
            public const string GUIDSupportedOperationSystem8 = @"4a2f28e3-53b9-4441-ba9c-d69d4a4a6e38";

            /// <summary>
            /// GUID Windows Vista
            /// </summary>
            /// <remarks>
            /// DON'T use Windows Vista !, 
            /// please make update! s uncorrectness and many Errors inside !.
            /// NO SUPPORT!
            /// </remarks>
            public const string GUIDSupportedOperationSystemVista = @"e2011457-1546-43c5-a5fe-008deee3d3f0";

            /// <summary>
            /// GUID Windows 7
            /// </summary>
            public const string GUIDSupportedOperationSystem7 = @"35138b9a-5d96-4fbd-8e2d-a2440225f93a";


        }




        /// <summary>
        /// The set of constants required for across various(Communication, CrossPlatform, etc.) modules.
        /// string constants with sign @ for unicode string is UTF16
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// Set here all global constants for strings.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// Set instancevariable for class VGFAssemblyInfo - Visual Galaxy Framework
        /// </remarks>
        public static class VGFCoreConstants
        {

            #region constants only for this Project-Solution

            /// <summary>
            /// Counter
            /// </summary>
             internal static int INSTANCECOUNT = 0;

            /* 
             * These values are the builtin defaults, 
             * mainly useful for testing purposes, or 
             * if the user is uninterested in setting a value.
             * 
             */

             internal static int DEFAULT_NUM_FILES = 5;

             internal static int DEFAULT_NUM_HEADER_FILES = 1;

             internal static int DEFAULT_NUM_MACROS = 10;

             internal static int DEFAULT_NUM_LIB_MACROS = 30;

             internal static int DEFAULT_MAX_MACRO_ARGS = 5;

             internal static int DEFAULT_NUM_ENUMS = 10;

             internal static int DEFAULT_NUM_LIB_ENUMS = 30;

             internal static int DEFAULT_NUM_ENUMERATORS = 10;

             internal static int DEFAULT_NUM_STRUCTS = 10;

             internal static int DEFAULT_NUM_LIB_STRUCTS = 30;

             internal static int DEFAULT_NUM_FIELDS = 20;

             internal static int DEFAULT_NUM_CLASSES = 10;

             internal static int DEFAULT_NUM_LIB_CLASSES = 30;

             internal static int DEFAULT_NUM_METHODS = 20;

             internal static int DEFAULT_NUM_FUNCTIONS = 100;

             internal static int DEFAULT_NUM_LIB_FUNCTIONS = 300;

             internal static int DEFAULT_MAX_FUNCTION_ARGS = 8;

             internal static int DEFAULT_FUNCTION_LENGTH = 20;

             internal static int DEFAULT_FUNCTION_DEPTH = 3;

             internal static int DEFAULT_LIB_PERCENT = 10;



            #endregion


            #region Short Descript with Lambda-Opertor

            /// <summary>
            /// ATTENTION ! if accessmodi set private or without name, not by used.
            ///  or set public !.
            /// private is standard in Visual C# without set the private statement.
            /// private has now an degree of protection !, no access by other .cs files.
            /// </summary>
            /// <!-- Author Tippo 🧑 -->
            /// Set short cut names, assignment to a value or string with Lambda Operator =
            /// <!-- Author Tippo 🧑 -->
            internal static int NUM_FILES = DEFAULT_NUM_FILES;

            /// <summary>
            /// 
            /// </summary>
            internal static int NUM_HEADER_FILES = DEFAULT_NUM_HEADER_FILES;


            #endregion


            #region ### All Constants for this Project ###

            /// <summary>
            /// The Company Name of this Framework
            /// </summary>
            public static string COMPANY_NAME = vai.VGFCompany;

            /// <summary>
            /// GUID_number for Assembly - Visual Galaxy Framework
            /// </summary>
            public static string VGF_GUID = vai.VGFAssGUID;

            /*
             * sign @ for unicode sign - Unicode Version 12.1.0 - 07.05.2019 -
             * 
             */


            /// <summary>
            /// constant Name for VGF
            /// </summary>
            public const string PROJECT_NAME = @"© Visual Galaxy Framework";

            /// <summary>
            /// Description of Visual Galaxy Framework
            /// </summary>
            public const string VGF_DESCRIPTION = @"© Visual Galaxy Framework - Application Framework - On GitHub";

            /// <summary>
            /// License Description
            /// </summary>
            public const string VGF_LICENSE_DESCRIPTION = @"This is an unlicensed Version !, Please licensed by our Community";

            /// <summary>
            /// The default language
            /// </summary>
            public const string DEFAULT_LANGUAGE = @"en-US";

            /// <summary>
            /// Versionnumber of Visual Galaxy Framework
            /// </summary>
            public static string VGF_VERSION = vai.VGFVersion;

            /// <summary>
            /// Name of Author
            /// </summary>
            /// <remarks>
            /// @ sign for unicode UTF16,
            /// make special sign like '', "" without espace sign
            /// </remarks>
            public const string MAIN_AUTHOR = @"Christian 'Tipplin' Kurs - Project-Founder / Maintainer";

            /// <summary>
            /// 
            /// </summary>
            public const string TAGS = @"live preview";


            /// <summary>
            /// Number of character should be logged on child process exited with
            /// error message on standard error.
            /// </summary>
            public const int STANDARD_ERROR_MAX_LENGTH = 8192; // 8 KB

            /// <summary>
            /// 
            /// </summary>
            public static string DEFAULT_IMAGE_FILENAME = "";

            /// <summary>
            /// 
            /// </summary>
            public static string NETWORK_NAME = "";

            /// <summary>
            /// 
            /// </summary>
            public static string CLIENT_ID = "";

            /// <summary>
            /// 
            /// </summary>
            public static string REDIRECT_URL = "";

            /// <summary>
            /// 
            /// </summary>
            public static string SCOPES = "";

            /// <summary>
            /// 
            /// </summary>
            public static string PROTECTED_RESOURCE_URL = "";

            /// <summary>
            /// 
            /// </summary>
            public static string SUBJECT_TEXT = "";

            /// <summary>
            /// 
            /// </summary>
            public const string CLIENT_ID_FOR_USER_AUTHORITY = "";

            /// <summary>
            /// Admin consent flow
            /// </summary>
            public const string TENANT = "";

            /// <summary>
            /// 
            /// </summary>
            public const string AUTHORITY_URI = "";

            /// <summary>
            /// 
            /// </summary>
            public const string REDIRECT_URI_FOR_APP_AUTHORITY = "";

            /// <summary>
            /// 
            /// </summary>
            public const string CLIENT_ID_FOR_APP_AUTHORITY = "";

            /// <summary>
            /// 
            /// </summary>
            public const string CLIENT_SECRET = "";

            /*
             * Folder/File/Path Limits
             * if greather as Limit, he cut the File/Path by drag and drop
             * paste in Visual Studio in as Document 8.3 PROJEC~1.doc
             * 
             */

            /// <summary>
            /// Start Dir for NEW Microsoft Webbrowser EDGE with Chromium Engine.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// New, Edge is in separte Dir Microsoft\Edge\Application,
            /// so you can call directly the Edge App with click,
            /// in command line (Console Window) call Edge with start command,
            /// start msedge.
            /// sign @ for unicode, so only one slash !.
            /// <!-- Author Tipplin 🧑 -->
            public const string MSEdgeStart = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

            /// <summary>
            /// Limit for Filename, but note take 260 -1 for safe, no overflow !
            /// </summary>
            public const int FILENAME = 260;

            /// <summary>
            /// Limit for Pathname, but note take 248 -1 for safe, no overflow !
            /// </summary>
            public const int PATHNAME = 248;

        }

        #endregion

        /// <summary>
        /// class VGFWorldWide
        /// </summary>
        /// <!-- Author Tipplin 🧑-->
        /// separate from an Website
        /// <!-- Author Tipplin 🧑 -->
        ///
        /// <remarks>
        /// first array - 190 World Countries
        /// second array - all USA States.
        /// </remarks>
        public static class VGFWorldWide
        {

            /// <summary>
            /// 190 World Countries
            /// </summary>
            public static readonly string[] VGFWorldCountries = {
                // Index 0 empty, the string array begins with Index 1
                "",
                "USA",
                "Canada",
                "Bulgaria",
                "Germany",
                "United Kingdom",
                "Australia",
                "Afghanistan",
                "Albania",
                "Algeria",
                "American Samoa",
                "Andora",
                "Angola",
                "Anguilla",
                "Antarctica",
                "Antigua and Barbuda",
                "Argentina",
                "Armenia",
                "Aruba",
                "Austria",
                "Azerbaijan",
                "Bahamas",
                "Bahrain",
                "Bangladesh",
                "Barbados",
                "Belarus",
                "Belgium",
                "Belize",
                "Benin",
                "Bermuda",
                "Bhutan",
                "Bolivia",
                "Bosnia",
                "Botswana",
                "Bouvet Island",
                "Brazil",
                "British Indian Ocean Terr.",
                "Brunei Darussalam",
                "Burkina Faso",
                "Burundi",
                "Cambodia",
                "Cameroon",
                "Cape Verde",
                "Cayman Islands",
                "Central African Republic",
                "Chad",
                "Chile",
                "China",
                "Christmas Island",
                "Cocos (Keeling) Islands",
                "Colombia",
                "Comoros",
                "Congo (Brazzaville)",
                "Congo, the democratic republic of the",
                "Cook Islands",
                "Costa Rica",
                "Cote de Ivoire",
                "Croatia (Hrvatska)",
                "Curacao",
                "Cyprus",
                "Czech Republic",
                "Denmark",
                "Djibouti",
                "Dominica",
                "Dominican Republic",
                "Ecuador",
                "Egypt",
                "El Salvador",
                "Equatorial Guinea",
                "Eritrea",
                "Estonia",
                "Ethiopia",
                "Falkland Islands",
                "Faroe Islands",
                "Fiji",
                "Finland",
                "France",
                "French Guiana",
                "French Polynesia",
                "French Southern Terr.",
                "Gabon",
                "Gambia",
                "Georgia",
                "Ghana",
                "Gibraltar",
                "Greece",
                "Greenland",
                "Grenada",
                "Guadeloupe",
                "Guam",
                "Guatemala",
                "Guernsey",
                "Guinea",
                "Guinea-Bissau",
                "Guyana",
                "Haiti",
                "Heard and McDonald Is.",
                "Honduras",
                "Hong Kong",
                "Hungary",
                "Iceland",
                "India",
                "Indonesia",
                "Iraq",
                "Ireland",
                "Israel",
                "Italy",
                "Jamaica",
                "Japan",
                "Jersey",
                "Jordan",
                "Kazakhstan",
                "Kenya",
                "Kiribati",
                "Korea South",
                "Kuwait",
                "Kyrgyzstan",
                "Lao Peoples Dem. Rep.",
                "Latvia",
                "Lebanon",
                "Lesotho",
                "Liberia",
                "Libya",
                "Liechtenstein",
                "Lithuania",
                "Luxembourg",
                "Macau",
                "Macedonia",
                "Madagascar",
                "Malawi",
                "Malaysia",
                "Maldives",
                "Mali",
                "Malta",
                "Man, Isle of",
                "Marshall Islands",
                "Martinique",
                "Mauritania",
                "Mauritius",
                "Mayotte",
                "Mexico",
                "Micronesia",
                "Moldova",
                "Monaco",
                "Mongolia",
                "Montenegro",
                "Montserrat",
                "Morocco",
                "Mozambique",
                "Myanmar",
                "Namibia",
                "Nauru",
                "Nepal",
                "Netherlands",
                "Netherlands Antilles",
                "New Caledonia",
                "New Zealand",
                "Nicaragua",
                "Niger",
                "Nigeria",
                "Niue",
                "Norfolk Island",
                "Northern Mariana Is.",
                "Norway",
                "Oman",
                "Pakistan",
                "Palau",
                "Palestine, State Of",
                "Panama",
                "Papua New Guinea",
                "Paraguay",
                "Peru",
                "Philippines",
                "Pitcairn",
                "Poland",
                "Portugal",
                "Puerto Rico",
                "Qatar",
                "Reunion",
                "Romania",
                "Russia",
                "Rwanda",
                "S.Georgia and S.Sandwich Is.",
                "Saint Kitts and Nevis",
                "Saint Lucia",
                "Samoa",
                "San Marino",
                "Sao Tome and Principe",
                "Saudi Arabia",
                "Senegal",
                "Serbia",
                "Seychelles",
                "Sierra Leone",
                "Singapore",
                "Sint Maarten",
                "Slovakia",
                "Slovenia",
                "Solomon Islands",
                "Somalia",
                "South Africa",
                "South Sudan",
                "Spain",
                "Sri Lanka",
                "St. Helena",
                "St. Pierre and Miquelon",
                "St. Vincent and Grenadines",
                "Suriname",
                "Svalbard and Jan Mayen Is.",
                "Swaziland",
                "Sweden",
                "Switzerland",
                "Taiwan",
                "Tajikistan",
                "Tanzania",
                "Thailand",
                "Timor-Leste",
                "Togo",
                "Tokelau",
                "Tonga",
                "Trinidad and Tobago",
                "Tunisia",
                "Turkey",
                "Turkmenistan",
                "Turks and Caicos Islands",
                "Tuvalu",
                "U.S. Minor Outlying Is.",
                "Uganda",
                "Ukraine",
                "United Arab Emirates",
                "Uruguay",
                "Uzbekistan",
                "Vanuatu",
                "Vatican (Holy See)",
                "Venezuela",
                "Viet Nam",
                "Virgin Islands (British)",
                "Virgin Islands (U.S.)",
                "Wallis and Futuna Is.",
                "Western Sahara",
                "Yemen",
                "Zambia",
                "Zimbabwe"


            };

            internal static string localcountry => VGFGetWorldWideCountry(5);

            /// <summary>
            /// All US States here
            /// </summary>
            public static readonly string[] VGFUSStates = {
                // begin with Index 0
                "",
                // Index 1 Alabama
                "AL",
                // Index 2 Alaska
                "AK",

                "AB", //Alberta

                "AZ", //Arizona

                "AR", //Arkansas

                "BC", //British Columbia

                "CA", //California

                "CO", //Colorado

                "CT", //Connecticut

                "DE", //Delaware

                "DC", //District of Columbia

                "FL", //Florida

                "GA", //Georgia

                "Hawaii", //Hawaii

                "ID", //Idaho

                "IL", //Illinois

                "IN", //Indiana

                "IA", //Iowa

                "KS", //Kansas

                "KY", //Kentucky

                "LA", //Louisiana

                "ME", //Maine

                "MB", //Manitoba

                "MD", //Maryland

                /* Massachusetts - special people Hugenotts speak german and english,
                 * old German Butchery - Price mark 'For the Hund' (Bones,rests)
                 */
                "MA", 

                "MI", //Michigan

                "MN", //Minnesota - Minnesota German Cities names: Hamburg, New Ulm, Köln, Heidelberg....

                "MS", //Mississippi

                "MO", //Missouri

                "MT", //Montana

                "NE", //Nebraska

                "NV", //Nevada

                "NB", //New Brunswick

                "NH", //New Hampshire

                "NJ", //New Jersey

                "NM", //New Mexico

                /* New York - part of city is New Paltz 
                 * (German: Neue Pfalz speech paltzisch/pfälzisch
                 * German Teacher in New Paltz: "kann's mit mir deutsch schwätze.")
                 * Long History: Paltz People from Germany migrate to USA 1864,
                 * all childrens speak paltzisch and english.
                 * Tip: On YouTube Videos from 'Kelly Englishs to Germans'
                 * Leavenworth an German Bavaria Town in USA, all from Bavaria, Bavaria Houses, Backery and more... 
                 * 
                 */
                "NY", 

                "NL", //Newfoundland and Labrador

                "NC", //North Carolina

                "ND", //North Dakota

                "NT", //Northwest Territories

                "NS", //Nova Scotia

                "NU", //Nunavut

                "OH", //Ohio

                "OK", //Oklahoma

                "ON", //Ontario

                "OR", //Oregon

                "PA", //Pennsylvania

                "PE", //Prince Edward Island

                "PR", //Puerto Rico

                "QC", //Quebec

                "RI", //Rhode Island

                "SK", //Saskatchewan

                "SC", //South Carolina

                "SD", //South Dakota

                "TN", //Tennessee

                "TX", //Texas - Cologne, two people from German Cologne have founded this City.

                "AE", //US ARMY EUROPE

                "UT", //Utah - Cologne, two people from German Cologne have founded this City. Früh Kölsch Inn

                "VT", //Vermont

                "VI", //Virgin Islands

                "VA", //Virginia

                "WA", //Washington

                "WV", //West Virginia

                "WI", //Wisconsin

                "WY", //Wyoming

                "YT" //Yukon
            };

            /// <summary>
            /// Germany 16 Federal States
            /// </summary>
            /// <!-- Author Tipplin -->
            /// For other Countries, all German Federal States in English/German.
            /// German Holidays in Class VGFWorldWideHolidays.
            /// <!-- Author Tipplin -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return>
            public static readonly string[] VGFGermaFederalStates =
            {
                 // Index 0
                 "",
                 // Index 1 begin Baden Wuerttemberg
                 "BW",
                 //-----------------------------------------------------------
                 // Baveria - the new Baveria in USA Leavenworth/Washington, 
                 // German Shops in English/German. Bavarian Houses.
                 //
                 // Kelly YouTube Videos about Germans and US
                 // USA: outside of DC - German Gourmet Shop all Foods from Germany. 
                 //(Schwartau, Hengstenberg, Kühne, Wanner... and German Beers)
                 // https://www.youtube.com/watch?v=xvc5w3c-Evs

                 //------------------------------------------------------------
                 "BY",
                 // Berlin
                 "BE",
                 // Brandenburg
                 "BB",
                 // Bremen
                 "HB",
                 // Hamburg
                 "HH",
                 // Hesse
                 "HE",
                 // Mecklenbourg Western Pommeriana
                 "MV",
                 // Low Saxe
                 "NI",
                 // Northrhine Westfalia
                 "NW",
                 // Rhineland Palatine
                 "RP",
                 // Saare
                 "SL",
                 // Saxe
                 "SN",
                 // Saxe Anhaltine
                 "ST",
                 // Schleswig Holstein
                 "SH",
                 // Index 15 but Thuringa is the 16 Federal State
                 "TH"

            };









        } // END_OF_CLASS::VGFCountries


        /// <summary>
        /// International Languages for automatic switch in App.
        /// Take check install Version of Windows, then switch to Language.
        /// <!-- Author Tipplin -->
        /// For Germany art Whitepaper from Dr. Knittel CBM:
        /// "German Umlauts"
        /// Coding at UTF8
        /// <!-- Author Tipplin -->
        /// </summary>
        public static class VGFCountryLanguages
        {
            /*-----------------------------------------------------------------
             * Following the ISO International Norm:
             * -----------------------------------------------------------------
             * Two Letter ISO --- Normally Language
             * German grammar rules,
             * 
             * Germany------- de-DE
             * Autriche------ de-AT
             * Switzerland--- de-CH
             * Luxembourg---- de-LU
             * Lichtenstein-- de-LI
             * Belgium------- de-be German Minority unproof
             * -----------------------------------------------------------------
             * Three Letter ISO - Regional Language Dialect
             * -----------------------------------------------------------------
             * Germany------- den-WEN for Sorbish 
             * Sorbish People near Berlin in Spreewood
             * dobre rantje - witamy nam -
             * -----------------------------------------------------------------
             * 
             * 
             */
            /// <summary>
            /// Two Letter ISO for English Language: US = USA, UK = United Kingdom
            /// </summary>
            public static readonly string English = "en-UK";

            /// <summary>
            /// Two Letter ISO for German: 
            /// DE for Germany, AT for Autriche, CH for Switzerland, LS for Liechtenstein, LU for Luxembourg
            /// </summary>
            public static readonly string German = "de-DE";
            
            /// <summary>
            ///  German Regional Dialect Sorbish in Spreewood by Berlin
            ///  Three Letter ISO - den = german -WEN = wendish =>
            ///  inside .NET Framework Country Languages.
            ///  =>
            ///  Witamy nam, dobre ranje,
            /// </summary>
            public static readonly string Sorbish = "den-WEN";

            /// <summary>
            /// 
            /// Dialect of German UN City of Bonn ca. 20 Organizations of UN 2000 People.
            /// The Building was before UN the "Long Eugen" owner now is UN.
            /// 
            /// https://www.unbonn.org/de
            /// 
            /// 
            /// Bonn Video UN
            /// https://www.unbonn.org/sites/default/files/2020-02/DEU-UT-L.mp4
            /// 
            /// Bonn have new Center: 'little Rhinemanhattan'
            /// 
            /// Post Tower is 167 Meters, 
            /// 
            /// 'New Federal Cancellor Place' (before Bonn Center) 101,5 Meters (2023) Investor: Art Invest - with Video
            /// Postbank The main tenant
            /// 
            /// The German Federal Cancellor second Workplace and the German Federal President in Bonn. 
            /// --------------------------------------------------------------------------------------------------------
            /// Mariott Hotel 4 Stars plus Superior Star - 17 Stocks. an First Class Hotel in Bonn. (coast 70 Billions.)
            /// Mariott Hotels Group the greatest of World 2000 an more...
            /// On the Roof - Bar and Restaurant 'KONRAD's' - Star Maitre - Alexander Stadler -
            /// SO - DO 11:00 to 01:00
            /// FR-SA 11:00 to 02:00 Lounge Bar - Long Drinks
            /// --------------------------------------------------------------------------------------------------------
            /// Hotel with Bavarian Beer garden Original Bavarian Food from Munich.
            /// By good Weather you see the Dom in Cologne and more.
            /// General Train Station in progress, new Piazza, Buildings and an Work Office Building with Glass fascade.
            /// In: Versace, Gucci, 
            /// near Bonn General Train Station an Atlanic Hotel - Atlantic Hotel Group Dallas/Texas USA.
            /// Investor: Die Developer Duesseldorf -
            /// 
            /// UNCHECK: Apple Store Bonn 
            /// (Apple was search for Place, Year to Year, Fake: Muensterplace Bank Building.)
            /// 
            /// New Bonn near General Railstation: 
            /// Motel ONE, City Office and more see Video from die Developer Duesseldorf as Investor.
            /// 
            /// https://youtu.be/rl9_A37J4Po
            /// 
            /// Bonn Peoples: goes to 400.000
            /// 
            /// The greatest City in NorthRhine-Westfalia is Cologne 1,2 billions People, 6 Place in Germany.
            /// ---------------------------------------------------------------------------------------------
            /// German Regional Language Dialect
            /// </summary>
            public static readonly string Boennsch = "den-BON";



        } // END_OF_CLASS::VGFCountryLanguages







        //
        // Class Destructor
        // <!-- Author TIPPO --
        // You can set Statements, Logs, Calls, Messages and Validation
        // <!-- Author TIPPO--
        // ATTENTION ! In Visual C# allowed, but the Destructor never Empty or NULL !,
        // if so?, the Destructor goes idling, and the Systen Performance goes down !.
        //
        // static class doesn't havent static destructors.
        //
        // static ~VGFCore()
        // {
        //
        // }




        //**************************************************************************************
        //********************* LANGUAGES INFORMATION ******************************************
        //********************* .NET FRAMEWORK *************************************************
        //
        // by Tipplin (live in Rhineland-Palatine near UN-City Bonn)
        //
        //**************************************************************************************
        //
        // Languages - native	- integer Value primary and secondary
        //
        //--------------------------------------------------------------------------------------
        // Languages - .NET	- Two Letter ISO and Three Letter ISO
        // International Organization for Standardization:
        //  https://www.iso.org/home.html
        //
        //
        //--------------------------------------------------------------------------------------
        // German Two Letter ISO's: -'German Umlauts' from Whitepaper from Dr. Kittel CBM
        //                          - German and English Description
        //                          - German Umlauts on Unicode Organization www.unicode.org
        //--------------------------------------------------------------------------------------
        // Tippo Tip: 'German Umlauts' in Unicode Organization in UTF8.
        // http://www.unicode.org - Unicode Version 12.1.0 -at time 13.0 Beta Review - 
        // Release March 10 2020 - 13.0.0
        // UTF8, UTF16, UTF32 - UTF16 in Common Language Runtime (CLR) in/out.
        //--------------------------------------------------------------------------------------
        // de-BE for German Minority in Belgium, but UNCHECKED !
        // de-DE for Germany-----------
        // de-AT for Autriche---------- "German Umlauts" - 
        // de-CH for Switzerland------- "German Umlauts" - different to Germany,
        // de-LS for Liechtenstein-----
        // de-LU for Luxembourg--------
        //
        //----------------------- Dialects ------------------------------------------------------
        //---- Three Letter ISO for Germany Regional Language Dialect ---- .NET Framework -------
        //----------------- den-WEN - Sorbian Wendish --------------------
        //
        //=======================================================================================
        // Bavarian City in USA, Bavarian Houses Leavenworth/Washington USA
        //
        //
        //
        //----------------------------------------------------------------------------------
        //- english description for federal states of Germany -
        //----------------------------------------------------------------------------------
        // NorthRhine-Westfalia     - Nordrhein-Westfalen
        // Rhineland-Palatine       - Rheinland Pfalz
        //------------------------------------------- Immigration USA - Rhineland-Palatine:
        //------------------------------------------- Paltz People immigration in USA:
        // ------------------------------------------ New Paltz in New York Part of City
        // ------------------------------------------ Hugenotes city-same speak Germans/Paltz
        //------------------------------------------- 'kanns mit mir deutsch schwätze!'
        //------------------------------------------- Amercian School - German Teacher
        //
        // State Minnesota/ City of Minneapolis ----------- German City's Names: 
        //                                            Hamburg, Cologne, Ulm, Heidelberg
        // most Germans Immigration.
        // Cologne in  - with Frueh Koelsch (Greatest Bewery in Cologne Worldwide)
        // The Berlin "Reichstag" Federal State Department on Roof Frueh Koelsch,
        // Georg Gysi drink not Berlin Beer, Frueh Koelsch.
        //
        // Berlin: 
        // "Ständige Vertretung des Rheinlands", Frueh Koelsch, Halve Hahn, Frikadellen and more,
        // Founder: 
        // Dirk Drautzburg from Bonn, for years founded in Leipzig, Dresden, Hamburg
        //----------------------------------------------------------------------------------
        //--------------------------------------------------- German 16 Dialects: 
        // Saxe                     - Sachsen               - Saxon - Sächsisch   
        // Hesse                    - Hessen                - Hessian - Hessisch
        // Bavaria                  - Bayern                - Bavarian - Bayerisch
        //                          - Franken               - Franconian - Fränkisch
        // Saxe Anhaltine           - Sachsen Anhalt        - 
        // Thuringa                 - Thüringen
        // - Brandenburg
        // - Mecklenburg-Vorpommern
        // - Niedersachsen
        // Saare                    - Saarland
        // Berlin
        // - Baden-Württemberg      - Baden                 - Alemannic - Badisch
        //                          - Schwaben              - Swabian   - Schwäbisch
        // Hamburg                  -                       - Hamburgi  - Hamburgisch
        // Rhineland Palatine       - Rheinland Pfalz       - Palatine - Pfälzsich
        // North-Rhine Westfalia    - Nordrhein Westfalen - 
        // Specials: 
        // Ruhrdeutsch - Ruhr Area Dialect
        // Plattdeutsch - Low German
        // Rhineland: Cologne Dialect, Boennsch Dialect
        // Rhine River Valley
        //----------------------------------------------------------------------------------
        // German/English Commission (Langenscheidt) in London new Words German/English:
        //----------------------------------------------------------------------------------
        // Rolls - Brötchen 
        // (Great German Bakery near London ca. 100 Salescars. London Stock. Self Service.
        // Favorites: Rolls, Top-Hit: Bread-Pumpernickel)
        //
        // at Time German Shields in City 'Zur U-Bahn'
        // In  London:
        // !NOTE! same U-Trams Driver speak good german, one was in Berlin (BVG)Tram Driver.
        //----------------------------------------------------------------------------------
        // NorthRhine-Westfalia: 
        // 2017: 
        // Cologne is the greathest City over 1 Million People - 6. Place in Germany
        // (Berlin over 4 Million.)
        //----------------------------------------------------------------------------------
        // Three Cities in the World: -- New York, Wien and Bonn. 
        //----------------------------------------------------------------------------------
        // TIPPO:
        // slang: Rhineanttan
        // The NEW - Tower in Bonn - 101,5 Meters. Main-Customer is Post Bank.
        // (New Bonn Center - TIPPO TIP: NEW UN-Tower)
        //
        // Investor: The New Cancellor Place in Bonn. (Website) with 3 Buildings.
        // now in Work - Complete ca. 2023
        //
        // UN-Tower - (German Slang "Langer Eugen").
        // 'UN Bonn' Website for more Information what UN do in Bonn.
        //-----------------------------------------------------------------
        // NEW! Bonn Main Railstation
        // 5 Buildings in Work, City Office near the Station:
        // (! Gucci, Prada, One Group Hotel, New Piazza, Apple Store..)
        // The Developer Project Team on Web with Photos and Video.
        // Bonn new Piazza Restauration 1000 qm by Sander Manufacture the
        // Ankermieter. (2019 at Frankfurt Zeil)
        //
        //-----------------------------------------------------------------
        // The Mariott Hotel 4+ (5) Stars in Bonn, 
        // 17Floor see by clear Weather City of Cologne 
        // and the famous DOM !. 
        // Cafe/Bistro/Restaurant over there Chief Aleander Stadler.
        // Greathest Worldwide Hotelgroup !
        //
        // The World Conference Center - 2018/2019 - Full - UN-Conferences
        // The Hotel Kahema
        // The Hotel Hilton.
        //
        // Mount Drachenfels with new Panorama Restaurant,
        // by Clear Weather see the Cologne Dom or Koblenz, 
        // with new great Plateau "German Biergarten" (ca. 500 Guests)
        // 2 Kitchen's for Company Party or Guests.
        // Bistro.
        // New Concept, all trades built in the mountain,
        // Wine Room over 20000 Bottles Red/White.
        // Conference Rooms. Reservation great restauration for Company.
        //
        //----------------------------------------------------------------
        //
        //
        //----------------------------------------------------------------
        // For Unicode Information see Unicode Organization -
        // For Windows 10 develop with Visual Studio in unicode and 64BIT
        // while Area 32BIT goes to End !.
        // Same Vendors dont supports 32BIT, IBM, 
        // Apple (developer site "develop next for 64BIT"), NVIDIA,
        //
        //----------------------------------------------------------------
        // Unicode Consortium change website:
        // https://home.unicode.org/
        //
        // Online Tool "ShapeCatcher" write/paint your
        // Sign or other into Box, and ShapeCatcher look directly in
        // Unicode Organization is or not !.
        // at Time Unicode Handbook Version 12.1.0
        // 
        // UO Return: Hexadecimal Value and Font...
        // UTF8    - 8 BIT	 - Signs, Music, Chemistry, and "German Umlauts"
        // UTF16   - 16 BIT - Work into Common Language Runtime (In/Out)
        // UTF32   - 32 BIT - only Algorithmic
        //----------------------------------------------------------------
        // Unicode Standard
        // Each release of the Unicode Standard includes the 
        // core specification, the code charts, data files, all annexes, 
        // and UTS #10, UTS #39, UTS #46, and UTS #51.
        //
        //----------------------------------------------------------------
        // For 'German Umlauts' have Specials from Dr. Knittel -CBM-:
        // Same German Umlauts in Germany, Autriche, Switzerland..
        // ä. ü, ß - sharp s - other see in Handbook.
        // 
        //----------------------------------------------------------------
        // ! NEW ! .NET Command Line Tool - dotnet with commands -
        // <dotnet --version, <dotnet --info, <dotnet --help
        // <type csharpfile.cs, <type csharpprojectfile.csproj
        // <type csharpfilesolution.sln
        // so he list off all text in files.
        // or compile, create, test all files.
        //
        //----------------------------------------------------------------
        // Console Window is Now the Operation System Window by new
        // May Update 2019 - OS-Build 18362 - 
        // Microsoft change the Name Console to Windows Terminal
        // while Windows Operation System goes open source,
        // Microsoft Build 2019, Windows open source with MIT License.
        //----------------------------------------------------------------
        // Windows Terminal Beta State on GitHub for Developers
        // sourcecode in C++.
        //---------------------------------------------------------------
        // next is:
        // Windows Implementation Libraries (WIL) open source on GitHub
        //---------------------------------------------------------------
        //
        //
        //---------------------------------------------------------------
        // For Students and very good Insiders: 
        // Windows Research Kernel source
        // Files only for Kernel written in C.
        //
        //
        //----------------------------------------------------------------
        // Annotation Tippo:
        // Windows 10 Operation System have ca. 40000 Files,
        // compile in ca. 4 Hours on Build Server,
        // written with Visual Studio in C++ and C#.
        //----------------------------------------------------------------
        // Microsoft Third Party Tools with sourcecode,
        // this third party tools all in Microsoft Products,
        // Office,
        //
        // While not all written by Microsoft Developers.
        //================================================================
        // programming your Console App with Class, Methods, Properties
        // and 1 Event.
        // Windows 10 'Fall Creators Update' - Console Window:
        // more colors,
        // SimpleSample, create a Console Window to your App, 
        // the Console Window goes HIDE, can receive and send to other
        // Window's, create logfile, Message for Information, Warnings,
        // by Critical goes from HIDE in Show Modus to show current User
        // this Messages.
        // TIPPO's: Console Window App with Splash, at runtime goes in
        // Resize and show Splash Image after Thread.Sleep goes another
        // Resize Normal and show all Messages.
        // Dependency with native Functions Library written in C.
        // Console Window App with Class ExternalNativeFunction 
        // MultiBeep, MessageBox(int TextID) - see fore defined Text,
        // set only TextID.
        //
        // Avantage: Console Window have smaller Overhead as a Window.
        // Faster, directly to Operation System !.
        //----------------------------------------------------------------
        // 2016 - German Umlauts allowed in Cryptografie and Internet/Web
        // ! NOTE - NEW ! - SHA1 is OUT !!!!.
        //----------------------------------------------------------------
        // ! TIPPO !: Set Language System Functions here to sure.
        // Some Functions intergrated in .NET Framework
        //
        //
        //****************************************************************



        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        internal const int LANG_NEUTRAL = 0x00,
                           LOCALE_IFIRSTDAYOFWEEK = 0x0000100C;   /* first day of week specifier */

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->        internal const int LOCALE_IMEASURE = 0x0000000D;   // 0 = metric, 1 = US

        /// <summary>
        /// Comments by SAP ABAP - Programming Language
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        internal const string CommentABAP = "=!";

        /// <summary>
        /// Set Global Variable for all in Project
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static string vgfmessage;



        #region ### Shortnames for Date with Operator Lambda => for Time Methods ###


        /// <summary>
        /// Get short real time now.
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <return>
        /// 
        /// </return>
        public static string SNowTime => DateTime.Now.ToShortTimeString();

        /// <summary>
        /// Get the real date
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static string SNowDate => DateTime.Now.ToShortDateString();

        /// <summary>
        /// Get the real day
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static string SToday => DateTime.Today.Day.ToString();

        /// <summary>
        /// 
        /// </summary>
        public static string ACTION_SETTINGS { get; private set; }

        /// <summary>
        ///  Univeral Time Coordinate Time for Worldtime/Europe
        ///  International Bureau for Measures and Weights in Paris.
        ///  All Atom Clocks of the World (ca. 300).
        ///  And NEW International Unit System at 20.05.2019,
        ///  (Conference Novembre 2018)
        ///  Adieu Base Units, welcome Nature Constants.
        ///  Candela, Ampere, Mole, Kelvin, Second, Meter, Kilogram (after uncorrectness new definition)
        ///  new definitions.
        ///  Germany: PTB Braunschweig/Berlin
        ///  The new Atom Clock with Light and Laser,
        ///  correctness  Factor 17.
        ///  Caesium is out!
        ///  PTB-Clock with local time difference in milliseconds - unsafe +- milliseconds: https://uhr.ptb.de/
        ///  
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static string UtcNow = DateTime.UtcNow.ToString();

        /// <summary>
        /// Get real Weekday
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static string Wday = DateTime.Now.DayOfWeek.ToString();

        /// <summary>
        /// Get is Leap Year ?, with given Year
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static bool LYear = DateTime.IsLeapYear(Year);

        /// <summary>
        /// Get real Year
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static int Year = DateTime.Now.Year;

        /// <summary>
        /// Get real value for Month - 1=january - 12 december
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static int Month = DateTime.Now.Month;

        /// <summary>
        /// Get real Days in Month, with given year and month
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static int DMonth = DateTime.DaysInMonth(Year, Month);


        /// <summary>
        /// Cane write into File
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static bool CanWrite = true;

        /// <summary>
        /// Can't write into File
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        public static bool CanNotWrite = false;


        #endregion


        #region ### Enumerators ###



        #endregion



        #region sourcecode from VALA Programming Language


        /* Experimental for Visual C# and .NET

        public static Application instance;

        public static bool log_auth = false;
        public static bool log_downloader = false;
        public static bool log_workers = false;
        public static bool log_no_filters = false;
        public static bool log_verbose = false;

        public const string ACTION_PREFIX = "app.";
        public const string ACTION_SETTINGS = "settings";
        public const string ACTION_ABOUT = "about";
        public const string ACTION_CORRUPTED_INSTALLER_PICK_ACTION = "corrupted-installer.pick-action";
        public const string ACTION_CORRUPTED_INSTALLER_SHOW = "corrupted-installer.show";
        public const string ACTION_CORRUPTED_INSTALLER_BACKUP = "corrupted-installer.backup";
        public const string ACTION_CORRUPTED_INSTALLER_REMOVE = "corrupted-installer.remove";
        public const string ACTION_GAME_RUN = "game.run";
        public const string ACTION_GAME_DETAILS = "game.details";
        public const string ACTION_GAME_PROPERTIES = "game.properties";

        internal static string[] Exec_cmd = {
                    "gdb", "-q", "--batch",
                    "-ex", @"set args $cmd_args_string",
                    "-ex", (opt_gdb_fatal_criticals ? "set env G_DEBUG = fatal-criticals" : "unset env G_DEBUG"),
                    "-ex", "set pagination off",
                    "-ex", "handle SIGHUP nostop pass",
                    "-ex", "handle SIGQUIT nostop pass",
                    "-ex", "handle SIGPIPE nostop pass",
                    "-ex", "handle SIGALRM nostop pass",
                    "-ex", "handle SIGTERM nostop pass",
                    "-ex", "handle SIGUSR1 nostop pass",
                    "-ex", "handle SIGUSR2 nostop pass",
                    "-ex", "handle SIGCHLD nostop pass",
                    "-ex", "set print thread-events off",
                    "-ex", "run",
                    "-ex", "thread apply all bt" + (opt_gdb_bt_full ? " full" : ""),
                    current_args[0]
                };


        construct
		{
			application_id = ProjectConfig.PROJECT_NAME;
			flags = ApplicationFlags.HANDLES_COMMAND_LINE;
			instance = this;
			add_action_entries(action_entries, this);
        set_accels_for_action(ACTION_PREFIX + ACTION_SETTINGS, { ACCEL_SETTINGS });
		}

    private const string[] Action_Entries = {
            ACTION_SETTINGS = "action_settings",
            { ACTION_ABOUT,                           action_about },
            { ACTION_CORRUPTED_INSTALLER_PICK_ACTION, action_corrupted_installer, "(ss)" },
            { ACTION_CORRUPTED_INSTALLER_SHOW,        action_corrupted_installer, "(ss)" },
            { ACTION_CORRUPTED_INSTALLER_BACKUP,      action_corrupted_installer, "(ss)" },
            { ACTION_CORRUPTED_INSTALLER_REMOVE,      action_corrupted_installer, "(ss)" },
            { ACTION_GAME_RUN,                        action_game, "s" },
            { ACTION_GAME_DETAILS,                    action_game, "s" },
            { ACTION_GAME_PROPERTIES,                 action_game, "s" }
        };
        


    */

        /* @    ManagedComment for Visual C# and .NET
         * @
         * @
         * @ Applicationname = (most) Solutionname;
         * @
         * @ Path
         * @    Paths{
         *              "path 1",
         *              "path 2",
         *              "path 3"
         * }
         * 
         * @ Class
         * @    Class1{
         *              Classname = "VGF.Core",
         *              Classversion = 0,
         *              ClassMajor = 0,
         *              ClassMinor = 0,
         *              ClassBuild = 0,
         *              ClassRevision = 0
         * }
         * 
         * @ Method
         * @    Method1{
         *              Methodname = "",
         *              Methodversion = 0,
         *              Methodrevision = 0
         * }
         * 
         * @ Instances
         * @    ManagedInstances{
         * 
         * 
         * }
         * 
         * @    UnManagedInstances{
         * 
         * 
         * }
         * 
         * @    ApplicationScope{
         * @    Set dependencies here for Application:
         * @    External Libraries and Operation System.
         *  Dependencies{
         *              <dependency>
         *                  <name>user32.dll</name>
         *                  <group></group>
         *                  <groupID></groupID>
         *                  <artifactID></artifactID>
         *                  @ mininum .NET Framework Version
         *                  <minNETFrameworkVersion></minNETFrameworkVersion>
         *                  @placeholder@
         *                  @ mininum SDK Version for Application 
         *                  <minsdkversion>10.0.20175.1000</sdkversion>
         *                  <version>2005</version>
         *                  <scope>Windows</scope>
         *  
         *              </dependency>
         *  /Dependencies}
         *                  
         *                  
         *                  
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         *              
         *      
        */



        #endregion




        #region ### Struct Instance Variables ###

        // struct and instance variable on STACK!
        // MEMORYSTATUSEX ex;
        // by new operator:
        // MEMORYSTATUSEX ex = new MEMORYSTATUSEX(); on HEAP ever!
        //
        // (Visual C# allocate automatic memmory for struct)
        // (Visual C# struct never null bytes, 1 byte for managed the Struct, if members or not!.)
        //
        // (Microsoft: Limit of Struct 16 Bytes, are greater split off in other.)
        // Here in Class Head only Structs with Instance-Variable, but NOT The Call, in Method!





        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <param name="primary"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        internal static int VGFMakeLangId(int primary, int sub)
        {
            //-----------------bitwise shift left
            return ((((ushort)(sub)) << 10) | (ushort)(primary));
        }

        //----------------------------------------------------------------
        // TIPPO UNDONE / UNCHECKED
        //----------------------------------------------------------------
        // Default System and User IDs for language and locale.
        // Convert Visual C++ Macro to Visual C# Method
        //----------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <param name="lgid"></param>
        /// <param name="srtid"></param>
        /// <returns></returns>
        internal static uint VGFMakeLCId(ushort lgid, ushort srtid)
        {
            //----------------------bitwise shift left
            return ((uint)((((uint)(srtid)) << 16) | ((uint)((lgid)))));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <param name="lgid"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        internal static int VGFMakeLCId(int lgid, int sort)
        {
            return ((0xFFFF & lgid) | (((0x000f) & sort) << 16));
        }



        /// <summary>
        /// Show standard Message for Method.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// Have set the Enumerator ERROR_CODES all in.
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode);
        /// msvcrt.dll - 64BIT Only -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks>
        internal static void VGFUsageMethod()
        {
            VFLMsgBox("The Method is not supported on this Operation System !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            NRMExit(EXIT_CODES.ERROR_CALL_NOT_IMPLEMENTED);
        }

        /// <summary>
        /// Show standard for User Cancel.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode); -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks> 
        internal static void VGFUsageUser()
        {
            VFLMsgBox("The Operation was cancelled by the User !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            NRMExit(EXIT_CODES.ERROR_CANCELLED);
        }

        /// <summary>
        /// Show standard for DLL not found.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode); -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks> 
        internal static void VGFUsageDLL()
        {
            VFLMsgBox("The Operation was cancelled by the User !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            NRMExit(EXIT_CODES.ERROR_DLL_NOT_FOUND);
        }

        /// <summary>
        /// Show standard for Internal Error
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode); -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks> 
        internal static void VGFUsageInternalError()
        {
            VFLMsgBox("An  error is occurred !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

            NRMExit(EXIT_CODES.ERROR_INTERNAL_ERROR);
        }

        /*--------------------------------------------------- 
         * Java
         * --------------------------------------------------
         * Project Joda Time
         * --------------------------------------------------
         * A selection of key features:
         * LocalDate - date without time
         * LocalTime - time without date
         * Instant - an instantaneous point on the time-line
         * DateTime - full date and time with time-zone
         * DateTimeZone - a better time-zone
         * Duration and Period - amounts of time
         * Interval - the time between two instants
         * A comprehensive and flexible formatter-parser
         * 
         *--------------------------------------------------- 
         */

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <param name="datetime"></param>
        /// <returns></returns>
        internal static bool VGFIsAfterPayDay(DateTime datetime)
        {
            DateTime dt = new DateTime();
            
            if (dt.Month == 2)
            {   // February is month 2!!
                return dt.Day >26 ;
            }
            return dt.Day > 28;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <param name="Year"></param>
        /// <returns></returns>
        internal static string VGFGetDaysToNewYear(DateTime Year)
        {
            return Year.DayOfYear.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Message"></param>
        internal static void VGFInternalInfo(string Message)
        {
            // FailFast terminate now the Process, write into Windows Application Event Log and send Message and ErrorReport to Microsoft.
            Environment.FailFast(Message);
            /*
             * Class Enviroment all System Infos and
             * Windows Folders - ! ATTENTION ! If you are NOT Administrator in Windows Account, Windows 10 automatic lock same Folders.
             * Onyl the Administrator and Admin Account have full rights !.
             * same by Windows Firewall, Windows Protection, Windows Network Protection, only as Administrator can set the Protections.
             * Special Folders - 60 Folders
             * 
             */
        }








        /*-------------------------------------------------------------------------------------------------------------------------
         * .NET Framework 4.7.2 and Visual C# 7.3 allowed this catch like Java
         * 
         * Same Classes have more then one Exceptions. Here SystemException.
         * 
         * catch(SystemException ex)when(ex is BufferOverflowException || ex is COMException || ex is InvalidDataException)
         * {
         * 
         *------Exception Messagetext - Source who occured the Exception. STYLES for MessageBox written C with Wrapper here,
         *---------------------------------------------------------------- STYLES as Enumerator like VB.NET.
         *      VOLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
         *      return false;
         * }
         * 
         *--------------------------------------------------------------------------------------------------------------------------
         */

        /*---------------------------------------------------------------------
         * Class FrameworkException
         * for our Visual Galaxy Framework.
         * --------------------------------------------------------------------
         * More Information who is the Exception occured ?
         * App Domain
         * Assembly Name
         * Class Name
         * Exception
         * User
         * Machine
         * Method Name
         * Process ID
         * Process Name
         * Reason Enumerator
         * Thread ID
         * -------------------------------------------------------------------- 
         * Error classes used throughout the library.
         * 
         * export class BadEventName extends Error { }
         * export class RequestTimedOut extends Error { }
         * export class TransportPriorityTooLow extends Error { }
         * export class TransportClosed extends Error { }
         * export class UnsupportedFeature extends Error { }
         * export class UnsupportedTransport extends Error { }
         * export class UnsupportedStrategy extends Error { }
         * 
         * 
         * 
         * --------------------------------------------------------------------
         * Set our Class FrameworkException for our Visual.Galaxy.Framework:
         * 
         * AppDomain is the Application Name who occured the Exception
         * AssemblyName is the Assemblyname who occured the Exception
         * ClassName is the Class who occoured the Exception.
         * If you use multiple Servers for Service Hosting,
         * this property shows which machine experienced the Error.
         * 
         * MethodName is the Method who occured the Exception.
         * ProcessID is Idnumber of Process at Error returns integer value.
         * ProcessName is Name of Process who occured at Exception.
         * ThreadID is the Thread ID number of the 
         * Thread who occured the Exception.
         * --------------------------------------------------------------------
         * 
         */

        /// <summary>
        ///👁‍🗨📸
        /// Define for our Framework, FrameworkException with Members
        /// Base Class is SystemException.
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// Create Global Exceptionhandling for this Framework.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// This class previously indicated an unspecified fatal error in the runtime. 
        /// </remarks>
        [Serializable]
        internal class VGFFrameworkException : SystemException
        {
            /// <summary>
            /// 
            /// </summary>
            private readonly int VGFFrameworkExceptionCode;

            /// <summary>
            /// 
            /// </summary>
            public int VGFFrameworkExceptionNativeErrorCode => VGFFrameworkExceptionCode;

            /// <summary>
            /// StackFrame is the complete Stack,
            /// </summary>
            internal StackFrame sf = new StackFrame();

            /// <summary>
            /// VGFFrameworkErrors
            /// </summary>
            public enum VGFFrameworkErrors : int
            {
                // second alternate as hexadecimal but unchecked.
                // ul at end allow! as unsigned long = ulong 64BIT value.
                // datatype is ulong, but by value is UInt32, but there is wrong!
                // so at end of value set ul for ulong! UInt64.
                //  const ulong ObjectError2 = 0x80040000ul;
                // long with signed sign, value with L for Int64
                // l lower letter is not so good, can be confused with 1,
                // so set upper letter L !
                // set here for HResult integer 
                // Limit integer -2147483648 (-1) - + 2147483647 (-1)
                // -1 for no overflow!
                // same in others values or control

                /// <summary>
                /// Object Error (-2147000000) occured in Framework
                /// </summary>
                VGF_Framework_Object_Error = -2147000000,
                // Base Errornumber for Framework Error
                VGF_Framework_Error_Base,
                // Framework Errornumber for namespace 
                VGF_Framework_Error_Namespace,
                // Framework Errornumber for Class 
                VGF_Framework_Error_Class,
                /// <summary>
                /// Framework Errornumber for Method 
                /// </summary>
                VGF_Framework_Error_Method,
                /// <summary>
                /// Method not found in Framework
                /// </summary>
                VGF_Framework_Error_MethodNotFound,
                /// <summary>
                /// Framework Errornumber for Property 
                /// </summary>
                VGF_Framework_Error_Property,
                /// <summary>
                /// Framework Errornumber for Event 
                /// </summary>
                VGF_Framework_Error_Event,
                /// <summary>
                ///  Framework Errornumber for Bad Format in exe file
                /// </summary>
                VGF_Framework_Error_Bad_Exe_Format,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Bad_Net_Name,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Bad_Net_Path,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Disk_Corrupt,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Dll_Init_Failed,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Dll_Not_Found,

                VGF_Framework_Error_Exe_Marked_Invalid,

                VGF_Framework_Error_File_Corrupt,

                VGF_Framework_Error_File_Invalid,

                VGF_Framework_Error_File_Not_Found,

                VGF_Framework_Error_Invalid_Dll,

                VGF_Framework_Error_Invalid_Name,

                VGF_Framework_Error_Invalid_Ordinal,

                VGF_Framework_Error_Invalid_Parameter,

                VGF_Framework_Error_Lock_Violation,

                VGF_Framework_Error_Mod_Not_Found,

                VGF_Framework_Error_Func_Not_Found,

                VGF_Framework_Error_No_Access,

                VGF_Framework_Error_Not_Ready,

                VGF_Framework_Error_Open_Failed,

                VGF_Framework_Error_Path_Not_Found,

                VGF_Framework_Error_Wrong_Target_Name,

                VGF_Framework_Error_Illegal_Function_Call,
                // String Storage place is full
                VGF_Framework_Error_Out_Of_String_Space,
                // String is too long maximum integer value
                VGF_Framework_Error_String_Too_Long,

                VGF_Framework_Error_Time_Out_Overflow,

                VGF_Framework_Error_File_Already_Open,

                VGF_Framework_Error_File_Already_Exists,

                VGF_Framework_Error_Device_IO_Failed,

                VGF_Framework_Error_Device_Unavailable,

                VGF_Framework_Error_Feature_Unavailable,

                VGF_Framework_Error_File_Path_acess_denied,

                VGF_Framework_Error_Missing_Library,

                VGF_Framework_Error_Duplicate_Name,

                VGF_Framework_Error_Unknown_Internal_Error = 255

            }

            internal VGFFrameworkException() : base()
            {
                VGFFrameworkExceptionSetCode(-2147000000);
            }




            /// <summary>
            /// 
            /// </summary>
            /// <param name="hr"></param>
            void VGFFrameworkExceptionSetCode(int hr)
            {
                HResult = hr;
            }


            /*
             * 
             * Fatal Framework Error Exception
             * Console.Error.WriteLine();

			Console.Error.WriteLine("*** INTERNAL FRAMEWORK ERROR ***");

			Console.Error.WriteLine();

			Console.Error.WriteLine("PLEASE FILE A BUG REPORT FOR IKVM.NET WHEN YOU SEE THIS MESSAGE");

			Console.Error.WriteLine();

			Console.Error.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().FullName);

			Console.Error.WriteLine(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory());

			Console.Error.WriteLine("{0} {1}-bit", Environment.Version, IntPtr.Size * 8);

			Console.Error.WriteLine();

			Console.Error.WriteLine(x);

			return 2;
             * 
             * 
             VGFFrameworkException() : base()
            {
                sealed class FatalCompilerErrorException : Exception

            {

                internal VGFFatalFrameworkErrorException(Message id, params object[] args)

                    : base(string.Format("fatal error IKVMC{0}: {1}", (int)id, args.Length == 0 ? GetMessage(id) : string.Format(GetMessage(id), args)))

                {

                }

                Developer Jeroen Frijters new Java Fork IKVM.NET - 
                Java for .NET - with OpenJDK puls IKVM Compiler
                written in Visual C# yet - Orignal IKVM.NET in Project MONO -
                Class-declaration in C# :plus Java inherited java.lang.thread

                Visual C# and Java work together:
                using System;
                using System.Diagnostics;
                using System.IO;
                using System.Reflection;
                using IKVM.Internal;
                using ikvm.runtime;
                using java.lang.reflect;
                
                Visual C# - Class:
                private class SaveAssemblyShutdownHook : java.lang.Thread
                
                
                
                ---------------------------------------------------------
                
                private static string GetMessage(Message id)

                {

                    switch (id)

                    {

                        case IKVM.Internal.Message.ResponseFileDepthExceeded:

                            return "Response file nesting depth exceeded";

                        case IKVM.Internal.Message.ErrorReadingFile:

                            return "Unable to read file: {0}\n\t({1})";

                        case IKVM.Internal.Message.NoTargetsFound:

                            return "No targets found";

                        case IKVM.Internal.Message.FileFormatLimitationExceeded:

                            return "File format limitation exceeded: {0}";

                        case IKVM.Internal.Message.CannotSpecifyBothKeyFileAndContainer:

                            return "You cannot specify both a key file and container";

                        case IKVM.Internal.Message.DelaySignRequiresKey:

                            return "You cannot delay sign without a key file or container";

                        case IKVM.Internal.Message.InvalidStrongNameKeyPair:

                            return "Invalid key {0} specified.\n\t(\"{1}\")";

                        case IKVM.Internal.Message.ReferenceNotFound:

                            return "Reference not found: {0}";

                        case IKVM.Internal.Message.OptionsMustPreceedChildLevels:

                            return "You can only specify options before any child levels";

                        case IKVM.Internal.Message.UnrecognizedTargetType:

                            return "Invalid value '{0}' for -target option";

                        case IKVM.Internal.Message.UnrecognizedPlatform:

                            return "Invalid value '{0}' for -platform option";

                        case IKVM.Internal.Message.UnrecognizedApartment:

                            return "Invalid value '{0}' for -apartment option";

                        case IKVM.Internal.Message.MissingFileSpecification:

                            return "Missing file specification for '{0}' option";

                        case IKVM.Internal.Message.PathTooLong:

                            return "Path too long: {0}";

                        case IKVM.Internal.Message.PathNotFound:

                            return "Path not found: {0}";

                        case IKVM.Internal.Message.InvalidPath:

                            return "Invalid path: {0}";

                        case IKVM.Internal.Message.InvalidOptionSyntax:

                            return "Invalid option: {0}";

                        case IKVM.Internal.Message.ExternalResourceNotFound:

                            return "External resource file does not exist: {0}";

                        case IKVM.Internal.Message.ExternalResourceNameInvalid:

                            return "External resource file may not include path specification: {0}";

                        case IKVM.Internal.Message.InvalidVersionFormat:

                            return "Invalid version specified: {0}";

                        case IKVM.Internal.Message.InvalidFileAlignment:

                            return "Invalid value '{0}' for -filealign option";

                        case IKVM.Internal.Message.ErrorWritingFile:

                            return "Unable to write file: {0}\n\t({1})";

                        case IKVM.Internal.Message.UnrecognizedOption:

                            return "Unrecognized option: {0}";

                        case IKVM.Internal.Message.NoOutputFileSpecified:

                            return "No output file specified";

                        case IKVM.Internal.Message.SharedClassLoaderCannotBeUsedOnModuleTarget:

                            return "Incompatible options: -target:module and -sharedclassloader cannot be combined";

                        case IKVM.Internal.Message.RuntimeNotFound:

                            return "Unable to load runtime assembly";

                        case IKVM.Internal.Message.MainClassRequiresExe:

                            return "Main class cannot be specified for library or module";

                        case IKVM.Internal.Message.ExeRequiresMainClass:

                            return "No main method found";

                        case IKVM.Internal.Message.PropertiesRequireExe:

                            return "Properties cannot be specified for library or module";

                        case IKVM.Internal.Message.ModuleCannotHaveClassLoader:

                            return "Cannot specify assembly class loader for modules";

                        case IKVM.Internal.Message.ErrorParsingMapFile:

                            return "Unable to parse remap file: {0}\n\t({1})";

                        case IKVM.Internal.Message.BootstrapClassesMissing:

                            return "Bootstrap classes missing and core assembly not found";

                        case IKVM.Internal.Message.StrongNameRequiresStrongNamedRefs:

                            return "All referenced assemblies must be strong named, to be able to sign the output assembly";

                        case IKVM.Internal.Message.MainClassNotFound:

                            return "Main class not found";

                        case IKVM.Internal.Message.MainMethodNotFound:

                            return "Main method not found";

                        case IKVM.Internal.Message.UnsupportedMainMethod:

                            return "Redirected main method not supported";

                        case IKVM.Internal.Message.ExternalMainNotAccessible:

                            return "External main method must be public and in a public class";

                        case IKVM.Internal.Message.ClassLoaderNotFound:

                            return "Custom assembly class loader class not found";

                        case IKVM.Internal.Message.ClassLoaderNotAccessible:

                            return "Custom assembly class loader class is not accessible";

                        case IKVM.Internal.Message.ClassLoaderIsAbstract:

                            return "Custom assembly class loader class is abstract";

                        case IKVM.Internal.Message.ClassLoaderNotClassLoader:

                            return "Custom assembly class loader class does not extend java.lang.ClassLoader";

                        case IKVM.Internal.Message.ClassLoaderConstructorMissing:

                            return "Custom assembly class loader constructor is missing";

                        case IKVM.Internal.Message.MapFileTypeNotFound:

                            return "Type '{0}' referenced in remap file was not found";

                        case IKVM.Internal.Message.MapFileClassNotFound:

                            return "Class '{0}' referenced in remap file was not found";

                        case IKVM.Internal.Message.MaximumErrorCountReached:

                            return "Maximum error count reached";

                        case IKVM.Internal.Message.LinkageError:

                            return "Link error: {0}";

                        case IKVM.Internal.Message.RuntimeMismatch:

                            return "Referenced assembly {0} was compiled with an incompatible IKVM.Runtime version\n" +

                                "\tCurrent runtime: {1}\n" +

                                "\tReferenced assembly runtime: {2}";

                        case IKVM.Internal.Message.CoreClassesMissing:

                            return "Failed to find core classes in core library";

                        case IKVM.Internal.Message.CriticalClassNotFound:

                            return "Unable to load critical class '{0}'";

                        case IKVM.Internal.Message.AssemblyContainsDuplicateClassNames:

                            return "Type '{0}' and '{1}' both map to the same name '{2}'\n" +

                                "\t({3})";

                        case IKVM.Internal.Message.CallerIDRequiresHasCallerIDAnnotation:

                            return "CallerID.getCallerID() requires a HasCallerID annotation";

                        case IKVM.Internal.Message.UnableToResolveInterface:

                            return "Unable to resolve interface '{0}' on type '{1}'";

                        case IKVM.Internal.Message.MissingBaseType:

                            return "The base class or interface '{0}' in assembly '{1}' referenced by type '{2}' in '{3}' could not be resolved";

                        case IKVM.Internal.Message.MissingBaseTypeReference:

                            return "The type '{0}' is defined in an assembly that is not referenced. You must add a reference to assembly '{1}'";

                        case IKVM.Internal.Message.FileNotFound:

                            return "File not found: {0}";

                        case IKVM.Internal.Message.RuntimeMethodMissing:

                            return "Runtime method '{0}' not found";

                        case IKVM.Internal.Message.MapFileFieldNotFound:

                            return "Field '{0}' referenced in remap file was not found in class '{1}'";

                        case IKVM.Internal.Message.GhostInterfaceMethodMissing:

                            return "Remapped class '{0}' does not implement ghost interface method\n" +

                                "\t({1}.{2}{3})";

                        default:

                            return "Missing Error Message. Please file a bug.";

                    }

                }

            }
        }


                // System.ExecutionEngineException
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

/// <summary>
///         Die Ausnahme, die bei einem internen Fehler im Ausführungsmodul der Common Language Runtime ausgelöst wird.
///          Diese Klasse kann nicht vererbt werden.
///       </summary>
[Serializable]
[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
[ComVisible(true)]
public sealed class ExecutionEngineException : SystemException
{
	/// <summary>
	///         Initialisiert eine neue Instanz der <see cref="T:System.ExecutionEngineException" />-Klasse.
	///       </summary>
	public ExecutionEngineException()
		: base(Environment.GetResourceString("Arg_ExecutionEngineException"))
	{
		SetErrorCode(-2146233082);
	}

	/// <summary>
	///         Initialisiert eine neue Instanz der <see cref="T:System.ExecutionEngineException" />-Klasse mit einer angegebenen Fehlermeldung.
	///       </summary>
	/// <param name="message">
	///           Die Meldung, in der der Fehler beschrieben wird.
	///         </param>
	public ExecutionEngineException(string message)
		: base(message)
	{
		SetErrorCode(-2146233082);
	}

	/// <summary>
	///         Initialisiert eine neue Instanz der <see cref="T:System.ExecutionEngineException" />-Klasse mit einer angegebenen Fehlermeldung und einem Verweis auf die innere Ausnahme, die diese Ausnahme ausgelöst hat.
	///       </summary>
	/// <param name="message">
	///           Die Fehlermeldung, in der die Ursache der Ausnahme erklärt wird.
	///         </param>
	/// <param name="innerException">
	///           Die Ausnahme, die die Ursache der aktuellen Ausnahme ist.
	///            Wenn der <paramref name="innerException" />-Parameter kein NULL-Verweis ist (<see langword="Nothing" /> in Visual Basic), wird die aktuelle Ausnahme in einem <see langword="catch" />-Block ausgelöst, der die innere Ausnahme behandelt.
	///         </param>
	public ExecutionEngineException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233082);
	}

	internal ExecutionEngineException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}











            */



            /// <summary>
            /// 
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="info"></param>
            /// <param name="context"></param>
            protected VGFFrameworkException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }


            /// <summary>
            /// FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="message"></param>
            /// <param name="innerException"></param>
            internal VGFFrameworkException(string message, SystemException innerException)
                : base(message, innerException)
            {
                //-------------------------------------------------------------
                // Set HRESULT Error Code for innerException.
                //-------------------------------------------------------------
                // ObjectError - 2147221504 plus 1000 for user defined error
                // number normal - here set 2147222600 for ObjectError
                //-------------------------------------------------------------
                VGFFrameworkExceptionSetCode(-2147000000);
            }

            /// <summary>
            /// FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="message"></param>
            internal VGFFrameworkException(string message)
                : base(message)
            {
                // Set HRESULT Error Code. HRESULTS are reserved by Microsoft,
                // so we set our Codes.
                // HRESULTs are everytime -minus error code values.
                VGFFrameworkExceptionSetCode(-2147000000);

            }

            /// <summary>
            /// FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="message"></param>
            /// <param name="errorCode"></param>
            internal VGFFrameworkException(int errorCode, string message)
                : base(message)
            {
                VGFFrameworkExceptionCode = errorCode;
            }

            /// <summary>
            /// Application how the FrameworkException occured.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionAppDomain
            {

                get
                {
                    // Get and display the friendly name of the default AppDomain.
                    return Thread.GetDomain().FriendlyName;
                }
            }

            /// <summary>
            /// Assembly how the Exception occured.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionAssemblyName
            {
                get
                {
                    return vai.VGFAsmFQName;
                }
            }

            /// <summary>
            /// Classname how the FrameworkException occured.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionClassName
            {

                get
                {
                    return sf.GetFileName().ToString();
                }
            }



            /// <summary>
            /// Get Username
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionUser
            {
                get
                {
                    return Environment.UserName;
                }
            }

            /// <summary>
            /// Get the Machinename of User
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionMachine
            {
                get
                {
                    return Environment.MachineName;
                }

            }

            /// <summary>
            /// Get the Methodname of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionMethodName
            {
                get
                {
                    return sf.GetMethod().ToString();
                }
            }

            /// <summary>
            /// Get current Process ID of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// Class Process from .NET Framework set in Class-Head
            /// with  and static, use so for all Classes and Methods...
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return>
            internal string VGFFrameworkExceptionProcessID
            {
                get
                {
                    return process.Id.ToString();
                }
            }

            /// <summary>
            /// Get current Processname of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// Class Process from .NET Framework set in Class-Head
            /// with  and static, use so for all Classes and Methods...
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return> 
            internal string VGFFrameworkExceptionProcessName
            {
                get
                {
                    return process.ProcessName;
                }

            } // END_OF_PROPERTY


            /// <summary>
            /// Get current Source Reason of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionReason
            {
                get
                {
                    return this.Source;
                }

            }


            /// <summary>
            /// Get current ThreadID of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal int VGFFrameworkExceptionThreadID
            {
                get
                {
                    return Environment.CurrentManagedThreadId;
                }

            }

            /// <summary>
            /// Query actual Stack watch information
            /// </summary>
            /// <!-- Author Tippolin 🧑 -->
            /// 
            /// <!-- Author Tippolin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return>
            internal string VGFFrameworkExceptionStackTraceInfo
            {
                get
                {
                    return Environment.StackTrace;
                }
            }

            /// <summary>
            /// Get the Cureent Process Id at occured Exception
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal uint VGFFrameworkExceptionGetCurrentProcessId
            {
                get
                {
                    return GetCurrentProcessId();
                }
            }

            /*
            internal uint TestFunction1
            {
                get
                {
                    uint _residue = uint.MaxValue;

                    /// ~ is an operator uint uint.operator(uint Value)
                    /// => lambda pointer
                    uint Crc => ~_residue;
                }
            }
            
            */
        
 
        } // END_OF_CLASS::VGFFrameworkException


        // String Helper

        /// <summary>
        /// Left of string
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// NOTE: Arrary's always begin with index 0
        /// </remarks> 
        /// <param name="source"></param>
        /// <param name="c"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFLeftOf(string source, char c)
        {
            string ret = source;

            int idx = source.IndexOf(c);

            if (idx != -1)
            {
                ret = source.Substring(0, idx);
            }

            return ret;

        } // end of method::LeftOf


        /// <summary>
        /// Start Microsoft Main Website directly
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFStartMicrosoftWebSite()
        {

            /*
             * 
             * try / catch / finally block
             * 
             * (finally is the ultimate resource free, if Exception or NOT !.
             *  cleanup all Windows Handles, Windows Resources, TWAIN-Scanner-Interface-Connect(if no disconnect, everytime open but access!) 
             *  close Files,
             *  
             *  )
             * 
             * 
             * catch (SystemException ex)when(ex is InvalidOperationException || ex is Win32Exception || ex is FileNotFoundException)
             * 
             * see new Exception with Operator || for more then one Exception Type, like Java Exceptions
             * 
             * or
             * 
             * return ex is NullReferenceException ||
             *        ex is StackOverflowException ||
             *        ex is OutOfMemoryException   ||
             *        ex is System.Threading.ThreadAbortException ||
             *        ex is System.Runtime.InteropServices.SEHException ||
             *        ex is System.Security.SecurityException;
             *
             *        
             *        
             */





            try
            {
                /* 
                 * Start Process/Thread with given Pathname and executable file .exe and start it direct!
                 * @ is a unicode sign, here for slashes \ backward slash, without  \\ (forward slash /)
                 * all unicode sign stand over Unicode Organization - www.unicode.org -
                 * 
                 * Unicode Handbook Version 12.0 at 05.03.2019
                 * For Germany, Autriche, Switzerland "German Umlauts".
                 * 
                 * For English Persons give english paper for "German Umlauts" by DIN-Norm (Deutsche Normierung)
                 * 
                 * Windows 10 May Update 2019 - 19H1 with new coding by Windows Editor by save under.
                 * Windows 10 Editor want save the File with own .suffix, so go this way:
                 * Filename - insert your own Filename
                 * Filetype - choice all Files
                 * Coding - UTF8
                 * While Windows 10 New Filesystem - Assocation with Filename (Prefix) and Suffixes
                 * means! set suffix to any application or filetype
                 * .dllfile = dll 
                 * .dllfile is an assembly DLL, is a little secure.
                 * set this with System-Tool assoc.exe on command line.
                 * 
                 * .accdb=Access.Application.16 is the new Database Microsoft Access Format .suffix .accdb
                 * (Microsoft Access Limit 255 Users, Database Size: )
                 * 
                 * (Microsoft SQL Server Limit x Users, Database Size: 535 Tebibyte - Tera binary byte (Terabyte is wrong))
                 * (Microsoft SQL Server Community Edition the same as Enterprise (Commerial) free download)
                 * 
                 * Microsoft SQL Server 2019 with:
                 * --------------------------------------------------------------------------------------------------------------------
                 * Apache Spark™ ist eine einheitliche Analyse-Engine für groß angelegte Datenverarbeitung. 
                 * Can run Spark Job's.
                 * 
                 * HDFS - Hadoop Distributed File System (HDFS) - Apache Hadoop
                 * The Apache™ Hadoop® project develops open-source software for reliable, scalable, distributed computing.
                 * The Apache Hadoop software library is a framework that allows for the distributed processing of large data sets 
                 * across clusters of computers using simple programming models. 
                 * It is designed to scale up from single servers to thousands of machines, 
                 * each offering local computation and storage. 
                 * Rather than rely on hardware to deliver high-availability, 
                 * the library itself is designed to detect and handle failures at the application layer, 
                 * so delivering a highly-available service on top of a cluster of computers, each of which may be prone to failures.
                 * 
                 * 
                 * 
                 * (IBM Db2 Developer Community Edition - after IBM Account free download)
                 * (Embacadero Interbase Community Edition - free download)
                 * (same Delphi and C++ Compiler and Builder - free download)
                 * 
                 * ------------------------------------------------------------------------------------------------------
                 * NEW in Microsoft Editor - Windows 10 OS-Build 18632 Fix
                 * ------------------------------------------------------------------------------------------------------
                 * UTF-8 with BOM (Byte Order Mark),
                 * ----------------------------------------------
                 * UTF-16 LE - Little Endian
                 * If the 16-bit units use little-endian order, 
                 * the BOM will appear in the 
                 * sequence of bytes as 0xFF 0xFE
                 * ----------------------------------------------
                 * UTF-16 BE - Big Endian
                 * If the 16-bit units are represented in 
                 * big-endian byte order, the BOM will appear 
                 * in the sequence of bytes as 0xFE 0xFF
                 * ----------------------------------------------
                 * and Ansi, UTF8 - remove Unicode and 
                 * Big Endian from Editor Coding.
                 * The Byte Order Mark (BOM) 
                 * is a Unicode character, 
                 * U+FEFF BYTE ORDER MARK (BOM), 
                 * whose appearance as a magic number at the 
                 * start of a text stream can signal several 
                 * things to a program reading the text:[1] 
                 * The byte order, or endianness, 
                 * of the text stream;
                 * ----------------------------------------------
                 * The fact that the text stream's encoding is Unicode, to a high level of confidence;
                 * Which Unicode encoding the text stream is encoded as.
                 * BOM use is optional.
                 * 
                 * Its presence interferes with the use of UTF-8 by software that does not 
                 * expect non-ASCII bytes at the start of a file but that could otherwise handle the text stream. 
                 * Unicode can be encoded in units of 8-bit, 16-bit, or 32-bit integers. 
                 * For the 16- and 32-bit representations, a computer receiving text from arbitrary sources 
                 * needs to know which byte order the integers are encoded in.
                 * 
                 * The BOM is encoded in the same scheme as the rest of the document and 
                 * becomes a non-character Unicode code point if its bytes are swapped. 
                 * 
                 * Hence, the process accessing the text can examine these first few bytes to determine the endianess, 
                 * without requiring some contract or metadata outside of the text stream itself. 
                 * 
                 * Generally the receiving computer will swap the bytes to its own endianess, 
                 * if necessary, and would no longer need the BOM for processing. 
                 * The byte sequence of the BOM differs per Unicode encoding
                 * (including ones outside the Unicode standard such as UTF-7, see table below), and 
                 * none of the sequences is likely to appear at the start of text streams stored in other encodings. 
                 * 
                 * Therefore, placing an encoded BOM at the start of a text stream can indicate 
                 * hat the text is Unicode and identify the encoding scheme used. 
                 * This use of the BOM character is called a "Unicode signature".
                 * 
                 * 
                 * Next New Windows 10 - Open Branch - 2020 more Unicode .
                 * emoij's, kat-emoij's with chat symbols, symbols.
                 * OS-Build at Time 18875 - 2020 - 20H1 - on FlightHub.
                 * 
                 * 
                 * All New Projects in Visual Studio 2019 Version 16.0.3 saved with -UTF16- .csproj....
                 * UTF-16  by Common Language Runtime In/Out Operations.
                 * 
                 * ------------------------------------------------------------------------------------
                 * International System of SI Units from 20 May 2019 comes into force.
                 * International Bureau for Measurement and Weights in Paris.
                 * ------------------------------------------------------------------------------------
                 * means Ade basis-units, Welcome natural constants !.
                 * New Definition for:
                 * Ampere, Kelvin, Mol, Candela, Second, Meter, Kilogram.
                 * 
                 * 
                 * 
                 * ------------------------------------------------------------------------------------
                 * TIPPOTIP: 
                 * In our Documentation, Whitepaper from Dr. Knittel -CBM- English Translation for this.
                 * 
                 * ---------------------------------------------------------wuri as constant uri string
                 * ---------------------------------------------------------set instance with Class Uri
                 * ---------------------------------------------------------.Original String call 
                 */

                // Start Process with Microsoft Edge Webbrowser and given Website as Original String by Class URI in namespacw System.
                Process.Start("microsoft-edge:"+ wuri.OriginalString);
            }
            // if the Process does't start, throw Excepetionhandler
            // new writing with Operator || double vertical bar, like Java Exceptions
            // Process.Start have four Exceptions.
            catch (SystemException ex) when (ex is InvalidOperationException || ex is Win32Exception || ex is FileNotFoundException)
            {
                // I have written for .NET the good old MessageBox with intellisense window by STYLES
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }
            return true;

        } // end of Method::VGFStartMicrosoftWebSite

        /// <summary>
        /// Start GitHub Projectsite
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        /// 
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Change bool to string, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// </remarks> 
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// returned true or false as Literal String True/False
        /// </returns>
        public static string VGFStartGitHubProjectSite()
        {
            try
            {
                // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                // string microsoft-edge:websitename or URL
                Process.Start("microsoft-edge:" + vgfdevTipplinVGFGitHub.OriginalString);
                
                // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                // but must change bool in Method-declaration into string as returned datatype.
                return true.ToString();
            }
            catch (InvalidOperationException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false.ToString();
            }

        } // end of Method::VGFStartGitHubProjectSite

        /*

         static bool VGFIsInRole(string Role)
        {
            //return Principal.IsInRole(Role);



        }

        /// <summary
        /// Callback method for the OnOperationStart event.
        /// </summary
        public static void CountOperationCalls(ICallable op, IApplyData data)

        {

            if (_operationsCount.ContainsKey(op))

            {

                _operationsCount[op]++;

            }

            else

            {

                _operationsCount[op] = 1;

            }

        }

        */

        /// <summary>
        /// Current User Is Administrator
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        /// Both instance in Class-Head !.
        /// Class WindowsPrincipal
        /// Class WindowsIdentity
        /// p is the instancevariable with member is class.
        /// But note WindowsBuiltInRole is an Enumerator ! no class,
        /// so must set in ().
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Visual C#
        /// Change bool to string by return, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// </remarks>
        /// <returns>
        /// Windows 10 Operation System have then 9 Roles in Windows Membership,
        /// System-Tool-command: net localgroup - commandline
        /// 
        /// * Administratoren
        /// * Benutzer
        /// * Distributed COM-Benutzer
        /// * Ereignisprotokollleser
        /// * Gäste
        /// * Hauptbenutzer
        /// * Hyper-V-Administratoren
        /// * IIS_IUSRS
        /// * Kryptografie-Operatoren
        /// * Leistungsprotokollbenutzer
        /// * Leistungsüberwachungsbenutzer
        /// * Netzwerkkonfigurations-Operatoren
        /// *
        /// * PVGF - Project Visual Galaxy Framework - Benutzerverwaltung
        /// * angelegt im System-tool netplwiz.exe unter Benutzer und Gruppe.
        /// * netplwiz.exe mit Windows 10 Web Password Tresor all your Web Password are saved.
        /// *
        /// * Remotedesktopbenutzer
        /// * Remoteverwaltungsbenutzer
        /// * Replikations-Operator
        /// * Sicherungs-Operatoren
        /// * Ssh Users
        /// * System Managed Accounts Group
        /// * WmsOperators
        /// * Zugriffssteuerungs-Unterstützungsoperatoren
        /// </returns>
        public static string VGFIsAdmin()
        {
            // p as class instance holder, define in Class Head as static for all others.
            return p.IsInRole(WindowsBuiltInRole.Administrator).ToString(); 
        }

        /// <summary>
        /// Is User
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        /// ! NOTE ! User has no all Rights on Computer as the Administrator.
        /// Windows 10 make sure same Folders, User can't open it !.
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Change bool to string, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// normally 0 or 1 as return.
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsUser()
        {
            return p.IsInRole(WindowsBuiltInRole.User).ToString();
        }

        /// <summary>
        /// Is Guest
        /// </summary>
        /// <!-- Author Tippolin 🧑-->
        /// Guest have no rights, same Guest Roles can set in Windows 10.
        /// <!-- Author Tippolin 🧑-->
        /// <remarks>
        /// Change bool to string, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsGuest()
        {
            return p.IsInRole(WindowsBuiltInRole.Guest).ToString();
        }

        /// <summary>
        /// Account Operator can add User to System with new Account,
        /// Administrator same, Users and Groups.
        /// While Windows 10 Professional is an Multi User System,
        /// one User or more on one Computer/PC.
        /// Windows 10 Professionl have  Database 'Resent',
        /// for Services, Recovery,
        /// Limit Database size 16 Terabyte. (MS SQL Server 2017 524 Terabyte.)
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsAccountOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.AccountOperator).ToString();
        }

        /// <summary>
        /// Backup Operator can make Backup, full.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// 
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsBackupOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.BackupOperator).ToString();
        }

        /// <summary>
        /// Replicator Operator can make File Replications.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// File Replication in domain
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <returns>
        /// NOTE: returned True or False as string
        /// </returns>
        public static string VGFIsReplicatorOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.Replicator).ToString();
        }

        /// <summary>
        /// System Operator manage particular computer.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// particular computer settings
        /// <!-- Author Tippo 🧑 -->
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsSystemOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.SystemOperator).ToString();
        }

        /// <summary>
        /// Print Operator can take control of Printer
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// manage Printer or Printers in Network.
        /// <!-- Author Tippo 🧑 --> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsPrintOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.PrintOperator).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// NOTE: bool true or false here returned as string True or False
        /// Method-declaration set string, not bool !.
        /// </returns>
        internal static string VGFUseFeatureMethod()
        {
            if(VGFRegisteredUser() == false)
            {
                return false.ToString();
            }
            else
            {
                return true.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static bool VGFRegisteredUser()
        {
            /*
             * Registry prüfen, ob Methode benutzt werden darf, 
             * nur registierte Benutzer !.
             * 
             */
            return false;
        }







    } // CLASS_END::VGFCore


    /// <summary>
    /// A class that helps do interop calls that take/return buffers.
    /// </summary>
    /// <!-- Author Tipplin 🧑 -->
    /// 
    /// <!-- Author Tipplin 🧑 -->
    /// <remarks>
    /// This holds onto a StringBuilder and an int that represent the
    /// arguments typically passed to such functions.
    /// DoBufferAction's overloads contain the necessary buffer sizing
    /// logic for doing calls that take string buffers.
    /// </remarks>
    public class VGFCoreBufferData
    {

        internal static StringBuilder Buffer = null;

        /// <summary>
        /// The length of the buffer, exposed so that it can be passed by ref
        /// </summary>
        internal static int Length = 0;

        /// <summary>
        /// Sets the length based on the current capacity of the buffer
        /// </summary>
        public static void VGFCoreSetLength()
        {
            Length = Buffer == null ? 0 : Buffer.Capacity;
        }

        /// <summary>
        /// Creates a buffer with a default initial capacity.
        /// </summary>
        static VGFCoreBufferData()
        {
            Buffer = new StringBuilder();
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates a buffer with an initial capacity
        /// </summary>
        /// <param name="capacity">The initial capacity of the buffer</param>
        public VGFCoreBufferData(int capacity)
        {
            Buffer = new StringBuilder(capacity);
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates a buffer containing the specified string and appropriate capacity.
        /// Useful for in/out parameters.
        /// </summary>
        /// <param name="str">The initial contents of the buffer</param>
        public VGFCoreBufferData(string str)
        {
            Buffer = new StringBuilder(str);
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates a buffer containing the specified string and with a specified capacity
        /// </summary>
        /// <param name="str">The initial contents of the buffer</param>
        /// <param name="capacity">The initial capacity of the buffer</param>
        public VGFCoreBufferData(string str, int capacity)
        {
            Buffer = new StringBuilder(str, capacity);
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates/grows the  buffer as necessary to accomodate the current.
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFCoreSetCapacity()
        {
            if (Buffer == null)
            {
                Buffer = new StringBuilder(Length);
                return true;
            }
            else if (Buffer.Capacity < Length)
            {
                Buffer.Capacity = Length;
                return true;
            }
            return false;
        }

        
        

       

        
    } // END_OF_CLASS::VGFCoreBufferData















    // Visual Studio 2019 Productivity Features
    //
    // Control-Shift V - Clipboard
    // Multi Caret - marked all same names you inserted search box
    // Control Q is the general big search
    // Show all Class Members with F12
    // Robert Green and Kendra Havens
    // https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-Productivity-Tips


    /*
     * on sequents
     * Navigate backward[03:55]
     * Solution Explorer tips[04:55]
     * Editor context menu(Alt + `) [06:40]
     * Keyboard command mapping[09:30]
     * Right-click on.sln  Open With [13:00]
     * Clipboard History (Ctrl + Shift + V) [14:10]
     * Go to recent files(Ctrl + T + R) [15:10]
     * Go to last edit location(Ctrl + Shift + Backspace)[15:20]
     * Multi-caret editing[16:10]
     * Using Git in Team Explorer[19:00]
     * Code snippets(Ctrl + K, Ctrl + X) [24:55]

        */
    /*  -------------------------------------------------------------------------------
     *  Windows 10 Professional Edition with more Security Protections:
     *  Folder, Data, System, Network and avantage Windows Firewall,
     *  Windows 10 Web Password Tresor with Security Query
     *  input Password(Logon Screen) then can blend in your password.
     *  Windows 10 save all Web Passwords for you.
     *  System-Tool: netplwiz.exe on command area.
     *  -------------------------------------------------------------------------------
     *  
     *  
     *  -------------------------------------------------------------------------------
     *  Windows 10 OS - Memory health / Kernel Isolation Protection
     *  May Update 2019 - only the (System-)Administrator can set Option on/off.
     *  ! ATTENTION !
     *  If set on by Kernel Isolation, he blend the toggle button, no return to off !.
     *  the only way for return off is the registry with 
     *  registry key for Kernel Isolation, set dword value 1 to 0.
     *  HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\DeviceGuard\
     *  Scenarios\HypervisorEnforcedCodeIntegrity
     *  If ON!, runs the Windows Device Guard automatic, and 
     *  search for old device drivers, if to old the Windows Updater 
     *  stop the new great Update, no change!.
     *  -------------------------------------------------------------------------------
     *  Memory integrity is a high-performance, the hardware virtualization,
     *  Windows Hyper-V hypervisor for the protection of Windows kernel-mode processes 
     *  before inserting and executing malicious or not verified code uses.
     *  Code integrity checks are performed in a secure environment that protects 
     *  against attacks from malicious software.
     *  Page permissions for kernel mode are set by the Hyper-V hypervisor and managed.
     *  Memory integrity helps to block many types of malicious software on computers 
     *  that are running Windows 10 and Windows Server 2016.
     *  --------------------------------------------------------------------------------
     *  IIS is the Web Server
     *  iisexpress.exe start automatic workloads
     *  Starting IIS Express ...
     *  Successfully registered URL "http://localhost:8080/" 
     *  for site "WebSite1" application "/"
     *  Registration completed for site "WebSite1"
     *  IIS Express is running.
     *  Enter 'Q' to stop IIS Express
     *  
     *  
     *  
     *  --------------------------------------------------------------------------------
     */







    /* #Developer Info#====================================================================================================
     * 
     * --------------------------------------------------------------------------------------------------------------------
     * Title...........:
     * --------------------------------------------------------------------------------------------------------------------
     * Author..........: 
     * --------------------------------------------------------------------------------------------------------------------
     * Language........: 
     * --------------------------------------------------------------------------------------------------------------------
     * Description.....: 
     * --------------------------------------------------------------------------------------------------------------------
     * Remarks.........:
     * --------------------------------------------------------------------------------------------------------------------
     * Note............:
     * --------------------------------------------------------------------------------------------------------------------
     * Author(s).......:  
     * --------------------------------------------------------------------------------------------------------------------
     * 
     * ====================================================================================================================
     * #CURRENT#
     * ====================================================================================================================
     * _StringSize.....: Returns size of rectangle required to display string - maximum width can be chosen
     * 
     * 
     * ====================================================================================================================
     * #_USE_ONLY#
     * ====================================================================================================================
     * 
     * 
     * 
     * 
     * 
     * ====================================================================================================================
     * #FUNCTION#
     * ====================================================================================================================
     * Name............: 
     * --------------------------------------------------------------------------------------------------------------------
     * Description ....: 
     * --------------------------------------------------------------------------------------------------------------------
     * Syntax .........: 
     * --------------------------------------------------------------------------------------------------------------------
     * Parameters .....: 
     * --------------------------------------------------------------------------------------------------------------------
     * Requirement(s)..: 
     * --------------------------------------------------------------------------------------------------------------------
     * Return values...:
     * --------------------------------------------------------------------------------------------------------------------
     * Author .........: 
     * --------------------------------------------------------------------------------------------------------------------
     * Modified .......:
     * --------------------------------------------------------------------------------------------------------------------
     * Remarks ........: 
     * 
     * 
     * 
     * 
     * -------------------------------------------------------------------------------------------------------------------- 
     * Related ........:
     * --------------------------------------------------------------------------------------------------------------------
     * Link ...........:
     * --------------------------------------------------------------------------------------------------------------------
     * Example ........:
     * --------------------------------------------------------------------------------------------------------------------
     * 
     * 
     * ====================================================================================================================
     * 
     * --------------------------------------------------------------------------------------------------------------------
     * #_USE_ONLY#
     * --------------------------------------------------------------------------------------------------------------------
     * Author..........:
     * --------------------------------------------------------------------------------------------------------------------
     * Name............: _StringSize_DefaultFontName
     * --------------------------------------------------------------------------------------------------------------------
     * Description.....: Determines Windows default font
     * --------------------------------------------------------------------------------------------------------------------
     * Syntax..........: _StringSize_DefaultFontName()
     * --------------------------------------------------------------------------------------------------------------------
     * Parameters......: None
     * --------------------------------------------------------------------------------------------------------------------
     * Return values...: Success - Returns name of system default font
     * --------------------------------------------------------------------------------------------------------------------
     * Failure-Returns.:
     * --------------------------------------------------------------------------------------------------------------------
     * Author..........: Melba23, based on some original code by Larrydalooza
     * --------------------------------------------------------------------------------------------------------------------
     * Modified........:
     * --------------------------------------------------------------------------------------------------------------------
     * Remarks.........: This function is used ly by _StringSize
     *
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * ====================================================================================================================

    ----------------------------------------------------------------
    ONLY for Students and good boys Insiders not for bad brain.
    Like Tipplin is good boy.
    ----------------------------------------------------------------
    Windows Research Kernel Code - Sourcecode - 2016 - all .c files:
    ----------------------------------------------------------------
    The primary NTOS source components included in the 
    WRK are organized as follows:
    (Windows 10 - 2016 - Operation System - Kernel Source Code)
    ----------------------------------------------------------------
    cache\  - cache manager
    config\ - registry implementation
    dbgk\   - user-mode debugger support
    ex\     - executive functions (kernel heap, synchronization, time)
    fsrtl\  - file system run-time support
    io\     - I/O manager
    ke\     - scheduler, CPU management, low-level synchronization
    lpc\    - local procedure call implementation
    mm\     - virtual memory manager
    ob\     - kernel object manager
    ps\     - process/thread support

    se\     - security functions
    accessck.c

    This Module implements the access check procedures.  Both NtAccessCheck
    and SeAccessCheck check to is if a user (denoted by an input token) can
    be granted the desired access rights to object protected by a security
    descriptor and an optional object owner.  Both procedures use a common
    local procedure to do the test.
    SepAccessCheck 

    wmi\    - Windows Management Instrumentation

    inc\    - NTOS-only include files
    rtl\    - kernel run-time support
    init\   - kernel startup

    The NTOS kernel implements the basic OS functions
    for processes, threads, virtual memory and cache managers, I/O management,
    the registry, executive functions such as the kernel heap and synchronization,
    the object manager, the local procedure call mechanism, the security reference
    monitor, low-level CPU management (thread scheduling, Asynchronous and Deferred
    Procedure calls, interrupt/trap handling, exceptions), etc.

    The NT Hardware Abstraction Layer, file systems, network stacks, and device
    drivers are implemented separately from NTOS and loaded into kernel mode
    as dynamic libraries.  Sources for these dynamic components are not included
    in the WRK, but some are available in various development kits published
    by Microsoft, such as the Installable File System (IFS) Kit and the
    Windows Driver Development Kit (DDK).
    -------------------------------------------------------------------------------
    Die Java Virtual Runtime Machine
    https://www.artima.com/insidejvm/ed2/jvm8.html

    Table of Contents 
    Links to reprints of each chapter of the book:

    Chapter 1 -- "Introduction to Java's Architecture".
    Chapter 2 -- "Platform Independence".
    Chapter 3 -- "Security".
    Chapter 4 -- "Network Mobility".
    Chapter 5 -- "The Java Virtual Machine".
    Chapter 6 -- "The Java Class File".
    Chapter 7 -- "The Lifetime of a Type".
    Chapter 8 -- "The Linking Model".
    Chapter 9 -- "Garbage Collection".
    Chapter 10 -- "Stack and Local Variable Operations".
    Chapter 11 -- "Type Conversion".
    Chapter 12 -- "Integer Arithmetic".
    Chapter 13 -- "Logic".
    Chapter 14 -- "Floating Point Arithmetic".
    Chapter 15 -- "Objects and Arrays".
    Chapter 16 -- "Control Flow".
    Chapter 17 -- "Exceptions".
    Chapter 18 -- "Finally Clauses".
    Chapter 19 -- "Method Invocation and Return".
    Chapter 20 -- "Thread Synchronization".


    Stack Walking in the .NET Runtime
    https://mattwarren.org/2019/01/21/Stackwalking-in-the-.NET-Runtime/



    Java® Platform, Standard Edition & Java Development Kit 12
    Version 12 API Specification
    https://docs.oracle.com/en/java/javase/12/docs/api/index.html

    Java® Platform, Standard Edition & Java Development Kit 13
    Version 13 API Specification


    Java® Platform, Standard Edition & Java Development Kit
    Version 12 API Specification
    Runtime Exception
    https://docs.oracle.com/en/java/javase/12/docs/api/java.base/java/lang/RuntimeException.html





    Constructs a new runtime exception with the specified detail message.
    public RuntimeException​(String message)

    Constructs a new runtime exception with the specified detail message and cause. 
    Note that the detail message associated with cause is not automatically incorporated in this runtime exception's detail message.
    public RuntimeException​(String message, Throwable cause)

    Constructs a new runtime exception with the specified cause and a detail message of (cause==null ? null : cause.toString()) 
    (which typically contains the class and detail message of cause). 
    This constructor is useful for runtime exceptions that are little more than wrappers for other throwables.
    public RuntimeException​(Throwable cause)

    Constructs a new runtime exception with the specified detail message, 
    cause, suppression enabled or disabled, and writable stack trace enabled or disabled.
    protected RuntimeException​(String message,
                           Throwable cause,
                           boolean enableSuppression,
                           boolean writableStackTrace)

    Parameters:
    message - the detail message.
    cause - the cause. (A null value is permitted, and indicates that the cause is nonexistent or unknown.)
    enableSuppression - whether or not suppression is enabled or disabled
    writableStackTrace - whether or not the stack trace should be writable

    StringBuilder Buffers:
    StringBuilder sb = new StringBuilder(min int32, max int32);
    Standard Buffer  by Visual C# is 16 chars, only StringBuilder sb = new StringBuilder();
    So make sure the string is not longer as 16 Chars, is longer he cut him !.
    or
    StringBuilder sb = new StringBuilder(255, 8148);
    So is the string longer as 255 chars he expand automatic to maximal Capacity here 8148.
    use same for C++ Buffers in C#.

    [flags()]
     enum StringBuffer
    {
        = 256,
        = 512,
        = 1024,
        = 2048,
        = 4096,
        = 8148,
        =
        =
        =
        =
        =
        = 2147483647 -1 set, while is greather is OutOfRangeException


    }



    */


    /// <summary>
    /// 
    /// </summary>
    public static class VGFCoreUrls
    {
        /*
        Handling and raising events
        Raise and Consume Events
        Handle Multiple Events Using Event Properties
        */
        //https://docs.microsoft.com/en-us/dotnet/standard/events/

        // .NET API Browser
        // https://docs.microsoft.com/en-us/dotnet/api/index

        /*
         * Welcome to the.NET API Browser – 
         * your one-stop shop for all.NET-based APIs from Microsoft.Start 
         * searching for any managed APIs by typing in the box below.
         * 
         * You can learn more about the API Browser in our blog post.
         * If you have any feedback, 
         * create a new issue in the MicrosoftDocs/feedback repo on GitHub.
         * 
         * Select Version
         * 
         * All APIs
         * all about.NET others
         * 
         * 
         * Identity- und Access-Management (IAM) 
         * 
         * 
         * 
         * Privileged Access Management (PAM)
         * 
         * Identity Solution for Identity and Access Management
         * Identity Solution eliminate the complexities and 
         * time-consuming processes often required to govern identities, 
         * manage privileged accounts and control access.
         * 
         * Active Roles
         * Password Manager
         * Identity Manager
         * 
         * 
         */

        #region ### URI's as Constants ##

        /*
         * with Class Uri from namespace System.Uri
         * set all uri's do you need
         * create instance static Uri wuri = new Uri("orginalstring uri");
         * / or // are forward slashs - HMTL source
         * \ or \\ backward slashs - Windows Directories
         * 
         * 
         */

        /*
        * Additional sources (repositories) to search for this pod.
        *
        * Since order is important sources specified in this list
        * are interleaved across each Pod added to the resolver.
        * e.g Pod1.source[0], Pod2.source[0] ...
        *    Pod1.source[1], Pod2.source[1] etc.
        *
        * See: https://guides.cocoapods.org/syntax/podfile.html#source
        */

        /// <summary>
        /// 
        /// </summary>
        public static List<string> sources = new List<string>() {

            // set index 0 of nullstring, we begin with Index 1
            "null",
            // index 1
            "https://github.com/CocoaPods/Specs.git",
            // index 2
            "https://github.com/Tipplin/VGF"

        };

        /// <summary>
        /// 
        /// </summary>
        public static DateTime Timestamp { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public static string Time => Timestamp.ToString("hh:mm tt");

        /*
        /// <summary>
        /// 
        /// </summary>
        public static string Text = GetValue(id, TextSnippetValues);
        /// <summary>
        /// 
        /// </summary>
        public static string UserName = GetValue(id, UserNameValues);
        /// <summary>
        /// 
        /// </summary>
        public static string Image = GetValue(id, ImagesValues);
        */

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="index"></param>
        /// <param name="values"></param>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetValue(int index, string[] values)
        {
            return values[index % values.Length];
        }









        /// <summary>
        /// 
        /// </summary>
        internal static string[] TextSnippetValues = new string[]
        {
            // index 0
            "What time did the man go to the dentist?",
            // index 1
            "I don't know.",
            // index 2
            "Tooth hurt-y.",
            // index 3
            "Did you hear about the guy who invented Lifesavers?",

            "No.",

            "They say he made a mint.",

            "A ham sandwich walks into a bar and orders a beer. Bartender says, 'Sorry we don't serve food here.'",

            "Whenever the cashier at the grocery store asks my dad if he would like the milk in a bag he replies, 'No, just leave it in the carton!'",

            "Why do chicken coops only have two doors?",

            "I don't know, why?",

            "Because if they had four, they would be chicken sedans!",

        };

        /// <summary>
        /// 
        /// </summary>
        internal static string[] UserNameValues = new string[]
        {
            // index 0
            "Parent",
            // index 1
            "Child",

        };

        /// <summary>
        /// 
        /// </summary>
        internal static string[] ImagesValues = new string[]
        {
            // index 0
            "ms-appx:///images/blueuser.png",
            // index 1
            "ms-appx:///images/reduser.png",

        };

        internal static string VGFGetInternalMessage(string MethodName, int data)
        {
            string msg;


            switch (data)
            {
                case 1:
                    msg = "close";
                    break;

                case 2:
                    msg = "Illegal Call, don't call this Method {0} directly !.\n" + MethodName;
                    msg += "Illegal Calls throw an exception IllegalCallMethodException !.";
                    break;
                default:
                    msg = "nothing";
                    break;
            }

            return msg;

        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static string VGFURIWebsiteArray()
        {
            return sources.IndexOf("1").ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArrayItem"></param>
        /// <returns></returns>
        internal static string VGFURIWebsiteArray2(string ArrayItem)
        {
            return sources.IndexOf(ArrayItem).ToString();
        }

        /// <summary>
        /// VGFWaitSeconds
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Method with optional pararmeters MessageText and MessageTitle,
        /// paramter milliseconds must be have an Value !.
        /// See in code asterics operator for an Call or 
        /// show MessageBox after Sleep an thread in milliseconds
        /// <!-- Author Tipplin -->
        /// <param name="milliseconds">Set milliseconds value</param>
        /// <param name="MessageText">Optional set Text for MessageBox</param>
        /// <param name="MessageTitle">Optional set Title for MessageBox</param>
        /// <remarks>
        /// Optional Parameters in C# - 
        /// string MessageText="" as null value, can be change in Call or in code.
        /// </remarks>
        public static void VGFWaitSeconds(uint milliseconds, string MessageText = "", string MessageTitle = "")
        {

            if (milliseconds <= 0 || milliseconds > 10000)
            {
                VFLMsgBox("Arguments out of range !", "VGFWaitSeconds::Parameter:milliseconds", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMExit(EXIT_CODES.ERROR_BAD_ARGUMENTS);
            }
            // Check Optional Parameters, if the values are null ?
            else if (MessageText.Length == 0 || MessageTitle.Length == 0)
            {
                // Operator * is an uint uint.operator(uint left, uint right)
                // Sleep with Operator * asterics for an Call or MessageBox show with Text and Title.
                // Sleep waitable with given milliseconds, after timeout than calls the Method, or show MessageBox
                Sleep(milliseconds * VFLMsgBox("undefine MessageText", "undefine MessageTitle", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal));
            }
            else
            {
                Sleep(milliseconds * VFLMsgBox(MessageText, MessageTitle, STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal));
            }
        }

        /// <summary>
        /// Get World Wide Country Name
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="ArrayItem">Index Begin with 1 to 190 ABC sorted</param>
        /// <remarks>
        /// Array's in Visual C# begins everytime with Index 0,
        /// want begin by 1, so make Index 0 = "",
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetWorldWideCountry(int ArrayItem)
        {
            return VGFCore.VGFWorldWide.VGFWorldCountries.ElementAt(ArrayItem);

        }

        /// <summary>
        /// Get the Name of USA State
        /// </summary>
        /// <param name="ArrayItem"></param>
        /// <returns></returns>
        public static string VGFGetShortNameOf_USAState(int ArrayItem)
        {
            return VGFCore.VGFWorldWide.VGFUSStates.ElementAt(ArrayItem);

        }

        /* without access modi public, internal, protected, private
         * Visual C# insert private automatic.
         * ! ATTENTION ! private have now 7.3 an protection degree.
         * No access !
         */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFExperitmenalMethod(int e, int Index)
        {
            switch (e)
            {
                case 0:
                    return e.ToString(Environment.MachineName);
                    
                case 1:
                    return e.ToString(Environment.UserName);
                case 2:
                    return "Type '{0}' is not writable" + Index.ToString();
                default:
                    NRMExit(EXIT_CODES.ERROR_INVALID_INDEX);
                    return "ERROR_INVALID_INDEX";
                    

            }
           
        }


        /// <summary>
        /// Uri Microsoft Website🌀
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// Class Uri form namespace System
        /// NOTE: without accessmofi public, all private with degree of protection,
        /// private now is standard in Visual C# without set.
        /// no access from outside.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// @ unicode sign, so only one slash !
        /// 
        /// See Microsoft have change the dir for Webbrowser Edge and inside works the Chromium Engine,
        /// New is the Translator for Languages, so you can translate Websites and others.
        /// New is Virus Scan for all Download Files, TAB Downloads View, cancel Donwload,
        /// 
        /// C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
        /// 
        /// Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", wuri.OriginalString);
        /// 
        /// wuri.OrignalString is the string for the Website Microsoft in German.
        /// </remarks>
        public static Uri wuri = new Uri("https://www.microsoft.com/de-de/");

        /// <summary>
        /// Microsoft TV Channel 9 with many Video's for all Developer.
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// Uri's as constant for OrginalString
        /// 
        /// Attention ! 
        /// without access modifier set internal private with degree of protection, 
        /// no external access.
        /// Either internal or public take.
        /// have forgotten by static uri... access modi public.
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", wuri.OriginalString);
        /// start process with NEW Webbrowser Microsoft Edge and directly Website channel9.msdn.com
        /// this is the Microsoft TV with TV Studios in Redmond, like CNN or others.
        /// 
        /// Most when LIVE Shows = LIVE Streaming, in Pause shows the People of Studio (steady cam)
        /// everything can send e-mails in Studio with Questions to Presenter to Developer and so...
        /// Developer in Studio: Windows Team, Visual Studio Team and more...
        /// Any Week news from Microsoft, most by Christina Warren 'Speech machine gun'.
        /// ----------------------------------------------------------------------------------------
        /// Directly call with Microsoft Edge Webbrowser:
        /// Process.Start("icrosoft-Edge:" + wuri1.OrginalString);
        /// wuri1.OrignalString is the string for the Website.
        /// ----------------------------------------------------------------------------------------
        /// </remarks>
        public static Uri wuri1 = new Uri("https://channel9.msdn.com/");


        /// <summary>
        /// Our secure 📬mailbox for anonymous messages in case 
        /// of rule violations our 🚻 Community Members.
        /// </summary>
        public static Uri vgfCommunityInvestigativ = new Uri("https://vgfc.org/community/investigativ");

        // &, () is not allwoed in XML Comment Block set +

        /// <summary>
        /// Community Helpful+Respectful
        /// </summary>
        public static Uri vgfCommunityHelp = new Uri("https://vgfc.org/community/helpfulrespectful");

        /// <summary>
        /// Website to 🧑 Tipplin 🧑 by Project Visual Galaxy Framework
        /// </summary>
        public static Uri vgfdevTipplinVGFGitHub = new Uri("https://github.com/Tipplin/VGF");

        /// <summary>
        /// Website to 🧑 Tipplin 🧑 by VGF Community
        /// </summary>
        public static Uri vgfdevTipplinVGFCommunity = new Uri("https://vgfc.org/community/open");

        /// <summary>
        /// Website to VGF KernelTeam by 🧑 Tipplin 🧑
        /// </summary>
        public static Uri vgfdevTipplinVGFKernelTeam = new Uri("https://vgfc.org/community/kernelteam/tippo");

        /// <summary>
        /// Website to VGF KernelTeam by 🦁 Tiger 🦁
        /// </summary>
        public static Uri vgfdevTigerVGFKernelTeam = new Uri("https://www.vgfc.org/community/kernelteam/tiger");



        /// <summary>
        /// 🧑 Tipplin 🧑 E-mail adress for send mail to me!
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// Base E-mail-adress
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// For E-Mail Method directly to me as Author.
        /// -------------------------------------------------------------------
        /// For Developer:
        /// -------------------------------------------------------------------
        /// All defined Attribute's, 
        /// all Attribute have the full set of regular expressions:
        /// so you can check/proof the given value/string.
        /// 
        /// namespace System.ComponentModel.DataAnnotations
        /// 
        /// CreditCardAttribute - Mastercard, Visa, American express card
        /// (Visa is first one the World.)
        /// EmailAddressAttribute - check email adress - allowed/not allowed characters
        /// MinLengthAttribute - set the minimum length of a string
        /// MaxLengthAttribute - set the maxnimum length of a string
        /// PhoneAttribute 
        /// UrlAttribute 
        /// RangeAttribute 
        /// 
        /// </remarks>
        public static Uri vgfdevTipplinVGFMail = new Uri("kurschristian@gmail.com");



        #endregion




    }  // END::OF:: class URLS

    #endregion

} // NAME_SPACE_END::Visual.Galaxy.Framework.Core
