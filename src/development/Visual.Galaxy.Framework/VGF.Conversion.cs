//#############################################################################
//
// Project			:	Visual.Galaxy.Framework
//
//#############################################################################
//
//-----------------------------------------------------------------------------
// Programmer       :	Project-Founder and Main-Author Christian "Tipplin" Kurs
//-----------------------------------------------------------------------------
// Part				:	VGF.Conversion
//-----------------------------------------------------------------------------
// Base Class       :	
//-----------------------------------------------------------------------------
// Copyright © 2019
// by  Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
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
// © 1982 - 2019 Microsoft Corporation.All rights reserved.
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
 * Copyright © 2019 by Christian 'Tipplin' Kurs - Germany
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

using System.Text;
using System.Text.RegularExpressions;


//-------------------------------------------------------
// Here namespaces from Project-Solution from other
// Visual C# Files name.cs, 
// classes and methods are static written in C#
//-------------------------------------------------------

using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;
using static Visual.Operation.System.Native.NativeMethods;
using static Visual.Operation.System.Native.NativeRuntimeMethods;
using static Visual.Operation.System.Native.UnsafeNativeMethods;
//





//-----------------------------------------------------------------------------
//
// 
//-----------------------------------------------------------------------------
// Next Crash Date and Time Unix Timestamp:
// 2038 03:40 - Timestamp in integer values goes overflow, pass to long.
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Conversion
{


    /// <summary>
    /// UNDONE - exceptionhandling do or not do ?!
    ///
    ///
    ///
    ///  Contains methods to do all kinds of Conversions
    ///
    ///
    /// </summary>
    internal static class VGFCoreConversion
    {
        /* NEW ! take one constant set for more
        internal static int a,
                            b,
                            c,
                            // marked the end of constants semicolon ;
                            d; 
         */


        public const long iOneMeg = 1024 * 1024;

        // file < 1 GByte?
        public const long iOneGigabyte = iOneMeg * 1000;

        // file > 1 GByte
        public static int iGigs = 0;

        /// <summary>
        /// Convert Hexadecimal to Decimal
        /// </summary>
        /// <param name="chChar"></param>
        /// <returns></returns>
        public static char VGFHexToDec(char chChar)
        {
            return char.IsDigit(chChar) ? chChar : (char)((chChar & ~('a' - 'A')) - 'A' + 10 + '0');

        } // End of Method::VGFHexToDec


        /*
         * Next Time Bomb by Unix File time.h
         * at 2038 the time overflow, while written in 32 BIT.
         * 
         */


        /// <summary>
        /// Get Seconds to Time short String
        /// </summary>
        /// <param name="lSeconds"></param>
        /// <returns></returns>
        public static string VGFSecondsToShortHMSString(int lSeconds)
        {
            if (lSeconds < 0) return ("0:00");
            int hh = lSeconds / 3600;
            lSeconds = lSeconds % 3600;
            int mm = lSeconds / 60;

            // int ss = lSeconds % 60;

            string strHMS = String.Format("{0}:{1:00}", hh, mm);
            return strHMS;

        } // End of Method::VGFSecondsToShortHMSString

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timespan"></param>
        /// <returns></returns>
        public static string VGFSecondsToHMSString(TimeSpan timespan)
        {
            return VGFSecondsToHMSString(timespan.Seconds);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lSeconds"></param>
        /// <returns></returns>
        public static string VGFSecondsToHMSString(int lSeconds)
        {
            if (lSeconds < 0) return ("0:00");
            int hh = lSeconds / 3600;
            lSeconds = lSeconds % 3600;
            int mm = lSeconds / 60;
            int ss = lSeconds % 60;

            string strHMS = hh >= 1 ? String.Format("{0}:{1:00}:{2:00}", hh, mm, ss) : String.Format("{0}:{1:00}", mm, ss);

            return strHMS;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lSeconds"></param>
        /// <returns></returns>
        public static string VGFSecondsToHMString(int lSeconds)
        {
            if (lSeconds < 0) return "0:00";
            int hh = lSeconds / 3600;
            lSeconds = lSeconds % 3600;
            int mm = lSeconds / 60;

            string strHM = hh >= 1 ? String.Format("{0:00}:{1:00}", hh, mm) : String.Format("0:{0:00}", mm);

            return strHM;
        }

        /// <summary>
        /// Get Unix Time
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Note! at Remarks
        /// <!-- Author Tipplin -->
        /// <param name="desiredTime_"></param>
        /// <remarks>
        /// NOTE !
        /// At Timebomb next is the Year 2038 at 03:48:00, the Unix Time -C- t_time is overflow !.
        /// is running at 1970 - 32 BIT written.
        /// source from Book: Better coding
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static long VGFGetUnixTime(DateTime desiredTime_)
        {
            TimeSpan ts = (desiredTime_ - new DateTime(1970, 1, 1, 0, 0, 0));

            return (long)ts.TotalSeconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ldate"></param>
        /// <returns></returns>
        public static DateTime VGFLongToDate(long ldate)
        {

            try
            {
                if (ldate < 0) return DateTime.MinValue;
                int sec = (int)(ldate % 100L); ldate /= 100L;
                int minute = (int)(ldate % 100L); ldate /= 100L;
                int hour = (int)(ldate % 100L); ldate /= 100L;
                int day = (int)(ldate % 100L); ldate /= 100L;
                int month = (int)(ldate % 100L); ldate /= 100L;
                int year = (int)ldate;
                DateTime dt = new DateTime(year, month, day, hour, minute, sec, 0);

                return dt;
            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFLongToDate", STYLES.OkOnly | STYLES.Exclamation | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static long VGFDateToLong(DateTime dt)
        {
            try
            {
                long iSec = dt.Second;
                long iMin = dt.Minute;
                long iHour = dt.Hour;
                long iDay = dt.Day;
                long iMonth = dt.Month;
                long iYear = dt.Year;
                long lRet = iYear;

                lRet = lRet * 100L + iMonth;
                lRet = lRet * 100L + iDay;
                lRet = lRet * 100L + iHour;
                lRet = lRet * 100L + iMin;
                lRet = lRet * 100L + iSec;
                return lRet;

            }
            catch (SystemException ex)
            {
                VFLMsgBox(ex.Message, "Exception at Method::VGFDateToLong", STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
                // HRESULT is now open for use, before, was hidden/protected as property
                // HRESULT all are long and with prefix sign minus -21000000
                return ex.HResult;
            }
        }

        /// <summary>
        /// Returns the size as a string formatted with Kibi bytes, Mebi bytes , Gibi bytes
        /// new norm for sizes, BIMP Paris official Values !.
        /// Kilobytes, Megabytes, Gigabytes are wrong values!
        /// BIMP Table differrents in Present / %
        /// </summary>
        /// <!-- Author Tipplin -->
        /// Official Values binary bytes the true values, 
        /// Kibi = Kilo Binary Byte 
        /// Mebi = Mega Binary Byte
        /// Gebi
        /// Tebi
        /// Exbi
        /// Yobi
        /// Zebi
        /// <!-- Author Tipplin -->
        /// <param name="dwFileSize"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static string VGFGetSizeString(long dwFileSize)
        {
            if (dwFileSize < 0) return "0";
            string szTemp;

            // file < 1 kbyte?
            if (dwFileSize < 1024)
            {
                //  substract the integer part of the float value
                float fRemainder = (dwFileSize / 1024.0f) - (dwFileSize / 1024.0f);
                float fToAdd = 0.0f;

                if (fRemainder < 0.01f)
                    fToAdd = 0.1f;

                szTemp = String.Format("{0:f} KB", (dwFileSize / 1024.0f) + fToAdd);

                return szTemp;
            }

            // file < 1 megabyte?
            if (dwFileSize < iOneMeg)
            {
                szTemp = String.Format("{0:f} KB", dwFileSize / 1024.0f);
                return szTemp;
            }

            //
            if (dwFileSize < iOneGigabyte)
            {
                szTemp = String.Format("{0:f} MB", dwFileSize / (float)iOneMeg);
                return szTemp;
            }

            //
            while (dwFileSize >= iOneGigabyte)
            {
                dwFileSize -= iOneGigabyte;
                iGigs++;
            }

            float fMegs = dwFileSize / (float)iOneMeg;
            fMegs /= 1000.0f;
            fMegs += iGigs;
            szTemp = String.Format("{0:f} GB", fMegs);
            return szTemp;
        }

        /// <summary>
        /// Is Char Alpha ?
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool VGFIsAlpha(char c)
        {
            return ((c >= 'A') && (c <= 'Z')) || ((c >= 'a') && (c <= 'z'));
        }


        

        /// <summary>
        /// Case Ignore Compare
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static int VGFCaseIgnoreCompare(String s1, String s2)
        {

            if (s1 == s2)
            {
                return 0;
            }
            return VGFToLowerString(s1).CompareTo(VGFToLowerString(s2));
        }

        /// <summary>
        /// Char To Upper
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char VGFToUpper(char c)
        {
            if ((c >= 'a') && (c <= 'z'))
            {
                c = (char)(c - ' ');
            }
            return c;
        }

        /// <summary>
        /// Char to Lower
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static char VGFToLower(char c)
        {
            if ((c >= 'A') && (c <= 'Z'))
            {
                c = (char)(c + ' ');
            }
            return c;
        }

        /// <summary>
        /// String to Lower
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string VGFToLowerString(String s)
        {
            return s.ToLower();
        }

        /// <summary>
        /// String to Upper String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string VGFToUpperString(String s)
        {
            return s.ToUpper().ToString();
        }

        /// <summary>
        /// String is a Alpha-string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool VGFIsAlphaString(String s)
        {
            return true;
        }

        /// <summary>
        /// Char is numeric
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool VGFIsNumeric(char c)
        {
            return (c >= '0') && (c <= '9');
        }

        /// <summary>
        /// String is numeric string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool VGFIsNumericString(String s)
        {
            return true;
        }

        /// <summary>
        /// Char is Alpha-Numeric
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool VGFIsAlphaNumeric(char c)
        {
            return (VGFIsAlpha(c)) || (VGFIsNumeric(c));
        }

        /// <summary>
        /// String is Alpha-Numeric string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool VGFIsAlphaNumericString(String s)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <!-- Author Tipplin -->
        /// ! ATTENTION ! use the Windows Function GetTickCount64() !,
        /// the old GetTickCount() overflow after 49 Days.
        /// Source: Microsoft Windows Developer.
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// 
        /// </returns>
        public static ulong VGFDifferentTimes()
        {
            ulong Start = GetTickCount64();
            ulong End = GetTickCount64();
            return End - Start;

        }





    }


} // END OF NAMESPACE::Visual.Galaxy.Framework.Conversion
