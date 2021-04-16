----
## codes for use in Project.
----
##### For MessageBox Style, Button, Icon, SetForground, SystemModal:
##### This IL-Code is an integer value for all Values, IL (INT32)
##### MB_OK | MB_ICONHAND | MB_SETFOREGROUND | MB_SYSTEMMODAL
##### Visual C# Compile calculate one Value for this, after compile this 
----
### Value in IL.
----
#### Microsoft make same Code Convention for Developers,
#### and Name Rules, the First Letter must be upper by Methodname !!!.
----
## TIPPO TIP: 
#### see Microsoft Framework Guidelines as Online-Version or as book or .pdf
#### DO NOT....
#### !!! Ungarian Notation is OUT !!! - all camelcase notation
#### Assembly Name or Projectname: Company.Technology.Assemblyname.partname.dll
----
#### Methodname and by Method-declaration at  [DllImportAttribute]:
----
#### see here sample for a Visual C/C++ Function in der 64BIT Runtime Library:
----
#### [DllImportAttribute("msvcrt.dll", EntryPoint = "rand", SetLastError = true, CharSet = CharSet.auto, CallingConvention = CallingConvention.cdecl)]
----
#### set here for C# Method-declaration, first letter upper!
#### internal extern bool Rand();
----
#### Constants:
##### At NEW Visual C# 7.0 one Constant Declaration for all other Constants
##### end with commata, the last constant with ; semicolon
----
##### MessageBox StyleX in Library an Enumerator STYLES with Button, Icon, SetWindowForeground, Systemmodal 
##### Hexdecimal value from IL Code:
##### internal const uint  Style1 = 0x00011010,
##### Style2 = 0x00011030,
##### Style3 = 0x00011040,
##### Style4 = 0x00011020,
##### Style5 = 0x00011040,
##### Style6 = 0x00011014,
##### Style7 = 0x00011034,
##### Style8 = 0x00011044,
##### Style9 = 0x00011024,
##### Style10 = 0x00011011,
##### Style11 = 0x00011031,
##### Style12 = 0x00011041,
##### Style13 = 0x00011021; /// at end semicolon !
----
##### static int DARK_BLACK = 0;
##### static int DARK_BLUE = 1;
        static int DARK_GREEN = 2;
        static int DARK_CYAN = 3;
        static int DARK_RED = 4;
        static int DARK_MAGENTA = 5;
        static int DARK_YELLOW = 6;
        static int DARK_WHITE = 7;
        static int BRIGHT_BLACK = 8;
        static int BRIGHT_BLUE = 9;
        static int BRIGHT_GREEN = 10;
        static int BRIGHT_CYAN = 11;
        static int BRIGHT_RED = 12;
        static int BRIGHT_MAGENTA = 13;
        static int BRIGHT_YELLOW = 14;
        static int BRIGHT_WHITE = 15;
----
##### static integer array

##### static int[] saneFgs = {
            DARK_BLACK     ,
            DARK_RED       ,
            DARK_GREEN     ,
            DARK_YELLOW    ,
            DARK_BLUE      ,
            DARK_MAGENTA   ,
            DARK_CYAN      ,
            DARK_WHITE     ,
            BRIGHT_BLACK   ,
            BRIGHT_RED     ,
            BRIGHT_GREEN   ,
            BRIGHT_YELLOW  ,
            BRIGHT_MAGENTA ,
            BRIGHT_BLUE    ,
            BRIGHT_CYAN    ,
            BRIGHT_WHITE

        };
----
##### string[] FGs = {

                "m",

                "1m",

                "30m",

                "1;30m",

                "31m",

                "1;31m",

                "32m",

                "1;32m",

                "33m",

                "1;33m",

                "34m",

                "1;34m",

                "35m",

                "1;35m",

                "36m",

                "1;36m",

                "37m",

                "1;37m"

            };








