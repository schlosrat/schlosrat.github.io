// Decompiled with JetBrains decompiler
// Type: RTG.Shape3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class Shape3D
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Raycast(Ray ray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastWire(Ray ray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool RaycastWire(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RenderSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RenderWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool Raycast(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract AABB GetAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Shape3D() => throw null;
  }
}
