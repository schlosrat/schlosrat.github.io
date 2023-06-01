// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.VesselDeltaVComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.OAB;
using KSP.Sim.Converters;
using KSP.Sim.impl;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.DeltaV
{
  public class VesselDeltaVComponent : ObjectComponent
  {
    public const float DELTAV_VESSEL_EVENT_DELAY_SECS = 1f;
    public const float DELTAV_ACTIVE_STAGE_UPDATE_SECS = 0.2f;
    public const float DELTAV_ALL_STAGES_UPDATE_SECS = 10f;
    public static bool DebugPrintEnabled;
    public DeltaVEngineStageSet EngineStageSet;
    [SerializeField]
    private PartOwnerComponent _vessel;
    [SerializeField]
    private ObjectAssembly _ship;
    [SerializeField]
    private List<int> _separationStageIndexes;
    private DictionaryValueList<IGGuid, DeltaVPartInfo> _partInfo;
    private int _partsCount;
    [SerializeField]
    private double _totalDeltaVVac;
    [SerializeField]
    private double _totalDeltaVASL;
    [SerializeField]
    private double _totalDeltaVActual;
    [SerializeField]
    private double _totalBurnTime;
    [SerializeField]
    private VesselDeltaVComponent.Mode _activeMode;
    public int LowestStageWithDeltaV;
    private bool _isCalculationRunning;
    private bool _isReady;
    [SerializeField]
    private bool _calcsDirty;
    private double _vesselEventDelayTime;
    private double _flightLastStageUpdateTime;
    private double _flightLastFullUpdateTime;

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object state, ISimulationModelMap simulationModelMap) => throw null;

    public List<DeltaVEngineInfo> EngineInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerComponent Vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectAssembly Ship
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [SerializeField]
    public List<DeltaVStageInfo> StageInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<int> SeparationStageIndexes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DictionaryValueList<IGGuid, DeltaVPartInfo> PartInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TotalDeltaVVac
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TotalDeltaVASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TotalDeltaVActual
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double TotalBurnTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselDeltaVComponent.Mode ActiveMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsCalculationRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSituationTotalDeltaV(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDeltaVComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDeltaVComponent(SimulationObjectModel simObject, PartOwnerComponent vesselRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDeltaVComponent(ObjectAssembly shipRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCalcsDirty(bool syncListInstances = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVStageInfo GetStage(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<OdeSolverStageComponent> TryGetOdeSolverStageComponents(int inStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetActivatedEngines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetHighestSeparationStage(int inStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResourceFlowGraphRebuilt(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineChangedMode(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitAndChangeEngineMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageRemoved(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageAdded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartStageChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageActivated(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartExploded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABMainAssemblyChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABVesselFuelChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABThrustPercentageChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselUndocking(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDockingComplete(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SOIChange(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRevertToLaunchEventMessage(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineShutdownMessage(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineFlameoutChangedMessage(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnProceduralWingChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPlacedOnMainAssembly(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostLoadAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartDeleted(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostOnPartPlacedConnected(IObjectAssemblyPart oabPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckDirtyAndRunCalcs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DeltaVStageInfo GetWorkingStage(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ProcessActiveUpdateEngines(DeltaVStageInfo currentDeltaVStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateSeparationStageIndexes(IDeltaVPart root, IEnumerable<IDeltaVPart> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSeparationIndices(IDeltaVPart root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSeparationIndices(IDeltaVPart part, int sepIndex, int carriedInverseStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPayloadStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetPartInfo(IEnumerable<IDeltaVPart> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessEnginePartInfoChildren(DeltaVPartInfo partInfoItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessDecouplePartInfoChildren(
      DeltaVPartInfo partInfoItem,
      VesselDeltaVComponent.PartStageComparisonOperator comparisonOp,
      int decoupleStage,
      int activationStage,
      bool bypassFairings,
      bool bypassJettison,
      bool setToParentDecoupleStage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangePartInfoDecoupleStage(
      DeltaVPartInfo partInfoItem,
      DeltaVPartInfo childPart,
      bool setToParentDecoupleStage = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RunCalculations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RunFlightSceneCalculations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SimulateLastStage(bool recalcVesselTotals = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReCalculateVesselTotals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double StageDVActual(DeltaVStageInfo stageInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateModuleEngines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResetSeparationIndexes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VesselDeltaVComponent() => throw null;

    private enum PartStageComparisonOperator
    {
      LessThan,
      NotEqual,
      Equal,
    }

    public enum Mode : byte
    {
      None,
      Ship,
      Vessel,
    }
  }
}
