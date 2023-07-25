// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Gantry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Gantry : PartBehaviourModule
  {
    public const string VESSEL_EXIT_LOCATION = "VesselLaunchPoint";
    [SerializeField]
    protected Data_Gantry _moduleData;
    private ModuleAction _actionCreateVessel;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateModuleActionStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCreateVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Gantry() => throw null;
  }
}
