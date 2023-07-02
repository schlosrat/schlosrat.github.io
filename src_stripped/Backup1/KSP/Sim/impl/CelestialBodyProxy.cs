// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CelestialBodyProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  [DisallowMultipleComponent]
  public class CelestialBodyProxy : KerbalMonoBehaviour, IUpdate, IPriorityOverride
  {
    private List<LocalTransformCacher> _transformsToProxy;
    private Transform _currentProxyTarget;
    private ITransformFrame _currentProxyTargetFrame;
    private TransformModel _proxyReferenceModelTransform;
    private InertialFrame _physXReferenceFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ISimulationObjectView viewToProxy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SnapToPhysXOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddToProxy(LocalTransformCacher toAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterProxyTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void SnapProxyChild(LocalTransformCacher toSnap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateProxyViewPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInertialReferenceFrameSnap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyProxy() => throw null;
  }
}
