// Decompiled with JetBrains decompiler
// Type: DraggableListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableListItem : 
  MonoBehaviour,
  IBeginDragHandler,
  IEventSystemHandler,
  IDragHandler,
  IEndDragHandler,
  IInitializePotentialDragHandler
{
  [SerializeField]
  private RectTransform _targetRectTransform;
  private ReorderableVerticalLayoutGroup _layoutGroup;
  private RectTransform _layoutGroupParentRect;
  private bool _isInitialized;
  private bool _isDragging;
  private Transform _dragOriginalParent;
  private int _siblingIndexStart;
  private Vector2 _dragStartOffset;
  private RectTransform _curDropTarget;
  private int _curDragIndex;
  private float _localXPosStart;
  public Action<int> DragStarted;
  public Action<int> Dragging;
  public Action<int, int> DragEnded;

  public bool IsDragging
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBeginDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEndDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnInitializePotentialDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DraggableListItem() => throw null;
}
