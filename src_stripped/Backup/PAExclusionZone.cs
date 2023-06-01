// Decompiled with JetBrains decompiler
// Type: PAExclusionZone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class PAExclusionZone : MonoBehaviour
{
  public static List<PAExclusionZone> exclusionZones;
  public LayerMask affectsLayers;
  public Vector3 edgeThreshold;
  public bool important;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void RegisterZone(PAExclusionZone zone) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void UnregisterZone(PAExclusionZone zone) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmos() => throw null;

  private Bounds bounds
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Vector3 ClosestPointOnBounds(Bounds bounds, Vector3 point) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetExclusionZones(
    ref PAExclusionZone[] zones,
    Vector3 position,
    Bounds checkBounds,
    int layer)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static PAExclusionZone Create(string name) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PAExclusionZone() => throw null;
}
