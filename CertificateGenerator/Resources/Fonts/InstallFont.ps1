$tempPath = [System.IO.Path]::GetTempPath()
$userFontsFolder = [System.IO.Path]::Combine($env:LOCALAPPDATA, 'Microsoft\Windows\Fonts')
$fontRegPath = "HKCU:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts"

if (!(Test-Path -Path $userFontsFolder)) {
    New-Item -ItemType Directory -Path $userFontsFolder | Out-Null
}

$fontPaths = Get-ChildItem -Path $tempPath -Filter *.ttf -Recurse -ErrorAction SilentlyContinue | Where-Object { -not $_.PSIsContainer } | Select-Object -ExpandProperty FullName

foreach ($fontPath in $fontPaths) {
    $fontFileName = [System.IO.Path]::GetFileName($fontPath)
    $fontName = [System.IO.Path]::GetFileNameWithoutExtension($fontPath)
    $fontDestination = [System.IO.Path]::Combine($userFontsFolder, $fontFileName)
    
    Copy-Item -Path $fontPath -Destination $fontDestination -Force

    Set-ItemProperty -Path $fontRegPath -Name "$fontName (TrueType)" -Value $fontDestination

    Add-Type -TypeDefinition @"
          using System;
          using System.Runtime.InteropServices;

          public class WinAPI
            {
                [DllImport("gdi32.dll", EntryPoint = "AddFontResourceEx")]
                public static extern int AddFontResourceEx(string lpszFilename, uint fl, IntPtr pdv);

                public const int FR_PRIVATE = 0x10;
                public const int FR_NOT_ENUM = 0x20;
            }
"@
        [WinAPI]::AddFontResourceEx($fontDestination, [WinAPI]::FR_PRIVATE, [IntPtr]::Zero) | Out-Null
        Write-Output "$fontName installed successfully."
}

Read-Host "Press Enter to exit..."
