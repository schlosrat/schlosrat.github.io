// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ColliderUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public static class ColliderUtility
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Collider[] GetSolidColliders(Transform transform, bool includeInactive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ComputeCentroid(
      MeshCollider meshCollider,
      out Vector3 centroid,
      out float volume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ComputeCentroid(
      MeshCollider[] meshColliders,
      out Vector3 centroid,
      out float volume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ComputeCentroidAdditive(
      MeshCollider meshCollider,
      ref Vector3 centroid,
      ref float volume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawColliderGizmos(
      Collider[] colliders,
      Color color,
      bool includeInactiveInHierarchy,
      bool includeNonConvex)
    {
      throw null;
    }

    public class LayerCollisionMatrix
    {
      private Dictionary<int, int> m_masksByLayer;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LayerCollisionMatrix() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Refresh() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int GetLayerCollisionMask(int layer) => throw null;
    }
  }
}
