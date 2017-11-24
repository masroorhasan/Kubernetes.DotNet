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

rem ************** Build ************** 
"%ProgramFiles(x86)%\MSBuild\14.0\bin\MSBuild.exe" Kubernetes\Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

rem ************** Pack **************
mkdir Build
%nuget% pack "Kubernetes\src\Kubernetes.DotNet\Kubernetes.DotNet.nuspec" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"