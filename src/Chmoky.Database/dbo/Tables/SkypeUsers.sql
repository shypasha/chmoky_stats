﻿CREATE TABLE [dbo].[SkypeUsers] (
    [author]           NVARCHAR (128) NOT NULL,
    [FirstName]        NVARCHAR (100) NULL,
    [LastName]         NVARCHAR (100) NULL,
    [Account]          NVARCHAR (255) NULL,
    [EmailDisplayName] NVARCHAR (255) NULL,
    CONSTRAINT [PK_SkypeUsers] PRIMARY KEY CLUSTERED ([author] ASC)
);












GO
CREATE NONCLUSTERED INDEX [IX_SkypeUsers_LastName]
    ON [dbo].[SkypeUsers]([LastName] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SkypeUsers_FirstName]
    ON [dbo].[SkypeUsers]([FirstName] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SkypeUsers_Account]
    ON [dbo].[SkypeUsers]([Account] ASC);

