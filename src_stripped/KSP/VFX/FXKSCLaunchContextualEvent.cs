// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXKSCLaunchContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
