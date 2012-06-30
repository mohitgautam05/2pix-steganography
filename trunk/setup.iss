; 2pix Setup Script
; Scott Clayton

[Setup]
AppId={{21120BBD-2CC6-48FA-A352-90F42A1D9C08}
AppName=2pix Stenography Tool 
AppVersion=1.2
AppPublisher=Scott Clayton 
AppPublisherURL=http://code.google.com/p/2pix-steganography/
AppSupportURL=http://code.google.com/p/2pix-steganography/
AppUpdatesURL=http://code.google.com/p/2pix-steganography/
DefaultDirName={pf}\2pix Steganography Tool
DefaultGroupName=2pix Steganography Tool
LicenseFile=.\LICENSE.txt
OutputDir=.
OutputBaseFilename=setup2pix
SetupIconFile=.\art\icon006.ico
Compression=lzma
SolidCompression=yes
WizardImageFile=.\art\setup.bmp
WizardSmallImageFile=.\art\setupUR.bmp

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: ".\2pix\bin\Release\2pix.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\2pxcmd\bin\Release\2pixcmd.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\ScottClayton.Stenography.2pix\bin\Release\ScottClayton.Stenography.2pix.dll"; DestDir: "{app}"; Flags: ignoreversion       
Source: ".\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\VERSION.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\2pix Steganography Tool"; Filename: "{app}\2pix.exe"
Name: "{group}\{cm:ProgramOnTheWeb,2pix Steganography Tool}"; Filename: "http://code.google.com/p/2pix-steganography/"
Name: "{group}\{cm:UninstallProgram,2pix Steganography Tool}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\2pix Steganography Tool"; Filename: "{app}\2pix.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\2pix Stenography Tool"; Filename: "{app}\2pix.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\2pix.exe"; Description: "{cm:LaunchProgram,2pix Stenography Tool}"; Flags: nowait postinstall skipifsilent

;[Registry]
;Root: HKCR; Subkey: ".bmp\OpenWithList\2pixcmd.exe"; ValueType: string; ValueData: ""
;Root: HKCR; Subkey: "Paint.Picture\SupportedTypes"; ValueType: string; ValueName: ".bmp"; ValueData: ""
;Root: HKCR; Subkey: "Paint.Picture\shell\ExtractWith2pix"; ValueType: string; ValueData: "Extract With &2pix"
;Root: HKCR; Subkey: "Paint.Picture\shell\ExtractWith2pix\command"; ValueType: string; ValueData: "{app}\2pixcmd.exe %1"






