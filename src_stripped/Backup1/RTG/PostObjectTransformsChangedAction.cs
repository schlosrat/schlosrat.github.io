// Decompiled with JetBrains decompiler
// Type: RTG.PostObjectTransformsChangedAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public class PostObjectTransformsChangedAction : IUndoRedoAction
  {
    private List<LocalTransformSnapshot> _preChangeTransformSnapshots;
    private List<LocalTransformSnapshot> _postChangeTransformSnapshots;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostObjectTransformsChangedAction(
      List<LocalTransformSnapshot> preChangeTransformSnapshots,
      List<LocalTransformSnapshot> postChangeTransformSnapshots)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Undo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Redo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRemovedFromUndoRedoStack() => throw null;
  }
}
