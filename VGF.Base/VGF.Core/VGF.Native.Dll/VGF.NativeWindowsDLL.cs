//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part				:	NativeDLL - most written in C/C++
//-----------------------------------------------------------------------------
// Base Class       :	VGF.NativeDLL
//-----------------------------------------------------------------------------
// Copyright © 2018
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "TIPPO" Kurs - Visual C# Developer
// Portions Copyright © 2018 by Microsoft Corporation GmbH.
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
// Copyright © 2018 by  Visual Galaxy Framework Community Kernel Developer Team
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
// © 1982 - 2018 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

/*********************************************************************************
 * For all Developers to help us and create a greatful Framework for our Community.
 * Application Framework with a lot of Classes, for all Application for use.
 * Network, Mobile, Services, Devices,
 * -------------------------------------------------------------------------------
 * - NICE TO HAVE YOU !!!.
 *--------------------------------------------------------------------------------
 * https://www.vfgc.org
 *--------------------------------------------------------------------------------
 * This is our Main Website:
 * https://www.vgfc.org/community
 *--------------------------------------------------------------------------------
 * my name is: Christian 'TIPPO' Kurs - Visual.NET C# / C++ Developer:
 * this is my website with a lot of information and more....
 * https://www.vgfc.org/community/developer/tippo
 *--------------------------------------------------------------------------------
 * For all Developers:
 * write your nickname at name.Thank's !
 * https://www.vgfc.org/community/developer/nickname
 *--------------------------------------------------------------------------------
 * my own Account by Google G-Mail
 * so can open directly account, insert password and Start my Account.
 * https://mail.google.com/mail/kurschristian
 *--------------------------------------------------------------------------------

********************************************************************************/

/*------------------------------------------------------------------------------
 * System Directives - .NET Framework Assemblies - begins with System - here
 * grayed are not in use, compiler remove them at build run.
 *------------------------------------------------------------------------------
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Reflection;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

/* 
 * Windows Directives - .NET Assemblies most written with extension .winmd 
 * begins with Windows - here - 
 * Windows Operation System for use them in Projects
 * same Assemblies/winmd's stand in:
 * \Windows\system32\WinMetadata
 *
 * Own directives\Assemblies\namespace in Project-Solution,
 * from other C# .cs Files, most namespaces or namesoace and static class!
 * pure namespace
 * using Visual.Operation.System.Internal.InternalUtilities
 * namespace and static class
 * using static Visual.Operation.System.Native.SafeNativeMethods;
 * Note: Class, Methods, Properties must be write static !.
*/

/*------------------------------------------------------------------------------
 * Own Directives - .NET Framework Assemblies - begins with Visual - here
 * grayed are not in use, compiler remove them at build run.
 * same from other project-files .cs, 
 * this classes written with static for direct use.
 * And from our Assemblies implement following:
 * Visual.Operation.System.dll
 * Visual.Resource.Libary.dll
 * Visual.Security.Library.dll
 * Visual.Registry.Library.dll
 * Visual.Galaxy.Framework.dll all on GitHub
 * 
 * Visual.Exception.Engine.dll
 * 
 * in progress:
 * Visual.Virtual.Engine.dll
 *------------------------------------------------------------------------------
*/

using static Visual.Galaxy.Framework.Core.VGFCore;

using static Visual.Operation.System.Internal.InternalOSMethods;

using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

using static Visual.Operation.System.Native.NativeMethods;

using static Visual.Operation.System.Native.NativeRuntimeMethods;

using static Visual.Operation.System.Native.UnsafeNativeMethods;



/*-----------------------------------------------------------------------------
*--------------------------- Microsoft Information ----------------------------
*------------------------------------------------------------------------------
* <!-- Microsoft Portability, Globalization, Design automatic active! -------->
* <!-- Microsoft.Interoperability -------------------------------------------->
* <!-- Microsoft Portability 
* <!-------------------------------------------------------------------------->
* <!--> For native unmanaged Methods, must be written in three Classes: ------>
* <!--> class NativeMethods-------- Stackwalk execute 
* <!--> NO! [SuppressUnmanagedCodeSecurityAttribute]
* <!-------------------------------------------------------------------------->
* <!--> class SafeNativeMethods---- Stackwalk non execute
* <!--> with [SuppressUnmanagedCodeSecurityAttribute]
* <!--> without Internal Full Security Check with Attribute
* <!--> NON! dangerous and Risk for User Calls.
* <!-------------------------------------------------------------------------->
* <!--> class UnsafeNativeMethods-- Stackwalk non execute
* <!--> with [SuppressUnmanagedCodeSecurityAttribute]
* <!--> with Security-Risk, so internal Full Security Check with Attribute.
* <!-------------------------------------------------------------------------->
* <!--> Microsoft Name Convention and Rule ----------------------------------->
* 
* Normal Method-Declaration: the first letter must be lower !
* and by DllImportAttribute the C# Declaration both.
* 
*------------------------------------------------------------------------------
* Better coding, comments set over namespace, inside codeparts
* everytime over constants, variables, parameters,
* never set comments at right side or underscore : 
* constants, variables, parameters,
* ! one is right, !!! idiot's
* XML-Comment member is <!-- --> can use for Authorname and comment.
-----------------------------------------------------------------------------*/


/*-----------------------------------------------------------------------------
*
*
*-----------------------------------------------------------------------------*/
namespace Visual.Galaxy.Framework.NativeWindows
{


    /*
     * Windows Operation System 10 - NEW SDK 18272 - 06.11.2018 -
     * Feedback List
     * 
     * include
     * WinUser.h
     * 
     * 
     * NEW in WinUser.h following defines and comic Functions
     #if defined(_M_CEE)
#undef SendMessage
__inline
LRESULT
SendMessage(
    HWND hWnd,
    UINT Msg,
    WPARAM wParam,
    LPARAM lParam
    )
{
#ifdef UNICODE
    return SendMessageW(
#else
    return SendMessageA(
#endif
        hWnd,
        Msg,
        wParam,
        lParam
        );
}
#endif   _M_CEE 


#undef DrawText
    __inline
int
DrawText(
    HDC hdc,
    LPCTSTR lpchText,
    int cchText,
    LPRECT lprc,
    UINT format
    )
{
#ifdef UNICODE
    return DrawTextW(
#else
    return DrawTextA(
#endif
        hdc,
    lpchText,
    cchText,
    lprc,
    format
        );
}
#endif   _M_CEE 
    
    
   
    #if defined(_M_CEE)
#undef MessageBox
__inline
int
MessageBox(
    HWND hWnd,
    LPCTSTR lpText,
    LPCTSTR lpCaption,
    UINT uType
    )
{

//Is this an wrong definition in SDK 18272 - Function MessageBoxW( ?
// and MessageBoxA without datatypes ?
#ifdef UNICODE
    return MessageBoxW(
#else
    return int MessageBoxA(
    hWnd,
    lpText,
    lpCaption,
    uType
        );
#endif
}

#if defined(_M_CEE)
#undef GetMessage
__inline
BOOL
GetMessage(
    LPMSG lpMsg,
    HWND hWnd,
    UINT wMsgFilterMin,
    UINT wMsgFilterMax
    )
{
#ifdef UNICODE
    return GetMessageW(
#else
    return GetMessageA(
#endif
        lpMsg,
        hWnd,
        wMsgFilterMin,
        wMsgFilterMax
        );
}
#endif  _M_CEE 









----------------------------------------------
- Windows OS Flags for ExitWindowsEx()
- New Flags at next Windows 10 SDK 18272
- New Flags at next Windows 10 2020 SDK 18945

----------------------------------------------
#define EWX_LOGOFF                  0x00000000
#define EWX_SHUTDOWN                0x00000001
#define EWX_REBOOT                  0x00000002
#define EWX_FORCE                   0x00000004
#define EWX_POWEROFF                0x00000008
#define EWX_FORCEIFHUNG             0x00000010
#define EWX_QUICKRESOLVE            0x00000020 NEW Flag
#define EWX_RESTARTAPPS             0x00000040 NEW Flag
#define EWX_HYBRID_SHUTDOWN         0x00400000
#define EWX_BOOTOPTIONS             0x01000000 NEW Flag

NTFS - Filesystem new Flag case sensety


NEW Windows 10 SDK 18272 - 06.11.2018
Windows Developer marked with macros !:

when old Functions, Flags removed/depreated/rearchitected

_When_((uFlags&(EWX_POWEROFF|EWX_SHUTDOWN|EWX_FORCE))!=0, __drv_preferredFunction("InitiateSystemShutdownEx", "Legacy API. Rearchitect to avoid Reboot"))

BOOL WINAPI ExitWindowsEx( _In_ UINT uFlags, _In_ DWORD dwReason);
------------------------------------------------------------------
dwReason any Reasons: 
MajorReason Application
MinorReason Securityfix, Bugfix, Quickfix
BOOL WINAPI ExitWindowsEx(EWX_REBOOT, Application | Quickfix);

*/



    // TIPPO_UNDONE - uncomplete Methods from WCF - DON'T USE IT!

    /// <summary>
    /// Class VGFNativeWindows
    /// Like Microsoft Guideline for native Methods:
    /// Three Classes.
    /// </summary>
    /// <!-- Author TIPPO -->
    /// 
    /// <!-- Author TIPPO -->
    /// <remarks>
    /// 
    /// 
    /// </remarks>
    public static class VGFNativeWindowsDLL
    {

        /// <summary>
        /// Multi Beep
        /// write for all Windows Operation System Functions, C# Wrapper Methods.
        /// </summary>
        /// <param name="fre">Set Frequence</param>
        /// <param name="dur">Set Duration</param>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// Frequence is integer Value, hear/not hear
        /// 32474 maximum.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFBeep(int fre, int dur)
        {

            bool bResult = false;

            if(fre < 20000 && fre > 32474)
            {
                VFLMsgBox("Frequence is wrong, try again", "Method::VGFBeep", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMCExit();
            }
            else if(dur < 500 && dur > 32474)
            {
                VFLMsgBox("Duration is wrong, try again", "Method::VGFBeep", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMCExit();
            }


            try
            {
                // unmanaged code function from WIndows Operation System: Beep
                bResult = Beep(fre, dur);
                return bResult;
            }
            catch(Win32Exception ex)when(ex is SystemException)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMExit(EXIT_CODES.ERROR_INTERNAL_ERROR);
            }
            return bResult;

        } // end of Method::VGFBeep

        

    } // end of class:OSVersionHelper









    /*

        static class UnsafeNativeMethods
        {

            Same as Windows Operation System Headerfile versionhelper.h for C/C++
            --------------------------------------------------------------------------------------
            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows10RS3OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows10RS2OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows10RS1OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows10TH2OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows10TH1OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows10OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows8Point1OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows8OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows7SP1OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindows7OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsVistaSP2OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsVistaSP1OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsVistaOrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsXPSP3OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsXPSP2OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsXPSP1OrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsXPOrGreater();

            [SecurityCritical, SuppressUnmanagedCodeSecurity]
            [DllImport(DllImport.PresentationNative, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            static extern bool IsWindowsServer();

        }

        internal static class DllImport
        {

            internal const string Shell32 = "shell32.dll";
            internal const string PresentationNative = "PresentationNative.dll";
            internal const string Wininet = "Wininet.dll";
            internal const string Ole32 = "ole32.dll";
            internal const string User32 = "user32.dll";
            internal const string NInput = "ninput.dll";
        }

    */

    

} // end of namespace::Visual.Galaxy.Framework.NativeWindows
