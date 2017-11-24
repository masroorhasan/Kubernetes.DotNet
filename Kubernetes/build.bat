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
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

REM create package
REM %nuget% pack "src\Kubernetes.DotNet\Kubernetes.DotNet.nuspec" -NoPackageAnalysis -verbosity detailed -o bin -Version %version% -p Configuration="%config%"

REM package
mkdir Build
call %nuget% pack "src\Kubernetes.DotNet\Kubernetes.DotNet.csproj" -symbols -o Build -p Configuration=%config% %version%

