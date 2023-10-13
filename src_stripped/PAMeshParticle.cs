// Decompiled with JetBrains decompiler
// Type: PAMeshParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PAMeshParticle : PAParticleMeshGenerator
{
  private const int MAX_VERT_COUNT = 65536;
  [HideInInspector]
  public Mesh inputMesh;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override int GetMaximumParticleCount() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override float GetParticleBaseSize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void UpdateMesh(Mesh mesh, PAParticleField settings) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override int SetParticleCapacity(int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateDirection(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateColor(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateSurface(PAParticleField settings, int startAt = 0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateTriangles(int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateSpeed(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float Vector3ToFloat(Vector3 c) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PAMeshParticle() => throw null;
}
