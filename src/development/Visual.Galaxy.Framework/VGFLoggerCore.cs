


/*
 * Set System Directives here
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Set Windows Directives here
 * \Windows\System\WinMetadata - .winmd the same as .NET Assenblies
 * Referencemanager click by search %dir% Windows.AI.winmd click, add it to Project.
 *  
 */

/*
 * Set here your .NET Assembly Directives
 * 
 */



/*
 * Set here other namespace from other .cs-Files
 * Tip: make all static classes
 * 
 * using Visual.Logger.Engine.namespace.classname
 * 
 */
using static Visual.Galaxy.Framework.LoggerEngine.CLoggerCore;

using static Visual.Operation.System.Native.UnsafeNativeMethods;
using static Visual.Operation.System.Native.NativeRuntimeMethods;







/*-----------------------------------------------------------------------------
 * 
 * 
 * 
 *----------------------------------------------------------------------------- 
 */
namespace Visual.Galaxy.Framework.LoggerEngine
{

    /// <summary>
    /// 
    /// </summary>
    internal static class CLoggerCore
    {

        /*
         * 17:20:46 (lmgrd) -----------------------------------------------
            17:20:46 (lmgrd)   Please Note:
            17:20:46 (lmgrd) 
            17:20:46 (lmgrd)   This log is intended for debug purposes only.
            17:20:46 (lmgrd)   In order to capture accurate license
            17:20:46 (lmgrd)   usage data into an organized repository,
            17:20:46 (lmgrd)   please enable report logging. Use Flexera Software LLC's
            17:20:46 (lmgrd)   software license administration  solution,
            17:20:46 (lmgrd)   FlexNet Manager, to  readily gain visibility
            17:20:46 (lmgrd)   into license usage data and to create
            17:20:46 (lmgrd)   insightful reports on critical information like
            17:20:46 (lmgrd)   license availability and usage. FlexNet Manager
            17:20:46 (lmgrd)   can be fully automated to run these reports on
            17:20:46 (lmgrd)   schedule and can be used to track license
            17:20:46 (lmgrd)   servers and usage across a heterogeneous
            17:20:46 (lmgrd)   network of servers including Windows NT, Linux
            17:20:46 (lmgrd)   and UNIX.
            17:20:46 (lmgrd) 
            17:20:46 (lmgrd) -----------------------------------------------
            17:20:46 (lmgrd) 
            17:20:46 (lmgrd) 
            17:20:46 (lmgrd) Server's System Date and Time: Tue Dec 18 2018 17:20:46 IST
            17:20:46 (lmgrd) SLOG: Summary LOG statistics is enabled.
            17:20:46 (lmgrd) FlexNet Licensing (v11.15.0.0 build 215548 x64_lsb) started on localhost.localdomain (linux) (12/18/2018)
            17:20:46 (lmgrd) Copyright (c) 1988-2017 Flexera Software LLC. All Rights Reserved.
            17:20:46 (lmgrd) World Wide Web:  http://www.flexerasoftware.com
            17:20:46 (lmgrd) License file(s): /opt/intel/serverlicenses/l_FRS6C7JL.lic
            17:20:46 (lmgrd) lmgrd tcp-port 27009
            17:20:46 (lmgrd) (@lmgrd-SLOG@) ===============================================
            17:20:46 (lmgrd) (@lmgrd-SLOG@) === LMGRD ===
            17:20:46 (lmgrd) (@lmgrd-SLOG@) Start-Date: Tue Dec 18 2018 17:20:46 IST
            17:20:46 (lmgrd) (@lmgrd-SLOG@) PID: 15707
            17:20:46 (lmgrd) (@lmgrd-SLOG@) LMGRD Version: v11.15.0.0 build 215548 x64_lsb ( build 215548 (ipv6))
            17:20:46 (lmgrd) (@lmgrd-SLOG@) 
            17:20:46 (lmgrd) (@lmgrd-SLOG@) === Network Info ===
            17:20:46 (lmgrd) (@lmgrd-SLOG@) Listening port: 27009
            17:20:46 (lmgrd) (@lmgrd-SLOG@) 
            17:20:46 (lmgrd) (@lmgrd-SLOG@) === Startup Info ===
            17:20:46 (lmgrd) (@lmgrd-SLOG@) Server Configuration: Single Server
            17:20:46 (lmgrd) (@lmgrd-SLOG@) Command-line options used at LS startup: -c /opt/intel/serverlicenses/l_FRS6C7JL.lic -l /home/sr/log.txt 
            17:20:46 (lmgrd) (@lmgrd-SLOG@) License file(s) used:  /opt/intel/serverlicenses/l_FRS6C7JL.lic
            17:20:46 (lmgrd) (@lmgrd-SLOG@) ===============================================
            17:20:46 (lmgrd) Starting vendor daemons ... 
            17:20:46 (lmgrd) Starting vendor daemon at port 28519
            17:20:46 (lmgrd) Using vendor daemon port 28519 specified in license file
            17:20:46 (lmgrd) Started INTEL (internet tcp_port 28519 pid 15708)
            17:20:46 (INTEL) Unable to initialize access to trusted storage: 2
            17:20:46 (INTEL) FlexNet Licensing version v11.15.0.0 build 215548 x64_lsb
            17:20:46 (INTEL) SLOG: Summary LOG statistics is enabled.
            17:20:46 (INTEL) SLOG: FNPLS-INTERNAL-CKPT1
            17:20:46 (INTEL) SLOG: VM Status: 0
            17:20:46 (INTEL) SLOG: FNPLS-INTERNAL-CKPT5
            17:20:46 (INTEL) SLOG: TPM Status: 0
            17:20:46 (INTEL) SLOG: FNPLS-INTERNAL-CKPT6
            17:20:46 (INTEL) Server started on localhost.localdomain for:	
            17:20:46 (INTEL) IB5A38952 (consisting of:		Comp-CA		
            17:20:46 (INTEL) Comp-CL		Comp-OpenMP	Comp-PointerChecker 
            17:20:46 (INTEL) DbgJTAGL	DbgJTAGW	MKernL		
            17:20:46 (INTEL) PerfAnl		PerfAnlSys	PerfPrimL	
            17:20:46 (INTEL) ThreadAnlGui	ThreadAnlGuiSys ThreadBB)	
            17:20:46 (INTEL) EXTERNAL FILTERS are OFF
            17:20:46 (lmgrd) INTEL using TCP-port 28519
            17:20:46 (INTEL) SLOG: Statistics Log Frequency is 240 minute(s).
            17:20:46 (INTEL) SLOG: TS update poll interval is 600 seconds.
            17:20:46 (INTEL) SLOG: Activation borrow reclaim percentage is 0.
            17:20:46 (INTEL) (@INTEL-SLOG@) ===============================================
            17:20:46 (INTEL) (@INTEL-SLOG@) === Vendor Daemon ===
            17:20:46 (INTEL) (@INTEL-SLOG@) Vendor daemon: INTEL
            17:20:46 (INTEL) (@INTEL-SLOG@) Start-Date: Tue Dec 18 2018 17:20:46 IST
            17:20:46 (INTEL) (@INTEL-SLOG@) PID: 15708
            17:20:46 (INTEL) (@INTEL-SLOG@) VD Version: v11.15.0.0 build 215548 x64_lsb ( build 215548 (ipv6))
            17:20:46 (INTEL) (@INTEL-SLOG@) 
            17:20:46 (INTEL) (@INTEL-SLOG@) === Startup/Restart Info ===
            17:20:46 (INTEL) (@INTEL-SLOG@) Options file used: None
            17:20:46 (INTEL) (@INTEL-SLOG@) Is vendor daemon a CVD: No
            17:20:46 (INTEL) (@INTEL-SLOG@) Is FlexNet Licensing Service installed and compatible: No
            17:20:46 (INTEL) (@INTEL-SLOG@) FlexNet Licensing Service Version: -NA-
            17:20:46 (INTEL) (@INTEL-SLOG@) Is TS accessed: No
            17:20:46 (INTEL) (@INTEL-SLOG@) TS access time: -NA-
            17:20:46 (INTEL) (@INTEL-SLOG@) Number of VD restarts since LS startup: 0
            17:20:46 (INTEL) (@INTEL-SLOG@) 
            17:20:46 (INTEL) (@INTEL-SLOG@) === Network Info ===
            17:20:46 (INTEL) (@INTEL-SLOG@) Listening port: 28519
            17:20:46 (INTEL) (@INTEL-SLOG@) Daemon select timeout (in seconds): 1
            17:20:46 (INTEL) (@INTEL-SLOG@) 
            17:20:46 (INTEL) (@INTEL-SLOG@) === Host Info ===
            17:20:46 (INTEL) (@INTEL-SLOG@) Host used in license file: localhost.localdomain
            17:20:46 (INTEL) (@INTEL-SLOG@) HostID node-locked in license file: a0c5891d5e57 
            17:20:46 (INTEL) (@INTEL-SLOG@) HostID of the License Server: a0c5891d5e57
            17:20:46 (INTEL) (@INTEL-SLOG@) Running on Hypervisor: Not determined - treat as Physical
            17:20:46 (INTEL) (@INTEL-SLOG@) ===============================================

            17:47:46 (lmgrd) -----------------------------------------------
            17:47:46 (lmgrd)   Please Note:
            17:47:46 (lmgrd) 
            17:47:46 (lmgrd)   This log is intended for debug purposes only.
            17:47:46 (lmgrd)   In order to capture accurate license
            17:47:46 (lmgrd)   usage data into an organized repository,
            17:47:46 (lmgrd)   please enable report logging. Use Flexera Software LLC's
            17:47:46 (lmgrd)   software license administration  solution,
            17:47:46 (lmgrd)   FlexNet Manager, to  readily gain visibility
            17:47:46 (lmgrd)   into license usage data and to create
            17:47:46 (lmgrd)   insightful reports on critical information like
            17:47:46 (lmgrd)   license availability and usage. FlexNet Manager
            17:47:46 (lmgrd)   can be fully automated to run these reports on
            17:47:46 (lmgrd)   schedule and can be used to track license
            17:47:46 (lmgrd)   servers and usage across a heterogeneous
            17:47:46 (lmgrd)   network of servers including Windows NT, Linux
            17:47:46 (lmgrd)   and UNIX.
            17:47:46 (lmgrd) 
            17:47:46 (lmgrd) -----------------------------------------------
            17:47:46 (lmgrd) 
            17:47:46 (lmgrd) 
            17:47:46 (lmgrd) Server's System Date and Time: Tue Dec 18 2018 17:47:46 IST
            17:47:46 (lmgrd) SLOG: Summary LOG statistics is enabled.
            17:47:46 (lmgrd) FlexNet Licensing (v11.15.0.0 build 215548 x64_lsb) started on localhost.localdomain (linux) (12/18/2018)
            17:47:46 (lmgrd) Copyright (c) 1988-2017 Flexera Software LLC. All Rights Reserved.
            17:47:46 (lmgrd) World Wide Web:  http://www.flexerasoftware.com
            17:47:46 (lmgrd) License file(s): /opt/intel/licenses/l_FRS6C7JL.lic
            17:47:46 (lmgrd) lmgrd tcp-port 9002
            17:47:46 (lmgrd) (@lmgrd-SLOG@) ===============================================
            17:47:46 (lmgrd) (@lmgrd-SLOG@) === LMGRD ===
            17:47:46 (lmgrd) (@lmgrd-SLOG@) Start-Date: Tue Dec 18 2018 17:47:46 IST
            17:47:46 (lmgrd) (@lmgrd-SLOG@) PID: 17272
            17:47:46 (lmgrd) (@lmgrd-SLOG@) LMGRD Version: v11.15.0.0 build 215548 x64_lsb ( build 215548 (ipv6))
            17:47:46 (lmgrd) (@lmgrd-SLOG@) 
            17:47:46 (lmgrd) (@lmgrd-SLOG@) === Network Info ===
            17:47:46 (lmgrd) (@lmgrd-SLOG@) Listening port: 9002
            17:47:46 (lmgrd) (@lmgrd-SLOG@) 
            17:47:46 (lmgrd) (@lmgrd-SLOG@) === Startup Info ===
            17:47:46 (lmgrd) (@lmgrd-SLOG@) Server Configuration: Single Server
            17:47:46 (lmgrd) (@lmgrd-SLOG@) Command-line options used at LS startup: -c /opt/intel/licenses/l_FRS6C7JL.lic -l /home/sr/log.txt 
            17:47:46 (lmgrd) (@lmgrd-SLOG@) License file(s) used:  /opt/intel/licenses/l_FRS6C7JL.lic
            17:47:46 (lmgrd) (@lmgrd-SLOG@) ===============================================
            17:47:46 (lmgrd) Starting vendor daemons ... 
            17:47:46 (lmgrd) Starting vendor daemon at port 9006
            17:47:46 (lmgrd) Using vendor daemon port 9006 specified in license file
            17:47:46 (lmgrd) Started INTEL (internet tcp_port 9006 pid 17273)
            17:47:46 (INTEL) Unable to initialize access to trusted storage: 2
            17:47:46 (INTEL) FlexNet Licensing version v11.15.0.0 build 215548 x64_lsb
            17:47:46 (INTEL) SLOG: Summary LOG statistics is enabled.
            17:47:46 (INTEL) SLOG: FNPLS-INTERNAL-CKPT1
            17:47:46 (INTEL) SLOG: VM Status: 0
            17:47:46 (INTEL) SLOG: FNPLS-INTERNAL-CKPT5
            17:47:46 (INTEL) SLOG: TPM Status: 0
            17:47:46 (INTEL) SLOG: FNPLS-INTERNAL-CKPT6
            17:47:46 (INTEL) Server started on localhost.localdomain for:	
            17:47:46 (INTEL) IB5A38952 (consisting of:		Comp-CA		
            17:47:46 (INTEL) Comp-CL		Comp-OpenMP	Comp-PointerChecker 
            17:47:46 (INTEL) DbgJTAGL	DbgJTAGW	MKernL		
            17:47:46 (INTEL) PerfAnl		PerfAnlSys	PerfPrimL	
            17:47:46 (INTEL) ThreadAnlGui	ThreadAnlGuiSys ThreadBB)	
            17:47:46 (INTEL) EXTERNAL FILTERS are OFF
            17:47:46 (lmgrd) INTEL using TCP-port 9006
            17:47:46 (INTEL) SLOG: Statistics Log Frequency is 240 minute(s).
            17:47:46 (INTEL) SLOG: TS update poll interval is 600 seconds.
            17:47:46 (INTEL) SLOG: Activation borrow reclaim percentage is 0.
            17:47:46 (INTEL) (@INTEL-SLOG@) ===============================================
            17:47:46 (INTEL) (@INTEL-SLOG@) === Vendor Daemon ===
            17:47:46 (INTEL) (@INTEL-SLOG@) Vendor daemon: INTEL
            17:47:46 (INTEL) (@INTEL-SLOG@) Start-Date: Tue Dec 18 2018 17:47:46 IST
            17:47:46 (INTEL) (@INTEL-SLOG@) PID: 17273
            17:47:46 (INTEL) (@INTEL-SLOG@) VD Version: v11.15.0.0 build 215548 x64_lsb ( build 215548 (ipv6))
            17:47:46 (INTEL) (@INTEL-SLOG@) 
            17:47:46 (INTEL) (@INTEL-SLOG@) === Startup/Restart Info ===
            17:47:46 (INTEL) (@INTEL-SLOG@) Options file used: None
            17:47:46 (INTEL) (@INTEL-SLOG@) Is vendor daemon a CVD: No
            17:47:46 (INTEL) (@INTEL-SLOG@) Is FlexNet Licensing Service installed and compatible: No
            17:47:46 (INTEL) (@INTEL-SLOG@) FlexNet Licensing Service Version: -NA-
            17:47:46 (INTEL) (@INTEL-SLOG@) Is TS accessed: No
            17:47:46 (INTEL) (@INTEL-SLOG@) TS access time: -NA-
            17:47:46 (INTEL) (@INTEL-SLOG@) Number of VD restarts since LS startup: 0
            17:47:46 (INTEL) (@INTEL-SLOG@) 
            17:47:46 (INTEL) (@INTEL-SLOG@) === Network Info ===
            17:47:46 (INTEL) (@INTEL-SLOG@) Listening port: 9006
            17:47:46 (INTEL) (@INTEL-SLOG@) Daemon select timeout (in seconds): 1
            17:47:46 (INTEL) (@INTEL-SLOG@) 
            17:47:46 (INTEL) (@INTEL-SLOG@) === Host Info ===
            17:47:46 (INTEL) (@INTEL-SLOG@) Host used in license file: localhost.localdomain
            17:47:46 (INTEL) (@INTEL-SLOG@) HostID node-locked in license file: a0c5891d5e57 
            17:47:46 (INTEL) (@INTEL-SLOG@) HostID of the License Server: a0c5891d5e57
            17:47:46 (INTEL) (@INTEL-SLOG@) Running on Hypervisor: Not determined - treat as Physical
            17:47:46 (INTEL) (@INTEL-SLOG@) ===============================================
         * 
         * 
         */

            /// <summary>
            /// 
            /// </summary>
            internal enum VLEEngineLoggingLevel
            {
                Normal,
                Debug
            }



    } // END_OF_CLASS::CLoggerCore








} // END_OF_NAMESPACES:: Visual.Galaxy.Framework.LoggerEngine


