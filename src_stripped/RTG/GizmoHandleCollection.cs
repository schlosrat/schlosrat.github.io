// Decompiled with JetBrains decompiler
// Type: RTG.GizmoHandleCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoHandleCollection
  {
    private Gizmo _gizmo;
    private List<IGizmoHandle> _handles;
    private Dictionary<int, IGizmoHandle> _idToHandle;

    public Gizmo Gizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGizmoHandle this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandleCollection(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IGizmoHandle GetHandleById(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(IGizmoHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(IGizmoHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(IGizmoHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<IGizmoHandle> GetAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay) => throw null;
  }
}
