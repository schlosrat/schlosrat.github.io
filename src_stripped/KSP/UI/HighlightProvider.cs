// Decompiled with JetBrains decompiler
// Type: KSP.UI.HighlightProvider
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
  public class HighlightProvider : KerbalMonoBehaviour
  {
    private Canvas _highlightsCanvas;
    private RectTransform _canvasTransform;
    private Dictionary<object, object> _highlightPools;
    private List<Highlight> activeHighlights;
    private Highlight highlightCache;
    public int countPlanets;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateActiveHighlights() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestHighlight<T>(T highlight) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestHighlight<T>(object id, T highlight) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseHighlight<T>(T highlight) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseHighlight<T>(object id, T highlight) where T : Component => throw null;

    [ContextMenu("UpdatePlanetCount")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePlanetCount() => throw null;

    [ContextMenu("HighlightHomebodyPlanet")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HighlightPlanetByIndex() => throw null;

    [ContextMenu("TestHighlightNavball")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TestHighlightNavball() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HighlightProvider() => throw null;
  }
}
