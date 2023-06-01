// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.AtmosphericFxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.VFX;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  [Serializable]
  public class AtmosphericFxSystem
  {
    private VesselBehavior _vessel;
    [SerializeField]
    private VesselVaporVFXManager _vaporFXManager;
    [SerializeField]
    private VesselReentryVFXManager _reentryFXManager;
    [SerializeField]
    private VesseVaporConeVFXManager _vaporConeFXManager;
    [SerializeField]
    private VesselSurfaceInteractionVFXManager _surfaceInteractionVFXManager;
    private FXContextData data;

    public VesselVaporVFXManager VaporFXManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselReentryVFXManager ReentryFXManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesseVaporConeVFXManager VaporConeFXManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselSurfaceInteractionVFXManager SurfaceInteractionVFXManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphericFxSystem(VesselBehavior vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Tick(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;
  }
}
