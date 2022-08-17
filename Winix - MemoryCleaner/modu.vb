Module modu
    'Option Explicit On
    Public Declare Function ExitWindowsEx Lib "user32" (ByVal uFlags As Long, ByVal dwReserved As Long) As Long
    Public Const EWX_SHUTDOWN = 1
    Public Const EWX_REBOOT = 2
    Public Const EWX_LOGOFF = 0
End Module
