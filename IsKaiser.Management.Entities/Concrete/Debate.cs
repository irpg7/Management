﻿using IsKaiser.Management.Core.Entities;
using System;
using System.Linq;

namespace IsKaiser.Management.Entities.Concrete
{
    public class Debate:IEntity
    {
        public int DebateId { get; set; }
        public int CustomerId { get; set; }
        public int EnvoyId { get; set; }
        public int TeamId { get; set; }
        public DateTime DebateDate { get; set; }
        public string DebateDetail { get; set; }
        public string DebateRequiredEquipment { get; set; }
        public string DebateSecurityDetail { get; set; }
        public string DebateRequested { get; set; }
    }
}
