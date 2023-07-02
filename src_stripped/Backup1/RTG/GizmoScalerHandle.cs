// Decompiled with JetBrains decompiler
// Type: RTG.GizmoScalerHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
