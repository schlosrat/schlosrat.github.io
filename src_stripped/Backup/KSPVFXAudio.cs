// Decompiled with JetBrains decompiler
// Type: KSPVFXAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPVFXAudio : MonoBehaviour, WaterManager.IWaterDetectObject
{
  private ParticleSystem _particleSystem;
  private ThrottleVFXManager _throttleVFXManager;
  private IEngineFXData _engineFXData;
  private TrailRenderer _trailRenderer;
  private int _particleCount;
  private bool _isEmitting;
  private bool _isUnderwater;
  private uint _waterDetectObjectId;
  public AK.Wwise.Event[] OnParticleStart;
  public AK.Wwise.Event[] OnParticleStop;

  private GameInstance _game
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnStartEmitting() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnStopEmitting() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayAudioEvents(AK.Wwise.Event[] audioEvents) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  Vector3 WaterManager.IWaterDetectObject.GetPosition() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  string WaterManager.IWaterDetectObject.GetBody() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  Vector3 WaterManager.IWaterDetectObject.GetHorizonUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPVFXAudio() => throw null;
}
