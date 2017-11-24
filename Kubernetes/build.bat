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
call %NuGet% restore Kubernetes\src\Kubernetes.DotNet\packages.config -OutputDirectory %cd%\packages -NonInteractive
REM call %NuGet% restore GoogleAnalyticsTracker.WP7\packages.config -OutputDirectory %cd%\packages -NonInteractive

REM Build
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" Kubernetes\Kubernetes.DotNet.sln /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

rem ************** Pack **************
mkdir Build
%nuget% pack "Kubernetes\src\Kubernetes.DotNet\Kubernetes.DotNet.csproj" -NoPackageAnalysis -verbosity detailed -o Build -Version %version% -p Configuration="%config%"

REM Package
mkdir Build
mkdir Build\net40
call %NuGet% pack "Kubernetes\src\Kubernetes.DotNet\Kubernetes.DotNet.csproj" -symbols -o Build\net40 -p Configuration=%config% %version%
copy Kubernetes\src\Kubernetes.DotNet\bin\%config%\*.dll Build\net40
copy Kubernetes\src\Kubernetes.DotNet\bin\%config%\*.pdb Build\net40