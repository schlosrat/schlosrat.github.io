// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PlayAnimationKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PlayAnimationKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private Action _onAnimEndCallback;
    private bool _disableEVAFlightInteractInputs;
    private Queue<PlayAnimationRequestKerbalCharacterMessage> _requestsQueue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayAnimationKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterAnimationEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterAnimationEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnimationEndEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanBeDeactivatedByLocomotionHandler(
      KerbalCharacterStateHandler deactivateByHandler)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool ShouldBeActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyStaticFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyUpright() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void AcceptMessage(KerbalCharacterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayAnimation(PlayAnimationRequestKerbalCharacterMessage msg) => throw null;
  }
}
