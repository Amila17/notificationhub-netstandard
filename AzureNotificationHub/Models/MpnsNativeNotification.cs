﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AzureNotificationHub.Models
{
    public class MpnsNativeNotification : Notification
    {
        public string PayLoad { get; set; }

        public MpnsNativeNotification()
        {

        }

        public MpnsNativeNotification(string payLoad)
        {
            PayLoad = payLoad;
        }

        public MpnsNativeNotification(XmlDocument payLoad)
        {
            PayLoad = payLoad.OuterXml;
        }
    }
}
