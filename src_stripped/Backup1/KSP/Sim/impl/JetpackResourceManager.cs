// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.JetpackResourceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using KSP.Sim.ResourceSystem;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class JetpackResourceManager
  {
    private const string FORCE_PROPELLANT_STATE_ID = "JetpackForcePropellantState";
    private const string TORQUE_PROPELLANT_STATE_ID = "JetpackTorquePropellantState";
    public bool IsThrusting;
    public bool IsResourceDeprived;
    private KerbalBehavior _kerbalBehavior;
    private Module_Kerbal _kerbalModule;
    private Data_Kerbal _kerbalData;
    private CharacterForce _resultantJetpackForce;
    private CharacterTorque _resultantJetpackTorque;
    private ResourceFlowRequestBroker _resourceFlowRequestBroker;
    private ResourceDefinitionDatabase _resourceDefinitionDatabase;
    private ResourceDefinitionData _resourceDefinitionData;
    private double _maxFuelFlowMove;
    private double _maxFuelFlowRotate;
    private double _exhaustVel;
    private bool _wasResourceDeprived;
    private bool _wasThrusting;

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deinitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeJetpackPartActionManagerProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStopCharacterState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterResultantJetpackForce(CharacterForce resultantJetpackForce) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterResultantJetpackForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterResultantJetpackTorque(CharacterTorque resultantJetpackTorque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterResultantJetpackTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessPreJetpackForcesAndTorques() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateThrustForceMagnitude(double forceMagnitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateThrustTorqueMagnitude(double torqueMagnitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeRequestInactive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitPropellantState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ForceRemovePropellantStateRequest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetISP(float realISP) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetInfinitePropellant() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateThrust(
      double magnitude,
      double maxResourceFuelFlow,
      PropellantState propellantState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RequestPropellant(double massFlow, PropellantState propellantState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetJetpackPartActionManagerProperties(float realISP) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MakeRequestInactive(
      ResourceFlowRequestBroker resourceFlowRequestBroker,
      ResourceFlowRequestHandle requestHandle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ForceRemovePropellantStateRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker,
      ref ResourceFlowRequestHandle requestHandle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JetpackResourceManager() => throw null;
  }
}
