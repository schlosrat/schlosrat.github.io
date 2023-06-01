// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXKSCLaunchContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class FXKSCLaunchContextualEvent : FXContextualEvent
  {
    private VesselBehavior Vessel;
    private IGGuid vesselGUID;
    private SimulationObjectModel VesselModel;
    private string prefabName;
    private Vector3 UnitySpaceInitialPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXKSCLaunchContextualEvent(
      ContextualFxSystem system,
      FXContextualEventParams eventParams,
      FXPartContextData partData,
      VesselBehavior vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string SelectPrefab(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Instantiate(GameObject prefab, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateParameterData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Tick(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void CleanUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateTotalThrustForceMagnitudeKN() => throw null;
  }
}
