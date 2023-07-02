// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXFuelTankDecompressionIceContextualEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
