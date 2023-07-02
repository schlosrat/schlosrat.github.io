// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVPartInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.DeltaV
{
  [Serializable]
  public class DeltaVPartInfo
  {
    public VesselDeltaVComponent VesselDV;
    public IDeltaVPart PartRef;
    public int DecoupleStage;
    public bool DecoupleBeforeBurn;
    public int ActivationStage;
    public bool IsDecoupler;
    public bool IsStageSeparator;
    public bool IsFairing;
    public bool IsLaunchClamp;
    public bool IsDockingPort;
    public bool IsEngine;
    public bool IsJettison;
    public bool IsIntake;
    public bool IsSolarPanel;
    public bool IsGenerator;
    public Data_ResourceIntake ModuleResourceIntake;
    public Data_SolarPanel ModuleDeployableSolarPanel;
    public Data_ModuleGenerator ModuleGenerator;
    public Data_DockingNode ModuleDockingNode;
    public Data_Decouple ModuleDecoupler;
    public Data_Engine ModuleEngine;
    public double DryMass;
    public double JettisonMass;
    public DictionaryValueList<int, DeltaVPartInfo.PartStageFuelMass> StageFuelMass;
    public IDeltaVPart JettisonPart;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVPartInfo(IDeltaVPart part, VesselDeltaVComponent vesselDv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CheckDecoupler(int chkStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetSeparationStage(int chkStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void StageStartFuelMass(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void StageEndFuelMass(int stage, double endMass = -1.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal float GetCurrentFuelMass(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResetStageFuelMass(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool GetStageFuelMassItem(
      int stage,
      out DeltaVPartInfo.PartStageFuelMass partStageFuelMass)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateMassValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateStagingValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int FindParentStageRecursive(IDeltaVPart PartRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool FindDecouplerParent(IDeltaVPart inPart, out IDeltaVPart decouplerParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool JettisonInStage(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStageStartMass(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStageEndMass(int stage) => throw null;

    public class PartStageFuelMass
    {
      private IDeltaVPart _part;
      public double StartMass;
      public double EndMass;
      public DeltaVPartInfo.PartStageFuelMass.PartResources Resources;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartStageFuelMass(IDeltaVPart part) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetCurrentFuelMass() => throw null;

      public class PartResources
      {
        public ResourceContainerGroup ResourceContainerGroup;
        public List<ResourceUnitMass> UnitsConsumed;
        public double UnitMass;
        private List<ResourceUnitMass> _cachedUnitsConsumed;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public PartResources(ResourceContainerGroup containerGroup) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void AddConsumedUnits(ResourceDefinitionID resourceID, double units) => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public double GetConsumedUnits(ResourceDefinitionID resourceID) => throw null;
      }
    }
  }
}
