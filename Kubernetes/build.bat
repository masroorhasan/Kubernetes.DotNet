@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)
 
set version=1.0.0
if not "%PackageVersion%" == "" (
   set version=%PackageVersion%
)

set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild src\Terrarium.Sdk.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=diag /nr:false

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\Kubernetes.DotNet\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\BouncyCastle.1.8.1\lib\BouncyCastle.Crypto.dll
copy packages\YamlDotNet.4.2.2\lib\net35\YamlDotNet.dll
copy packages\Newtonsoft.Json.10.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll;bin\BouncyCastle.Crypto.dll;YamlDotNet.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\Kubernetes.DotNet.dll /recurse:src\Kubernetes.DotNet\*.cs /doc:bin\Kubernetes.DotNet.xml

