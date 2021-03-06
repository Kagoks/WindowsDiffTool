﻿using System.Collections.Generic;
using WindowsSystemDiffToolsCore;
using System.ServiceProcess;

namespace ServicesScanner
{

    public class Service : Component
    {
        public string DisplayName { get; set; }
        public string ServiceName { get; set; }
        public ServiceControllerStatus Status { get; set; }

        public Service() { }

        public Service(ServiceController service)
        {
            this.DisplayName = service.DisplayName;
            this.ServiceName = service.ServiceName;
            this.Status = service.Status;
        }



        private string getStatusString()
        {
            switch (this.Status)
            {
                case ServiceControllerStatus.ContinuePending:
                    return "ContinuePending";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.PausePending:
                    return "PausePending";
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.StartPending:
                    return "StartPending";
                case ServiceControllerStatus.Stopped:
                    return "Stopped";
                case ServiceControllerStatus.StopPending:
                    return "StopPending";
                default:
                    return "Unknown??";
            }
        }


        public override string getDisplayName()
        {
            return this.DisplayName;
        }

        public override Dictionary<string, string> getItems()
        {
            return new Dictionary<string, string>()
            {
                { "ServiceName", ServiceName },
                { "Status", getStatusString() }
            };
        }

    }
}
