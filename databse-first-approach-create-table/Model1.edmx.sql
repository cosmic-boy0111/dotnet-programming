
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/24/2023 15:57:33
-- Generated from EDMX file: C:\Users\Admin\source\repos\dotnet-programming\databse-first-approach-create-table\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PratitiDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Entity1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entity1];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PratitiTasks'
CREATE TABLE [dbo].[PratitiTasks] (
    [PratitiTaskId] int IDENTITY(1,1) NOT NULL,
    [PratitiTaskHeading] nvarchar(max)  NOT NULL,
    [PratitiTaskDescription] nvarchar(max)  NOT NULL,
    [PratitiTaskAssignedBy] nvarchar(max)  NOT NULL,
    [PratitiTaskAssignedTo] nvarchar(max)  NOT NULL,
    [PratitiTaskAssignedDate] datetime  NOT NULL,
    [PratitiTaskDays] int  NOT NULL,
    [PratitiTaskDeadLineDate] datetime  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Account_Number] bigint  NOT NULL,
    [User_Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PratitiTaskId] in table 'PratitiTasks'
ALTER TABLE [dbo].[PratitiTasks]
ADD CONSTRAINT [PK_PratitiTasks]
    PRIMARY KEY CLUSTERED ([PratitiTaskId] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------