// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundRumbleEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Rumble Effect")]
  public class VPGroundRumbleEffect : MonoBehaviour
  {
    public VPGroundRumbleEffect.Waveform waveform;
    [Range(0.0f, 0.5f)]
    [Space(5f)]
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
