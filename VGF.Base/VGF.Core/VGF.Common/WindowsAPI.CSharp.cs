///----------------------------------------------
/// Microsoft never documented this Methods
/// at Windows 7 System.
/// but all Exported Methods for use !.
///
/// MessageBoxTimeout - user32.dll
///
///
///
///
///
///----------------------------------------------------------------------------
///
/// Visual C/C++ Method from "user32.dll"
///
/// unicode version - set CharSet.unicode
///int MessageBoxTimeoutW(
///          			HWND hWnd,
///          			LPCWSTR lpText,
///          			LPCWSTR lpCaption,
///          			UINT uType,
///          			WORD wLanguageId,
///          			DWORD dwMilliseconds);
///
/// #define MB_TIMEDOUT 32000
///----------------------------------------------------------------------------

///
/// Visual C++ call
///
///int MessageBoxTimeoutW(
///                           HWND hWnd, 
///                           LPCWSTR lpText, 
///                           LPCWSTR lpCaption,
///                           UINT uType, 
///                           WORD wLanguageId,
///                           DWORD dwMilliseconds)
{
    static MSGBOXWAPI MsgBoxTOW = NULL;

    if (!MsgBoxTOW)
    {
        HMODULE hUser32 = GetModuleHandle(_T("user32.dll"));
        if (hUser32)
        {
            MsgBoxTOW = (MSGBOXWAPI)GetProcAddress(hUser32, 
                                      "MessageBoxTimeoutW");
            //fall through to 'if (MsgBoxTOW)...'
        }
        else
        {
            //stuff happened, add code to handle it here 
            //(possibly just call MessageBox())
            return 0;
        }
    }

    if (MsgBoxTOW)
    {
        return MsgBoxTOW(hWnd, lpText, lpCaption, 
               uType, wLanguageId, dwMilliseconds);
    }

    return 0;
}
//End required definitions <--


///----------------------------------------------------------------
/// Visual C# Convert
///
///
///----------------------------------------------------------------
[DllImport("user32.dll", SetLastError = true)]
private static extern uint MessageBoxTimeout(
                    						IntPtr WindowsHandle,
                    						String text,
                    						String title,
                    						uint type,
                    						ushort wLanguageId,
                    						int milliseconds);




private static uint SetupCallMessageBoxTimeOut(   IntPtr WindowsHandle,
                                                  string Message,
                                                  string Caption, 
                                                  uint MessageBoxOptions,
                                                  int TimeOutMilliSeconds)
 {
      return MessageBoxTimeout(WindowsHandle , Message, Caption, MessageBoxOptions, 0, TimeOutMilliSeconds);
 }

[DllImport("user32.dll")]
static extern bool RedrawWindow(
				IntPtr hWnd, 
				[In] ref RECT lprcUpdate,
				IntPtr hrgnUpdate,
				RedrawWindowFlags flags);




[DllImport ( "kernel32.dll", SetLastError = true, CharSet = CharSet.Auto )]
static extern uint SearchPath (
				string lpPath,
				string lpFileName,
				string lpExtension,
				int nBufferLength,
				StringBuilder lpBuffer,
				out IntPtr lpFilePart );



public bool scpSearchFile(string FileName)
{
	/// Set StringBuilder faster as string
	StringBuilder sb = new StringBuilder ( 260 );
	IntPtr ptr = new IntPtr ( );
	
	SearchPath ( null ,
         "NOTEPAD.EXE" ,
          null ,
          sb.Capacity ,
          sb ,
          out ptr );

    Console.WriteLine ( sb.ToString ( ) );
 }



///-------------------------------------------------
/// GetVolumeInformation
///
///
///
///-------------------------------------------------
[Flags]
 public enum FileSystemFeature : uint {
     /// <summary>
     /// The file system supports case-sensitive file names.
     /// </summary>
     CaseSensitiveSearch = 1,
     /// <summary>
     /// The file system preserves the case of file names when it places a name on disk.
     /// </summary>
     CasePreservedNames = 2,
     /// <summary>
     /// The file system supports Unicode in file names as they appear on disk.
     /// </summary>
     UnicodeOnDisk = 4,
     /// <summary>
     /// The file system preserves and enforces access control lists (ACL).
     /// </summary>
     PersistentACLS = 8,
     /// <summary>
     /// The file system supports file-based compression.
     /// </summary>
     FileCompression = 0x10,
     /// <summary>
     /// The file system supports disk quotas.
     /// </summary>
     VolumeQuotas = 0x20,
     /// <summary>
     /// The file system supports sparse files.
     /// </summary>
     SupportsSparseFiles = 0x40,
     /// <summary>
     /// The file system supports re-parse points.
     /// </summary>
     SupportsReparsePoints = 0x80,
     /// <summary>
     /// The specified volume is a compressed volume, for example, a DoubleSpace volume.
     /// </summary>
     VolumeIsCompressed = 0x8000,
     /// <summary>
     /// The file system supports object identifiers.
     /// </summary>
     SupportsObjectIDs = 0x10000,
     /// <summary>
     /// The file system supports the Encrypted File System (EFS).
     /// </summary>
     SupportsEncryption = 0x20000,
     /// <summary>
     /// The file system supports named streams.
     /// </summary>
     NamedStreams = 0x40000,
     /// <summary>
     /// The specified volume is read-only.
     /// </summary>
     ReadOnlyVolume = 0x80000,
     /// <summary>
     /// The volume supports a single sequential write.
     /// </summary>
     SequentialWriteOnce = 0x100000,
     /// <summary>
     /// The volume supports transactions.
     /// </summary>
     SupportsTransactions = 0x200000,
 }




///---------------------------------------------------------------------
/// Set DllImport
///
///---------------------------------------------------------------------
[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
internal extern static bool GetVolumeInformation(
                                                     string RootPathName,
                                                     StringBuilder VolumeNameBuffer,
                                                     int VolumeNameSize,
                                                     out uint VolumeSerialNumber,
                                                     out uint MaximumComponentLength,
                                                     out FileSystemFeature FileSystemFlags,
                                                     StringBuilder FileSystemNameBuffer,
                                                     int nFileSystemNameSize);


StringBuilder volname = new StringBuilder(261);
 StringBuilder fsname = new StringBuilder(261);
 uint sernum, maxlen;
 FileSystemFeature flags;
 if(!GetVolumeInformation("c:\\", volname, volname.Capacity, out sernum, out maxlen, out flags, fsname, fsname.Capacity))
     Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
 string volnamestr = volname.ToString();
 string fsnamestr = fsname.ToString();



public string scpGetVolumeSerial(string DriveLetter)
{
	/// Check for valid drive letter argument. 
	const string ValidDriveLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	If(ValidDriveLetters.IndexOf(DriveLetter) <> -1)
	{
		
		If(DriveLetter.Length = 1)
		{
			Disk As New System.Management.ManagementObject("Win32_LogicalDisk.DeviceID=""" & DriveLetter & ":""");
			DiskProperty As System.Management.PropertyData;
         		
			Foreach (DiskProperty In Disk.Properties)
			{
				If(DiskProperty.Name = "VolumeSerialNumber")
				{
					return DiskProperty.Value.ToString;///.ToString 'Return the volume serial number. 
         			}
         		}
		}
	}
}


///------------------------------------------------------
/// GlobalMemoryStatusEx
///
///------------------------------------------------------
[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
internal static extern bool GlobalMemoryStatusEx( [In,Out] MEMORYSTATUSEX lpBuffer);
///Used to use ref with comment below
/// but ref doesn't work.(Use of [In, Out] instead of ref 
///causes access violation exception on windows XP
///comment: most probably caused by MEMORYSTATUSEX being declared as a class
///(at least at pinvoke.net). On Win7, ref and struct work.

///-----------------------------------------------------------------
/// Erweiterung von SetComputerName
///
///
///-----------------------------------------------------------------
[DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
internal static extern byte SetComputerNameEx(
                              						COMPUTER_NAME_FORMAT NameType,
                              						string lpBuffer);
///-----------------------------------------------------------------
/// Erweiterung von GetComputerName
/// Set in Visual C# byte for Windows Boolean is only 1 Byte !
/// bool in Visual C# is 4 Bytes, hardcoded - true and false.
/// Source form Microsoft Developer Brian Harry .NET Framework
///-----------------------------------------------------------------
[DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
internal static extern byte GetComputerNameEx(
						COMPUTER_NAME_FORMAT NameType,
						StringBuilder lpBuffer,
						uint lpnSize);

enum COMPUTER_NAME_FORMAT
{
         ComputerNameNetBIOS,
         ComputerNameDnsHostname,
         ComputerNameDnsDomain,
         ComputerNameDnsFullyQualified,
         ComputerNamePhysicalNetBIOS,
         ComputerNamePhysicalDnsHostname,
         ComputerNamePhysicalDnsDomain,
         ComputerNamePhysicalDnsFullyQualified
}


public string scpGetComputerDNSDomainName()
{
	bool success;

	StringBuilder name = new StringBuilder(260, 1024);

	if(!success = GetComputerNameEx(COMPUTER_NAME_FORMAT.ComputerNameDnsDomain, name, sb.capacity))
	{
		return string.format("Name not avialable");
	}
	else
	{
	return name.ToString();
	}
}
      

///
/// ComputerNamePhysicalDnsHostname used to rename the computer name and netbios name before domain join
///
public static bool scpSetComputerPhysDNSHostName(string name)
{
         try
         {
         return SetComputerNameEx(COMPUTER_NAME_FORMAT.ComputerNamePhysicalDnsHostname, name);
         }
         catch (Exception)
         {
         return false;
         }
     }



///----------------------------------------------------------------------------
/// Papierkorb leeren
///
/// Parameter:	WindowHandle bindung an Fenster ?:
///		1. this.handle
///
///		WindowHandle keine bindung ans Fenster:
///		2. IntPtr.zero
///-----------------------------------------------------------------
[DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
internal static extern int SHEmptyRecycleBin(
                    						IntPtr WindowHandle,
                    						string pszRootPath,
                    						uint dwFlags);

///-----------------------------------------------------------------
/// dwFlags here:
///
///         
/// No dialog box confirming the deletion of the objects will be displayed.
///
const int SHERB_NOCONFIRMATION = 0x00000001;

///-----------------------------------------------------------------
/// No dialog box indicating the progress will be displayed. 
///
///-----------------------------------------------------------------
const int SHERB_NOPROGRESSUI = 0x00000002;

///-----------------------------------------------------------------
/// No sound will be played when the operation is complete. 
///
///-----------------------------------------------------------------
const int SHERB_NOSOUND = 0x00000004;

///-----------------------------------------------------------------
/// C# call:
///-----------------------------------------------------------------
SHEmptyRecycleBin(
			IntPtr.Zero, /// not bound to window
			rootPath,    /// Drive letter
			SHERB_NOCONFIRMATION | SHERB_NOPROGRESSUI | SHERB_NOSOUND);

///-----------------------------------------------------------------




















































