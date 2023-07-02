// Decompiled with JetBrains decompiler
// Type: RTG.Plane2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class Plane2D
  {
    private Vector2 _normal;
    private float _distance;

    public Vector2 Normal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Distance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Plane2D(Vector2 normal, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Plane2D(Vector2 normal, Vector2 pointOnPlane) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetDistanceToPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t) => throw null;
  }
}
