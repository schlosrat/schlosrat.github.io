// Decompiled with JetBrains decompiler
// Type: KSP.VFX.RCSVFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public class RCSVFXManager : KerbalMonoBehaviour
  {
    [FormerlySerializedAs("debugMode")]
    public bool DebugMode;
    private IFloatingOrigin _floatingOrigin;
    protected AtmosphereTransitionVFXHandling _atmoTransVFXHandler;
    protected PartBehavior _thisPart;
    protected VesselComponent _vessel;
    protected Module_RCS _rcsModule;
    protected List<IEngineFXData[]> _VFXDataToControl;
    protected Animator _animator;
    protected bool _TVMInitialized;
    private Vector3d _accelVesselSurfaceSmoothed;
    private List<int> _activeGroupIndices;
    private List<int> _pendingDisableGroupIndices;
    private List<Coroutine> _pendingDisableGroupCoroutines;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(IFloatingOrigin floatingOrigin, PartBehavior part, Module_RCS module_RCS) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindThrusterVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitAnimator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartDisableVFXAtIndex(int index, bool checkIfActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineDisableVFXAtIndexWithDelay(int index, float delaySeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleVFX(bool turnOn, int nozzleIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RCSVFXManager() => throw null;
  }
}
