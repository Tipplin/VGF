using System;
using System.IO;

using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Runtime.InteropServices;

using System.Timers;
using System.Threading;
using System.Threading.Tasks;




// Is not a Directive - Assembly, Is Only a namespace from a other Visual C# .cs file
// in this Project-Solution.

using static Visual.Operation.System.Native.NativeMethods;
using static Visual.Operation.System.Native.NativeRuntimeMethods;
using static Visual.Operation.System.Native.UnsafeNativeMethods;

using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;
using static Visual.Galaxy.Framework.Application.VGFApplication;





namespace Visual.Galaxy.Framework.Services
{

    /// <summary>
    /// 
    /// </summary>
    public class VGFProcessBuilder
    {

        /*
        // Class Constructor in Visual C# - IL-code as .ctor
        VGFProcessBuilder()
        {
            // Statement, Calls, Logs or initializing
        }

        /// <summary>
        /// Class Destructor in Visual C# - IL-code as .dtor but it's HIDDEN, no view!
        /// NEVER null or empty ! if so, running in idling, 
        /// that's not so good, the system performance goes dowm.
        /// </summary>
        ~VGFProcessBuilder()
        {
            // Statement, Calls, Logs or what you want!

        }

        */




        /// <summary>
        /// Start Executable Process
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <param name="ProcessName">Set EXE Name</param>
        /// <param name="ProcessArgument">Set Arguments</param>
        /// <param name="UserName">Set your UserName, but is an optional parameter.</param>
        /// <param name="Password">Set your Password</param>
        /// <param name="UDomain">Set your Domainname, but is an optional parameter.</param>
        /// <remarks>
        /// Method-declaration with optional parameters,
        /// string UserName = ""
        /// string Domain = ""
        /// the standard nullorempty can be change in Code.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public bool VGFStartExecutableProcess(string ProcessName, string ProcessArgument, SecureString Password, string UserName = "", string UDomain = "")
        {
            try
            {
                
                // Set NullGuardedAnalyzer
                if (ProcessName == string.Empty)
                {
                    VFLMsgBox("Processname is null, not allowed!", "Exception at Method::VGFStartExecutableProcess", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false;
                }
                else if (Password == null)
                {
                    VFLMsgBox("Password is null, not allowed!", "Exception at Method::VGFStartExecutableProcess", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false;
                }



                Process.Start(ProcessName, ProcessArgument, UserName, Password, UDomain);

                // OK! returned true!
                return true;
            }
            catch (InvalidOperationException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFStartExecutableProcess", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }
            // ApplicationException everytime means only the Application, 
            // so is a Exception occured in Application, catch the exception here, the System is isolate, no hang up!
            catch (ApplicationException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFStartExecutableProcess", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }
            // Win32Exception for all Windows Operation System Errors - at time new SDK 18282 - WinError.h ca. 15885 errors plus COM errors...
            // and in SDK Bugcodes for Bluescreens - Bugcodes.h
            // WinError.h as C++ Headerfile stand now in folder \shared not in \include.
            // Set this Project Enumerator for Exit Codes: 
            //[DllImport("mscrt.dll", EntryPoint = "_Exit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
            //internal static extern int VGFExit(EXIT_CODES exitcode);
            catch (Win32Exception ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFStartExecutableProcess", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }


            return false;


        } // end of method::VGFStartExecutableProcess

        /// <summary>
        /// Start any Process (.exe) with arguments
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Start all executable .exe as process, same with SDK Tools, System-tools...
        /// <!-- Author Tipplin -->
        /// <param name="ProcessName">set the Processname, most .exe</param>
        /// <param name="arguments">set the arguments, is optional parameter.</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public bool VGFStartProcessWithArguments(string ProcessName, string arguments = "")
        {

            try
            {

                ProcessStartInfo startInfo = new ProcessStartInfo(ProcessName);
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;

                Process.Start(ProcessName);

                startInfo.Arguments = arguments;

                Process.Start(startInfo);



            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFStartExecutableProcess", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }

            return true;
        }

        /// <summary>
        /// Test our Console Window App
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public bool VGFTestStartUpAppConsole()
        {

            try
            {
                Process p = new Process();

                p.StartInfo.UseShellExecute = false;

                // string Path = @"C:\Users\Tipplin\Software Creative Production\StartUpApp\StartUpApp\bin\Debug\StartUpApp.exe";

                // Set Filename and Path, see the unicode sign @, so only one Slash \ normal \\
                // URL, Server the same \\\..\\..\\ -> @ \\..\..\
                p.StartInfo.FileName = @"C:\Users\Tipplin\Software Creative Production\StartUpApp\StartUpApp\bin\Debug\StartUpApp.exe";
                // No Window show!
                p.StartInfo.CreateNoWindow = true;
                // start the given Process.
                p.Start();
                // This code assumes the process you are starting will terminate itself. 
                // Given that is is started without a window so you cannot terminate it 
                // on the desktop, it must terminate itself or you can do it programmatically
                // from this application using the Kill method.
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFTestStartUpAppConsole", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;

        } // end of Method::VGFTestStartUpAppConsole

        /// <summary>
        /// Start Website directly with Internet Explorer or Microsoft Edge or other Web-Browser
        /// </summary>
        /// <param name="WebsiteURI">Set the uri: -microsoft.com- </param>
        /// <returns></returns>
        public bool VGFStartWebSiteDirectly(string WebsiteURI)
        {
            try
            {
                // Set Internet Explorer as Web-Browser
                // Call him
                ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");

                startInfo.WindowStyle = ProcessWindowStyle.Maximized;

                // Start the Process Webbrowser and argument.
                Process.Start(startInfo);

                // Set the given Website URI without www. - microsoft.com
                startInfo.Arguments = WebsiteURI;

                Process.Start(startInfo);
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFTestStartUpAppConsole", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;
        }









    } // end of class::VGFProcessBuilder


} // end of namespace::Visual.Galaxy.Framework.Services
