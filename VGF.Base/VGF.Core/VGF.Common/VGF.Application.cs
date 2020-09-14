//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Application
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "TIPPO" Kurs - Visual C# Developer
// Portions Copyright © 2020 by Microsoft Corporation GmbH.
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
// Copyright © 2020
// by  Visual Galaxy Framework Community Kernel Developer Team.
// all rights reserved.
// May be redistributed for free,
// but may not be sold without the author's explicit permission
//
// This software is Copyright © 2020 by VGF-Technologies at VGF-KernelTeam
// You may only use this software if you are an authorized licensee
// of an VGF developer tools product.
//
// This software is considered a Redistributable as defined under
// the software license agreement that comes with the VGF Products
// and is subject to that software license agreement.
//
//-----------------------------------------------------------------------------
// NOTE: Microsoft make Restrictions of Export for following Countries:
// ----------------------------------------------------------------------------
// This software is subject to the U.S. Export Administration Regulations and 
// other U.S.law, and may not be exported or re-exported to certain countries
// (Cuba, Iran, North Korea, Sudan, Syria, and the Crimea region of Ukraine) or
// to persons or entities prohibited from receiving U.S.exports
// (including Denied Parties, Specially Designated Nationals,
// and entities on the Bureau of Export Administration Entity List or
//involved with missile technology or nuclear, chemical or biological weapons).
//
// © 1982 - 2020 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// VFGCore
// written by 		
//						Christian "Tipplin" Kurs
//						Ahornweg 1
//				  -G -  53177 Bonn
//						Germany - Allemagne - Duitsland
//-----------------------------------------------------------------------------
// 				voice               :
//					international phone :	
//					Skype               :
//					e-mail              : kurschristian@gmail.com
//                  e-mail              : christian.kurs@gmx.net
//					community Website   :	
//                  own website         :
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
//				under construction
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//				
//
//-----------------------------------------------------------------------------

/*********************** Developer Disclaimer *********************************
 *
 * Copyright © 2020 by Christian 'Tipplin' Kurs - Germany
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
// All System Directories about .NET Framework 4.8
//
//
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

#region static classes in Visual Galaxy Framework for use here:

using static Visual.Galaxy.Framework.NativeWindows.VGFNativeWindowsDLL;

//
using static Visual.Galaxy.Framework.Application.VGFApplication;

// VGFCore - All Global Constants, Variables, Instances
// here public static string message
// NOTE ! Because of ambiguity set vgfmessage - the same message constant as vosmessage in Visual.Operation.System.dll
using static Visual.Galaxy.Framework.Core.VGFCore;

#endregion


#region Directives from other Assembly Visual Operation System here for use:

/*
 * set for native Methods from native Dll's.
 * here Class SafeNativeMethods, means no dangerous and risk for User call.
 * Three Classes like Microsoft Guideline for native Dll's.
 * Class UnsafeNativeMethods with Stackwalk and internal Security check.
 * 
*/
using static Visual.Operation.System.Native.NativeMethods;

// Microsoft C/C++ Runtime Library Functions
using static Visual.Operation.System.Native.NativeRuntimeMethods;

// Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

//
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

#endregion



/******************* END OF OWN DIRECTIVES ---------------------------------


/******************************************************************************
 * Application Services, Application Container, Application Watching
 * Syncron/Asyncron
 * ---------------------------------------------------------------------------
 * App To App Communication
******************************************************************************/
namespace Visual.Galaxy.Framework.Application
{
    

    /// <summary>
    /// Class VGFApplication
    /// </summary>
    /// <!-- Author 🧑TIPPLIN 🧑-->
    /// Class Application with Information, Settings, Security, AccessSystem
    /// <!-- Author 🧑TIPPLIN 🧑-->
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
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// Start your Favorite Application automatic.
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <param name="ApplicationPath">Set Application Path</param>
        /// <param name="RegisterName">Set Register Name</param>
        /// <param name="User">Set User</param>
        /// <returns></returns>
        public static bool VGFAddAutoStartApplication(string ApplicationPath, string RegisterName, bool User)
        {
        
            var root = User ? Microsoft.Win32.Registry.CurrentUser : Microsoft.Win32.Registry.LocalMachine;
        
            // Open the Key with write Access
            using(var key = root.OpenSubKey(VGF_AUTOSTART_REGISTRY_KEY, true))
            {
                if(key == null)
                { 
                    vgfmessage = "Unable to access/create registry key";
                    vgfmessage += "EnviromentException occured !.";

                    //------------------------------------------------------
                    // See OS-MessageBox, but with STYLES enumerator like VB
                    // OS-MessageBox have 3 Parameters, the Third Parameter 
                    // is a Enumerator for one Value must be use 
                    // Operator Vertical Bar |
                    // OS-MessageBox from VFL.dll - pure C Functions.
                    //------------------------------------------------------
                    VFLMsgBox(vgfmessage, "VGFAddAutoStartApplication", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                }

                key.SetValue(RegisterName, ApplicationPath, Microsoft.Win32.RegistryValueKind.ExpandString);
                
                return true;
            } // end of using

        } // end of method::AddAutoStartApplication


        /// <summary>
        /// Remove Application from Autostart
        /// </summary>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        ///
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <param name="RegisterName">most Applicationname</param>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool VGFRemoveAutoStartApplication(string RegisterName, bool User)
        {
            var root = User ? Microsoft.Win32.Registry.CurrentUser : Microsoft.Win32.Registry.LocalMachine;
            // Open the Key with write Access
            using (var key = root.OpenSubKey(VGF_AUTOSTART_REGISTRY_KEY, true))
            {
                if (key == null)
                {
                    vgfmessage = "Unable to access registry key";
                    vgfmessage += "EnviromentException occured !.";

                    VFLMsgBox(vgfmessage, "VGFRemoveAutoStartApplication", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                }

                key.DeleteValue(RegisterName, false);
                
                return true;
            } // end of using

        } // end of method::

        /// <summary>
        /// Get Autostart Application Path
        /// </summary>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        ///
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <param name="RegisterName">Set Registername</param>
        /// <param name="User">Set User - true/false</param>
        /// <returns></returns>
        public static string VGFGetAutoStartApplicationPath(string RegisterName, bool User)
        {

            var root = User ? Microsoft.Win32.Registry.CurrentUser : Microsoft.Win32.Registry.LocalMachine;
            // Open the Key with write Access
            using (var key = root.OpenSubKey(VGF_AUTOSTART_REGISTRY_KEY))
            {
                return key == null ? null: key.GetValue(RegisterName) as string;
                
            } // end of using

        } // end of method::VGFGetAutoStartApplicationPath
        
        /// <summary>
        /// Register App into Windows Operation System for Restart
        /// </summary>
        /// <param name="ApplicationName">Set Application Name</param>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// Windows 10 have a internal table for Applications
        /// <!-- Author 🧑TIPPLIN 🧑-->
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
        /// Get Application Companyname
        /// </summary>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// 
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <returns></returns>
        public static string VGFApplicationCompanyName()
        {
           string AppCompanyName = System.Windows.Forms.Application.CompanyName;

            // return Company Name of Application
            return AppCompanyName;
        }

        /// <summary>
        /// Get Application Productname
        /// </summary>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// Windows 10 have a internal table for Applications
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// <returns></returns>
        public static string VGFApplicationProductName()
        {
            string AppProductName = System.Windows.Forms.Application.ProductName;

            // return Company Name of Application
            return AppProductName;
        }

        /// <summary>
        /// Application Lock by Running Operation
        /// </summary>
        /// <param name="LockApp"></param>
        /// <!-- Author 🧑TIPPLIN 🧑-->
        /// use Class Application for specials
        /// <!-- Author 🧑TIPPLIN 🧑-->
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
                    VFLMsgBox("Sorry, but a Operation is now running, you can quit the Application", "Application Lock", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                    LockApp = System.Windows.Forms.Application.AllowQuit;
                }

            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }

            return LockApp;
        
        } // end of method::VGFApplicationLockRunningOperation








    } // end of class::Application




} // end of namespace::Visual.Galaxy.Framework.Application
