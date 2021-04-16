using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Reflection;
using System.Threading.Tasks;

// DllImportAttribute for native Methods from native Dll's - unmanaged Code -
using System.Runtime.InteropServices;




//---------------------------------------------------------------------------------
// <!-- Microsoft Portability, Globalization, Design automatic active! ----------->
// <!-- Microsoft.Interoperability ----------------------------------------------->
// <!-- Microsoft Portability 
// <!----------------------------------------------------------------------------->
// <!-- For native unmanaged Methods, must be written in three Classes: ---------->
// <!--> class NativeMethods-------- Stackwalk execute 
// <!--> NO! [SuppressUnmanagedCodeSecurityAttribute]
// <!----------------------------------------------------------------------------->
// <!--> class SafeNativeMethods---- Stackwalk non execute
// <!--> with [SuppressUnmanagedCodeSecurityAttribute]
// <!--> without Internal Full Security Check with Attribute
// <!--> NON! dangerous and Risk for User Calls.
// <!----------------------------------------------------------------------------->
// <!--> class UnsafeNativeMethods-- Stackwalk non execute
// <!--> with [SuppressUnmanagedCodeSecurityAttribute]
// <!--> with Security-Risk, so internal Full Security Check with Attribute.
// <!----------------------------------------------------------------------------->
//---------------------------------------------------------------------------------
//
//
//---------------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.NativeWindows
{










    /// <summary>
    /// Class VGFNativeWindows
    /// Like Microsoft Guideline for native Methods:
    /// Three Classes.
    /// </summary>
    /// <!-- Author Tipplin -->
    /// 
    /// <!-- Author Tipplin -->
    /// <remarks>
    /// 
    /// 
    /// </remarks>
    internal static class VGFNativeDLL
    {

        // set Global Variables here

        // set here Global Constants here
        // see the new write for constants as block by more as one,
        // by the same datatype.
        internal static string message = null, // first commata
                                  text = null, // second...
                                 title = null; // at last constant everytime set the semicolon ;


        // set here Global Enumerators here


        // set here Global Structures here

        // set here Global Instancevariable for Structs:
        // struct and instance variable on STACK!
        // MEMORYSTATUSEX ex;
        // by new operator:
        // MEMORYSTATUSEX ex = new MEMORYSTATUSEX(); on HEAP ever!
        // (Visual C# allocate automatic memmory for struct)
        // (Visual C# struct never null bytes, 1 byte for managed the Struct if members or not!.)
        // (Microsoft: Limit of Struct 16 Bytes, are greater split off in other.)
        //
        // Here in Class Head only Structs with Instance-Variable, but NOT The Call, in Methods !

        #region ### Enumerator ###

        /// <summary>
        /// 
        /// </summary>
        public enum Styles
        {
            /// <summary>
            /// Set MessageBox Button
            /// </summary>

            /// <summary>
            /// Button OK only
            /// </summary>
            OkOnly = 0,

            /// <summary>
            /// Button OK and Cancel
            /// </summary>
            OkCancel = 1,

            /// <summary>
            /// Button Abort and Retry and Ignore
            /// </summary>
            AbortRetryIgnore = 2,

            /// <summary>
            /// Button Yes and No and Cancel
            /// </summary>
            YesNoCancel = 3,

            /// <summary>
            /// Button Yes and No
            /// </summary>
            YesNo = 4,

            /// <summary>
            /// Button Retry and Cancel
            /// </summary>
            RetryCancel = 5,


            /// <summary>
            /// Set MessageBox Icon
            /// </summary>
            /// <summary>
            /// Application Icon
            /// </summary>
            Application = 32512,

            /// <summary>
            /// Critical Icon
            /// </summary>
            Critical = 32513,

            /// <summary>
            /// Question Icon 
            /// </summary>
            Question = 32514,

            /// <summary>
            /// Icon Exclamation
            /// </summary>
            Exclamation = 32515,

            /// <summary>
            /// Icon Information
            /// </summary>
            Information = 32516,

            /// <summary>
            /// Icon Windows Operation System Logo
            /// </summary>
            /// 
            Winlogo = 32517,

            /// <summary>
            /// Icon Shield green, yellow, red
            /// means the Security Shield
            /// </summary>
            Shield = 32518,


            /// <summary>
            /// Set Window in foreground everytime
            /// </summary>
            /// <remarks>
            /// Flag SetForeGround,
            /// The Window is Foreground everytime.
            /// </remarks>
            MsgBoxSetForeground = 65536,


            /// <summary>
            /// Set Modal Type
            /// 
            /// Flag SystemModal for this Window,
            /// User must bes close the Window, before he continue the Work,
            /// NO switch to other App's.
            /// </summary>
            SystemModal = 4096,

            /// <summary>
            /// 
            /// </summary>
            TaskModal = 2048

        }



        #endregion


        /// <summary>
        /// Class NativeMethods
        /// </summary>
        /// <remarks>
        ///  NO! [SuppressUnmanagedCodeSecurityAttribute]
        ///  class NativeMethods-------- Stackwalk execute
        ///  </remarks>
        internal static class NativeMethods
        {

        }

        /// <summary>
        /// Class SafeNativeMethods
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// 
        /// No SecurityCheck and without Stackwalk,
        /// No dangerous and Risk for User Call.
        /// 
        /// !ATTENTION!
        /// Have set special Attribute set in Main == assemblyname in AssemblyInfo.cs
        /// InternalsVisibleTo("Visual.Galaxy.Framework") as Reference of Class SafeNativeMethods.
        /// Class SafeNativeMethods in this Assembly 
        /// have Attribute [SuppressUnmanagedCodeSecurityAttribute] is degree of protection.
        /// All SafeNativeMethods outside locked. 
        /// </remarks>
        [SuppressUnmanagedCodeSecurityAttribute]
        internal static class SafeNativeMethods
        {
            /// <summary>
            /// MessageBox from our famous Visual.Function.Library.dll written in C.
            /// </summary>
            /// <!-- Author Tipplin -->
            /// At next in new Project an better MessageBox as this old Style,
            /// Project "" - WPFMessageBox with many Features:
            /// WPFMessageBox: 3D Icons, Hyperlink, Clipboard, Copy, Scrollbar, 
            /// Expand WPFMessageBox to Full Window at Left Corner Black Field click and make it greather,
            /// Timeout, set value and the WPFMessageBox close automatic by no User Action!.
            /// (NOTE: same was in Windows Operation System as MessageBoxTimeout Function)
            /// (NOTE: STOPPED a Thread with Thread.Sleep or Sleep Function can write this:
            /// Thread.Sleep(5000 * MessageBox("After OK Click, Thread continue!", "Thread", OK, Buton) );
            /// * asteric as operator, so sleep the Thread 5 seconds and than the MessageBox shows the Message.
            /// Thread.Sleep(5000 * MethodName(parameters) );
            /// * asteric as operator, so sleep the Thread 5 seconds and than execute the Call/Method.
            /// Many Timers in .NET Framework without any Control!
            /// Timers Timer;
            /// Timer(interval, parameter, Call, x);
            /// The Timer execute after TimeInterval any time this Call, don't forget the Timer.Stop!,
            /// Forget the Timer runs continue.
            /// Same in Mobile Class Vibrator as Timer, forget Timer.Stop - Phone any time vibrate.
            /// <!-- Author Tipplin -->
            /// <param name="lpszText">set here your Text</param>
            /// <param name="lpszTitel">set here your Title</param>
            /// <param name="styles">Enumerator Styles: Button, Icon, SetForeground, SystemModal</param>
            /// set here the Style do you want
            /// 1 - 4
            /// OK Button
            /// 1 Critical Icon
            /// 2 Exclamation Icon
            /// 3 Information Icon
            /// 4 Question Icon
            /// 5 - 8
            /// YESNO
            /// 9 - 12
            /// ABORTRETRYIGNORE
            /// 
            /// <remarks>
            /// Note!, MessageBox from System with internal Flags,
            /// MessageBox is alltime in Foreground and SystemModal,
            /// so the user must be closed, before work continue with other Programs.
            /// </remarks>
            /// <returns></returns>
            [DllImport("VFL.dll", EntryPoint = "vgfVFLMsgBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
            internal static extern uint VFLMsgBox(
                                                   [MarshalAs(UnmanagedType.LPWStr)]
                                                   string lpszText,
                                                   [MarshalAs(UnmanagedType.LPWStr)]
                                                   string lpszTitel,
                                                   Styles styles); // write enumerator like VB.NET
                                                                   // show you in code than the intellsense Window
        }

        /// <summary>
        /// Class UnsafeNativeMethods
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Third Class for Native Methods from native DLL's
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// [SuppressUnmanagedCodeSecurityAttribute]
        /// with SecurityCheck and Stackwalk.
        /// 
        /// !ATTENTION!
        /// Have set special Attribute set in Main == assemblynae.dll in AssemblyInfo.cs
        /// InternalsVisibleTo("Visual.Galaxy.Framework") as Reference of Class SafeNativeMethods.
        /// Class SafeNativeMethods in this Assembly 
        /// have Attribute [SuppressUnmanagedCodeSecurityAttribute] is degree of protection.
        /// All SafeNativeMethods outside locked.  
        /// </remarks>
        [SuppressUnmanagedCodeSecurityAttribute]
        internal static class UnsafeNativeMethods
        {

        }


        /// <summary>
        /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
        /// !NOTE! If Operation System is Windows 10 Professional more than one C/C++ Runtimes !
        /// at Time by Windows 10 October Update 2018.
        /// 
        /// Windows 10 System Compoment - ucrt.dll - universal c runtime library -
        /// equa. is vcruntime140.dll in Visual Studio - Windows is written with Visual Studio.
        /// 
        /// ucrt.h as headerfiles in Windows 10 SDK in:
        /// C:\Program Files (x86)\Windows Kits\10\Include\10.0.17763.0\ucr
        /// 
        /// ucrt with sourcecodes:
        /// C:\Program Files (x86)\Windows Kits\10\Source\10.0.17763.0\ucr
        /// 
        /// Windows Error Numbers with description
        /// C:\Program Files (x86)\Windows Kits\10\Include\10.0.17763.0\shared
        /// INFO ! catch the Windows Operation System Error with:
        /// Class Win32Exception
        /// .NET Framework: try/catch/finally block and filtermethod 
        /// catch(Win32Exception exe)if(ex.Number == -2100000) or when(ex.Number == 0x000000c5){...}
        /// 
        /// 
        /// Give mixed Runtimes C and C++ by C++ Classes with mangled Names and pure C Functions,
        /// see with Dependency Walker (32/64BIT) - Functions 64BIT at Name.
        /// </summary>
        [SuppressUnmanagedCodeSecurityAttribute]
        internal static class NativeMethodsRuntimes
        {

            #region ### Microsoft C/C++ Runtime Library Functions - ! NOTE ! are ONLY 64BIT - ###

            /// <summary>
            /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
            /// exit, terminate process complete, call and caller.
            /// exit(errorcode); All in Windows SDK: All with begin ERROR_
            /// </summary>
            /// <remarks>
            /// Microsoft Name Convention: First Letter must be upper at Declaration
            /// </remarks>
            [DllImport("mscrt.dll", EntryPoint = "exit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void VRLExit();

            /// <summary>
            /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
            /// exit, terminate process complete, call and caller.
            /// exit(errorcode); All in Windows SDK: All with begin ERROR_
            /// VRLExit2(1150); 
            /// // 1150 is The specifies program requires a newer Version of Windows Operation System.
            /// ERROR_OLD_WIN_VERSION = 1150L
            /// </summary>
            [DllImport("mscrt.dll", EntryPoint = "_Exit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void VRLExit2(int ExitCode);

            /// <summary>
            /// Use here Microsoft C Runtime Library - mscrt.dll - 64 Bit Version !.
            /// mscrt.dll
            /// _cexit, Performs cleanup operations and returns without terminating the process.
            /// </summary>
            [DllImport("mscrt.dll", EntryPoint = "_cexit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            internal static extern void VRLCExit();




            #endregion






        } // end of class::NativeMethodsRuntimes








    } // end of class::VGFNativeDLL


} // end of namespace::Visual.Galaxy.Framework.NativeWindows
