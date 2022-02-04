#Requires -RunAsAdministrator

# Install SQL Server and SSMS by hand using defaults or desired settings.
# Allow SQL Firewall port (not needed for local development)
netsh advfirewall firewall add rule name = SQLPort dir = in protocol = tcp action = allow localport = 1433 remoteip = localsubnet profile = PRIVATE

$features = @(
  'IIS-ManagementConsole'
  'IIS-ASPNET45'
  'IIS-NetFxExtensibility45'
  'IIS-ISAPIExtensions'
  'IIS-ISAPIFilter'
  'IIS-StaticContent'
)

Enable-WindowsOptionalFeature -Online -All -FeatureName $features -LogLevel Errors
