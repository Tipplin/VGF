//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Exception
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
// © 1982 - 2020 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// VFGCore
// written by 		
//					 Christian 'Tipplin' Kurs
//					 Nettweg 1
//				-G - 53498 Bad Breisig
//					 Germany - Allemagne - Duitsland
//-----------------------------------------------------------------------------
// 				voice                   :	02633 - 470736  
//					international phone :	00-49-2633-470736
//					Skype               :
//					e-mail				:	Christian.Kurs@gmail.de
//					community Website	:	http://www.vgfc.org/community/tippo
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
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows;
using System.Timers;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Build.Framework;



// NOTE ! No System Directives here !
// own namespace and static classes from other Visual C# Files.
using static Visual.Operation.System.Native.NativeMethods;
using static Visual.Operation.System.Native.UnsafeNativeMethods;
using static Visual.Operation.System.Native.NativeRuntimeMethods;



using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities.STYLES;







//-----------------------------------------------------------------------------
//
//
//
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Utility
{

    /// <summary>
    /// Class VGFUtility
    /// </summary>
    public static class VGFUtility
    {

        

        

        /*----------- Interaction User ----------------------------------------
         * Automatic Button - Click
         * --------------------------------------------------------------------
         * DispatcherTimer mt = new DispatcherTimer();
         * mt.Interval = TimeSpan.FromMilliseconds(10);
         * mt.Tickm += x_button_click;
         * mt.Start;
         * 
         * automatic buttons-click when no user action or reaction or timeout.
         * 
         * 
         * --------------------------------------------------------------------
         * .NET Framework have many Timers for use, without controls.
         * --------------------------------------------------------------------
         * Timer(Method, Parameter, TimnerStart, TimerInterval);
         * ------------------------0 = late start, 1 = direct start Timer
         * 
         * Timer(Methodname, null, 1, 5000); 
         * means, all 5 seconds he calls the Method.
         * 
         * DON'T FORGET the Timer.Stop; FORGET- the timer runs continue, end of app.
         * -------------------------------------------------------------------------
         * Phone: Class VibrateController - vibrate your Phone
         * controlled with Timer, Vibration, but don't forget Timer.Stop!
         * forget?, vibrate never stop.
         * -------------------------------------------------------------------------
         * ?? the new operator in Visual C# 7.3/8.0 - Elvis Operator
         * -------------------------------------------------------------------------
         * for shorter writing constants for method/property 
         * use the Lambda Operator:
         *
         * here class Enviroment with Property
         * internal static string Name => Environment.UserName;
         * ------------------------------------------------------------------------- 
         * public void Methodname(parameter) => throw MethodException
         * {
         * 
         * }
         * 
         * -------------------------------------------------------------------------
         * Exception Bundle
         * 
         * Visual C# Exceptions like Java Exceptions with Operator ||
         * 
         * catch(SystemException ex)when(ex is Win32Exception || ex is COMException || ex is ApplicationExcedption)
         * {
         * 
         * }
         * 
         * 
         * 
         * 
         * Exception beim Start einer .NET-Applikation
         * Wenn Sie eine Applikation unter .NET starten, kann es unter 64-Bit-Betriebssystemen zu folgenden Exceptions kommen:
         * System.BadImageFormat Exception (Exception-Detail: Es wurde versucht, 
         * eine Datei mit einem falschen Format zu laden. (Ausnahme von HRESULT: 0x8007000B)).
         * Exception.InnerException oder System.IO.FileNotFoundException 
         * (Exception-Detail: Die DLL "cxll??.dll": Das angegebene Modul wurde nicht gefunden. (Ausnahme von HRESULT: 0x8007007E)).
         * 
         * Hintergrund ist, dass Visual Studio auf 64-Bit-Betriebssystemen per Default versucht, 
         * Ihre Applikation als 64-Bit-Prozess zu starten.
         * Sie können die Meldung bei Verwendung älterer Versionen leicht umgehen,
         * indem Sie das Compile-Ziel von "Any CPU" auf "x86" ändern.
         * 
         * Die Applikation läuft dann auch auf 64-Bit-Systemen als 32-Bit-Applikation und kann so problemlos ausgeführt werden
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */

        /// <summary>
        /// b now have the string Hello Spatzl
        /// </summary>
        /// <returns></returns>
        public static string TestMethod1()
        {
            string a = "Hello Spatzl";
            string b;

            b = a;

            // b have yet string from a
            return b;
        }


        /// <summary>
        /// a now have the string Hello 
        /// </summary>
        /// <returns></returns>
        public static string TestMethod2()
        {
            string a = "Hello Spatzl";

            // trim the string
            a.Substring(0, 5);

            // a have only the Word 'Hello' as returned string value
            return a;
        }

        /// <summary>
        ///         Hält den aktuellen Thread während des angegebenen Zeitraums an.
        /// </summary>
        /// <param name="timeout">
        /// Der Zeitraum, während dessen der Thread angehalten wird.
        /// Wenn der Wert des timeout lautet, gibt der Thread den Rest seines
        /// Zeitanteils an einen beliebigen Thread mit gleicher Priorität ab, 
        /// der für die Ausführung bereit ist.
        /// Sind keine anderen Threads mit gleicher Priorität vorhanden, 
        /// die ausgeführt werden können, 
        /// wird die Ausführung des aktuellen Threads nicht angehalten.
        /// </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Der Wert von timeout ist negativ und nicht gleich in Millisekunden oder 
        /// größer als Millisekunden.
        /// </exception>
        public static void VGFSleep(TimeSpan timeout)
        {
            long num = (long)timeout.TotalMilliseconds;

            if (num < -1 || num > 2147483647)
            {
                VFLMsgBox("Argument out of Range by timeout value !", "VGF::Sleep::Warning", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                NRMExit(EXIT_CODES.ERROR_BAD_ARGUMENTS);
            }

            Sleep((uint)num);
        }





        /// <summary>
        /// Check Operation Systems - Windows, Linux and Apple mac OS X
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Check before use any Classes on other Operation Systems
        /// Windows----- Class registry
        /// Linux------- NO, Registry not supported !
        /// mac OS X---- NO, Registry not supported !
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// NOT all you can use in other Operation Systems,
        /// from Windows System or .NET Framework.
        /// .NET Framework, .NET Core 3.0 and Standard
        /// Windows, Ubuntu Linux, Apple mac OS X
        /// IBM i Systems (after rebranding AS/400 - OS/400), IBM AIX (install)
        /// For this Operation System can use MONO Framework supports them.
        /// AIX is a derivate from Unix, but have new Format XCOFF same as Microsoft COFF Format.
        /// i System have a Object Based File System.
        /// IBM give Developers same sourcecodes written in C#, to connect to gateways,
        /// Server, z/series (Mainframes plus Handbooks)
        /// VMware give lot of sourcecode to VMware parts:
        /// 
        /// Windows 10 Professional October 2018 supports now all Virtual Machines,
        /// Virtual Machine Platform and more Networking Client/Server....
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static int VGFCheckOperationSystem()
        {

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // OK ! Windows support IT ! simpleSample Class Registry
                // Set your code here, sample Registry Methods
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // NOTE! Class Registry doesnt support on Linux
                throw new PlatformNotSupportedException("Linux doesn't support Registry");
                
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // NOTE! Class Registry doesnt support on Apple mac OS X
                throw new PlatformNotSupportedException("Apple mac OS X doesn't support Registry");
            }
            else
            {
                throw new PlatformNotSupportedException("The current Operation System on your Computer doesnt support this!");
            }
            return 0;

        }

        /// <summary>
        /// Exit Process .exe and component
        /// </summary>
        /// <!-- Author Tippo -->
        /// 
        /// <!-- Author Tippo -->
        /// <remarks>
        /// One of the Library files needed to run this application is damaged.
        /// </remarks>
        /// <returns>
        /// returned 1154 for Exitcode
        /// </returns>
        public static int VGFExitProcessExeDll()
        {
            return NRMExit(EXIT_CODES.ERROR_INVALID_DLL);
        }

        /// <summary>
        /// TEST METHOD DON'T USE IT!
        /// </summary>
        /// <!-- Author TIPPO -->
        /// !NOTE! inside a new Method from OS-Build 18272 19H1 - 2019.
        /// SetLastErrorEx now with Errortype.
        /// <!-- Author TIPPO -->
        /// <param name="ErrorCode"></param>
        /// <returns></returns>
        public static string VGFSetLastError(int ErrorCode)
        {
            

            try
            {
                /* NEW! now Windows Function have second Parameter:
                 * SetLastErrorEx have Parameter ErrorType! can set it,
                 * SLE_ERROR
                 * SLE_MINORERROR
                 * SLE_WARNING
                 * 
                 */
                SetLastErrorEx(ErrorCode, SLE.SLE_ERROR);

                // Change bool to string in Methoddeclaration,
                // true to true.ToString literal, so the returned is True as string.
                return true.ToString();
            }
            // catch a Windows Operation System Error
            catch(Win32Exception ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFSetLastError", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                
                // Change bool to string in Methoddeclaration,
                // true to false.ToString literal, so the returned is False as string.
                return false.ToString();
            }

        } // end of Method::VGFSetLastError

        /// <summary>
        /// Load System Library of Windows Operation System
        /// </summary>
        /// <param name="LibFileName">Set the Libraryname</param>
        /// <remarks>
        /// Same Windows Library must be load before use it,
        /// netapi.dll, netapi32.dll they are pure resources, Network Error Messages!
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFLoadLibrary(string LibFileName)
        {
            IntPtr intPtr;

            intPtr = LoadLibraryEx(LibFileName, IntPtr.Zero, 0);

            /************* Returned Error Number for LoadLibraryEx ************
             * 
             * UNCHECKED TIPPO - if guilty?
             * ----------------------------------------------------------------
             * 0    System was out of memory, executable file was corrupt, 
             *      or relocations were invalid.
             * ----------------------------------------------------------------
             * 2    File was not found.
             * ----------------------------------------------------------------
             * 3    Path was not found.
             * ----------------------------------------------------------------
             * 5    Attempt was made to dynamically link to a task, or 
             *      there was a sharing or network-protection error.
             * ----------------------------------------------------------------
             * 6    Library required separate data segments for each task.
             * ----------------------------------------------------------------
             * 8    There was insufficient memory to start the application.
             * ----------------------------------------------------------------
             * 10   Windows version was incorrect.
             * ----------------------------------------------------------------
             * 11   Executable file was invalid. Either it was not a Windows
             *      application or there was an error in the .EXE image.
             * ----------------------------------------------------------------
             * 12   Application was designed for a different operating system.
             * ----------------------------------------------------------------
             * 13   Application was designed for MS-DOS 4.0.
             * ----------------------------------------------------------------
             * 14   Type of executable file was unknown.
             * ----------------------------------------------------------------
             * 15   Attempt was made to load a real-mode application.
             *      (developed for an earlier version of Windows).
             * ----------------------------------------------------------------
             * 16   Attempt was made to load a second instance of an 
             *      executable file containing multiple data segments 
             *      that were not marked read-only.
             * ----------------------------------------------------------------
             * 19   Attempt was made to load a compressed executable file. 
             *      The file must be decompressed before it can be loaded.
             * ----------------------------------------------------------------
             * 20   Dynamic-link library (DLL) file was invalid. 
             *      One of the DLLs required to run this 
             *      application was corrupt.
             * -----------------------------------------------------------------
             * 21   Application requires Microsoft Windows 32-bit extensions.
             * -----------------------------------------------------------------
             *******************************************************************/

            if ((int)intPtr > 32)
            {
                // "LoadLibrary success";
                return true;
            }
            else
            {
                // Load Library Fehler
                return false;
            }

        } // end of Method::VGFLoadLibrary

        /// <summary>
        /// Search a File in System other.
        /// </summary>
        /// <!-- Author TIPPO -->
        /// Faster as others.
        /// <!-- Author TIPPO -->
        /// <param name="FileName">Set Filename</param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFSearchFile(string FileName)
        {

            try
            {

                // Set StringBuilder faster as string
                // set expanded StringBuilder range minimum 255 chars and maximum 2048 Chars.
                // Set this, for one Value in String 255, if string greather he cut the string.
                var sb = new StringBuilder(255, 2048);

                // Windows Function, for faster search a File.
                SearchPath(null, FileName, null, sb.Capacity, sb, IntPtr.Zero);
                return true;
            }
            catch(Win32Exception ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }

        } // end of Method::VGFSearchFile

        /// <summary>
        /// Get Volume Serial
        /// </summary>
        /// <param name="DriveLetter"></param>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetVolumeSerial(string DriveLetter)
        {
            

            return "";





        } // end of Method::VGFGetVolumeSerial


        /*

            DNS - Domain Name System
            The Domain Name System, DNS for short, 
            is also referred to as the "Telephone Book of the Internet". 
            Similar to looking for a name in a telephone directory 
            to get the phone number out, look in the DNS for a computer name to get the associated IP address.
            The IP address is needed to connect to a server that knows only the computer name.
            The Domain Name System is a system for resolving computer names into IP addresses and vice versa. 
            DNS has no central database. 
            The information is distributed on many thousands of name servers (DNS servers).
            If, for example, you want to visit the website www.elektronik-kompendium.de, 
            the browser will ask you for a DNS server that is stored in the IP configuration. 
            This is usually the router of internet access. Depending on whether or 
            not the DNS request can be answered, a chain of additional DNS servers is polled 
            until the request is answered in the affirmative and an IP address can be returned to the browser.
            If a computer name or domain name can not be resolved, then no connection can be established to that host. 
            Unless the user has the knowledge of the IP address. 
            This means that without DNS, communication in the network and on the Internet is practically impossible. 
            This is why there are many thousands of DNS servers around the world, which are hierarchically arranged
            and inform each other about changes.

            Windows Operation System First was GetComputerName,
            Windows 7, 8, 8.1 GetComputerNameEx,
            Windows 10 GetComputerNameEx2 with extension, 
            means more Networking in Windows Operation System with lot of Network Libraries - Client/Server -
            more Network Connections...


        */


        /// <summary>
        /// Get Computer DNS DomainName
        /// </summary>
        /// <returns></returns>
        public static string VGFGetComputerDNSDomainName()
        {
            byte success;

            try
            {
                var name = new StringBuilder(260, 2048);
                
                success = GetComputerNameEx2(COMPUTER_NAME_FORMAT.ComputerNameDnsDomain, name, name.Capacity);
                return name.ToString();
            }
            catch(SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

                int VGFError = NRMExit(EXIT_CODES.ERROR_EXTENDED_ERROR);

                return string.Format("The Method returns {0} is extended Error has occured !.", VGFError);
            }

        } // end of Method::VGFGetComputerDNSDomainName


        //
        // ComputerNamePhysicalDnsHostname used to rename the computer name and netbios name before domain join
        //

        /// <summary>
        /// Get Computer DNS DomainName
        /// </summary>
        /// <param name="DNSHostname"></param>
        /// <returns></returns>
        public static string VGFSetComputerPhysDNSHostName(string DNSHostname)
        {
            /*

            // Exceptionhandling ON
            try
            {
                var name = new StringBuilder(260, 2048);
                
                
                SetComputerNameEx(Operation.System.Native.NativeMethods.COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsHostname, name);
                return name.ToString();

            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);

                int VGFError = NRMExit(EXIT_CODES.ERROR_EXTENDED_ERROR);

                return string.Format("The Method returns {0} is extended Error has occured !.", VGFError);
            }

            */

            return "";

        } // end of Method::VGFSetComputerPhysDNSHostName

        /// <summary>
        /// Check if a process is running
        /// </summary>
        /// <param name="processname">the processname</param>
        /// <returns>true if the process runns otherwise false</returns>
        public static bool VGFCheckIfAProcessIsRunning(string processname)
        {
            return Process.GetProcessesByName(processname).Length > 0;

        } // end of Method::VGFCheckIfAProcessIsRunning


        















        /*
        public static bool VGFShowSplashImage()
        {
            // namespace System.Windows - Windows Presentation Foundation
            // Start Splash Screen on an WPF App with given image.bmp
            SplashScreen splashScreen = new SplashScreen("SplashScreenImage.bmp");
            
            // true is autoClose, false no!
            splashScreen.Show(false);

            // close the Splash Screen with given TimeSpan in milliseconds for Fade Out
            // Fade Out same in AnimateWindow() an Windows Function:
            // Fade In, Slide In, Slide Out on Top, Buttom, left and right, middle site
            splashScreen.Close(TimeSpan.FromMilliseconds(3000));

            // Run the application.

            // splashScreen.Close(TimeSpan fadeoutDuration);
            // A TimeSpan that specifies how long it will take for the splash screen to fade after the close operation has been initiated.
            // splashScreen.Close(5000);

            -----------------------------------------------------------------------------------------------------
            TimeSpan is struct
            -----------------------------------------------------------------------------------------------------
            TIPPO Idea - automatic by date and time or time call anything,
            Method, write, automatic e-mail, network connection, 
            
            Admin the same for Network in a Company, setup, install, update, upgrade,
            Admin send Message to all open Workstations: "! ATTENTION ! in x minutes and seconds we shutdown the 
            Network System for install new Programs and Compoments !. Please save your Works ! Thank you! -
            For more Information go on: x"
            Class DateTime, TimeSpan Struct, 
            
            // ----------------------31.12.2018 at 17:00:00 ---make automatic call ------------------------------
            var date1 = new DateTime(2018, 12, 31, 17, 00, 00);
            //
            string.Format("{0:2}",  HH:MM:SS:MMM);
            {0:2} trailing null 00 - 1 to 9 -- 01, 02, 03...
            -----------------------------------------------------------------------------------------------------
            string array for date and time, so the program automatic calls anythings at date and time.
            
            string[] values = 
            { 
              "12", ----------------> Index O - want start with Index 1, so set in Index 0 - 0, null, "",
              "31.", ---------------> Index 1
              "5.8:32:16", ---------> Index 2
              "12:12:15.95", -------> Index 3
              ".12" ----------------> Index 4
            };

            Array with extensions, .Add, .delete, .split, .indexOf(),
            add a Members, delete a member, remove a member
            -----------------------------------------------------------------------------------------------------
                // Define two dates.
                DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
                DateTime date2 = new DateTime(2010, 8, 18, 13, 30, 30);
                
                // Calculate the interval between the two dates.
                TimeSpan interval = date2 - date1;
                
                Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString());
                
                // Display individual properties of the resulting TimeSpan object.
                Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
                Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
                Console.WriteLine("   {0,-35} {1,20}", "Value of Hours Component:", interval.Hours);
                Console.WriteLine("   {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
                Console.WriteLine("   {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
                Console.WriteLine("   {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
                Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds);
                Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
                Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
                Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
                Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);

                OUTPUT:
                the example displays the following output:
                //       8/18/2010 1:30:30 PM - 1/1/2010 8:00:15 AM = 229.05:30:15
                //          Value of Days Component:                             229
                //          Total Number of Days:                   229.229340277778
                //          Value of Hours Component:                              5
                //          Total Number of Hours:                  5501.50416666667
                //          Value of Minutes Component:                           30
                //          Total Number of Minutes:                       330090.25
                //          Value of Seconds Component:                           15
                //          Total Number of Seconds:                      19,805,415
                //          Value of Milliseconds Component:                       0
                //          Total Number of Milliseconds:             19,805,415,000
                //          Ticks:                               198,054,150,000,000


                # Define two dates.
                $Date2 = Get-Date -Date '2010/8/18' -Hour 13 -Minute 30 -Second 30
                $Date1 = Get-Date -Date '2010/1/1'  -Hour 8  -Minute 0  -Second 15

                # Calculate the interval between the two dates.
                $Interval = $Date2 - $Date1
                "{0} - {1} = {2}" -f $Date2, $Date1, ($Interval.ToString())

                #  Display individual properties of the resulting TimeSpan object.
                "   {0,-35} {1,20}"    -f "Value of Days Component:", $Interval.Days
                "   {0,-35} {1,20}"    -f "Total Number of Days:", $Interval.TotalDays
                "   {0,-35} {1,20}"    -f "Value of Hours Component:", $Interval.Hours
                "   {0,-35} {1,20}"    -f "Total Number of Hours:", $Interval.TotalHours
                "   {0,-35} {1,20}"    -f "Value of Minutes Component:", $Interval.Minutes
                "   {0,-35} {1,20}"    -f "Total Number of Minutes:", $Interval.TotalMinutes
                "   {0,-35} {1,20:N0}" -f "Value of Seconds Component:", $Interval.Seconds
                "   {0,-35} {1,20:N0}" -f "Total Number of Seconds:", $Interval.TotalSeconds
                "   {0,-35} {1,20:N0}" -f "Value of Milliseconds Component:", $Interval.Milliseconds
                "   {0,-35} {1,20:N0}" -f "Total Number of Milliseconds:", $Interval.TotalMilliseconds
                "   {0,-35} {1,20:N0}" -f "Ticks:", $Interval.Ticks

                <# This sample produces the following output:

                18/08/2010 13:30:30 - 01/01/2010 08:00:15 = 229.05:30:15
                   Value of Days Component:                             229
                   Total Number of Days:                   229.229340277778
                   Value of Hours Component:                              5
                   Total Number of Hours:                  5501.50416666667
                   Value of Minutes Component:                           30
                   Total Number of Minutes:                       330090.25
                   Value of Seconds Component:                           15
                   Total Number of Seconds:                      19,805,415
                   Value of Milliseconds Component:                       0
                   Total Number of Milliseconds:             19,805,415,000
                   Ticks:                               198,054,150,000,000
                #>

                    DateTime departure = new DateTime(2010, 6, 12, 18, 32, 0);
                    DateTime arrival = new DateTime(2010, 6, 13, 22, 47, 0);
                    TimeSpan travelTime = arrival - departure;  
                    Console.WriteLine("{0} - {1} = {2}", arrival, departure, travelTime);      
                    // The example displays the following output:
                    //       6/13/2010 10:47:00 PM - 6/12/2010 6:32:00 PM = 1.04:15:00
                    using System;

                    public class Example
                    {
                       static Random rnd = new Random();
   
                       public static void Main()
                       {
                          TimeSpan timeSpent = TimeSpan.Zero;

                          timeSpent += GetTimeBeforeLunch();
                          timeSpent += GetTimeAfterLunch();

                          Console.WriteLine("Total time: {0}", timeSpent);
                       }

                       private static TimeSpan GetTimeBeforeLunch()
                       {
                          return new TimeSpan(rnd.Next(3, 6), 0, 0);
                       }
   
                       private static TimeSpan GetTimeAfterLunch()
                       {
                          return new TimeSpan(rnd.Next(3, 6), 0, 0);
                       }
                    }
                    // The example displays output like the following:
                    //        Total time: 08:00:00

                    
                    
                    string[] values = { "12", "31.", "5.8:32:16", "12:12:15.95", ".12"};

                    foreach (string value in values)
                    {
                       try {
                          TimeSpan ts = TimeSpan.Parse(value);
                          Console.WriteLine("'{0}' --> {1}", value, ts);
                       }
                       catch (FormatException) {
                          Console.WriteLine("Unable to parse '{0}'", value);
                       }
                       catch (OverflowException) {
                          Console.WriteLine("'{0}' is outside the range of a TimeSpan.", value);
                       }   
                    }
                    // The example displays the following output:
                    //       '12' --> 12.00:00:00
                    //       Unable to parse '31.'
                    //       '5.8:32:16' --> 5.08:32:16
                    //       '12:12:15.95' --> 12:12:15.9500000
                    //       Unable to parse '.12'

                    using System;

                    public class Example
                    {
                       public static void Main()
                       {
                          TimeSpan interval = DateTime.Now - DateTime.Now.Date;
                          string msg = String.Format("Elapsed Time Today: {0:d} hours.", interval);
                          Console.WriteLine(msg);
                       }
                    }
                    // The example displays the following output:
                    //       Elapsed Time Today: 01:40:52.2524662 hours.



                    / Example of the TimeSpan( int, int, int, int, int ) constructor. 
                    using System;

                    class TimeSpanCtorIIIIIDemo
                    {
                        // Create a TimeSpan object and display its value.
                        static void CreateTimeSpan( int days, int hours, int minutes, int seconds, int millisec )
                        {
                            TimeSpan elapsedTime = new TimeSpan(days, hours, minutes, seconds, millisec );

                            // Format the constructor for display.
                            string ctor = 
                                String.Format( "TimeSpan( {0}, {1}, {2}, {3}, {4} )", days, hours, minutes, seconds, millisec);

                            // Display the constructor and its value.
                            Console.WriteLine( "{0,-48}{1,24}", 
                                ctor, elapsedTime.ToString( ) );
                        }

                        static void Main( )
                        {
                            Console.WriteLine( 
                                "This example of the " +
                                "TimeSpan( int, int, int, int, int ) " +
                                "\nconstructor generates the following output.\n" );
                            Console.WriteLine( "{0,-48}{1,16}", "Constructor", "Value" );
                            Console.WriteLine( "{0,-48}{1,16}", "-----------", "-----" );

                            CreateTimeSpan( 10, 20, 30, 40, 50 );
                            CreateTimeSpan( -10, 20, 30, 40, 50 );
                            CreateTimeSpan( 0, 0, 0, 0, 937840050 );
                            CreateTimeSpan( 1111, 2222, 3333, 4444, 5555 );
                            CreateTimeSpan( 1111, -2222, -3333, -4444, -5555 );
                            CreateTimeSpan( 99999, 99999, 99999, 99999, 99999 );
                        } 
                    } 


                    This example of the TimeSpan( int, int, int, int, int )
                    constructor generates the following output.

                    Constructor                                                Value
                    -----------                                                -----
                    TimeSpan( 10, 20, 30, 40, 50 )                       10.20:30:40.0500000
                    TimeSpan( -10, 20, 30, 40, 50 )                      -9.03:29:19.9500000
                    TimeSpan( 0, 0, 0, 0, 937840050 )                    10.20:30:40.0500000
                    TimeSpan( 1111, 2222, 3333, 4444, 5555 )           1205.22:47:09.5550000
                    TimeSpan( 1111, -2222, -3333, -4444, -5555 )       1016.01:12:50.4450000
                    TimeSpan( 99999, 99999, 99999, 99999, 99999 )    104236.05:27:18.9990000



                    Worldwide Timezones Map - 
                    // Example of selected TimeZone class elements.
                    using System;
                    using System.Globalization;

                    class TimeZoneDemo
                    {
                        static void Main( )
                        {
                            const string dataFmt = "{0,-30}{1}";
                            const string timeFmt = "{0,-30}{1:yyyy-MM-dd HH:mm}";

                            Console.WriteLine(
                                "This example of selected TimeZone class " +
                                "elements generates the following \n" +
                                "output, which varies depending on the " +
                                "time zone in which it is run.\n" );

                            // Get the local time zone and the current local time and year.
                            TimeZone localZone = TimeZone.CurrentTimeZone;
                            DateTime currentDate = DateTime.Now;
                            int      currentYear = currentDate.Year;

                            // Display the names for standard time and daylight saving 
                            // time for the local time zone.
                            Console.WriteLine( dataFmt, "Standard time name:", 
                                localZone.StandardName );
                            Console.WriteLine( dataFmt, "Daylight saving time name:", 
                                localZone.DaylightName );

                            // Display the current date and time and show if they occur 
                            // in daylight saving time.
                            Console.WriteLine( "\n" + timeFmt, "Current date and time:",
                                currentDate );
                            Console.WriteLine( dataFmt, "Daylight saving time?", 
                                localZone.IsDaylightSavingTime( currentDate ) );

                            // Get the current Coordinated Universal Time (UTC) and UTC 
                            // offset.
                            DateTime currentUTC = 
                                localZone.ToUniversalTime( currentDate );
                            TimeSpan currentOffset = 
                                localZone.GetUtcOffset( currentDate );

                            Console.WriteLine( timeFmt, "Coordinated Universal Time:", 
                                currentUTC );
                            Console.WriteLine( dataFmt, "UTC offset:", currentOffset );

                            // Get the DaylightTime object for the current year.
                            DaylightTime daylight = 
                                localZone.GetDaylightChanges( currentYear );

                            // Display the daylight saving time range for the current year.
                            Console.WriteLine( 
                                "\nDaylight saving time for year {0}:", currentYear );
                            Console.WriteLine( "{0:yyyy-MM-dd HH:mm} to " +
                                "{1:yyyy-MM-dd HH:mm}, delta: {2}", 
                                daylight.Start, daylight.End, daylight.Delta );
                        } 
                    } 

            
                    This example of selected TimeZone class elements generates the following
                    output, which varies depending on the time zone in which it is run.

                    Standard time name:           Pacific Standard Time
                    Daylight saving time name:    Pacific Daylight Time

                    Current date and time:        2006-01-06 16:47
                    Daylight saving time?         False
                    Coordinated Universal Time:   2006-01-07 00:47
                    UTC offset:                   -08:00:00

                    Daylight saving time for year 2006:
                    2006-04-02 02:00 to 2006-10-29 02:00, delta: 01:00:00
            












           



        

        }

        */






    } // end of class VGFUtility

} // end of namespace::Vual.Galaxy.Framework.Utility


//-----------------------------------------------------------------------------//
//---------------------- END OF FILE::VGF.Utility.cs --------------------------//
//-----------------------------------------------------------------------------//
