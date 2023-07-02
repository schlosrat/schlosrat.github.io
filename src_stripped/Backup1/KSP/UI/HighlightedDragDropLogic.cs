// Decompiled with JetBrains decompiler
// Type: KSP.UI.HighlightedDragDropLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class HighlightedDragDropLogic : KerbalMonoBehaviour
  {
    [SerializeField]
    [Tooltip("GameObject Tag that will be compared in order to validate a drop")]
    protected string _compareTag;
    [Tooltip("Action key for moving the main list to another index position")]
    [SerializeField]
    protected string ACTION_MOVE_MAINLIST;
    [Tooltip("Action key for moving an element to a new list at a certain index.")]
    [SerializeField]
    protected string ACTION_MOVE_ELEMENT_TO_LIST_AT_INDEX;
    [Tooltip("Action key for moving a group to another index from a main list")]
    [SerializeField]
    protected string ACTION_MOVE_GROUP_ELEMENT_TO_LIST_AT_INDEX;
    [Tooltip("Action key for moving an element from a group to another index from a main list")]
    [SerializeField]
    protected string ACTION_MOVE_GROUP_ELEMENTS_TO_LIST_AT_INDEX;
    protected UIList_ListElement _curDragElement;
    protected int _curDragElementOriginalIndex;
    protected UIHighlightListValueBinder _uIHighlightListValueBinder;
    protected Component _curDropTarget;
    protected int _curUnityDropIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RegisterNewViewList(UIList_ListView listView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SubscribeListElements(UIList_ListView listView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ModifyNewElement(UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ModifyDeletingElement(UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleElementDrag(PointerEventData eventData, UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleElementBeginDrag(
      PointerEventData eventData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleElementEndDrag(
      PointerEventData eventData,
      UIList_ListElement element)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual int GetDroptargetIndex(UIList_ListView targetView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void MoveElementInto(
      UIList_ListElement element,
      UIList_ListView targetView,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIList_ListView GetValidDropListViewOverPointer(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool IsValidDrop(UIList_ListElement element, Component dropTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool IsDropTargetValidTag(Component dropTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static bool IsRectVisible(RectTransform rectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual int GetUnityChildIndex(
      UIList_ListView hoverView,
      Vector2 screenPos,
      Camera cam)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Transform GetChildContainer(UIList_ListView listView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HighlightedDragDropLogic() => throw null;
  }
}
