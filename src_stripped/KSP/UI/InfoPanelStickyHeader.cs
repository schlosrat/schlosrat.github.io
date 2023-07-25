// Decompiled with JetBrains decompiler
// Type: KSP.UI.InfoPanelStickyHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class InfoPanelStickyHeader : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private RectTransform _topRectTransform;
    [SerializeField]
    private RectTransform _bottomRectTransform;
    private DataContext _dataContext;
    private Property<string> _headerTitle;
    private CanvasGroup _canvasGroup;
    private InfoPanelStickyHeaderTarget _currentTarget;
    private List<RaycastResult> _raycastResults;
    private Canvas _parentCanvas;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameInstance GetGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAccordionOpenUnder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHeaderPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InfoPanelStickyHeader() => throw null;
  }
}
