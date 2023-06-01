// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVPropellantInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.DeltaV
{
  [Serializable]
  public class DeltaVPropellantInfo
  {
    private const double _AmtEpsilon = 0.001;
    public PropellantState Propellant;
    private List<DeltaVPropellantInfo.ResourceIdAmounts> _resourceIdAmounts;
    private List<KeyValuePair<DeltaVPartInfo, DeltaVPartInfo.PartStageFuelMass>> _resourcePartsToStage;
    public double MaxBurnTime;
    public double MaxBurnTimeASL;
    public double MaxBurnTimeVac;
    public double MassPerUnit;
    public DictionaryValueList<DeltaVPartInfo, DeltaVPartInfo.PartStageFuelMass> Containers;
    private VesselDeltaVComponent _vesselDVComponent;
    private ResourceDefinitionID _intakeAirResourceID;
    private int _partCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double AmountAvailable(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVPropellantInfo(PropellantState propellant, VesselDeltaVComponent vesselDVComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupPropellantInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetMaxBurnTimes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResetPropellantPartCountCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdatePropellantInfo(int stage, int partCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ConsumeUnits(double units) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConsumeSharedUnits(ResourceDefinitionID resourceID, double units) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResourcePartsToStage(
      int stage,
      ref List<KeyValuePair<DeltaVPartInfo, DeltaVPartInfo.PartStageFuelMass>> partsToStage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetHighestResourceSeparationIndex(int stage) => throw null;

    private class ResourceIdAmounts
    {
      public ResourceUnitMass ResourceUnitMass;
      public double AmountAvailable;
      public double SharedAmount;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResourceIdAmounts(ResourceDefinitionID resourceId, double units, double unitMass) => throw null;
    }
  }
}
