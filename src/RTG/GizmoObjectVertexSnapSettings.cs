// Decompiled with JetBrains decompiler
// Type: RTG.GizmoObjectVertexSnapSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class GizmoObjectVertexSnapSettings : Settings
  {
    [SerializeField]
    private int _snapDestinationLayers;
    [SerializeField]
    private bool _canSnapToGrid;
    [SerializeField]
    private bool _canSnapToObjectVerts;

    public int SnapDestinationLayers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool CanSnapToGrid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool CanSnapToObjectVerts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLayerSnapDestination(int objectLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLayerSnapDestination(int objectLayer, bool isSnapDestination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Transfer(GizmoObjectVertexSnapSettings destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoObjectVertexSnapSettings() => throw null;
  }
}
