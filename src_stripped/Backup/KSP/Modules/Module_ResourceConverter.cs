// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ResourceConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ResourceConverter : PartBehaviourModule
  {
    [FormerlySerializedAs("DataResourceConverter")]
    [SerializeField]
    protected Data_ResourceConverter _dataResourceConverter;
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
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasEnoughResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ThermalUpdate(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMVisibility(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleChangedValue(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRecipeChanged(string activeRecipe) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartConverter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopConverter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleConverter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ResourceConverter() => throw null;
  }
}
