// Decompiled with JetBrains decompiler
// Type: JTemp.UIContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JTemp
{
  public class UIContainer : UIElement
  {
    public Action OnStateChanged;
    public Action OnElementsSorted;
    public Func<UIElement, UIElement, int> OverrideComparison;
    public UIContainer.State currentState;
    private UIContainer.State previousState;
    protected ContentSizeFitter fitter;
    protected RectTransform container;
    public RectTransform titleRect;
    public RectTransform contentRect;
    public RectTransform itemsRect;
    public TextMeshProUGUI titleText;
    private List<UIElement> elements;
    private Vector2 defaultContainerSize;
    private float defaultTitleHeight;
    public float spacing;

    protected UIContainer.State CurrentState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    protected UIContainer.State PreviousState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected Vector2 originalContainerSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected Vector2 closedContainerSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected Vector2 titleRectTargetSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected Vector2 contentRectTargetSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateContent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTitle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void GetComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void StateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void AddElement(UIElement ele) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RemoveElement(UIElement ele) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Enable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Disable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Open() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Search(string term) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Sort() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIContainer() => throw null;

    public enum State
    {
      Open,
      Closed,
      DisabledOpen,
      DisableClosed,
    }
  }
}
