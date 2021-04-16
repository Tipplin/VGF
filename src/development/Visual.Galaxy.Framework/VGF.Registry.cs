//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "Tipplin" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Exception
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2018
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
// Portions Copyright © 2018 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
//
// For same secured Assemblies set inside internal for class, Methods...
// for use in Visual Galaxy Framework, 
// give free with:
//
// [InternalsVisibleAttribute("Visual.Galaxy.Framework", 
// AllInternalsVisible = true)]
//
// ============================================================================
// Warning:  
// ============================================================================
// This product is licensed to you pursuant to the terms of the 
// VGF license agreement included with the original software, and is
// protected by copyright law and international treaties.Unauthorized
// reproduction or distribution may result in severe civil and criminal
// penalties, and will be prosecuted to the maximum extent possible under
// the law.
// You cannot distribute a compiled version 
// of this code without prior registration.
//
// Please see the documentation supplied with
// the VGF Libraries for further details.
//
// Authored by 
// Copyright © 2018
// by  Visual Galaxy Framework Community Kernel Developer Team.
// all rights reserved.
// May be redistributed for free,
// but may not be sold without the author's explicit permission
//
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
// 
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
//involved with missile technology or nuclear, chemical or biological weapons).
//
// © 1982 - 2018 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// VFGCore
// written by 		
//						Christian "Tipplin" Kurs
//						Nettweg 1
//				-G -  53498 Bad Breisig
//						Germany - Allemagne - Duitsland
//-----------------------------------------------------------------------------
// 				voice                   :	02633 - 470736  
//					international phone :	00-49-2633-470736
//					Skype               :
//					e-mail				:	Christian.Kurs@gmail.de
//					community Website	:	http://www.vgfc.org/community/Tipplin
//										
//-----------------------------------------------------------------------------
// This software is supplied as is. Use it at your own  RISK !!!!.
// Obviously I've tried to do the best job possible.
// If you find any problem with it, let me know.
//
// With any luck, Visual Galaxy Framework will make it obsolete anyway
//----------------------------------------------------------------------------
// License:	
//				NO fee for NON-Commercial use.
//				our Community Website:
// 
//						http://www.vgfc.org/community/project/vgf/
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//				www.vgf.com/business/vgf/License
//
//-----------------------------------------------------------------------------

/*********************** Developer Disclaimer *********************************
 *
 * Copyright © 2018 by Christian 'Tipplin' Kurs - Germany
 * 
 ******************************************************************************
 * 
 * English
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy 
 * of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, 
 * publish, distribute, sublicense, and/or sell copies of the Software, and 
 * to permit persons to whom the Software is furnished to do so, 
 * 
 * subject to the following conditions:
 * The above copyright notice and this permission notice shall be included 
 * in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE 
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE 
 * AND NONINFRINGEMENT.
 * 
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * ----------------------------------------------------------------------------
 * 
 * German:
 * 
 * Personen, die eine Kopie dieser Software und der dazugehörigen 
 * Dokumentationsdateien (die "Software") erhalten, 
 * wird hiermit die kostenlose Erlaubnis erteilt.
 * uneingeschränkt mit der Software zu handeln, 
 * einschließlich der Rechte zur Verwendung, zum Kopieren, Ändern, 
 * Zusammenführen, Veröffentlichen, Verteilen,
 * Unterlizenzen und / oder Verkauf von Kopien der Software und 
 * Erlaubnis von Personen, an die die Software geliefert wird,
 * 
 * unter den folgenden Bedingungen:
 * 
 * Der obige Copyright-Hinweis und dieser Erlaubnisschein sind in 
 * allen Kopien oder wesentlichen Teilen der Software enthalten.
 * 
 * DIE SOFTWARE WIRD "WIE BESEHEN" OHNE JEGLICHE GARANTIE, 
 * AUSDRÜCKLICH ODER IMPLIZIERT, EINSCHLIESSLICH, ABER NICHT BESCHRÄNKT 
 * AUF DIE GEWÄHRLEISTUNG DER MARKTFÄHIGKEIT, 
 * EIGNUNG FÜR EINEN BESTIMMTEN ZWECK UND NICHTVERLETZUNG.
 * 
 * IN KEINEM FALL HAFTEN DIE AUTOREN ODER COPYRIGHT-INHABER FÜR ANSPRÜCHE, 
 * SCHADEN ODER ANDERE HAFTUNG.
 * 
 * WENN SIE AUSSCHLIESSLICH EINES VERTRAGS, TORTES ODER ANDERWEITIG SIND, 
 * HERAUSGEGEBEN, ABER ODER IN VERBINDUNG MIT DER SOFTWARE 
 * ODER DIE NUTZUNG ODER ANDERE ABKOMMEN IN DER SOFTWARE.
 * 
 * ----------------------------------------------------------------------------
 *
 * Frensh:
 * Par la présente, une autorisation est accordée gratuitement à toute personne 
 * obtenant une copie de ce logiciel et des fichiers de documentation associée 
 * (le "Logiciel"),
 * traiter le logiciel sans restriction, y compris, sans limitation, 
 * les droits d'utilisation, de copie, de modification, de fusion, 
 * de publication, de distribution, sous-licence, 
 * et / ou vendre des copies du logiciel, 
 * et permettre aux personnes à qui le logiciel est fourni de le faire,
 * 
 * sous réserve des conditions suivantes:
 * 
 * L'avis de copyright ci-dessus et cet avis de permission doivent être inclus 
 * dans toutes les copies ou parties substantielles du logiciel.
 * 
 * LE LOGICIEL EST FOURNI "EN l’ETAT", SANS AUCUNE GARANTIE, 
 * EXPRESSE OU IMPLICITE,
 * Y COMPRIS, MAIS SANS S'Y LIMITER, LES GARANTIES DE VALEUR MARCHANDE, 
 * D'ADÉQUATION À UN USAGE PARTICULIER ET D'ABSENCE DE VIOLATION.
 * EN AUCUN CAS, LES AUTEURS OU LES TITULAIRES DU DROIT D'AUTEUR NE PEUVENT 
 * ÊTRE TENUS RESPONSABLES DE TOUTE RÉCLAMATION, 
 * DE DOMMAGES OU D'AUTRE RESPONSABILITÉ
 * QU'IL SOIT DANS UN ACTION DE CONTRAT, DE LORT OU DE AUTRE FACILITÉ, 
 * RÉSULTANT DU LOGICIEL, OU NON OU LIÉ AVEC CE LOGICIEL
 * OU L'UTILISATION OU D'AUTRES TRANSACTIONS DANS LE LOGICIEL.
 * 
 * ----------------------------------------------------------------------------
 * 
 * Spanish:
 * 
 * Por la presente se otorga el permiso, sin cargo, a cualquier persona que 
 * obtenga una copia de este software y los archivos de 
 * documentación asociados (el "Software"), para operar en el Software sin 
 * restricciones, incluidos, entre otros, los derechos de uso, copia, 
 * modificación, combinación, publicación, distribución, sublicenciar, 
 * y / o vender copias del Software, y para permitir que las 
 * personas a quienes se suministra el Software lo hagan,
 * 
 * sujeto a las siguientes condiciones:
 * 
 * El aviso de copyright anterior y este aviso de permiso se incluirán 
 * en todas las copias o partes sustanciales del Software.
 * 
 * EL SOFTWARE SE PROPORCIONA "TAL CUAL", SIN GARANTÍA DE NINGÚN TIPO, 
 * EXPRESA O IMPLÍCITA, INCLUYENDO PERO NO LIMITADO A LAS 
 * GARANTÍAS DE COMERCIABILIDAD, APTITUD PARA UN PROPÓSITO 
 * PARTICULAR Y NO INCUMPLIMIENTO. EN NINGÚN CASO, LOS AUTORES O TITULARES DE 
 * DERECHOS DE AUTOR SERÁN RESPONSABLES POR CUALQUIER RECLAMACIÓN, 
 * DAÑOS U OTRAS RESPONSABILIDADES, SI EN UNA ACCIÓN DE CONTRATO, 
 * CORTE O DE OTRA MANERA, DERIVADO DE, FUERA DE O EN CONEXIÓN CON EL SOFTWARE
 * O EL USO O OTROS TRATOS EN EL SOFTWARE.
 * 
 * -----------------------------------------------------------------------------
 * 
 * Italian:
 * 
 * L'autorizzazione è concessa, a titolo gratuito, a chiunque ottenga una copia 
 * di questo software e dei relativi file di documentazione (il "Software"),
 * trattare il Software senza limitazioni, 
 * inclusi senza limitazione i diritti di utilizzo, copia, modifica, fusione, 
 * pubblicazione, distribuzione, concedere in sub-licenza e / o vendere 
 * copie del Software e consentire alle persone a cui è fornito 
 * il Software di farlo, 
 * soggetto alle seguenti condizioni:
 * 
 * La suddetta nota sul copyright e questa nota di autorizzazione devono 
 * essere incluse in tutte le copie o parti sostanziali del Software.
 * 
 * IL SOFTWARE VIENE FORNITO "COSÌ COM'È", SENZA GARANZIA DI ALCUN TIPO, 
 * ESPRESSA O IMPLICITA, INCLUSE, A TITOLO ESEMPLIFICATIVO, 
 * LE GARANZIE DI COMMERCIABILITÀ, 
 * IDONEITÀ PER UN PARTICOLARE SCOPO E NON VIOLAZIONE. 
 * IN NESSUN CASO GLI AUTORI OI DETENTORI DEL COPYRIGHT SARANNO 
 * RITENUTI RESPONSABILI PER QUALSIASI RECLAMO, DANNO O ALTRO RESPONSABILITÀ,
 * SE IN UN AZIONE DI CONTRATTO, TORT O ALTRO, DERIVANTE DA, FUORI O IN 
 * CONNESSIONE CON IL SOFTWARE OPPURE L'USO O ALTRE RACCOLTE DEL SOFTWARE.
 *
 *****************************************************************************/

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
using System.Threading.Tasks;


//-----------------------------------------------------------------------------
//
// In this Project-Solution you use in all other namespaces 
// from other Visual C# name.cs Files:
// Classes and Methods are static written set this:
// here bind in Visual.Operation.System.dll, inside Attribute
// [InternalsInvisibleAttribute("Visual.Galaxy.Framework"), AllInternals = true]
// All internals written are visible in Project 'Visual Galaxy Framework'
//-----------------------------------------------------------------------------

// static Class NativeMethods for Constants, Enumerator, Struct's, variables...
using static Visual.Operation.System.Native.NativeMethods;

// All Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// Constants for MessageBox, StartUp
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

// Visual.Function.Library.dll - our Functions for use written in C/C++.


// All C/C++ Runtime Library Functions for use.
using static Visual.Operation.System.Native.NativeRuntimeMethods;

using Visual.Operation.System.Internal.InternalUtilities;

using static Visual.Registry.Library.VRLWindowsRegistry;

namespace VGF.Windows.SystemAbstractions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMicrosoftWin32Registry
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        object GetValue(string keyName, string valueName, object defaultValue);
    } // Interface

} // namespace

//-----------------------------------------------------------------------------
//
//
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Registry
{

    using VGF.Windows.SystemAbstractions;

    /// <summary>
    /// Class VGFRegistry
    /// </summary>
    /// <!-- Author Tipplin -->
    /// 
    /// <!-- Author Tipplinlin -->
    /// <remarks>
    /// Wrapper Methods for Methods from 
    /// Assembly Visual.Registry.Library.dll
    /// In Assembly internal written, can be visible with Attribute
    /// in AssemblyInfo.cs
    /// 
    /// </remarks>
    public static class VGFRegistry
    {

        /*---------------------------------------------------------------------
         * At class Head can set instances to Interfaces, Classes, 
         * Classes from other Visual C# Files (must be static written)
         *--------------------------------------------------------------------- 
         */

        //-----------------------------------------------------------------------------------------------------------------------
        // Registry Key for CurrentVersion with all Information about Operation System and Computer...
        // Regedit   - 32BIT Version
        // Regedit64 - 64BIT Version
        // ! ATTENTION ! The new Registry allowed more than 255 char's in an Key, BUT DON'T IT ! ENDLESS LOOP !!! by use the Key-
        // End Registry and start Registry new and more and more, Help is the System Tool: regrecovery, set the standards,
        // all must be new registering.
        // 64BIT Registry works with QWORD for DWORD and Multistring Array
        //-----------------------------------------------------------------------------------------------------------------------
        // The Registry Key UBR means the Revisionnumber, everytime Microsoft increment him by Bugs Fixes, security Fixes and so.
        // SystemTool: systeminfo.exe as console command show all Computer Information
        // net accounts show actual account of User,
        // Role of Computer: (by Windows 10 Professional is Workstation with many Network Libraries to connect to Server. CAL!?)
        //-----------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// 
        /// </summary>
        internal const string WindowsVersionRegKey = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion";
        
        /// <summary>
        /// Interface from IMicrosoftWin32Registry
        /// </summary>
        internal static IMicrosoftWin32Registry _registry = null;

        /// <summary>
        /// Check whether the current Windows is Windows 7 or not. 
        /// </summary>
        /// <returns></returns>
        internal static bool IsWindows7()
        {
            VFLMsgBox("Please update your Operation System to Windows 10 Build 19042 - 2020", "Check Operation System", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.TaskModal);
            
            return Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1;
        }

        /// <summary>
        /// Get the current Windows version info from HKLM
        /// </summary>
        /// <returns></returns>
        internal static string GetCurrentWindowsVersion()
        {
            var retVal = (string)_registry.GetValue(WindowsVersionRegKey, "CurrentVersion", "");
            return retVal;
        }

        /// <summary>
        /// Get the current Windows build info from HKLM
        /// </summary>
        /// <returns></returns>
        internal static string GetCurrentWindowsBuild()
        {
            return (string)_registry.GetValue(WindowsVersionRegKey, "CurrentBuild", "");
        }

        /// <summary>
        /// Returned the Key UBR for Windows 10 Revisionnumber
        /// </summary>
        /// <returns></returns>
        internal static string GetCurrentWindowsRevision()
        {
            return (string)_registry.GetValue(WindowsVersionRegKey, "UBR", "");
        }


        /// <summary>
        /// Get Windows Operation System BuildLabEx
        /// </summary>
        /// <!-- Author Tipplin -->
        /// BuildLabex means the created current Build with Date and Time compiled.
        /// 19640.1.amd64fre.mn_release.200530-1731
        /// Build 19640 30.05.2020 at 17:31
        /// <!-- Author Tipplin -->
        /// <returns>
        /// 
        /// </returns>
        internal static string GetCurrentWindowsBuildLab()
        {
            return (string)_registry.GetValue(WindowsVersionRegKey, "BuildLabEx", "");
        }

        /// <summary>
        /// Get the current Windows Operation System Build Lab
        /// </summary>
        /// <returns></returns>
        public static string VGFGetWindowsBuildLab()
        {
            return VRLGetCurrentBuildLab();
        }

        /// <summary>
        /// Get the current Windows Build Number
        /// </summary>
        /// <returns></returns>
        public static string VGFGetWindowsCurrentBuildNumber()
        {
            return VRLGetCurrentBuildNumber();
        }

        /// <summary>
        /// Get the Windows Operation System Editian Name
        /// </summary>
        /// <returns></returns>
        public static string VGFGetWindowsOperationSystemEdition()
        {
            return VRLGetCurrentEditionID();
        }

        /// <summary>
        /// Get Registered Organization Name
        /// </summary>
        /// <returns></returns>
        public static string VGFGetRegisteredOrganizationName()
        {
            return VRLGetCurrentRegisteredOrganization();
        }

        /// <summary>
        /// Get Current Registered Owner()
        /// </summary>
        /// <returns></returns>
        public static string VGFGetRegisteredOwner()
        {
            return VRLGetCurrentRegisteredOwner();
        }

        /// <summary>
        /// Get Windows Current Revisionnumber()
        /// </summary>
        /// <returns></returns>
        public static int VGFGetWindowsOperationSystemRevisionnumber()
        {
            return VRLGetCurrentRevisionnumber();
        }

        /// <summary>
        /// Compare with given RevisionNumber on Windows System.
        /// </summary>
        /// <param name="RevisionNumber"></param>
        /// <returns></returns>
        public static bool VGFCompareWithGivenRevisionNumber(int RevisionNumber)
        {
            return VRLValidateRevisionnumber(RevisionNumber);
        }

        /* Registry Short Entries for Windows 10 Operation System

            "SystemRoot" = "C:\\WINDOWS"
            "BuildBranch" = "rs_prerelease"
            "BuildGUID" = "ffffffff-ffff-ffff-ffff-ffffffffffff"
            "BuildLab" = "21277.rs_prerelease.201207-1443"---------------> OS-build.Milestone 4. date - time compile Windows
            -----------------------------------------------------------------------------------07.12.2020 at 14:43
            "BuildLabEx" = "21277.1000.amd64fre.rs_prerelease.201207-1443"--> everytime Microsoft make great update change this
            "CompositionEditionID" = "Professional"
            "CurrentBuild" = "21277"-----------------------------------> everytime Microsoft make great update change this
            "CurrentBuildNumber" = "21277"-----------------------------> everytime Microsoft make great update change this
            "CurrentMajorVersionNumber" = dword:0000000a
            "CurrentMinorVersionNumber" = dword : 00000000
            "CurrentType" = "Multiprocessor Free"
            "CurrentVersion" = "6.3"
            "EditionID" = "Professional" ------------------------------> Rule of Computers: WORKSTATION
            "EditionSubstring" = ""
            "InstallationType" = "Client"
            "InstallDate" = dword:5967e805
            "ProductName" = "Windows 10 Pro"
            "ReleaseId" = "2104"---------------------------------------> everytime Microsoft make great update change this
            "SoftwareType" = "System"
            "UBR" = dword : 3e8
            (as hexadecimal value at time 1000)-----------------------> cumulative update (Fixes, improvements) increment this, 
            -----------------------------------------------------------> NOTE: Microsoft skip the Revision by 19h2 Sep 2019
            -----------------------------------------------------------> First skip was Revision 10000 by Sep 2019 Update.
            -----------------------------------------------------------> Skip show in Taskbar/desktop rights side
            -----------------------------------------------------------> Build 18632.19h1-release_svc_19h2_rel.190621-1123
            -----------------------------------------------------------> UBR means the Windows 10 Operation-System-Revisionnumber
            -----------------------------------------------------------> actual Revision is  - OS-Build 18632.
            -----------------------------------------------------------> Microsot make increments by revision at updates.
            "PathName" = "C:\\WINDOWS"
            "ProductId" = "00330-71230-97984-AAOEM"

            If you develop for other Operation Systems, make query if Operation System supports Registry !
            Linux, macOS does't support registry functions.

         */



    } // END_OF_CLASS::VGFRegistry
} // END_OF_NAMESPACE::Visual.Galaxy.Framework.Registry
