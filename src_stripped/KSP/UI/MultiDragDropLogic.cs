// Decompiled with JetBrains decompiler
// Type: KSP.UI.MultiDragDropLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class MultiDragDropLogic : MonoBehaviour
  {
    private const string DUMMY_OBJECT_NAME = "Dummy Object";
    [Space]
    public CanvasGroup DraggingWidget;
    private Component _curDropTarget;
    private int _curUnityDropIndex;
    private UIList_ListElement _curDragElement;
    private int _curDragElementOriginalIndex;
    public UIList_ListElement _debugElement;
    private const string ACTION_MOVE_ELEMENT_TO_LIST_AT_INDEX = "../../MoveFromSourceListToTargetListAtIndex";
    private const string ACTION_MOVE_FOLDER_ELEMENT_TO_LIST_AT_INDEX = "../../../MoveFromSourceFolderToTargetStageAtIndex";
    private const string ACTION_MOVE_FOLDER_ELEMENTS_TO_LIST_AT_INDEX = "../../MoveSourceFolderElementsToTargetStageAtIndex";

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [ContextMenu("DebugSubscribeElement")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugSubscribeElement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubscribeListElements(UIList_ListView listView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterNewViewList(UIList_ListView listView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ModifyNewElement(UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ModifyDeletingElement(UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleElementDrag(PointerEventData eventData, UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleElementBeginDrag(PointerEventData eventData, UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleElementEndDrag(PointerEventData eventData, UIList_ListElement element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValidDrop(UIList_ListElement element, Component dropTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetUnityChildIndex(UIList_ListView hoverView, Vector2 screenPos, Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsRectVisible(RectTransform rectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearDropTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDraggingWidget(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private UIList_ListView GetValidDropListViewOverPointer(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static RectTransform GetDummyObject(UIList_ListView list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ResetDummyObject(UIList_ListView list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetDummyRectDimensions(UIList_ListView list, RectTransform source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetDummySiblingIndex(UIList_ListView list, int targetElementIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetDummyVisibility(UIList_ListView list, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Transform GetChildContainer(UIList_ListView listView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsDropTargetStage(Component dropTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveElementInto(
      UIList_ListElement element,
      UIList_ListView targetView,
      int targetElementIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MultiDragDropLogic() => throw null;
  }
}
