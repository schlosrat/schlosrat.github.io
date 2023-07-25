// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Tire Audio", 1)]
  public class VPTireAudio : VehicleBehaviour
  {
    public AudioClip tireSkidAudioClip;
    public AudioMixerGroup output;
    [Header("Skid")]
    public float skidMinSlip;
    public float skidMaxSlip;
    [Range(0.0f, 3f)]
    public float skidMinPitch;
    [Range(0.0f, 3f)]
    public float skidMaxPitch;
    [Range(0.0f, 1f)]
    public float skidMaxVolume;
    [Header("3D Sound Settings")]
    [Tooltip("Maximum volume under this distance")]
    public float minDistance;
    [Tooltip("Volume clipped beyond this distance")]
    public float maxDistance;
    [Tooltip("Volume attenuated progressively until this distance")]
    public float attenuationDistance;
    [Tooltip("This volume constant from Attenuation Distance to Max Distance")]
    public float attenuatedVolume;
    [Header("Low Pass Filter")]
    [Range(0.0f, 1f)]
    public float interiorCameraFilter;
    private VPTireAudio.TireAudioData[] m_tireAudioData;
    private VPCameraController m_cameraController;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AudioSource GetAudioSource(int wheel) => throw null;

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
    private void ConfigureAudioSource(AudioSource audio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessTireAudio(float slip, AudioSource audioSource, VehicleBase.WheelState ws) => throw null;

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
    private void MuteZeroPitch(AudioSource audio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTireAudio() => throw null;

    public class TireAudioData
    {
      public AudioSource audioSource;
      public AudioLowPassFilter lowPassFilter;
      public InterpolatedFloat slip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TireAudioData() => throw null;
    }
  }
}
