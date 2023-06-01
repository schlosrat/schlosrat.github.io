// Decompiled with JetBrains decompiler
// Type: PACustomBillboardGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PACustomBillboardGenerator : PABillboardParticle, PAICustomParticleGenerator
{
  public List<PACustomParticle> particles;
  [SerializeField]
  [HideInInspector]
  private Mesh particleMesh;
  private Vector2[] particleUVs;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateCache(PAParticleField settings) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override int SetParticleCapacity(int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnValidate() => throw null;

  [ContextMenu("Apply Particles")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyParticles() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetOriginDirection(int particleIndex, Vector3 direction) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSpeed(int particleIndex, float speed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSpinSpeed(int particleIndex, float spinSpeed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetColor(int particleIndex, Color color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetUV(int particleIndex, Rect uv) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSize(int particleIndex, float size) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetIndex(int particleIndex, float normalizedIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomBillboardGenerator() => throw null;
}
