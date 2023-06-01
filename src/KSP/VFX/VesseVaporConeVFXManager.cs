// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VesseVaporConeVFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  [Serializable]
  public class VesseVaporConeVFXManager : VesselVFXManagerBase
  {
    private PartBehavior _coneReferencePart;
    private SubscriptionHandle _handlePartDestroyed;
    private SubscriptionHandle _handlePartDetached;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesseVaporConeVFXManager(
      VesselVFXManagerBase.EffectQuality effectQuality,
      VesselBehavior vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override FXContextualEvent CreateEvent(
      FXContextualEventParams fxContextualEventParams,
      FXPartContextData fxPartContextData,
      VesselBehavior vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDetached(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVaporConeReferencePart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckCondition(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PositionCameraAndMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSetIntensity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetParameters() => throw null;
  }
}
