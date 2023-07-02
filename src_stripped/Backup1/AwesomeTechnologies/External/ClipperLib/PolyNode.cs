// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.PolyNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.External.ClipperLib
{
  public class PolyNode
  {
    internal PolyNode m_Parent;
    internal List<IntPoint> m_polygon;
    internal int m_Index;
    internal JoinType m_jointype;
    internal EndType m_endtype;
    internal List<PolyNode> m_Childs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsHoleNode() => throw null;

    public int ChildCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IntPoint> Contour
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AddChild(PolyNode Child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolyNode GetNext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal PolyNode GetNextSiblingUp() => throw null;

    public List<PolyNode> Childs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PolyNode Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsOpen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolyNode() => throw null;
  }
}
