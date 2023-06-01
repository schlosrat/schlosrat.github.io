// Decompiled with JetBrains decompiler
// Type: RTG.GizmoScalerHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoScalerHandle
  {
    private int _handleId;
    private List<int> _scaleDragAxisIndices;

    public int HandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<int> ScaleDragAxisIndices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex) => throw null;
  }
}
