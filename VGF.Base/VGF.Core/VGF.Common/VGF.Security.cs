//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Security
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2019
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "TIPPO" Kurs - Visual C# Developer
// Portions Copyright © 2019 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
// Warning:
// ----------------------------------------------------------------------------
// This product is licensed to you pursuant to the terms of the 
// VGF license agreement included with the original software, and is
// protected by copyright law and international treaties.Unauthorized
// reproduction or distribution may result in severe civil and criminal
// penalties, and will be prosecuted to the maximum extent possible under
// the law.
// You cannot distribute a compiled version 
// of this code without prior registration.
//-----------------------------------------------------------------------------
// Please see the documentation supplied with
// the VGF Libraries for further details.
//
// Authored by 
// Copyright © 2019 by  Visual Galaxy Framework Community Kernel Developer Team
// All Rights Reserved.
// May be redistributed for free,
// but may not be sold without the author's explicit permission
//-----------------------------------------------------------------------------
// This software is Copyright © 2018 by VGF-Technologies at VGF-KernelTeam
// You may only use this software if you are an authorized licensee
// of an VGF developer tools product.
//
// This software is considered a Redistributable as defined under
// the software license agreement that comes with the VGF Products
// and is subject to that software license agreement.
//
//-----------------------------------------------------------------------------
// Microsoft make Restrictions of Export for following Countries:
// --------------------------------------------------------------
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
// or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
// involved with missile technology or nuclear, chemical or biological weapons)
//-----------------------------------------------------------------------------
// © 1982 - 2019 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Microsoft make Restrictions of Export for following Countries:
// ============================================================================
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) 
// or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
// involved with missile technology or nuclear, chemical or biological weapons)
//-----------------------------------------------------------------------------
// © 1982 - 2019 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

/*
     For Developers:
     Here all System Directives from .NET Framework for Project.
     System.namespace or Windows.namespace or 
     Windows Metadata's .winmd the same as Assemblies
     Give us the Windows Operation System for use!
     Direrctory: 
     \windows\system32\Winmetadata
     bind in  with Reference Manager search option go into Directory and click.
     
*/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.ExceptionServices;




//-----------------------------------------------------------------------------
//
// In this Project-Solution you use in all other namespaces 
// from other Visual C# name.cs Files:
// Classes and Methods are static written set this:
// here bind in Visual.Operation.System.dll, inside Attribute
// [InternalsInvisibleAttribute("Visual.Galaxy.Framework"), AllInternals = true]
// All internals written are visible in Project 'Visual Galaxy Framework'
//-----------------------------------------------------------------------------

using static Visual.Galaxy.Framework.Core.VGFCore;


using static Visual.Operation.System.Native.NativeMethods;
using static Visual.Operation.System.Native.UnsafeNativeMethods;
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;



using static Visual.Security.Library.Cryption.VSLCrypt;

using static Visual.Security.Library.Core.VSLSecurity;
//-----------------------------------------------------------------------------
// after set [InternalsVisibleAttribute("Visual.Galaxy.Framework")]
// in Visual.Security.Library.dll - Assembly - 
// All internals as classes, Methods, Properties 
// in Visual.Galaxy.Framework visible for use.
// 
//-----------------------------------------------------------------------------







//-----------------------------------------------------------------------------
//
//
//
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Security
{

    /// <summary>
    /// Class VGFSecurity
    /// </summary>
    public static class VGFSecurity
    {


        


        /// <summary>
        /// Framework Method don't use it!
        /// </summary>
        /// <!-- Author TIPPO -->
        /// SystemFunction001 is Security Method as Check
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        [PrincipalPermission(SecurityAction.Demand)]
        public static bool SystemFunction001(string Filename, string UserAccount)
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
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            } // end of try/catch block - INFO: finally{...} is the ultimate resource free, Exception or NOT !

        } // end of Method::SystemFunction001

        /// <summary>
        /// Framework Method don't use it!
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <param name="ErrorCode">Set ErrorCode</param>
        /// <returns>
        /// 
        /// </returns>
        public static void SystemFunction002(int ErrorCode)
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
                vgfmessage = ex.Message + "\n";
                vgfmessage += ex.Source + "\n";
                vgfmessage += "returned errorcode from System: {0}\n" + ErrorCode;

                VFLMsgBox(vgfmessage, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
            }

        } // end of Method::SystemFunction002


        /// <summary>
        ///  Framework Method don't use it!
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <param name="ErrorCode">Set ErrorCode</param>
        /// <returns>
        /// 
        /// </returns>
        public static bool SystemFunction003(int ErrorCode)
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
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::SystemFunction002


        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <param name="ErrorCode">Set ErrorCode</param>
        /// <returns>
        /// 
        /// </returns>
        public static bool SystemFunction004(int ErrorCode)
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
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::SystemFunction002














    } // end of class::VGFSecurity

} // NAME_SPACE_END::Visual.Galaxy.Framework.Security
