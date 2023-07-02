// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ThermalBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    public ThermalBehavior() => throw null;
  }
}
