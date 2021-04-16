//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "Tipplin" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Application
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
// Portions Copyright © 2020 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
/*-----------------------------------------------------------------------------
 * Copyright © 2020 Christian 'Tipplin' Kurs. All Rights Reserved.
 *-----------------------------------------------------------------------------
 * you may not use this file except in compliance with the License.
 * See License Agreement in Class VGF.Core at Main Head.
 *-----------------------------------------------------------------------------
 * Unless required by applicable law or agreed to in writing, 
 * software distributed under the License is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
 * either express or implied.
 * See the License for the permissions and limitations under the License.
 */
/*
 * -----------------------------------------------------------------------------
 * Microsoft make Restrictions of Export for following Countries:
 * -----------------------------------------------------------------------------
 * This software is subject to the U.S. Export Administration Regulations and 
 * other U.S.law, and may not be exported or re-exported to certain countries
 * (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
 * or
 * to persons or entities prohibited from receiving U.S.exports
 * (including Denied Parties, Specially Designated Nationals,
 * and entities on the Bureau of Export Administration Entity List or
 * involved with missile technology or nuclear, chemical or biological weapons)
 * -----------------------------------------------------------------------------
 * © 1982 - 2020 Microsoft Corporation.All rights reserved.
 * -----------------------------------------------------------------------------
*/

//
// Set here the System Directives from .NET Framework 4.8
//

#region System - Directives from .NET Framework

using System;
using System.IO;

using System.DirectoryServices;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;

#endregion

#region Directives plus static class from internal Visual.Galaxy.Framework  

// Internal Utilities, means Methodcalls at Runtime for checks:
// Windows Operation System Versions, Memory, Storage, 
// Windows Membership, Accounts,

using static Visual.Galaxy.Framework.VGFCore;

#endregion

#region Directives from Visual.Operation.System.dll

// use Operation System Functions
using static Visual.Operation.System.Native.NativeMethods;

// Visual C++ - Runtimes Library Functions - ! CharSet.Cdecl
using static Visual.Operation.System.Native.NativeRuntimeMethods;

/*--------------------------------------------------------------------------------
 * Project-Maintainer 'Tipplin' change internal the using Visual.Function.Library to 
 * Visual.Operation.System.Native.UnsafeNativeMethods,
 * thats all Wrapper Methods from VisualFunctionLibrary.dll written in C.
 * Run analysis have Proposal made unmanaged Code into Class UnsafeNativeMethods.
 *--------------------------------------------------------------------------------
 */
using static Visual.Operation.System.Native.UnsafeNativeMethods;

using static Visual.Operation.System.Base.VOSInternalBase;

// use Style for MessageBox
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

#endregion


//-----------------------------------------------------------------------------
// Only one namespace at First
//-----------------------------------------------------------------------------
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
        internal enum VGFLogEventType
        {
            VGFLogInvalid = -1,
            VGFLogCustomEvent,
            VGFLogErrorEvent,
            VGFLogFinishedEvent,
            VGFLogMessageEvent,
            VGFLogStartedEvent,
            VGFLogWarningEvent
        }

        /// <summary>
        /// 
        /// </summary>
        [Serializable]
        internal enum VGFLogLevel
        {
            VGFLogTrace = 0,
            VGFLogInfo = 5,
            VGFLogStatus = 20,
            VGFLogWarning = 40,
            VGFLogError = 50,
            VGFLogTotalPanic = 100
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFWriteToFrameworkLogFile()
        {
            try
            {
                var logfile = new StreamWriter(VGFFrameworkLogFile, true);

                logfile.WriteLine("LogDate: {0} - LogTime: {1}", dt.ToLongDateString(), dt.ToLongTimeString());

                logfile.WriteLine("Frameworkname:\t {0}\n", vai.AsmFQName);
                logfile.WriteLine("Framworkversion:\t {1}\n", vai.FileVersion);
                logfile.WriteLine("Operation System:\t {0}\n", VOSGetOperationSystemName());
                logfile.WriteLine("Execute Platform: \t {0}\n", VOSGetPlatformName());
                
                // write the full complete stream into logfile
                logfile.Flush();

                // close the logfile
                logfile.Close();

                return bool.TrueString;
            }
            catch (SystemException ex)when(ex is IOException | ex is ArgumentException)
            {
                // MessageBox from Visual Function Library written in C, with intellsense window: icon, button, state, modal
                _ = VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
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
                StreamWriter sw = new(VGFTraceFile);

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

                VGFStandardMessage1 = ex.Message + "\n";
                VGFStandardMessage1 += ex.Source + "\n\n";
                VGFStandardMessage1 += ex.StackTrace;

                _ = VFLMsgBox(VGFStandardMessage1, ex.TargetSite.Name, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false.ToString();
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

            // Open the file
            StreamWriter sw = new(VGFTraceFile);

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
