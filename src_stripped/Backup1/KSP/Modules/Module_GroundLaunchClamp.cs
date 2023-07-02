// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_GroundLaunchClamp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_GroundLaunchClamp : PartBehaviourModule
  {
    [SerializeField]
    protected Data_GroundLaunchClamp dataGroundLaunchClamp;
    public Animator PartAnimator;
    public VariableHeightPartStacker VariableHeightPartStacker;
    private ConfigurableJoint _clampJoint;
    private Quaternion _towerRotation;
    private bool _extension_enabled;
    private Transform _anchor;
    private Transform _towerStretch;
    private Transform _towerPivot;
    private Material _towerMaterial;
    private ModuleAction _actionRelease;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableExtension() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformPartDecouple(PartComponent parentPartModel, AttachNodeData detachedNodeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPitchAngle(float newPitchAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FXBurst(
      PartBehavior part,
      AttachNodeData explosiveNode,
      ContextualFxSystem vfxSystem,
      KSPPartAudioManager audioManager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_GroundLaunchClamp() => throw null;
  }
}
