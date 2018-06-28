
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/08/2017 10:40:34
-- Generated from EDMX file: E:\VS_projeckt\ADBN\ADBN\Entity\ShopDBEntety.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_NoteBook_ToDiscs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteBook] DROP CONSTRAINT [FK_NoteBook_ToDiscs];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteBook_ToDiscs2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteBook] DROP CONSTRAINT [FK_NoteBook_ToDiscs2];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteBook_ToMotherBord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteBook] DROP CONSTRAINT [FK_NoteBook_ToMotherBord];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteBook_ToProcessor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteBook] DROP CONSTRAINT [FK_NoteBook_ToProcessor];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteBook_ToRAM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteBook] DROP CONSTRAINT [FK_NoteBook_ToRAM];
GO
IF OBJECT_ID(N'[dbo].[FK_NoteBook_ToVideoBords]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoteBook] DROP CONSTRAINT [FK_NoteBook_ToVideoBords];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_PowerSourse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_PowerSourse];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToDiscs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToDiscs];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToDiscs2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToDiscs2];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToDiscs3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToDiscs3];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToDiscs4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToDiscs4];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToMotherBord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToMotherBord];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToProcessor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToProcessor];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToRAMs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToRAMs];
GO
IF OBJECT_ID(N'[dbo].[FK_PC_ToVideoBords]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PC] DROP CONSTRAINT [FK_PC_ToVideoBords];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Disc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Disc];
GO
IF OBJECT_ID(N'[dbo].[Hulls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hulls];
GO
IF OBJECT_ID(N'[dbo].[MotherBord]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MotherBord];
GO
IF OBJECT_ID(N'[dbo].[NoteBook]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoteBook];
GO
IF OBJECT_ID(N'[dbo].[PC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PC];
GO
IF OBJECT_ID(N'[dbo].[PowerSourse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PowerSourse];
GO
IF OBJECT_ID(N'[dbo].[Processor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Processor];
GO
IF OBJECT_ID(N'[dbo].[RAM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RAM];
GO
IF OBJECT_ID(N'[dbo].[VideoBord]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VideoBord];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Disc'
CREATE TABLE [dbo].[Disc] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [value] int  NULL,
    [manufacturer] varchar(max)  NULL,
    [SSD] varchar(max)  NULL,
    [cost] int  NULL
);
GO

-- Creating table 'Hulls'
CREATE TABLE [dbo].[Hulls] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Manafacture] nchar(10)  NULL,
    [hullType] nchar(10)  NULL,
    [hullModel] nchar(10)  NULL,
    [cost] nchar(10)  NULL
);
GO

-- Creating table 'MotherBord'
CREATE TABLE [dbo].[MotherBord] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NULL,
    [northBridge] nvarchar(max)  NULL,
    [chipSet] nvarchar(max)  NULL,
    [SoketId] int  NOT NULL
);
GO

-- Creating table 'NoteBook'
CREATE TABLE [dbo].[NoteBook] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [processor_ID] int  NULL,
    [motherBord_ID] int  NULL,
    [RAM_ID] int  NULL,
    [videoCard_ID] int  NULL,
    [disc1_ID] int  NULL,
    [disc2_ID] int  NULL,
    [Batarray] int  NULL,
    [existence] int  NULL,
    [reservet] int  NULL,
    [Cost] int  NULL
);
GO

-- Creating table 'PC'
CREATE TABLE [dbo].[PC] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Marking] nvarchar(max)  NULL,
    [processor_ID] int  NULL,
    [motherBord_ID] int  NULL,
    [RAM_ID] int  NULL,
    [videoCard_ID] int  NULL,
    [disc1_ID] int  NULL,
    [disc2_ID] int  NULL,
    [disc3_ID] int  NULL,
    [disc4_ID] int  NULL,
    [hull_ID] int  NULL,
    [power_Supply_ID] int  NULL,
    [existence] int  NULL,
    [reservet] int  NULL,
    [cost] int  NULL,
    [Note] nvarchar(max)  NULL
);
GO

-- Creating table 'PowerSourse'
CREATE TABLE [dbo].[PowerSourse] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [voltage] int  NULL,
    [manifacture] nvarchar(max)  NULL
);
GO

-- Creating table 'Processor'
CREATE TABLE [dbo].[Processor] (
    [Id] int  NOT NULL,
    [manufacturer] nvarchar(max)  NULL,
    [model] nvarchar(max)  NULL,
    [frequency] int  NULL,
    [cache] int  NULL,
    [number_of_Cores] int  NULL,
    [number_of_threads] int  NULL,
    [cost] int  NULL,
    [SoketId] int  NOT NULL
);
GO

-- Creating table 'RAM'
CREATE TABLE [dbo].[RAM] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [manufacture] nvarchar(max)  NULL,
    [value] int  NULL,
    [frequency] int  NULL,
    [DDR] int  NULL,
    [cost] int  NULL
);
GO

-- Creating table 'VideoBord'
CREATE TABLE [dbo].[VideoBord] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [model] nvarchar(max)  NULL,
    [memory_generation] nvarchar(max)  NULL,
    [bits] int  NULL,
    [memory_] int  NULL,
    [C3D_API] nvarchar(max)  NULL,
    [cost] int  NULL
);
GO

-- Creating table 'SoketSet'
CREATE TABLE [dbo].[SoketSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Disc'
ALTER TABLE [dbo].[Disc]
ADD CONSTRAINT [PK_Disc]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hulls'
ALTER TABLE [dbo].[Hulls]
ADD CONSTRAINT [PK_Hulls]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MotherBord'
ALTER TABLE [dbo].[MotherBord]
ADD CONSTRAINT [PK_MotherBord]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [PK_NoteBook]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [PK_PC]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PowerSourse'
ALTER TABLE [dbo].[PowerSourse]
ADD CONSTRAINT [PK_PowerSourse]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Processor'
ALTER TABLE [dbo].[Processor]
ADD CONSTRAINT [PK_Processor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RAM'
ALTER TABLE [dbo].[RAM]
ADD CONSTRAINT [PK_RAM]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'VideoBord'
ALTER TABLE [dbo].[VideoBord]
ADD CONSTRAINT [PK_VideoBord]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SoketSet'
ALTER TABLE [dbo].[SoketSet]
ADD CONSTRAINT [PK_SoketSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [disc1_ID] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [FK_NoteBook_ToDiscs]
    FOREIGN KEY ([disc1_ID])
    REFERENCES [dbo].[Disc]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteBook_ToDiscs'
CREATE INDEX [IX_FK_NoteBook_ToDiscs]
ON [dbo].[NoteBook]
    ([disc1_ID]);
GO

-- Creating foreign key on [disc2_ID] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [FK_NoteBook_ToDiscs2]
    FOREIGN KEY ([disc2_ID])
    REFERENCES [dbo].[Disc]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteBook_ToDiscs2'
CREATE INDEX [IX_FK_NoteBook_ToDiscs2]
ON [dbo].[NoteBook]
    ([disc2_ID]);
GO

-- Creating foreign key on [disc1_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToDiscs]
    FOREIGN KEY ([disc1_ID])
    REFERENCES [dbo].[Disc]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToDiscs'
CREATE INDEX [IX_FK_PC_ToDiscs]
ON [dbo].[PC]
    ([disc1_ID]);
GO

-- Creating foreign key on [disc2_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToDiscs2]
    FOREIGN KEY ([disc2_ID])
    REFERENCES [dbo].[Disc]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToDiscs2'
CREATE INDEX [IX_FK_PC_ToDiscs2]
ON [dbo].[PC]
    ([disc2_ID]);
GO

-- Creating foreign key on [disc3_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToDiscs3]
    FOREIGN KEY ([disc3_ID])
    REFERENCES [dbo].[Disc]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToDiscs3'
CREATE INDEX [IX_FK_PC_ToDiscs3]
ON [dbo].[PC]
    ([disc3_ID]);
GO

-- Creating foreign key on [disc4_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToDiscs4]
    FOREIGN KEY ([disc4_ID])
    REFERENCES [dbo].[Disc]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToDiscs4'
CREATE INDEX [IX_FK_PC_ToDiscs4]
ON [dbo].[PC]
    ([disc4_ID]);
GO

-- Creating foreign key on [motherBord_ID] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [FK_NoteBook_ToMotherBord]
    FOREIGN KEY ([motherBord_ID])
    REFERENCES [dbo].[MotherBord]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteBook_ToMotherBord'
CREATE INDEX [IX_FK_NoteBook_ToMotherBord]
ON [dbo].[NoteBook]
    ([motherBord_ID]);
GO

-- Creating foreign key on [motherBord_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToMotherBord]
    FOREIGN KEY ([motherBord_ID])
    REFERENCES [dbo].[MotherBord]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToMotherBord'
CREATE INDEX [IX_FK_PC_ToMotherBord]
ON [dbo].[PC]
    ([motherBord_ID]);
GO

-- Creating foreign key on [processor_ID] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [FK_NoteBook_ToProcessor]
    FOREIGN KEY ([processor_ID])
    REFERENCES [dbo].[Processor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteBook_ToProcessor'
CREATE INDEX [IX_FK_NoteBook_ToProcessor]
ON [dbo].[NoteBook]
    ([processor_ID]);
GO

-- Creating foreign key on [RAM_ID] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [FK_NoteBook_ToRAM]
    FOREIGN KEY ([RAM_ID])
    REFERENCES [dbo].[RAM]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteBook_ToRAM'
CREATE INDEX [IX_FK_NoteBook_ToRAM]
ON [dbo].[NoteBook]
    ([RAM_ID]);
GO

-- Creating foreign key on [videoCard_ID] in table 'NoteBook'
ALTER TABLE [dbo].[NoteBook]
ADD CONSTRAINT [FK_NoteBook_ToVideoBords]
    FOREIGN KEY ([videoCard_ID])
    REFERENCES [dbo].[VideoBord]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NoteBook_ToVideoBords'
CREATE INDEX [IX_FK_NoteBook_ToVideoBords]
ON [dbo].[NoteBook]
    ([videoCard_ID]);
GO

-- Creating foreign key on [power_Supply_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_PowerSourse]
    FOREIGN KEY ([power_Supply_ID])
    REFERENCES [dbo].[PowerSourse]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_PowerSourse'
CREATE INDEX [IX_FK_PC_PowerSourse]
ON [dbo].[PC]
    ([power_Supply_ID]);
GO

-- Creating foreign key on [processor_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToProcessor]
    FOREIGN KEY ([processor_ID])
    REFERENCES [dbo].[Processor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToProcessor'
CREATE INDEX [IX_FK_PC_ToProcessor]
ON [dbo].[PC]
    ([processor_ID]);
GO

-- Creating foreign key on [RAM_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToRAMs]
    FOREIGN KEY ([RAM_ID])
    REFERENCES [dbo].[RAM]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToRAMs'
CREATE INDEX [IX_FK_PC_ToRAMs]
ON [dbo].[PC]
    ([RAM_ID]);
GO

-- Creating foreign key on [videoCard_ID] in table 'PC'
ALTER TABLE [dbo].[PC]
ADD CONSTRAINT [FK_PC_ToVideoBords]
    FOREIGN KEY ([videoCard_ID])
    REFERENCES [dbo].[VideoBord]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PC_ToVideoBords'
CREATE INDEX [IX_FK_PC_ToVideoBords]
ON [dbo].[PC]
    ([videoCard_ID]);
GO

-- Creating foreign key on [SoketId] in table 'Processor'
ALTER TABLE [dbo].[Processor]
ADD CONSTRAINT [FK_SoketProcessor]
    FOREIGN KEY ([SoketId])
    REFERENCES [dbo].[SoketSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SoketProcessor'
CREATE INDEX [IX_FK_SoketProcessor]
ON [dbo].[Processor]
    ([SoketId]);
GO

-- Creating foreign key on [SoketId] in table 'MotherBord'
ALTER TABLE [dbo].[MotherBord]
ADD CONSTRAINT [FK_SoketMotherBord]
    FOREIGN KEY ([SoketId])
    REFERENCES [dbo].[SoketSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SoketMotherBord'
CREATE INDEX [IX_FK_SoketMotherBord]
ON [dbo].[MotherBord]
    ([SoketId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------