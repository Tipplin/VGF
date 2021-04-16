
using System;
using System.Net;
using System.Text;

using System.Runtime.InteropServices;
using System.Net.NetworkInformation;







//-------------------------------------------------------
// Here namespaces from Project-Solution from other
// Visual C# Files name.cs, 
// classes and methods are static written in C#
//-------------------------------------------------------

// Microsoft Guideline for native Methods from 
// native Dll's written in C/C++.
// Three classes: 
// Class NativeMethods, with Security Check and Stackwalk
// Class SafeNativeMethods, without Security Check and Stackwalk
// all are secure, no dangerous and no risk for User Calls.
// Class UnsafeNativeMethods, with Security Check and Stackwalk

// Base Class VGFNativeDLL, with Variables, Enumerators, Structures...
using static Visual.Galaxy.Framework.NativeWindows.VGFNativeWindowsDLL;


using static Visual.Operation.System.Native.NativeMethods;
using static Visual.Operation.System.Native.NativeRuntimeMethods;
using static Visual.Operation.System.Native.UnsafeNativeMethods;
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;
using static Visual.Galaxy.Framework.Application.VGFApplication;

//------------------------------------------------------
// Network - native Methods and .NET Framework 
//
//
//------------------------------------------------------
namespace Visual.Galaxy.Framework.Network
{

    /// <summary>
    /// 
    /// </summary>
    public static class VGFCoreNetwork
    {

        // EndpointInfo contains read-only information about an endpoint.

        // Datastore for NetworkInfo. Store this if required

        /// <summary>
        /// VGFEndpointInfoNetwork
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// 
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct VGFEndpointInfoNetwork
        {
            /// <summary>
            /// 
            /// </summary>
            public string ID;
            /// <summary>
            /// 
            /// </summary>
            public string Name;
            /// <summary>
            /// 
            /// </summary>
            public string NetworkID;
            /// <summary>
            /// 
            /// </summary>
            public string NamespaceID;
            /// <summary>
            /// 
            /// </summary>
            public int IPAddress;
            /// <summary>
            /// 
            /// </summary>
            public int MacAddress;
            /// <summary>
            /// 
            /// </summary>
            public int Gateway;
            /// <summary>
            /// 
            /// </summary>
            public string[] RouteInfo;
            /// <summary>
            /// 
            /// </summary>
            public string[] Policies;
            /// <summary>
            /// 
            /// </summary>
            public int Subnet;
            /// <summary>
            /// 
            /// </summary>
            public string DNSInfo;
            /// <summary>
            /// 
            /// </summary>
            public string ContainerID;
    }













    /*
    /// UNDONE: EXP_
    /// Is Harddrive a Network Harddrive ?
    public static ushort VGFIsNetDrive(int iDrive)
    {
        int EXP_;
        new char szDrive[3];
        char szConn[64];
        int nSize = 64;
        szDrive[0] = (char)(iDrive + 'A');
        szDrive[1] = ':';
        szDrive[2] = (char)0;

        if (IsCDRomDrive(iDrive))
            return 0;

        EXP_ = WNetGetConnection(szDrive, szConn, &nSize);

        if (EXP_ == WN_SUCCESS)
            return 1;

        if (EXP_ == WN_CONNECTION_CLOSED || EXP_ == WN_DEVICE_EXP_OR)
            return 2;

        return 0;

    } /// End of VGFIsNetDrive


    ///-----------------------------------------------------------------------------
    ///
    ///
    ///
    ///
    ///-----------------------------------------------------------------------------
    public static string VGFDisplayNetWorkExceptionText(uint dwNetworkExceptionCode)
    {
        var sb = new StringBuilder(255, 2048);

        IntPtr hModule = IntPtr.Zero;
        bool bResult;

        /// FORMAT Flags binding with Operator | to one 
        ///
        ///
        uint dwFormatFlags = FormatMessageFlags.FORMAT_MESSAGE_ALLOCATE_BUFFER | FormatMessageFlags.FORMAT_MESSAGE_IGNORE_INSERTS | FormatMessageFlags.FORMAT_MESSAGE_FROM_SYSTEM;

        ///============================================================== 
        /// This file contains error messages in the range 
        /// NERR_BASE (2100) through MAX_NERR(NERR_BASE+899). 
        /// These error codes are defined in the SDK header file lmerr.h.
        ///--------------------------------------------------------------
        /// Network Error Range from Microsoft Standard:
        /// NERR_BASE = 680 - under is reserved by MS
        /// NERR_BASE +
        /// netmsg.dll - old - network error message resource dll.
        ///
        /// BUT !, Here we must first load this DLL netmsmg.dll
        /// Only resource message inside.
        ///--------------------------------------------------------------
        if (dwNetworkExceptionCode >= NERR_BASE && dwNetworkExceptionCode <= MAX_NERR)
        {
            hModule = VGFCoreOperationSystem.LoadLibraryEx((string)("netmsg.dll"), 0, LOAD_LIBRARY_AS_DATAFILE);

            if (hModule != NULL)
            {
                dwFormatFlags |= FormatMessageFlags.FORMAT_MESSAGE_FROM_HMODULE;
            }
        }

        //
        // Call FormatMessage() to allow for message 
        //  text to be acquired from the system 
        //  or from the supplied module handle.
        //
        VGFCoreOperationSystem.FormatMessage(
                                                dwFormatFlags,              // FormatMessageFlags
                                                hModule,                    // module to get message from (NULL == system
                                                dwExceptionCode,            // ErrorCode
                                                VGFCoreUtiliy.LANG_NEUTRAL, // neutral default language (primary and secondary)
                                                sb,                         // set for pszBuffer - StringBuilder()
                                                sb.capacity,                // set nSize - StringBuilder expand -
                                                                            // StringBuilder( (min) 255, (max) 2048)
                                                                            // If the Networkmessage is greather as 255 chars the
                                                                            // the Stringbuilder expand to maximal Value.
                                                                            // If the Message is greather, he cut the Message !.
                                                                            // 
                                                IntPtr.Zero                 // C# Pointer with Pointer Correctness.
                                                );

        //
        // Free the buffer allocated by the system.
        //
        VGFCoreOperationSystem.LocalFree(lpMessageBuffer);

        //--------------------------------------------------------
        // If we loaded a message source, unload it.
        // Microsoft Developer Info: 
        // Close all Handle at Final.
        // UNCHECKED for use the Class SafeHandles in .NET FX.
        //--------------------------------------------------------
        if (hModule != NULL)
        {
            bResult = VGFCoreOperationSystem.FreeLibrary(hModule);
        }

        return (sb.ToString());
    }

}

///--------------------------------------------------------------
/// VGFGetMPRNetworkMassage
/// Windows 10 - multi provider router API - mpr.dll, mpr32.dll
/// MprmsgGetErrorString - only one function in mprmsg.dll
/// Messages Service for Multi Provider Router.
///--------------------------------------------------------------
public static string VGFGetMPRNetworkMassage(int mprNativeErrorCode)
{
    return GetErrorString(mprNativeErrorCode);

} /// End of VGFGetMPRNetworkMassage

///
public static bool VGFLoadDLLIntoMemory(string DLLName)
{

    var sb = new Stringbuilder(255, 8096);


    //
    // NOW! LoadLibraryEx for Network Error Messages - Dynamic Link Library, must be loaded!
    // 
    //
    IntPtr hWinINetLibrary;
    hWinINetLibrary = LoadLibraryExW(
                        DLLName,
                        0,
                        LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE | LOAD_LIBRARY_AS_IMAGE_RESOURCE);

    if (hWinINetLibrary == NULL)
    {
        // if library load failed using flags only valid on Vista+, 
        // fall back to using flags valid on XP
        hWinINetLibrary = LoadLibraryExW(DLLName, NULL, LOAD_LIBRARY_AS_DATAFILE);
    }

    if (hWinINetLibrary == NULL || FormatMessage(FORMAT_MESSAGE_ALLOCATE_BUFFER |
                            FORMAT_MESSAGE_FROM_HMODULE,
                            hWinINetLibrary,
                            m_dwError,
                            MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT),
                            sb.capacity,
                            0,
                            NULL) == 0)
    {
        // it failed! try Windows...

        bRet = FormatMessage(FORMAT_MESSAGE_ALLOCATE_BUFFER |
                    FORMAT_MESSAGE_FROM_SYSTEM,
                    0,
                    m_dwError,
                    MAKELANGID(LANG_NEUTRAL, SUBLANG_SYS_DEFAULT),
                    sb.capacity,
                    0,
                    NULL);
    }

    return true;
}

*/

    /// <summary>
    /// Lock the current Workstation/Computer
    /// </summary>
    /// <!-- Author Tipplin -->
    /// 
    /// <!-- Author Tipplin-->
    /// <remarks>
    /// 
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    public static bool VGFLockWorkStation()
    {

        try
        {
            // kbhit() aus der C Runtime - bedeutet keyboard hit - irgendeine taste drücken und schon gesperrt der Computer
            if (NRMKeyboardHit() )
            {
                    // WINAPI32 native method - Lock the current Workstation/Computer - Unlock via LogOn Screen
                    LockWorkstation();
                    
            }
        }
        catch (SystemException ex)
        {

            VFLMsgBox(ex.Message, "Exception at Method::VGFLockWorkStation", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            return false;
        }

            return true;

    } // end of Method::VGFLockWorkStation
















    } // End of Class::VGFCoreNetwork

} // End of Namespace::Visual.Galaxy.Framework:VGFCoreNetwork

