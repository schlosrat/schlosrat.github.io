// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap2DCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCap2DCollection
  {
    private List<GizmoCap2D> _caps;
    private Dictionary<int, GizmoCap2D> _handleIdToCap;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap2D this[int id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(GizmoCap2D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(GizmoCap2D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(GizmoCap2D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make2DHoverPriorityLowerThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make2DHoverPriorityHigherThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool hoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragSession(IGizmoDragSession dragSession) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap2DCollection() => throw null;
  }
}
