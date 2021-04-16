/*#############################################################################
 * 
 * Project			:	Visual.Galaxy.Framework
 * 
 * ############################################################################
 * 
 * ----------------------------------------------------------------------------
 * Programmer       :	Project-Founder and Main-Author Christian "Tipplin" Kurs
 * ----------------------------------------------------------------------------
 * Part				:	VGF.WorldwideHolidays
 * ----------------------------------------------------------------------------
 * Base Class       :	
 * ----------------------------------------------------------------------------
 * Copyright © 2020 by  Visual Galaxy Framework Community Kernel Developer Team
 * ----------------------------------------------------------------------------
 * Project-Maintainer and
 * Head-Author: Christian "Tipplin" Kurs - Visual C# Developer
 * ----------------------------------------------------------------------------
 * Portions Copyright © 2020 by Microsoft Corporation GmbH.
 * ----------------------------------------------------------------------------
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
 * © 1982 - 2019 Microsoft Corporation.All rights reserved.
 * ----------------------------------------------------------------------------
 * Same sourcecode by Microsoft, so we marked with Copyright !.
 * © 1982 - 2019 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
 * Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
 * ----------------------------------------------------------------------------
 * DON'T CHANGE OR DELETE ANYTHING IN SECTION !!!.
 * ----------------------------------------------------------------------------
 * VFGCore written by
 *                      Christian "Tipplin" Kurs
 *                      Nettweg 1
 *                      - G -  53498 Bad Breisig
 *                      Germany - Allemagne - Duitsland
 * ----------------------------------------------------------------------------
 * voice                02633 - 470736  
 * international phone  00-49-2633-470736
 * Skype
 * E-mail               kurschristian@gmail.de
 * Community Website    http://www.vgfc.org/community/Tipplin
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
 * Copyright © 2019 by Christian 'Tipplin' Kurs - Germany
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

/*-----------------------------------------------------------------------------
* Visual Galaxy Framework - Project-Solution 
* other Directives from other Visual C# Files .cs:
* If class static so set using static <namespacename><classname>
*
-----------------------------------------------------------------------------*/


//-----------------------------------------------------------------------------
// static class VGFCore: Global Constants, variables, instances
//-----------------------------------------------------------------------------
using static Visual.Galaxy.Framework.VGFCore;

//-----------------------------------------------------------------------------
// static class VGFLogger:
//-----------------------------------------------------------------------------
using static Visual.Galaxy.Framework.Logging.VGFLogger;

//-----------------------------------------------------------------------------
// Methods from Visual.Function.Library.dll written in C.
//-----------------------------------------------------------------------------


//-----------------------------------------------------------------------------
// static class VOSInternalUtilities:
//-----------------------------------------------------------------------------
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;


using static Visual.Operation.System.Native.UnsafeNativeMethods;






/*-----------------------------------------------------------------------------
 * World Wide Holidays for 63 Countries, Europe, North America,
 * For Germany Holiday - Wikipedia
 * Fixed Holidays with fixed Date and mobile Holidays with various Date.
 * ----------------------------------------------------------------------------
 * Germany: 
 * All German Holidays are translate in English,
 * source: 
 * Langenscheidt Publishing, 
 * the German and Englisch Commission in London:
 * many german words translate in english.
 * ----------------------------------------------------------------------------
 * Langenscheidt Translate German/English:
 * Brötchen - Rolls
 * near London a 'Great German Bakery' - 150 Sales Cars delivery near England
 * London Stock, break best Pumpernickel and Rolls.
 * ----------------------------------------------------------------------------
 * London:
 * Three Languages for Shields:
 * ----------------------------------------------------------------------------
 * To the Subway - english
 * Zur U-Bahn - german
 * au métro - frensh
 * ----------------------------------------------------------------------------
 * some tram driver speaks german, one was in Berlin by BVG, returns to London,
 * now, return to Berlin. (born in London)
 * ----------------------------------------------------------------------------
 * City Part New Paltz in New York: 
 * ================================
 * (Neue Pfalz - German Migrations of Rhineland Palatine for 300 years)
 * 
 * Susanne Nett German TV in New Paltz - Saumagen - is good!
 * German Teacher (US-Member): "Kann's mit mir deutsch schwätze"
 * ----------------------------------------------------------------------------
 * Pennsylvania Dutch - is Paltz Dialect == German Language, no nederlands!
 * Video YouTube
 * ----------------------------------------------------------------------------
 * Map of State Minneapolis - German Cities: 
 * Hamburg, NewUlm, Cologne, Heidelberg, Flensburg
 * 
 * State OHIO - Cologne - Inn with Früh-Kölsch.
 * ----------------------------------------------------------------------------
 * Cologne Brewery 'Früh Kölsch' in Germany delivery the World.
 * New Big Brewery outside Cologne City.
 * ----------------------------------------------------------------------------
 * Delivery the German "Reichstag" Buildung/Restaurant in Berlin, any Week,
 * but only Beer Bottles.
 * 
 * All Cologne/Rhineland specials in 'Rheinische Vertretung' in Berlin.
 * Oberbaumbrücke
 * Halver Hahn, Frikadellen, Kölsch...
 * ----------------------------------------------------------------------------
 * Windows 10 Professional have Language Dictionaries as package download,
 * current German/English in all Programs available, spelling, orthography
 * automatic correct words "SWIFTKEY", 
 * suggested words in an black field right corner,
 * Windows 10 have now inside AI / KI support by Inputs.
 * ----------------------------------------------------------------------------
 * ----------------------------------------------------------------------------
 * Translate German Holidays - German to English
 * ----------------------------------------------------------------------------
 * Pfingsten ----------- Whitsun
 * Pfingst Sonntag ----- Whit Sunday
 * Pfingst Montag ------ Whit Monday
 * Ostern -------------- Eastern
 * Ostersonntag -------- Eastern Sunday
 * Ostermontag --------- Eastern Monday
 * Osterei ------------- Easter Egg
 * Karfreitag ---------- Good Friday
 * Christi Himmelfahrt - Corpus Christi
 * Allerheiligen ------- All Saints
 * Allerseelen --------- All Souls
 * Heiligabend --------- Christmas Eve
 * Weihnachtsmann ------ Father Christmas
 * ----------------------------------------------------------------------------
 * fixed holidays
 * ----------------------------------------------------------------------------
 * 
 * German------------------------------English
 * Neujahr --------------------------- New Year
 * 
 * bewegliche Feiertage / mobile holidays
 * ----------------------------------------------------------------------------
 * HeiligeDreiKönige, ever 06.01 ----- Epiphany
 * Valentinstag, ever 14.02 ---------- ValentinesDay
 * RosenMontag, ---------------------- RoseMonday
 * FaschingsDienstag, ---------------- ShroveTuesday
 * Aschermittwoch, ------------------- AshWednesday
 * GrünDonnerstag, ------------------- MaundyThursday
 * Karfreitag, ----------------------- GoodFriday
 * OsterSonntag, --------------------- EasterSunday
 * OsterMontag, ---------------------- EasterMonday
 * Muttertag, ------------------------ MothersDay
 * TagDerArbeit, --------------------- DayWork
 * ChristiHimmelfahrt, --------------- Ascension
 * 
 * PfingstMontag, -------------------- WhitMonday
 * PfingstSonntag, ------------------- WhitSunday
 * Fronleichnam, --------------------- CorpusChristi
 * AugsburgerFriedensfest, ----------- AugsburgPeaceFestival
 * MariaHimmelfahrt, ----------------- Assumption
 * TagDerDeutschenEinheit, ----------- DayOfGermanUnity
 * Reformationstag, ------------------ ReformationDay
 * Allerheiligen, -------------------- AllSaints
 * Allerseelen ----------------------- AllSouls *
 * BußUndBettag, --------------------- RepentanceAndPrayer
 * Nikolaus, ------------------------- Nicolas
 * ErsterAdvent, --------------------- FirstAdvent
 * ZweiterAdvent, -------------------- SecondAdvent
 * DritterAdvent, -------------------- ThirdAdvent
 * VierterAdvent, -------------------- FourthAdvent
 * Heiligabend, ---------------------- ChristmasEve
 * ErsterWeihnachtsfeiertag, --------- ChristmasEve
 * ZweiterWeihnachtsfeiertag, -------- SecondDayOfChristmas
 * Sylvester, ------------------------ Sylvester
 * KeinFeiertag ---------------------- NoHoliday
 *  
 * ----------------------------------------------------------------------------
 * Germany Special Holidays for City and Regions:
 * ----------------------------------------------------------------------------
 * ----------------------------------------------------------------------------
 * City of Augsburg - Augsburger Friedensfest
 * ----------------------------------------------------------------------------
 * 
 * Landkreis Bautzen:
 * ============================================================================
 * Bautzen (nur in den Ortsteilen Bolbritz und Salzenforst), 
 * Crostwitz, Göda (nur im Ortsteil Prischwitz), 
 * 
 * Großdubrau (nur im Ortsteil Sdier), 
 * Hoyerswerda (nur im Ortsteil Dörgenhausen),
 * 
 * Königswartha (nicht im Ortsteil Wartha), Nebelschütz, 
 * Neschwitz (nur in den Ortsteilen Neschwitz und Saritsch), 
 * 
 * Panschwitz-Kuckau, Puschwitz, Räckelwitz, Radibor, 
 * Ralbitz-Rosenthal und Wittichenau."
 * 
 * Unstrut-Hainich-Kreis:
 * CorpusChristi
 * 
 * In Anrode (nur in den Ortsteilen Bickenriede und Zella), 
 * Dünwald (nur in den Ortsteilen Beberstedt und Hüpstedt), 
 * Rodeberg (nur im Ortsteil Struth), Südeichsfeld",
 * -----------------------------------------------------------------------------
 * Berlin:
 * ❗ New 2019 ❗
 * Frauentag / Womensday
 * -----------------------------------------------------------------------------
 * Wartburgkreis:
 * CorpusChristi
 * In Brunnhartshausen (nur in den Ortsteilen Föhlritz und Steinberg),
 * Buttlar, Geisa, Schleid, Zella/Rhön
 * -----------------------------------------------------------------------------
 * 
 * 
 * 
 * 
 * 
 * ----------------------------------------------------------------------------
 */
namespace Visual.Galaxy.Framework.Worldwide.Holidays
{

    /// <summary>
    /// Class Worldwide Holidays
    /// </summary>
    /// <!-- Author Tipplin -->
    /// First set German Holidays, but correct same German Holidays there are failed.
    /// Set German Holidays movable and fixed Holidays.
    /// other Formuale
    /// Meeuws
    /// T.H. O' Beirne
    /// Bresenham
    /// <!-- Author Tipplin -->
    /// <remarks>
    /// source part:
    /// Take from C# Holiday Framework - Thomas Gianini
    /// 63 Countries, Europe and North America.
    /// Use for Holidays Calculation.
    /// But he forgot German Days:
    /// Totensonntag, Volkstrauertag,
    /// </remarks>
    public static class VGFWorldwideHolidays
    {

        #region ### AUSTRIA HOLIDAYS ###



        #endregion

        #region ### SWITZERLAND HOLIDAYS ###



        #endregion

        #region ### BELGIUM HOLIDAYS ###



        #endregion

        #region ### DENMARK HOLIDAYS ###



        #endregion

        #region ### SPAIN HOLIDAYS ###



        #endregion

        #region ### FRANCE HOLIDAYS ###



        #endregion





        /**********************************************************************
         * Germany Holidays
         * Fixed days:
         * --------------------------------------------------------------------
         * 01.01.
         * 06.01.
         * 01.05.
         * 15.08.
         * 03.10.
         * 31.10.
         * 01.11.
         * 25.12.
         * 26.12.
         * 
         * mobile days:
         * ---------------------------------------------------------------------
         * 
         * 
         * 
         **********************************************************************/


        #region ### GERMANY HOLIDAYS ###

        /// <summary>
        /// German Calendar Calculator
        /// Translate German States and Federal Name to Englisch,
        /// help by NEW Langenscheidt German/English Book.
        /// German/English Commission,
        /// translate same German Special Words to English
        /// Brötchen = roll,
        /// 
        /// </summary>
        public class GermanCalendarCalculator
        {

            /// <summary>
            ///  Actual Federal State of Germany
            /// </summary>
            public FederalStatesGermany _FederalState;
            
            /// <summary>
            /// Matrix der Feiertage pro Bundesland
            /// </summary>
            public Dictionary<FederalStatesGermany, List<GermanHolidays>> _holidayMatrix;
            
            /*
             * create the compiler two automatic properties
             */
            /// <summary>
            /// // Flag ob Samstag als Arbeitstag zählt
            /// </summary>
            private bool _saturday_IsWorkday;
            
            /// <summary>
            /// // Flag ob Sonntag als Arbeitstag zählt
            /// </summary>
            private bool _sundayIsWorkday;



            /// <summary>
            /// Class Construtor with Info
            /// </summary>
            static GermanCalendarCalculator()
            {
                VFLMsgBox("Hello in my Wonderful Worldwide Holiday Calendar", "VGF::German Calendar Calculator", STYLES.OkOnly | STYLES.Information | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
            }



            /// <summary>
            /// Class Constructor Standard
            /// </summary>
            internal GermanCalendarCalculator()
            {
                this._FederalState = FederalStatesGermany.DeutschlandGesamt;
                this._holidayMatrix = new Dictionary<FederalStatesGermany, List<GermanHolidays>>();
                this._saturday_IsWorkday = false;
                this._sundayIsWorkday = false;

                // Method initializing
                InitMatrixFederalStates();
            }

            /// <summary>
            /// Class Constructor with Parameter
            /// </summary>
            /// <param name="federalState"></param>
            internal GermanCalendarCalculator(FederalStatesGermany federalState) : this()
            {
                _FederalState = federalState;
            }


            /// <summary>
            /// Federal States of Germany
            /// </summary>
            /// <!-- Author Tipplin -->
            /// First I set the Federal States in German Language,
            /// after test I change to English.
            /// <!-- Author Tipplin -->
            public enum FederalStatesGermany
            {
                /// <summary>
                /// Germany total
                /// </summary>
                DeutschlandGesamt,
                /// <summary>
                /// Bavaria - short Federal State BY
                /// </summary>
                Bayern,
                /// <summary>
                /// Baden Wuerttemberg - short Federal State BW
                /// </summary>
                BadenWürtemberg,
                /// <summary>
                /// Berlin - short Federal State BE
                /// </summary>
                Berlin,
                /// <summary>
                /// Brandenburg - short Federal State BB
                /// </summary>
                Brandenburg,
                /// <summary>
                /// Bremen - short Federal State HB
                /// Hanseatic city
                /// </summary>
                Bremen,
                /// <summary>
                /// Hamburgs - short Federal State HH
                /// Hanseatic city
                /// </summary>
                Hamburg,
                /// <summary>
                /// Hesse - short Federal State HE
                /// </summary>
                Hessen,
                /// <summary>
                /// Mecklenburg Western Pomerania - short Federal State MV
                /// </summary>
                MecklenburgVorpommern,
                /// <summary>
                /// Lower Saxony - short Federal State NI
                /// </summary>
                Niedersachsen,
                /// <summary>
                /// North Rhine Westphalia - short Federal State NW
                /// </summary>
                NordrheinWestfalen,
                /// <summary>
                /// Rhineland Palatinate - short Federal State RP
                /// </summary>
                RheinlandPfalz,
                /// <summary>
                /// Saarland - short Federal State SL
                /// </summary>
                Saarland,
                /// <summary>
                /// Saxony - short Federal State SN - only Federal State RepentanceAndPrayer/Buß und Bettag
                /// </summary>
                Sachsen,
                /// <summary>
                /// Saxony-Anhaltine - short Federal State ST
                /// </summary>
                SachsenAnhalt,
                /// <summary>
                /// Schleswig Holstein - short Federal State SH
                /// </summary>
                SchleswigHolstein,
                /// <summary>
                /// Thuringia - short Federal State TH
                /// </summary>
                Thüringen
            };

            /// <summary>
            /// German Holidays
            /// Langenscheidt English/German Commission
            /// Goes german word to english.
            /// Brötchen in english rolls
            /// 
            /// near London an great German Bakery with 150 sale cars.
            /// stand in London by Stock change, best yet rolls and pumpernickel.
            /// Next German Christmas Market in same Cities in England,
            /// Sausages, Frankurter, grilled sausages, (glühwein) mulled wine with alcohol,
            /// Frankfurter green sauce.
            /// </summary>
            public enum GermanHolidays
            {
                /// <summary>
                /// Neujahr
                /// </summary>
                NewYear,
                /// <summary>
                /// Heiligen Drei Könige
                /// </summary>
                Epiphany,
                /// <summary>
                /// Valentins Tag
                /// </summary>
                ValentinesDay,
                /// <summary>
                /// Rosenmontag
                /// </summary>
                RoseMonday,
                /// <summary>
                /// Fasching Dienstag
                /// </summary>
                ShroveTuesday,
                /// <summary>
                /// Aschermittwoch
                /// </summary>
                AshWednesday,
                /// <summary>
                /// Gründonnerstag
                /// </summary>
                MaundyThursday,
                /// <summary>
                /// Karfreitag
                /// </summary>
                GoodFriday,
                /// <summary>
                /// Ostern / Eastern / Osterei / Easteregg
                /// Oster Sonntag
                /// </summary>
                EasterSunday,
                /// <summary>
                /// Oster Montag
                /// </summary>
                EasterMonday,
                /// <summary>
                /// Muttertag
                /// </summary>
                MothersDay,
                /// <summary>
                /// 1. Mai - Tag der Arbeit
                /// </summary>
                DayWork,
                /// <summary>
                /// Christi Himmelfahrt
                /// </summary>
                Ascension,
                /// <summary>
                /// Pfingst Sonntag
                /// </summary>
                WhitSunday,
                /// <summary>
                /// Pfingst Montag
                /// </summary>
                WhitMonday,
                /// <summary>
                /// Fronleichnam
                /// </summary>
                CorpusChristi,
                /// <summary>
                /// Augsbuger Friedenfest
                /// </summary>
                AugsburgPeaceFestival,
                /// <summary>
                /// Erntedankfest
                /// </summary>
                ThanksgivingDay,
                /// <summary>
                /// Maria Himmelfahrt
                /// </summary>
                Assumption,
                /// <summary>
                /// Tag der Deutschen Einheit
                /// </summary>
                DayOfGermanUnity,
                /// <summary>
                /// Reformationtag
                /// </summary>
                Reformation,
                /// <summary>
                /// Allerheiligen
                /// </summary>
                AllSaints,
                /// <summary>
                /// Allerseelen
                /// </summary>
                AllSouls,
                /// <summary>
                /// Martinstag
                /// </summary>
                Martinmas,
                /// <summary>
                /// Volkstrauertag
                /// </summary>
                MemorialDay,
                /// <summary>
                /// Totensonntag
                /// </summary>
                Deadsunday,
                /// <summary>
                /// Maria Emfängnis
                /// </summary>
                ImmaculateConception,
                /// <summary>
                /// Buß und Bettag
                /// </summary>
                RepentanceAndPrayer,
                /// <summary>
                /// Nikolaustag
                /// </summary>
                Nicolas,
                /// <summary>
                /// Erster Advent
                /// </summary>
                FirstAdvent,
                /// <summary>
                /// Zweiter Advent
                /// </summary>
                SecondAdvent,
                /// <summary>
                /// Dritter Advent
                /// </summary>
                ThirdAdvent,
                /// <summary>
                /// Vierter Advent
                /// </summary>
                FourthAdvent,
                /// <summary>
                /// Heiligabend
                /// </summary>
                ChristmasEve,
                /// <summary>
                /// 1. Weihnachtstag
                /// </summary>
                ChristmasDay,
                /// <summary>
                /// 2. Weihnachtstag
                /// </summary>
                SecondDayOfChristmas,
                /// <summary>
                /// Sylvester
                /// </summary>
                Sylvester,
                /// <summary>
                /// Kein Feiertag
                /// </summary>
                NoneHoliday
            };

            /// <summary>
            /// Calculates the number of actual working days
            /// Berechnet die Anzahl tatsächlicher Arbeitstage
            /// </summary>
            /// <!-- Author Tipplin -->
            /// NOTE: ❌The Gauss Formuale goes incorrect, ❌
            /// The gauss formula is incorrect, makes false statements, means deviations
            /// 
            /// use the Meeuw Formuale -Math. Belgium-
            /// 
            /// <!-- Author Tipplin -->
            /// <param name="dtBeginDate"></param>
            /// <param name="dtEndDate"></param>
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public uint GetWorkdays(DateTime dtBeginDate, DateTime dtEndDate)
            {
                uint iDays;                                    // Anzahl Tage Brutto zwischen Beginn- und Endedatum
                byte iDayCount;                                // Zähler für Wochentage (0 = Sonntag, 1 = Montag etc., angelehnt an DayOfWeek Enum)
                int iYear;                                     // Zähler für Jahre       
                uint Workdays;                             // Anzahl Arbeitstage
                DateTime dtHoliday;                           // Datum akt. Feiertag
                TimeSpan tsTicks;                              // Differenz Beginndatum/Endedatum in Ticks 
                uint[] aWeekdays = { 0, 0, 0, 0, 0, 0, 0 };    // Array mit Anzahl der Wochentage (Index 0 = alle Sonntage, 1 = alle Montage etc.)

                tsTicks = new TimeSpan(dtEndDate.Ticks - dtBeginDate.Ticks);
                iDays = (uint)(tsTicks.TotalDays + 1);         // Anzahl der Tage Brutto ermitteln
                iDayCount = (byte)Math.Min(iDays - 1, 6);      // Falls Zeitraum kleiner 1 Woche

                for (int i = 0; i <= iDayCount; i++)           // Hier wird die Anzahl der jeweiligen Wochentage des Zeitraumes 
                {                                              // in das Wochentage-Array übertragen
                    aWeekdays[(int)(dtBeginDate.AddDays(i).DayOfWeek)] = (uint)((iDays - i) / 7) + 1;
                }

                // Vom Folgewochentag des Ende-Datums wird immer ein Tag zuviel berechnet, deshalb Korrektur
                aWeekdays[(int)dtEndDate.DayOfWeek < (int)DayOfWeek.Saturday ? (int)dtEndDate.DayOfWeek + 1 : (int)DayOfWeek.Sunday]--;

                // Alle Jahre durchlaufen und Feiertage abziehen
                for (iYear = (ushort)dtBeginDate.Year; iYear <= (ushort)dtEndDate.Year; iYear++)
                {
                    foreach (GermanHolidays holiday in this._holidayMatrix[this._FederalState])
                    {
                        dtHoliday = GetHolidayDate(holiday, iYear);

                        if (dtHoliday >= dtBeginDate && dtHoliday <= dtEndDate)
                        {
                            if (holiday == GermanHolidays.FourthAdvent && this._holidayMatrix[this._FederalState].Contains(GermanHolidays.ChristmasEve) &&
                                dtHoliday.DayOfWeek == DayOfWeek.Sunday)
                                continue;                      // Wenn vierter Advent gleich Heiligabend und beide sind Feiertage: Nur einmal abziehen!

                            aWeekdays[(int)dtHoliday.DayOfWeek]--;
                        }
                    }
                }

                // Arbeitstage zusammenzählen
                Workdays = aWeekdays[(int)DayOfWeek.Monday] + aWeekdays[(int)DayOfWeek.Tuesday] + aWeekdays[(int)DayOfWeek.Wednesday] +
                               aWeekdays[(int)DayOfWeek.Thursday] + aWeekdays[(int)DayOfWeek.Friday];

                if (SaturdayIsWorkday)
                {
                    Workdays += aWeekdays[(int)DayOfWeek.Saturday];
                }

                if (SundayIsWorkday)
                {
                    Workdays += aWeekdays[(int)DayOfWeek.Sunday];
                }

                return (Workdays);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="dtDate"></param>
            /// <returns></returns>
            public bool IsHoliday(DateTime dtDate)
            {
                foreach (GermanHolidays holiday in this._holidayMatrix[this._FederalState])
                {
                    if (dtDate == GetHolidayDate(holiday, dtDate.Year))
                        return (true);
                }
                return (false);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="dtDate"></param>
            /// <returns></returns>
            public GermanHolidays GetHolidayName(DateTime dtDate)
            {
                foreach (GermanHolidays holiday in this._holidayMatrix[this._FederalState])
                {
                    if (dtDate == GetHolidayDate(holiday, dtDate.Year))
                        return (holiday);
                }
                return (GermanHolidays.NoneHoliday);
            }

            /// <summary>
            /// Get Holiday Date
            /// </summary>
            /// <!-- Author Tipplin -->
            /// Unchecked Formulare, Gauss Formulare goes uncorrectness,
            /// change to Meeuws (Belgian Mathe.) Formulare is correctness
            /// <!-- Author Tipplin-->
            /// <param name="holiday"></param>
            /// <param name="iYear"></param>
            /// <returns></returns>
            public DateTime GetHolidayDate(GermanHolidays holiday, int iYear)
            {
                DateTime dtOstern;                           // Datum Ostersonntag
                DateTime dtFeiertag = new DateTime(0);       // Datum des Feiertags

                dtOstern = GetEasterSunday(iYear);

                int osterKennzahl = dtOstern.Day - 1 + (dtOstern.Month * 31);
                int adventMuttertagKennzahl = (iYear - 1 + iYear / 4) % 7;

                switch (holiday)
                {
                    case GermanHolidays.NewYear:
                        dtFeiertag = new DateTime(iYear, 1, 1);                      // Neujahr
                        break;
                    case GermanHolidays.Assumption:
                        dtFeiertag = new DateTime(iYear, 1, 6);                      // Hl. Drei Könige
                        break;
                    case GermanHolidays.ValentinesDay:
                        dtFeiertag = new DateTime(iYear, 2, 14);                     // Valentinstag
                        break;
                    case GermanHolidays.RoseMonday:
                        dtFeiertag = dtOstern.AddDays(-48);                          // Rosenmontag
                        break;
                    case GermanHolidays.ShroveTuesday:
                        dtFeiertag = dtOstern.AddDays(-47);                          // Fachingsdienstag
                        break;
                    case GermanHolidays.AshWednesday:
                        dtFeiertag = dtOstern.AddDays(-46);                          // Aschermittwoch
                        break;
                    case GermanHolidays.MaundyThursday:
                        dtFeiertag = dtOstern.AddDays(-3);                           // Gründonnerstag
                        break;
                    case GermanHolidays.GoodFriday:
                        dtFeiertag = dtOstern.AddDays(-2);                           // Karfreitag
                        break;
                    case GermanHolidays.EasterSunday:
                        dtFeiertag = dtOstern;                                       // Ostersonntag
                        break;
                    case GermanHolidays.EasterMonday:
                        dtFeiertag = dtOstern.AddDays(1);                            // Ostermontag
                        break;
                    case GermanHolidays.MothersDay:
                        dtFeiertag = new DateTime(iYear, 5, 14 - adventMuttertagKennzahl);   // Muttertag
                        break;
                    case GermanHolidays.DayWork:
                        dtFeiertag = new DateTime(iYear, 5, 1);                      // 1. Mai
                        break;
                    case GermanHolidays.Ascension:
                        dtFeiertag = dtOstern.AddDays(39);                           // Christi Himmelfahrt
                        break;
                    case GermanHolidays.WhitSunday:
                        dtFeiertag = dtOstern.AddDays(49);                           // Pfingstsonntag
                        break;
                    case GermanHolidays.WhitMonday:
                        dtFeiertag = dtOstern.AddDays(50);                           // Pfingstmontag
                        break;
                    case GermanHolidays.CorpusChristi:
                        dtFeiertag = dtOstern.AddDays(60);                           // Fronleichnam
                        break;
                    case GermanHolidays.AugsburgPeaceFestival:
                        dtFeiertag = new DateTime(iYear, 8, 8);                      // Augsburger Friedensfest
                        break;
                    case GermanHolidays.DayOfGermanUnity:
                        dtFeiertag = new DateTime(iYear, 10, 3);                     // Dt. Einheit
                        break;
                    case GermanHolidays.AllSaints:
                        dtFeiertag = new DateTime(iYear, 11, 1);                     // Allerheiligen
                        break;
                    case GermanHolidays.RepentanceAndPrayer:
                        dtFeiertag = new DateTime(iYear, 11, 16 + (osterKennzahl % 7));  // Buß- und Bettag
                        break;
                    case GermanHolidays.Nicolas:
                        dtFeiertag = new DateTime(iYear, 12, 6);                     // Nikolaus
                        break;
                    case GermanHolidays.FirstAdvent:
                        dtFeiertag = new DateTime(iYear, 12, 24 - adventMuttertagKennzahl).AddDays(-21);   // Erster Advent
                        break;
                    case GermanHolidays.SecondAdvent:
                        dtFeiertag = new DateTime(iYear, 12, 24 - adventMuttertagKennzahl).AddDays(-14);   // Zweiter Advent
                        break;
                    case GermanHolidays.ThirdAdvent:
                        dtFeiertag = new DateTime(iYear, 12, 24 - adventMuttertagKennzahl).AddDays(-7);    // Dritter Advent
                        break;
                    case GermanHolidays.FourthAdvent:
                        dtFeiertag = new DateTime(iYear, 12, 24 - adventMuttertagKennzahl);                // Vierter Advent
                        break;
                    case GermanHolidays.ChristmasEve:
                        dtFeiertag = new DateTime(iYear, 12, 24);                    // Heiligabend
                        break;
                    case GermanHolidays.ChristmasDay:
                        dtFeiertag = new DateTime(iYear, 12, 25);                    // 1. Weihnachtsfeiertag
                        break;
                    case GermanHolidays.SecondDayOfChristmas:
                        dtFeiertag = new DateTime(iYear, 12, 26);                    // 2. Weihnachtsfeiertag
                        break;
                    case GermanHolidays.Sylvester:
                        dtFeiertag = new DateTime(iYear, 12, 31);                    // Sylvester
                        break;
                }
                return (dtFeiertag);
            }

            /// <summary>
            /// Get Easter Sunday
            /// </summary>
            /// <!-- Author Tipplin 🧑-->
            /// !NOTE! Gauss Formulare goes uncorrectness,
            /// next change to Meeuws Formulare is correct.
            /// Meeuws mathematic from Belgium.
            /// <!-- Author Tipplin 🧑-->
            /// <param name="iYear"></param>
            /// <remarks>
            /// 
            /// </remarks>
            /// <returns>
            /// 
            /// </returns>
            public DateTime GetEasterSunday(int iYear) 
            {
                int a, b, c, d, e, m, n, p;

                DateTime dtEasterSunday;

                a = iYear % 19;
                b = iYear % 4;
                c = iYear % 7;
                m = 24;
                n = 5;
                d = (19 * a + m) % 30;
                e = (2 * b + 4 * c + 6 * d + n) % 7;
                p = 22 + d + e;

                if (p > 31)
                {
                    if (p == 56 && d == 28 && a > 10)
                    {
                        dtEasterSunday = new DateTime(iYear, 4, 18);
                    }
                    else
                    {
                        if (p == 57)
                        {
                            dtEasterSunday = new DateTime(iYear, 4, 19);
                        }
                        else
                        {
                            dtEasterSunday = new DateTime(iYear, 4, p - 31);
                        }
                    }
                }
                else
                {
                    dtEasterSunday = new DateTime(iYear, 3, p);
                }

                return (dtEasterSunday);
            }


            /// <summary>
            /// Saturday is a Workday
            /// </summary>
            public bool SaturdayIsWorkday
            {
                get { return this._saturday_IsWorkday; }
                set { this._saturday_IsWorkday = value; }
            }

            /// <summary>
            /// Sunday is a Workday
            /// </summary>
            public bool SundayIsWorkday
            {
                get { return this._sundayIsWorkday; }
                set { this._sundayIsWorkday = value; }
            }

            /// <summary>
            /// Add German Holiday
            /// </summary>
            /// <param name="holiday"></param>
            public void AddHoliday(GermanHolidays holiday)
            {
                if (!this._holidayMatrix[this._FederalState].Contains(holiday))
                {
                    this._holidayMatrix[this._FederalState].Add(holiday);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="holiday"></param>
            public void RemoveHoliday(GermanHolidays holiday)
            {
                if (this._holidayMatrix[this._FederalState].Contains(holiday))
                {
                    this._holidayMatrix[this._FederalState].Remove(holiday);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            private void InitMatrixFederalStates()
            {
                // Template = Bundeseinheitliche Feiertage
                List<GermanHolidays> templateFeiertag = new List<GermanHolidays>() { GermanHolidays.NewYear, GermanHolidays.GoodFriday, GermanHolidays.EasterSunday,
                                                                       GermanHolidays.EasterMonday, GermanHolidays.DayWork, GermanHolidays.CorpusChristi,
                                                                       GermanHolidays.WhitMonday, GermanHolidays.DayOfGermanUnity,
                                                                       GermanHolidays.ChristmasDay, GermanHolidays.SecondDayOfChristmas};

                this._holidayMatrix.Add(FederalStatesGermany.DeutschlandGesamt, new List<GermanHolidays>(templateFeiertag));

                this._holidayMatrix.Add(FederalStatesGermany.Bayern, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.Bayern].Add(GermanHolidays.Ascension);
                this._holidayMatrix[FederalStatesGermany.Bayern].Add(GermanHolidays.CorpusChristi);
                this._holidayMatrix[FederalStatesGermany.Bayern].Add(GermanHolidays.Epiphany);
                this._holidayMatrix[FederalStatesGermany.Bayern].Add(GermanHolidays.AllSaints);


                this._holidayMatrix.Add(FederalStatesGermany.BadenWürtemberg, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.BadenWürtemberg].Add(GermanHolidays.Ascension);
                this._holidayMatrix[FederalStatesGermany.BadenWürtemberg].Add(GermanHolidays.CorpusChristi);
                this._holidayMatrix[FederalStatesGermany.BadenWürtemberg].Add(GermanHolidays.AllSaints);

                this._holidayMatrix.Add(FederalStatesGermany.Berlin, new List<GermanHolidays>(templateFeiertag));

                this._holidayMatrix.Add(FederalStatesGermany.Brandenburg, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.Brandenburg].Add(GermanHolidays.Reformation);

                this._holidayMatrix.Add(FederalStatesGermany.Bremen, new List<GermanHolidays>(templateFeiertag));

                this._holidayMatrix.Add(FederalStatesGermany.Hamburg, new List<GermanHolidays>(templateFeiertag));

                this._holidayMatrix.Add(FederalStatesGermany.Hessen, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.Hessen].Add(GermanHolidays.CorpusChristi);

                this._holidayMatrix.Add(FederalStatesGermany.MecklenburgVorpommern, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.MecklenburgVorpommern].Add(GermanHolidays.Reformation);

                this._holidayMatrix.Add(FederalStatesGermany.Niedersachsen, new List<GermanHolidays>(templateFeiertag));

                this._holidayMatrix.Add(FederalStatesGermany.NordrheinWestfalen, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.NordrheinWestfalen].Add(GermanHolidays.CorpusChristi);
                this._holidayMatrix[FederalStatesGermany.NordrheinWestfalen].Add(GermanHolidays.AllSaints);

                this._holidayMatrix.Add(FederalStatesGermany.RheinlandPfalz, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.RheinlandPfalz].Add(GermanHolidays.CorpusChristi);
                this._holidayMatrix[FederalStatesGermany.RheinlandPfalz].Add(GermanHolidays.AllSaints);

                this._holidayMatrix.Add(FederalStatesGermany.Saarland, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.Saarland].Add(GermanHolidays.CorpusChristi);
                this._holidayMatrix[FederalStatesGermany.Saarland].Add(GermanHolidays.Assumption);
                this._holidayMatrix[FederalStatesGermany.Saarland].Add(GermanHolidays.AllSaints);

                this._holidayMatrix.Add(FederalStatesGermany.Sachsen, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.Sachsen].Add(GermanHolidays.Reformation);
                this._holidayMatrix[FederalStatesGermany.Sachsen].Add(GermanHolidays.RepentanceAndPrayer);

                this._holidayMatrix.Add(FederalStatesGermany.SachsenAnhalt, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.SachsenAnhalt].Add(GermanHolidays.Ascension);
                this._holidayMatrix[FederalStatesGermany.SachsenAnhalt].Add(GermanHolidays.Reformation);

                this._holidayMatrix.Add(FederalStatesGermany.SchleswigHolstein, new List<GermanHolidays>(templateFeiertag));

                this._holidayMatrix.Add(FederalStatesGermany.Thüringen, new List<GermanHolidays>(templateFeiertag));
                this._holidayMatrix[FederalStatesGermany.Thüringen].Add(GermanHolidays.Reformation);

            } // end of method::InitMatrixFederalStates

        } // end of class::GermanCalendarCalculator


        #endregion








    } // end of class VGFWorldwideHolidays

} // end of namespace::Visual.Galaxy.Framework.Worldwide.Holidays
// see in SDK write end of File
/******************************************************************************
 * END OF FILE::VGF.WorldwideHolidays.cs
 ******************************************************************************
 */
