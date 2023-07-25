// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCButtonTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class KSCButtonTooltip : ExtendedTooltip<KSCBuildingTooltipData>
  {
    private const string KSC_MENU_PREFIX = "Menu/KSC/";
    private const string NAME_PROPERTY_KEY = "KSCBuildingTooltipName";
    private const string ICON_PROPERTY_KEY = "KSCBuildingTooltipIcon";
    private const string DESC_PROPERTY_KEY = "KSCBuildingTooltipDesc";
    private const string ANIM_ID = "startDelayed";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private List<DOTweenAnimation> _tweenAnimations;
    private Property<string> _kscTooltipName;
    private Property<Sprite> _kscTooltipIcon;
    private Property<string> _kscBuildingDesc;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTooltipData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOffset(Vector2 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(RectTransform targetRect = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCButtonTooltip() => throw null;
  }
}
