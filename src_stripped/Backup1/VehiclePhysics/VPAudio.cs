// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Audio", 0)]
  public class VPAudio : VehicleBehaviour
  {
    [Tooltip("AudioSource to be used with the one-time audio effects (impacts, etc)")]
    public AudioSource audioClipTemplate;
    [Space(2f)]
    public VPAudio.Engine engine;
    [Space(2f)]
    public VPAudio.EngineExtras engineExtras;
    [Space(2f)]
    public VPAudio.Wheels wheels;
    [Space(2f)]
    public VPAudio.Impacts impacts;
    [Space(2f)]
    public VPAudio.Drags drags;
    [Space(2f)]
    public VPAudio.Wind wind;
    [Space(2f)]
    private InterpolatedFloat m_engineRpm;
    private InterpolatedFloat m_engineLoadRatio;
    private bool m_prevEngineLimiter;
    private bool m_engineLimiterActive;
    private float m_engineLimiterTime;
    private float m_skidRatio;
    private float m_offroadSpeed;
    private float m_lastScratchTime;
    private float m_turboRatio;
    private VPAudio.WheelAudioData[] m_audioData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnterPause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnLeavePause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessEngineAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessInterpolatedEngineAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrcessEngineExtraAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessTireAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessWheelBumpAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessWindAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessImpactsAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessBodyDragAudio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupLoopAudioSource(AudioSource audio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayContinuousAudio(AudioSource audio, float baseValue, float value, float scale = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayContinuousAudio(
      AudioSource audio,
      float ratio,
      float minPitch,
      float maxPitch,
      float minVolume,
      float maxVolume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayContinuousAudioWithFallOff(
      AudioSource audio,
      float value,
      float minValue,
      float maxValue,
      float minPitch,
      float maxPitch,
      float minVolume,
      float maxVolume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayContinuousAudioPitchWithFallOff(
      AudioSource audio,
      float value,
      float minValue,
      float maxValue,
      float minPitch,
      float maxPitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AdjustVolumeWithRatio(
      AudioSource audio,
      float minVolume,
      float maxVolume,
      float ratio,
      float changeRateUp = 1000f,
      float changeRateDown = 1000f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaySpeedBasedAudio(
      AudioSource audio,
      float speed,
      float cutoutSpeed,
      float minSpeed,
      float maxSpeed,
      float cutoutPitch,
      float minPitch,
      float maxPitch,
      float minVolume,
      float maxVolume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaySpeedBasedAudioPitch(
      AudioSource audio,
      float speed,
      float cutoutSpeed,
      float minSpeed,
      float maxSpeed,
      float minPitch,
      float maxPitch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MuteZeroPitch(AudioSource audio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopAudio(AudioSource audio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayWheelBumpAudio(float suspensionForceDelta, Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayOneTime(AudioClip clip, Vector3 position, float volume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayOneTime(AudioClip clip, Vector3 position, float volume, float pitch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPAudio() => throw null;

    [Serializable]
    public class Engine
    {
      public AudioSource audioSource;
      public float audioBaseRpm;
      public float rpmScaling;
      [Space(5f)]
      public float volumeAtRest;
      public float volumeAtFullLoad;
      public float volumeChangeRateUp;
      public float volumeChangeRateDown;
      [Space(5f)]
      public bool keepVolumeAtIdleRpm;
      public float idleRpm;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Engine() => throw null;
    }

    [Serializable]
    public class EngineExtras
    {
      public AudioSource turboAudioSource;
      public float turboMinRpm;
      public float turboMaxRpm;
      [Range(0.0f, 3f)]
      public float turboMinPitch;
      [Range(0.0f, 3f)]
      public float turboMaxPitch;
      [Range(0.0f, 1f)]
      public float turboMaxVolume;
      [Space(5f)]
      public AudioSource transmissionAudioSource;
      public float transmissionMinRpm;
      public float transmissionMaxRpm;
      [Range(0.0f, 3f)]
      public float transmissionMinPitch;
      [Range(0.0f, 3f)]
      public float transmissionMaxPitch;
      [Range(0.0f, 1f)]
      public float transmissionMinVolume;
      [Range(0.0f, 1f)]
      public float transmissionMaxVolume;
      [Space(5f)]
      public AudioSource retarderAudioSource;
      public float retarderMaxTorque;
      [HelpBox("Retarder Min Pitch and Max Pitch are applied to Transmission Min Rpm and Max Rpm", HelpBoxMessageType.Info)]
      [Range(0.0f, 3f)]
      public float retarderMinPitch;
      [Range(0.0f, 3f)]
      public float retarderMaxPitch;
      [Range(0.0f, 1f)]
      public float retarderMaxVolume;
      [NonSerialized]
      public float turboRatioChangeRate;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineExtras() => throw null;
    }

    [Serializable]
    public class RetarderBrake
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public RetarderBrake() => throw null;
    }

    [Serializable]
    public class Wheels
    {
      public AudioSource skidAudioSource;
      public float skidMinSlip;
      public float skidMaxSlip;
      [Range(0.0f, 3f)]
      public float skidMinPitch;
      [Range(0.0f, 3f)]
      public float skidMaxPitch;
      [Range(0.0f, 1f)]
      public float skidMaxVolume;
      [Range(0.0f, 1f)]
      public float skidIntensity;
      [Space(5f)]
      public AudioSource offroadAudioSource;
      public float offroadMinSpeed;
      public float offroadMaxSpeed;
      [Range(0.0f, 3f)]
      public float offroadMinPitch;
      [Range(0.0f, 3f)]
      public float offroadMaxPitch;
      [Range(0.0f, 1f)]
      public float offroadMinVolume;
      [Range(0.0f, 1f)]
      public float offroadMaxVolume;
      [Space(5f)]
      public AudioClip bumpAudioClip;
      public float bumpMinForceDelta;
      public float bumpMaxForceDelta;
      [Range(0.0f, 1f)]
      public float bumpMinVolume;
      [Range(0.0f, 1f)]
      public float bumpMaxVolume;
      [NonSerialized]
      public float skidRatioChangeRate;
      [NonSerialized]
      public float offroadSpeedChangeRate;
      [NonSerialized]
      public float offroadCutoutSpeed;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Wheels() => throw null;
    }

    [Serializable]
    public class Impacts
    {
      [Space(5f)]
      public AudioClip hardImpactAudioClip;
      public AudioClip softImpactAudioClip;
      public float minSpeed;
      public float maxSpeed;
      [Range(0.0f, 3f)]
      public float minPitch;
      [Range(0.0f, 3f)]
      public float maxPitch;
      [Range(0.0f, 3f)]
      public float randomPitch;
      [Range(0.0f, 1f)]
      public float minVolume;
      [Range(0.0f, 1f)]
      public float maxVolume;
      [Range(0.0f, 1f)]
      public float randomVolume;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Impacts() => throw null;
    }

    [Serializable]
    public class Drags
    {
      public AudioSource hardDragAudioSource;
      public AudioSource softDragAudioSource;
      public float minSpeed;
      public float maxSpeed;
      [Range(0.0f, 3f)]
      public float minPitch;
      [Range(0.0f, 3f)]
      public float maxPitch;
      [Range(0.0f, 1f)]
      public float minVolume;
      [Range(0.0f, 1f)]
      public float maxVolume;
      [Space(5f)]
      public AudioClip scratchAudioClip;
      public float scratchRandomThreshold;
      public float scratchMinSpeed;
      public float scratchMinInterval;
      [Range(0.0f, 3f)]
      public float scratchMinPitch;
      [Range(0.0f, 3f)]
      public float scratchMaxPitch;
      [Range(0.0f, 1f)]
      public float scratchMinVolume;
      [Range(0.0f, 1f)]
      public float scratchMaxVolume;
      [NonSerialized]
      public float cutoutSpeed;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Drags() => throw null;
    }

    [Serializable]
    public class Wind
    {
      public AudioSource windAudioSource;
      public float minSpeed;
      public float maxSpeed;
      [Range(0.0f, 3f)]
      public float minPitch;
      [Range(0.0f, 3f)]
      public float maxPitch;
      [Range(0.0f, 1f)]
      public float maxVolume;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Wind() => throw null;
    }

    private class WheelAudioData
    {
      public float lastSuspensionLoad;
      public float lastWheelBumpTime;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WheelAudioData() => throw null;
    }
  }
}
