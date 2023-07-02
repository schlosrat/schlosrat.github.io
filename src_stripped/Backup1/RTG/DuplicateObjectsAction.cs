// Decompiled with JetBrains decompiler
// Type: RTG.DuplicateObjectsAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class DuplicateObjectsAction : IUndoRedoAction
  {
    private List<GameObject> _rootsToDuplicate;
    private List<GameObject> _duplicateResult;
    private bool _cleanupOnRemovedFromStack;

    public List<GameObject> DuplicateResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DuplicateObjectsAction(List<GameObject> rootsToDuplicate) => throw null;

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
