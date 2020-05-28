﻿using System;
namespace ddd.Application
{
    public class CircleJoinCommand
    {
        public CircleJoinCommand(string userId, string circleId)
        {
            UserId = userId;
            CircleId = circleId;
        }

        public string UserId { get; }
        public string CircleId { get; }
    }
}
