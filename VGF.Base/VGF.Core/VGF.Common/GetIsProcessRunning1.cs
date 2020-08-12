// using System.Diagnostics;

/// <summary>
/// Check if a process is running
/// </summary>
/// <param name="processname">the processname</param>
/// <returns>true if the process runns otherwise false</returns>
private bool VGFCheckIfAProcessIsRunning(string processname)
{
   return Process.GetProcessesByName(processname).Length > 0;            
}
