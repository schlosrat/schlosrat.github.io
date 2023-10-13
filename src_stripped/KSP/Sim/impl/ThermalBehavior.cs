// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ThermalBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ThermalBehavior : 
    ViewObjectComponent<ThermalComponent>,
    IUpdate,
    IFixedUpdate,
    ILateUpdate
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
    void ILateUpdate.OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalBehavior() => throw null;
  }
}
