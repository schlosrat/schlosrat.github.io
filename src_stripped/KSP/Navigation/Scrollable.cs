// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.Scrollable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public class Scrollable : Decorator<NavElementGroup>
  {
    public float AutoScrollDuration;
    private ScrollRect _scrollRect;
    private float _minX;
    private float _maxX;
    private float _minY;
    private float _maxY;

    public RectTransform ScrollRectTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ScrollRect ScrollRect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Scrollable(Extend<NavElementGroup> extend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateBoundary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Scroll(Vector2 deltaScroll) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ScrollTo(Selectable element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AnimatedScrollTo(Vector2 destnation, float duration = 0.2f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScrolledCallback(Vector2 deltaAmount) => throw null;
  }
}
