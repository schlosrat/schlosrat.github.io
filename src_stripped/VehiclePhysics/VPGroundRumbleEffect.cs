// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundRumbleEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Rumble Effect")]
  public class VPGroundRumbleEffect : MonoBehaviour
  {
    public VPGroundRumbleEffect.Waveform waveform;
    [Space(5f)]
    [Range(0.0f, 0.5f)]
    public float amplitude;
    [Range(0.0f, 1f)]
    public float midPoint;
    public float periodLength;
    public float perlinSeed;
    [Range(0.0f, 5f)]
    public float forceLimiter;
    [Space(5f)]
    public float noEffectSpeed;
    public float fullEffectSpeed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyEffect(VehicleBase.WheelState wheel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SuspensionEffect(VehicleBase.WheelState ws, float factor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float UnitWaveform(float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundRumbleEffect() => throw null;

    public enum Waveform
    {
      Triangle,
      Saw,
      Perlin,
      Step,
    }
  }
}
