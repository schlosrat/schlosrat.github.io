// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXFuelTankDecompressionIceContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class FXFuelTankDecompressionIceContextualEvent : FXContextualEvent
  {
    private VesselBehavior _vessel;
    private PartBehavior _part;
    private string _prefabName;

    public override string DefaultVFXAssetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override VFXEventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXFuelTankDecompressionIceContextualEvent(
      ContextualFxSystem system,
      FXContextualEventParams eventParams,
      FXPartContextData partData,
      VesselBehavior vessel,
      PartBehavior part)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Instantiate(GameObject prefab, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateParameterData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidConditions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Tick(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void CleanUp() => throw null;
  }
}
