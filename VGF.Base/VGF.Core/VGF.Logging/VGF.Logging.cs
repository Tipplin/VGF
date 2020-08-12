//------------------------------------------------------
// Project	: Visual.Galaxy.Framework
//
//------------------------------------------------------
// Programmer	: Christian "TIPPO"
//------------------------------------------------------
// Part	        : Logging
//------------------------------------------------------
// Base Class	: Core
//
//
//
//
//------------------------------------------------------
//
//
//
// Set here Directives and namespaces (Project)
//
//------------------------------------------------------
using System;
using System.IO;
using System.IO.Log;
using System.DirectoryServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;






// use Operation System Functions
using static Visual.Operation.System.Native.NativeMethods;

// Visual C++ - Runtimes Library Functions - ! CharSet.Cdecl
using static Visual.Operation.System.Native.NativeRuntimeMethods;

/*--------------------------------------------------------------------------------
 * Project-Maintainer 'Tippo' change internal the using Visual.Function.Library to 
 * Visual.Operation.System.Native.UnsafeNativeMethods,
 * thats all Wrapper Methods from VisualFunctionLibrary.dll written in C.
 * Run analysis have Proposal made unmanaged Code into Class UnsafeNativeMethods.
 *--------------------------------------------------------------------------------
 */
using static Visual.Operation.System.Native.UnsafeNativeMethods;

using static Visual.Operation.System.Base.VOSInternalBase;

// use Style for MessageBox
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

// Internal Utilities, means Methodcalls at Runtime for checks:
// Windows Operation System Versions, Memory, Storage, 
// Windows Membership, Accounts,

using static Visual.Galaxy.Framework.Core.VGFCore;


//------------------------------------------------------
// CLogs 
//
//
//------------------------------------------------------
namespace Visual.Galaxy.Framework.Logging
{

    /// <summary>
    /// 
    /// </summary>
    public static class VGFLogger
    {

        /// <summary>
        /// 
        /// </summary>
        internal enum VGFLoggingEventType
        {
            Invalid = -1,
            CustomEvent,
            BuildErrorEvent,
            BuildFinishedEvent,
            BuildMessageEvent,
            BuildStartedEvent,
            BuildWarningEvent,
            ProjectFinishedEvent,
            ProjectStartedEvent,
            TargetStartedEvent,
            TargetFinishedEvent,
            TaskStartedEvent,
            TaskFinishedEvent,
            TaskCommandLineEvent
        }

        /// <summary>
        /// 
        /// </summary>
        [Serializable]
        internal enum LogLevel
        {
            Trace = 0,
            Info = 5,
            Status = 20,
            Warning = 40,
            Error = 50,
            Panic = 100
        }


        /// <summary>
        /// 
        /// </summary>
        private static TraceSource TraceSource;

        /// <summary>
        /// 
        /// </summary>
        public const string EventLogSource = "Automatic Versions";

        /// <summary>
        /// 
        /// </summary>
        public static TraceListenerCollection Listeners => TraceSource.Listeners;

        /// <summary>
        /// 
        /// </summary>
        static VGFLogger()
        {
            TraceSource = new TraceSource("VGFVersions")
            {
                Switch = new SourceSwitch("DefaultSwitch")
                {
                    Level = SourceLevels.All
                }
            };
            TraceSource.Listeners.Add(new EventLogTraceListener("VGFVersions")
            {
                Filter = new EventTypeFilter(SourceLevels.Verbose)
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFAssert(bool condition, string message, params object[] args)
        {
            if (!condition)
            {
                VGFError(message, args);
                throw new ApplicationException(message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public static void VGFError(SystemException ex)
        {
            VGFWriteEvent(TraceEventType.Error, ex.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFError(string message, params object[] args)
        {
            VGFWriteEvent(TraceEventType.Error, message, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFWarning(string message, params object[] args)
        {
            VGFWriteEvent(TraceEventType.Warning, message, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFInfo(string message, params object[] args)
        {
            VGFWriteEvent(TraceEventType.Information, message, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFLog(string message, params object[] args)
        {
            VGFWriteEvent(TraceEventType.Verbose, message, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFLog(TraceEventType type, string message, params object[] args)
        {
            VGFWriteEvent(type, message, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public static void VGFLog(object data)
        {
            VGFWriteData(TraceEventType.Verbose, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        public static void VGFLog(TraceEventType type, object data)
        {
            VGFWriteData(type, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFLogIf(bool condition, string message, params object[] args)
        {
            if (condition)
            {
                VGFWriteEvent(TraceEventType.Verbose, message, args);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void VGFLogIf(bool condition, TraceEventType type, string message, params object[] args)
        {
            if (condition)
            {
                VGFWriteEvent(type, message, args);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        private static void VGFWriteData(TraceEventType type, params object[] data)
        {
            try
            {
                TraceSource.TraceData(type, 0, data);
                TraceSource.Flush();
            }
            catch
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        private static void VGFWriteEvent(TraceEventType type, string message, params object[] args)
        {
            try
            {
                if (VGFShouldLogVerbose())
                {
                    TraceSource.TraceEvent(type, 0, message, args);
                    TraceSource.Flush();
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static bool VGFShouldLogVerbose()
        {
            return false;
        }
    











        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFWriteToFrameworkLogFile()
        {
            try
            {
                StreamWriter logfile = new StreamWriter(FrameworkLogFile, true);

                logfile.WriteLine("LogDate: {0} - LogTime: {1}", dt.ToLongDateString(), dt.ToLongTimeString());
                logfile.WriteLine("Frameworkname:\t {0}\n", vai.AsmName);
                logfile.WriteLine("Framworkversion:\t {1}\n", vai.Version.ToString());
                logfile.WriteLine("Operation System:\t {0}\n", VOSGetOperationSystemName());
                logfile.WriteLine("Execute Platform: \t {0}\n", VOSGetPlatformName());
                logfile.Flush();
                logfile.Close();
                return bool.TrueString;
            }
            catch (SystemException ex)when(ex is IOException | ex is ArgumentException)
            {
                // MessageBox from Visual Function Library written in C, with intellsense window: icon, button, state, modal
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // boolean as string, returned true or false as string
                return bool.FalseString;
            }
        }

   } // END_OF_CLASS_VGFLogger
        






    // This logger will derive from the Microsoft.Build.Utilities.Logger class,
    // which provides it with getters and setters for Verbosity and Parameters,
    // and a default empty Shutdown() implementation.
    internal static class VGFBaseFileLogger
    {
        /// <summary>
        /// Initialize is guaranteed to be called by MSBuild at the start of the build
        /// before any events are raised.
        /// </summary>
        public static string VGFLogsEvents(string LogModule, string LogStatus, string LogDescription)
        {


            try
            {
                // Open the file
                StreamWriter sw = new StreamWriter(TraceFile);

                sw.WriteLine("{0}\n", LogModule);
                sw.WriteLine("{0}\n", LogStatus);
                sw.WriteLine("{0}\n", LogDescription);

                sw.Flush();
                sw.Close();

            }
            // catch the Exception - other alternate is filtermethod with if in one line
            // equal about Java(UnauthorizedAccessException ex || ArgumentNullException ex ||  PathTooLongException ex)
            // catch (SystemException ex)if(ex is UnauthorizedAccessException || ex is ArgumentNullException || ex is PathTooLongException)    
            catch (SystemException ex) when (ex is UnauthorizedAccessException || ex is ArgumentNullException || ex is DirectoryNotFoundException || ex is SecurityException || ex is IOException)
            {

                vgfmessage = ex.Message + "\n";
                vgfmessage += ex.Source + "\n\n";
                vgfmessage += ex.StackTrace;

                VFLMsgBox(vgfmessage, ex.TargetSite.Name, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false.ToString();
            }
            // finally as ultimate free resource, Exception or NOT !
            finally
            {
                // free resource sw as Streamwriter
                // unmanaged Resources same !, Handles, Interface Twain Scanner,
                // If not free resource Interface Twain Scanner he is open, but no access again, so he can block the System.
                IDisposable dis = sw as IDisposable;
                if (dis != null)
                {
                    dis.Dispose();
                }

            }

            return true.ToString();

        } // END_OF_METHOD::VGFLogsEvents

    } // END_OF_CLASS::VGFBaseFileLogger


    /// <summary>
    /// VGFCoreLogs make it SPF conform with ISO Norm Developer
    /// Logs central in Class with static, so all Classes and Method using.
    /// </summary>
    internal static class VGFCoreLogs
    {



       ///------------------------------------------------------------------------------------
	   /// Set Method Implementation with Options:
	   /// AggressiveInline	- for short methods better inline
	   /// InternalCall		- internal call for method, so in Common Language Runtime Entry
	   /// NoInline			- No Inline say to Compiler !.
	   /// Compiler make Inline Methods at Compile with our Code.
	   /// Do J want this NOT, set NoInline !!!.
	   ///------------------------------------------------------------------------------------
	   /// UNDONE - MethodImplAttribute have out comment
	   /// [MethodImplementation(MethodImplOption.AggressiveInline)]
	   internal static string VGFWriteTrace(int TraceCategory, int TraceLevel, string TraceMessage, Object[] TraceArgs)
	   {
            
            
            // set instance for Class DateTime with instancevariable dt.
            var dt = new DateTime();

            // Question is Directory exists ?
            if ( dr.Exists == false)
			{
                // NO, we created the Directory on Drive C
				dr.Create();						
			}
			else
			{
			    // Create Trace File with Name and Date and Time.
				sw.WriteLine("IFTTraceFile{0}", dt.Date + dt.ToLongTimeString());
						
				sw.WriteLine("ITFTraceCategory	: {0}\n", TraceCategory);
				sw.WriteLine("ITFTraceLevel		: {0}\n", TraceLevel);
				sw.WriteLine("ITFTraceMessage	: {0}\n", TraceMessage);
                sw.WriteLine("ITFFreeObjectSet	: {0}\n", TraceArgs);
                
                // Write complete Stream into Trace File
                sw.Flush();
                
                // close the Trace File
                sw.Close();
                  
			}

            //OutputDebugString("IFTTraceLevel: ");
            //OutputDebugStringW();

            // change return value from bool to string,
            // while we ncan set boolean.ToString() return value is string True or False as string.
            // normally 0 or 1
            return true.ToString();

        } // End of Method::ITFWriteTrace


        








           

        


            } // END_OF_CLAS::VGFCoreLogs

} // END_OF_NAMESPACE::Visual.Galaxy.Framework.Logs
