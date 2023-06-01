// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class IndicatorProvider : KerbalMonoBehaviour
  {
    private Canvas _indicatorCanvas;
    private RectTransform _canvasTransform;
    private CanvasGroup _canvasGroup;
    private Dictionary<object, object> _indicatorPools;
    private Dictionary<string, RectTransform> _IndicatorTags;
    private List<Indicator> activeIndicators;
    private Indicator _indicatorCache;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideIndicatorCanvasGroup(bool hidden) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddIndicator(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveIndicator(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestIndicator<T>(T indicator) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestIndicator<T>(object id, T indicator) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseIndicator<T>(T indicator) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseIndicator<T>(object id, T indicator) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RepositionIndicatorUI(Indicator indicator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RespositionIndicator(Indicator indicator, Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterTag(string tagName, RectTransform rectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTag(string tagName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectTransform GetTaggedRect(string tagName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorProvider() => throw null;
  }
}
