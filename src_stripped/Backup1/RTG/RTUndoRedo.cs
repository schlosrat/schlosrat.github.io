// Decompiled with JetBrains decompiler
// Type: RTG.RTUndoRedo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RTUndoRedo : MonoSingleton<RTUndoRedo>
  {
    [SerializeField]
    private bool _isEnabled;
    [SerializeField]
    private int _actionLimit;
    private List<RTUndoRedo.ActionGroup> _actionGroupStack;
    private int _stackPointer;

    public event UndoStartHandler UndoStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event UndoEndHandler UndoEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event RedoStartHandler RedoStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event RedoEndHandler RedoEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event CanUndoRedoHandler CanUndoRedo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ActionLimit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecordAction(IUndoRedoAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Undo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Redo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveGroups(int startIndex, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTUndoRedo() => throw null;

    private class ActionGroup
    {
      public List<IUndoRedoAction> Actions;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActionGroup(IUndoRedoAction action) => throw null;
    }
  }
}
