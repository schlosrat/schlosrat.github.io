// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPGroundParticleEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Ground Materials/Ground Particle Emitter")]
  [RequireComponent(typeof (ParticleSystem))]
  public class VPGroundParticleEmitter : MonoBehaviour
  {
    public VPGroundParticleEmitter.Mode mode;
    public float emissionRate;
    [Range(0.0f, 1f)]
    public float emissionShuffle;
    public float maxLifetime;
    public float minVelocity;
    public float maxVelocity;
    [Range(0.0f, 1f)]
    public float wheelVelocityRatio;
    [Range(0.0f, 1f)]
    public float tireVelocityRatio;
    public Color Color1;
    public Color Color2;
    public bool randomColor;
    private ParticleSystem m_particles;
    private ParticleSystem.EmitParams m_emitParams;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float EmitParticle(
      Vector3 position,
      Vector3 wheelVelocity,
      Vector3 tireVelocity,
      float pressureRatio,
      float intensityRatio,
      float lastParticleTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPGroundParticleEmitter() => throw null;

    public enum Mode
    {
      PressureAndSkid,
      PressureAndVelocity,
    }
  }
}
