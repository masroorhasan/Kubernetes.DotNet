#!/bin/sh

MajorVersion=$1
MinorVersion=$2
BuildVersion=$3
ApiKey=$4

mono nuget.exe pack ./src/Kubernetes.DotNet/Kubernetes.DotNet.nuspec -Version $MajorVersion.$MinorVersion.$BuildVersion -p Configuration=Release -Verbosity detailed
mono nuget.exe setApiKey $ApiKey -Source https://www.nuget.org -Verbosity quiet
mono nuget.exe push Kubernetes.DotNet.$MajorVersion.$MinorVersion.$BuildVersion.nupkg -Source https://www.nuget.org/api/v2/package