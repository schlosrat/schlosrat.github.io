// Decompiled with JetBrains decompiler
// Type: RTG.XZGridCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class XZGridCell
  {
    private IXZGrid _parentGrid;
    private int _xIndex;
    private int _zIndex;
    private Vector3 _min;
    private Vector3 _max;

    public IXZGrid ParentGrid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int XIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ZIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Min
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Max
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public XZGridCell(int xIndex, int zIndex, Vector3 min, Vector3 max, IXZGrid parentGrid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XZGridCell FromPoint(
      Vector3 point,
      float cellSizeX,
      float cellSizeZ,
      IXZGrid parentGrid)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetCenterAndCorners() => throw null;
  }
}
