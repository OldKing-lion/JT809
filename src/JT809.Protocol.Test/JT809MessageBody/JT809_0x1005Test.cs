﻿using JT809.Protocol.JT809Enums;
using JT809.Protocol.JT809Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JT809.Protocol.Test.JT809MessageBody
{
    public class JT809_0x1005Test
    {
        [Fact]
        public void Test1()
        {
            JT809Package heartbeatPackage = JT809BusinessType.主链路连接保持请求消息.Create();
            byte[] sendHeartbeatData = JT809Serializer.Serialize(heartbeatPackage, 100);
        }
    }
}
