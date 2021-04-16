//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "Tipplin" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.AssemblyInfo
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2017-2021
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
// Portions Copyright © 2017-2020 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
/*-----------------------------------------------------------------------------
 * Copyright © 2017-2021 Christian 'Tipplin' Kurs. All Rights Reserved.
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

/*******************************************************************************
 * 
 * Microsoft make Restrictions of Export for following Countries:
 * 
 *******************************************************************************
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
 * © 1982 - 2021 Microsoft Corporation.All rights reserved.
 * -----------------------------------------------------------------------------
*/

//
// Set here the System Directives from .NET Framework 4.8
//

#region System - Directives from .NET Framework

using System;
using System.IO;
using System.Security;
using System.Reflection;
using System.Runtime;


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

#region Directives plus static class from internal Visual.Galaxy.Framework  

//
using static Visual.Galaxy.Framework.VGFCore;


#endregion

#region Directives from Visual.Operation.System.dll

// static Class NativeMethods for Constants, Enumerator, Struct's, variables...
using static Visual.Operation.System.Native.NativeMethods;

// All Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// Constants for MessageBox, StartUp
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

// Visual.Function.Library.dll - our Functions for use written in C/C++.


// All C/C++ Runtime Library Functions for use.
using static Visual.Operation.System.Native.NativeRuntimeMethods;

//
using Visual.Operation.System.Internal.InternalUtilities;


#endregion

//-----------------------------------------------------------------------------
// Only one namespace at First
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Assembly
{
    /// <summary>
    /// Assembly Visual.Galaxy.Framework.dll
    /// </summary>
    /// <!-- Author Tipplin -->
    /// Specials Infos about Assembly Visual.Galaxy.Framework
    /// <!-- Author Tipplin -->
    /// <remarks>
    /// Assembly Informations - Properties from Class AssemblyInfo in AssemblyInfo.cs
    /// Late Binding and Loading - LoadAssembly
    /// AddAssembly to Project/App
    /// 
    /// 
    /// </remarks>
    public static class VGFAssembly
    {

        /*********************************************************************************
         * Globals can you set here!
         * instances, variables
         * 
         * NOTE! without access modi, means public, protected, internal, private protected
         * the instance is private, is standard in C#.
         * but don't forget 'private' is degree of protection.
         *********************************************************************************
         */

        /*=============================== AUTHORS INFO ===================================
         * <Titel>
         * Project-Solutionname
         * Copyright © 2017-2021 by  VGF Community Kernel Developer Team. 
         * Portions © 1982 - 2021 by Microsoft Corporation. All rights reserved.
         * </Titel>
         * 
         * <Author>
         *      Christian 'Tipplin' Kurs
         *      Parts declared with shortname 'Tipplin'
         *      Copyright © 2017-2021 by Christian 'Tipplin' Kurs. 
         * </Author>
         * <Author-Url>
         *      https://www.kurschristian.de
         * </Author-Url>
         * 
         * <Community-Url>
         *      https://www.vgfc.org
         * </Community-Url>
         * 
         * <Project-Url on GitHub>
         *      https://github.com/Tipplin/Visual.Galaxy.Framework
         * </Project-Url on GitHub>
         * 
         * 
         * <Description>
         *      Code Description
         * </Description>
         * 
         * <ToolTip>
         * 
         * </ToolTip>
         * 
         * <Declarations>
         * 
         * </Declarations>
         * 
         * <Default>
         *      Default value
         * </Default>
         * 
         * <Reference>
         *      <Assembly>
         *      
         *      </Assembly>
         *      <Url>
         *      
         *      </Url>
         * </Reference>
         * 
         * <Dependencies>
         *      <Assemblyname>
         *          Internal Assembly with public classes
         *          or
         *          Friendly Assembly declared with public access of all Classes and Methods...
         *      </Assemblyname>
         * </Dependencies>
         * 
         * 
         * 
         * 
         * 
         *=============================== END OF AUTHOR INFO =============================
         */



        /*--------------------------------------------------------------------------------
         * <Author>
         * -------------------------------------------------------------------------------
         *  Author Christian 'Tipplin' Kurs NOTE:
         *  ! NEWS ! at .NET 5.0 Framework Project-Solution and more:
         *  ------------------------------------------------------------------------------
         *  First way to access of the Attribute Classes in Solutionname.AssemblyInfo.cs
         *  
         *  Microsoft have change the File AssemblyInfo.cs, 
         *  all Attributes are now in an Class separtly, 
         *  the File can't be change, delete or other, or insert others, 
         *  with ! WARNING ! Message inside der File, 
         *  this File is yet an auto created file from build running.
         *  ------------------------------------------------------------------------------
         * </Author>
         * -------------------------------------------------------------------------------
        */

        /*
         * NOTE: when the public, internal fail, automatic set C# private, is standard !.
         */

       
        
       



        /// <summary>
        /// Get Fullname of VGF Assembly
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!--Author Tipplin -->
        /// <remarks>
        /// The Information come from AssemblyInfo.cs
        /// with Class VGFAssemblyInfo and Properties
        /// this Class is not normally !.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetAssemblyName()
        {
            AssemblyName assemblyName = null;
            // Name of this Assembly
            return assemblyName.Name;
        }

        /// <summary>
        /// Get VGF Assembly Copyright
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetAssemblyCopyright()
        {
            AssemblyCopyrightAttribute assemblyCopyright = null;
            return assemblyCopyright.ToString();
        }

        /// <summary>
        /// Get VGF Assembly current Version Number
        /// </summary>
        /// <returns></returns>
        public static string VGFGetAssemblyVersion()
        {
            AssemblyVersionAttribute assemblyVersion = null;
            return assemblyVersion.Version;
        }

        /// <summary>
        /// Get VGF Assembly Company Name
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Specials Infos about Visual.Galaxy.Framework.dll
        /// <!-- Author Tipplin --> 
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetAssemblyCompanyName()
        {
            AssemblyCompanyAttribute assemblyCompany = null;
            return assemblyCompany.Company;
        }

        /// <summary>
        /// Get VGF Assembly Product Name
        /// </summary>
        /// <returns></returns>
        public static string VGFGetAssemblyProductName()
        {
            AssemblyProductAttribute assemblyProduct = null;
            return assemblyProduct.Product;
        }

        /// <summary>
        /// Get VGF Assembly Description
        /// </summary>
        /// <returns></returns>
        public static string VGFGetAssemblyDescription()
        {
            AssemblyDescriptionAttribute assemblyDescription = null;
            return assemblyDescription.Description;
        }

        /// <summary>
        /// Get VGF Assembly Title Name
        /// </summary>
        /// <returns></returns>
        public static string VGFGetAssemblyTitleName()
        {
            AssemblyTitleAttribute assemblyTitle = null;
            return assemblyTitle.Title;
        }

        /// <summary>
        /// Get VGF Assembly File Version
        /// </summary>
        /// <returns></returns>
        public static string VGFGetAssemblyFileVersion()
        {

            AssemblyFileVersionAttribute assemblyFileVersion = null;
            return assemblyFileVersion.ToString();

        }



    } // END_OF_CLASS::VGFAssembly  
       
} // END_OF_NAMESPACE::Visual.Galaxy.Framework.Assembly
