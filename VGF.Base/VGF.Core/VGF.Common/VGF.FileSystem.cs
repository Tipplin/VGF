//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.FileSystem
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2019
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "TIPPO" Kurs - Visual C# Developer
// Portions Copyright © 2019 by Microsoft Corporation GmbH.
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
// Copyright © 2019
// by  Visual Galaxy Framework Community Kernel Developer Team.
// all rights reserved.
// May be redistributed for free,
// but may not be sold without the author's explicit permission
//
// This software is Copyright © 2019 by VGF-Technologies at VGF-KernelTeam
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
// © 1982 - 2019 Microsoft Corporation.All rights reserved.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// VFGCore
// written by 		
//						Christian "TIPPO" Kurs
//						Nettweg 1
//				-G -  53498 Bad Breisig
//						Germany - Allemagne - Duitsland
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
 * Copyright © 2019 by Christian 'TIPPO' Kurs - Germany
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
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.AccessControl;

using System.Web;
using System.Web.UI;
using static System.Web.UI.Page;
using System.Web.UI.WebControls;
using System.Runtime.Caching;
using static System.Runtime.Caching.FileChangeMonitor;



//-----------------------------------------------------------------------------
//
// In this Project-Solution you use in all other namespaces 
// from other Visual C# name.cs Files:
// Classes and Methods are static written set this:
// here bind in Visual.Operation.System.dll, inside Attribute
// [InternalsInvisibleAttribute("Visual.Galaxy.Framework"), AllInternals = true]
// All internals written are visible in Project 'Visual Galaxy Framework'
//-----------------------------------------------------------------------------
//
//-----------------------------------------------------------------------------
// static Class NativeMethods for Constants, Enumerator, Struct's, variables...
//-----------------------------------------------------------------------------
using static Visual.Operation.System.Native.NativeMethods;

//-----------------------------------------------------------------------------
// static class All Windows Operation System Functions
//-----------------------------------------------------------------------------
using static Visual.Operation.System.Native.UnsafeNativeMethods;

//-----------------------------------------------------------------------------
// static class constants for MessageBox, StartUp
//-----------------------------------------------------------------------------
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

//-----------------------------------------------------------------------------
// static class Visual.Function.Library.dll
// our Functions for use written in C/C++.
//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------
// static class All C/C++ Runtime Library Functions for use.
//-----------------------------------------------------------------------------
using static Visual.Operation.System.Native.NativeRuntimeMethods;

//-----------------------------------------------------------------------------
// namespace Visual.Operation.System.Internal.InternalUtilities;
//-----------------------------------------------------------------------------
using Visual.Operation.System.Internal.InternalUtilities;





//-----------------------------------------------------------------------------
// Windows 10 File Systems Support:
//-----------------------------------------------------------------------------
// with Windows 10 new file orders, association for files:
// Microsoft open suffixes, so you can set own suffixes (max. 255 -1)
// Appname.config as configuration file, see .config as suffix,
// .accdb=Access.Application.16 - assoc to Microsoft Access Database,
// suffix new for Access .accdb -
//-----------------------------------------------------------------------------
// But note by drag and drop, windows explorer into Visual Studio:
// Excel sheets or Word documents into Project-Solution:
// Filename max 260 -1
// Pathfilename max 248 -1
// if the pathfilename nested and branched is higher then 247, 
// Warning Message:
// he shortened the Filename to PROJEC~1.DOC
//
//-----------------------------------------------------------------------------
// Filesystems:
//-----------------------------------------------------------------------------
// NTFS     - Windows 10 Filesystem - NEW FLAG ! - case sensitive
// use a extern Harddrive 1 Terabytes to 100 Terabytes or more
// the vendor set FAT32 that's not good.
// use system-tool fs for change FAT32 to NTFS that's convert.
//
//-----------------------------------------------------------------------------
// CIFS     -
// Btrfs    - Linux
// Sysfs    - Linux
// NPFS     -
// CDFS     - Flash storage
// RDR      -
// Refs     - Resilient File System Windows Server and 
//          - Windows 10 Professional for Workstations
//
//
// AlphaFs  -
// ADFS     - Apple 
//
// NEW by Files are open and by Windows Software Update,
// the internal Database 'Recent' make sure after shutdown and 
// reboot show all open Files last stand.
// internal Windows 10 Database make Event-loogs into Event Viewer.
//
//
// Class File set this Attribute:
// FileAttributes.ReadOnly = 1 the file secure to write, only read!
//-----------------------------------------------------------------------------
// Microsoft Operation System Windows 10 on USB-Stick with both Systems 32/64
// 110 € Home, 220 € Professional, in a Blue Box and readonly, Storage 17 GB.
//-----------------------------------------------------------------------------
// secure your Files with .NET Framework:
// Access Right System for other Users.
// Set for other Users your Rights add, delete, change, copy
//
// Special secure your File(s) with Password, use the SecureString Class
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.FileSystem
{
    /// <summary>
    /// Class VGFFileSystem
    /// </summary>
    /// <!-- Author TIPPO -->
    /// 
    /// <!-- Author TIPPO -->
    /// <remarks>
    /// NOTE ! Class File is static, you can directly use the members.
    /// 
    /// 
    /// </remarks>
    public static class VGFFileSystem
    {
        /// <summary>
        /// Get Last Access of File
        /// </summary>
        /// <param name="FullFilePathName"></param>
        /// <returns></returns>
        public static string VGFGetLastAccessTimeOfFile(string FullFilePathName)
        {
            if (!File.Exists(FullFilePathName))
            {
                // returned string get last access time for given File
                return string.Format("{0}", File.GetLastAccessTime(FullFilePathName) );
            }

            return "";
        }


        /// <summary>
        /// Get Last Write Time for a File
        /// </summary>
        /// <param name="FullFilePathName"></param>
        /// <returns></returns>
        public static string VGFGetLastWriteTimeOfFile(string FullFilePathName)
        {
            if (!File.Exists(FullFilePathName))
            {
                // returned string get last access time for given File
                return string.Format("{0}", File.GetLastWriteTime(FullFilePathName));
            }

            return "";
        }

        /// <summary>
        /// Get the creation Time of File
        /// </summary>
        /// <param name="FullFilePathName"></param>
        /// <returns></returns>
        public static string VGFGetCreationTimeOfFile(string FullFilePathName)
        {
            if (!File.Exists(FullFilePathName))
            {
                // returned string get last access time for given File
                return string.Format("{0}", File.GetCreationTime(FullFilePathName));
            }

            return "";
        }

        // TIPPO-UNDONE - FileSystem FileAccess and Password set to File failed !

        /// <summary>
        /// Set File Security
        /// </summary>
        /// <param name="Filename">Set the Filename</param>
        /// <param name="fa">Enumerator for File Attributes</param>
        /// <param name="fac">Set the Mode for File Access</param>
        /// <param name="Password">Set the Password</param>
        /// <!-- Author TIPPO -->
        /// optimal secure your File, Password is save, 
        /// while use SecureString for it!, 
        /// encrypt by handing over the password with Internal AES Cryptografy,
        /// the Password is save, by change the Harddisk.
        /// The class SecureString with Interface IDisposable, 
        /// so the Password not movable in the Main-Memory, the GC make it from time to time.
        /// At end of Program, all rewritable with zeros in Memory.
        /// Class SecureString at Time by Password, TAN, PIN, LogOn.
        /// <!-- Author TIPPO -->
        /// <remarks>
        /// Set File Security with .NET Framework,
        /// and in Windows 10 a Function SetFileSecurity(LPSTR FileName, SecurityDescriptor)
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static bool VGFSetFileSecurity(string Filename, FileAttributes fa, FileAccess fac, SecureString Password)
        {
            

            try
            {
                // Create the file if it does not exist.
                if (File.Exists(Filename))
                {
                    //
                    File.SetAttributes(Filename, fa); 
                }
                else
                {
                    // Get a FileSecurity object that represents the
                    // current security settings.
                    FileSecurity fSecurity = File.GetAccessControl(Filename);

                    // Add the FileSystemAccessRule to the security settings.
                    fSecurity.SetAccessRuleProtection(true, true);

                    // Set the new access settings.
                    File.SetAccessControl(Filename, fSecurity);

                }
            }
            catch(SecurityException ex)
            {
                VFLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return false;
            }



            // FileAttributes in 4.7.2 have new sets:
            // Please NOTE! parts of NTFS Filesystem and a new Flag case sensitive !
            //
            // FileAttributes.ReadOnly = 1 the file secure to write, only read!
            // FileAttributes.Hidden = 2 the File blend out in Windows Explorer
            // FileAttributes.Device = 64 is reserved for feature, TIPPO set the Device
            // FileAttributes.Encrypted = 16384 is encrypted the File

            // Class string is unsecure! GC write in Memory, Delphi Tool: Siphor.exe can read out the String from Memory. 

            // Class SecureString is at Time the best about encrypted a string:
            // now at insert the string as parameter and set, the internal automatic encryption works
            // AES Cryption, ECC from new Microsoft.System.Security.Cryptography does the work for us.
            // at Time secure Password, TAN, PIN, LogIN, optimal secure string doesnt write clear into memory storage
            // make the internal Interface IDisposable -> GC make string into Memory -> at end of program the IDisposable and
            // Dispose write many null value into Memory.
            // If Attacker change the harddrive, the securestring is crypted!
            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="securityRuleSet"></param>
        /// <returns></returns>
        public static string VGFSetWatchOfFile(string FileName, SecurityRuleSet securityRuleSet)
        {



            HttpServerUtility server = null;
            ObjectCache cache = MemoryCache.Default;
            
            var fileContents = cache["filecontents"] as string;
            
            if (fileContents == null)
            {
                    CacheItemPolicy policy = new CacheItemPolicy();
                    policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10.0);

                    List<string> filePaths = new List<string>();
                    string cachedFilePath = server.MapPath("~") + "\\cacheText.txt";

                    filePaths.Add(cachedFilePath);

                    policy.ChangeMonitors.Add(new HostFileChangeMonitor(filePaths));

                    // Fetch the file contents.
                    fileContents = File.ReadAllText(cachedFilePath) + "\n" + DateTime.Now.ToString();

                    cache.Set("filecontents", fileContents, policy);
            }
            // Label1.Text = fileContents;
            return fileContents;
        }
        





    } // End of Class::VGFFileSystem

} // End of Namespace::Visual.Galaxy.Framework.FileSystem

//-----------------------------------------------------------------------------
// END OF FILE: VGF.FileSystem.cs
//-----------------------------------------------------------------------------
