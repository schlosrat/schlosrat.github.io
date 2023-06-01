// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_SolarPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_SolarPanel : Module_Deployable
  {
    [SerializeField]
    protected Data_SolarPanel dataSolarPanel;
    private double _flowRate;
    private Transform _trackingDotTransform;
    private int _defaultLayerMask;
    private RaycastHit _raycastHit;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CalculateTrackingLOS(Vector3 trackingDirection, ref string blocker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PostCalculateTracking(bool trackingLOS, Vector3 trackingDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployableToggleExtendChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployableStateChanged(Data_Deployable.DeployState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_SolarPanel() => throw null;
  }
}
