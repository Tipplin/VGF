//############################################################################
//
// Project		:	Visual.Galaxy.Framework
//
//----------------------------------------------------------------------------
// Programmer	:	Christian "Tipplin" Kurs
//----------------------------------------------------------------------------
// Part		:	Database Connections
//----------------------------------------------------------------------------
// Base Class	:	VGFCore
//----------------------------------------------------------------------------
// Copyright © 2017, by 
// Visual Galaxy Framework Community Kernel Developer Team.
//
// by Headauthor: Christian "Tipplin" Kurs - Visual C# Senior Developer
// Portions Copyright © 2017 by Microsoft Corporation GmbH.
//
// Same sourcecode by Microsoft, so we marked with Copyright !.
// © 1982 - 2017 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
// Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
// ----------------------------------------------------------------------------
// DON'T CHANGE OR DELETE ANYTHING IN SECTION !!!.
// ----------------------------------------------------------------------------
//
//
//
//
//
//
//############################################################################
//
// Hello Authors for Visual Galaxy Framework !
// nice to have you, for other Project " " (codename) !.
//
// At New Visual Studio 2017 Code Editor "MONACO" your can use following 
// Programming Languages - same can precompile Module to bind in Project.
//
// Go, PHP, Coffee, Java, Lua, Less, Python, Objective C, Razor, Ruby, Swift,
// Jade,
//
//----------------------------------------------------------------------------
// .NET - Programming Languages and there Command Line Compiler: 
// Visual C++ (for .NET compile)	- cl /clr filename.cpp 
// Visual C#						- csc /target:exe, dll, module, xml csharpfile.cs
//									- output: csharp.exe, csharp.dll, csharp.dll without Metadata
//									- C# module as precompiled.
// Visual Basic.NET				- vbc
// Typescript						- tsc
// Windows for Javascript (WinJS)	- jsc
//
// X++ for Dynamics (NAVISION)		-
// X++ new programming language 2017/06/20
//------------- Same Command Line Compiler Switches --------------------------
// /target:dll 	- standard for Library compile	- same in Visual Studio IDE
// /target:exe 	- standard for Executable compile - same in VS IDE
// only over command line compiler's:
// /target:module	- precompiled for a Module without Metadatas
// /target:xml		- compiled a xml File.
// short: /t:module csharpfile.cs - precompile to a dll.
// /t:module cppfilename.cpp and so.... for others...
//
// backend compile with Assembly Linker Tool: al.exe
// al/t:output		- compiled DLL -
//
// 
// inside slang: multiple Assembly with Miscellous Programming Languages and
// Metadata.
// (there are relevant for Common Language Runtime  slang: .NET Runtime)
// The CLR loads only Module for Work, LoadModule and UnloadModule inside.
// Module's are smaller and faster.
// Option: In Module -
// [MethodImplemenationAttribute(MethodImpl.Option.InternalCall)]
// here method-declaration
// InternalCall - this Method runs internal with entry in CLR.
// AggreviceInline - inline method
// NoInline - (General: The Compiler's change your Method to inline)
// ! Tipplin ! - Compiler's and Processor change your Codes. Backend.
// Same Processors Aggrevice, SPARC's, Alpha's, Arm'S.
// Intel and AMD to 2016 are little different's, but relevant.
// 
//----------------------------------------------------------------------------
// VFGCore
// written by 		Christian "Tipplin" Kurs
// 				Nettweg 1
//					-G - 53498 Bad Breisig
//					Germany - Allemagne - Duitsland
//----------------------------------------------------------------------------
// 				voice				:	02633 - 470736  
//					international phone	:	00-49-2633-470736
//					Skype				:
//					e-mail				:	Christian.Kurs@gmail.de
//					community Website	:	www.vgf.com/community/Tipplin
//----------------------------------------------------------------------------
// This software is supplied as is. Use it at your own  RISK !!!!.
// Obviously I've tried to do the best job possible.
// If you find any problem with it, let me know.
//
// With any luck, Visual Galaxy Framework will make it obsolete anyway
//----------------------------------------------------------------------------
// License:	
//				NO fee for NON-Commercial use.
//				our Community Website: www.vgf.de/community/project/vgf/
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//				www.vgf.com/business/vgf/License
//
//----------------------------------------------------------------------------
// Same specified to Project "Visual.Galaxy.Framework":
// 
// 	Bugfix 			-	for Errors (clean up's)
//
//		Hotfix			-	pass to Operation System-update, bugfixes, cleanup
//
//		SecurityFix		-	for Security leaks
//
// combine with Reason in ExitWindowsEx and 
// Shutdown Flag: EWX_RESTARTAPPS | ShutdownReason.REASON_PLANNED_FLAG
// so the Operation System force to close all App's and shutdown,
// install SecurityFix and restart the System and restart the last App.
//
//----------------------------------------------------------------------------
//-------------------------- Project History ---------------------------------
//----------------------------------------------------------------------------
// Release 0.0.0 - 2016/01/01 - Tipplin - KC - Project Founder - Initial
//----------------------------------------------------------------------------
// Commentary:
// [VGF.NET - 01]
//
//
//
//----------------------------------------------------------------------------
// Definition:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Improvement:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// New Feature:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Task:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Class:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Method:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Property:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Breaking Changes: (Like Microsoft Fundamental Team for .NET FX)
// Last .NET FX 4.6 for jit Compiler Error, 
// change Parameters in Method, wrong Results. DONT USE 4.6 !!!.
// use .NET FX 4.6.1 and 4.6.2 or higher. (Bugfixes)
// 
//
//
//
//
//
//######################## Other notable Changes #############################
//
// Other:
// [VGF.NET - 01] 
//
//----------------------------------------------------------------------------
// Bug:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Fixes:
//[VGF.NET - Bug 01]
//
//---------------------------------------------------------------------------- 
// Miscellous:
//
//
//
//
//
//
//
//######################### Visual.Galaxy.Framework ##########################
//#
//# Start Date: 2016/01/01 - 17:00 - Ground Leaning -Initial
//#
//#---------------------------------------------------------------------------
//# Freeze Date: 
//# (FREEZE: like Microsoft - stopp develop, no more codes into project,
//# - but develop goes on - compiling to R T M )
//# Microsoft Developer's have all one or more Platform's for Project's.
//# Microsoft Office, Project, Team Foundation Server... 
//# Microsoft Build Server - all Developer save they code here, test OK! 
//# Build Server bundles that and compile a Daily Build - 
//# like Windows 10 Desktop - B 15002 - 09.01.2017.
//# --------------------------------------------------------------------------
//#
//# ! NOTE ! Develop are going on, new an features in later build.
//#
//#
//#
//#
//############################################################################
//############################################################################
//
// 		Here Operation System and Processor Informations:
//
//			This Visual.Galaxy.Framework works with 
//			Intel Processor Skylake all Features !
// 
//		If you have a other  Variant of Skylake this Features doesn't WORK !.
//		Intel Skylake with Hyperthreading everytime!! and the most Features.
//		others Skylake without them !!!.
//	
//		Intel Skylake better works with Windows 10 - Features inside
//
//		New Technology Intel Speed Shift, 
//		change the old operation system managed Processor States,
//		the Processor make own States for all Processes, Turbo Tact, 
//		Speed Shift with Hardware-Algorithmic for right Choice:
//		Tact's und Voltages. Works Operation System and Skylake everytime.
//		! ONLY ! Windows 10 can works with Intel Speed Shift.
//		"Hallo Cortana" reaction with Intel Smart Sound Technology in Work.
//		while Windows 10 goes into suspend state by shutdown, sleep modus,
//		than Intel Skylake Processor can wake up the System.
//		-----------------------------------------------------------------------
//		Intel Skylake Features:
//		-----------------------------------------------------------------------
//		Internal Random Generator with 16, 32 and 64 BIT Random Numbers, use
//		over Visual C++ Headers files bridge to machine code. Everytime new!.
//		! NOTE !: Please write a query, can Processor this supports !.
//
//		Internal Cryptopgrafy with AES and Rijndael Cryption API.
//		Intel Boot Guard
//		Intel Software Guard Extenstion:
//		App's help datas and Codes hold secured 
//
//		Intel Memory Protection Extenstion (Intel MPX), Intel Processor Trace,
//		Intel Secure Key - see in Folder "Tipplin" - Intel Skylake Internal -
//----------------------------------------------------------------------------
// ! Tipplin ! TIP:
// Intel Processors are coded with a Codenumber.
// Intel Skylake i5 / i7 - not relevant - 6700 + one letter, that's relevant !
// 6 is the Processor Generation, 700 is the Modelnumber, Any one Letter's:
// K= for specially Properties, S= performance optimize
//----------------------------------------------------------------------------
// Intel Skylake: L1 cache, L2 Cache = 2 MB to 8 MB, L3 Cache but small.
// All Information here, Intel give a SDK's and Intel Extenstions 
// (NOT all free due), Intel SDK and Extenstion bind in Visual Studio.
// Most of the Processor use with Visual C++.
// Intel Processors old full written in Machinecode, new in Microcode,
// Intel have a Patcher to patch this microcode from outside by Bug's.
// BUT give this Patcher only Hardware - BIOS Vendors. - Activation set!.
// Microsoft make this with the microcode dll - mc-genuine-x.dll for Intel
// Processor and mc-authentic-x.dll for AMD Processor is Windows on fly update
// Sample: Division bug - have forgotten the Value Scope 
// !!! inside longdouble is 80 BIT !!! but show Microsoft support yet !!! NOT! 
// calculate with double Values.
// single, double, longdouble DON'T calculation with Financial Values !!!!
// double: In Million scope are uncorrectness in million cent scope.
// So use in .NET and Visual C# the datatype decimal is 128 BIT scope.
// the very correct calculate datatype.
// Visual C#: UIntPtr, IntPtr for Pointers and handles and so.. is a 
// intergral datatype with correctness Pointer Values. 
// Pass on for 32BIT Platform and 64 BIT Platform automatic !.
// !!! Pointers are not usefully in .NET !!!. (unsafe)
// 
//
//
//---------------------------------------------------------------------------- 
// Intel Processor Codename "Kaby Lake" Optane 2017 more Kernels/Threads,
// but Technology for SSD next, Intel Processor CPU and GPU integration.
// Intel Processor next with Chipset 3DPoint SSD with Capacity 16/32 Gbyte.
// so he can hold the Datas by Newstart.
// Intel Processor Kaby Lake 7. Generation only for Windows 10 and Linux.
// Windows 7 out. Intel New Tech 4 K Videos for Windows Webbrowser 'EDGE'.
//
//
//
// ---------------------------------------------------------------------------
//
//
//
//
//
//############################################################################
//
//		DON'T CALL WINDOWS SYSTEM FUNCTIONS DIRECTLY WITH EXTENTION  - Ex -
//----------------------------------------------------------------------------
// 		Windows Operation System call this permanent at Time !. 
// 	(Internal)
//		Please write Visual C# Wrapper as here !!!. (Indirect Call)
//
//
//
//
//
//
//############################################################################
//
//
//
//
//----------------------------------------------------------------------------
// Windows Operation System - native Methods - 
//----------------------------------------------------------------------------
// Windows 10 Major jump to 10, Microsoft Info: has problems with 9 as
// major version, same install/setups programs has problems with them,
// and see 9 as Windows 95.
//----------------------------------------------------------------------------
// Same Windows API have new Flags and Functions for Windows 10: 
//
// 1. 	use the .NET Framework 4.6.1, 4.6.2 or higher (de. to Win 10)
// 2. 	use all NOT into .NET Framework as native Functions 
//		in DLLImportAttribute - user32, kernel32, shell32, advapi32 and so..
//		all this new System Dll's have more Functions.
// ! NOTE !:
// All marked Windows 10 functions, you can use ONLY on Windows 10 System !.
// Set special #if directive for Platform - 32 BIT and 64 BIT -
// x86 and x64 - Intel and AMD compatible(little different, but not relevant).
// a.) Visual Studio help us porting a 32 BIT Project to 64 BIT Project, like
//		a Assistant, going to Platform Option over new... and show the Assist.
//		Choice your Selecting new Platform 64 BIT, than 32 BIT Project......
//		Take Solution, but your must pass on same specials for 64 BIT.
//
//
//############################################################################
//
//----------------------------------------------------------------------------
//------------------- Query for Operation System: ----------------------------
//----------------------------------------------------------------------------
//
//
// OSVERSIONINFOEX - Structure for Operation System Info
// GetSystemInfo(ref OSVERSIONINFOEX);
//
// IsWindows10OrGreather() as bool.
//
//----------------------------------------------------------------------------
// Tipplin TIP: 
//----------------------------------------------------------------------------
// All Windows Functions with Exenstion - Ex - are use
// from Operation System permanent, so please write wrapper
// for this Calls in Visual C#.
//
// Source Info: From Microsoft Developer .NET Framework.
//
// At Time MS Developer Team:
// Problems with Apple MAC OS X Operation Systems with
// [DLLImportAttribute -> Entrypoint]
// set internal .NET FX a Directive for Apple - __APPLE__
// Apple have other suffixe for System Dll's:
// .so, .dynlib, .lib, .sys - means the same as .dll
// you can use System Dll also: system.so - Source: Miguel de Icaza
//
//-----------------------------------------------------------------------------
// Windows 10 have three Platforms inside:
//
// Universal Windows Platform (UWP):
// 1. Windows 10
// 2. Windows 8.1
// 3. Classics (Windows API - Like Windows 7 <>)
//--------------------------------------------------------------
//								Windows NT
// Windows 10		- Version - Major: 10 Minor: 0
//
//--------------------------------------------------------------
//
// Windows 8.1		- Version - Major:  6 Minor: 3
//
// Windows 8.0		- Version - Major:	6 Minor: 2
//
// Windows 7		- Version - Major:  6 Minor: 1
//
// Windows Vista	- Version - Major:  6 Minor: 0
//
// Windows XP		- Version - Major:  5 Minor: 1
// 
//
//############################################################################
//
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------
// Set here Directives and namespaces (Project)
// using System;
// using namespacename;
// NEW at .NET Framework 4.6(4.6.1, 4.6.2)
// using static -> classes and Methods are written with static.
// using static directivename.classname;
// so you can use the Methods directly without instance !.
//----------------------------------------------------------------------------
// using static System.Math;		// mathematic methods - pow(x,y);
//									// power of 2 - 2^10
//									// Visual C++ Runtime Library refactoring:
//									// old 17 Digits on new 768 Digits.
//----------------------------------------------------------------------------
// using static System.Console;	// console: 
//									// methods, properties and one event
//----------------------------------------------------------------------------
//--------------- .NET Framework 4.6.2 or higher (2017 5.0) ------------------
//----------------------------------------------------------------------------
// opening the hidden HRESULT - Exception.HRESULT long time protected !.
// sample: 
// catch(Exception ex)when(ex.HRESULT == 0x80072EFD)
// {
//	
// }
//
// 0x80072EFD - Values are minus numbers like 
// -2147954429 => WININET_CANNOT_CONNECT - a connection with the Server could 
// not be establisheded.
//----------------------------------------------------------------------------
// Community TIP from 
//
// use:
//
// using(var a = new HTTPClient)
// {
//		// here codes
// }
//
// !!! if using block out, !!!
// !!! the using call automatic dispose() for free all Resources. !!!
//
//
//
//############################################################################
// NEW ! Visual Studio 2017 both Community, Professional, Enterprise
//----------------------------------------------------------------------------
// set .NET Framework using's directives assemblies or your own assembly....
// If your Assembly written static class and methods, so set following:
//
// using static Visual.Security.Library.Classname;
// so you can directly call a method.
//
//############################################################################
using System;
using static System.Console;
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
using System.Timers;

//----------------------------------------------------------------------------
// using Visual.Galaxy.Framework; to use in your Project
// Backend compile have inside Visual.Security.Library this Library is Active
// at Runtime !. - means only registered Users can use our Framework after
// free Testphase !.
//----------------------------------------------------------------------------
// Special Library - pure Resources without any Class or Methods:
//----------------------------------------------------------------------------
// using Visual.Resource.Library.Properties;
//
// so you can use the inside Resource or your directly !!!.
// all Resources are public set !!!.
//
// Visual Studio Resource Manager stand on internal !!! must change! to public
//
// your property or set:
//
// Sample:
// 
// form1.backgroundimage = resource.BigBen; // BigBen by Night
// (auto)resource with light blend up.)
//----------------------------------------------------------------------------
// Inside Embedded Resources: Icons, Images, Pictures, Photos, Music, Sounds,
// Noises, Texte, Flying Windows Flag, Animated GIF's and more...
//
//----------------------------------------------------------------------------
// To add your Resource too, 
//
// use the Compiler Flag: csc /addresource to Assembly
// or our specials.
//----------------------------------------------------------------------------
// !!! Special from MS Developer: !!!
//----------------------------------------------------------------------------
// Can use the FrameworkException for your Framework, 
// normally for .NET Framework, 
// FrameworkException as inherited
// Class VGFCore:FrameworkException - VGFCore as Base class
// with special informations, FrameworkException has special members.
//----------------------------------------------------------------------------
//
// <summary>
//
// 	Main - namespace for Visual Galaxy Framework.Database
//     support ODBC and JDBC, both supports Windows 10 Professional with
//     Activation via Windows Features !. (ODBC 32/64BIT, JDBC)
//     Driver for Database inside is MS SQL Server, Oracle MySQL, MS Access,
//     Set the Driver's in ODBC Database Manager for other Databases.
//     Windows 10 'Creators Update' V1703 Revision xxx, Java Support ->
//     Install Oracle JVM, Oracle OpenJDK and Java Development Center,
//     Oracle Java Mission Control Center.
//
//     From Video Microsoft Mechanics:
//     Microsoft SQL Server on Linux - Java Simple Sample -
//
//----------------------------------------------------------------------------
// </summary>
namespace Visual.Galaxy.Framework.Database
{
    /*
	public class sqldatabaseDemo
    {
        public static main(String[] args)
        {
            WriteLine("*** Microsoft SQL Server Demo ***\n");

            

            /// Tipplin TIP:
            /// set all your settings, system, url's, websites, 
            /// database connections, servernames, workstations and more in
            /// Configurations File is BETTER ! name.config 
            /// - Visual Studio create automatic - app.config, web.config,
            /// - machine.config, user.config - Own: Network.config, 
            /// - Workstation.config, ServerNames.config, SQLQueries.config.....
            /// Use Class ConfigurationManager from .NET Framework:
            /// create, delete, change, add, read and write, ... a .config file
            /// Secure the Configuration, encrypt the .config-File !!!.
            /// Tool.
            /// Configuration-files: XML.file
            /// Tipplin: UNCHECKED
            /// compile with csc /t:xml name.xml
            /// csc = csharp compiler, /t: = target
            /// /t:dll, /t:exe, /t:module (precompiled assembly without metadata,
            /// backend compile wit assembly linker all .net languages to one
            /// Assembly .dll !!! - .net slang: "Multiple Assembly" and one resource Assembly
            /// all Country Languages - .net slang: "Satellite Assembly").
            /// .NET is multi programming with Languages - command line compiler: 
            /// C++ ->          cl /clr 
            /// C#, ->          csc
            /// F#, ->          fsc
            /// VB.NET ->       vbc
            /// Typescript ->   tsc
            /// WinJS ->        jsc
            
            string connectionUrl = "jdbc:sqlserver://localhost:1433;databaseName=master;user=sa;password=Yukon900";
            // removed password for now !!!.
            
            // Load SQL Server JDBC driver and establish connection
            try{
                WriteLine("Connecting to SQL Server......");
                /// import java.sql.DriverManager;
                try(Connection con = DriverManager.getConnection(connectionUrl)){
                    WriteLine("....done");
                    /// Create sample Database
                    Write("Dropping and creating database 'DemoDB' ...");
                    string sql = "DROP DATABASE IF EXISTS [DemoDB]; CREATE DATABASE [DemoDB]";
                    try(Statement state = connection.createStatement()){
                        statement.executeUpdate(sql);
                        WriteLine("done ...");
                    }
                    /// Insert 5 Million rows into the table Orders_with_5M_rows'
                    Write("Inserting 5 Million rows into table 'Orders_with_5M_rows'. Thos takes ~30 seconds, please wait......");
                    ///-----------------------------StringBuilder-------------------------------
                    /// Both Language C# and Java - StringBuilder are 3000 faster as string !!!.
                    /// inside StringBuilderCache.
                    /// Expand StringBuilder for all Visual C++ Buffers !, set following:
                    /// -------------StringBuilder(min integer, max integer)--------------------
                    /// var sb = new StringBuilder(255, 2000000000)
                    /// so when string longer as 255 chars, 
                    /// StringBuilder expand to maximal Value ! automatic !.
                    /// Ground: minium must everytime smaller as maxium !!!.
                    /// Is string greather as maxium sets, concate the string !.
                    /// TCHAR Buffer        - StringBuilder Buffer,
                    /// DWORD BufferSize    - int sb
                    /// var sb = new StringBuilder(255, 8096);
                    /// method(..., Buffer, sb.capacity); --> capacity to maxium expand.
                    ///
                    ///
                    ///-------------------------------------------------------------------------
                    var sql = new StringBuilder();
                        sql.append("USE DemoDB");
                        sql.append("WITH a AS (SELECT * FROM (VALUES(1),(2),(3),(4),(5),(6),(7),(8),(9),(10) ) AS a(a)");
                        sql.append("SELECT TOP(5000000) ");
                        sql.append("");
                    /// ....
                    sql.toString();
                    try(Statement state = connection.createStatement() ){
                            WriteLine("...done");
                   */






} // end of namespace::Visual.Galaxy.Framework.Database