// Decompiled with JetBrains decompiler
// Type: RTG.Shape2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class Shape2D
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RenderArea(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void RenderBorder(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool ContainsPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Rect GetEncapsulatingRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Shape2D() => throw null;
  }
}
