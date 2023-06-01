// Decompiled with JetBrains decompiler
// Type: MissionToggleTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (LayoutElement))]
[RequireComponent(typeof (CanvasGroup))]
public class MissionToggleTooltip : ExtendedTooltip<MissionToggleTooltipData>
{
  [SerializeField]
  private ContextBindRoot _bindRoot;
  [SerializeField]
  private TMP_Text _name;
  [SerializeField]
  private TMP_Text _missionStageNamesText;
  private DataContext _dataContext;
  private List<DOTweenAnimation> _tweenAnimations;
  private Property<string> _tooltipName;
  private Property<string> _tooltipDescritpion;
  private const string NAME_PROPERTY_KEY = "TooltipName";
  private const string DESCRIPTION_PROPERTY_KEY = "TooltipDescription";

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTooltipData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Show() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleTooltipParts(bool description = true, bool name = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleAnimation(string triggerType) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MissionToggleTooltip() => throw null;
}
