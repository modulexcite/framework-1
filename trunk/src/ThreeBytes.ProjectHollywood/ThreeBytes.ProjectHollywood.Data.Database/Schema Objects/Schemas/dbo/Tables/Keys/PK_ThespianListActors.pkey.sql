﻿ALTER TABLE [dbo].[ThespianListThespians]
    ADD CONSTRAINT [PK_ThespianListThespians] PRIMARY KEY CLUSTERED ([ThespianId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
