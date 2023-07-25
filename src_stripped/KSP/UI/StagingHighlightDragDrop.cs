// Decompiled with JetBrains decompiler
// Type: KSP.UI.StagingHighlightDragDrop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class StagingHighlightDragDrop : HighlightedDragDropLogic
  {
    [Tooltip("Action key for moving the main list to another index position")]
    [SerializeField]
    protected string ACTION_MOVE_NEXT_INDEX_MAINLIST;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleElementDrag(
      PointerEventData eventData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleElementEndDrag(
      PointerEventData eventData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void MoveElementInto(
      UIList_ListElement element,
      UIList_ListView targetView,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingHighlightDragDrop() => throw null;
  }
}
