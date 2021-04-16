----                                    

## TIPPO' s Insider Tip's for Visual Studio
----
#### Eine Assembly kann auch internal geschrieben werden - Klassen und Methoden usw. -
#### damit Sie ausserhalb benutzt werden kann in einer anderen Assembly , folgendes:
----
#### Attribute setzen:

#### [assembly: InternalsVisibleTo("AssemblyName")]
##### Hier 'AssemblyName' die andere, die die Klassen und Methoden usw. benutzen möchte.

##### // Friend Assemblies  
##### [assembly:InternalsVisibleTo("AssemblyName, PublicKey= xxx")];  

##### [assembly: DependencyAttribute("Visual.Resource.Library", LoadHint.Always)]
##### [assembly: DependencyAttribute("Visual.Resource.Library", LoadHint.Sometimes)]
##### Ruft den LoadHint -Wert, der angibt, wann eine Assembly eine Abhängigkeit laden.
----
#### pragmas for other Vendors Operation System --- System DLL's ---------------

####  #if directives:
##### from part of .NET Framework sourcecode
#### #if FEATURE_PAL --> Platform Abstraction Layer

#### #if !PLATFORM_UNIX ----> Inside Windows Operation System as subsystem

##### directly Unix calls, and more with activation.
##### Unix subsystem in Windows Kernel.

##### #else // !PLATFORM_UNIX

##### #if _MAC

##### #else

##### #endif

----
#### Windows 10 Professional is a Multi User system !
##### One or more Users on one PC/Computer !.
##### Windows Starts he show the Lockscreen for LogIN
##### with name and option Photo (scan in)

----

##### // Apple dynamic link library .lib is same as .dll by Microsoft
##### // often written in C/C++ with exported Functions,
##### // can use in .NET
#### #if __APPLE__ ----> Apple pragma
        internal const String DLLPREFIX = "lib";------> Apple Library
        internal const String DLLSUFFIX = ".dylib";---> Apple dynamic Library
##### // IBM 
##### #elif __AIX__ ----> IBM pragma for Unix AIX Operation System
###### internal const String DLLPREFIX = "lib";
###### internal const String DLLSUFFIX = ".a";
##### // Hewlett Packard
###### elif __hppa__ || IA64 ---> HP
###### internal const String DLLPREFIX = "lib";
###### internal const String DLLSUFFIX = ".sl"; -------> HP shared library
##### #else
        internal const String DLLPREFIX = "lib";
        internal const String DLLSUFFIX = ".so"; ------> Apple shared objects
        /// name.so - system library - same as .dll in Windows,
        /// to show the exported functions., Tool Dependency Walker.
        /// XAMARIN Chief Miguel de Icaza Wihitepaper for System-Function for use !
#### #endif
#### #endif // !PLATFORM_UNIX

##### public const string Kernel32 = DLLPREFIX + "rotor_pal" + DLLSUFFIX;
##### public const string User32 = DLLPREFIX + "rotor_pal" + DLLSUFFIX;
##### public const string Mscoree  = DLLPREFIX + "sscoree" + DLLSUFFIX;
#### Platform Info

##### NOT all Functions are use in other Platforms, so you can set this:
##### var os = System.Environment.OSVersion.Platform;
##### if (os == PlatformID.Windows)
##### {
##### // Statement, Function
##### }
##### elif(os == PlatformID.Unix)
##### elif(os == PlatformID.Linux)
##### elif(os == PlatformID.MAC)
##### Mac Computer have problems with DllImport, here EntryPoint !
##### elif(os == PlatformID.XBOX)
----

#### OLD
##### AssemblyInfo.cs - File - Visual Studio 2017 V 15.4 more Attributes:

##### Inside .NET Framework written in Visual C++, AssemblyAttributes.h and .cpp

#### NEW at .NET 5.0 Framework or higher:

##### All Attributes change in an Class !!!
##### AssemblyInfo.cs not allowed to change, delete, or insert anything !
##### This File is now an auto generated File by Build run !!!.
----
#### System.Reflection is the namespace.AssemblyName the class
#### Show my first use by Attribute in Project-Solution
        static readonly System.Reflection.AssemblyName sra1;
        static readonly System.Reflection.AssemblyCopyrightAttribute sra2;
        static readonly System.Reflection.AssemblyFileVersionAttribute sra3;
        static readonly System.Reflection.AssemblyCompanyAttribute sra4;
        static readonly System.Reflection.AssemblyProductAttribute sra5;
        static readonly System.Reflection.AssemblyDescriptionAttribute sra6;
        static readonly System.Reflection.AssemblyTitleAttribute sra7;


##### Method for get AssemblyName
        public static string VGFGetAssemblyName()
        {
            // Name of this Assembly
            return sra1.Name;
        }



----
##### Versionsinformationen für eine Assembly bestehen aus den folgenden vier Werten:

###### Hauptversion------------- (Windows 10 immer == 10)
###### Nebenversion------------- (Windows 10 immer == 0)
###### Buildnummer------------- Buildnumber xxxxx
###### Revision------------------- Revisionnumber wird laufend erhöht !!! .xxx
##### Registry Schlüsseleintrag für Revision ist UBR in hexadezimal
----
##### Interne Buildnumber für Windows 10.
##### zweistellig am großen update später kann auch dreistellig .xxx
##### das nennt man running develop, bugfixes, issues....
##### Revisionnummer ist in der Registry hinterlegt im Schlüssel UBR in hexadezimal.
##### (click auf schlüssel -> kleines fenster dort kann man umschalten auf dezimal wert ablesen.)
##### Windows 10 'Fall Creators Update' Buildnummer 16299 Revision .15 anfang!.
----
### INFO: Windows 10 ist Windows NT 10.0
----
#### Sie können alle Werte angeben oder die standardmäßigen Build- und Revisionsnummern 
#### übernehmen, indem Sie "*" eingeben:
#### [assembly: AssemblyVersion("1.0.*")]
#### [assembly: AssemblyVersion("1.0.0.10000")]
#### [assembly: AssemblyFileVersion("1.0.0.10000")]
----
### ! NEW ! written one constant line for more constants:

public const int Value1 = 0,
                 Value2 = 1,
                 Value3 = 2; // End of Constants with ; semicolon.

----
#### Visual Studio 2017 V 15.4 (to Fall Creators Update):
#### All Compiler active under the Hood.
##### Yellow Lamp is the Compiler! with intellisense Window for corrections and Online Help.
##### ou can insert in your Codeline with click.
##### Visual Studio go sleep, Compiler proof all writing Codeline - Line to Line.
##### Make a pre-compiling code, at end a faster Backend Compiling.
----
##### Next !New! is Microsoft Name Rules, all Functionsnames must be begin with one Lower-Letter.
##### old rand and new Rand, the same for DllImportAttribute:
##### ! Neue ! Microsoft Namen Regeln, der erste Buchstabe muss ein Grossbuchstabe sein, 
##### der neue Compiler macht darauf aufmerksam mit seinem Intellisense Fenster.
##### (die Visual Studio Compiler laufen mit, bei Code-Eingabe, direkte Überprüfung! 
##### und pre-compile dadurch schnellere Backend Compile. 
##### .net-slang: "Under the Hood", Compiler C++, C#, F#.....
##### Wenn Code eingegeben wird tritt das Studio in den Hintergrund, Compiler übernimmt.)
----
##### MSVCRT.dll is a 64BIT Visual C++ Runtime Library - one part written in C++, rest C
##### ONLY with Windows 10 64BIT
##### see here the NEW Microsoft Name Rules the first letter must be lower:
##### [DllImport("MSVCRT.dll", EntryPoint = "rand".....)]
##### internal static extern int Rand();

----
##### IntelliTrace Tool is now a standlone tool, so you can install on Customer System for
##### Exceptionhandling with many Informations, System-Actions, User-Actions, App Hang?,
##### and more. Before ONLY in Ultimate and Enterprise Edition inte.
##### Remote Debugging, Remote 
----
##### More opening the Windows Operation System, more Visual C++ Header-files.
##### Fall Creators Update come the NEW Console Window complete new ! is now legacy Application.
##### Word WrapUp, more Colors, separate Dll for Developers,
##### Console Window is the Windows 10 Operation System Window !!!.
##### Can write, Console App for User Settings to a Application.
##### Can call the Application out Console Window - CreateProcess(string AppName);
----
##### Options:
###### 1. Close the Console Window 
###### 2. or runs with normal Application.
###### (can be HIDE, send and receive all System / WindowMessages with the Operation System)
##### Shows:
###### Information, Warning, Critical Messages (Console Window goes Show Normal with Refresh)
###### simplesample: "an illegal Operation has now start, Cancel or Abort or shutdown ?"
----
#### From Community Developer:
##### Console Menu - see in folder.
##### Menu Item choice with Console.Key.Arrow up and down and return taste
----
### Rechtliche Hinweise zur Benutzung von Microsoft Inhalten:
----
#### https://www.microsoft.com/de-de/rechtliche-hinweise/urheberrecht.aspx
----
#### Betrifft:
##### Icons, Fonts, Maps, Logos, Clip Arts, Box Shots, Sounds, Weitergabe von Software und mehr....
----
##### TIPPO TIPP: Besser Genehmigung einholen ! - schriftlich/telefonisch
##### Genehmigung durch Microsoft 
##### Sie müssen folgenden Hinweis aufnehmen: “Nutzung mit Genehmigung von Microsoft.” 
##### oder/auch im Über/About Dialog aufnehmen:
##### Copyrights © 2017-2021 by Christian "Tipplin" Kurs - Visual .NET C# / C++ Developer
##### Portions of Copyrights © 1982-2021 by Microsoft Corporation 
----
#### Verlinkung von Microsoft Websites:
---- 
##### Sie dürfen einen Link zu Microsoft-Inhalten setzen, indem Sie entweder einen unformatierten Text-Link mit Worten wie beispielsweise “Hier geht’s zu Microsoft.com“ verwenden oder indem Sie an dem jeweiligen Link-Logo-Programm teilnehmen. 
##### Andere Bilder dürfen nicht als Link zu einer Microsoft-Seite verwendet warden. 

----
#### TIPPO TIPP:

##### ACHTUNG ! Im Internet läuft ein maschinengetriggter Algorithmus von Microsoft,
##### dieser spürt illegale Microsoft-Links auf !!!.

##### Microsoft behält sich vor die Websites zu sperren oder sogar den Computer/PC.
##### Sperre? dann hat man 14 Tage Zeit sich zu erklären !. Freigabe vorbehalten !.
##### Firmen und Unternehmen können sich in eine WHITE-LIST eintragen lassen.
----
##### Microsoft Crime Center verfolgt alles illegales ! - Sitz in London - MS Operation Center -
##### Letzte Festnahme in London 2017, Zwei Personen illegal einen Teil vom Quellcode Windows 10 ins Netz gestellt,
##### (TIPPO: ca 40000 Quellcodedateien, 70 GB )
##### Beta Archive musste es herunternehmen !!! sofort !!!.
##### Micorosoft arbeitet eng mit Police und Zoll zusammen. Vor einigen Jahren Großeinsatz in Nürnberg,
##### Microsoft Mitarbeiter und Zollkriminalamt, alles weg von den PC's -beschlagnamt-komplette Netzwerk abgeschaltet.
----
#### Linux Kernel und Kernel-Tree Sourcecode GitHub gehostet von Linus Torvald.
----
#### Singularity - Microsoft Managed Operation System in .NET und Visual C# geschrieben.
##### (Microsoft Research Center )
##### Keine Limits mehr !!!! - 255 weg, Laufwerke A-Z weg.......
##### Anschluss Laufwerke so viel man will, das Betriebssystem erkennt das Laufwerk mit Meldung.
##### Auch im laufenden Betrieb.

----
#### Fakultät:
##### Urheberrecht soll lernen erleichtern der Lehrenden an Hochschulen, erlaubt Ihren Studierenden,
##### Auszüge aus wissenschaftlichen Werken - DIGITAL - zur Verfügung zu stellen.
##### Die Urheber werden über eine Pauschalgebühr, die an die Verwertungsgesellschaft gezahlt wird,
##### vergütet.
##### Neuregekung: 5 Jahre befristet ! - nach 4 Jahren Überprüfung.
----
### EUIPO
#### Europäische Behörde für geistiges Eigentum
##### https://euipo.europa.eu/ohimportal/de/trade-marks
##### European Trademark
##### European Copyright Law
##### https://ec.europa.eu/digital-single-market/copyright
###### Häufig gestellte Fragen zum Urheberrecht:
##### https://euipo.europa.eu/ohimportal/de/web/observatory/faqs-on-copyright-de
----
#### Europäisches Patentamt für Software Patente in München
#### Software Patent gültig für 5 Jahre,
#### Patent kostet Geld !
#### (Microsoft hat Patente auf Steuerelemente / Controls)

----
#### In USA gibt es ein Copyright Register zum Schutz der Software
----
#### Deutsche Patentamt in Berlin
----







