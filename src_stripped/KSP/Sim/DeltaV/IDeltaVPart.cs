// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.IDeltaVPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;

namespace KSP.Sim.DeltaV
{
  public interface IDeltaVPart : IEquatable<IDeltaVPart>
  {
    string PartName { get; }

    IGGuid GlobalId { get; }

    int ActivationStage { get; set; }

    int DecoupleStage { get; set; }

    double DryMass { get; }

    double WetMass { get; }

    double GreenMass { get; }

    double TotalMass { get; }

    float StaticPressureAtm { get; }

    float StaticPressureAtmASL { get; }

    double AtmosphericTemperature { get; }

    double AtmDensity { get; }

    double AtmosphericTemperatureASL { get; }

    double AtmDensityASL { get; }

    IResourceContainer[] DeltaVContainers { get; }

    IDeltaVPart FindAttachNodeAttachedPart(string nodeName);

    new bool Equals(IDeltaVPart other);

    IEnumerable<IDeltaVPart> DeltaVChildren { get; }

    IDeltaVPart Parent { get; }

    bool TryGetModuleData<T, U>(out U moduleData)
      where T : PartComponentModule
      where U : ModuleData;

    bool IsActiveInStaging { get; }

    bool IsDestroyedOrBeingDestroyed { get; }
  }
}
