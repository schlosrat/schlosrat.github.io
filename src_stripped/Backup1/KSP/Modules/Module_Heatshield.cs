// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Heatshield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_Heatshield : PartBehaviourModule
  {
    [SerializeField]
    private Data_Heatshield _dataHeatshield;
    private Data_Deployable _dataDeployable;
    private float _currentCharIntensity;
    private Material _charMaterial;
    private KSPPartAudioManager _kspPartAudioManager;
    private const string _moduleDisplayName = "PartModules/HeatShield/Name";
    private bool _previousAblationState;

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
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeployChanged(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Heatshield() => throw null;
  }
}
