﻿using FusionDemo.HealthCentral.Domain;
using Stl.Fusion;
using Stl.Fusion.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FusionDemo.HealthCentral.Abstractions
{
    public class PainelComposedValue
    {
        public DateTime ServerTime { get; set; }
        public IEnumerable<CareUnit> AvailableUnits { get; set; } = new List<CareUnit>();
        public IEnumerable<Patient> PatientsWaitingList { get; set; } = new List<Patient>();
    }
    public interface IPainelComposerService
    {
        [ComputeMethod(KeepAliveTime = 1)]
        Task<PainelComposedValue> GetComposedValueAsync(string parameter,
       Session session, CancellationToken cancellationToken = default);
    }

}