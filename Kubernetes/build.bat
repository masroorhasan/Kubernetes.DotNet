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

%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=diag /nr:false

%nuget% install Kubernetes\src\Kubernetes.DotNet\packages.config -o packages
if not exist ".\bin" mkdir bin
copy packages\BouncyCastle.1.8.1\lib\BouncyCastle.Crypto.dll
copy packages\YamlDotNet.4.2.2\lib\net35\YamlDotNet.dll
copy packages\Newtonsoft.Json.10.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.1.0\lib\net45\RestSharp.dll bin\RestSharp.dll

%nuget% pack "Kubernetes\src\Kubernetes.DotNet\Kubernetes.DotNet.nuspec" -NoPackageAnalysis -verbosity detailed -o bin -Version %version% -p Configuration="%config%"

