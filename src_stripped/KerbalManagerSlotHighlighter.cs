// Decompiled with JetBrains decompiler
// Type: KerbalManagerSlotHighlighter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Api.Generic;
using KSP.Game;
using KSP.UI;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof (CanvasGroup))]
[RequireComponent(typeof (UIList_ListElement))]
[RequireComponent(typeof (UIHighlightDraggableValueBinder))]
public class KerbalManagerSlotHighlighter : 
  KerbalMonoBehaviour,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler,
  IEndDragHandler
{
  private UIHighlightDraggableValueBinder _highlightBinder;
  private ContextBindRoot _listElementBinder;
  [SerializeField]
  private string _isEmptyKey;
  [SerializeField]
  private string _isHighlightedKey;
  [SerializeField]
  private string _isHighlightedEmptyKey;
  [SerializeField]
  private string _isValidDropKey;
  [SerializeField]
  private string _isValidDropEmptyKey;
  private IPropertyWritable<bool> _isEmpty;
  private IPropertyWritable<bool> _isHighlighted;
  private IPropertyWritable<bool> _isHighlightedEmpty;
  private IPropertyWritable<bool> _isValidDrop;
  private IPropertyWritable<bool> _isValidDropEmpty;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResolveProperties(IDataContextReadonly context) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerEnter(PointerEventData pointerEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerExit(PointerEventData pointerEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEndDrag(PointerEventData pointerEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetHighlight(bool isHighlighted) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetValidDrop(bool isValidDrop) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KerbalManagerSlotHighlighter() => throw null;
}
