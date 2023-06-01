// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCBuildingTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class KSCBuildingTooltip : Extended3DObjectTooltip<KSCBuildingTooltipData>
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
    public override void Show(Camera currentCamera = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCBuildingTooltip() => throw null;
  }
}
