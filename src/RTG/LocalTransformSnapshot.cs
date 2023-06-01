// Decompiled with JetBrains decompiler
// Type: RTG.LocalTransformSnapshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class LocalTransformSnapshot
  {
    private Transform _transform;
    private Transform _parentTransform;
    private Vector3 _localPosition;
    private Quaternion _localRotation;
    private Vector3 _localScale;

    public Transform Transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<LocalTransformSnapshot> GetSnapshotCollection(
      IEnumerable<GameObject> gameObjects)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Snapshot(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SameAs(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalTransformSnapshot() => throw null;
  }
}
