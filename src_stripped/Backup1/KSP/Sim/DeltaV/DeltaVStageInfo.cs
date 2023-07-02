// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVStageInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using KSP.OAB;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.DeltaV
{
  [Serializable]
  public class DeltaVStageInfo
  {
    public int Stage;
    public int SeparationIndex;
    [NonSerialized]
    public VesselDeltaVComponent VesselDV;
    public bool PayloadStage;
    public List<DeltaVPartInfo> Parts;
    public List<Data_ResourceIntake> AirIntakeParts;
    public List<DeltaVEngineInfo> EnginesActiveInStage;
    public List<DeltaVEngineInfo> EnginesInStage;
    public double StageMass;
    public double DryMass;
    public double FuelMass;
    public double StartMass;
    public double EndMass;
    public double DecoupledMass;
    public double IspVac;
    public double IspASL;
    public double IspActual;
    public float TWRVac;
    public float TWRASL;
    public float TWRActual;
    public float ThrustVac;
    public float ThrustASL;
    public float ThrustActual;
    public float VectoredThrustVac;
    public float VectoredThrustASL;
    public float VectoredThrustActual;
    public double DeltaVinVac;
    public double DeltaVatASL;
    public double DeltaVActual;
    public double StageBurnTime;
    public List<DeltaVCalc> DeltaVCalcs;
    public float TotalExhaustVelocityVAC;
    public float TotalExhaustVelocityASL;
    public float TotalExhaustVelocityActual;
    public Vector3 VectoredExhaustVelocityVAC;
    public Vector3 VectoredExhaustVelocityASL;
    public Vector3 VectoredExhaustVelocityActual;
    private Vector3 _enginesThrustVac;
    private Vector3 _enginesThrustASL;
    private Vector3 _enginesThrustActual;
    private List<DeltaVPartInfo> _cachedActivatedParts;
    private Dictionary<IGGuid, DeltaVPartInfo> _partInfoDictionary;
    private bool _stageContainsOnlyLaunchClamps;
    private List<DeltaVCalc> _subStages;
    private Dictionary<ResourceDefinitionID, List<DeltaVEngineInfo>> _enginesByResource;
    private List<ResourceUnitsPair> _resourceIds;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSituationISP(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSituationTWR(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSituationThrust(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSituationVectoredThrust(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSituationDeltaV(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSituationTotalExhaustVelocity(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetSituationVectoredExhaustVelocity(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVStageInfo(ObjectAssembly ship, int inStage, VesselDeltaVComponent vesselDv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVStageInfo(PartOwnerComponent vessel, int inStage, VesselDeltaVComponent vesselDv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset(int inStage, VesselDeltaVComponent vesselDeltaVComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessParts(int inStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateStartMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetHighestSeparationIndex(List<DeltaVEngineInfo> engines) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<DeltaVEngineInfo> MatchingSeparationIndex(
      List<DeltaVEngineInfo> engines,
      int index)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StoreStartFuelMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StoreEndFuelMass(double endMass = -1.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SimulateDeltaV(bool runningActive, bool thisStageActive = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcSubStageStartEndMasses(ref List<DeltaVCalc> subStages) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortEnginesByResource(
      List<DeltaVEngineInfo> engines,
      ref Dictionary<ResourceDefinitionID, List<DeltaVEngineInfo>> enginesByResource)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcEngineStats(ref List<DeltaVEngineInfo> engines) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessEngineSharedResources(
      ref Dictionary<ResourceDefinitionID, List<DeltaVEngineInfo>> enginesByResource)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessEnginesToSubStages(
      List<DeltaVEngineInfo> enginesActiveInStage,
      ref List<DeltaVCalc> subStages)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcEngineBurnTimes(ref List<DeltaVEngineInfo> engines) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcSubStageTotals(ref List<DeltaVCalc> subStages) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcStageDeltaVTotal(ref List<DeltaVCalc> subStages) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcStageVelocityandThrust(List<DeltaVCalc> _subStages) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal double CalculateTimeRequiredDV(bool runningActive, float deltaVRequested) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void CalcLerpDeltaV() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ProcessActiveEngines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CarryOverConsumedFuelMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetStageMass(
      out double dryMass,
      out double fuelMass,
      out double decoupledDryMass,
      out double decoupledFuelMass,
      out double jettisonedDryMass)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateISP(List<DeltaVEngineInfo> engines = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateTWR(double mass = -1.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int PartsActiveInStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int PartsActivateInStage(ref List<DeltaVPartInfo> activeParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int PartsDecoupledInStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemovePart(IGGuid partId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<OdeSolverStageComponent> GetOdeSolverStageComponents() => throw null;
  }
}
