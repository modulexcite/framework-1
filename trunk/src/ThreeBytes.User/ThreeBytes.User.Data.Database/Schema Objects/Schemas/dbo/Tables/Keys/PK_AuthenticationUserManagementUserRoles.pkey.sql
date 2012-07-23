﻿ALTER TABLE [dbo].[AuthenticationUserManagementUserRoles]
    ADD CONSTRAINT [PK_AuthenticationUserManagementUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
