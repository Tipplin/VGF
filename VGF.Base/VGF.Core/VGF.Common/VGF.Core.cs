/*#############################################################################
 * 
 * Project			:	Visual.Galaxy.Framework
 * 
 * ############################################################################
 * 
 * ----------------------------------------------------------------------------
 * Programmer       :	Project-Founder and 
 *                  :   Main-Author Christian 🧑 "Tipplin" 🧑 Kurs
 *                  :
 *                  :
 *                  :
 *                  :
 * ----------------------------------------------------------------------------
 * Part		    : VGF.Core
 * ----------------------------------------------------------------------------
 * Base Class       :	
 * ----------------------------------------------------------------------------
 * Dependencies     :   Visual.Operation.Library.dll    - C# Assembly as Friend
 *                  :   Visual.Registry.Library.dll     - C# Assembly as Friend
 *                  :   Visual.Security.Library.dll     - C# Assembly as Friend
 *                  :
 * ----------------------------------------------------------------------------
 * ;---------------------------------------------------------------------------
 * ; NOTE:
 * ;---------------------------------------------------------------------------
 * ; all outside executables like psr.exe can into Project-Solution as Resource
 * ; in Folder Resources. (psr is an windows tool - problem step recorder),
 * ;
 * ;
 * ;---------------------------------------------------------------------------
 * ;REVISION HISTORY:
 * ;---------------------------------------------------------------------------
 * ; 0.0            :   initial startup
 * ;---------------------------------------------------------------------------
 * ;
 * ;
 * ;---------------------------------------------------------------------------
 * ;
 * ;
 * ----------------------------------------------------------------------------
 * Copyright © 2017 - 2021 by  
 * Visual Galaxy Framework Community Kernel Developer Team
 * ----------------------------------------------------------------------------
 * by Head-Author: Christian 🧑 "Tipplin" 🧑 Kurs - 👀 Visual C# Developer 👀
 * ----------------------------------------------------------------------------
 * Portions Copyright © 2017 - 2021 by Microsoft Corporation GmbH.
 * ----------------------------------------------------------------------------
 * 
 * We are currently looking for collaborators. 
 * If you have rich experience in writing 
 * generic framework or enterprise application, 
 * 
 * please contact me at Google Mail:
 * 🧑 kurschristian@gmail.com  🧑
 * 
 * 
 * 
 * ============================================================================
 * ============================================================================
 * 
 * Developer Tipplin 🧑 - 🚧 WARNING 🚧 - :
 * ----------------------------------------------------------------------------
 * ----------------------------------------------------------------------------
 * Tippo Tip:
 * At Time to Time the System Clock the system time after in seconds and 
 * milliseconds range, means the Local Time in a Country.
 * For Germany:
 * download the PTB - ATOM-Clock show Second/Millisecond on after?
 * click right side in taskbar on Date/Time,
 * open Windows Settings goes to Time and Language,
 * stand an Time Server for Time synchronization, click it.
 * Time Server for Windows: time.windows.com
 *  
 * 
 * ============================================================================
 * Warning:
 * ============================================================================
 * This product is licensed to you pursuant to the terms of the 
 * VGF license agreement included with the original software, and is
 * protected by copyright law and international treaties.
 * 
 * Unauthorized reproduction or distribution may result in severe civil and 
 * criminal penalties, and 
 * will be prosecuted to the maximum extent possible under the law.
 * 
 * You cannot distribute a compiled version of 
 * this code without prior registration.
 * 
 * Please see the documentation supplied with 
 * the VGF Libraries for further details.
 * 
 * Authored by Copyright © 2017 - 2021 by 
 * Visual Galaxy Framework Community Kernel Developer Team.
 * All rights reserved.
 * 
 * May be redistributed for free, but may not be sold without 
 * the author's explicit permission.
 * 
 * This software is Copyright © 2017 - 2020 by 
 * VGF-Technologies at VGF-KernelTeam
 * You may only use this software if you are an 
 * authorized licensee of an VGF developer tools product.
 * 
 * This software is considered a Redistributable as defined under
 * the software license agreement that comes with the VGF Products
 * and is subject to that software license agreement.
 * 
 * ----------------------------------------------------------------------------
 * Microsoft make Restrictions of Export for following Countries:
 * ----------------------------------------------------------------------------
 * This software is subject to the U.S. Export Administration Regulations and 
 * other U.S.law, and may not be exported or re-exported to certain countries
 * (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or
 * to persons or entities prohibited from receiving U.S.exports
 * (including Denied Parties, Specially Designated Nationals,
 * and entities on the Bureau of Export Administration Entity List or
 * involved with missile technology or nuclear, chemical or biological weapons)
 * ----------------------------------------------------------------------------
 * © 1982 - 2021 Microsoft Corporation.All rights reserved.
 * ----------------------------------------------------------------------------
 * Same sourcecode by Microsoft, so we marked with Copyright !.
 * © 1982 - 2021 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
 * Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
 * ----------------------------------------------------------------------------
 * DON'T CHANGE OR DELETE ANYTHING IN SECTION !!!.
 * ----------------------------------------------------------------------------
 * VFGCore written by
 *                      Christian 🧑 "TIPPLIN" 🧑 Kurs
 *                      Ahornweg 1
 *               - G -  53177 Bonn
 *                      Germany - Allemagne - Duitsland
 * ----------------------------------------------------------------------------
 * mobile		: 0049 1734593440
 * voice		:  
 * Skype		:
 * E-mail               : kurschristian@gmail.de
 * Community Website    :
 * 
 * -----------------------------------------------------------------------------
 * This software is supplied as is. 
 * 
 * Use it at your own  💥 RISK 💥!!!!.
 * 
 * Obviously I've tried to do the best job possible.
 * If you find any problem with it, let me know.
 * With any luck, Visual Galaxy Framework will make it obsolete anyway
 * ----------------------------------------------------------------------------
 * License:
 * ----------------------------------------------------------------------------
 * NO fee for NON-Commercial use our Community Website:
 * ----------------------------------------------------------------------------
 * 
 * 
 * 
 * ----------------------------------------------------------------------------
 * Honest Business Users, to use our compiled Versions, 
 * please call us to send you our Business Licenses.
 * or 
 * our Business Website:
 * 
 * 
 * 
 *############################################################################# 
 */

/*********************** Developer Disclaimer *********************************
 *
 * Copyright © 2017 - 2021 by Christian 🧑'Tipplin'🧑 Kurs - Germany
 * 
 ******************************************************************************
 * English:
 *-----------------------------------------------------------------------------
 * 
 * 
 * Mariott Hotel Bonn - Restaurant KONRAD's Chief Alexander Stadler
 * https://www.youtube.com/watch?time_continue=6&v=tOl7eh2N5Ps&feature=emb_logo
 * 
 *****************************************************************************/




/* ######################### Visual.Galaxy.Framework ##########################
 * # Start Date: 2019/01/01 - 17:00 - Ground Leaning -Initial
 * #---------------------------------------------------------------------------
 * # Freeze Date:
 * # (FREEZE: like Microsoft - stopp develop, no more codes into project,
 * # - but develop goes on - compiling to R T M )
 * #---------------------------------------------------------------------------
 * # ! NOTE ! Develop are going on, new an features in later build.
 * #---------------------------------------------------------------------------
 * #
 * #
 * #
 * ############################################################################
 * ############################################################################
 * 
 * ############################################################################
 * 
 * DON'T CALL WINDOWS SYSTEM FUNCTIONS DIRECTLY WITH EXTENTION  - Ex -
 * 
 * ############################################################################
 * Windows Operation System call this permanent at Time !. 
 * ()
 * Please write Visual C# Wrapper as here !!!. (Indirect Call)
 * ############################################################################
 * 
 *
 * ################ MICROSOFT INFO ############################################
//----------------------------------------------------------------------------
// <!-- Microsoft Portability, Globalization, Design automatic active! -------
// <!-- Microsoft.Interoperability -------------------------------------------
// <!-- Microsoft Portability ------------------------------------------------
// <!-------------------------------------------------------------------------
// <!-- For native unmanaged Methods, must be written in three Classes: ------
// <!-- Class NativeMethods-------- Stackwalk execute -----------------------
// <!-- NO! [SuppressUnmanagedCodeSecurityAttribute] ------------------------
// <!-------------------------------------------------------------------------
// <!-- Class SafeNativeMethods---- Stackwalk non execute
// <!-- with [SuppressUnmanagedCodeSecurityAttribute]
// <!--------- NO Security Check !, when set this Attribute, also ATTENTION!
// <!-- without  Full Security Check with Attribute
// <!-- NON! dangerous and Risk for User Calls.
// <!-----------------------------------------------------------------------------
// <!-- Class UnsafeNativeMethods-- Stackwalk non execute
// <!-- with [SuppressUnmanagedCodeSecurityAttribute]
// <!-- with Security-Risk, so  Full Security Check with Attribute.
// <!-----------------------------------------------------------------------------
// <!-- ! drag and drop from Files Microsoft Explorer into Project-Solution,
// <!-- so you can Documentation into Project-Solution, directly start the Document,
// <!-- click on Documentname, Office: Word, Excel, Powerpoint starts !.
// <!-- qualifized Filename must be less than 260 chars, and Pathname less as
// <!-- 248 Chars. -- Visual Studio make short prefix and suffix old 8.3,
// <!-- documments names Projec~1.doc whey?
// <!-----------------------------------------------------------------------------
// <!-- Make sure start migrate for any Application you create, next Years 
// <!-- Microsoft make great changes, Windows Operation System old API's removes
// <!-- more and more .NET !, at November 2020 one Platform for all.
// <!-- New Info more then 50000 .NET API's.
// <!-- .NET 5 is the Platform for Future. More source from Windows Operation
// <!-- System - parts Windows goes open source -
// <!--  use Visual C++.NET and Visual C# with Visual Studio next.
// <!-- parts unmanaged code (native) and managed code in Windows.
// <!--
//
//#################################################################################
*/

//-----------------------------------------------------------------------------
// System-Directives from .NET Framework
//-----------------------------------------------------------------------------

#region ### Standard System-Directives ###

/*-----------------------------------------------------------------------------
 * External Dependencies
 * ----------------------------------------------------------------------------
 * All System Directives Here ! - use new .NET Framework 4.8.03752 with
 * cumulative update.
 *-----------------------------------------------------------------------------
 * Guilty as Implemented System .NET Libraries
 *-----------------------------------------------------------------------------
 * .NET Framework comes with Windows Operation System automatic.
 * All classe can show members and comments with Key F12, 
 * marked classname and push F12
 *-----------------------------------------------------------------------------
*/

using System;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Security;
using System.Security.Principal;


#endregion

/*-----------------------------------------------------------------------------
* External Dependencies:
* Windows-Directives from .NET Framework
*------------------------------------------------------------------------------
*/

#region ### Standard Windows-Directives ###

/*-----------------------------------------------------------------------------
* All Windows Directives Here ! 
* All Windows Directives begins with Windows.namespace.class.winmd
* Directory:
* 
* C:\Windows\System32\WinMetadata\ all Windows Assemblies
* Windows.AI.winmd
* Windows.System.winmd
* ... more
* 
* 
* -----------------------------------------------------------------------------
* For Developer:
* -----------------------------------------------------------------------------
* all winmd are .NET Assemblies, open with Reference Manager.
* -----------------------------------------------------------------------------
* Windows Operation System Assemblies Directory:
* 
* 
* -----------------------------------------------------------------------------
* For Developer:
* all winmd are .NET Assemblies, open with Reference Manager.
*------------------------------------------------------------------------------
* 
*/

#endregion

//-----------------------------------------------------------------------------
// namespace from Project Visual Galaxy Framework,
// Directives/namespaces from Assemblies:
//-----------------------------------------------------------------------------
// NOTE! same Library's are protected with .(HIDDEN)
// For this Project Visual.Galaxy.Framework, 
// have be open with visible Attribute in they Library's.
//-----------------------------------------------------------------------------
// same in Develop ! not complete yet !:
// Visual.Operation.Library.dll, Visual.Security.dll, 
// Visual.Resource.Library.dll, Visual.Message.Library.dll,
// Visual.Form.Library.dll, Visual.Registry.Library.dll
// Visual.Exception.Engine.dll, Visual.Virtual.Engine.dll,
//-----------------------------------------------------------------------------

/*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*/

#region ### Foreign Directives - here from other Visual C# Files ###

/*-----------------------------------------------------------------------------
 * External Dependencies - but most written with FriendlyAttribute, 
 * so you can use internal classes.
 * Is not a Directive - Assembly, 
 * Is Only a namespace from a other 
 * Visual C# name.cs file in this Project-Solution.
 * -----------------------------------------------------------------------------
 * In New Visual Studio 2019 give Options:
 * 0 (checkbox) unused Directives remove, at Build run he delete all unused!
 * 0 (checkbox) unused variable remove
 * 0 (checkbox) change datatype to var (string) = "";
 * -----------------------------------------------------------------------------
 * more support by coding, online search bar
 * Yellow lamp on left side - Compiler 'under the HOOD' , 
 * precompile codeline to codeline, check syntax, semantic and more...
 * for better and faster backend compile!.
 * -----------------------------------------------------------------------------
 * use Operation System Functions
------------------------------------------------------------------------------*/
using static Visual.Operation.System.Native.NativeMethods;

// Visual C++ - Runtimes Library Functions - ! CharSet.Cdecl
using static Visual.Operation.System.Native.NativeRuntimeMethods;

/*--------------------------------------------------------------------------------
 * Project-Maintainer 'Tippo' change  the using Visual.Function.Library to 
 * Visual.Operation.System.Native.UnsafeNativeMethods,
 * thats all Wrapper Methods from VisualFunctionLibrary.dll written in C.
 * Run analysis have Proposal made unmanaged Code into Class UnsafeNativeMethods.
 *--------------------------------------------------------------------------------
 */
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// use Style for MessageBox
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

//  Utilities, means Methodcalls at Runtime for checks:
// Windows Operation System Versions, Memory, Storage, 
// Windows Membership, Accounts,


using static Visual.Operation.System.Internal.InternalOSMethods;

#endregion

#region ### set here only Project Files for use in this namespace ###

// all over Class Application
using static Visual.Galaxy.Framework.Application.VGFApplication;

// separte only URL's here in Class.
using static Visual.Galaxy.Framework.Core.VGFCoreUrls;

#endregion


/*-----------------------------------------------------------------------------
* Visual.Galaxy.Framework
* Application Framework for great Applications
*-----------------------------------------------------------------------------
* Core:
* make global constants in class head for all other Files in Project-Solution.
* make global instancevariables.
*
* -----------------------------------------------------------------------------
*/
/*-----------------------------------------------------------------------------
 * NAME_SPACE_BEGIN::Visual.Galaxy.Framework.Core
 *-----------------------------------------------------------------------------
 * Use Windows Emoji's in Comment-Blocks, short comments... 
 * Emoji's in the Screen-Keyboard like me 🧑Tipplin🧑 as Developer Face
 * look below under class VGFCore.
 *-----------------------------------------------------------------------------
 * Members:
 * Class-Head:
 * Constants, Varaibles, Instances, short cut names with Lambda Operator =,
 * 
 * Class FrameworkException
 *----------------------------------------------------------------------------- 
*/
namespace Visual.Galaxy.Framework.Core
{
    /// <summary>
    /// Class VGFCore for all Basics
    /// </summary>
    /// <!-- Author TIPPLIN 🧑 -->
    /// If class static declare, sealed not allowed!
    /// <!-- Author TIPPLIN 🧑 -->
    /// <remarks>
    /// Globals for the Project-Solution for all others Files.
    /// Bind In, thats all!
    /// using static Visual.Galaxy.Framework.Core.VGFCore;
    /// </remarks>
    /// [ClassVersion( "1.0" ), Association, Abstract, Description("Association between basics like .NET global in VGFCore")]
    internal static class VGFCore
    {
        // /** in Visual C# not allowed ! more then two asterics like /***


        // Insert EMOJI's in your Code bzw. Commentblock  🖥 here all emoji's uni color, in Office, GitHub page in Multi Color


        /* insert emoji's with Screen - Tastatur 👩‍🦰 - 💥💫💘💓 right mouse click on taskbar, window Screemtastatur show, right on Taskbar show the sign, click it!
         * emoji's show with click smile face, choice an emoji and click it then he insert in document or here in commentblock. 😜
         */

        /*** <!-- ⚡ **WARNING** --
        */

        /*** <!-- 👉 **NOTE** --
         */

        /*** <!-- ❌ **Crictical** --
         */

        /*** <!-- ❗ **ATTENTION** --
         */

        /*** <!-- 🧶 **QUESTION** --
         */

        /*** <!-- 👁‍🗨 **FOR YOUR EYES ONLY ! --


        /*** 🚩🏴‍☠️☢🔚🗽🛠🔧⚔👀
         * 
         * chat symbols like  :)  :(  =)
         * 
         */


        // Developer Info 🧑 Performs one-time initialization 🧑


           


        /* 
         * 🧑 Tipplin-Tip: 👌 🧑 🏴
         * emoji only one colour 🧑❗, in Visual Studio Code in colors❗
         * 
         * Globals at Class-Head:
         * Class Instances fro other Classes in Project-Solution
         * Instance on Stack or Heap with new Operator.
         * Stack:
         * Struct instance
         * static Structname instancevariable;
         * Heap
         * static VGFAssemblyInfo vai = new VGFAssemblyInfo();
         * 
         * New Visual Studio Feature is intellisense window with little box
         * StringBuilder
         * sb.Capacity
         * go with mousemove at point and psuh F12 make open class StringBuilder source
         * 
         */
        #region ### Instances, instance for structs, global variables here ###

       

        /// <summary>
        /// Settings Constants for Web.config
        /// </summary>
	/// <!-- Author 🧑TIPPLIN🧑-->
	/// some constants, but only one define internal const string,
	/// the last one everytime with end semicolon ;
	/// <!-- Author 🧑TIPPLIN🧑-->
        internal const string SETTINGS_STORE_NAME = "vscode-edge-devtools",
                              SETTINGS_DEFAULT_USE_HTTPS = "",
                              SETTINGS_DEFAULT_HOSTNAME = "localhost",
                              SETTINGS_DEFAULT_PORT = "",
                              SETTINGS_DEFAULT_URL = "about:blank",
                              SETTINGS_WEBVIEW_NAME = "Elements",
                              SETTINGS_PREF_NAME = "devtools-preferences",
                              SETTINGS_PREF_DEFAULTS = ""; // end sign for constants

        /// <summary>
        /// Constant String for start Webbrowser Microsoft Edge directly,
        /// Microsoft-Edge official start the Webbrowser Edge:
        /// Microsoft-Edge:websitename
        /// by start with Process.Start(MSEdge, website);
        /// </summary>
        /// <!-- Author 🧑TIPPLIN🧑 -->
        /// NOTE: direct call is different to Internet Explorer,
        /// or under console the command start:
        /// start is an new console window, without start an new Window while
        /// start Website directly:
        /// start microsoft-edge:http://www.microsoft.com
        /// <!-- Author 🧑TIPPLIN🧑 -->
        /// <remarks>
        /// In Windows 10 Build 10000, Microsoft Edge Web Browser 
        /// with Chrominum Engine have new place in Directory:
        /// C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
        /// direct call msedge at search or console with start msedge or
        /// go into dir click on msedge.exe.
        /// </remarks>
        internal static string MSEdge = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";


        /// <summary>
        /// Individual StringBuilderBufferSize 
        /// always have a maximum size of Chararcters.
        /// Make sure, that the String is not higher/longer as the StringBufferSize is !.
        /// StringBuffers have an strong Value, not variable or maximum Capacity.
        /// </summary>
        /// <!-- 🧑Author TIPPLIN🧑 -->
        /// SizeCharSize is the static chars for an Buffersize:
        /// SizeChar1024 are 1024 chars in maxium StringBuilder and so...
        /// maximum chars is integer value: 2.147.483.647
        /// StandardBuilder sb = new 
        /// StringBuilder(StringBuilderBufferSize.SizeChar255, 
        /// StringBuilderBufferSize.SizeChar1024);
        /// sb.Capacity - StringBuilder automatic to highest value, 
        /// if the string is higher as 255 chars.
        /// -------------------------------------------------------------------
        /// StringBuilder standard is 16 chars internal set.
        /// StringBuilder sb = new StringBuilder();
        /// -------------------------------------------------------------------
        /// <!-- 🧑Author TIPPLIN🧑-->
        /// <remarks>
        /// Use only StringBuilder is 3000x faster as string,
        ///  own CACHE.
        /// Use for: Buffers, Sorted Methods, I/O Operations...
        /// </remarks>
        public enum VGFStringBuilderBufferSize
        {


            /// <summary>
            /// Buffersize 255 chars for StringBuider
            /// </summary>
            SizeChar255 = 0x200,

            /// <summary>
            /// Buffersize 1024 chars for StringBuider
            /// </summary>
            SizeChar1024 = 0x400,
            /// <summary>
            /// Buffersize 2048 chars for StringBuider
            /// </summary>
            SizeChar2048 = 0x800,
            /// <summary>
            /// Buffersize 4096 chars for StringBuider
            /// </summary>
            SizeChar4096 = 0x1000,
            /// <summary>
            /// Buffersize 8192 chars for StringBuider
            /// </summary>
            SizeChar8192 = 0x2000,
            /// <summary>
            /// Buffersize 16384 chars for StringBuider
            /// </summary>
            SizeChar16384 = 0x4000,
            /// <summary>
            /// Buffersize 32767 chars for StringBuider
            /// </summary>
            SizeChar32767 = 0x6000,
            /// <summary>
            /// Buffersize 65535 chars for StringBuider
            /// </summary>
            SizeChar65535 = 0x8000
        }

        /// <summary>
        /// Use the BufferBaseSize for Buffers - standard always 255 -
        /// </summary>
        /// <!-- 🧑Author Tippo🧑 -->
        /// can use for all Buffers you need.
        /// <!-- 🧑Author Tippo🧑 -->
        /// <remarks>
        /// Use inside StringBuilder with baseValue, 
        /// is the better way for Buffers and C++ Buffers.
        /// StringBuilder have own Cache and 3000x faster as string.
        /// </remarks>
        /// <Return>
        /// return Value = 255
        /// </Return>
        public static int VGFBufferBaseSize
        {
            get
            {
                    int BaseValue = 255;
                    var sb = new StringBuilder(BaseValue);

                    return sb.Capacity;  
            }
        }

        /// <summary>
        /// Use the BufferBaseSizeMax for Buffers - maxium 65535
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// can use for all Buffers you need.
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <remarks>
        /// Use inside StringBuilder with baseValue, 
        /// is the better way for Buffers and C++ Buffers.
        /// StringBuilder have own Cache and 3000x faster as string.
        /// </remarks>
        /// <Return>
        /// return Value = 65535
        /// </Return> 
        public static int VGFBufferBaseSizeMax
        {
            get
            {
                int BaseValueMax = 65535;
                var sb = new StringBuilder(BaseValueMax);
                return sb.Capacity;
            }
        }

        /// <summary>
        /// Set capacity for Buffers, like C++ here with 255 
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// But is the given buffer capacity greather as 255, StringBuilder he cut him!
        /// <!-- 🧑Author Tipplin🧑 -->
        internal static int capacity = 255;
        /// <summary>
        /// Class StringBuilder are 3000x faster as string.
        ///  StringBuilderCache
        /// </summary>
        /// <remarks>
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access. 
        /// </remarks>
        public static StringBuilder sbb = new StringBuilder(capacity);


        /*
         * See section StringBuilder with different maximum values. 
         * Sets instances here in ClassHead, thats allowed in Visual C#
         * Allowed: enumerators, struct's, instances, constants, file paths,
         * 
         */


        /// <summary>
        /// StringBuilder expanded
        /// </summary>
        /// <!-- 🧑Author Tipplin 🧑 -->
        /// String are slower as StringBuilder is very fast.
        /// <!-- 🧑Author Tipplin 🧑 -->
        /// <remarks>
        /// StringBuilder(minimum integer, maximum integer);
        /// he expand automatic to highest capacity !.
        /// -------------------------------------------------------------------
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access.
        /// -------------------------------------------------------------------
        /// </remarks>
        public static StringBuilder sb = new StringBuilder(255, 4096);

        /// <summary>
        /// Global in Project-Solution.
        /// StringBuilder here as expanded, minimum 255 chars and maximum 2048 chars,
        /// if minimum string is greather than 255, he expand to maximum automatic.
        /// So we have save, that he NOT cut the string after 255 chars.
        /// Standard StringBuilder set  16 chars without use expand.
        /// StringBuilder(min integer, max integer);
        /// StringBuilder is 2000x faster as string by sorted routines.
        /// Sorted Routines in System Directive: 
        /// System.Collections.Generic
        /// Class Stack
        /// Quicksort, Bubblesort...
        /// </summary>
        /// <!-- 🧑Author Tipplin 🧑 -->
        /// For no  conflicts, I have set other instancevariables!.
        /// If conflict the compiler make message, before at left side yellow lamp.
        /// Visual C# Compiler runs "under the Hood", check syntax and semantics, make helps!
        /// if codeline ok!, he precompile the codeline directly, faster backend compile!.
        /// If search infos about Keywords and others, push F1 - goes Online to Website.
        /// <!-- 🧑Author Tipplin 🧑 -->
        /// <remarks>
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access.
        /// while this set in Class-Head, so Global for all Classes and Methods...
        /// </remarks>
        public static StringBuilder sbr = new StringBuilder(255, 2048);

        /// <summary>
        /// Set StringBuilder with Expand, minimum 255 chars and maximum 1024 chars.
        /// if string greather than 255 chars, he automatic expand to maximum!.
        /// </summary>
        public static StringBuilder volname = new StringBuilder(255, 1024);

        /// <summary>
        /// Instancevariable fsname for native Operation System Function: GetVolumeInformation();
        /// 
        /// </summary>
        public static StringBuilder fsname = new StringBuilder(255, 1024);

        /// <summary>
        /// Instancevariable vgfai for Visual Galaxy Framework Assembly Info
        /// </summary>
        internal static VGFAssemblyInfo vgfai = new VGFAssemblyInfo();


        /// <summary>
        /// Class VOSAssemblyInfo from Visual.Operation.System.dll
        /// </summary>
        internal static VOSAssemblyInfo vos = new VOSAssemblyInfo();

        /// <summary>
        /// Class VSLAssemblyInfo from Visual.Security.Library.dll
        /// </summary>
        internal static VSLAssemblyInfo vsl = new VSLAssemblyInfo();



        /*
         * © 🧑Author Tipplin🧑 
         * 
         * Tipplin 🐻 👌Special Constants here  👌
         * 
         * 
         */




        /*---------------------------------------------------------------------
         * Class Uri from .NET Framework as instance 🧑
         * System.dll - namespace System.Uri
         * --------------------------------------------------------------------
         * public static Uri wuri = new Uri("<webadressname");
         * 
         * 
         *--------------------------------------------------------------------- 
         */

        #endregion

        #region ### Logging - Log-Files Constants - ###

        /// <summary>
        /// Constant string with Pathname and Folder for all Trace Log Files
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// / forward slash, see Javascript, HTML, - by Audiocontrol, Videocontrol (Website) as directory who is the Audiofile and Videofile.
        /// <!-- 🧑Author Tipplin🧑 -->
        internal static string TraceFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\IFTTraceFiles";

        /// <summary>
        /// Constant string with Pathname and Folder for all Console Log Files
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// <!-- 🧑Author Tipplin🧑 -->
        internal static string ConsoleFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\ConsoleFiles";

        /// <summary>
        /// Constant string with Pathname and Folder for all System Log Files
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// <!-- 🧑Author Tipplin🧑 -->
        internal static string SystemFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.FrameworkC:\SystemFiles";

        /// <summary>
        /// Constant string with Pathname and Folder for all Framework Log Files
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// @ sign for unicode sign, so only one \ backward slash in Pathname !
        /// <!-- 🧑Author Tipplin🧑 --> 
        internal static string FrameworkFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.FrameworkC:\FrameworkFiles";

        /// <summary>
        /// For internal Visual Galaxy Framework Log File path
        /// </summary>
        internal static string FrameworkLogFile = @"C:\Users\Tippo\Project_Visual_Galaxy_Framework\Visual.Galaxy.Framework\Visual.Galaxy.Framework\Visual.Galaxy.FrameworkC:\FrameworkLogFiles";

        /// <summary>
        /// Current Versionnumber of Visual Galaxy Framework
        /// </summary>
        internal static string VGFrameworkVersion = vgfai.VGFVersion.ToString();

        #endregion


        /*------------------- CLASS HEAD INFO ----------------------------------------------------
         * See class-instances with instance variable in Class Head, this is allowed in Visual C#,
         * make a global effect for all classes and Methods in Project-Solution and our C# Files.
         * using static VGF.Core.VGFCore;
         *----------------------------------------------------------------------------------------
         * For All Classes own or .NET, want show all Members and 
         * info marked classname and push F12
         *---------------------------------------------------------------------------------------- 
         */
        #region ### Global Class Instances - own and .NET FX ###



        /// <summary>
        /// .NET Class Process, starts Application with Process.Start(appname) and more
        /// </summary>
        internal static Process process = new Process();



        /// <summary>
        /// Global in Project-Solution  🚧
        /// Class VGFAssemblyInfo Instance with instancevariable vai, 
        /// so can use in Methods the static properties from Class VGFAssemblyInfo, 
        /// this Class VGFAssemblyInfo is NOT normally in AssemblyInfo.cs
        /// All Properties are all Information about the Assembly.
        /// </summary>
        /// <!-- 🧑Author Tippo🧑 -->
        /// Make different names for Class AssemblyInfo, if not the compiler make error message,
        /// set first letter the short Assemblyname:
        /// VGF = Visual Galaxy Framework   = VGFAssemblyInfo
        /// VSL = Visual Security Library   = VSLAssemblyInfo
        /// VEE = Visual Exception Engine   = VEEAssemblyInfo
        /// VFL = Visual Form Library       = VFLAssemblyInfo
        /// VRL = Visual Resource Library   = VRLAssemblyInfo    
        /// <!-- 🧑Author Tippo🧑 -->
        /// <remarks>
        /// NOW ! 
        /// but don't forget 'private' is degree of protection, no access!
        /// must set public for outside access.
        /// </remarks>
        public static VGFAssemblyInfo vai = new VGFAssemblyInfo();
        
        /// <summary>
        /// .NET Class DirectoryInfo - Exists Dir...
        /// </summary>
        /// <!-- 🧑Author Tippolin🧑 -->
        ///  Class Instance
        /// <!-- 🧑Author Tippolin🧑 -->
        /// <remarks>
        /// Class Directory
        /// pplies access control list (ACL) entries described by a System.Security.AccessControl.DirectorySecurity
        /// object to the directory described by the current System.IO.DirectoryInfo object.
        /// 
        /// directorySecurity:
        /// An object that describes an ACL entry to apply to 
        /// the directory described by the path parameter.
        /// SetAccessControl(DirectorySecurity directorySecurity);
        /// </remarks>
        internal static DirectoryInfo dr = new DirectoryInfo(TraceFile);
        
        /// <summary>
        /// .NET Class StreamWriter - write into File
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// .Flush() write complete Block into File.
        /// .Flush() everytime before .Close() the File !.
        /// if not he close file, but nothing write into file!.
        /// DON'T FORGET .Close(); - if so, the File continue open and no access more and can block the System.
        /// Tipplin Tip: write .Close(); into try/catch block - finally
        /// finally is ultimate free resource, If Exception ot NOT !.
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <remarks>
        /// 
        /// </remarks>
        public static StreamWriter sw = new StreamWriter(fs);

        /// <summary>
        /// .NET Class StreamReader - read from a File
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 -->
        public static StreamReader sr = new StreamReader(TraceFile);

        /// <summary>
        /// .NET Class FileStream instance with instancevariable fs.
        /// </summary>
        /// <!--  🧑Author Tipplin🧑 -->
        /// 
        /// <!--  🧑Author Tipplin🧑 -->
        /// <remarks>
        /// Provides a System.IO.Stream for a file, 
        /// supporting synchronous and asynchronous reads and writes.
        /// </remarks>
        public static FileStream fs = new FileStream(TraceFile, FileMode.OpenOrCreate | FileMode.Append);

        /// <summary>
        /// .NET Class DateTime - Problem is USA to Europe here Germany, 
        /// USA last year make leap second minute have now 60 seconds not 59 - old 12:59:59 new 12:00:60 -> 12:01:00
        /// Problem by Windows Clock must be everytime syncronize the clock with Windows Time Server -> Option Time+Language
        /// Time Server: time.windows.com - every date check the Clock and time - Germany high different was 2 seconds.
        /// Tip Tipplin: install the PTB Clock (Atomclock) written in Javascript as Website:https://uhr.ptb.de/
        /// Class DateTime:
        /// IsLeapYear(int year)
        /// DaysInMonth(int year, int month);
        /// Show all Class Members with marked classname and push F12
        /// </summary>
        public static DateTime dt = new DateTime();

        /// <summary>
        /// Set static instance for Class WindowsIdentity for all other Classes and Methods.
        /// </summary>
        internal static WindowsIdentity id = WindowsIdentity.GetCurrent();

        /// <summary>
        ///  Set static instance for Class WindowsPrincipal for all other Classes and Methods.
        /// </summary>
        internal static WindowsPrincipal p = new WindowsPrincipal(id);


        #endregion


        /// <summary>
        /// Class Constructor VGFCore
        /// <!-- 🧑Author Tipplin🧑 -->
        /// You can set Statements, Logs, Calls, Messages and Validation
        /// if class declare static, the Constructor same static, without not allowed!.
        /// <!-- 🧑Author Tipplin🧑 -->
        /// </summary>
        static VGFCore()
        {

            //-----------------------------------------------------------------
            // into class constructor and check is 64BIT System, 
            // if NOT terimate it.
            // X64 is short name for property set with Lambda Operator.
            //-----------------------------------------------------------------
            if (!X64)
            {
                // our Method from Visual.Operation.System.dll
                // same Functions from Windows Operation System, here VFLMsgBox from VFL.dll - C/C++ Functions.
                // Enumerator STYLES with Buttons, Icons, 
                // Flag MsgBoxSetForeground
                // Flag AppModal, TaskModal, SystemModal
                VFLMsgBox("The current Operation System is NOT 64BIT !.", "Visual Galaxy Framework - Operation System Info", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // exit C Runtime Function from mscrt.dll is an 64BIT Dynamic Link Library.
                // and Enumerator EXIT_CODES all ERROR CODES.
                NRMExit(EXIT_CODES.ERROR_OLD_WIN_VERSION);


                // Visual C++ Runtime Library Function for Exit the Program. (use msvcrt.dll only 64BIT Library.)
                // Enumerator EXIT_CODES for all ExitCodes.
                // terminate Program with Wrong Operation System.
                NRMExit(EXIT_CODES.ERROR_APP_WRONG_OS);
            }

            //
            // First set this, next with validation.
            //
            // vgfmessage as public static for all classes/files in Class VGF.Core
            vgfmessage = "Have you a License ? Master ! No than I Terminate\n\n";
            vgfmessage += "Copyright © 2019 by  Visual Galaxy Framework Community Kernel Developer Team.\n";
            vgfmessage += "Copyright © 2019 by Christian 'TIPPO' Kurs - Project-Founder and Main-Author\n";
            vgfmessage += "Portions Copyright © 2019 by Microsoft Corporation GmbH. \n";
            //
            // Our famous MessageBox with Message, Title and the enumerator STYLES for Button, Icon, StandaloneMessageBox in Foreground and System Modal
            // VFLMsgBox from Visual.Function.Library.dll - native C Function, use MessageBoxW from Windows Operation System.
            //
            VFLMsgBox(vgfmessage, "Visual Galaxy Framework - License", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

            /*-----------------------------------------------------------------
             * IDEA HERE:
             * ================================================================
             * Use our Visual Galaxy Framework, we protocol all Windows Actions
             * for more Safety first and better Exception Handling,
             * we start automatic 
             * in hidden background the Windows System Protocoller,
             * for all Windows System Events, User events and more...
             * NO UserInformation or other Information without User Permission.
             * The Windows System Protocol File is open 
             * for the current user on this Computer, for others is denied.
             * ----------------------------------------------------------------
             * For Developers:
             * Windows Operation System have an own Protocoller
             * psr.exe, must be started at runtime the System.
             * Is the Problem Step Recorder with all System and User actions:
             * Mouse move, Keyboard pushes and more...
             * Microso HTML Format saved, is filename.mhtm, 
             * can read with Webbrowser.
             * or do into .zip file and send to:
             * App Author by Exception in Application.
             * 
             *----------------------------------------------------------------- 
             */








        } // CLASS_END::VGFCore::Constructor

        /*---------------------------------------------------------------------
         * Struct as class.
         * Struct/class allowed
         * assignments,
         * Method calls,
         * Property calls,
         * 
         * --------------------------------------------------------------------
         * [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
         * struct structname
         * or
         * class Structname 
         * 
         * --------------------------------------------------------------------
         *  Assembly _foundDllAssembly;
         *  only allowed when the main Class Constructor without static
         *  Class Constructor with parameter and 
         *  base initialize an new instance od teh object class
         *  internal VGFCore(string file):base(file, null)
         *  {
         *      _foundDllAssembly = 
         *      System.Reflection.Assembly.ReflectionOnlyLoadFrom(file);
         *  }
         * 
         * --------------------------------------------------------------------
         *  by static class not allowed ! constructor with access modi public
         *  and an static class construtor must be parameterless !
         *  public VGFCore()
         *  {
         *      InitializeComponent();
         *      cmbInputFolder.Text = 
         *      Properties.Settings.Default.LastusedFolder;
         *      CallMethod();
         *  }
         * 
         * --------------------------------------------------------------------
         * .cctor = class constructor in Microsoft IL
         * .cdtor = class destructor in Microsoft IL but is hidden.
         * static class no destructor allowed !.
         * 
         * --------------------------------------------------------------------
         * NOTE:
         * ~destructor, must have statements, calls, logs or other,
         * but NOT null or empty, the destructor via GC runs in an idle.
         * the system performance goes down.
         * The GCWorkstation or GCServer destroy the last class first,
         * buttom to top.
         * GCWorkstation everytime install by .NET Framework,
         * two versions .NET Framework 32BIT and .NET Framework 64 BIT.
         * C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
         * Have .NET Framework 64BIT you can config GCServer in File:
         * nameofProjectSolution.config
         * manually into this file
         * <runtime>
         *      <gcServer enabled="true"></gcServer>
         * </runtime>
         * 
         * avantages:
         * All Windows Operation System NUMA Function (under 64 BIT) for use
         * Gets or sets a value that indicates whether a full blocking garbage 
         * collection compacts the large object heap (LOH).
         * 
         * 
         *--------------------------------------------------------------------- 
        */

        /// <summary>
        /// Class VGFRemote
        /// </summary>
        static class VGFRemote
         {

            /// <summary>
            /// 
            /// </summary>
            static VGFRemote()
            {
                // First set this, next with validation.
                vgfmessage = "Thank you for use our Framework, if any Problem or Exception,\n";
                vgfmessage += "send it us: per Website or Email. see our Methods for directly send it!.\n";
                vgfmessage += "Any Suggestion or any other welcome !.\n\n";
                vgfmessage += "Copyright © 2017-2021 by  Visual Galaxy Framework Community Kernel Developer Team.\n";
                vgfmessage += "Copyright © 2017-2021 by Christian 'Tipplin' Kurs - Project-Founder and Main-Author\n";
                vgfmessage += "Portions Copyright © 1982-2021 by Microsoft Corporation GmbH. \n";

                VFLMsgBox(vgfmessage, "Visual Galaxy Framework - Remote", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }





            // Set UNC .\\.\\
            /// <summary>
            /// Remote System in Windows 10 Professional OS-Build 18362.116 Official Final Release.
            /// Remote Procedure Call - rpc32.dll
            /// Remote Server Client DLL
            /// 
            /// </summary>
            /// <!-- 🧑Author Tipplin🧑 -->
            /// 
            /// <!-- 🧑Author Tipplin🧑 -->
            public static string VGFRemoteServerName = VGFServerName("");
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteComputerName = VGFComputerName();
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteSecureKeyName = "";
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteValueName = "";
            /// <summary>
            /// 
            /// </summary>
            public static bool VGFRemoteIsReference = false;
            /// <summary>
            /// 
            /// </summary>
            public static string VGFRemoteAuthorDirectly = VGFToAuthorDirectly();



            /// <summary>
            /// Wrapper,  set ServerName and give returned to Classmember RemoteServerName
            /// </summary>
            /// <param name="ServerName"></param>
            /// <returns></returns>
            internal static string VGFServerName(string ServerName)
            {
                return ServerName;

            }

            /// <summary>
            ///  USE
            /// </summary>
            /// <!-- 🧑Author Tipplin🧑 -->
            /// Lock Application, means the User can't close the Application,
            /// an I/O Operation is now running, most by multi threads on 64BIT System on multiple CPUkernels
            /// CPUKernel starts by 0 to 64, but don't use CPUKernel 0 is the Operation System.
            /// GPUKernels for calculation, financial calculation, GPUKernel 1000 faster as the CPU.
            /// Move the Operation from CPU to GPU and return.
            /// <!-- 🧑Author Tipplin🧑-->
            /// <returns>
            /// boolean as string true or false
            /// </returns>
            public static string VGFLockApplication()
            {
                try
                {
                    VGFApplicationLockRunningOperation(true);
                    return bool.TrueString;
                }
                catch(ApplicationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return bool.FalseString;

                }
            }




            /*
             * Info to sign <runtime == section runtime in xml-config
             * the sign < is not allowed in normal comment blog.
             * so i have set -runtime- for <runtime</runtime in .config file
             */


            /// <summary>
            /// Get Garbage Collection Status, 
            /// means run the GCWorkstation or GCServer.
            /// project-solution-name.config
            /// </summary>
            /// <!-- 🧑Author Tipplin🧑 -->
            /// NOTE! Project-Solution has more than standard file from Visual Studio automatic:
            /// but hidden, must be load into Project Solution Map, stand in Project Paths
            /// your Projectname: Asssemblynamedll.config
            /// .editorconfig
            /// app.config
            /// 
            /// 
            /// 
            /// 
            /// gcWorkstation now is standard by install .NET Framework.
            /// gcServer must be actived Asssemblynamedll.config
            /// section -runtime--/runtime-
            /// see here under File:
            /// 
            /// ❗ Visual.Galaxy.Framework.dll.config ❗
            /// in this Project-Solution.
            /// ---------------------------------------------------------------
            /// Better coding with VeryLargeObjects, VeryLargeObjectHeap, NUMA,
            /// 
            /// but must be an 64 BIT System ! and 64 BIT .NET Framework !.
            /// ---------------------------------------------------------------
            /// <!-- 🧑Author Tipplin🧑 -->
            /// <remarks>
            /// Gets a value that indicates whether 
            /// server garbage collection is enabled.
            /// </remarks>
            /// <returns>
            /// The following example indicates whether the host computer
            /// is using server or workstation garbage collection. 
            /// </returns>
            public static string VGFGetGCState()
            {
                string result;

                // query Is gcServer Garbage Collector is set?
                if (GCSettings.IsServerGC == true)
                {
                    // ❗ ONLY ON 64BIT OS-System ❗ and 64BIT .NET FRAMEWORK.❗
                    result = "gcServer";
                }
                else
                {
                    // ‼ Is the standard by Installed .NET Framework as GC Workstation ‼
                    result = "gcWorkstation";
                }

               return string.Format("The {0} Garbage Collector is running.", result);

            }
	    
            /// <summary>
            /// Get NetBIOS-Computername
            /// </summary>
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// use here  Class SystemInformation from .NET Framework 4.8.03752
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// <remarks>
            /// ---------------------------------------------------------------------
            /// Use Class SystemInformation from 
            /// namespace System.Windows.Forms,
            /// here are more then 300 Classes for use!.
            /// ---------------------------------------------------------------------
            /// Tip: Make your own Webbrowser
            /// Class Webbrowser...
            /// Create Form - Allows the user to navigate to web pages within a form.
            /// Method GoBack():
            /// Causes the System.Windows.Forms.WebBrowser control 
            /// to navigate to the previous page (if any) in the navigation history.
            /// ---------------------------------------------------------------------
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            internal static string VGFComputerName()
            {
                // Class SystemInformation from namespace System.Windows.Forms, have 300 classes
                return SystemInformation.ComputerName;
            }

            /// <summary>
            ///  Send directly to Author via URL
            /// </summary>
            /// <!-- 🧑Author Tipplin 🧑 -->
            ///  
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// <remarks>
            /// If any Problem or Exception in codeparts, 
            /// we can send later directly to Author on Website/Webserver or GitHub Connect.
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static string VGFToAuthorDirectly()
            {
                return vgfdevTipplinVGFKernelTeam.OriginalString;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// 
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static string VGFWebSiteCommunityInvestigativ()
            {
                try
                {
                    // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                    // string microsoft-edge:websitename or URL
                    // our Website Community Investigativ
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" + vgfCommunityInvestigativ.OriginalString);

                    // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                    // but must change bool in Method-declaration into string as returned datatype.
                    return true.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false.ToString();
                }



            } // END_OF_METHOD::VGFWebSiteCommunityInvestigativ

            /// <summary>
            /// Start Community Help Website
            /// </summary>
	    /// <!-- 🧑Author Tipplin 🧑 -->
            /// 
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// <returns></returns>
            public static string VGFWebSiteCommunityHelp()
            {

                try
                {
                    // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                    // string microsoft-edge:websitename or URL
                    // Our Website Community Helpful & Respectful
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe" + vgfCommunityHelp.OriginalString);

                    // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                    // but must change bool in Method-declaration into string as returned datatype.
                    return true.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false.ToString();
                }
            } // END_OF_METHOD::VGFWebSiteCommunityHelp

            /// <summary>
            /// Start Microsoft Webbrowser EDGE
            /// </summary>
	    /// <!-- 🧑Author Tipplin 🧑 -->
            /// 
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// <returns>
            /// boolean string - True/False as string return.
            /// </returns>
            public static string VGFStartEdgePure()
            {

                try
                {
                    // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                    // string microsoft-edge:websitename or URL
                    // Our Website Community Helpful & Respectful
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");

                    // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                    // but must change bool in Method-declaration into string as returned datatype.
                    return true.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    return false.ToString();
                }

            }




            /// <summary>
            ///  Method ToUserDirectlyReturned
            /// </summary>
	    /// <!-- 🧑Author Tipplin 🧑 -->
            /// everytime HIDDEN in this Codepart.
            /// <!-- 🧑Author Tipplin 🧑 -->
            /// <param name="User"></param>
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static string VGFToUserDirectlyReturned(string User)
            {
                // Class System.Web
                // HTTP PostedFile, update file with Fixes.
                // or
                // as Remote Email with .zip file.

                return User;
            }


        } // END_OF_CLASS::VGFRemote

        /// <summary>
        /// Get the current GUID of Windows Operation Systems
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// NOTE: 
        /// found in Setup.bin is binary file, but with Windows XML Block.
        /// ATTENTION:
        /// UNCHECKED
        /// With any new update change GUID's.
        /// <!-- 🧑Author Tipplin🧑 -->
        internal static class VGFWindowsOperationSystemGUIDS
        {

            /******************************************************************
             * GUID (128BIT key)  Is a unique identifier for an application
             * Here for all Windows Operation Systems:
             * ! Sample from setup.bin is compiled !
             * 
             * GUID's in an XML block readable
             * any Windows Operation System have an GUID.
             * supportedOS operation system mit GUID-numbers:
             *
             *****************************************************************/

            /// <summary>
            /// GUID Windows 10 - General Unique Identification Key
            /// </summary>
            /// <!-- 🧑Author Tipplin🧑 -->
            /// unchecked by new updates, change the GUID by Windows Operation System 10
            /// <!-- 🧑Author Tipplin🧑 -->
            /// <remarks>
            /// Microsoft GUID's by Operation Systems and .NET Assemblies - unicate key 128 Bit.
            /// Apple UUID
            /// 
            /// </remarks>
            public const string GUIDSupportedOperationSystem10 = @"8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a";

            /// <summary>
            /// GUID Windows 8.1
            /// </summary>
            public const string GUIDSupportedOperationSystem81 = @"1f676c76-80e1-4239-95bb-83d0f6d0da78";

            /// <summary>
            /// GUID Windows 8.0
            /// </summary>
            public const string GUIDSupportedOperationSystem8 = @"4a2f28e3-53b9-4441-ba9c-d69d4a4a6e38";

            /// <summary>
            /// GUID Windows Vista
            /// </summary>
            /// <remarks>
            /// DON'T use Windows Vista !, 
            /// please make update! s uncorrectness and many Errors inside !.
            /// NO SUPPORT!
            /// </remarks>
            public const string GUIDSupportedOperationSystemVista = @"e2011457-1546-43c5-a5fe-008deee3d3f0";

            /// <summary>
            /// GUID Windows 7
            /// </summary>
            public const string GUIDSupportedOperationSystem7 = @"35138b9a-5d96-4fbd-8e2d-a2440225f93a";


        }




        /// <summary>
        /// The set of constants required for across various(Communication, CrossPlatform, etc.) modules.
        /// string constants with sign @ for unicode string is UTF16
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// Set here all global constants for strings.
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <remarks>
        /// Set instancevariable for class VGFAssemblyInfo - Visual Galaxy Framework
        /// </remarks>
        public static class VGFCoreConstants
        {

            #region constants only for this Project-Solution

            /// <summary>
            /// Counter
            /// </summary>
             internal static int INSTANCECOUNT = 0;

            /* 
             * These values are the builtin defaults, 
             * mainly useful for testing purposes, or 
             * if the user is uninterested in setting a value.
             * 
             */

             internal static int DEFAULT_NUM_FILES = 5;

             internal static int DEFAULT_NUM_HEADER_FILES = 1;

             internal static int DEFAULT_NUM_MACROS = 10;

             internal static int DEFAULT_NUM_LIB_MACROS = 30;

             internal static int DEFAULT_MAX_MACRO_ARGS = 5;

             internal static int DEFAULT_NUM_ENUMS = 10;

             internal static int DEFAULT_NUM_LIB_ENUMS = 30;

             internal static int DEFAULT_NUM_ENUMERATORS = 10;

             internal static int DEFAULT_NUM_STRUCTS = 10;

             internal static int DEFAULT_NUM_LIB_STRUCTS = 30;

             internal static int DEFAULT_NUM_FIELDS = 20;

             internal static int DEFAULT_NUM_CLASSES = 10;

             internal static int DEFAULT_NUM_LIB_CLASSES = 30;

             internal static int DEFAULT_NUM_METHODS = 20;

             internal static int DEFAULT_NUM_FUNCTIONS = 100;

             internal static int DEFAULT_NUM_LIB_FUNCTIONS = 300;

             internal static int DEFAULT_MAX_FUNCTION_ARGS = 8;

             internal static int DEFAULT_FUNCTION_LENGTH = 20;

             internal static int DEFAULT_FUNCTION_DEPTH = 3;

             internal static int DEFAULT_LIB_PERCENT = 10;



            #endregion


            #region Short Descript with Lambda-Opertor

            /// <summary>
            /// ATTENTION ! if accessmodi set private or without name, not by used.
            ///  or set public !.
            /// private is standard in Visual C# without set the private statement.
            /// private has now an degree of protection !, no access by other .cs files.
            /// </summary>
            /// <!-- 🧑Author Tippo🧑 -->
            /// Set short cut names, assignment to a value or string with Lambda Operator =
            /// <!-- 🧑Author Tippo🧑 -->
            internal static int NUM_FILES = DEFAULT_NUM_FILES;

            /// <summary>
            /// 
            /// </summary>
            internal static int NUM_HEADER_FILES = DEFAULT_NUM_HEADER_FILES;


            #endregion


            #region ### All Constants for this Project ###

            /// <summary>
            /// The Company Name of this Framework
            /// </summary>
            public static string COMPANY_NAME = vai.VGFCompany;

            /// <summary>
            /// GUID_number for Assembly - Visual Galaxy Framework
            /// </summary>
            public static string VGF_GUID = vai.VGFAssGUID;

            /*
             * sign @ for unicode sign - Unicode Version 12.1.0 - 07.05.2019 -
             * 
             */


            /// <summary>
            /// constant Name for VGF
            /// </summary>
            public const string PROJECT_NAME = @"© Visual Galaxy Framework";

            /// <summary>
            /// Description of Visual Galaxy Framework
            /// </summary>
            public const string VGF_DESCRIPTION = @"© Visual Galaxy Framework - Application Framework - On GitHub";

            /// <summary>
            /// License Description
            /// </summary>
            public const string VGF_LICENSE_DESCRIPTION = @"This is an unlicensed Version !, Please licensed by our Community";

            /// <summary>
            /// The default language
            /// </summary>
            public const string DEFAULT_LANGUAGE = @"en-US";

            /// <summary>
            /// Versionnumber of Visual Galaxy Framework
            /// </summary>
            public static string VGF_VERSION = vai.VGFVersion;

            /// <summary>
            /// Name of Author
            /// </summary>
            /// <remarks>
            /// @ sign for unicode UTF16,
            /// make special sign like '', "" without espace sign
            /// </remarks>
            public const string MAIN_AUTHOR = @"Christian '🧑Tipplin🧑' Kurs - Project-Founder / Maintainer";

            /// <summary>
            /// 
            /// </summary>
            public const string TAGS = @"live preview";


            /// <summary>
            /// Number of character should be logged on child process exited with
            /// error message on standard error.
            /// </summary>
            public const int STANDARD_ERROR_MAX_LENGTH = 8192; // 8 KB

            /// <summary>
            /// 
            /// </summary>
            public static string DEFAULT_IMAGE_FILENAME = "";

            /// <summary>
            /// 
            /// </summary>
            public static string NETWORK_NAME = "";

            /// <summary>
            /// 
            /// </summary>
            public static string CLIENT_ID = "";

            /// <summary>
            /// 
            /// </summary>
            public static string REDIRECT_URL = "";

            /// <summary>
            /// 
            /// </summary>
            public static string SCOPES = "";

            /// <summary>
            /// 
            /// </summary>
            public static string PROTECTED_RESOURCE_URL = "";

            /// <summary>
            /// 
            /// </summary>
            public static string SUBJECT_TEXT = "";

            /// <summary>
            /// 
            /// </summary>
            public const string CLIENT_ID_FOR_USER_AUTHORITY = "";

            /// <summary>
            /// Admin consent flow
            /// </summary>
            public const string TENANT = "";

            /// <summary>
            /// 
            /// </summary>
            public const string AUTHORITY_URI = "";

            /// <summary>
            /// 
            /// </summary>
            public const string REDIRECT_URI_FOR_APP_AUTHORITY = "";

            /// <summary>
            /// 
            /// </summary>
            public const string CLIENT_ID_FOR_APP_AUTHORITY = "";

            /// <summary>
            /// 
            /// </summary>
            public const string CLIENT_SECRET = "";

            /*
             * Folder/File/Path Limits
             * if greather as Limit, he cut the File/Path by drag and drop
             * paste in Visual Studio in as Document 8.3 PROJEC~1.doc
             * 
             */

            /// <summary>
            /// Start Dir for NEW Microsoft Webbrowser EDGE with Chromium Engine.
            /// </summary>
            /// <!-- 🧑Author Tipplin🧑 -->
            /// New, Edge is in separte Dir Microsoft\Edge\Application,
            /// so you can call directly the Edge App with click,
            /// in command line (Console Window) call Edge with start command,
            /// start msedge.
            /// sign @ for unicode, so only one slash !.
            /// <!-- 🧑Author Tipplin🧑 -->
            public const string MSEdgeStart = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

            /// <summary>
            /// Limit for Filename, but note take 260 -1 for safe, no overflow !
            /// </summary>
            public const int FILENAME = 260;

            /// <summary>
            /// Limit for Pathname, but note take 248 -1 for safe, no overflow !
            /// </summary>
            public const int PATHNAME = 248;

        }

        #endregion

        /// <summary>
        /// class VGFWorldWide
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑-->
        /// separate from an Website
        /// <!-- 🧑Author Tipplin🧑 -->
        ///
        /// <remarks>
        /// first array - 190 World Countries
        /// second array - all USA States.
        /// </remarks>
        public static class VGFWorldWide
        {

            /// <summary>
            /// 190 World Countries
            /// </summary>
	    /// <!-- 🧑Author Tipplin🧑-->
	    /// World Countries into string Array,
	    /// begins by Index 1
	    /// <!-- 🧑Author Tipplin🧑 -->
            public static readonly string[] VGFWorldCountries = {
                // Index 0 empty, the string array begins with Index 1
                "",
                "USA",
                "Canada",
                "Bulgaria",
                "Germany",
                "United Kingdom",
                "Australia",
                "Afghanistan",
                "Albania",
                "Algeria",
                "American Samoa",
                "Andora",
                "Angola",
                "Anguilla",
                "Antarctica",
                "Antigua and Barbuda",
                "Argentina",
                "Armenia",
                "Aruba",
                "Austria",
                "Azerbaijan",
                "Bahamas",
                "Bahrain",
                "Bangladesh",
                "Barbados",
                "Belarus",
                "Belgium",
                "Belize",
                "Benin",
                "Bermuda",
                "Bhutan",
                "Bolivia",
                "Bosnia",
                "Botswana",
                "Bouvet Island",
                "Brazil",
                "British Indian Ocean Terr.",
                "Brunei Darussalam",
                "Burkina Faso",
                "Burundi",
                "Cambodia",
                "Cameroon",
                "Cape Verde",
                "Cayman Islands",
                "Central African Republic",
                "Chad",
                "Chile",
                "China",
                "Christmas Island",
                "Cocos (Keeling) Islands",
                "Colombia",
                "Comoros",
                "Congo (Brazzaville)",
                "Congo, the democratic republic of the",
                "Cook Islands",
                "Costa Rica",
                "Cote de Ivoire",
                "Croatia (Hrvatska)",
                "Curacao",
                "Cyprus",
                "Czech Republic",
                "Denmark",
                "Djibouti",
                "Dominica",
                "Dominican Republic",
                "Ecuador",
                "Egypt",
                "El Salvador",
                "Equatorial Guinea",
                "Eritrea",
                "Estonia",
                "Ethiopia",
                "Falkland Islands",
                "Faroe Islands",
                "Fiji",
                "Finland",
                "France",
                "French Guiana",
                "French Polynesia",
                "French Southern Terr.",
                "Gabon",
                "Gambia",
                "Georgia",
                "Ghana",
                "Gibraltar",
                "Greece",
                "Greenland",
                "Grenada",
                "Guadeloupe",
                "Guam",
                "Guatemala",
                "Guernsey",
                "Guinea",
                "Guinea-Bissau",
                "Guyana",
                "Haiti",
                "Heard and McDonald Is.",
                "Honduras",
                "Hong Kong",
                "Hungary",
                "Iceland",
                "India",
                "Indonesia",
                "Iraq",
                "Ireland",
                "Israel",
                "Italy",
                "Jamaica",
                "Japan",
                "Jersey",
                "Jordan",
                "Kazakhstan",
                "Kenya",
                "Kiribati",
                "Korea South",
                "Kuwait",
                "Kyrgyzstan",
                "Lao Peoples Dem. Rep.",
                "Latvia",
                "Lebanon",
                "Lesotho",
                "Liberia",
                "Libya",
                "Liechtenstein",
                "Lithuania",
                "Luxembourg",
                "Macau",
                "Macedonia",
                "Madagascar",
                "Malawi",
                "Malaysia",
                "Maldives",
                "Mali",
                "Malta",
                "Man, Isle of",
                "Marshall Islands",
                "Martinique",
                "Mauritania",
                "Mauritius",
                "Mayotte",
                "Mexico",
                "Micronesia",
                "Moldova",
                "Monaco",
                "Mongolia",
                "Montenegro",
                "Montserrat",
                "Morocco",
                "Mozambique",
                "Myanmar",
                "Namibia",
                "Nauru",
                "Nepal",
                "Netherlands",
                "Netherlands Antilles",
                "New Caledonia",
                "New Zealand",
                "Nicaragua",
                "Niger",
                "Nigeria",
                "Niue",
                "Norfolk Island",
                "Northern Mariana Is.",
                "Norway",
                "Oman",
                "Pakistan",
                "Palau",
                "Palestine, State Of",
                "Panama",
                "Papua New Guinea",
                "Paraguay",
                "Peru",
                "Philippines",
                "Pitcairn",
                "Poland",
                "Portugal",
                "Puerto Rico",
                "Qatar",
                "Reunion",
                "Romania",
                "Russia",
                "Rwanda",
                "S.Georgia and S.Sandwich Is.",
                "Saint Kitts and Nevis",
                "Saint Lucia",
                "Samoa",
                "San Marino",
                "Sao Tome and Principe",
                "Saudi Arabia",
                "Senegal",
                "Serbia",
                "Seychelles",
                "Sierra Leone",
                "Singapore",
                "Sint Maarten",
                "Slovakia",
                "Slovenia",
                "Solomon Islands",
                "Somalia",
                "South Africa",
                "South Sudan",
                "Spain",
                "Sri Lanka",
                "St. Helena",
                "St. Pierre and Miquelon",
                "St. Vincent and Grenadines",
                "Suriname",
                "Svalbard and Jan Mayen Is.",
                "Swaziland",
                "Sweden",
                "Switzerland",
                "Taiwan",
                "Tajikistan",
                "Tanzania",
                "Thailand",
                "Timor-Leste",
                "Togo",
                "Tokelau",
                "Tonga",
                "Trinidad and Tobago",
                "Tunisia",
                "Turkey",
                "Turkmenistan",
                "Turks and Caicos Islands",
                "Tuvalu",
                "U.S. Minor Outlying Is.",
                "Uganda",
                "Ukraine",
                "United Arab Emirates",
                "Uruguay",
                "Uzbekistan",
                "Vanuatu",
                "Vatican (Holy See)",
                "Venezuela",
                "Viet Nam",
                "Virgin Islands (British)",
                "Virgin Islands (U.S.)",
                "Wallis and Futuna Is.",
                "Western Sahara",
                "Yemen",
                "Zambia",
                "Zimbabwe"


            };

            internal static string localcountry => VGFGetWorldWideCountry(5);

            /// <summary>
            /// United States of America - 53 states
            /// </summary>
	    /// <!-- 🧑Author Tipplin🧑-->
	    /// World Countries into string Array,
	    /// begins by Index 1
	    /// <!-- 🧑Author Tipplin🧑 -->
            public static readonly string[] VGFUSStates = {
                // begin with Index 0
                "",
                // Index 1 Alabama
                "AL",
                // Index 2 Alaska
                "AK",

                "AB", //Alberta

                "AZ", //Arizona

                "AR", //Arkansas

                "BC", //British Columbia

                "CA", //California

                "CO", //Colorado

                "CT", //Connecticut

                "DE", //Delaware

                "DC", //District of Columbia

                "FL", //Florida

                "GA", //Georgia

                "Hawaii", //Hawaii

                "ID", //Idaho

                "IL", //Illinois

                "IN", //Indiana

                "IA", //Iowa

                "KS", //Kansas

                "KY", //Kentucky

                "LA", //Louisiana

                "ME", //Maine

                "MB", //Manitoba

                "MD", //Maryland

                /* Massachusetts
		 * special people Hugenotts speak german and english,
		 * dutch, is not nethersland language is an german dialect
                 * Old German Butchery - Price mark 'For the Hund' (Bones,rests)
                 */
                "MA", 

                "MI", //Michigan

                "MN", //Minnesota - Minnesota German Cities names: Hamburg, New Ulm, Cologne, Heidelberg....

                "MS", //Mississippi

                "MO", //Missouri

                "MT", //Montana

                "NE", //Nebraska

                "NV", //Nevada

                "NB", //New Brunswick

                "NH", //New Hampshire

                "NJ", //New Jersey

                "NM", //New Mexico

                /* New York - The Part of New York City is 'New Paltz' 
                 * (German: Neue Pfalz speech paltzisch/pfälzisch
                 * German Teacher in New Paltz: "kann's mit mir deutsch schwätze.")
                 * Long History: Paltz People from Germany migrate to USA 1864,
                 * all childrens speak paltzisch and english.
                 * Tip: 
		 * On YouTube Videos from 'Kelly Englishs to Germans'
                 * Leavenworth an German Bavaria Town in USA, 
		 * all from Bavaria, Bavaria Houses, Backery and more... 
                 * 
                 */
                "NY", 

                "NL", //Newfoundland and Labrador

                "NC", //North Carolina

                "ND", //North Dakota

                "NT", //Northwest Territories

                "NS", //Nova Scotia

                "NU", //Nunavut

                "OH", //Ohio

                "OK", //Oklahoma

                "ON", //Ontario

                "OR", //Oregon

                "PA", //Pennsylvania

                "PE", //Prince Edward Island

                "PR", //Puerto Rico

                "QC", //Quebec

                "RI", //Rhode Island

                "SK", //Saskatchewan

                "SC", //South Carolina

                "SD", //South Dakota

                "TN", //Tennessee

                "TX", //Texas - Cologne/Köln, two people from German Cologne have founded this City.

                "AE", //US ARMY EUROPE

                "UT", //Utah - Cologne/Köln, two people from German Cologne have founded this City. BAR Früh Kölsch Inn

                "VT", //Vermont

                "VI", //Virgin Islands

                "VA", //Virginia

                "WA", //Washington

                "WV", //West Virginia

                "WI", //Wisconsin

                "WY", //Wyoming

                "YT" //Yukon
            };

            /// <summary>
            /// Germany 16 Federal States
            /// </summary>
            /// <!-- 🧑Author Tipplin🧑 -->
            /// For other Countries, all German Federal States in English/German.
            /// German Holidays in Class VGFWorldWideHolidays.
            /// <!-- 🧑Author Tipplin🧑 --!>
            /// <return>
            /// give the name of string array
            /// </return>
            public static readonly string[] VGFGermaFederalStates =
            {
                 // Index 0
                 "",
                 // Index 1 begin Baden Wuerttemberg
                 "BW",
                 //-----------------------------------------------------------
                 // Baveria - the new Baveria in USA Leavenworth/Washington, 
                 // German Shops in English/German. Bavarian Houses.
                 //
                 // Kelly YouTube Videos about Germans and US
                 // USA: outside of DC - German Gourmet Shop all Foods from Germany. 
                 //(Schwartau, Hengstenberg, Kühne, Wanner... and German Beers)
                 // https://www.youtube.com/watch?v=xvc5w3c-Evs

                 //------------------------------------------------------------
                 "BY",
                 // Berlin
                 "BE",
                 // Brandenburg
                 "BB",
                 // Bremen
                 "HB",
                 // Hamburg
                 "HH",
                 // Hesse
                 "HE",
                 // Mecklenbourg Western Pommeriana
                 "MV",
                 // Low Saxe
                 "NI",
                 // Northrhine Westfalia
                 "NW",
                 // Rhineland Palatine
                 "RP",
                 // Saare
                 "SL",
                 // Saxe
                 "SN",
                 // Saxe Anhaltine
                 "ST",
                 // Schleswig Holstein
                 "SH",
                 // Index 15 but Thuringa is the 16 Federal State
                 "TH"

            };

        } // END_OF_CLASS::VGFCountries


        /// <summary>
        /// International Languages for automatic switch in App.
        /// Take check install Version of Windows, then switch to Language.
        /// <!-- 🧑Author Tipplin🧑 -->
        /// For Germany art Whitepaper from Dr. Knittel CBM:
        /// "German Umlauts"
        /// Coding at UTF8
        /// <!-- 🧑Author Tipplin🧑 -->
        /// </summary>
        public static class VGFCountryLanguages
        {
            /*-----------------------------------------------------------------
             * Following the ISO International Norm:
             * -----------------------------------------------------------------
             * Two Letter ISO --- Normally Language
             * German grammar rules, more information about this see file
	     * Dr. Knittel CBM - German 'Umlauts'
             * 
             * Germany------- de-DE
             * Autriche------ de-AT
             * Switzerland--- de-CH
             * Luxembourg---- de-LU
             * Lichtenstein-- de-LI
	     *
             * Belgium------- de-be German Minority unproof!
             * -----------------------------------------------------------------
             * Three Letter ISO - Regional Language Dialect
             * -----------------------------------------------------------------
             * Germany------- den-WEN for Sorbish 
             * Sorbish People near Berlin in Spreewood
             * dobre rantje - witamy nam -
             * -----------------------------------------------------------------
             * 
             * 
             */
            /// <summary>
            /// Two Letter ISO for English Language: US = USA, UK = United Kingdom
            /// </summary>
            public static readonly string English = "en-UK";

            /// <summary>
            /// Two Letter ISO for German: 
            /// DE for Germany, AT for Autriche, CH for Switzerland, LS for Liechtenstein, LU for Luxembourg
            /// </summary>
            public static readonly string German = "de-DE";
            
            /// <summary>
            ///  German Regional Dialect Sorbish in Spreewood by Berlin
            ///  Three Letter ISO - den = german -WEN = wendish =>
            ///  inside .NET Framework Country Languages.
            ///  =>
            ///  Witamy nam, dobre ranje,
            /// </summary>
            public static readonly string Sorbish = "den-WEN";

            



        } // END_OF_CLASS::VGFCountryLanguages







        



        //**************************************************************************************
        //********************* LANGUAGES INFORMATION ******************************************
        //********************* .NET FRAMEWORK *************************************************
        //
        // by Tipplin (live in Rhineland-Palatine near UN-City Bonn)
        //
        //**************************************************************************************
        //
        // Languages - native	- integer Value primary and secondary
        //
        //--------------------------------------------------------------------------------------
        // Languages - .NET	- Two Letter ISO and Three Letter ISO
        // International Organization for Standardization:
        //  https://www.iso.org/home.html
        //
        //
        //--------------------------------------------------------------------------------------
        // German Two Letter ISO's: -'German Umlauts' from Whitepaper from Dr. Kittel CBM
        //                          - German and English Description
        //                          - German Umlauts on Unicode Organization www.unicode.org
        //--------------------------------------------------------------------------------------
        // Tippo Tip: 'German Umlauts' in Unicode Organization in UTF8.
        // http://www.unicode.org - Unicode Version 12.1.0 -at time 13.0 Beta Review - 
        // Release March 10 2020 - 13.0.0
        // UTF8, UTF16, UTF32 - UTF16 in Common Language Runtime (CLR) in/out.
        //--------------------------------------------------------------------------------------
        // de-BE for German Minority in Belgium, but UNCHECKED !
        // de-DE for Germany-----------
        // de-AT for Autriche---------- "German Umlauts" - 
        // de-CH for Switzerland------- "German Umlauts" - different to Germany,
        // de-LS for Liechtenstein-----
        // de-LU for Luxembourg--------
        //
        //----------------------- Dialects ------------------------------------------------------
        //---- Three Letter ISO for Germany Regional Language Dialect ---- .NET Framework -------
        //----------------- den-WEN - Sorbian Wendish --------------------
        //
        //=======================================================================================
        // Bavarian City in USA, Bavarian Houses Leavenworth/Washington USA
        //
        //
        //
        //----------------------------------------------------------------------------------
        //- english description for federal states of Germany -
        //----------------------------------------------------------------------------------
        // NorthRhine-Westfalia     - Nordrhein-Westfalen
        // Rhineland-Palatine       - Rheinland Pfalz
        //------------------------------------------- Immigration USA - Rhineland-Palatine:
        //------------------------------------------- Paltz People immigration in USA:
        // ------------------------------------------ New Paltz in New York Part of City
        // ------------------------------------------ Hugenotes city-same speak Germans/Paltz
        //------------------------------------------- 'kanns mit mir deutsch schwätze!'
        //------------------------------------------- Amercian School - German Teacher
        //
        // State Minnesota/ City of Minneapolis ----------- German City's Names: 
        //                                            Hamburg, Cologne, Ulm, Heidelberg
        // most Germans Immigration.
        // Cologne in  - with Frueh Koelsch (Greatest Bewery in Cologne Worldwide)
        // The Berlin "Reichstag" Federal State Department on Roof Frueh Koelsch,
        // Georg Gysi drink not Berlin Beer, Frueh Koelsch.
        //
        // Berlin: 
        // "Ständige Vertretung des Rheinlands", Frueh Koelsch, Halve Hahn, Frikadellen and more,
        // Founder: 
        // Dirk Drautzburg from Bonn, for years founded in Leipzig, Dresden, Hamburg
        //----------------------------------------------------------------------------------
        //--------------------------------------------------- German 16 Dialects: 
        // Saxe                     - Sachsen               - Saxon - Sächsisch   
        // Hesse                    - Hessen                - Hessian - Hessisch
        // Bavaria                  - Bayern                - Bavarian - Bayerisch
        //                          - Franken               - Franconian - Fränkisch
        // Saxe Anhaltine           - Sachsen Anhalt        - 
        // Thuringa                 - Thüringen
        // - Brandenburg
        // - Mecklenburg-Vorpommern
        // - Niedersachsen
        // Saare                    - Saarland
        // Berlin
        // - Baden-Württemberg      - Baden                 - Alemannic - Badisch
        //                          - Schwaben              - Swabian   - Schwäbisch
        // Hamburg                  -                       - Hamburgi  - Hamburgisch
        // Rhineland Palatine       - Rheinland Pfalz       - Palatine - Pfälzsich
        // North-Rhine Westfalia    - Nordrhein Westfalen - 
        // Specials: 
        // Ruhrdeutsch - Ruhr Area Dialect
        // Plattdeutsch - Low German
        // Rhineland: Cologne Dialect, Boennsch Dialect
        // Rhine River Valley
        //----------------------------------------------------------------------------------
        // German/English Commission (Langenscheidt) in London new Words German/English:
        //----------------------------------------------------------------------------------
        // Rolls - Brötchen 
        // (Great German Bakery near London ca. 100 Salescars. London Stock. Self Service.
        // Favorites: Rolls, Top-Hit: Bread-Pumpernickel)
        //
        // at Time German Shields in City 'Zur U-Bahn'
        // In  London:
        // !NOTE! same U-Trams Driver speak good german, one was in Berlin (BVG)Tram Driver.
        //----------------------------------------------------------------------------------
        // NorthRhine-Westfalia: 
        // 2017: 
        // Cologne is the greathest City over 1 Million People - 6. Place in Germany
        // (Berlin over 4 Million.)
        //----------------------------------------------------------------------------------
        // Three Cities in the World: -- New York, Wien and Bonn. 
        //----------------------------------------------------------------------------------
        // TIPPO:
        // slang: Rhineanttan
        // The NEW - Tower in Bonn - 101,5 Meters. Main-Customer is Post Bank.
        // (New Bonn Center - TIPPO TIP: NEW UN-Tower)
        //
        // Investor: The New Cancellor Place in Bonn. (Website) with 3 Buildings.
        // now in Work - Complete ca. 2023
        //
        // UN-Tower - (German Slang "Langer Eugen").
        // 'UN Bonn' Website for more Information what UN do in Bonn.
        //-----------------------------------------------------------------
        // NEW! Bonn Main Railstation
        // 5 Buildings in Work, City Office near the Station:
        // (! Gucci, Prada, One Group Hotel, New Piazza, Apple Store..)
        // The Developer Project Team on Web with Photos and Video.
        // Bonn new Piazza Restauration 1000 qm by Sander Manufacture the
        // Ankermieter. (2019 at Frankfurt Zeil)
        //
        //-----------------------------------------------------------------
        // The Mariott Hotel 4+ (5) Stars in Bonn, 
        // 17Floor see by clear Weather City of Cologne 
        // and the famous DOM !. 
        // Cafe/Bistro/Restaurant over there Chief Aleander Stadler.
        // Greathest Worldwide Hotelgroup !
        //
        // The World Conference Center - 2018/2019 - Full - UN-Conferences
        // The Hotel Kahema
        // The Hotel Hilton.
        //
        // Mount Drachenfels with new Panorama Restaurant,
        // by Clear Weather see the Cologne Dom or Koblenz, 
        // with new great Plateau "German Biergarten" (ca. 500 Guests)
        // 2 Kitchen's for Company Party or Guests.
        // Bistro.
        // New Concept, all trades built in the mountain,
        // Wine Room over 20000 Bottles Red/White.
        // Conference Rooms. Reservation great restauration for Company.
        //
        //----------------------------------------------------------------
        //
        //
        //----------------------------------------------------------------
        // For Unicode Information see Unicode Organization -
        // For Windows 10 develop with Visual Studio in unicode and 64BIT
        // while Area 32BIT goes to End !.
        // Same Vendors dont supports 32BIT, IBM, 
        // Apple (developer site "develop next for 64BIT"), NVIDIA,
        //
        //----------------------------------------------------------------
        // Unicode Consortium change website:
        // https://home.unicode.org/
        //
        // Online Tool "ShapeCatcher" write/paint your
        // Sign or other into Box, and ShapeCatcher look directly in
        // Unicode Organization is or not !.
        // at Time Unicode Handbook Version 12.1.0
        // 
        // UO Return: Hexadecimal Value and Font...
        // UTF8    - 8 BIT	 - Signs, Music, Chemistry, and "German Umlauts"
        // UTF16   - 16 BIT - Work into Common Language Runtime (In/Out)
        // UTF32   - 32 BIT - only Algorithmic
        //----------------------------------------------------------------
        // Unicode Standard
        // Each release of the Unicode Standard includes the 
        // core specification, the code charts, data files, all annexes, 
        // and UTS #10, UTS #39, UTS #46, and UTS #51.
        //
        //----------------------------------------------------------------
        // For 'German Umlauts' have Specials from Dr. Knittel -CBM-:
        // Same German Umlauts in Germany, Autriche, Switzerland..
        // ä. ü, ß - sharp s - other see in Handbook.
        // 
        //----------------------------------------------------------------
        // ! NEW ! .NET Command Line Tool - dotnet with commands -
        // <dotnet --version, <dotnet --info, <dotnet --help
        // <type csharpfile.cs, <type csharpprojectfile.csproj
        // <type csharpfilesolution.sln
        // so he list off all text in files.
        // or compile, create, test all files.
        //
        //----------------------------------------------------------------
        // Console Window is Now the Operation System Window by new
        // May Update 2019 - OS-Build 18362 - 
        // Microsoft change the Name Console to Windows Terminal
        // while Windows Operation System goes open source,
        // Microsoft Build 2019, Windows open source with MIT License.
        //----------------------------------------------------------------
        // Windows Terminal Beta State on GitHub for Developers
        // sourcecode in C++.
        //---------------------------------------------------------------
        // next is:
        // Windows Implementation Libraries (WIL) open source on GitHub
        //---------------------------------------------------------------
        //
        //
        //---------------------------------------------------------------
        // For Students and very good Insiders: 
        // Windows Research Kernel source
        // Files only for Kernel written in C.
        //
        //
        //----------------------------------------------------------------
        // Annotation Tippo:
        // Windows 10 Operation System have ca. 40000 Files,
        // compile in ca. 4 Hours on Build Server,
        // written with Visual Studio in C++ and C#.
        //----------------------------------------------------------------
        // Microsoft Third Party Tools with sourcecode,
        // this third party tools all in Microsoft Products,
        // Office,
        //
        // While not all written by Microsoft Developers.
        //================================================================
        // programming your Console App with Class, Methods, Properties
        // and 1 Event.
        // Windows 10 'Fall Creators Update' - Console Window:
        // more colors,
        // SimpleSample, create a Console Window to your App, 
        // the Console Window goes HIDE, can receive and send to other
        // Window's, create logfile, Message for Information, Warnings,
        // by Critical goes from HIDE in Show Modus to show current User
        // this Messages.
        // TIPPO's: Console Window App with Splash, at runtime goes in
        // Resize and show Splash Image after Thread.Sleep goes another
        // Resize Normal and show all Messages.
        // Dependency with native Functions Library written in C.
        // Console Window App with Class ExternalNativeFunction 
        // MultiBeep, MessageBox(int TextID) - see fore defined Text,
        // set only TextID.
        //
        // Avantage: Console Window have smaller Overhead as a Window.
        // Faster, directly to Operation System !.
        //----------------------------------------------------------------
        // 2016 - German Umlauts allowed in Cryptografie and Internet/Web
        // ! NOTE - NEW ! - SHA1 is OUT !!!!.
        //----------------------------------------------------------------
        // ! TIPPO !: Set Language System Functions here to sure.
        // Some Functions intergrated in .NET Framework
        //
        //
        //****************************************************************



        /// <summary>
        /// 
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        internal const int LANG_NEUTRAL = 0x00,
                           LOCALE_IFIRSTDAYOFWEEK = 0x0000100C;   /* first day of week specifier */

        /// <summary>
        /// 
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 -->        internal const int LOCALE_IMEASURE = 0x0000000D;   // 0 = metric, 1 = US

        /// <summary>
        /// Comments by SAP ABAP - Programming Language
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        internal const string CommentABAP = "=!";

        /// <summary>
        /// Set Global Variable for all in Project
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static string vgfmessage;



        #region ### Shortnames for Date with Operator Lambda => for Time Methods ###


        /// <summary>
        /// Get short real time now.
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <return>
        /// 
        /// </return>
        public static string SNowTime => DateTime.Now.ToShortTimeString();

        /// <summary>
        /// Get the real date
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static string SNowDate => DateTime.Now.ToShortDateString();

        /// <summary>
        /// Get the real day
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static string SToday => DateTime.Today.Day.ToString();

        /// <summary>
        ///  Univeral Time Coordinate Time for Worldtime/Europe
        ///  International Bureau for Measures and Weights in Paris.
        ///  All Atom Clocks of the World (ca. 300).
        ///  And NEW International Unit System at 20.05.2019,
        ///  (Conference Novembre 2018)
        ///  Adieu Base Units, welcome Nature Constants.
        ///  Candela, Ampere, Mole, Kelvin, Second, Meter, Kilogram (after uncorrectness new definition)
        ///  new definitions.
        ///  Germany: PTB Braunschweig/Berlin
        ///  The new Atom Clock with Light and Laser,
        ///  correctness  Factor 17.
        ///  Caesium is out!
        ///  PTB-Clock with local time difference in milliseconds - unsafe +- milliseconds: https://uhr.ptb.de/
        ///  
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// NOTE: 2018 in USA Minute have now 60 seconds not 59 then jump to 1 minute.
	/// so our Time in Europa goes 1 minute after.
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static string UtcNow = DateTime.UtcNow.ToString();

        /// <summary>
        /// Get real Weekday
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static string Wday = DateTime.Now.DayOfWeek.ToString();

        /// <summary>
        /// Get is Leap Year ?, with given Year
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static bool LYear = DateTime.IsLeapYear(Year);

        /// <summary>
        /// Get real Year
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static int Year = DateTime.Now.Year;

        /// <summary>
        /// Get real value for Month - 1=january - 12 december
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static int Month = DateTime.Now.Month;

        /// <summary>
        /// Get real Days in Month, with given year and month
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static int DMonth = DateTime.DaysInMonth(Year, Month);


        /// <summary>
        /// Cane write into File
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static bool CanWrite = true;

        /// <summary>
        /// Can't write into File
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        public static bool CanNotWrite = false;


        #endregion


        




        #region ### Struct Instance Variables ###

        // struct and instance variable on STACK!
        // MEMORYSTATUSEX ex;
        // by new operator:
        // MEMORYSTATUSEX ex = new MEMORYSTATUSEX(); on HEAP ever!
        //
        // (Visual C# allocate automatic memmory for struct)
        // (Visual C# struct never null bytes, 1 byte for managed the Struct, if members or not!.)
        //
        // (Microsoft: Limit of Struct 16 Bytes, are greater split off in other.)
        // Here in Class Head only Structs with Instance-Variable, but NOT The Call, in Method!





        /// <summary>
        /// 
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        /// <param name="primary"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        internal static int VGFMakeLangId(int primary, int sub)
        {
            //-----------------bitwise shift left
            return ((((ushort)(sub)) << 10) | (ushort)(primary));
        }

        //----------------------------------------------------------------
        // TIPPO UNDONE / UNCHECKED
        //----------------------------------------------------------------
        // Default System and User IDs for language and locale.
        // Convert Visual C++ Macro to Visual C# Method
        //----------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        /// <!-- 🧑Author Tipplin 🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin 🧑 --> 
        /// <param name="lgid"></param>
        /// <param name="srtid"></param>
        /// <returns></returns>
        internal static uint VGFMakeLCId(ushort lgid, ushort srtid)
        {
            //----------------------bitwise shift left
            return ((uint)((((uint)(srtid)) << 16) | ((uint)((lgid)))));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 --> 
        /// <param name="lgid"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        internal static int VGFMakeLCId(int lgid, int sort)
        {
            return ((0xFFFF & lgid) | (((0x000f) & sort) << 16));
        }



        /// <summary>
        /// Show standard Message for Method.
        /// </summary>
        /// <!-- 🧑Author Tippo🧑 -->
        /// Have set the Enumerator ERROR_CODES all in.
        /// <!-- 🧑Author Tippo🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode);
        /// msvcrt.dll - 64BIT Only -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks>
        internal static void VGFUsageMethod()
        {
            VFLMsgBox("The Method is not supported on this Operation System !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            NRMExit(EXIT_CODES.ERROR_CALL_NOT_IMPLEMENTED);
        }

        /// <summary>
        /// Show standard for User Cancel.
        /// </summary>
        /// <!-- 🧑Author Tippo🧑 -->
        /// 
        /// <!-- 🧑Author Tippo🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode); -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks> 
        internal static void VGFUsageUser()
        {
            VFLMsgBox("The Operation was cancelled by the User !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            NRMExit(EXIT_CODES.ERROR_CANCELLED);
        }

        /// <summary>
        /// Show standard for DLL not found.
        /// </summary>
        /// <!-- 🧑Author Tippo🧑 -->
        /// 
        /// <!-- 🧑Author Tippo🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode); -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks> 
        internal static void VGFUsageDLL()
        {
            VFLMsgBox("The Operation was cancelled by the User !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            NRMExit(EXIT_CODES.ERROR_DLL_NOT_FOUND);
        }

        /// <summary>
        /// Show standard for Internal Error
        /// </summary>
        /// <!-- 🧑Author Tippo🧑 -->
        /// 
        /// <!-- 🧑Author Tippo🧑 -->
        /// <remarks>
        /// NRMExit is an Wrapper in C#, Microsoft C Runtime Function Exit(int Errorcode); -
        /// have set all ERROR_CODES in the Assembly Visual.Operation.System.dll
        /// </remarks> 
        internal static void VGFUsageInternalError()
        {
            VFLMsgBox("An  error is occurred !.", "Visual Galaxy Framework", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

            NRMExit(EXIT_CODES.ERROR_INTERNAL_ERROR);
        }

        /*--------------------------------------------------- 
         * Java
         * --------------------------------------------------
         * Project Joda Time
         * --------------------------------------------------
         * A selection of key features:
         * LocalDate - date without time
         * LocalTime - time without date
         * Instant - an instantaneous point on the time-line
         * DateTime - full date and time with time-zone
         * DateTimeZone - a better time-zone
         * Duration and Period - amounts of time
         * Interval - the time between two instants
         * A comprehensive and flexible formatter-parser
         * 
         *--------------------------------------------------- 
         */

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <param name="datetime"></param>
        /// <returns></returns>
        internal static bool VGFIsAfterPayDay(DateTime datetime)
        {
            DateTime dt = new DateTime();
            
            if (dt.Month == 2)
            {   // February is month 2!!
                return dt.Day >26 ;
            }
            return dt.Day > 28;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <param name="Year"></param>
        /// <returns></returns>
        internal static string VGFGetDaysToNewYear(DateTime Year)
        {
            return Year.DayOfYear.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Message"></param>
        internal static void VGFInternalInfo(string Message)
        {
            // FailFast terminate now the Process, write into Windows Application Event Log and send Message and ErrorReport to Microsoft.
            Environment.FailFast(Message);
            /*
             * Class Enviroment all System Infos and
             * Windows Folders - ! ATTENTION ! If you are NOT Administrator in Windows Account, Windows 10 automatic lock same Folders.
             * Onyl the Administrator and Admin Account have full rights !.
             * same by Windows Firewall, Windows Protection, Windows Network Protection, only as Administrator can set the Protections.
             * Special Folders - 60 Folders
             * 
             */
        }








        /*-------------------------------------------------------------------------------------------------------------------------
         * .NET Framework 4.7.2 and Visual C# 7.3 allowed this catch like Java
         * 
         * Same Classes have more then one Exceptions. Here SystemException.
         * 
         * catch(SystemException ex)when(ex is BufferOverflowException || ex is COMException || ex is InvalidDataException)
         * {
         * 
         *------Exception Messagetext - Source who occured the Exception. STYLES for MessageBox written C with Wrapper here,
         *---------------------------------------------------------------- STYLES as Enumerator like VB.NET.
         *      VOLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
         *      return false;
         * }
         * 
         *--------------------------------------------------------------------------------------------------------------------------
         */

        /*---------------------------------------------------------------------
         * Class FrameworkException
         * for our Visual Galaxy Framework.
         * --------------------------------------------------------------------
         * More Information who is the Exception occured ?
         * App Domain
         * Assembly Name
         * Class Name
         * Exception
         * User
         * Machine
         * Method Name
         * Process ID
         * Process Name
         * Reason Enumerator
         * Thread ID
         * -------------------------------------------------------------------- 
         * Error classes used throughout the library.
         * 
         * export class BadEventName extends Error { }
         * export class RequestTimedOut extends Error { }
         * export class TransportPriorityTooLow extends Error { }
         * export class TransportClosed extends Error { }
         * export class UnsupportedFeature extends Error { }
         * export class UnsupportedTransport extends Error { }
         * export class UnsupportedStrategy extends Error { }
         * 
         * 
         * 
         * --------------------------------------------------------------------
         * Set our Class FrameworkException for our Visual.Galaxy.Framework:
         * 
         * AppDomain is the Application Name who occured the Exception
         * AssemblyName is the Assemblyname who occured the Exception
         * ClassName is the Class who occoured the Exception.
         * If you use multiple Servers for Service Hosting,
         * this property shows which machine experienced the Error.
         * 
         * MethodName is the Method who occured the Exception.
         * ProcessID is Idnumber of Process at Error returns integer value.
         * ProcessName is Name of Process who occured at Exception.
         * ThreadID is the Thread ID number of the 
         * Thread who occured the Exception.
         * --------------------------------------------------------------------
         * 
         */

        /// <summary>
        ///👁‍🗨📸
        /// Define for our Framework, FrameworkException with Members
        /// Base Class is SystemException.
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// Create Global Exceptionhandling for this Framework.
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// This class previously indicated an unspecified fatal error in the runtime. 
        /// </remarks>
        [Serializable]
        internal class VGFFrameworkException : SystemException
        {
            /// <summary>
            /// 
            /// </summary>
            private readonly int VGFFrameworkExceptionCode;

            /// <summary>
            /// 
            /// </summary>
            public int VGFFrameworkExceptionNativeErrorCode => VGFFrameworkExceptionCode;

            /// <summary>
            /// StackFrame is the complete Stack,
            /// </summary>
            internal StackFrame sf = new StackFrame();

            /// <summary>
            /// VGFFrameworkErrors
            /// </summary>
            public enum VGFFrameworkErrors : int
            {
                // second alternate as hexadecimal but unchecked.
                // ul at end allow! as unsigned long = ulong 64BIT value.
                // datatype is ulong, but by value is UInt32, but there is wrong!
                // so at end of value set ul for ulong! UInt64.
                //  const ulong ObjectError2 = 0x80040000ul;
                // long with signed sign, value with L for Int64
                // l lower letter is not so good, can be confused with 1,
                // so set upper letter L !
                // set here for HResult integer 
                // Limit integer -2147483648 (-1) - + 2147483647 (-1)
                // -1 for no overflow!
                // same in others values or control

                /// <summary>
                /// Object Error (-2147000000) occured in Framework
                /// </summary>
                VGF_Framework_Object_Error = -2147000000,
                // Base Errornumber for Framework Error
                VGF_Framework_Error_Base,
                // Framework Errornumber for namespace 
                VGF_Framework_Error_Namespace,
                // Framework Errornumber for Class 
                VGF_Framework_Error_Class,
                /// <summary>
                /// Framework Errornumber for Method 
                /// </summary>
                VGF_Framework_Error_Method,
                /// <summary>
                /// Method not found in Framework
                /// </summary>
                VGF_Framework_Error_MethodNotFound,
                /// <summary>
                /// Framework Errornumber for Property 
                /// </summary>
                VGF_Framework_Error_Property,
                /// <summary>
                /// Framework Errornumber for Event 
                /// </summary>
                VGF_Framework_Error_Event,
                /// <summary>
                ///  Framework Errornumber for Bad Format in exe file
                /// </summary>
                VGF_Framework_Error_Bad_Exe_Format,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Bad_Net_Name,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Bad_Net_Path,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Disk_Corrupt,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Dll_Init_Failed,
                /// <summary>
                /// 
                /// </summary>
                VGF_Framework_Error_Dll_Not_Found,

                VGF_Framework_Error_Exe_Marked_Invalid,

                VGF_Framework_Error_File_Corrupt,

                VGF_Framework_Error_File_Invalid,

                VGF_Framework_Error_File_Not_Found,

                VGF_Framework_Error_Invalid_Dll,

                VGF_Framework_Error_Invalid_Name,

                VGF_Framework_Error_Invalid_Ordinal,

                VGF_Framework_Error_Invalid_Parameter,

                VGF_Framework_Error_Lock_Violation,

                VGF_Framework_Error_Mod_Not_Found,

                VGF_Framework_Error_Func_Not_Found,

                VGF_Framework_Error_No_Access,

                VGF_Framework_Error_Not_Ready,

                VGF_Framework_Error_Open_Failed,

                VGF_Framework_Error_Path_Not_Found,

                VGF_Framework_Error_Wrong_Target_Name,

                VGF_Framework_Error_Illegal_Function_Call,
                // String Storage place is full
                VGF_Framework_Error_Out_Of_String_Space,
                // String is too long maximum integer value
                VGF_Framework_Error_String_Too_Long,

                VGF_Framework_Error_Time_Out_Overflow,

                VGF_Framework_Error_File_Already_Open,

                VGF_Framework_Error_File_Already_Exists,

                VGF_Framework_Error_Device_IO_Failed,

                VGF_Framework_Error_Device_Unavailable,

                VGF_Framework_Error_Feature_Unavailable,

                VGF_Framework_Error_File_Path_acess_denied,

                VGF_Framework_Error_Missing_Library,

                VGF_Framework_Error_Duplicate_Name,

                VGF_Framework_Error_Unknown_Internal_Error = 255

            }

            internal VGFFrameworkException() : base()
            {
                VGFFrameworkExceptionSetCode(-2147000000);
            }




            /// <summary>
            /// 
            /// </summary>
            /// <param name="hr"></param>
            void VGFFrameworkExceptionSetCode(int hr)
            {
                HResult = hr;
            }


            /*
             * 
             * Fatal Framework Error Exception
             * Console.Error.WriteLine();

			Console.Error.WriteLine("*** INTERNAL FRAMEWORK ERROR ***");

			Console.Error.WriteLine();

			Console.Error.WriteLine("PLEASE FILE A BUG REPORT FOR IKVM.NET WHEN YOU SEE THIS MESSAGE");

			Console.Error.WriteLine();

			Console.Error.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().FullName);

			Console.Error.WriteLine(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory());

			Console.Error.WriteLine("{0} {1}-bit", Environment.Version, IntPtr.Size * 8);

			Console.Error.WriteLine();

			Console.Error.WriteLine(x);

			return 2;
             * 
             * 
             VGFFrameworkException() : base()
            {
                sealed class FatalCompilerErrorException : Exception

            {

                internal VGFFatalFrameworkErrorException(Message id, params object[] args)

                    : base(string.Format("fatal error IKVMC{0}: {1}", (int)id, args.Length == 0 ? GetMessage(id) : string.Format(GetMessage(id), args)))

                {

                }

                Developer Jeroen Frijters new Java Fork IKVM.NET - 
                Java for .NET - with OpenJDK puls IKVM Compiler
                written in Visual C# yet - Orignal IKVM.NET in Project MONO -
                Class-declaration in C# :plus Java inherited java.lang.thread

                Visual C# and Java work together:
                using System;
                using System.Diagnostics;
                using System.IO;
                using System.Reflection;
                using IKVM.Internal;
                using ikvm.runtime;
                using java.lang.reflect;
                
                Visual C# - Class:
                private class SaveAssemblyShutdownHook : java.lang.Thread
                
                
                
                ---------------------------------------------------------
                
                private static string GetMessage(Message id)

                {

                    switch (id)

                    {

                        case IKVM.Internal.Message.ResponseFileDepthExceeded:

                            return "Response file nesting depth exceeded";

                        case IKVM.Internal.Message.ErrorReadingFile:

                            return "Unable to read file: {0}\n\t({1})";

                        case IKVM.Internal.Message.NoTargetsFound:

                            return "No targets found";

                        case IKVM.Internal.Message.FileFormatLimitationExceeded:

                            return "File format limitation exceeded: {0}";

                        case IKVM.Internal.Message.CannotSpecifyBothKeyFileAndContainer:

                            return "You cannot specify both a key file and container";

                        case IKVM.Internal.Message.DelaySignRequiresKey:

                            return "You cannot delay sign without a key file or container";

                        case IKVM.Internal.Message.InvalidStrongNameKeyPair:

                            return "Invalid key {0} specified.\n\t(\"{1}\")";

                        case IKVM.Internal.Message.ReferenceNotFound:

                            return "Reference not found: {0}";

                        case IKVM.Internal.Message.OptionsMustPreceedChildLevels:

                            return "You can only specify options before any child levels";

                        case IKVM.Internal.Message.UnrecognizedTargetType:

                            return "Invalid value '{0}' for -target option";

                        case IKVM.Internal.Message.UnrecognizedPlatform:

                            return "Invalid value '{0}' for -platform option";

                        case IKVM.Internal.Message.UnrecognizedApartment:

                            return "Invalid value '{0}' for -apartment option";

                        case IKVM.Internal.Message.MissingFileSpecification:

                            return "Missing file specification for '{0}' option";

                        case IKVM.Internal.Message.PathTooLong:

                            return "Path too long: {0}";

                        case IKVM.Internal.Message.PathNotFound:

                            return "Path not found: {0}";

                        case IKVM.Internal.Message.InvalidPath:

                            return "Invalid path: {0}";

                        case IKVM.Internal.Message.InvalidOptionSyntax:

                            return "Invalid option: {0}";

                        case IKVM.Internal.Message.ExternalResourceNotFound:

                            return "External resource file does not exist: {0}";

                        case IKVM.Internal.Message.ExternalResourceNameInvalid:

                            return "External resource file may not include path specification: {0}";

                        case IKVM.Internal.Message.InvalidVersionFormat:

                            return "Invalid version specified: {0}";

                        case IKVM.Internal.Message.InvalidFileAlignment:

                            return "Invalid value '{0}' for -filealign option";

                        case IKVM.Internal.Message.ErrorWritingFile:

                            return "Unable to write file: {0}\n\t({1})";

                        case IKVM.Internal.Message.UnrecognizedOption:

                            return "Unrecognized option: {0}";

                        case IKVM.Internal.Message.NoOutputFileSpecified:

                            return "No output file specified";

                        case IKVM.Internal.Message.SharedClassLoaderCannotBeUsedOnModuleTarget:

                            return "Incompatible options: -target:module and -sharedclassloader cannot be combined";

                        case IKVM.Internal.Message.RuntimeNotFound:

                            return "Unable to load runtime assembly";

                        case IKVM.Internal.Message.MainClassRequiresExe:

                            return "Main class cannot be specified for library or module";

                        case IKVM.Internal.Message.ExeRequiresMainClass:

                            return "No main method found";

                        case IKVM.Internal.Message.PropertiesRequireExe:

                            return "Properties cannot be specified for library or module";

                        case IKVM.Internal.Message.ModuleCannotHaveClassLoader:

                            return "Cannot specify assembly class loader for modules";

                        case IKVM.Internal.Message.ErrorParsingMapFile:

                            return "Unable to parse remap file: {0}\n\t({1})";

                        case IKVM.Internal.Message.BootstrapClassesMissing:

                            return "Bootstrap classes missing and core assembly not found";

                        case IKVM.Internal.Message.StrongNameRequiresStrongNamedRefs:

                            return "All referenced assemblies must be strong named, to be able to sign the output assembly";

                        case IKVM.Internal.Message.MainClassNotFound:

                            return "Main class not found";

                        case IKVM.Internal.Message.MainMethodNotFound:

                            return "Main method not found";

                        case IKVM.Internal.Message.UnsupportedMainMethod:

                            return "Redirected main method not supported";

                        case IKVM.Internal.Message.ExternalMainNotAccessible:

                            return "External main method must be public and in a public class";

                        case IKVM.Internal.Message.ClassLoaderNotFound:

                            return "Custom assembly class loader class not found";

                        case IKVM.Internal.Message.ClassLoaderNotAccessible:

                            return "Custom assembly class loader class is not accessible";

                        case IKVM.Internal.Message.ClassLoaderIsAbstract:

                            return "Custom assembly class loader class is abstract";

                        case IKVM.Internal.Message.ClassLoaderNotClassLoader:

                            return "Custom assembly class loader class does not extend java.lang.ClassLoader";

                        case IKVM.Internal.Message.ClassLoaderConstructorMissing:

                            return "Custom assembly class loader constructor is missing";

                        case IKVM.Internal.Message.MapFileTypeNotFound:

                            return "Type '{0}' referenced in remap file was not found";

                        case IKVM.Internal.Message.MapFileClassNotFound:

                            return "Class '{0}' referenced in remap file was not found";

                        case IKVM.Internal.Message.MaximumErrorCountReached:

                            return "Maximum error count reached";

                        case IKVM.Internal.Message.LinkageError:

                            return "Link error: {0}";

                        case IKVM.Internal.Message.RuntimeMismatch:

                            return "Referenced assembly {0} was compiled with an incompatible IKVM.Runtime version\n" +

                                "\tCurrent runtime: {1}\n" +

                                "\tReferenced assembly runtime: {2}";

                        case IKVM.Internal.Message.CoreClassesMissing:

                            return "Failed to find core classes in core library";

                        case IKVM.Internal.Message.CriticalClassNotFound:

                            return "Unable to load critical class '{0}'";

                        case IKVM.Internal.Message.AssemblyContainsDuplicateClassNames:

                            return "Type '{0}' and '{1}' both map to the same name '{2}'\n" +

                                "\t({3})";

                        case IKVM.Internal.Message.CallerIDRequiresHasCallerIDAnnotation:

                            return "CallerID.getCallerID() requires a HasCallerID annotation";

                        case IKVM.Internal.Message.UnableToResolveInterface:

                            return "Unable to resolve interface '{0}' on type '{1}'";

                        case IKVM.Internal.Message.MissingBaseType:

                            return "The base class or interface '{0}' in assembly '{1}' referenced by type '{2}' in '{3}' could not be resolved";

                        case IKVM.Internal.Message.MissingBaseTypeReference:

                            return "The type '{0}' is defined in an assembly that is not referenced. You must add a reference to assembly '{1}'";

                        case IKVM.Internal.Message.FileNotFound:

                            return "File not found: {0}";

                        case IKVM.Internal.Message.RuntimeMethodMissing:

                            return "Runtime method '{0}' not found";

                        case IKVM.Internal.Message.MapFileFieldNotFound:

                            return "Field '{0}' referenced in remap file was not found in class '{1}'";

                        case IKVM.Internal.Message.GhostInterfaceMethodMissing:

                            return "Remapped class '{0}' does not implement ghost interface method\n" +

                                "\t({1}.{2}{3})";

                        default:

                            return "Missing Error Message. Please file a bug.";

                    }

                }

            }
        }


                // System.ExecutionEngineException
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

/// <summary>
///         Die Ausnahme, die bei einem internen Fehler im Ausführungsmodul der Common Language Runtime ausgelöst wird.
///          Diese Klasse kann nicht vererbt werden.
///       </summary>
[Serializable]
[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
[ComVisible(true)]
public sealed class ExecutionEngineException : SystemException
{
	/// <summary>
	///         Initialisiert eine neue Instanz der <see cref="T:System.ExecutionEngineException" />-Klasse.
	///       </summary>
	public ExecutionEngineException()
		: base(Environment.GetResourceString("Arg_ExecutionEngineException"))
	{
		SetErrorCode(-2146233082);
	}

	/// <summary>
	///         Initialisiert eine neue Instanz der <see cref="T:System.ExecutionEngineException" />-Klasse mit einer angegebenen Fehlermeldung.
	///       </summary>
	/// <param name="message">
	///           Die Meldung, in der der Fehler beschrieben wird.
	///         </param>
	public ExecutionEngineException(string message)
		: base(message)
	{
		SetErrorCode(-2146233082);
	}

	/// <summary>
	///         Initialisiert eine neue Instanz der <see cref="T:System.ExecutionEngineException" />-Klasse mit einer angegebenen Fehlermeldung und einem Verweis auf die innere Ausnahme, die diese Ausnahme ausgelöst hat.
	///       </summary>
	/// <param name="message">
	///           Die Fehlermeldung, in der die Ursache der Ausnahme erklärt wird.
	///         </param>
	/// <param name="innerException">
	///           Die Ausnahme, die die Ursache der aktuellen Ausnahme ist.
	///            Wenn der <paramref name="innerException" />-Parameter kein NULL-Verweis ist (<see langword="Nothing" /> in Visual Basic), wird die aktuelle Ausnahme in einem <see langword="catch" />-Block ausgelöst, der die innere Ausnahme behandelt.
	///         </param>
	public ExecutionEngineException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233082);
	}

	internal ExecutionEngineException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}











            */



            /// <summary>
            /// 
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="info"></param>
            /// <param name="context"></param>
            protected VGFFrameworkException(SerializationInfo info, StreamingContext context)
                : base(info, context)
            {
            }


            /// <summary>
            /// FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="message"></param>
            /// <param name="innerException"></param>
            internal VGFFrameworkException(string message, SystemException innerException)
                : base(message, innerException)
            {
                //-------------------------------------------------------------
                // Set HRESULT Error Code for innerException.
                //-------------------------------------------------------------
                // ObjectError - 2147221504 plus 1000 for user defined error
                // number normal - here set 2147222600 for ObjectError
                //-------------------------------------------------------------
                VGFFrameworkExceptionSetCode(-2147000000);
            }

            /// <summary>
            /// FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="message"></param>
            internal VGFFrameworkException(string message)
                : base(message)
            {
                // Set HRESULT Error Code. HRESULTS are reserved by Microsoft,
                // so we set our Codes.
                // HRESULTs are everytime -minus error code values.
                VGFFrameworkExceptionSetCode(-2147000000);

            }

            /// <summary>
            /// FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            /// <param name="message"></param>
            /// <param name="errorCode"></param>
            internal VGFFrameworkException(int errorCode, string message)
                : base(message)
            {
                VGFFrameworkExceptionCode = errorCode;
            }

            /// <summary>
            /// Application how the FrameworkException occured.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionAppDomain
            {

                get
                {
                    // Get and display the friendly name of the default AppDomain.
                    return Thread.GetDomain().FriendlyName;
                }
            }

            /// <summary>
            /// Assembly how the Exception occured.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionAssemblyName
            {
                get
                {
                    return vai.VGFAsmFQName;
                }
            }

            /// <summary>
            /// Classname how the FrameworkException occured.
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionClassName
            {

                get
                {
                    return sf.GetFileName().ToString();
                }
            }



            /// <summary>
            /// Get Username
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionUser
            {
                get
                {
                    return Environment.UserName;
                }
            }

            /// <summary>
            /// Get the Machinename of User
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionMachine
            {
                get
                {
                    return Environment.MachineName;
                }

            }

            /// <summary>
            /// Get the Methodname of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionMethodName
            {
                get
                {
                    return sf.GetMethod().ToString();
                }
            }

            /// <summary>
            /// Get current Process ID of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// Class Process from .NET Framework set in Class-Head
            /// with  and static, use so for all Classes and Methods...
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return>
            internal string VGFFrameworkExceptionProcessID
            {
                get
                {
                    return process.Id.ToString();
                }
            }

            /// <summary>
            /// Get current Processname of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// Class Process from .NET Framework set in Class-Head
            /// with  and static, use so for all Classes and Methods...
            /// <!-- Author Tipplin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return> 
            internal string VGFFrameworkExceptionProcessName
            {
                get
                {
                    return process.ProcessName;
                }

            } // END_OF_PROPERTY


            /// <summary>
            /// Get current Source Reason of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal string VGFFrameworkExceptionReason
            {
                get
                {
                    return this.Source;
                }

            }


            /// <summary>
            /// Get current ThreadID of FrameworkException
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal int VGFFrameworkExceptionThreadID
            {
                get
                {
                    return Environment.CurrentManagedThreadId;
                }

            }

            /// <summary>
            /// Query actual Stack watch information
            /// </summary>
            /// <!-- Author Tippolin 🧑 -->
            /// 
            /// <!-- Author Tippolin 🧑 -->
            /// <remarks>
            /// 
            /// </remarks>
            /// <return>
            /// 
            /// </return>
            internal string VGFFrameworkExceptionStackTraceInfo
            {
                get
                {
                    return Environment.StackTrace;
                }
            }

            /// <summary>
            /// Get the Cureent Process Id at occured Exception
            /// </summary>
            /// <!-- Author Tipplin 🧑 -->
            /// 
            /// <!-- Author Tipplin 🧑 --> 
            internal uint VGFFrameworkExceptionGetCurrentProcessId
            {
                get
                {
                    return GetCurrentProcessId();
                }
            }

            /*
            internal uint TestFunction1
            {
                get
                {
                    uint _residue = uint.MaxValue;

                    /// ~ is an operator uint uint.operator(uint Value)
                    /// => lambda pointer
                    uint Crc => ~_residue;
                }
            }
            
            */
        
 
        } // END_OF_CLASS::VGFFrameworkException


        // String Helper

        /// <summary>
        /// Left of string
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// NOTE: Arrary's always begin with index 0
        /// </remarks> 
        /// <param name="source"></param>
        /// <param name="c"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFLeftOf(string source, char c)
        {
            string ret = source;

            int idx = source.IndexOf(c);

            if (idx != -1)
            {
                ret = source.Substring(0, idx);
            }

            return ret;

        } // end of method::LeftOf


        /// <summary>
        /// Start Microsoft Main Website directly
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 --> 
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFStartMicrosoftWebSite()
        {

            /*
             * 
             * try / catch / finally block
             * 
             * (finally is the ultimate resource free, if Exception or NOT !.
             *  cleanup all Windows Handles, Windows Resources, TWAIN-Scanner-Interface-Connect(if no disconnect, everytime open but access!) 
             *  close Files,
             *  
             *  )
             * 
             * 
             * catch (SystemException ex)when(ex is InvalidOperationException || ex is Win32Exception || ex is FileNotFoundException)
             * 
             * see new Exception with Operator || for more then one Exception Type, like Java Exceptions
             * 
             * or
             * 
             * return ex is NullReferenceException ||
             *        ex is StackOverflowException ||
             *        ex is OutOfMemoryException   ||
             *        ex is System.Threading.ThreadAbortException ||
             *        ex is System.Runtime.InteropServices.SEHException ||
             *        ex is System.Security.SecurityException;
             *
             *        
             *        
             */





            try
            {
                /* 
                 * Start Process/Thread with given Pathname and executable file .exe and start it direct!
                 * @ is a unicode sign, here for slashes \ backward slash, without  \\ (forward slash /)
                 * all unicode sign stand over Unicode Organization - www.unicode.org -
                 * 
                 * Unicode Handbook Version 12.0 at 05.03.2019
                 * For Germany, Autriche, Switzerland "German Umlauts".
                 * 
                 * For English Persons give english paper for "German Umlauts" by DIN-Norm (Deutsche Normierung)
                 * 
                 * Windows 10 May Update 2019 - 19H1 with new coding by Windows Editor by save under.
                 * Windows 10 Editor want save the File with own .suffix, so go this way:
                 * Filename - insert your own Filename
                 * Filetype - choice all Files
                 * Coding - UTF8
                 * While Windows 10 New Filesystem - Assocation with Filename (Prefix) and Suffixes
                 * means! set suffix to any application or filetype
                 * .dllfile = dll 
                 * .dllfile is an assembly DLL, is a little secure.
                 * set this with System-Tool assoc.exe on command line.
                 * 
                 * .accdb=Access.Application.16 is the new Database Microsoft Access Format .suffix .accdb
                 * (Microsoft Access Limit 255 Users, Database Size: )
                 * 
                 * (Microsoft SQL Server Limit x Users, Database Size: 535 Tebibyte - Tera binary byte (Terabyte is wrong))
                 * (Microsoft SQL Server Community Edition the same as Enterprise (Commerial) free download)
                 * 
                 * Microsoft SQL Server 2019 with:
                 * --------------------------------------------------------------------------------------------------------------------
                 * Apache Spark™ ist eine einheitliche Analyse-Engine für groß angelegte Datenverarbeitung. 
                 * Can run Spark Job's.
                 * 
                 * HDFS - Hadoop Distributed File System (HDFS) - Apache Hadoop
                 * The Apache™ Hadoop® project develops open-source software for reliable, scalable, distributed computing.
                 * The Apache Hadoop software library is a framework that allows for the distributed processing of large data sets 
                 * across clusters of computers using simple programming models. 
                 * It is designed to scale up from single servers to thousands of machines, 
                 * each offering local computation and storage. 
                 * Rather than rely on hardware to deliver high-availability, 
                 * the library itself is designed to detect and handle failures at the application layer, 
                 * so delivering a highly-available service on top of a cluster of computers, each of which may be prone to failures.
                 * 
                 * 
                 * 
                 * (IBM Db2 Developer Community Edition - after IBM Account free download)
                 * (Embacadero Interbase Community Edition - free download)
                 * (same Delphi and C++ Compiler and Builder - free download)
                 * 
                 * ------------------------------------------------------------------------------------------------------
                 * NEW in Microsoft Editor - Windows 10 OS-Build 18632 Fix
                 * ------------------------------------------------------------------------------------------------------
                 * UTF-8 with BOM (Byte Order Mark),
                 * ----------------------------------------------
                 * UTF-16 LE - Little Endian
                 * If the 16-bit units use little-endian order, 
                 * the BOM will appear in the 
                 * sequence of bytes as 0xFF 0xFE
                 * ----------------------------------------------
                 * UTF-16 BE - Big Endian
                 * If the 16-bit units are represented in 
                 * big-endian byte order, the BOM will appear 
                 * in the sequence of bytes as 0xFE 0xFF
                 * ----------------------------------------------
                 * and Ansi, UTF8 - remove Unicode and 
                 * Big Endian from Editor Coding.
                 * The Byte Order Mark (BOM) 
                 * is a Unicode character, 
                 * U+FEFF BYTE ORDER MARK (BOM), 
                 * whose appearance as a magic number at the 
                 * start of a text stream can signal several 
                 * things to a program reading the text:[1] 
                 * The byte order, or endianness, 
                 * of the text stream;
                 * ----------------------------------------------
                 * The fact that the text stream's encoding is Unicode, to a high level of confidence;
                 * Which Unicode encoding the text stream is encoded as.
                 * BOM use is optional.
                 * 
                 * Its presence interferes with the use of UTF-8 by software that does not 
                 * expect non-ASCII bytes at the start of a file but that could otherwise handle the text stream. 
                 * Unicode can be encoded in units of 8-bit, 16-bit, or 32-bit integers. 
                 * For the 16- and 32-bit representations, a computer receiving text from arbitrary sources 
                 * needs to know which byte order the integers are encoded in.
                 * 
                 * The BOM is encoded in the same scheme as the rest of the document and 
                 * becomes a non-character Unicode code point if its bytes are swapped. 
                 * 
                 * Hence, the process accessing the text can examine these first few bytes to determine the endianess, 
                 * without requiring some contract or metadata outside of the text stream itself. 
                 * 
                 * Generally the receiving computer will swap the bytes to its own endianess, 
                 * if necessary, and would no longer need the BOM for processing. 
                 * The byte sequence of the BOM differs per Unicode encoding
                 * (including ones outside the Unicode standard such as UTF-7, see table below), and 
                 * none of the sequences is likely to appear at the start of text streams stored in other encodings. 
                 * 
                 * Therefore, placing an encoded BOM at the start of a text stream can indicate 
                 * hat the text is Unicode and identify the encoding scheme used. 
                 * This use of the BOM character is called a "Unicode signature".
                 * 
                 * 
                 * Next New Windows 10 - Open Branch - 2020 more Unicode .
                 * emoij's, kat-emoij's with chat symbols, symbols.
                 * OS-Build at Time 18875 - 2020 - 20H1 - on FlightHub.
                 * 
                 * 
                 * All New Projects in Visual Studio 2019 Version 16.0.3 saved with -UTF16- .csproj....
                 * UTF-16  by Common Language Runtime In/Out Operations.
                 * 
                 * ------------------------------------------------------------------------------------
                 * International System of SI Units from 20 May 2019 comes into force.
                 * International Bureau for Measurement and Weights in Paris.
                 * ------------------------------------------------------------------------------------
                 * means Ade basis-units, Welcome natural constants !.
                 * New Definition for:
                 * Ampere, Kelvin, Mol, Candela, Second, Meter, Kilogram.
                 * 
                 * 
                 * 
                 * ------------------------------------------------------------------------------------
                 * TIPPOTIP: 
                 * In our Documentation, Whitepaper from Dr. Knittel -CBM- English Translation for this.
                 * 
                 * ---------------------------------------------------------wuri as constant uri string
                 * ---------------------------------------------------------set instance with Class Uri
                 * ---------------------------------------------------------.Original String call 
                 */

                // Start Process with Microsoft Edge Webbrowser and given Website as Original String by Class URI in namespacw System.
                Process.Start("microsoft-edge:"+ wuri.OriginalString);
            }
            // if the Process does't start, throw Excepetionhandler
            // new writing with Operator || double vertical bar, like Java Exceptions
            // Process.Start have four Exceptions.
            catch (SystemException ex) when (ex is InvalidOperationException || ex is Win32Exception || ex is FileNotFoundException)
            {
                // I have written for .NET the good old MessageBox with intellisense window by STYLES
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }
            return true;

        } // end of Method::VGFStartMicrosoftWebSite

        /// <summary>
        /// Start GitHub Projectsite
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        /// 
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Change bool to string, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// </remarks> 
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// returned true or false as Literal String True/False
        /// </returns>
        public static string VGFStartGitHubProjectSite()
        {
            try
            {
                // Start Process with Microsoft Edge Webbrowser and given Website as Original String
                // string microsoft-edge:websitename or URL
                Process.Start("microsoft-edge:" + vgfdevTipplinVGFGitHub.OriginalString);
                
                // true normally give 1 returned, here set bool.ToString give turned True or False as literal string
                // but must change bool in Method-declaration into string as returned datatype.
                return true.ToString();
            }
            catch (InvalidOperationException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false.ToString();
            }

        } // end of Method::VGFStartGitHubProjectSite

        /*

         static bool VGFIsInRole(string Role)
        {
            //return Principal.IsInRole(Role);



        }

        /// <summary
        /// Callback method for the OnOperationStart event.
        /// </summary
        public static void CountOperationCalls(ICallable op, IApplyData data)

        {

            if (_operationsCount.ContainsKey(op))

            {

                _operationsCount[op]++;

            }

            else

            {

                _operationsCount[op] = 1;

            }

        }

        */

        /// <summary>
        /// Current User Is Administrator
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        /// Both instance in Class-Head !.
        /// Class WindowsPrincipal
        /// Class WindowsIdentity
        /// p is the instancevariable with member is class.
        /// But note WindowsBuiltInRole is an Enumerator ! no class,
        /// so must set in ().
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Visual C#
        /// Change bool to string by return, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// </remarks>
        /// <returns>
        /// Windows 10 Operation System have then 9 Roles in Windows Membership,
        /// System-Tool-command: net localgroup - commandline
        /// 
        /// * Administratoren
        /// * Benutzer
        /// * Distributed COM-Benutzer
        /// * Ereignisprotokollleser
        /// * Gäste
        /// * Hauptbenutzer
        /// * Hyper-V-Administratoren
        /// * IIS_IUSRS
        /// * Kryptografie-Operatoren
        /// * Leistungsprotokollbenutzer
        /// * Leistungsüberwachungsbenutzer
        /// * Netzwerkkonfigurations-Operatoren
        /// *
        /// * PVGF - Project Visual Galaxy Framework - Benutzerverwaltung
        /// * angelegt im System-tool netplwiz.exe unter Benutzer und Gruppe.
        /// * netplwiz.exe mit Windows 10 Web Password Tresor all your Web Password are saved.
        /// *
        /// * Remotedesktopbenutzer
        /// * Remoteverwaltungsbenutzer
        /// * Replikations-Operator
        /// * Sicherungs-Operatoren
        /// * Ssh Users
        /// * System Managed Accounts Group
        /// * WmsOperators
        /// * Zugriffssteuerungs-Unterstützungsoperatoren
        /// </returns>
        public static string VGFIsAdmin()
        {
            // p as class instance holder, define in Class Head as static for all others.
            return p.IsInRole(WindowsBuiltInRole.Administrator).ToString(); 
        }

        /// <summary>
        /// Is User
        /// </summary>
        /// <!-- Author Tippolin 🧑 -->
        /// ! NOTE ! User has no all Rights on Computer as the Administrator.
        /// Windows 10 make sure same Folders, User can't open it !.
        /// <!-- Author Tippolin 🧑 -->
        /// <remarks>
        /// Change bool to string, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// normally 0 or 1 as return.
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsUser()
        {
            return p.IsInRole(WindowsBuiltInRole.User).ToString();
        }

        /// <summary>
        /// Is Guest
        /// </summary>
        /// <!-- Author Tippolin 🧑-->
        /// Guest have no rights, same Guest Roles can set in Windows 10.
        /// <!-- Author Tippolin 🧑-->
        /// <remarks>
        /// Change bool to string, is bool.ToString()
        /// while returned bool as string literal,
        /// True or False as string.
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsGuest()
        {
            return p.IsInRole(WindowsBuiltInRole.Guest).ToString();
        }

        /// <summary>
        /// Account Operator can add User to System with new Account,
        /// Administrator same, Users and Groups.
        /// While Windows 10 Professional is an Multi User System,
        /// one User or more on one Computer/PC.
        /// Windows 10 Professionl have  Database 'Resent',
        /// for Services, Recovery,
        /// Limit Database size 16 Terabyte. (MS SQL Server 2017 524 Terabyte.)
        /// </summary>
        /// <!-- Author Tipplin 🧑 -->
        /// 
        /// <!-- Author Tipplin 🧑 -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsAccountOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.AccountOperator).ToString();
        }

        /// <summary>
        /// Backup Operator can make Backup, full.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <!-- Author Tippo 🧑 -->
        /// <remarks>
        /// 
        /// </remarks> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsBackupOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.BackupOperator).ToString();
        }

        /// <summary>
        /// Replicator Operator can make File Replications.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// File Replication in domain
        /// <!-- Author Tippo 🧑 -->
        /// 
        /// <returns>
        /// NOTE: returned True or False as string
        /// </returns>
        public static string VGFIsReplicatorOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.Replicator).ToString();
        }

        /// <summary>
        /// System Operator manage particular computer.
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// particular computer settings
        /// <!-- Author Tippo 🧑 -->
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsSystemOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.SystemOperator).ToString();
        }

        /// <summary>
        /// Print Operator can take control of Printer
        /// </summary>
        /// <!-- Author Tippo 🧑 -->
        /// manage Printer or Printers in Network.
        /// <!-- Author Tippo 🧑 --> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFIsPrintOperator()
        {
            return p.IsInRole(WindowsBuiltInRole.PrintOperator).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// NOTE: bool true or false here returned as string True or False
        /// Method-declaration set string, not bool !.
        /// </returns>
        internal static string VGFUseFeatureMethod()
        {
            if(VGFRegisteredUser() == false)
            {
                return false.ToString();
            }
            else
            {
                return true.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static bool VGFRegisteredUser()
        {
            /*
             * Registry prüfen, ob Methode benutzt werden darf, 
             * nur registierte Benutzer !.
             * 
             */
            return false;
        }







    } // CLASS_END::VGFCore


    /// <summary>
    /// A class that helps do interop calls that take/return buffers.
    /// </summary>
    /// <!-- Author Tipplin 🧑 -->
    /// 
    /// <!-- Author Tipplin 🧑 -->
    /// <remarks>
    /// This holds onto a StringBuilder and an int that represent the
    /// arguments typically passed to such functions.
    /// DoBufferAction's overloads contain the necessary buffer sizing
    /// logic for doing calls that take string buffers.
    /// </remarks>
    public class VGFCoreBufferData
    {

        internal static StringBuilder Buffer = null;

        /// <summary>
        /// The length of the buffer, exposed so that it can be passed by ref
        /// </summary>
        internal static int Length = 0;

        /// <summary>
        /// Sets the length based on the current capacity of the buffer
        /// </summary>
        public static void VGFCoreSetLength()
        {
            Length = Buffer == null ? 0 : Buffer.Capacity;
        }

        /// <summary>
        /// Creates a buffer with a default initial capacity.
        /// </summary>
        static VGFCoreBufferData()
        {
            Buffer = new StringBuilder();
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates a buffer with an initial capacity
        /// </summary>
        /// <param name="capacity">The initial capacity of the buffer</param>
        public VGFCoreBufferData(int capacity)
        {
            Buffer = new StringBuilder(capacity);
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates a buffer containing the specified string and appropriate capacity.
        /// Useful for in/out parameters.
        /// </summary>
        /// <param name="str">The initial contents of the buffer</param>
        public VGFCoreBufferData(string str)
        {
            Buffer = new StringBuilder(str);
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates a buffer containing the specified string and with a specified capacity
        /// </summary>
        /// <param name="str">The initial contents of the buffer</param>
        /// <param name="capacity">The initial capacity of the buffer</param>
        public VGFCoreBufferData(string str, int capacity)
        {
            Buffer = new StringBuilder(str, capacity);
            VGFCoreSetLength();
        }

        /// <summary>
        /// Creates/grows the  buffer as necessary to accomodate the current.
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFCoreSetCapacity()
        {
            if (Buffer == null)
            {
                Buffer = new StringBuilder(Length);
                return true;
            }
            else if (Buffer.Capacity < Length)
            {
                Buffer.Capacity = Length;
                return true;
            }
            return false;
        }

        
        

       

        
    } // END_OF_CLASS::VGFCoreBufferData
    
    /// <summary>
    /// 
    /// </summary>
    public static class VGFCoreUrls
    {
        

        /// <summary>
        /// 
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <param name="index"></param>
        /// <param name="values"></param>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetValue(int index, string[] values)
        {
            return values[index % values.Length];
        }

        /// <summary>
        /// 
        /// </summary>
        internal static string[] TextSnippetValues = new string[]
        {
            // index 0
            "What time did the man go to the dentist?",
            // index 1
            "I don't know.",
            // index 2
            "Tooth hurt-y.",
            // index 3
            "Did you hear about the guy who invented Lifesavers?",

            "No.",

            "They say he made a mint.",

            "A ham sandwich walks into a bar and orders a beer. Bartender says, 'Sorry we don't serve food here.'",

            "Whenever the cashier at the grocery store asks my dad if he would like the milk in a bag he replies, 'No, just leave it in the carton!'",

            "Why do chicken coops only have two doors?",

            "I don't know, why?",

            "Because if they had four, they would be chicken sedans!",

        };

        /// <summary>
        /// 
        /// </summary>
        internal static string[] UserNameValues = new string[]
        {
            // index 0
            "Parent",
            // index 1
            "Child",

        };

        /// <summary>
        /// 
        /// </summary>
        internal static string[] ImagesValues = new string[]
        {
            // index 0
            "ms-appx:///images/blueuser.png",
            // index 1
            "ms-appx:///images/reduser.png",

        };

        internal static string VGFGetInternalMessage(string MethodName, int data)
        {
            string msg;


            switch (data)
            {
                case 1:
                    msg = "close";
                    break;

                case 2:
                    msg = "Illegal Call, don't call this Method {0} directly !.\n" + MethodName;
                    msg += "Illegal Calls throw an exception IllegalCallMethodException !.";
                    break;
                default:
                    msg = "nothing";
                    break;
            }

            return msg;

        }




        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static string VGFURIWebsiteArray()
        {
            return sources.IndexOf("1").ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArrayItem"></param>
        /// <returns></returns>
        internal static string VGFURIWebsiteArray2(string ArrayItem)
        {
            return sources.IndexOf(ArrayItem).ToString();
        }

        /// <summary>
        /// VGFWaitSeconds
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// Method with optional pararmeters MessageText and MessageTitle,
        /// paramter milliseconds must be have an Value !.
        /// See in code asterics operator for an Call or 
        /// show MessageBox after Sleep an thread in milliseconds
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <param name="milliseconds">Set milliseconds value</param>
        /// <param name="MessageText">Optional set Text for MessageBox</param>
        /// <param name="MessageTitle">Optional set Title for MessageBox</param>
        /// <remarks>
        /// Optional Parameters in C# - 
        /// string MessageText="" as null value, can be change in Call or in code.
        /// </remarks>
        public static void VGFWaitSeconds(uint milliseconds, string MessageText = "", string MessageTitle = "")
        {

            if (milliseconds <= 0 || milliseconds > 10000)
            {
                VFLMsgBox("Arguments out of range !", "VGFWaitSeconds::Parameter:milliseconds", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMExit(EXIT_CODES.ERROR_BAD_ARGUMENTS);
            }
            // Check Optional Parameters, if the values are null ?
            else if (MessageText.Length == 0 || MessageTitle.Length == 0)
            {
                // Operator * is an uint uint.operator(uint left, uint right)
                // Sleep with Operator * asterics for an Call or MessageBox show with Text and Title.
                // Sleep waitable with given milliseconds, after timeout than calls the Method, or show MessageBox
                Sleep(milliseconds * VFLMsgBox("undefine MessageText", "undefine MessageTitle", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal));
            }
            else
            {
                Sleep(milliseconds * VFLMsgBox(MessageText, MessageTitle, STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal));
            }
        }

        /// <summary>
        /// Get World Wide Country Name
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// 
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <param name="ArrayItem">Index Begin with 1 to 190 ABC sorted</param>
        /// <remarks>
        /// Array's in Visual C# begins everytime with Index 0,
        /// want begin by 1, so make Index 0 = "",
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetWorldWideCountry(int ArrayItem)
        {
            return VGFCore.VGFWorldWide.VGFWorldCountries.ElementAt(ArrayItem);

        }

        /// <summary>
        /// Get the Name of USA State
        /// </summary>
        /// <param name="ArrayItem"></param>
        /// <returns></returns>
        public static string VGFGetShortNameOf_USAState(int ArrayItem)
        {
            return VGFCore.VGFWorldWide.VGFUSStates.ElementAt(ArrayItem);

        }

        /* without access modi public, internal, protected, private
         * Visual C# insert private automatic.
         * ! ATTENTION ! private have now 7.3 an protection degree.
         * No access !
         */

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFExperitmenalMethod(int e, int Index)
        {
            switch (e)
            {
                case 0:
                    return e.ToString(Environment.MachineName);
                    
                case 1:
                    return e.ToString(Environment.UserName);
                case 2:
                    return "Type '{0}' is not writable" + Index.ToString();
                default:
                    NRMExit(EXIT_CODES.ERROR_INVALID_INDEX);
                    return "ERROR_INVALID_INDEX";
                    

            }
           
        }


        /// <summary>
        /// Uri Microsoft Website🌀
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// Class Uri form namespace System
        /// NOTE: without accessmofi public, all private with degree of protection,
        /// private now is standard in Visual C# without set.
        /// no access from outside.
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <remarks>
        /// @ unicode sign, so only one slash !
        /// 
        /// See Microsoft have change the dir for Webbrowser Edge and inside works the Chromium Engine,
        /// New is the Translator for Languages, so you can translate Websites and others.
        /// New is Virus Scan for all Download Files, TAB Downloads View, cancel Donwload,
        /// 
        /// C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe
        /// 
        /// Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", wuri.OriginalString);
        /// 
        /// wuri.OrignalString is the string for the Website Microsoft in German.
        /// </remarks>
        public static Uri wuri = new Uri("https://www.microsoft.com/de-de/");

        /// <summary>
        /// Microsoft TV Channel 9 with many Video's for all Developer.
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// Uri's as constant for OrginalString
        /// 
        /// Attention ! 
        /// without access modifier set internal private with degree of protection, 
        /// no external access.
        /// Either internal or public take.
        /// have forgotten by static uri... access modi public.
        /// 
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <remarks>
        /// Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", wuri.OriginalString);
        /// start process with NEW Webbrowser Microsoft Edge and directly Website channel9.msdn.com
        /// this is the Microsoft TV with TV Studios in Redmond, like CNN or others.
        /// 
        /// Most when LIVE Shows = LIVE Streaming, in Pause shows the People of Studio (steady cam)
        /// everything can send e-mails in Studio with Questions to Presenter to Developer and so...
        /// Developer in Studio: Windows Team, Visual Studio Team and more...
        /// Any Week news from Microsoft, most by Christina Warren 'Speech machine gun'.
        /// ----------------------------------------------------------------------------------------
        /// Directly call with Microsoft Edge Webbrowser:
        /// Process.Start("icrosoft-Edge:" + wuri1.OrginalString);
        /// wuri1.OrignalString is the string for the Website.
        /// ----------------------------------------------------------------------------------------
        /// </remarks>
        public static Uri wuri1 = new Uri("https://channel9.msdn.com/");


        /// <summary>
        /// Our secure 📬mailbox for anonymous messages in case 
        /// of rule violations our 🚻 Community Members.
        /// </summary>
        public static Uri vgfCommunityInvestigativ = new Uri("https://vgfc.org/community/investigativ");

        // &, () is not allwoed in XML Comment Block set +

        /// <summary>
        /// Community Helpful+Respectful
        /// </summary>
        public static Uri vgfCommunityHelp = new Uri("https://vgfc.org/community/helpfulrespectful");

        /// <summary>
        /// Website to 🧑 Tipplin 🧑 by Project Visual Galaxy Framework
        /// </summary>
        public static Uri vgfdevTipplinVGFGitHub = new Uri("https://github.com/Tipplin/VGF");

        /// <summary>
        /// Website to 🧑 Tipplin 🧑 by VGF Community
        /// </summary>
        public static Uri vgfdevTipplinVGFCommunity = new Uri("https://vgfc.org/community/open");

        /// <summary>
        /// Website to VGF KernelTeam by 🧑 Tipplin 🧑
        /// </summary>
        public static Uri vgfdevTipplinVGFKernelTeam = new Uri("https://vgfc.org/community/kernelteam/tippo");

        /// <summary>
        /// Website to VGF KernelTeam by 🦁 Tiger 🦁
        /// </summary>
        public static Uri vgfdevTigerVGFKernelTeam = new Uri("https://www.vgfc.org/community/kernelteam/tiger");



        /// <summary>
        /// 🧑 Tipplin 🧑 E-mail adress for send mail to me!
        /// </summary>
        /// <!-- 🧑Author Tipplin🧑 -->
        /// Base E-mail-adress
        /// <!-- 🧑Author Tipplin🧑 -->
        /// <remarks>
        /// For E-Mail Method directly to me as Author.
        /// -------------------------------------------------------------------
        /// For Developer:
        /// -------------------------------------------------------------------
        /// All defined Attribute's, 
        /// all Attribute have the full set of regular expressions:
        /// so you can check/proof the given value/string.
        /// 
        /// namespace System.ComponentModel.DataAnnotations
        /// 
        /// CreditCardAttribute - Mastercard, Visa, American express card
        /// (Visa is first one the World.)
        /// EmailAddressAttribute - check email adress - allowed/not allowed characters
        /// MinLengthAttribute - set the minimum length of a string
        /// MaxLengthAttribute - set the maxnimum length of a string
        /// PhoneAttribute 
        /// UrlAttribute 
        /// RangeAttribute 
        /// 
        /// </remarks>
        public static Uri vgfdevTipplinVGFMail = new Uri("kurschristian@gmail.com");



        #endregion




    }  // END::OF:: class URLS

    #endregion

} // NAME_SPACE_END::Visual.Galaxy.Framework.Core
