// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXVaporVorticesEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class FXVaporVorticesEvent : FXContextualEvent
  {
    public VesselBehavior Vessel;
    public Module_LiftingSurface LiftingSurface;
    private TrailRenderer _trailRenderer;

    public override VFXEventType EventType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXVaporVorticesEvent(
      ContextualFxSystem system,
      FXContextualEventParams eventParams,
      FXPartContextData partData,
      VesselBehavior vessel,
      Module_LiftingSurface liftingSurface)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string SelectPrefab(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Instantiate(GameObject prefab, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Tick(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void CleanUp() => throw null;
  }
}
