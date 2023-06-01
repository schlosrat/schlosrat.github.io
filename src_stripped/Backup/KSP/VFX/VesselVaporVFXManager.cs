// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VesselVaporVFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  [Serializable]
  public class VesselVaporVFXManager
  {
    private VesselBehavior _vessel;
    private GameInstance Game;
    private SubscriptionHandle _handlePartDestroyed;
    private SubscriptionHandle _handlePartDetached;
    private SubscriptionHandle _handleVesselCreated;
    private List<Module_Engine> contrailsVaporObjects;
    private List<Module_LiftingSurface> vorticesVaporObjects;
    private HashSet<Module_Engine> activeContrails;
    private HashSet<Module_LiftingSurface> activeVortices;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselVaporVFXManager(VesselBehavior vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyedOrDetached(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshVaporObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVaporEvents(FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckContrailsConditions(Module_Engine engine, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVaporContrails(VesselBehavior vessel, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateDewpointTemperature(float relativeHumidity, float temperature) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateVortexTemperature(
      float atmospherePressure,
      float vortexPressure,
      float atmosphereTemperature,
      float gamma)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckVorticesConditionsAndIntensity(
      Module_LiftingSurface liftingSurface,
      FXContextData contextData,
      out float intensity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVaporVortices(VesselBehavior vessel, FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnContrailsEventEnded(Module_Engine engine) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVorticesEventEnded(Module_LiftingSurface liftingSurface) => throw null;
  }
}
