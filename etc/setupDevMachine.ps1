#Requires -RunAsAdministrator

# Install SQL Server and SSMS by hand using defaults or desired settings.

$features = @(
  'IIS-ManagementConsole'
  'IIS-ASPNET45'
  'IIS-NetFxExtensibility45'
  'IIS-ISAPIExtensions'
  'IIS-ISAPIFilter'
  'IIS-StaticContent'
)

Enable-WindowsOptionalFeature -Online -All -FeatureName $features -LogLevel Errors

# Allow SQL Firewall port
netsh advfirewall firewall add rule name = SQLPort dir = in protocol = tcp action = allow localport = 1433 remoteip = localsubnet profile = PRIVATE


# For Windows Authentication (lsa tweaks may or may not be needed)
# $lsaRegPath = 'HKLM:\SYSTEM\CurrentControlSet\Control\Lsa'
# New-ItemProperty -Path $lsaRegPath -Name 'DisableStrictNameChecking' -PropertyType 'DWORD' -Value 1 -Force | Out-Null
# New-ItemProperty -Path $lsaRegPath -Name 'DisableLoopbackCheck' -PropertyType 'DWORD' -Value 1 -Force | Out-Null
# Enable-WindowsOptionalFeature -Online -All -FeatureName 'IIS-WindowsAuthentication' -LogLevel Errors
