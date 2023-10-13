// Decompiled with JetBrains decompiler
// Type: KSP.UI.StagingHighlightDragDrop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class StagingHighlightDragDrop : HighlightedDragDropLogic
  {
    [SerializeField]
    [Tooltip("Action key for moving the main list to another index position")]
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
