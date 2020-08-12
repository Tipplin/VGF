Alternative Managed API:

///
/// System Directives
///
using System.Diagnostics;

/// same in.NET as CancelShutdown (user32.dll - Win7) from WinAPI.
///
/// Cancels shutdown of the Computer
Process.Start("Shutdown", "-a");
