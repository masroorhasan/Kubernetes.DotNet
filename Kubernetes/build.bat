REM @echo Off
REM set config=%1
REM if "%config%" == "" (
REM    set config=Release
REM )
 
REM set version=0.7.0
REM if not "%PackageVersion%" == "" (
REM    set version=%PackageVersion%
REM )

REM set nuget=
REM if "%nuget%" == "" (
REM 	set nuget=nuget
REM )

REM rem ************** Build ************** 
REM "%ProgramFiles(x86)%\MSBuild\14.0\bin\MSBuild.exe" Kubernetes\Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

REM rem ************** Pack **************
REM mkdir Build
REM %nuget% pack "Kubernetes\src\Kubernetes.DotNet\Kubernetes.DotNet.nuspec" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"


@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\Kubernetes.DotNet\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.10.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll
copy packages\BouncyCastle.1.8.1\lib\BouncyCastle.Crypto.dll bin\BouncyCastle.Crypto.dll
copy packages\YamlDotNet.4.2.2\lib\net35\YamlDotNet.dll bin\YamlDotNet.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll;bin\BouncyCastle.Crypto.dll;bin\YamlDotNet.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\Kubernetes.DotNet.dll /recurse:src\Kubernetes.DotNet\*.cs

