/*#############################################################################
 * 
 * Project			:	Visual.Galaxy.Framework
 * 
 * ############################################################################
 * 
 * ----------------------------------------------------------------------------
 * Programmer       :	Project-Founder and Main-Author Christian "TIPPO" Kurs
 * ----------------------------------------------------------------------------
 * Part				:	VGF.Timer
 * ----------------------------------------------------------------------------
 * Base Class       :	
 * ----------------------------------------------------------------------------
 * Copyright © 2019-2020 by: 
 * Visual Galaxy Framework Community Kernel Developer Team
 * ----------------------------------------------------------------------------
 * by Head-Author: Christian "TIPPO" Kurs - Visual C# Developer
 * 
 * Portions Copyright © 1982-2020 by Microsoft Corporation GmbH.
 * ----------------------------------------------------------------------------
 * 
 * ============================================================================
 * Tipplin WARNING:
 * ----------------------------------------------------------------------------
 * Change Windows 10 Operation System at 01.03.2019 
 * to new OS-Build 18342.8_Release,
 * March Update 2019, but Operation System stands under Bugfixes now!.
 * So wait for more Information, now compile under Visual C# 7.3
 * Visual C# 8.0 comes with Visual Studio 2019.
 * Visual Studio 2017 - Version 15.9.7 - 
 * Now Microsoft have Free Visual Studio 2019 as Download, but as Preview,
 * Final Release starts at 02.04.2019.
 * 
 * ============================================================================
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
 * Authored by Copyright © 2019 by 
 * Visual Galaxy Framework Community Kernel Developer Team.
 * All rights reserved.
 * 
 * May be redistributed for free, but may not be sold without 
 * the author's explicit permission.
 * 
 * This software is Copyright © 2019 by VGF-Technologies at VGF-KernelTeam
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
 * © 1982 - 2018 Microsoft Corporation.All rights reserved.
 * ----------------------------------------------------------------------------
 * Same sourcecode by Microsoft, so we marked with Copyright !.
 * © 1982 - 2018 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
 * Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
 * ----------------------------------------------------------------------------
 * DON'T CHANGE OR DELETE ANYTHING IN SECTION !!!.
 * ----------------------------------------------------------------------------
 * VFGCore written by
 *                      Christian "TIPPO" Kurs
 *                      Nettweg 1
 *                      - G -  53498 Bad Breisig
 *                      Germany - Allemagne - Duitsland
 * ----------------------------------------------------------------------------
 * voice                02633 - 470736  
 * international phone  00-49-2633-470736
 * Skype
 * E-mail               kurschristian@gmail.de
 * Community Website    http://www.vgfc.org/community/tippo
 * 
 * -----------------------------------------------------------------------------
 * This software is supplied as is. 
 * 
 * Use it at your own  RISK !!!!.
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
 * http://www.vgfc.org/community/project/vgf/
 * 
 * ----------------------------------------------------------------------------
 * Honest Business Users, to use our compiled Versions, 
 * please call us to send you our Business Licenses.
 * or 
 * our Business Website:
 * www.vgf.com/business/vgf/License
 * 
 * 
 *############################################################################# 
 */

/*********************** Developer Disclaimer *********************************
 *
 * Copyright © 2019 by Christian 'TIPPO' Kurs - Germany
 * 
 ******************************************************************************
 * English:
 *-----------------------------------------------------------------------------
 * 
 *****************************************************************************/




/* ######################### Visual.Galaxy.Framework ##########################
 * # Start Date: 2016/01/01 - 17:00 - Ground Leaning -Initial
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
 * (Internal)
 * Please write Visual C# Wrapper as here !!!. (Indirect Call)
 * ############################################################################
 * 
 * ----------------------------------------------------------------------------
 * Windows Operation System - native Methods - 
 * ----------------------------------------------------------------------------
 * Windows 10 Major jump to 10, Microsoft Info: has problems with 9 as
 * major version, same install/setups programs has problems with them,
 * and see 9 as Windows 95.
 * ----------------------------------------------------------------------------
 * Same Windows API have new Flags and Functions for Windows 10: 
 * ----------------------------------------------------------------------------
 * 1. 	use the .NET Framework 4.6.2, 4.7, 4.7.1 or higher (de. to Win 10)
 * 2. 	use all NOT into .NET Framework as native Functions 
 *      in DLLImportAttribute - user32, kernel32, shell32, advapi32 and so..
 *      all this new System Dll's have more Functions.
 * ----------------------------------------------------------------------------
 * 
 * ! NOTE !:
 * 
 * ----------------------------------------------------------------------------
 * All marked Windows 10 functions, you can use ONLY on Windows 10 System !.
 * Set special #if directive for Platform - 32 BIT and 64 BIT -
 * x86 and x64 - Intel and AMD compatible(little different, but not relevant).
 * a.)  Visual Studio help us porting a 32 BIT Project to 64 BIT Project, 
 *      like a Assistant, going to Platform Option over new... 
 *      and show the Assist.
 *      Choice your Selecting new Platform 64 BIT, than 32 BIT Project......
 *      Take Solution, but your must pass on same specials for 64 BIT.
 * 
 * 
 * ----------------------------------------------------------------------------
 * 
 * ----------------------------------------------------------------------------
 * Set here Directives and namespaces (Project)
 * using System,
 * using namespacename,
 * NEW at .NET Framework 4.6(4.6.1, 4.6.2)
 * using static -> classes and Methods are written with static.
 * using static directivename.classname,
 * so you can use the Methods directly without instance !.
 * ----------------------------------------------------------------------------
 * using static System.Math,		// mathematic methods - pow(x,y),
 *                                  // power of 2 - 2^10
 *                                  // Visual C++ Runtime Library refactoring:
 *                                  // old 17 Digits on new 768 Digits.
 * ----------------------------------------------------------------------------
 * using static System.Console,	// console:
 *                              // methods, properties and one event
 * ----------------------------------------------------------------------------
 * 
 * ################ MICROSOFT INFO ############################################
//---------------------------------------------------------------------------->
// <!-- Microsoft Portability, Globalization, Design automatic active! ------->
// <!-- Microsoft.Interoperability ------------------------------------------->
// <!-- Microsoft Portability ------------------------------------------------>
// <!------------------------------------------------------------------------->
// <!-- For native unmanaged Methods, must be written in three Classes: ------>
// <!--> Class NativeMethods-------- Stackwalk execute ----------------------->
// <!--> NO! [SuppressUnmanagedCodeSecurityAttribute] ------------------------>
// <!------------------------------------------------------------------------->
// <!--> Class SafeNativeMethods---- Stackwalk non execute
// <!--> with [SuppressUnmanagedCodeSecurityAttribute]
// <!--------- NO Security Check !, when set this Attribute, also ATTENTION!
// <!--> without Internal Full Security Check with Attribute
// <!--> NON! dangerous and Risk for User Calls.
// <!----------------------------------------------------------------------------->
// <!--> Class UnsafeNativeMethods-- Stackwalk non execute
// <!--> with [SuppressUnmanagedCodeSecurityAttribute]
// <!--> with Security-Risk, so internal Full Security Check with Attribute.
// <!----------------------------------------------------------------------------->
// <!--> drap and drop from Files Microsoft explorer into Project-Solution,
// <!--> qualifized Filename must be less than 260 chars, and Pathname less as
// <!--> 248 Chars. -- Visual Studio make short prefix and suffix old 8.3,
// <!--> documments names Projec~1.doc whey?
// <!-->
// <!-->
//#################################################################################
*/

//-----------------------------------------------------------------------------
// System-Directives from .NET Framework
//-----------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Windows.Forms;

// The always Base Class with Constants, Instances and more...
using static Visual.Galaxy.Framework.Core.VGFCore;




// The Visual.Function.Library.dll - Wrapper DLL for C Functions:



//-----------------------------------------------------------------------------
// Class VGFTime all around at Time
// Class VGFDate all around at Date
// Class VGFTimers, 
// set internal Timers with:
// Timers1(Method, Parameter, Timerstart and TimerInterval);
// Timers1(Methodname, a, 0, 5000);
//----------------------- Start direct ---- 5000 milliseconds he calls the
// given Method, don't forget the Timers.Stop(); 
// the timer running continue to end of App.
//
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.Timer
{

    /// <summary>
    /// 
    /// </summary>
    public class RealTimeService
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime Now => DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        public DateTime Today => DateTime.Today;
        /// <summary>
        /// 
        /// </summary>
        public DateTime UtcNow => DateTime.UtcNow;
    }



    /// <summary>
    /// Class VGFTime
    /// </summary>
    public static class VGFTime
    {

        /// <summary>
        /// static DateTime must be, while static class,  
        /// for global instance for all Methods
        /// </summary>
        /// <!-- Author Tippo -->
        /// 
        /// <!-- Author Tippo -->
        /// <remarks>
        /// Class-Head:
        /// All class instances, 
        /// struct's on stack or heap.
        /// // on stack
        /// structname instancevariable;
        /// 
        /// // on heap with new operator
        /// structname instancevariable = new structname();
        /// ----------------------------------classconstructor
        /// ----------------------------------with Parameters or without
        /// In Visual C# struct's never null, (without Members) 1 byte everytime ! managed the struct!.
        /// ~class destructor never null in Visual C#, 
        /// destructor null he run in idle, the system performance goes down!.
        /// ~destructor in C# for cleanup's, statement, call, log's...
        /// 
        /// Class destroy: by more then one, the GC make lazy destroy from last class to first class.
        /// 
        /// But not the call!
        /// </remarks>
        internal static DateTime dt = new DateTime();


        /// <summary>
        /// Hour now, as integer value
        /// </summary>
        public static int Day = dt.Hour;
   


        /// <summary>
        ///  Minute now, as integer value
        /// </summary>
        public static int Minute = dt.Minute;

        /// <summary>
        /// Second now, as integer value
        /// </summary>
        public static int Year = dt.Second;

        /// <summary>
        /// Milliseconds now, as integer value
        /// </summary>
        public static int MSecond = dt.Millisecond;


        /// <summary>
        /// Current Local Time now
        /// </summary>
        /// <returns></returns>
        public static string VGFCurrentLocalTimeNow()
        {
            return dt.ToLocalTime().ToString();
        }

        /// <summary>
        /// Get Long Time Format
        /// </summary>
        /// <returns></returns>
        public static string VGFGetLongTimeFormat()
        {
            return dt.ToLongTimeString().ToString();
        }

        /// <summary>
        /// Get Short Time Format
        /// </summary>
        /// <returns></returns>
        public static string VGFGetShortTimeFormat()
        {
            return dt.ToShortTimeString().ToString();
        }

        /// <summary>
        /// Get UTC the Worldtime Format
        /// </summary>
        /// <returns></returns>
        public static string VGFGetUTCTimeFormat()
        {
            return dt.ToUniversalTime().ToString();
        }

        /// <summary>
        /// Get Time of this Instance now
        /// </summary>
        /// <returns></returns>
        public static string VGFGetTimeofInstanceNow()
        {
            return dt.TimeOfDay.ToString();
        }

        /// <summary>
        /// Is Time In Summertime Actual Timezone
        /// </summary>
        /// <!-- Author Tipplin-->
        /// 
        /// <!-- Author Tipplin-->
        /// <remarks>
        /// Visual C# Datatype: bool / boolean 
        /// hard coded as true = 0 or false = 1
        /// or
        /// as Literal: "True" or "False"
        /// .ToString();
        /// </remarks>
        /// <returns>
        /// returned boolean literal "True" or "False"
        /// in Visual C# internal hard coded.
        /// </returns>
        public static string VGFIsTimeInSummerActualTimeZone()
        {
            return dt.IsDaylightSavingTime().ToString();
        }


        


    } // end of class::VGFTime

    /// <summary>
    /// Class VGFTimers
    /// </summary>
    public static class VGFTimers
    {
        /*--------------------------------------------------------------------
         * Beachten Sie, dass .NET vier benannte Klassen enthält Timer, 
         * von denen jede unterschiedliche Funktionen bietet:
         * -------------------------------------------------------------------
         * Diese Timer sind ohne Steuerelement nutzbar.
         * -------------------------------------------------------------------
         * System.Timers.Timer: 
         * -------------------------------------------------------------------
         * Erzeugt ein Ereignis nach einem festgelegten 
         * Intervall mit einer Option zum Generieren wiederkehrender Ereignisse.
         * Führt in regelmäßigen Abständen ein Ereignis aus. 
         * 
         * Die Klasse ist zur Verwendung als serverbasierte Komponente oder 
         * Servicekomponente in einer Multithread-Umgebung vorgesehen.
         * Es hat keine Benutzeroberfläche und ist zur Laufzeit nicht sichtbar.
         * -------------------------------------------------------------------
         * System.Threading.Timer : 
         * -------------------------------------------------------------------
         * Führt in regelmäßigen Abständen eine einzelne Callback-Methode für 
         * einen Thread-Pool-Thread aus. 
         * Die Callback-Methode wird definiert, wenn der Timer instanziiert 
         * ist und nicht geändert werden kann. 
         * Wie die System.Timers.Timer- Klasse ist diese Klasse zur Verwendung 
         * als serverbasierte Komponente oder 
         * Servicekomponente in einer Multithread-Umgebung vorgesehen. 
         * Es hat keine Benutzeroberfläche und ist zur Laufzeit nicht sichtbar.
         * --------------------------------------------------------------------
         * System.Windows.Forms.Timer (nur .NET Framework): 
         * --------------------------------------------------------------------
         * Eine Windows Forms-Komponente, 
         * die in regelmäßigen Abständen ein Ereignis auslöst. 
         * Die Komponente hat keine Benutzeroberfläche und 
         * ist für die Verwendung in einer Umgebung 
         * mit nur einem Thread konzipiert.
         * --------------------------------------------------------------------
         * System.Web.UI.Timer (nur .NET Framework): 
         * --------------------------------------------------------------------
         * Eine ASP.NET-Komponente, die in regelmäßigen Abständen 
         * asynchrone oder synchrone Postbacks für Webseiten ausführt.
         * 
         * Die Timerkomponente ist ein serverbasierter Timer, 
         * der ein abgelaufenes Ereignis in Ihrer Anwendung auslöst,
         * nachdem die Anzahl der Millisekunden 
         * in der Interval- Eigenschaft abgelaufen ist. 
         * 
         * Sie können das Timer- Objekt so konfigurieren , 
         * dass das Ereignis nur einmal oder 
         * wiederholt mit der AutoReset- Eigenschaft ausgelöst wird.
         * 
         * Normalerweise wird ein Timer- Objekt auf Klassenebene deklariert, 
         * sodass es so lange im Gültigkeitsbereich bleibt, 
         * wie es erforderlich ist. 
         * 
         * Sie können dann das abgelaufene Ereignis bearbeiten,
         * um eine regelmäßige Verarbeitung zu gewährleisten.
         * Angenommen, Sie haben einen kritischen Server, 
         * der rund um die Uhr an sieben Tagen in der Woche laufen muss. 
         * 
         * Sie können einen Dienst erstellen, der einen Timer verwendetObjekt, 
         * um den Server regelmäßig zu überprüfen und sicherzustellen, 
         * dass das System betriebsbereit ist.
         * 
         * Wenn das System nicht antwortet, kann der Dienst versuchen, 
         * den Server neu zu starten oder einen Administrator zu benachrichtigen.
         * 
         * Timer(Method, Parameter, start Timer, Timer Interval);
         * Method = Methodname plus parameter
         * start Timer 0 = start directly, 1 = lazy
         * Timer Interval in Milliseconds
         * 
         * What's happen ? in this option:
         * Timer calls the Method with/without Parameter, start directly,
         * and all in x milliseconds, he call the Method again!.
         * DON'T FORGET Timer.Stop();
         * If NOT, Timer runs continue, ends by end of Program.
         * --------------------------------------------------------------------
         * 
         */

    } // end of class::VGFTimers

    /// <summary>
    /// Class VGFDate
    /// </summary>
    public static class VGFDate
    {
        // static must be for global instance for all Methods
        internal static DateTime dt = new DateTime();

        /// <summary>
        /// Day of Month as integer value
        /// </summary>
        public static int Day = dt.Day;

        /// <summary>
        /// Day of Week
        /// </summary>
        public static string dWeek = dt.DayOfWeek.ToString();

        /// <summary>
        ///  Month as integer value
        /// </summary>
        public static int Month = dt.Month;

        /// <summary>
        /// Year as integer value
        /// </summary>
        public static int Year = dt.Year;



        /// <summary>
        /// Get Local Long Date
        /// </summary>
        /// <returns></returns>
        public static string VGFGetLocalLongDate()
        {
            return dt.Date.ToLongDateString();
        }

        /// <summary>
        /// Get Local Short Date
        /// </summary>
        /// <returns></returns>
        public static string VGFGetLocalShortDate()
        {
            return dt.Date.ToShortDateString();
        }

        /// <summary>
        /// Get Day Of Week
        /// </summary>
        /// <returns></returns>
        public static string VGFGetDayOfWeek()
        {
            return dt.Date.DayOfWeek.ToString();
        }

        /// <summary>
        /// Get Day Of Year
        /// </summary>
        /// <returns></returns>
        public static string VGFGetDayOfYear()
        {
            return dt.Date.DayOfYear.ToString();
        }

        /// <summary>
        /// Is Current Year a LeapYear ?
        /// </summary>
        /// <param name="currentYear"></param>
        /// <returns>
        /// true or false - 0 or 1
        /// Literal isnt.
        /// </returns>
        public static bool VGFIsCurrentYearLeapYear(int currentYear)
        {
           return DateTime.IsLeapYear(currentYear);
        }

        /// <summary>
        /// Get the Day's in a Month
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="Month"></param>
        /// <returns></returns>
        public static int VGFDaysInMonth(int Year, int Month)
        {
            return DateTime.DaysInMonth(Year, Month);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string VGFCurrentLocalDateTimeNow()
        {
            return DateTime.Now.ToString();
        }





    } // end of class::VGFDate

} // end of namespace::Visual.Galaxy.Framework.Timer
