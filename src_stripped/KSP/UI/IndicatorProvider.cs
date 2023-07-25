// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class IndicatorProvider : KerbalMonoBehaviour
  {
    private Canvas _indicatorCanvas;
    [SerializeField]
    private Canvas _viewIndicatorCanvas;
    [SerializeField]
    private Canvas _interactiveIndicatorCanvas;
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
    private void SetIndicatorParent(Indicator indicator, bool worldPositionStays = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorProvider() => throw null;
  }
}
