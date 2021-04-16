using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








/* ----------------------------------------------------------------------------
 *  Windows Management Instrumentation - short WMI
 * ----------------------------------------------------------------------------
 * Operating System Classes
 * The Operating System category groups classes that 
 * represent operating system related objects. 
 * They denote the various configurations and settings 
 * that define a computing environment. 
 * Examples include: the boot configuration, Component Object Model (COM) 
 * settings, desktop environment settings, drivers, security settings, 
 * user settings, and registry settings.
 * 
 * The Operating System category is grouped into the following subcategories:
 * 
 * COM
 * Desktop
 * Drivers
 * Event log
 * File system - CIFS
 * FAT---------- all flash storages - Smart card, cards, USB-Stick - Limit 32 GB! by Format Function
 * FAT32-------- all flash storages - Smart card, cards, USB-Stick - For 32, 64, 128 GB by FormatEx Function
 * All Flash Storages are pre-formatted from Vendors, delete all and new format the USB-Stick !.
 * FMIFS.dll - written by Microsoft CTO Russovinc.
 * Exported Functions (C/C++): 
 * Format, FormatEx, Chkdsk - Checkdisk, QueryDeviceInformation,
 * CheckDisk the same as Microsoft System-Tool. 
 * Create your own Check Disk App, and the best have an Parameter verbose, 
 * the Tool can repair Sectors on Harddrive.
 * But NOTE! if an great Harddrive the Tool longer running - many Hours - he steps into Sectors and more...
 * Same System-Tools helps you by many Works, RAM - Work Storage - Problem/Defect ?, secure the Computer - SystemPropertyProtection,
 * by 64 BIT System set NOEXECUTEBIT abot Malware is Flag in System, stopped the execution App and terminate by Virus or others, little help!
 * After Meeting, the 32 BIT Area goes END! - First Vendors only with 64 BIT Systems: IBM, Apple, NVIDIA,
 * (Meeting: 128 BIT Operation System ?! - The first was AS/400 inside written, Father IBM Frank Soltis)
 * (The Windows NT 4.0 with 64 BIT inside written, Father Microsoft Dave Cutler)
 * (The Windows NT 10.0 is Windows 10.)
 * 
 * 
 * NTFS---------
 * Refs---------
 * 
 * 
 * Job objects
 * Memory and page files
 * Multimedia audio or visual
 * Networking
 * Operating system events - everytime the thread is longer runs, set DoEvents() by VB.NET and Visual C#, Time Scheduler by 55ms switch to other Thread.
 * Operating system settings
 * Processes
 * Registry
 * Scheduler jobs
 * Security
 * Services
 * Shares
 * Start menu
 * Storage
 * Users
 * Windows product activation
 * 
 *  all Windows Operation System Classes
 *  all for more Information about Hardware and Software.
 * ----------------------------------------------------------------------------
 *  CDROMDrive Information
 *  NOTE! Windows Operation System have own datatypes,
 *  real, real64, string[],
 *  all must convert by Visual C#
 *  see boolean is Windows boolean! only 1 byte!
         class CIM_CDROMDrive : CIM_MediaAccessDevice
        {
          string   Caption;
          string   Description;
          datetime InstallDate;
          string   Name;
          string   Status;
          uint16   Availability;
          uint32   ConfigManagerErrorCode;
          // NOTE! Windows boolean is 1 byte! in Visual C# set byte, not bool !
          boolean  ConfigManagerUserConfig; 
          string   CreationClassName;
          string   DeviceID;
          uint16   PowerManagementCapabilities[];
          // NOTE! Windows boolean is 1 byte! in Visual C# set byte, not bool !
          boolean  ErrorCleared;
          string   ErrorDescription;
          uint32   LastErrorCode;
          string   PNPDeviceID;
          // NOTE! Windows boolean is 1 byte! in Visual C# set byte, not bool !
          boolean  PowerManagementSupported;
          uint16   StatusInfo;
          string   SystemCreationClassName;
          string   SystemName;
          uint16   Capabilities[];
          string   CapabilityDescriptions[];
          string   CompressionMethod;
          uint64   DefaultBlockSize;
          string   ErrorMethodology;
          uint64   MaxBlockSize;
          uint64   MaxMediaSize;
          uint64   MinBlockSize;
          // NOTE! Windows boolean is 1 byte! in Visual C# set byte, not bool !
          boolean  NeedsCleaning;
          uint32   NumberOfMediaSupported;
        };


    class CIM_ComputerSystem : CIM_System
    {
      string   Caption;
      string   Description;
      datetime InstallDate;
      string   Status;
      string   CreationClassName;
      string   Name;
      string   PrimaryOwnerContact;
      string   PrimaryOwnerName;
      string   Roles[];
      string   NameFormat;
    };

*/











//-----------------------------------------------------------------------------
// Windows Management Instrumentation - Windows Operation System Classes
//
//-----------------------------------------------------------------------------
namespace Visual.Galaxy.Framework.WMI
{

    /// <summary>
    /// 
    /// </summary>
    public static class VGFWMI
    {

        /// <summary>
        /// Get Device ID
        /// </summary>
        /// <returns></returns>
        public static string VGFGetDeviceID()
        {

            return null;




        } // end of method::VGFGetDeviceID













} // end of class::WGFWMI

} // end of namespace:: Visual.Galaxy.Framework.WMI
