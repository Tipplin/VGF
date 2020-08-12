using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual.Galaxy.Framework.Currency
{

    /// <summary>
    /// 
    /// </summary>
    public static class VGFCurrency
    {

        //--------------------------------------------------------------------
        // TIPPO Idea:
        // Currency/Währungen
        // so you can connect with Stock WebServer - Devisen - give adress 
        // so daily new exchanges
        // -------------------------------------------------------------------
        // New Windows 10 March Update 2019 have Stock Exchange,
        // but Falling costs because retrieval via the foreign exchange stock
        // 1 US-Dollar = 0,8853 Euro at 05.03.2019
        //--------------------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public enum Currencies : int
        {
            /// <summary>
            /// 
            /// </summary>
            euro = 0,
            /// <summary>
            /// 
            /// </summary>
            dollar = 1,
            /// <summary>
            /// 
            /// </summary>
            rubel = 3,
            /// <summary>
            /// 
            /// </summary>
            pfund = 4,
            /// <summary>
            /// 
            /// </summary>
            danmarkkronen = 5,
            /// <summary>
            /// 
            /// </summary>
            australiadollar = 6,
            /// <summary>
            /// 
            /// </summary>
            forint = 7

        } // End of Enumerator::Currencies

        /*
            .net
            StringWriter sw = new StringWriter();
            from JAVA: PrintWriter flush the strem to Printer and print it!
            PrintWriter pw = new PrintWriter(sw);
            tr.printStackTrace(pw); 
            pw.flush();  

        */

        /*
        /// <summary>
        /// 
        /// </summary>
        public enum Currencies3:string
        {
            /// <summary>
            /// 
            /// </summary>
            danmarkkronen = "dkk"
        }
        */





        /*--------------------------------------------------------------------- 
         * Enumerators:
         * .NET Language Typescript 2.0  enum with : string
         *--------------------------------------------------------------------- 
         *  Visual C# 7.3 at time now with 1 char - 'c' is now allowed !.
         *  but string later.
         *  
         *---------------------------------------------------------------------  
         */

            /// <summary>
            /// Enumerator for World Currencies
            /// Info: Most Currencies in Windows 10 Calculator
            /// under Currencies option. 
            /// But NOTE ! make connect Currency Stock are with costs.
            /// And the best the Windows 10 Calculator is open source on GitHub written in Visual C++.
            /// </summary>
            /// <!-- Author Tippo -->
            /// Note! Only one char allowed in '€'
            /// <!-- Author Tippo -->
            /// <remarks>
            /// shortname for Sign
            /// public static string Euro => Currencies2.euro.ToString();
            /// </remarks>
            /// <return>
            /// returned the Sign.
            /// </return>
        public enum Currencies2
        {
            // € is one char sign is allowed in Enumerator Visual C# - character UTF16 unit

            /// <summary>
            /// Euro Sign €
            /// </summary>
            euro = '€',

            /// <summary>
            /// Dollar Sign $
            /// </summary>
            dollar = '$',

            /// <summary>
            /// Pfund Sign l
            /// </summary>
            pfund = 'l',


            // more then one char make fail!
            // to many chars in sign literal
            // birr = 'bbb'

        }

        /// <summary>
        /// Get Euro sign
        /// </summary>
        /// <!-- Author Tippo -->
        /// Shortname for Euro sign with Lamdba Operator,
        /// as property.
        /// stringformat("Cash {0} {1} it !", Value, Euro);
        /// in {1} the euro sign.
        /// <!-- Author Tippo -->
        /// <remarks>
        /// 
        /// </remarks>
        public static string Euro => Currencies2.euro.ToString();
        /// <summary>
        /// 
        /// </summary>
        public static string Dollar => Currencies2.dollar.ToString();
        /// <summary>
        /// 
        /// </summary>
        public static string Pfund => Currencies2.pfund.ToString();
    }
}
