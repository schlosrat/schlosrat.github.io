// Decompiled with JetBrains decompiler
// Type: RTG.PostGizmoTransformsChangedAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public class PostGizmoTransformsChangedAction : IUndoRedoAction
  {
    private List<LocalGizmoTransformSnapshot> _preChangeTransformSnapshots;
    private List<LocalGizmoTransformSnapshot> _postChangeTransformSnapshots;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostGizmoTransformsChangedAction(
      List<LocalGizmoTransformSnapshot> preChangeTransformSnapshots,
      List<LocalGizmoTransformSnapshot> postChangeTransformSnapshots)
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
