// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Cooler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.ViewActions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_Cooler : PartBehaviourModule
  {
    [SerializeField]
    protected Data_Cooler dataCooler;
    private KSPPartAudioManager _kspPartAudioManager;
    private List<Material> _emissiveMaterials;
    private bool _emissiveListPopulated;
    private float emissiveIntensity;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetStatusString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnBeforeSetStatusString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasEnoughResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCoolerEnabledChanged(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LaunchFX(IViewActionQueue actionQueue, bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Cooler() => throw null;
  }
}
