// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ThermalBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ThermalBehavior : ViewObjectComponent<ThermalComponent>, IUpdate, IFixedUpdate
  {
    private PartOwnerBehavior _partOwner;
    private const double AcceptableAreaThreshold = 0.999;
    private CelestialBodyData _currentCBData;
    private ThermalOcclusionGraph _thermalOcclusionGraph;
    private VesselBehavior _vesselBehaviour;
    private Vector3d _vesselVelocity;
    private bool _vesselChanged;

    public ThermalComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(ThermalComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateReentryFlux(PartBehavior part, Vector3d partVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d CalculateReentryFlux(
      double dragCoefficient,
      double areaExposedProportion,
      double totalArea,
      Vector3d partVelocity,
      double DragForceMagnitude)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateOcclusionConvection(Vector3d velocityVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalBehavior() => throw null;
  }
}
