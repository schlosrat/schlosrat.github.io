// Decompiled with JetBrains decompiler
// Type: RTG.WorldTransformSnapshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
