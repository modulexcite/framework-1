﻿ALTER TABLE [dbo].[AuthenticationUserManagementRoles]
    ADD CONSTRAINT [PK_AuthenticationUserManagementRoles] PRIMARY KEY CLUSTERED ([RoleId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

