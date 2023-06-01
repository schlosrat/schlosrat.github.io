// Decompiled with JetBrains decompiler
// Type: PAParticleMeshGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class PAParticleMeshGenerator : MonoBehaviour, ISerializationCallbackReceiver
{
  private const int DATA_STRUCTURE_VERSION = 2;
  [SerializeField]
  [HideInInspector]
  protected Vector3[] verts;
  [SerializeField]
  [HideInInspector]
  protected Vector3[] normals;
  [SerializeField]
  [HideInInspector]
  protected Vector4[] tangents;
  [SerializeField]
  [HideInInspector]
  protected Vector2[] uv0;
  [SerializeField]
  [HideInInspector]
  protected Vector2[] uv1;
  [HideInInspector]
  [SerializeField]
  protected Color[] colors;
  [HideInInspector]
  [SerializeField]
  protected int[] triangles;
  [HideInInspector]
  [SerializeField]
  private int dataStructureVersion;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBeforeSerialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnAfterDeserialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void CacheSeed() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetSeed(int seed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected float GetRandomAndIncrement(float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void ResetSeed() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual int GetMaximumParticleCount() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual float GetParticleBaseSize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void SkipRandomCalls(int callsPerParticle, int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void UpdateMesh(Mesh mesh, PAParticleField settings) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateCache(PAParticleField settings) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void FillMesh(Mesh mesh) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int GetClampedParticleCount(int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual int SetParticleCapacity(int count) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void SetArraySizes(int vertCount, int triCount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateDirection(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateSurface(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateSpeed(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateColor(PAParticleField settings, int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateIndicies() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void UpdateTriangles(int startAt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearCache() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CheckDataStructureVersion() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PAParticleMeshGenerator() => throw null;

  public static class RandomWrapper
  {
    private static int m_Seed;
    public static Random.State cachedState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CacheState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RestoreState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetState(int seed) => throw null;

    public static int seed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
