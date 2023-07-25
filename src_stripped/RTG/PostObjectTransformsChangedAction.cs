// Decompiled with JetBrains decompiler
// Type: RTG.PostObjectTransformsChangedAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
