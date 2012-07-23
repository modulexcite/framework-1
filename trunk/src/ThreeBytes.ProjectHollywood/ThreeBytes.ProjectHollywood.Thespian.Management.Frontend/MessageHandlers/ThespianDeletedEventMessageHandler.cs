﻿using System;
using NServiceBus;
using SignalR;
using ThreeBytes.ProjectHollywood.Thespian.Management.Frontend.Hubs;
using ThreeBytes.ProjectHollywood.Thespian.Messages.InternalEvents;

namespace ThreeBytes.ProjectHollywood.Thespian.Management.Frontend.MessageHandlers
{
    public class ThespianDeletedEventMessageHandler : IHandleMessages<IDeletedThespianInternalEventMessage>
    {
        public IConnectionManager ConnectionManager;

        public ThespianDeletedEventMessageHandler(IConnectionManager connectionManager)
        {
            if (connectionManager == null)
                throw new ArgumentNullException("connectionManager");

            ConnectionManager = connectionManager;
        }

        public void Handle(IDeletedThespianInternalEventMessage message)
        {
            ConnectionManager.GetClients<ThespianManagementHub>().handleDeletedThespianEventMessage(message.Id);
        }
    }
}