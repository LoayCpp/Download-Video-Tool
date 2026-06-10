#define MyAppName "Video Downloader"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Luai Anwar"
#define MyAppURL "https://github.com/LoayCpp/Download-Video-Tool"
#define MyAppExeName "DownloadVideo.exe"

[Setup]
AppId={{AA3BD631-C211-47D5-8E92-903FBA8E73A1}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}

DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
DisableProgramGroupPage=yes

; 🔥 مهم جداً (ناتج داخل dist)
OutputDir=dist
OutputBaseFilename=Video_Downloader_Setup

SetupIconFile=Gemini_Generated_Image_micfqmmicfqmmicf.ico

SolidCompression=yes
WizardStyle=modern

Compression=lzma2
LZMAUseSeparateProcess=yes
LZMADictionarySize=1048576

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "arabic"; MessagesFile: "compiler:Languages\Arabic.isl"

[Tasks]
Name: "desktopicon"; Description: "Create Desktop Icon"; Flags: unchecked

[Files]
; 🚀 أهم نقطة: نأخذ من publish (وليس bin)
Source: "..\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Launch {#MyAppName}"; Flags: nowait postinstall skipifsilent
