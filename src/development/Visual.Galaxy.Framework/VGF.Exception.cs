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
using System.Text.RegularExpressions;
using System.IO;

using System.IO.Compression;
using System.Configuration;
using System.Net;

using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Security.Principal;
using System.ComponentModel;

using System.DirectoryServices.ActiveDirectory;

using System.Threading;
using System.Threading.Tasks;

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.Serialization;
/*
 * Here all what you need for Project,
 * from other C# Files, namespaces,
 * namespaces and static classes.
 * 
 */

using static Visual.Galaxy.Framework.VGFCore;

#region ### namespaces and static classes from Visual.Operation.System.dll ###
// static Class NativeMethods for Constants, Enumerator, Struct's, variables...
using static Visual.Operation.System.Native.NativeMethods;

// All Windows Operation System Functions
using static Visual.Operation.System.Native.UnsafeNativeMethods;

// All C/C++ Runtime Library Functions for use.
using static Visual.Operation.System.Native.NativeRuntimeMethods;

// Constants for MessageBox, StartUp, Properties-Hardware-Enviroment-Battery Queries
// SystemFunctions - but please don't use it!
using static Visual.Operation.System.Internal.InternalUtilities.VOSInternalUtilities;

// No static, Internals
using Visual.Operation.System.Internal.InternalUtilities;


#endregion


#region ### namespace and classes from Visual.Operation.Syste,dll - part Visual.Function.Library.dll written in C. ###
// Visual.Function.Library.dll - our Functions for use written in C/C++.


#endregion







//------------------------------------------------------
// Base from Visual.Exception.Engine
//
//------------------------------------------------------
namespace Visual.Galaxy.Framework.Exception
{

    /*
     * NEW ExceptionHandling like Java and Operator || vertical bar, more Classes Exceptions
     * 
     *return ex is NullReferenceException ||
                   ex is StackOverflowException ||
                   ex is OutOfMemoryException   ||
                   ex is System.Threading.ThreadAbortException ||
                   ex is System.Runtime.InteropServices.SEHException ||
                   ex is System.Security.SecurityException; 
     * 
     * 
     * catch(SystemException ex)when(ex is NullReferenceException || ex is SecurityException || ex is COMException || ...)
     * {
     *      // Statements here
     * }
     * 
     * 
     * .NET Framework 4.7.2 and Visual C# 7.3 allowed this catch like Java.
     * 
     * catch(SystemException ex)when(ex is InternalBufferOverflowException || ex is COMException || ex is InvalidDataException)
     * {
     *      VOLMsgBox(ex.Message, ex.Source, STYLES.OkOnly | STYLES.Critical | STYLES.MsgBoxSetForeground | STYLES.SystemModal);
     *      return false;
     * }
     * 
     * 
     */












    /// <summary>
    /// Class VGFCoreException
    /// </summary>
    /// <!-- Author Tipplin -->
    /// 
    /// <!-- Author Tipplin -->
    /// <remarks>
    /// Create Remote Exception Service for Framework, Application...
    /// DataContracts
    /// ExceptionServer
    /// ExceptionClient
    /// 
    /// </remarks>

    /*
     * Gibt an, dass der Typ einen Datenvertrag definiert oder implementiert und 
     * mit einem Serialisierer wie dem DataContractSerializer serialisierbar ist. 
     * Um ihren Typ serialisierbar zu machen, 
     * müssen die Autoren hierfür einen Datenvertrag definieren.
     * 
     * Wenden Sie das DataContractAttribute-Attribut auf Typen 
     * (Klassen, Strukturen oder Enumerationen) an, die bei Serialisierungs-
     * und Deserialisierungsvorgängen vom DataContractSerializer verwendet werden. 
     * Wenn Sie zu senden oder Empfangen von Nachrichten mithilfe der 
     * Windows Communication Foundation (WCF)-Infrastruktur, 
     * Sie sollten auch anwenden, die DataContractAttribute auf alle Klassen, 
     * die in Nachrichten gesendeten Daten enthalten und bearbeiten. 
     * 
     * Weitere Informationen zu Datenverträgen finden Sie unter Using Data Contracts.
     * 
     * Sie müssen den DataMemberAttribute auch auf alle Felder, 
     * Eigenschaften oder Ereignisse anwenden, die Werte enthalten, 
     * die Sie serialisieren möchten. Indem Sie den DataContractAttribute anwenden, 
     * aktivieren Sie explizit den DataContractSerializer zum Serialisieren und Deserialisieren der Daten.
     * 
     * Achtung
     * Sie können den DataMemberAttribute auf private Felder anwenden. 
     * Beachten Sie, dass die von dem Feld zurückgegebenen Daten (auch bei privaten Feldern) 
     * serialisiert und deserialisiert werden und 
     * daher von böswilligen Benutzern oder Vorgängen angezeigt oder abgefangen werden können.
     * 
     * Datenverträge
     * Ein Datenvertrag ist eine abstrakte Beschreibung einer 
     * Gruppe von Feldern mit einem Namen und Typ für jedes Feld.
     * Der Datenvertrag befindet sich außerhalb einzelner Implementierungen, 
     * um die Zusammenarbeit zwischen den Diensten verschiedener Plattformen zu ermöglichen. 
     * Solange die zwischen den Diensten übermittelten Daten demselben Vertrag entsprechen, 
     * können sie von allen Diensten verarbeitet werden. 
     * Diese Verarbeitung wird auch eine lose verbundenes System. 
     * Ein Datenvertrag ist auch mit einer Schnittstelle vergleichbar, 
     * da der Vertrag angibt, wie die Daten zu übermitteln sind, 
     * um von einer Anwendung verarbeitet werden zu können. 
     * Der Datenvertrag kann beispielsweise einen Datentyp mit der Bezeichnung 'Person' erfordern, 
     * der zwei Textfelder mit der Bezeichnung 'Vorname' und 'Nachname' enthält. 
     * Um einen Datenvertrag zu erstellen, können Sie den DataContractAttribute auf die Klasse anwenden und 
     * den DataMemberAttribute auf Felder oder Eigenschaften anwenden, die serialisiert werden müssen. 
     * Wenn die Daten serialisiert sind, entsprechen sie dem implizit in den Typ integrierten Datenvertrag.
     * 
     * https://docs.microsoft.com/de-de/dotnet/api/system.runtime.serialization.datacontractattribute?view=netframework-4.7.2
     * 
     */
    [Serializable]
    [DataContract(Name = "Exception", Namespace = "http://www.vgfc.org/exception/authors")]

    public class VGFCoreException
    {

        /// <summary>
        /// Class VGFCoreExceptionService
        /// </summary>
        /// <!-- Author Tipplin -->
        /// VGFCoreExceptionService:
        /// Idea Developer create full Exception Service for Framework and Application,
        /// as Help Service for Users.
        /// So the Developer can see where is the Exception occured and can cleanup this,
        /// and send fix(es) vis Webserver to Users.
        /// Fix Category: Security, Quick, Bug, Quality
        /// By Windows Operation System 10, 
        /// the Developer can create Function ExitWindowsEx(EXW_SHUTDOWN | EXW_REBOOT, REASON_APPLICATION_MINOR | REASON_SECURITY_FIX_PLANNED)
        /// shutdown system install fix and reboot it.
        /// VGFCoreExceptionServiceClient:
        /// 
        /// 
        /// VGFCoreExceptionServiceServer:
        /// 
        /// 
        /// VGFCoreExceptionServiceHTTPS:
        /// secure connect to Webserver
        /// 
        /// VGFCoreExceptionServiceURI:
        /// constants Uri's as Websites with .NET Class URI
        /// 
        /// Call is: 
        /// Process.Start(webserver, instancevaraiable.OrginalString);
        /// Process.Start(InternetExplorer/Chrome/Edge/..., wuri.OrignalString
        /// ---------------------------------------------"https://www.microsoft.com"
        /// 
        /// 
        /// ------------------------------------------------------------------------
        /// Next can use:
        /// Windows Tool - psr.exe - problem step recorder -
        /// All Useractions (mouse, taste...), Machine, System,
        /// create Microsoft Special HTML File x.mht, 
        /// can pack all into .zip package and send to Developer directly.
        /// 
        /// 
        /// <!-- Author Tipplin -->
        /// <remarks>
        /// Create Remote Exception Service for Framework, Application...
        /// </remarks>
        public class VGFCoreExceptionService
        {
            /// <summary>
            /// 
            /// </summary>
            [NonSerialized]
            private ExtensionDataObject extensionDataField;

            /// <summary>
            /// 
            /// </summary>
            [OptionalField]
            private Dictionary<string, string> DataField;

            /// <summary>
            /// 
            /// </summary>
            [OptionalField]
            private string ErrorTypeField;

            /// <summary>
            /// 
            /// </summary>
            [OptionalField]
            private VGFCoreException InnerErrorField;

            /// <summary>
            /// 
            /// </summary>
            [OptionalField]
            private string MessageField;

            /// <summary>
            /// 
            /// </summary>
            [OptionalField]
            private string SourceField;

            /// <summary>
            /// 
            /// </summary>
            [OptionalField]
            private string StackTraceField;

            /// <summary>
            /// 
            /// </summary>
            [Browsable(false)]
            public ExtensionDataObject ExtensionData
            {
                get
                {
                    return extensionDataField;
                }
                set
                {
                    extensionDataField = value;
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public Dictionary<string, string> Data
            {
                get
                {
                    return DataField;
                }
                set
                {
                    if (!object.ReferenceEquals(DataField, value))
                    {
                        DataField = value;
                        RaisePropertyChanged("Data");
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public string ErrorType
            {
                get
                {
                    return ErrorTypeField;
                }
                set
                {
                    if (!object.ReferenceEquals(ErrorTypeField, value))
                    {
                        ErrorTypeField = value;
                        RaisePropertyChanged("ErrorType");
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public VGFCoreException InnerError
            {
                get
                {
                    return InnerErrorField;
                }
                set
                {
                    if (!object.ReferenceEquals(InnerErrorField, value))
                    {
                        InnerErrorField = value;
                        RaisePropertyChanged("InnerError");
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public string Message
            {
                get
                {
                    return MessageField;
                }
                set
                {
                    if (!object.ReferenceEquals(MessageField, value))
                    {
                        MessageField = value;
                        RaisePropertyChanged("Message");
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public string Source
            {
                get
                {
                    return SourceField;
                }
                set
                {
                    if (!object.ReferenceEquals(SourceField, value))
                    {
                        SourceField = value;
                        RaisePropertyChanged("Source");
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public string StackTrace
            {
                get
                {
                    return StackTraceField;
                }
                set
                {
                    if (!object.ReferenceEquals(StackTraceField, value))
                    {
                        StackTraceField = value;
                        RaisePropertyChanged("StackTrace");
                    }
                }
            }

            /// <summary>
            /// 
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="propertyName"></param>
            protected void RaisePropertyChanged(string propertyName)
            {
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        /*
    namespace DataContractAttributeExample
{
    // Set the Name and Namespace properties to new values.
    [DataContract(Name = "Customer", Namespace
    class Person : IExtensibleDataObject
    {
        // To implement the IExtensibleDataObject interface, you must also
        // implement the ExtensionData property.
        private ExtensionDataObject extensionDataObjectValue;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataObjectValue;
            }
            set
            {
                extensionDataObjectValue = value;
            }
        }

        [DataMember(Name = "CustName")]
        internal string Name;

        [DataMember(Name = "CustID")]
        internal int ID;

        public Person(string newName, int newID)
        {
            Name = newName;
            ID = newID;
        }

    }



    class Test
    {
        public static void Main()
        {
            try
            {
                WriteObject("DataContractExample.xml");
                ReadObject("DataContractExample.xml");
                Console.WriteLine("Press Enter to end");
                Console.ReadLine();
            }
            catch (SerializationException se)
            {
                Console.WriteLine
                ("The serialization operation failed. Reason: {0}",
                  se.Message);
                Console.WriteLine(se.Data);
                Console.ReadLine();
            }
        }

        public static void WriteObject(string path)
        {
            // Create a new instance of the Person class and 
            // serialize it to an XML file.
            Person p1 = new Person("Mary", 1);
            // Create a new instance of a StreamWriter
            // to read and write the data.
            FileStream fs = new FileStream(path,
            FileMode.Create);
            XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(fs);
            DataContractSerializer ser =
                new DataContractSerializer(typeof(Person));
            ser.WriteObject(writer, p1);
            Console.WriteLine("Finished writing object.");
            writer.Close();
            fs.Close();
        }
        public static void ReadObject(string path)
        {
            // Deserialize an instance of the Person class 
            // from an XML file. First create an instance of the 
            // XmlDictionaryReader.
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            XmlDictionaryReader reader =
                XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

            // Create the DataContractSerializer instance.
            DataContractSerializer ser =
                new DataContractSerializer(typeof(Person));

            // Deserialize the data and read it from the instance.
            Person newPerson = (Person)ser.ReadObject(reader);
            Console.WriteLine("Reading this object:");
            Console.WriteLine(String.Format("{0}, ID: {1}",
            newPerson.Name, newPerson.ID));
            fs.Close();
        }

    }
}


//[Serializable] 

public partial class FrameworkException : System.Exception

{

    /// <summary>

    /// 

    /// </summary>

    public string ErrorCode = null;

    public string []Arguments = null;



    /// <summary>

    /// 

    /// </summary>

    public FrameworkException (): base ()

    {

    }



    /// <summary>

    /// 

    /// </summary>

    /// <param name="message"></param>

    public FrameworkException ( string Message ) : base ( Message )

    {

    }



    /// <summary>

    /// 

    /// </summary>

    /// <param name="message"></param>

    /// <param name="inner"></param>

    public FrameworkException ( string Message, System.Exception InnerException ) : base ( Message, InnerException )

    {

    }



    /// <summary>

    /// 

    /// </summary>

    /// <param name="errorCode"></param>

    /// <param name="message"></param>

    public FrameworkException ( string ErrorCode, string Message ) : base ( Message )

    {

        this.ErrorCode = ErrorCode;

    }



    /// <summary>

    /// 

    /// </summary>

    /// <param name="errorCode"></param>

    /// <param name="arguments"></param>

    public FrameworkException ( string ErrorCode, params object [] Arguments )

    {

        this.ErrorCode = ErrorCode;

        //this.arguments = arguments;



        this.Arguments = new string [Arguments.Length];



        for ( var length = 0; length < Arguments.Length; ++ length )

        {

            this.Arguments[length] = (string)Arguments [length];

        }



    }



    /// <summary>

    /// 

    /// </summary>

    /// <param name="errorCode"></param>

    /// <param name="message"></param>

    /// <param name="inner"></param>

    public FrameworkException ( string ErrorCode, string Message, System.Exception InnerException ) : base ( Message, InnerException )

    {

        this.ErrorCode = ErrorCode;

    }



    /// <summary>

    /// 

    /// </summary>

    /// <param name="info"></param>

    /// <param name="context"></param>

    public FrameworkException ( SerializationInfo SerializationInfo, StreamingContext Context ) : base ( SerializationInfo, Context )

    {

        this.ErrorCode = ( string ) SerializationInfo.GetValue ( "errorCode", typeof ( string ) );

    }



    ///// <summary>

    ///// 

    ///// </summary>

    ///// <param name="info"></param>

    ///// <param name="context"></param>

    //public override void GetObjectData ( SerializationInfo SerializationInfo, StreamingContext Context )

    //{

    //  SerializationInfo.AddValue ( "errorCode", ErrorCode );

    //  base.GetObjectData ( SerializationInfo, Context ) ;

    //}



}











*/





    } // end of Class::VGFCoreException

} // end of Namespace::Visual.Galaxy.Framework
  
