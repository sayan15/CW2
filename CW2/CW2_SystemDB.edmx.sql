
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/06/2021 20:51:04
-- Generated from EDMX file: D:\Masters_IIT_Modules\EnterprsieSytemDesign\CW2\CW2\CW2_SystemDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CW2_SystemDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserDetailsPayerOrPayee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayerOrPayees] DROP CONSTRAINT [FK_UserDetailsPayerOrPayee];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDetailsEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_UserDetailsEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDetailsTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_UserDetailsTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionPayerOrPayee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_TransactionPayerOrPayee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PayerOrPayees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayerOrPayees];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[UserDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserDetails];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PayerOrPayees'
CREATE TABLE [dbo].[PayerOrPayees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [PhoneNumber] int  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TransactionType] nvarchar(max)  NOT NULL,
    [OccurenceType] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Amount] float  NOT NULL,
    [UserId] int  NOT NULL,
    [PayerOrPayee_Id] int  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EventType] nvarchar(max)  NOT NULL,
    [OccurenceType] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PayerOrPayees'
ALTER TABLE [dbo].[PayerOrPayees]
ADD CONSTRAINT [PK_PayerOrPayees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'PayerOrPayees'
ALTER TABLE [dbo].[PayerOrPayees]
ADD CONSTRAINT [FK_UserPayerOrPayee]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPayerOrPayee'
CREATE INDEX [IX_FK_UserPayerOrPayee]
ON [dbo].[PayerOrPayees]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_UserEvent]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserEvent'
CREATE INDEX [IX_FK_UserEvent]
ON [dbo].[Events]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_UserTransaction]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTransaction'
CREATE INDEX [IX_FK_UserTransaction]
ON [dbo].[Transactions]
    ([UserId]);
GO

-- Creating foreign key on [PayerOrPayee_Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionPayerOrPayee]
    FOREIGN KEY ([PayerOrPayee_Id])
    REFERENCES [dbo].[PayerOrPayees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionPayerOrPayee'
CREATE INDEX [IX_FK_TransactionPayerOrPayee]
ON [dbo].[Transactions]
    ([PayerOrPayee_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------