// Decompiled with JetBrains decompiler
// Type: KSP.UI.TechnologyNodeTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (CanvasGroup))]
  [RequireComponent(typeof (LayoutElement))]
  public class TechnologyNodeTooltip : ExtendedTooltip<TechnologyNodeTooltipData>
  {
    private const string RD_CENTER_PREFIX = "Menu/RDCenter/";
    private const string UNRESEARCHED_TECH_KEY = "UnresearchedTechInfo";
    private const string CANNOT_AFFORD_KEY = "Cannot Afford";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Header("Tooltip parts")]
    [SerializeField]
    private Image _icon;
    [SerializeField]
    private TMP_Text _name;
    [SerializeField]
    private TMP_Text _researched;
    [SerializeField]
    private GameObject _scienceCost;
    [SerializeField]
    private TMP_Text _accessInfo;
    private DataContext _dataContext;
    private List<DOTweenAnimation> _tweenAnimations;
    private Property<string> _tooltipName;
    private Property<Sprite> _tooltipIcon;
    private Property<int> _technologyCost;
    private const string NAME_PROPERTY_KEY = "TooltipName";
    private const string ICON_PROPERTY_KEY = "TooltipIcon";
    private const string COST_PROPERTY_KEY = "TechnologyCost";

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTooltipData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PurchasedTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CannotAffordTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PurchasableTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NotPurchasableTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleTooltipParts(
      bool researched,
      bool scienceCost,
      bool accessInfo,
      bool icon = true,
      bool name = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TechnologyNodeTooltip() => throw null;
  }
}
