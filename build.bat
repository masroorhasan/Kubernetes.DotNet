@echo Off
set config=%1
if "%config%" == "" (
   set config=Release
)
 
set version=0.7.0
if not "%PackageVersion%" == "" (
   set version=%PackageVersion%
)

REM Package restore
call %NuGet% restore src\Kubernetes.DotNet\packages.config -OutputDirectory packages -NonInteractive
call %NuGet% restore src\Kubernetes.DotNet.Test\packages.config -OutputDirectory packages -NonInteractive

REM Build
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

rem ************** Pack **************
mkdir Build
%nuget% pack "src\Kubernetes.DotNet\Kubernetes.DotNet.csproj" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"

REM Package
mkdir Build
mkdir Build\net40
call %NuGet% pack "src\Kubernetes.DotNet\Kubernetes.DotNet.csproj" -symbols -o Build\net40 -p Configuration=%config% %version%
copy src\Kubernetes.DotNet\bin\%config%\*.dll Build\net40
copy src\Kubernetes.DotNet\bin\%config%\*.pdb Build\net40