@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)
 
set version=0.7.0
if not "%PackageVersion%" == "" (
   set version=%PackageVersion%
)

set nuget=
if "%nuget%" == "" (
	set nuget=nuget
)

REM install packages
REM %nuget% install src\Kubernetes.DotNet\packages.config -o packages
REM if not exist ".\bin" mkdir bin
REM copy packages\BouncyCastle.1.8.1\lib\BouncyCastle.Crypto.dll bin\BouncyCastle.Crypto.dll
REM copy packages\YamlDotNet.4.2.2\lib\net35\YamlDotNet.dll bin\YamlDotNet.dll
REM copy packages\Newtonsoft.Json.10.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
REM copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll

REM build solution
REM Build
"%ProgramFiles(x86)%\MSBuild\14.0\bin\MSBuild.exe" Kubernetes\Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false
REM package
mkdir Build
%nuget% pack "Kubernetes\src\Kubernetes.DotNet\Kubernetes.DotNet.nuspec" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"