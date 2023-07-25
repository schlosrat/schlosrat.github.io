// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.KerbalComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class KerbalComponent : ObjectComponent
  {
    [HideInInspector]
    public IGGuid CurrentLadderPartId;
    [HideInInspector]
    public VesselComponent GroundPresentCollisionVesselComponent;
    [HideInInspector]
    public float LadderUpPosOffsetSigned;
    [HideInInspector]
    public bool IsCharacterAtLadderUpperLimit;
    [HideInInspector]
    public bool IsCarryingFlag;
    private UniverseModel _universeModel;
    private Data_Kerbal _kerbalData;

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

    [TypeConverterIgnore]
    public override System.Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselComponent Vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerComponent PartOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RigidbodyComponent Rigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartComponent MainPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Data_Kerbal KerbalData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEVA
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid EVAStartLocationId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool WasCreatedFromEVAAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KerbalInfo KerbalInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalComponent(AssemblyDefinition kerbalDefinition, UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap modelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetDefinition(object definitionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignKerbalInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAboveHighAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckClimbingLadderSituation(
      ref VesselSituations situation,
      ref bool landed,
      ref bool splashed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckNotInOrbitGroundContactSituation(
      ref VesselSituations situation,
      ref bool landed,
      ref bool splashed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckSituation(ref VesselSituations situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AssignKerbalData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SimulationObject_onStarted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetObservationFrameDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCurrentLadderPartId(IGGuid ladderPartId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLadderUpPosOffsetSigned(float ladderUpPosOffsetSigned) => throw null;
  }
}
