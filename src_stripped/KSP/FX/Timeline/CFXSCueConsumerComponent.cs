// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.CFXSCueConsumerComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.VFX;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.FX.Timeline
{
  public class CFXSCueConsumerComponent : KerbalMonoBehaviour
  {
    public string _groupID;
    public string _overrideWwiseStartEvent;
    public string _overrideWwiseStopEvent;
    private int _instanceIndex;
    private List<GameObject> _spawnedObjects;
    private List<FXContextualEvent> _spawnedEvents;
    private SequenceControllerComponent _sequenceController;
    private bool _needAudioSmokeLaunchUpdate;
    private float _rtpcNormalizedThrustCache;
    private VesselBehavior _vesselBehavior;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator RegisterMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateTotalThrustForceMagnitudeKN(PartOwnerComponent activePartOwner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CueMessageHandler(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGeneralContextualEvent(VFXEventType fxEventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFuelTankIceEvent(VFXCueMessage vfxMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateLaunchEvent(VFXEventType eventType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopEffects(ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CFXSCueConsumerComponent() => throw null;
  }
}
