﻿// Decompiled with JetBrains decompiler
// Type: PABillboardParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PABillboardParticle : PAParticleMeshGenerator
{
  private const int MAX_PARTICLE_COUNT = 16250;
  protected static readonly Vector2[] quadUVs;
  protected static readonly Vector2[] quadOffsets;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override int GetMaximumParticleCount() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override int SetParticleCapacity(int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateDirection(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateColor(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateSpeed(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateSurface(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateTriangles(int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateIndicies() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PABillboardParticle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static PABillboardParticle() => throw null;
}
