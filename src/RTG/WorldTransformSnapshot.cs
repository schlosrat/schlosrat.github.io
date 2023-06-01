// Decompiled with JetBrains decompiler
// Type: RTG.WorldTransformSnapshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class WorldTransformSnapshot
  {
    private Vector3 _worldPosition;
    private Quaternion _worldRotation;
    private Vector3 _worldScale;

    public Vector3 WorldPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion WorldRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 WorldScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Snaphot(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SameAs(Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WorldTransformSnapshot() => throw null;
  }
}
