//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and
//                  :   Main-Author Christian "Tipplin" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Application
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2017-2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
// Portions Copyright © 2017-2020 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
/*-----------------------------------------------------------------------------
 * Copyright © 2017-2020 Christian 'Tipplin' Kurs. All Rights Reserved.
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
 * © 1982-2021 Microsoft Corporation.All rights reserved.
 * -----------------------------------------------------------------------------
*/

//
// Set here the System Directives from .NET Framework 4.8
//

#region System - Directives from .NET Framework

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

#endregion

#region Directives plus static class from internal Visual.Galaxy.Framework  

using static Visual.Galaxy.Framework.NativeWindows.VGFNativeWindowsDLL;

// VGFCore - All Global Constants, Variables, Instances
// here public static string message
// NOTE ! Because of ambiguity set vgfmessage - the same message constant as vosmessage in Visual.Operation.System.dll
using static Visual.Galaxy.Framework.VGFCore;

#endregion



/*
 * set for native Methods from native Dll's.
 * here Class SafeNativeMethods, means no dangerous and risk for User call.
 * Three Classes like Microsoft Guideline for native Dll's.
 * Class UnsafeNativeMethods with Stackwalk and internal Security check.
 * 
*/

#region Directives from Visual.Operation.System.dll

using static Visual.Operation.System.Native.NativeMethods;

// Microsoft C/C++ Runtime Library Functions
using static Visual.Operation.System.Native.NativeRuntimeMethods;

// Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

//
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

#endregion


//-----------------------------------------------------------------------------
// Only one namespace at First
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Application
{
    

    /// <summary>
    /// Class VGFApplication
    /// </summary>
    /// <!-- Author Tipplin -->
    /// Class Application with Information, Settings, Security, AccessSystem
    /// <!-- Author Tipplin -->
    /// <remarks>
    /// Use Class Application from System.Windows.Form (inside 300 classes)
    /// Class Application, Battery, MessageBox, Controls, SystenInformation
    /// Webbrowser for your own Browser,
    /// special for multiple Works, means I/O Operation on miscellous CPU-Kernels:
    /// CPU-0, CPU-1, CPU-2, CPU-3 (!NOTE! dont use CPU-0 is the Operation System reserved ever!)
    /// CPU-1 input and CPU-2 output
    /// If the user want end the Application, but one or more CPU-Kernels work now,
    /// you can set Application.QuitAllowed (bool) = true/false - yes/no
    /// by false give Message to User.
    /// </remarks>
    public static class VGFApplication
    {
        // Avantage for Global Here in the Class Head

        #region ### VGFApplication - Constants ###

        
         


        /// <summary>
        /// constant for Autostart Registry Key with sign @ for unicode UTF16 - CLR internal UTF16 in/out
        /// </summary>
        internal const string VGF_AUTOSTART_REGISTRY_KEY = @"Software\Microsoft\Windows\CurrentVersion\Run";

        #endregion

        #region ### VGFApplication - Variables ###

        #endregion

        #region ### VGFApplication - Instancevariables ###


        #endregion

        #region ### Lambda Operator => for Enviroment Infos, for short names ###

        //---------------------------------------------------------------------
        // for use the shortnames in Project set this directive
        // -------------namespace in project other file-----Class
        // using static Visual.Galaxy.Framework.Application.VGFApplication;
        // ------------------------------------------------Class static written
        //
        //---------------------------------------------------------------------

        /// <summary>
        /// Property shortname for UserName
        /// </summary>
        internal static string Name => Environment.UserName;

        /// <summary>
        /// Property shortname for MaschineName
        /// </summary>
        internal static string Machine => Environment.MachineName;

        /// <summary>
        /// Get the current Network-Domain-Name for User in Network.
        /// </summary>
        internal static string UDomain => Environment.UserDomainName;

        /// <summary>
        /// The current Process in 64BIT Process ?
        /// </summary>
        internal static bool Process64 => Environment.Is64BitProcess;

        /// <summary>
        /// The current Operation System is 64 BIT ?
        /// </summary>
        /// <!-- Author TIPPLIN -->
        /// Tip:
        /// can change the datatype bool to string,
        /// then added by Environment.Is64BitOperatingSystem.ToString;
        /// so returned boolean as an string True or False !
        /// <!-- Author TIPPLIN -->
        internal static bool Is64 => Environment.Is64BitOperatingSystem;
        
        /// <summary>
        /// Get current Operation System Major
        /// </summary>
        internal static int Major => Environment.OSVersion.Version.Major;
        
        /// <summary>
        /// Get current Operation System Minor
        /// </summary>
        internal static int Minor => Environment.OSVersion.Version.Minor;
        
        /// <summary>
        /// Get current Operation System Build
        /// </summary>
        internal static int Build => Environment.OSVersion.Version.Build;
        
        /// <summary>
        /// Get current Operation System Revision,
        /// Microsoft increment the Revision by updates !.
        /// Quickfixes, Bugfixes, SecurityFixes, Improvements or
        /// Great Year Update.
        /// The Value stand in Registry under Key UBR as hexadecimal.
        /// Tipplin write help warapper for the OS-Revision's,
        /// read out the current Revision on this Computer.
        /// </summary>
        internal static int Revision => Environment.OSVersion.Version.Revision;

        /// <summary>
        /// Get how many Processors inside the current Machine
        /// </summary>
        internal static int ProcCount => Environment.ProcessorCount;



        #endregion



        /// <summary>
        /// Add Application to Autostart
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="ApplicationPath">Set Application Path</param>
        /// <param name="RegisterName">Set Register Name</param>
        /// <param name="User">Set User</param>
        /// <returns></returns>
        public static bool VGFAddAutoStartApplication(string ApplicationPath, string RegisterName, bool User)
        {

            var root = User ? Microsoft.Win32.Registry.CurrentUser : Microsoft.Win32.Registry.LocalMachine;

            // Open the Key with write Access
            using var key = root.OpenSubKey(VGF_AUTOSTART_REGISTRY_KEY, true);
            if (key == null)
            {

                VGFStandardMessage1 = "Unable to access/create registry key\n";
                VGFStandardMessage1 += "EnviromentException occured !.";

                //------------------------------------------------------
                // See OS-MessageBox, but with STYLES enumerator like VB
                // OS-MessageBox have 3 Parameters, the Third Parameter 
                // is a Enumerator for one Value must be use 
                // Operator Vertical Bar |
                // OS-MessageBox from VFL.dll - pure C Functions.
                //------------------------------------------------------
                // Windows 10 have 3D Icons for use, 
                // use Security Shield Icon in green, red and yellow
                // With Permission from Microsoft can use the Windows 10
                // icons, extract with 7Zip in imageres.dll 
                // under Resources, open dll with 7Zip see binary files,
                // All Windows 10 Resources in imageres.dll, marked all
                // icons and extract to a Folder.
                //------------------------------------------------------
                // Permitted by Microsoft
                // You must include the following statement: 
                // "Used with permission from Microsoft."
                //------------------------------------------------------
                _ = VFLMsgBox(VGFStandardMessage1, "VGFAddAutoStartApplication", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }

            key.SetValue(RegisterName, ApplicationPath, Microsoft.Win32.RegistryValueKind.ExpandString);

            return true;
            // end of using

        } // end of method::AddAutoStartApplication


        /// <summary>
        /// Remove Application from Autostart
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="RegisterName"></param>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool VGFRemoveAutoStartApplication(string RegisterName, bool User)
        {
            var root = User ? Microsoft.Win32.Registry.CurrentUser : Microsoft.Win32.Registry.LocalMachine;
            
            // Open the Key with write Access
            using var key = root.OpenSubKey(VGF_AUTOSTART_REGISTRY_KEY, true);
            
            if (key == null)
            {
                VGFStandardMessage1 = "Unable to access registry key\n";
                VGFStandardMessage1 += "EnviromentException occured !.";

                _ = VFLMsgBox(VGFStandardMessage1, "VGFRemoveAutoStartApplication", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }

            key.DeleteValue(RegisterName, false);

            return true;
            // end of using

        } // end of method::

        /// <summary>
        /// Get Autostart Application Path
        /// </summary>
        /// <param name="RegisterName">Set Registername</param>
        /// <param name="User">Set User - true/false</param>
        /// <returns></returns>
        public static string VGFGetAutoStartApplicationPath(string RegisterName, bool User)
        {

            var root = User ? Microsoft.Win32.Registry.CurrentUser : Microsoft.Win32.Registry.LocalMachine;
            // Open the Key with write Access
            using var key = root.OpenSubKey(VGF_AUTOSTART_REGISTRY_KEY);
            return key == null ? null : key.GetValue(RegisterName) as string;
            // end of using

        } // end of method::VGFGetAutoStartApplicationPath

        /*
        /// <summary>
        /// Get Special Folder
        /// </summary>
        /// <param name="folder">Set Folder</param>
        /// <param name="folderPath">Set Folder Path</param>
        /// <!-- Author Tipplin -->
        ///     The Special Folder in Windows 10 are many! ca. 90 Folder!
        ///     View in this Class and Enumerator:
        ///     Environment.SpecialFolder.enumFoldername
        ///     on CodeProject one Developer have a complete View over Windows 10 Folders
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFGetSpecialFolder(Environment.SpecialFolder folder, out string folderPath)
        {

            string msg;

            try
            {
                switch (folder)
                {



                    //------------------------------------------------------------
                    // NOTE ! in Windows Operation System more than this 3 Folder,
                    // 100 Folders.
                    //------------------------------------------------------------
                    // Private Folders can secure with sign $ and ~
                    // C:\~privateFolder, so is not visible in Windows Explorer
                    // Create new partition with dispart as private Partition,
                    // and secured/crypt, 
                    // so only you can use this Partition no other.
                    // for secret documents and more...
                    // ! you can use diskpart after install and primary partition
                    // without lost datas.
                    //------------------------------------------------------------
                    // \shared Folders always public.
                    //------------------------------------------------------------
                    case Environment.SpecialFolder.MyMusic:
                    case Environment.SpecialFolder.MyPictures:
                    case Environment.SpecialFolder.MyVideos:
                        folderPath = Environment.GetFolderPath(folder);
                        return !string.IsNullOrWhiteSpace(folderPath);

                    default:
                        break;

                } // end of switch
                
            }
            catch(SystemException ex)when(ex is NotImplementedException)
            {
                msg = string.Format("The handling for special folder '{0}' is'nt implemented yet", folder);


                VFLMsgBox(msg, "VGFGetSpecialFolder - Exception", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMExit(EXIT_CODES.ERROR_UNKNOWN_PROPERTY);
            }

        } // end of method::VGFGetSpecialFolder
        */


        /// <summary>
        /// Register App into Windows Operation System for Restart
        /// </summary>
        /// <param name="ApplicationName">Set Application Name</param>
        /// <!-- Author Tipplin -->
        /// Windows 10 have a internal table for Applications
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// OS-Function: RegisterApplicationWindows(LPSTR ApplicationName);
        /// If registered, so for use by Reboot and shutdown,
        /// Reboot, all operations close (force) reboot Windows and starts the Application new.
        /// can use by Hotfix, Bugfix and Securityfix, shutdown clear install fix and reboot.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static long VGFRegisterApplicationToWindows(string ApplicationName)
        {
            // see have wrapper call in Visual C#, make it for all Windows Operation System Functions!, is better!.
            return RegisterApplicationRestart(ApplicationName, 0);

        }

        
       
        /// <summary>
        /// Application Lock by Running Operation
        /// </summary>
        /// <param name="LockApp"></param>
        /// <!-- Author Tipplin -->
        /// use Class Application for specials
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// Property AllowQuit means, if a Operation now running, 
        /// but User will close the Application you can lock it.
        /// AllowQuit - true, he can close the Application - false NO !
        /// Use for Multiple Operations in CPU-Kernels,
        /// Intel i5 - 
        /// Microsoft Tool for distributed work on more than 2 CPU's:
        /// CPU 0, CPU 1, CPU 2, CPU 3... to CPU 63
        /// make hook by checkbox o, so the Works run on this CPUKernel.
        /// 
        /// but CPU 0 only for Operation System - Hand off -
        /// time-consuming works by I/O Operations, set on a CPU X,
        /// so this Work in background by System, but you must create a Lock like this.
        /// For calculations and mathematic Operations use better the GPU,
        /// the modern GPU like Nidvia G. works and faster 3000x as an CPU!
        /// Works moves from the CPU to the GPU and returns the result.
        /// Windows Operation System Functions:
        /// SetAffinityMask(threadname, CPUMask);
        /// ----------------GetCurrentThread, 0x2); CPU 2
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFApplicationLockRunningOperation(bool LockApp)
        {

            try
            {

                /*
                 * User allow quit the Application
                 * if false set, the app can't be closed !, 
                 * please set an task, sleep for end the running process for this and then give info to User can closed the App !
                */
                if (LockApp == true)
                {
                    LockApp = System.Windows.Forms.Application.AllowQuit;
                }
                else
                {
                    // user does't quit the Application
                    _ = VFLMsgBox("Sorry, but a Operation is now running, you can quit the Application", "Application Lock", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    LockApp = System.Windows.Forms.Application.AllowQuit;
                }

            }
            catch (SystemException ex)
            {
                _ = VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }

            return LockApp;
        
        } // end of method::VGFApplicationLockRunningOperation








    } // END_OF_CLASS::Application
} // END_OF_NAMESPACE::Visual.Galaxy.Framework.Application
