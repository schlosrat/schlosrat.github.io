// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_LitPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_LitPart : PartBehaviourModule
  {
    [SerializeField]
    private Data_LitPart _dataLitPart;
    private const string _moduleDisplayName = "PartModules/LitPart/Name";
    private List<Light> _lights;
    private List<Material> _materials;
    [SerializeField]
    private Gradient _gradient;

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
    private void InitializeGradient() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MaterialsUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwitchLightOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwitchLightOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwitchLight(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLightToggleValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_LitPart() => throw null;
  }
}
