#Requires -RunAsAdministrator
#Requires -Modules WebAdministration

[CmdletBinding()]
param (
  [Parameter()]
  [string]
  $CertificatePfxPath,

  [Parameter()]
  [string]
  $CmsDomain = 'medioclinic-cms',

  [Parameter()]
  [string]
  $LiveSiteDomain = 'medioclinic'
)

$baseFilePath = Resolve-Path -Path "$PSScriptRoot/../src/"

$cmsAppPool = New-WebAppPool -Path $CmsDomain
$cmsAppPool | Set-Item

$cmsWebSite = New-WebSite -Name $CmsDomain -Port 80 -HostHeader $CmsDomain -PhysicalPath "$filePathBase/CMS" -ApplicationPool $cmsAppPool.Name

$liveSiteAppPool = New-WebAppPool -Path $LiveSiteDomain
$liveSiteAppPool.managedRuntimeVersion = ""
$liveSiteAppPool | Set-Item




