//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "Tipplin" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Security
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

#region System-Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.ExceptionServices;

#endregion


//-----------------------------------------------------------------------------
//
// In this Project-Solution you use in all other namespaces 
// from other Visual C# name.cs Files:
// Classes and Methods are static written set this:
// here bind in Visual.Operation.System.dll, inside Attribute
// [InternalsInvisibleAttribute("Visual.Galaxy.Framework"), AllInternals = true]
// All internals written are visible in Project 'Visual Galaxy Framework'
//-----------------------------------------------------------------------------

#region Directives from Visual.Galaxy.Framework

using static Visual.Galaxy.Framework.VGFCore;

#endregion

#region Directives from Visual.Operation.System.dll

using static Visual.Operation.System.Native.NativeMethods;
using static Visual.Operation.System.Native.UnsafeNativeMethods;
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

#endregion

#region Directives from Visual.Security.Library.dll

using static Visual.Security.Library.Cryption.VSLCrypt;

using static Visual.Security.Library.Core.VSLSecurity;

#endregion

//-----------------------------------------------------------------------------
// after set [InternalsVisibleAttribute("Visual.Galaxy.Framework")]
// in Visual.Security.Library.dll - Assembly - 
// All internals as classes, Methods, Properties 
// in Visual.Galaxy.Framework visible for use.
// 
//-----------------------------------------------------------------------------







//-----------------------------------------------------------------------------
// Only one namespace at First
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Security
{

    /// <summary>
    /// Class VGFSecurity
    /// </summary>
    public static class VGFSecurity
    {

        /// <summary>
        /// Determines if the current process is running with elevated privileges
        /// </summary>
        /// <returns></returns>
        public static bool VGFIsRunningWithElevatedPrivileges()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.User);
        }

        /// <summary>
        /// Determines if the current process is running with elevated Admin privileges
        /// </summary>
        /// <returns></returns>
        public static bool VGFIsRunningWithElevatedAdminPrivileges()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        /// <summary>
        /// Framework Method don't use it!
        /// </summary>
        /// <!-- Author Tipplin -->
        /// SystemFunction001 is Security Method as Check
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFSystemFunction001(string Filename, string UserAccount)
        {
            // Exceptionhandling on
            try
            {
                // returned true=0/false=1
                VSLAddFileSecurity(Filename, UserAccount, FileSystemRights.Read, AccessControlType.Allow);
                return true;
            }
            // Method secured with Access Control, onyl authorized Personnel have Acces on this Method.
            catch(MethodAccessException ex)
            {
                _ = VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            } // end of try/catch block - INFO: finally{...} is the ultimate resource free, Exception or NOT !

        } // end of Method::SystemFunction001

        /// <summary>
        /// Framework Method don't use it!
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="ErrorCode">Set ErrorCode</param>
        /// <returns>
        /// 
        /// </returns>
        public static void VGFSystemFunction002(int ErrorCode)
        {
            try
            {
                // NEW The ErrorType is in use at SDK OS-Build 18272
                // SDK Info:
                // SLE_ERROR
                // SLE_MINORERROR
                // SLE_WARNING
                // before is ignore!
                SetLastErrorEx(ErrorCode, SLE.SLE_ERROR);
            }
            catch(SystemException ex)
            {
                VGFStandardMessage1 = ex.Message + "\n";
                VGFStandardMessage1 += ex.Source + "\n";
                VGFStandardMessage1 += "returned errorcode from System: {0}\n" + ErrorCode;

                VFLMsgBox(VGFStandardMessage1, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
            }

        } // end of Method::SystemFunction002


        /// <summary>
        ///  Framework Method don't use it!
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="ErrorCode">Set ErrorCode</param>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFSystemFunction003(int ErrorCode)
        {
            try
            {
                // The ErrorType is in use at SDK OS-Build 18272
                // before is ignore!
                SetLastErrorEx(ErrorCode, SLE.SLE_MINORERROR);
                return true;
            }
            catch (Win32Exception ex)
            {
                _ = VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::SystemFunction002


        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <param name="ErrorCode">Set ErrorCode</param>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFSystemFunction004(int ErrorCode)
        {
            try
            {
                // The ErrorType is in use at SDK OS-Build 18272
                // before is ignore!
                SetLastErrorEx(ErrorCode, SLE.SLE_WARNING);
                return true;
            }
            catch (Win32Exception ex)
            {
                _ = VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::SystemFunction002














    } // END_OF_CLASS::VGFSecurity
} // END_OF_NAME_SPACE::Visual.Galaxy.Framework.Security
