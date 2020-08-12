﻿//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
// Project	    : Visual.Galaxy.Framework
//
//-----------------------------------------------------------------------------
// Programmer	: Christian "Tipplin" Kurs - 
//				: Visual .NET C# / C++ Developer
//              : Project-Founder and Maintainer
//-----------------------------------------------------------------------------
// Part         : VGF.Utility
//              :
//-----------------------------------------------------------------------------
// Use with permission from Microsoft Corporation
// Use of copyrighted content by Microsoft
// For more Information see by Microsoft.
//-----------------------------------------------------------------------------
// Copyrights © 2020 by Christian "TIPPO" Kurs
// Portions of Copyrights © 2020 by Microsoft Corporation 
//-----------------------------------------------------------------------------
// Main-Author: Christian 'Tipplin' Kurs
//-----------------------------------------------------------------------------
// Disclaimer:
//-----------------------------------------------------------------------------
//
//-----------------------------------------------------------------------------
// English
//-----------------------------------------------------------------------------
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions: 
// 
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software. 
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.
//-----------------------------------------------------------------------------
// Deutsch:
//-----------------------------------------------------------------------------
// Der Erlaubnis wird hiermit jedermann kostenlos eine Erlaubnis erteilt
// dieser Software und der dazugehörigen Dokumentationsdateien (die "Software") 
// um zu handeln in der Software ohne Einschränkung, einschließlich der Rechte
// zu verwenden, kopieren, modifizieren, zusammenführen, veröffentlichen, 
// verteilen, unterlizenzieren und / oder verkaufen
// Kopien der Software und um Personen zu erlauben, zu denen die Software 
// gehört dafür eingerichtet, unter den folgenden Bedingungen:
//
// Der obige Copyright-Hinweis und dieser Berechtigungshinweis sind in 
// enthalten alle Kopien oder wesentliche Teile der Software.
//
// DIE SOFTWARE WIRD "WIE BESEHEN" OHNE JEGLICHE GEWÄHRLEISTUNG, 
// AUSDRÜCKLICH ODER IMPLIED, EINSCHLIESSLICH, ABER NICHT BESCHRÄNKT 
// AUF DIE GARANTIE DER MARKTGÄNGIGKEIT,
// EIGNUNG FÜR EINEN BESTIMMTEN ZWECK UND NICHTVERLETZUNG
// AUTOREN ODER COPYRIGHT-INHABER HAFTEN FÜR ANSPRÜCHE, SCHÄDEN ODER ANDERE
// HAFTUNG, BEI EINER VERTRAGSMASSNAHME, VERSPÄRUNG ODER ANDERER WEIT
// NICHT ODER IN VERBINDUNG MIT DER SOFTWARE ODER DER VERWENDUNG ODER 
// ANDERER ABKOMMEN IN DIE SOFTWARE.
//-----------------------------------------------------------------------------
// French
//-----------------------------------------------------------------------------
// La permission est donnée gratuitement à toute personne, une copie
// de ce logiciel et des fichiers de documentation associés (le "Logiciel"), 
// pour traiter dans le logiciel sans restriction, y compris, sans limitation, 
// les droits utiliser, copier, modifier, fusionner, publier, distribuer, 
// concéder en sous-licence et / ou vendre copies du logiciel, 
// et pour permettre aux personnes à qui le logiciel est destiné
// fourni à cet effet, sous réserve des conditions suivantes:
//
// L'avis de copyright ci-dessus et cet avis de permission sont inclus dans
// toutes les copies ou parties substantielles du logiciel.
//
// LE LOGICIEL EST FOURNI "TEL QUEL", SANS GARANTIE D'AUCUNE SORTE, EXPRESSE OU
// IMPLICITE, Y COMPRIS, MAIS SANS S'Y LIMITER, 
// LES GARANTIES DE QUALITÉ MARCHANDE,
// APTITUDE À UN USAGE PARTICULIER ET À L’ABSENCE DE VIOLATION. EN AUCUN CAS, 
// LE LES AUTEURS OU LES TITULAIRES DE COPYRIGHT 
// SONT RESPONSABLES DE TOUTE RÉCLAMATION, DE DOMMAGES OU D'AUTRES
// RESPONSABILITÉ, QU'IL SOIT DANS UN ACTION DE CONTRAT, DE DÉLIT OU AUTREMENT, 
// RÉSULTANT DE, HORS OU EN LIEN AVEC LE LOGICIEL OU L'UTILISATION OU D'AUTRES 
// TRANSACTIONS DANS LE LOGICIEL.
//-----------------------------------------------------------------------------
// Italian
//-----------------------------------------------------------------------------
// L'autorizzazione è concessa, a titolo gratuito, a chiunque ne faccia una copia
// di questo software e dei relativi file di documentazione (il "Software"), da trattare
// nel Software senza restrizioni, inclusi senza limitazioni i diritti
// utilizzare, copiare, modificare, unire, pubblicare, distribuire, 
// sublicenziare e / o vendere
// copie del Software e per consentire a chi è il Software
// fornito di farlo, alle seguenti condizioni:
//
// La suddetta nota sul copyright e questo avviso di autorizzazione sono inclusi in
// tutte le copie o parti sostanziali del software.
//
// IL SOFTWARE VIENE FORNITO "COSÌ COM'È", SENZA GARANZIA DI ALCUN TIPO, ESPRESSA O
// IMPLICITE, INCLUSE, A TITOLO ESEMPLIFICATIVO, LE GARANZIE DI COMMERCIABILITÀ,
// IDONEITÀ PER UN PARTICOLARE SCOPO E NON VIOLAZIONE. IN NESSUN CASO IL
// AUTORI O DETENTORI DEL COPYRIGHT SARANNO RITENUTI RESPONSABILI PER 
// QUALSIASI RECLAMO, DANNO O ALTRO RESPONSABILITÀ, 
// SIA IN UN ATTO DI CONTRATTO, IN FATTO O ALTRIMENTI, DERIVANTE DA,
// FUORI O IN COLLEGAMENTO CON IL SOFTWARE O L'USO O ALTRE DISPOSIZIONI IN
// IL SOFTWARE.
//-----------------------------------------------------------------------------
// Spanish
//-----------------------------------------------------------------------------
// Por la presente se otorga permiso, sin cargo, a cualquier persona una copia
// de este software y los archivos de documentación relacionados 
// (el "Software"), para tratar en el Software sin restricción, 
// incluyendo sin limitación los derechos para usar, copiar, modificar, 
// fusionar, publicar, distribuir, sublicenciar y / o vender
// copias del Software, y para permitir a las personas a quienes el Software 
// está dispuesto a hacerlo, sujeto a las siguientes condiciones:
//
// El aviso de copyright anterior y este aviso de permiso se incluirán en
// todas las copias o partes sustanciales del Software.
//
// EL SOFTWARE SE PROPORCIONA "TAL CUAL", 
// SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O
// IMPLÍCITA, INCLUYENDO PERO NO LIMITADO A LAS GARANTÍAS DE COMERCIABILIDAD,
// APTITUD PARA UN PROPÓSITO PARTICULAR Y NO INCUMPLIMIENTO. EN NINGÚN CASO, 
// EL LOS AUTORES O LOS TITULARES DEL DERECHO DE AUTOR SERÁN RESPONSABLES POR 
// CUALQUIER RECLAMACIÓN, DAÑOS U OTROS
// RESPONSABILIDAD, YA SEA EN UNA ACCIÓN DE CONTRATO, TORTUNA O DE OTRA MANERA, 
// DERIVADA DE, FUERA DE O EN CONEXIÓN CON EL SOFTWARE O EL USO 
// O OTRAS REPARACIONES EN EL SOFTWARE.
//-----------------------------------------------------------------------------

// ============================================================================
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
// © 1982 - 2020 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Set here Directives and namespaces (Project)
// Compiler 'Under the Hood', means he runs at coding, codeline for codeline,
// is precompile for a better and faster backend compile!.
// make sign on left site as yellow lamp! - in codeline scan, syntax/semantic
// blend out unused directives can be removed!
// stand at build running, he delete them, all space lines, unused variables,
// and comments...
//-----------------------------------------------------------------------------

/*
 * Guilty implemented System Assemblies
 * 
 */
using System;
using static System.Console;
using System.IO;
using System.IO.Log;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Reflection;
using System.DirectoryServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

//-----------------------------------------------------------------------------
// In this Project-Solution you use in all other namespaces and .cs files 
// from other Visual C# name.cs Files:
//
// Classes and Methods are static written set this:
// here bind in Visual.Operation.System.dll, inside Attribute
// [InternalsInvisibleAttribute("Visual.Galaxy.Framework"), AllInternals = true]
// All internals written are visible in Project 'Visual Galaxy Framework'
//-----------------------------------------------------------------------------

// Internal.InternalUtilities
using Visual.Operation.System.Internal.InternalUtilities;


// static Class NativeMethods for Constants, Enumerator, Struct's, variables...
using static Visual.Operation.System.Native.NativeMethods;

// All Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// Constants for MessageBox, StartUp
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

using static Visual.Operation.System.Internal.InternalOSMethods;


// Visual.Function.Library.dll - our Functions for use written in C/C++.


// All C/C++ Runtime Library Functions for use.
using static Visual.Operation.System.Native.NativeRuntimeMethods;

// Class VGFCore is the Base, with instances, constants, enum, structs and more
// little help methods - VGFIsPrintOperator...
// most you can sets this in the Class-Head.
using static Visual.Galaxy.Framework.Core.VGFCore;
using static Visual.Galaxy.Framework.Core.VGFCoreUrls;


//-----------------------------------------------------------------------------
//
// 
//
//
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Utility
{
    /// <summary>
    /// VGFCoreUtiliy 
    /// Utilities Methods:
    /// Languages (primary language-secondary language-sorted),
    /// call Website directly with Process.Start
    /// use LockWorkstation for lock with keyboard hit (taste = F12 later)
    /// use _cexit to terminate caller (.dll) - NOT .exe !!!.
    /// use VGFCheckDirectoryIsExists check is Directory current created.
    ///
    ///
    ///
    ///
    /// </summary>
    internal static class VGFCoreUtiliy
    {

        /// <summary>
        /// Global Struct instance for all Methods for use!
        /// without new operator so is on STACK not on Heap.
        /// access with instancevariable mse.
        /// NOTE! some Objects with in Constructors parameters!
        /// then must set with new operator.
        /// </summary>
        internal static MEMORYSTATUSEX mse;

        
        /// <summary>
        /// Make Langauage ID
        /// </summary>
        /// <param name="primarylanguage"></param>
        /// <param name="sublanguage"></param>
        /// <returns></returns>
        public static int VGFMAKELANGID(int primarylanguage, int sublanguage)
        {
            return ((sublanguage << 10) | primarylanguage);
        }
        
        /// <summary>
        /// Make Primary Language ID
        /// </summary>
        /// <param name="lgid"></param>
        /// <returns></returns>
        public static int VGFPRIMARYLANGID(int lgid)
        {
            return (lgid & 0x3ff);
        }

        /// <summary>
        /// Make Sub Language ID
        /// </summary>
        /// <param name="lgid"></param>
        /// <returns></returns>
        public static int VGFSUBLANGID(int lgid)
        {
            return (lgid >> 10);
        }

        /// <summary>
        /// Make Long
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static int VGFMAKELONG(int low, int high)
        {
            return (high << 16) | (low & 0xffff);
        }

        /// <summary>
        /// Make
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static IntPtr VGFMAKELPARAM(int low, int high)
        {
            return (IntPtr)((high << 16) & 0xffff);
        }

        /// <summary>
        /// Make HIWORD
        /// </summary>
        /// <!-- Author Tippo -->
        /// 
        /// <!-- Author Tippo -->
        /// <param name="n"></param>
        /// <returns></returns>
        public static int VGFHIWORD(int n)
        {
            return (n >> 16) & 0xffff;
        }
       
        /// <summary>
        /// Make LOWORD
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int VGFLOWORD(int n)
        {
            return n & 0xffff;
        }

        /// <summary>
        /// Make HRESULT
        /// </summary>
        /// <param name="Severe"></param>
        /// <param name="Facility"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
        public static long VGFMAKEHESULT(long Severe, long Facility, long Code)
        {
            return ((Severe) << 31) | (Facility) << 16 | (Code);
        }

        /// <summary>
        /// Make HRESULT from given Error Code
        /// </summary>
        /// <param name="ErrorCode"></param>
        /// <returns></returns>
        public static int VGFMakeHRFromErrorCode(int ErrorCode)
        {
            if ((0xffff0000 & ErrorCode) == 0)
            {
                //
                // our MessageBox from Library: Visual.Function.Library short VFL.dll written in native C/C++,
                // STYLES is an Enumerator for Button, Icon, SetForeground (the Dialog), AppModal or TaskModal or SystemModal written in C#.
                //
                VFLMsgBox("This is an HRESULT !, NOT an ErrorCode", "Exception in VGFMakeHRFromErrorCode", STYLES.OkCancel | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return 0;
            }
            else
            {
                return unchecked( ( (int)0x80070000) | ErrorCode);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static long VGFHResultFromWin32(long error)
        {
            long FACILITY_WIN32 = 7;

            if (error <= 0)
            {
                return error;
            }
            return ((error & 0x0000FFFF) | (FACILITY_WIN32 << 16) | 0x80000000);
        }

        /// <summary>
        /// VGFSucceeded
        /// </summary>
        /// <param name="hr"></param>
        /// <returns></returns>
        public static bool VGFSucceeded(int hr)
        {
            return (hr >= 0);
        }

        /// <summary>
        /// VGFFailed
        /// </summary>
        /// <param name="hr"></param>
        /// <returns></returns>
        public static bool VGFFailed(int hr)
        {
            return (hr < 0);
        }


        ///-----------------------------------------------------------------------
        /// Start Message at Entrypoint of APP
        ///
        ///	[assembly: PreApplicationStartMethod(typeof("") VGFStartUpMessage() )]
        /// main(string[] args)
        /// {
        ///		.....	
        /// }
        /// 
        /// ----------------------------------------------------------------------
        /// Prefined Message in our Visual Function Library - VFL.dll written in C
        /// TextID from 1 to 24. Text as CHAR array.
        ///-----------------------------------------------------------------------
        public static void VGFStartUpMessage()
        {
            // Show MessageBox with predefined MessageText is an Char Array.
            VFLMessageBox(14);

        } //  end of Method::VGFStartUpMessage

        ///
        /// Assembly can write for shared and other Developers for use them, 
        /// this is public.
        /// Assembly can write only for Application, this is private.
        /// use AssemblySharedAttribute true = public/shared
        /// false = private.
        /// Developer can call add reference on Assembly for use, but we dont allowed it,
        /// "You have NO License to use them, you dont use our Assembly - STATUS: private"
        /// "Only reserved for Application !!!. NOT FOR FREE !!!."
        /// [assembly: AssemblySharedAttribute(true, false)]
        public static void VGFComponentPrivateMessage(string AppName)
        {

            // string message in Project as Global string variable
            vgfmessage = "The Application {0} have a private Component.\n" + AppName;
            vgfmessage += "Private Components are Assemblies or Libraries.\n";
            vgfmessage += "The Developer wan't that the Component use for other Projects\n";
            vgfmessage += "Please respect this !.\n";

            // enumerator STYLES intellisense window like VB.NET
            VFLMsgBox(vgfmessage, "Visual.Galaxy.Framework - System-Message -", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

        } // end of Method::VGFComponentPrivateMessage


        /// <summary>
        /// 	Checks whether another instance of the same application is already running.
        /// </summary>
        /// <param name="SwitchToAlreadyRunningProcess">
        /// 	Whether the already running process is flashed and brought to front.
        /// </param>
        /// <returns>
        /// 	Whether another instance of the application is already running.
        /// </returns>
        public static bool VGFCheckApplicationAlreadyRunning(bool SwitchToAlreadyRunningProcess)
        {
            //
            Process[] processes = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);

            //
            // > 1 because if there is already a process running, then 2 instances (with this one) are present
            //
            if (processes.Length > 1)
            {
                if (SwitchToAlreadyRunningProcess)
                {
                    IntPtr WindowHandle = processes[0].Id != Process.GetCurrentProcess().Id ? processes[0].MainWindowHandle : processes[1].MainWindowHandle;

                    if (!IsWindowVisible(WindowHandle))
                    {
                        // ShowWindowAsync
                        ShowWindow(WindowHandle, SHOW_FLAGS.SW_SHOWMAXIMIZED); // maximize window
                    }

                    SwitchToThisWindow(WindowHandle, false);
                }

                return true;
            }

            return false;

        } /// End of Method::VGFCheckApplicationAlreadyRunning









        ///------------------------------------------------------------
        /// VGFAppGetClassName
        /// Get the Classname of a Application.
        /// sample: Microsoft Applications.
        /// MS Word = opus 
        /// MS Edge = spartan
        /// MS Excel = 
        ///------------------------------------------------------------
        public static string VGFAppGetClassName(IntPtr WindowHandle)
        {
            // returned value
            int retVal;

            // Native Windows Operation System Function
            retVal = GetClassName(WindowHandle, sbr, sbr.Capacity);

            //
            // return Classname for given WindowHandle, convert to string!
            // StringBuilder is Object!
            // Alternate: string.Format("{0}", sbr);
            return sbr.ToString();


        } // End of Method::VGFAppGetClassName

        ///------------------------------------------------------------
        /// Lock your Workstation, 
        /// (Windows 10 Professional is an Workstation)
        /// push only 
        /// unlock with NEW LogIn Dialog
        ///------------------------------------------------------------
        public static bool VGFLockWorkstation()
        {
            try
            {
                // kbhit() - keyboard hit - any taste you push
                if (NRMKeyboardHit() )
                {
                        // WINAPI32 native method - Lock the Workstation - Unlock via Screen LogOn
                        // Windows 10 Professional is Workstation, Multi User System ! one or more User on one Computer.
                        LockWorkstation();
                }
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFLockWorkstation", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;

        } /// End of Method::VGFLockWorkstation

        ///------------------------------------------------------------
        /// Lock your Workstation, here version for key's 
        /// s/S = Secret, Lock, u/U = unsecret, show LogIn Dialog
        /// Another is per click on Taskbar, icon secret.
        ///------------------------------------------------------------
        public static bool VGFCheckForSecretKeyStroke()
        {
            try
            {
                // kbhit() - keyboard hit - getchar = 27 escape taste
                // if( VGFCoreNativeMethods.kbhit() == getchar(27))
                if (NRMKeyboardHit() )
                {
                    char KeyStroke = (char)NRMGetChar();

                    switch(KeyStroke)
                    {
                        // without break goes downup in next case
                        case 'h':
                        case 'H':
                            VFLMsgBox("Switch h/H not implemented!", "VGFCheckForSecretKeyStroke - HELP", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                            break;
                        case 's':
                        case 'S':
                            LockWorkstation();
                            break;
                        case 'u':
                        case 'U':
                            VFLMsgBox("Switch h/H not implemented!", "VGFCheckForSecretKeyStroke - HELP", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFCheckForSecretKeyStroke", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;

        } /// End of Method::VGFLockWorkstation


        ///--------------------------------------------------------
        /// VGFExitDllApplication
        /// You can exit the Dynamic Link Library from Memory Space
        /// with cexit from Visual C++ Runtime Library !
        /// But NOT the .exe = app
        /// Take, you can see in Task Manager.
        ///--------------------------------------------------------
        public static bool VGFExitDllApplication(string strAppName)
        {

            try
            {
                string msg;

                msg = string.Format("The Application must be terminated, found not DllComponent.\n");

                VFLMsgBox(msg, strAppName, STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

                // C/C++ Runtime Function with Enumerator EXIT_CODES - ALL!
                NRMExit(EXIT_CODES.ERROR_DLL_NOT_FOUND);

            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFExitDllApplication", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            return true;

        } // end of Method::VGFExitDllApplication

        /// <summary>
        /// Check Directory is Exists or Create it.
        /// </summary>
        /// <param name="DirectoryName"></param>
        /// <returns></returns>
        public static bool VGFCheckDirectoryIsExistsOrCreate(string DirectoryName)
        {

            // Specify the directories you want to manipulate.
            var di = new DirectoryInfo(DirectoryName);

            // Check is Directory exists ? if false, then create new with DirectoryName !.
            if (di.Exists)
            {
                return true;
            }
            else
            {
                // Try to create the directory.
                di.Create();
                return true;
            }

        } // end of Method::VGFCheckDirectoryFile



        // UNDONE: returned values
        public static bool VGFFindWindow(string WindowCaption)
        {
            IntPtr handle = FindWindow(null, WindowCaption);


            // DON'T FORGET THIS !, close Handles everytime !, open handles can blocked the next access on Method Handle and System.
            // Set in single codeline or on try/catch/finally block, in finally, finally is ultimate resource free, Exception or NOT!
            // or make label mark:
            // goto is now IN! Source: Microsoft Developer by Projects and Windows Operation System as cleanup mark.
            // goto cleanup;
            // cleanup:
            // CloseHandle(handle);
            CloseHandle(handle);

            return true;
        }





        /// <summary>
        /// Check is Debugger present on System
        /// </summary>
        /// <!-- Author Tipplin -->
        /// means the local debugger on system,
        /// other is the (install!) remote debugger system on customer system,
        /// have access, for see who is the Error occured,
        /// make remote update.
        /// or
        /// install app and start the PSR on Customer System,
        /// so many Information about User Action and App,
        /// PSR make an special HTML File is Microsoft HTML - .mht,
        /// pack in to .zip file and send to Author.
        /// PSR.exe is an Windows Systemtool = Problem Step Recorder.
        /// All user actions, Keyboard, Mouse moves...
        /// <!-- Author Tipplin -->
        /// <returns></returns>
        public static bool VGFCheckIsDebuggerPresent()
        {
            

            if (IsDebuggerPresent() )
            {
                return true;
            }
            else
            {
                return false;
            }
        } /// End of Method::VGFCheckIsDebuggerPresent


        ///
        /// Get the Computername
        ///	
        public static string VGFGetComputerNameDNSHostname()
        {
            // StringBuilder means the Expanded Version
            // StringBuilder(min int32, max int32)
            // At Newer Operation Systems Names can
            // longer as 255 Characters. (NETWORK)
            // So all other cut here the Name.
            // But StringBuilder here expand to maximal x Character.
            // automatic with sb.capacity();
            var sb = new StringBuilder(255, 1024);

            // set the buffer to higest value with capacity from StringBuilder.
            // second method is GetComputerNameEx - Network - DnsDomain
            // Windows 10 with extension GetComputerNameEx2.
            // Windows 10 (Professional) with more Network functionality.
            int ccBuff = sb.Capacity;

            // Get the Name of the ComputerNameEx2 with Enumerator
            GetComputerNameEx2(COMPUTER_NAME_FORMAT.ComputerNameDnsHostname, sb, sb.Capacity);

            // StringBuilder is object, so we must convert to string.
            return (sb.ToString());

        } // End of Method::VGFGetComputerName


        /// <summary>
        /// Get Username extend, Domainname
        /// </summary>
        /// <returns></returns>
        public static string VGFGetUserName()
        {
            // StringBuilder is faster as string, and have automatic expand!
            // if string greather as 16 chars is standard in StringBuilder();
            // higest is integer value - int32
            var sb = new StringBuilder(255, 1024);

            GetUserNameEx(EXTENDED_NAME_FORMAT.NameDnsDomain, sb, sb.Capacity);

            // must be convert to string, while StringBuilder is Object.
            return sb.ToString();

        } // end of Method::VGFGetUserName

        //"%s - eine Instanz läuft schon !\n", lpWindowTitleName);
        //"SCP - Systemmeldung: %s", lpWindowTitleName);
        //

        /// <summary>
        /// Check App Instance is running
        /// </summary>
        /// <param name="WindowHandle"></param>
        /// <param name="WindowTitleName"></param>
        /// <returns></returns>
        public static bool VGFCheckIsInstanceRun(IntPtr WindowHandle, string WindowTitleName)
        {

            if (FindWindow(null, WindowTitleName) == IntPtr.Zero)
            {
                // Set current Window (WindowTileName) in the Foreground
                // so the Instance is running.
                SetForegroundWindow(WindowHandle);
                return true;
            }
            else
            {
                // The giving Window (WindowTitelName) instance isn't running !.
                return false;
            }

        } /// End of Method::VGFCheckIsInstanceRun

        ///-----------------------------------------------------------------
        /// UNDONE: 
        /// shutdown flags and reason flag
        /// At Windows new access rights and privileges.
        /// The User must have Shutdown Privilege (many more)
        /// failed LookupAccountPrivilege and struct's
        ///-----------------------------------------------------------------
        /// Shutdown your System with Shutdown Flag and Reason Flag
        /// second parameter is for Reasons, can combine with | operator.
        /// Reasons: 
        /// Hardware reasons, software reasons......
        ///
        /// reasons practiable for Applications, means Fixes, 
        /// planned updates, upgrade, install, reconfig,
        ///
        /// avantage: write entry into Windows your App, 
        /// with RegisterApplicationRestart(string AppName);
        /// so windows shutdown, make your work, 
        /// than windows reboot and start your app automatic.
        ///
        /// Bugfix			- Bug in Application
        /// Securityfix		- Security Leak in Application
        /// Hotfix			- Fix the App, after Operation System Fix.
        ///					- pass on !
        ///
        /// unchecked:
        /// Windows 10 NOT allowed when app and component in use a update or so...
        /// Windows 10 have a Anti Virus scanner and Malware Protection Engine,
        /// scan every app.... - Defender ! ATTENTION about Modulversion !
        ///
        /// Please get the newest !!!.
        /// Online:
        /// often make Microsoft automatic update, outer Patchcycle Time.
        ///
        /// Systemtool: scan system, inconti. problems?
        /// 
        ///
        ///
        /// This Reasons are from Microsoft:
        ///
        ///
        ///-----------------------------------------------------------------
        public static bool VGFShutdownSystemWithFlag(uint Flag, uint Reason)
        {

            switch (Flag)
            {
                case 0:
                    ExitWindowsEx(EWX_SHUTDOWN_FLAGS.EWX_SHUTDOWN, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION);
                    break;
                case 1:
                    ExitWindowsEx(EWX_SHUTDOWN_FLAGS.EWX_LOGOFF, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION);
                    break;
                case 2:
                    ExitWindowsEx(EWX_SHUTDOWN_FLAGS.EWX_HYBRID_SHUTDOWN, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION);
                    break;
                case 3:
                    // Shutdown the System for install upgrade and reboot the System.
                    ExitWindowsEx(EWX_SHUTDOWN_FLAGS.EWX_REBOOT, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_CODES.SHTDN_REASON_MINOR_UPGRADE);
                    break;
                case 4:
                    ExitWindowsEx(EWX_SHUTDOWN_FLAGS.EWX_POWEROFF, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION);
                    break;
                default:
                    break;

            }

            return true;

        } // end of Method::VGFShutdownSystemWithFlag

        /// <summary>
        /// Set Suspend State
        /// </summary>
        /// <param name="state"></param>
        /// <param name="force"></param>
        /// <param name="disableWakeEvent"></param>
        /// <returns></returns>
        public static bool VGFSetSuspendState(PowerState state, bool force, bool disableWakeEvent)
        {

                //===========================================================================================
                // ab Windows 10 geht das System in suspenstate, es beendet alle Prozesse und Anwendungen,
                // in einen sogenannten SLEEP-MODUS, aus diesen Sleep-Modus fährt das Systen schneller und
                // automatisch hoch.
                //
                //
                //============================================================================================
                // state: 
                // System.Windows.Forms.PowerState
                // Ein PowerState, der den Energieaktivitätsmodus angibt, in den das System wechseln soll.
                //-------------------------------------------------------------------------------------------
                // force: bool
                // true , um den Standbymodus sofort zu erzwingen, false, 
                // damit Windows veranlasst wird, an jede Anwendung eine Unterbrechungsanforderung zu senden.
                //------------------------------------------------------------------------------------------- 
                // disableWakeEvent: bool
                // true , damit bei einem Aktivierungsereignis die 
                // Wiederherstellung eines aktiven Systemenergiezustands
                // deaktiviert wird, false, damit bei einem Aktivierungsereignis
                // die Wiederherstellung eines aktiven Systemenergiezustands aktiviert wird.
                //-------------------------------------------------------------------------------------------
                // Rückgabewert Typ: bool
                // true , wenn das System gerade in den Ruhezustand versetzt wird, andernfalls false.
                //-------------------------------------------------------------------------------------------
                //
                // ==========================================================================================
                // Hinweise
                // ==========================================================================================
                // Wenn eine Anwendung auf eine Unterbrechungsanforderung 
                // nicht innerhalb von 20 Sekunden reagiert,
                // ermittelt Windows, ob die Anwendung nicht reagiert und
                // daher in den Standbymodus versetzt oder beendet werden kann.
                // Wenn eine Anwendung auf eine Unterbrechungsanforderung reagiert,
                // kann es beliebig lange dauern,
                // die Ressourcen zu bereinigen und aktive Prozesse zu beenden.
                //-----------------------------------------------------------------					

                return false;

            } // end of Method::VGFSetSuspendState

            
            /// <summary>
            /// Search File in System
            /// </summary>
            /// <!-- Author TIPPO -->
            /// The fasted System-Function for search a File in System.
            /// <!-- Author TIPPO -->
            /// <param name="Path"></param>
            /// <param name="FileName"></param>
            /// <param name="FileExtension"></param>
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public static bool VGFSearchFile(string Path, string FileName, string FileExtension)
            {

                uint fFunction;

                // Set StringBuilder faster as string
                var sb = new StringBuilder(260);
                
                // One Windows Operation System Function with faster search.
                fFunction = SearchPath(Path,                // fullpath
                                            FileName,       // file
                                            FileExtension,  // suffix - .txt
                                            sb.Capacity,    // maximal capacity of string
                                            sb,             // filebuffer
                                            IntPtr.Zero);   //
                if (fFunction == 0)
                {
                    return false;
                }

                return true;

            } /// End of Method::VGFSearchFile

            ///------------------------------------------------------------
            /// GetVolumeInformation
            /// GetVolumeInformation("c:\\", volname, volname.Capacity, out sernum, out maxlen, out flags, fsname, fsname.Capacity))
            ///
            /// string RootPathName						- Drive (A, B, C, D.....)
            /// StringBuilder VolumeNameBuffer			- VolumeNameBuffer caching the Name of Volume in a Buffer
            /// int VolumeNameSize						- Size of the Volume Name (Drive)
            /// out uint VolumeSerialNumber				- Serial Number of Volume (Drive)
            /// out uint MaximumComponentLength			-
            /// out FileSystemFeature FileSystemFlags	-
            /// StringBuilder FileSystemNameBuffer		- Name of Filesystem of current System
            /// int nFileSystemNameSize					- Size of Filesystemname
            ///
            ///
            ///------------------------------------------------------------
            public static string VGFGetFileSystemNameOnComputer(string DriveName)
            {
                return null;

            } // end of Method::VGFGetFileSystemNameOnComputer


        /// <summary>
        /// Get Volume Serialnumber
        /// </summary>
        /// <param name="DriveLetter"></param>
        /// <returns></returns>
        public static string VGFGetVolumeSerialNumber(string DriveLetter)
        {
            //--------------------------------------------------------
            // Check for valid drive letter argument.
            // 26 Drives on Windows System 
            // A = Diskdrive 3,5 - Diskette small
            // TIP: Diskdrive with USB-Cable, 
            // automatic install in Windows 10
            // B = Diskdrive 5,4 - Diskette great
            // C = Harddrive
            // D = DVD Drive
            // E = USB Stick - Flashstorage is preformatted from Vendor!
            // FormatEx() - format new, FAT32 - limit 32Gbyte
            // exFAT for over 32 Gbyte, 64 GB >
            // F = USB Stick
            // ...
            // Tipplin Tip:
            // have an .iso image, click it, 
            // than create
            // Microsoft Virtual DVD Drive in Windows Explorer,
            // see all files, setup or msi = mcirosoft installer
            // click it, automatic installation begins.
            //--------------------------------------------------------

            return null;

        } // End of Method::VGFGetVolumeSerial

        // Two Methods from Windows Operation System for Network.
        // SetComputerNameExW
        // GetComputerNameEx
        // Domain, NetBIOS, Dns Hostname
        //
        // !!! ATTENTION !!!
        // This Methods have a boolean typ, this type is Windows Boolean !!!
        // Windows Boolean give 1 Byte returned !.
        // Visual C++ 2 Byte and Visual C# 4 byte returned - here hardcoded - true, false
        //
        // ! ATTENTION ! In P/Invoke.NET Website wrong returned Value !.
        // ! Please check generally all Settings and Calls !!!!!!!!.
        //
        // Microsoft Developer Brian Harry Tip: set here byte for returned value !.
        // byte SetComputerNameEx
        // byte GetComputerNameEx
        //
        // Expanded Methods from SetComputerName and GetComputerName.
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool VGFSetComputerPhysDNSHostName(string name)
        {
            /*
            // returned Value for SetComputerNameEx - !!! Internal Windows Boolean - 1 byte - !!!
            // same GetComputerNameEx - 
            // Visual C# NOT -bool-, set -byte- as return value.

            var sb = new StringBuilder(255);


            try
            {
                return SetComputerNameEx(COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsHostname, sb);
                
                
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFExitDllApplication", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            */

            return false;

        } // End of Method::VGFSetComputerPhysDNSHostName

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFGetComputerDNSDomainName()
        {
            
            // StringBuilder expand value, so we have chance, 
            // when the DNSDomainName greather as 255 Chars, NO CUT!
            // StringBuilder(int min, int max) - integer scope!
            // But min=minimal must be smaller as maxmimal!
            // StringBuilder is better as string, 2000 faster.
            // StringBuilderCacheAquire() holded internal.
            var sb = new StringBuilder(255, 1024);

            GetComputerNameEx2(COMPUTER_NAME_FORMAT.ComputerNameDnsDomain, sb, sb.Capacity);

            return sb.ToString();

        } // end of Method::VGFGetComputerDNSDomainName

        /// <summary>
        /// Recycle the Trash, delete all!
        /// </summary>
        /// <param name="WindowHandle"></param>
        /// <param name="DriveLetter"></param>
        /// <returns></returns>
        public static bool VGFRecycleBinDelAll(IntPtr WindowHandle, string DriveLetter)
        {

            // Set Exceptionhandler here for Windows Operation System
            try
            {
                SHEmptyRecycleBin(
                                    WindowHandle,
                                    DriveLetter,
                                    SHERB_TRASH.SHERB_NOCONFIRMATION | SHERB_TRASH.SHERB_NOPROGRESSUI | SHERB_TRASH.SHERB_NOSOUND);
                return true;
            }
            catch (SystemException ex)
            {
               VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }

            // finally so we can free resources here - ultimative free ressource handler (GC)
            // Filestreams - .close();
            // Devices - free the ressources for Devices like scanners (TWAIN Interface) and so....
            // If NOT the Device and Interface can BLOCKED the System !!!!.
            //finally
            //{
            //	
            //}

            return false;

        } // End of Method::VGFRecycleBinDelAll

       
        /// <summary>
        ///  Create Random Number
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Random Generator not from .NET FX, use C/C++ Runtime Lib: Random srand/rand
        /// next use Intel Processor Random Generator.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// -----------------------------------------------------------
        /// Generate a Random Numbers like:
        /// -----------------------------------------------------------
        /// Type: 
        /// ===========================================================
        /// alpha, alphanumeric, numeric with lengths
        ///
        /// srand, rand from Microsoft Visual C++ Runtime Library
        /// all methods declared with .cdecl convention for C#
        /// so you can use them.
        /// Better Visual C++ Runtime Methods as Class Random.
        /// -----------------------------------------------------------
        /// INFO: 
        /// INTEL SKYLAKE have internal Random Generator for use. 
        /// Intel give C++ Header's Files, so you can use all Features.
        /// 
        /// Intel Processor Randomnumbers 
        /// in 16, 32, 64 BIT Numbers returned.
        /// 
        /// This Numbers are everytime NEW.
        /// Intel Processor Cryption - AES and Rijndael for use.
        /// -----------------------------------------------------------
        /// </remarks>
        /// <param name="Type">
        ///		alpha               = 1
        ///		numeric             = 2
        ///		alphanumeric string = 3
        /// </param>
        /// <param name="Length">
        ///		insert your length for random number string
        /// </param>
        /// <returns>
        ///		returned create random string
        /// </returns>
        public static string VGFRandomNumberString(int Type, int Length)
        {

            int iNumber;
            string strValue = null;

            for (uint i = 0; i < Length; i++)
            {



                /*
                    Seed the random-number generator with current time so
                    that the numbers will be different every time we run.
                    srand( (unsigned)time( NULL ) );

                    NOTE: 
                    Statement of TIPPO:
                    Bullshit from Persons: 32BIT Programms (32Bit.exe, .dll) does't run of 64BIT System.
                    The Programms run in isolated Adressroom on 64BIT, the App can abort but NOT the 64bit System !!!.
                    (Most in Bank 1 - Bank 0 is reserved for Operation System)
                    All 32BIT Systemfiles in \syswow64 and all 64BIT Systemfiles in \system32.
                    16BIT Files cant start on Windows 64BIT failed System Files !!!. Only Message. 

                    TIPPO:
                    Get 64BIT Computer and Operation System !!!.
                    The Large System, Arrays over 2 GBytes, Large Objects over GCServer
                    As Standard Installation .NET Framework is GCWorkstation ever.
                    GCServer - NUMA, LargeHeaps, LargeObjects and lot of more.
                    Theoretic 16 Exabyte largest Adressrooms.
                    The ExceptionHandling in 64BIT = is table oriented - every method goes in a table - Headerfile -
                    The ExceptionHandling in 32 BIT = is stack oriented
                    On 64BIT you can write 32BIT .exe and .dll  - (same 64BIT)
                    The System Dll's and Runtimes are in the Directory \WOW64
                    = Windows On Windows on 64BIT System (All 32BIT).
                    The 64BIT System Dll's and Runtimes are in the Directory \System32 !!!!.


                 */


                // Microsoft Developer Urgent Info: (orignal comment)
                // NOW! DON'T USE GetCountTick() !!!
                // the method GetIickCount() have after 49 Days a overflow, DON'T USE IT !!!.
                //
                // The GetTickCount64 have NO Problems.
                //
                // Change at 05.11.2017:
                // Extern Visual C++ Runtime Function srand, rand
                // ! NEW !  Microsoft Name Rules for Functions from them:
                // ! NEW ! Visual Studio and the programming-language Compiler runs different
                // If you insert code, the Studio goes in background, only Compiler works !
                // .net-slang: 'compiler under the hood', he checks the written code line, and pre-compiled
                // if NO errors! - checked Visual C++ and Visual C# Compiler -
                // the new Compilers check your syntax, keyword... if error!, he show a dialog window
                // with correction or he can search online for a better code.
                // 
                // The First Letter must be lower, old VGFCoreOperationSystem.srand
                // now:
                // VGFCoreOperationSystem.Srand
                // In DllImportAttribute the old can be stand, but in Call in new name rule.
                //
                //see !NEW! GetTickCount64(), better as GetTickCount64 !, after 49 days he overflow!
                //----------------------------------------------------------------------------------
                NRMSrand((int)(i + 1) * Length * (int)GetTickCount64());

                

                // set switch for random number you want create !	
                switch (Type)
                {
                    // Type only alpha numbers - abcgh - Length = 5
                    case 1:
                        iNumber = NRMRand() % 122;
                        if (48 > iNumber)
                        {
                            iNumber += 48;
                        }
                        if (57 < iNumber && 65 > iNumber)
                        {
                            iNumber += 7;
                        }
                        if (90 < iNumber && 97 > iNumber)
                        {
                            iNumber += 6;
                        }
                        strValue = string.Format("{0}", iNumber);
                        break;
                    // Type alphanumeric - sample: a2n9m - Length = 5
                    case 2:
                        iNumber = NRMRand() % 122;
                        if (65 > iNumber)
                        {
                            iNumber = 65 + iNumber % 56;
                        }
                        if (90 < iNumber && 97 > iNumber)
                        {
                            iNumber += 6;
                        }
                        strValue = string.Format("{0}", iNumber);
                        break;
                    // Type numeric - sample: 12457 - Length = 5
                    case 3:
                        strValue = string.Format("{0}", NRMRand() % 9);
                        break;
                    default:
                        strValue = string.Format("{0}", NRMRand());
                        break;

                } // End of switch

            }  // End of for loop

            return strValue;

        } // end of Method::VGFRandomNumberString (same as IL-Code)

        /// <summary>
        /// Create Cycle Redundancy Check 32BIT
        /// DON'T USE at current Windows Operation System,
        /// in new Windows 10 SDK OS-Build 18282 and new 18298
        /// NTCreateCRC32 - System - Function
        /// NTCreateCRC64 - System - Function
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Cycle Redundancy Check 32BIT Value
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Windows 10 SDK 18272 winuser.h new functions
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static int VGFCreateCRC32()
        {
            return 1;
        }

        /// <summary>
        /// Create Cycle Redundancy Check 64BIT
        /// DON'T USE at current Windows Operation System,
        /// in new Windows 10 OS-Build 18362 and new 18922
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Cycle Redudancy Check 64BIT Value
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Windows 10 SDK 18282 
        /// C++ headerfile: winuser.h new functions
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static int VGFCreateCRC64()
        {
            return 1;
        }




        // VGFInitialSystemShutdown - Windows Shutdown Dialog with x seconds too shutdown the System
        // antipart is InitialAbortSystemShutdown method, to abort the shutdown.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MachineName"></param>
        /// <param name="MessageText"></param>
        /// <param name="TimeOut"></param>
        /// <param name="ForceShutdown"></param>
        /// <param name="RebootAfterShutdown"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static long VGFInitialSystemShutdown(string MachineName, string MessageText, uint TimeOut, bool ForceShutdown, bool RebootAfterShutdown, SHTDN_REASON_CODES dr)
        {

            bool bResult = false;

            /*
                string lpMachineName,		- machine name - current local null or empty
                string lpMessage,			- message text
                uint dwTimeout,				- System dialog 30 seconds - 30000 milliseconds
                bool bForceAppsClosed,		- force the shutdown close all app's and processes
                true - yes do it.
                bool bRebootAfterShutdown,	- after shutdown reboot the system
                true - yes do it.
                ------------------------
                ISShutdownFlags dr:
                ------------------------
                REASON_SWINSTALL    = 0, - Software install
                REASON_HWINSTALL    = 1, - Hardware install
                REASON_SERVICEHANG  = 2, - Windows service or service hang - stopp -
                REASON_UNSTABLE     = 3, - System is unstable !!! must shutdown !
                REASON_SWHWRECONF   = 4, - Software/Hardware reconfiguration
                REASON_OTHER        = 5, -
                REASON_UNKNOWN      = 255, - nothing
                REASON_PLANNED_FLAG = 0x80000000 - planning next update, upgrade, new version on web server

            */

            // Exceptionhandling ON
            try
            {
                bResult = InitiateSystemShutdownEx(MachineName, MessageText, TimeOut, ForceShutdown, RebootAfterShutdown, SHTDN_REASON_CODES.SHTDN_REASON_MAJOR_APPLICATION | SHTDN_REASON_CODES.SHTDN_REASON_MINOR_INSTALLATION);
                if (bResult == true)
                {
                    return 0;
                }
            }
            catch (SystemException ex) 
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return ex.HResult;
            }

            return 0;

        } // end of Method::VGFInitialSystemShutdown

        
        /// <summary>
        /// Search File in System
        /// </summary>
        /// <!-- Author TIPPO -->
        /// 
        /// <!-- Author TIPPO -->
        /// <param name="FileName"> Set Filename for search</param>
        /// <remarks>
        /// System Function: SearchFile is the fasted Search.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFSearchFile(string FileName)
        {
            uint returnedValue;

            // Set StringBuilder faster as string
            var sb = new StringBuilder(260);

            
            if(FileName.Length > 259)
            {
                vgfmessage = "The File and Pathname is to long ! max 260 chars.\n";
                vgfmessage += "but -1 for save, not he occured an Exception !.\n";

                VFLMsgBox(vgfmessage, "Exception at Method::VGFSearchFile", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

            returnedValue = SearchPath(null,
                                       FileName,
                                       null,
                                       sb.Capacity,
                                       sb,
                                       IntPtr.Zero);

            return true;

        } // end of Method::VGFSearchFile

        /// <summary>
        /// 
        /// </summary>
        public static void VGFGetMessageAboutMemoryPermanent()
        {

            string msg;

            GlobalMemoryStatusEx(ref mse);

            msg = mse.availPhys.ToString();

            VFLMsgBox(msg, "Show Total Physical Memmory Permanent", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

        } // end of Method::VGFGetMessageAboutMemoryPermanent

        /// <summary>
        /// Get Total Physical Memory
        /// </summary>
        public static void VGFGetMessageAboutTotalMemory()
        {

            string msg;

            GlobalMemoryStatusEx(ref mse);

            msg = mse.totalPhys.ToString();

            VFLMsgBox(msg, "Show Total Physical Memmory Permanent", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

        } // end of Method::VGFGetMessageAboutTotalMemory

        ///
        /// Code: Zeilenweises Lesen einer Textdatei (Visual C#)
        /// In diesem Beispiel wird der Inhalt einer Textdatei mit Hilfe der 
        /// ReadLine-Methode der StreamReader-Klasse zeilenweise in eine Zeichenfolge eingelesen.
        /// Jede Textzeile wird in der line-Zeichenfolge gespeichert und auf dem Bildschirm angezeigt.
        ///
        public static int VGFConsoleReadFiletext(string FullPathFileName)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            var file = new StreamReader(FullPathFileName);

            while ((line = file.ReadLine()) != null)
            {
                WriteLine(line);
                counter++;
            }

            file.Close();

            // Suspend the screen.
            ReadLine();

            return 0;

        } /// End of Method::VGFConsoleReadFiletext

        ///
        /// Compute different days
        ///
        public static int VGFComputeDiffDays(int year, int month, int day)
        {
            DateTime oldDate = new DateTime(year, month, day);
            DateTime newDate = DateTime.Now;

            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;
            // Difference in days.
            int differenceInDays = ts.Days;

            return differenceInDays;

        } /// End of Method::VGFComputeDiffDays			

        ///------------------------------------------------------------
        /// Standard Windows Dialogs
        /// OpenFileDialog and SaveFileDialog
        ///------------------------------------------------------------
        public static int VGFShowOpenFileDialog(string directory)
        {
            Stream myStream;
            var openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = directory;

            // Set here our new suffixes, the suffix .xxx, .xxxx is over, you can set your own suffix longer.
            // filename.appconfig save with all and UTF8. appconfig is the application configuration file.
            // Visual Studio automatic create appconfig, webconfig, userconfig, machineconfig.
            // appname.exe.config
            // all are XML Files - add, delete, change entries with class configurationmanager from. .NET
            // Feature: sqlconfig - all database entries, server, users, connections, sql queries
            // Microsoft SQL Server inside .NET - Install deactive, must be actived with procedure call
            // .NET: Visual C# SQL any Templates: ..Create SQL database
            // Microsoft SQL Development Studio - German Thesaurus, German Dictionries, String List.
            // German Thesaurus at install null, can fill it.
            openFileDialog1.Filter = "appconfig files (*.appconfig)|*.appconfig|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    // Insert code to read the stream here.
                    myStream.Close();
                }
            }

            return 0;

        } // END_OF_METHOD::VGFShowOpenFileDialog

        

        

        /* Everytime the current Time at Day with Atom Clock
        * On the World, give ca. 250 Atom Clocks.
        * For Germany by PTB Braunschweig with three network adresses.
        * so you can synchronize your Time.
        */
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool VGFGetCurrentTimeATOM()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "microsoft-edge:http://ptbtime1.ptb.de"
            };

            process = Process.Start(startInfo);

            if (!process.WaitForExit(7000))
            {
                // kill the process
                process.Kill();
                return true;
            }

            return true;
        }

        /// <summary>
        /// Show the German PTB Atom Currectness Clock,
        /// with option Speech output for hours and seconds
        /// </summary>
        /// <!-- Author Tipplin -->
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        ///  so here Microsoft Webbrowser Edge , GitHub not supported Internet Explorer.
        ///  Area Internet Explorer goes to end.
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFShowPTBClock()
        {
            try
            {

                // SleepEx from Windows with Operator Asterics, 
                // so you call after the milliseconds and Method or MessageBox
                // Operator asterics is an: uint uint.operator*(uint left, uint right)
                SleepEx(2000 * VFLMsgBox("Have Fun !", "PTB Clock", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal), false);
                //
                // Start Process with the Microsoft-Edge Webbrowser and Website
                // NEW Microsoft Edge Webbrowser is an seperate App in \dir C:\Program Files (x86)\Microsoft\Edge\msedge.exe
                // directly call
                Process.Start("microsoft-edge:https://uhr.ptb.de/");
                
                // new option return bool as string here true as string, must be change in Method-declaration bool to string.
                return bool.TrueString;
            }
            catch (SystemException ex)when(ex is FileNotFoundException | ex is Win32Exception)
            {
                // MessaggeBox standard and new intellsense windows with enumerator STYLES
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // new option return bool as string here false as string, must be change in Method-declaration bool to string.
                return bool.FalseString;
            }

        }



        /// <summary>
        /// Cancel Shutdown on Computer
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Have use here Process.Start and Shutdown Command Line with switch -a, the cancel the shutdown.
        /// <!-- Author Tipplin -->
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFCancelShutdownOnComputer()
        {
            try
            {
                // same in.NET as CancelShutdown (user32.dll - Win7) from WinAPI.
                //
                // Cancels Shutdown of the Computer
                // Shutdown is an Command Line under console with switches.
                // same Microsoft Application have switches under command line start.
                // Internet Explorer /f without Frame.
                // cmd.exe the command line console, input in search text - cmd and click.
                // Next Windows 10, NEW Windows 10 Terminal with Powershell, Command Line Console and GNU Linux Bash.
                // changes in profile.json via option settings in Windows 10 Terminal.
                Process.Start("Shutdown", "-a");
                return true;

            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::VGFCancelShutdownOnComputer

        /// <summary>
        /// Start directly Microsoft Website with Microsoft Edge
        /// </summary>
        /// <returns></returns>
        public static string VGFStartMicrosoftSite()
        {
            try
            {
                // Start Process with Microsoft Edge Webbrowser
                Process.Start("microsoft-edge:http://www.microsoft.com");
                return bool.TrueString;
            }
            // catch by exception on class Process. 
            catch(SystemException ex)when(ex is FileNotFoundException | ex is Win32Exception)
            {
                // MessaggeBox standard and new intellsense windows with enumerator STYLES
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return bool.FalseString;
            }

        }

        public static string VGFStartDirectlyWebSite(string FullURL)
        {
            try
            {
                Process.Start("microsoft-edge:"+ FullURL);
                return bool.TrueString;
            }
            // catch by exception on class Process. 
            catch (SystemException ex) when (ex is FileNotFoundException | ex is Win32Exception)
            {
                // MessaggeBox standard and new intellsense windows with enumerator STYLES
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return bool.FalseString;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFMainAuthorWebsite()
        {
            try
            {
                // start process with Microsoft Edge and URL by Tipplin Main Author
                Process.Start("microsoft-edge:" + vgfdevTipplinVGFKernelTeam);
                return bool.TrueString;
            }
            // catch by exception on class Process. 
            catch (SystemException ex) when (ex is FileNotFoundException | ex is Win32Exception)
            {
                // MessaggeBox standard and new intellsense windows with enumerator STYLES
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return bool.FalseString;
            }

        }









        /*
        public static decimal VGFGetCurrencyValueFromDAX(CurrencyName currencyname, string CurrencyInfoName, CurrenciesSign currencysign)
        {

            decimal decimalValue;

            //--------------------------------------------------------
            // Take here connection to DAX - directly via Web Address
            // so we have everytime the newest Values for Currencies.
            //--------------------------------------------------------
            // decimalValue = string.format("For {0} you become {1} ", currencyname.dollar, currencysign.euro);
            // return decimalValue;
            // switch(currencyname)
            // {
            //		case "euro":
            //			switch(CurrencyInfoName)
            //			{
            //				case "dollar":
            //				case "pfund":
            //			case "rubel":
            //				case "danmark kronen":
            //				case "norway kronen":
            //				case "forint":
            //			}
            //		case "dollar":
            //		............
            // }
            //
            return 0;
        } // end of Method::VGFGetCurrencyValueFromDAX


         From Sourcecode Visual C++ - MFC - Visual Studio 2017
            inet.cpp - internet functions -

            Pre-startup Code
                                    Class		  Class
            IMPLEMENT_DYNAMIC(CInternetException, CException)

            Java - da vinci machine inside Java Runtime Enviroment
            for all dynamic programming-languages, so we can use them!
            INVOKE_DYNAMIC


            const TCHAR URLftp[] = _T("ftp://");
            const TCHAR URLgopher[] = _T("gopher://");
            const TCHAR URLhttp[] = _T("http://");
            const TCHAR URLhttps[] = _T("https://");

            /// new! one constant line for more as one constant:
            const LPCTSTR CHttpConnection::szHtmlVerbs[] = {
                _T("POST"),
                _T("GET"),
                _T("HEAD"),
                _T("PUT"),
                _T("LINK"),
                _T("DELETE"),
                _T("UNLINK"),
            };




        ASSERT(lpComponents != NULL && pstrURL != NULL);

        if (lpComponents == NULL || pstrURL == NULL)
                return FALSE;
            ASSERT(lpComponents->dwHostNameLength == 0 ||
                    lpComponents->lpszHostName != NULL);
            ASSERT(lpComponents->dwUrlPathLength == 0 ||
                    lpComponents->lpszUrlPath != NULL);
            ASSERT(lpComponents->dwUserNameLength == 0 ||
                    lpComponents->lpszUserName != NULL);
            ASSERT(lpComponents->dwPasswordLength == 0 ||
                    lpComponents->lpszPassword != NULL);

        */

        //------------------------------------------------------------
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        // !!! NullGuardAnalyzer - NEW -- C# 7.1 / 7.2 exists
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //------------------------------------------------------------

        /// <summary>
        /// MethodNullGuardAnalyzer
        /// </summary>
        /// <param name="str"></param>
        /// <param name="obj"></param>
        /// <param name="i"></param>
        public static void MethodNullGuardAnalyzer(string str, object obj, int i)
        {
            // check string is empty or null ?
            if (str == null)
            {
                // or so throw new ArgumentNullException("parameter 'str' must have a value");
                throw new ArgumentNullException(nameof(str));
            }

            // check object is null ?
            else if (obj == null)
            {
                // or so throw new ArgumentNullException("parameter 'obj' must have a value");
                throw new ArgumentNullException(nameof(obj));
            }

            // check integer value is null ?
            else if (i == 0)
            {
                // or so throw new ArgumentNullException("parameter 'i' must have a value");
                throw new ArgumentNullException(nameof(i));
            }

        }

        /*
        ///------------------------------------------------------------
        /// !!! ATTENTION !!! New Idea for Visual C#:
        /// proof the instancevariable to class
        /// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        ///------------------------------------------------------------
        public static bool foo2()
        {
            VGFBase st = new VGFBase();

            
            if (typeof(st) is VGFBase)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        

        ///------------------------------------------------------------
        /// !!! ATTENTION !!! New Idea for Visual C#:
        /// TEST Method for switch, case with {}
        /// Source: OPC UA Project from OPC Foundation.
        ///------------------------------------------------------------
        public static int GetReturnValue(int ID)
        {
            switch (ID)
            {
                case 0:
                case 1:
                    {
                        var st = new VGFCore();
                        return st.Value;
                        break;
                    }
                case 2:
                    {
                        return 0;
                    }
                case 3: /// actived members or not.
                    {
                        Application.Start.Launcher = null;
                        Application.Start.Timeout = 10000;
                    }
            }
        }

        */


        ///------------------------------------------------------------
        /// UNDONE
        ///
        ///
        ///------------------------------------------------------------
        public static string VGFCheckHardwareMachine(string SystemInfoDumpString, string SystemKey, byte MaskBits)
        {
            return null;
        }

        /// <summary>
        /// Get Battery Status Life
        /// </summary>
        /// <returns></returns>
        public static int VGFGetBatteryStatusLife()
        {
            var bsi = new BatteryStatusInfo();
            return bsi.BattLife;
        }



        ///------------------------------------------------------------
        /// UNDONE
        /// Assembly failed ? or want bind later ?
        /// Method, Check Connection, failed ?, 
        /// bind with bAddAssembyToProject = true
        ///------------------------------------------------------------
        public static bool VGFCheckAssemblyConnection(string AssemblyName, bool bAddAssembyToProject)
        {

            try
            {

                // Class Assembler in .NET Framework
                // direct bind assembly and late bind assembly with class lazy
                // compile assembly all members read out. class, method, parameters, who are, 
                //
                // Class Assembly - at new IDE - only set: var as = new Assembly();
                

                return true;
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }


        } // end of Method::VGFCheckAssemblyConnection







    } // End of Class::VGFCoreUtility


} // END OF NAMESPACE::Visual.Galaxy.Framework.Utility

























