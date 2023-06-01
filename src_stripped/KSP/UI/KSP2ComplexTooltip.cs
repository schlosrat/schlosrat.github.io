// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ComplexTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (LayoutElement))]
  [RequireComponent(typeof (CanvasGroup))]
  public class KSP2ComplexTooltip : ExtendedTooltip<ComplexTooltipData>
  {
    [SerializeField]
    private int _tabsCount;
    [SerializeField]
    private DOTweenAnimation _onStartDelayAnimation;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private GameObject _expandedField;
    private DataContext _dataContext;
    private Property<string>[] _titleProperties;
    private Property<string>[] _descriptionProperties;
    private Property<Sprite>[] _iconProperties;
    private const string TITLE_PROPERTY_KEY = "TooltipTitle";
    private const string DESCRIPTION_PROPERTY_KEY = "TooltipDescription";
    private const string ICON_PROPERTY_KEY = "TooltipIcon";

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTooltipData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FreezeHandling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleTooltipExpansion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetUpBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ComplexTooltip() => throw null;
  }
}
