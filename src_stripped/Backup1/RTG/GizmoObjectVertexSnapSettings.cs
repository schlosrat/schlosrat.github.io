// Decompiled with JetBrains decompiler
// Type: RTG.GizmoObjectVertexSnapSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
