CREATE DATABASE [Sample]
GO
USE [Sample]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
    [Id] [bigint] IDENTITY(1,1) NOT NULL,
    [FirstName] [nvarchar](50) NOT NULL,
    [LastName] [nvarchar](50) NOT NULL,
    [EmailAddress] [nvarchar](256) NOT NULL,
    [PhoneNumber] [nvarchar](25) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[People_GetByLastName] @LastName nvarchar(50)
AS
BEGIN
    SET NOCOUNT ON
    SELECT * FROM [Sample].[dbo].[People] WHERE LastName = @LastName
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[People_Insert] @FirstName nvarchar(50), @LastName nvarchar(50), @EmailAddress nvarchar(256), @PhoneNumber nvarchar(25)
AS 
INSERT INTO dbo.People (FirstName, LastName, EmailAddress, PhoneNumber) VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber)
GO