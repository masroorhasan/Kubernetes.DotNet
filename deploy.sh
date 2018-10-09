#!/bin/bash
MajorVersion=$MAJOR_VERSION_NUMBER
MinorVersion=$MINOR_VERSION_NUMBER
BuildVersion=$TRAVIS_BUILD_NUMBER
ApiKey=$NUGET_API_KEY

echo "Packing nuspec package for $MajorVersion.$MinorVersion.$BuildVersion"
mono nuget.exe pack ./src/Kubernetes.DotNet/Kubernetes.DotNet.nuspec -Version $MajorVersion.$MinorVersion.$BuildVersion -p Configuration=Release -Verbosity detailed
mono nuget.exe setApiKey $ApiKey -Source https://www.nuget.org -Verbosity quiet

echo "Pushing package to nuget"
mono nuget.exe push Kubernetes.DotNet.$MajorVersion.$MinorVersion.$BuildVersion.nupkg -Source https://www.nuget.org/api/v2/package
echo "Done"
