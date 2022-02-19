USE [master]
GO
CREATE LOGIN [medioclinic] WITH PASSWORD=N'kLmX1Ay5FbKkmGlinNI3', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [medioclinic]
GO
CREATE USER [medioclinic] FOR LOGIN [medioclinic]
GO
USE [medioclinic]
GO
ALTER ROLE [db_owner] ADD MEMBER [medioclinic]
GO
