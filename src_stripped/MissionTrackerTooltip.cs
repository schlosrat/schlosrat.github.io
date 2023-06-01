// Decompiled with JetBrains decompiler
// Type: MissionTrackerTooltip
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

[RequireComponent(typeof (CanvasGroup))]
public class MissionTrackerTooltip : ExtendedTooltip<MissionTrackerTooltipData>
{
  [SerializeField]
  private ContextBindRoot _bindRoot;
  [SerializeField]
  private TMP_Text _name;
  [SerializeField]
  private TMP_Text _description;
  private CanvasGroup _canvasGroup;
  private DataContext _dataContext;
  private MissionControlAction _missionControl;
  private List<DOTweenAnimation> _tweenAnimations;
  private MissionTrackerTooltipData _tooltipData;
  private Property<string> _tooltipName;
  private Property<string> _tooltipMissionStagesNames;
  private const string NAME_PROPERTY_KEY = "TooltipName";
  private const string DESCRIPTION_PROPERTY_KEY = "TooltipDescription";
  private bool _isInitialized;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMissionTrackerTooltipClose() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitializeData(string name, string description) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTooltipData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Show() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleTooltipParts(bool description = true, bool name = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HandleAnimation(string triggerType) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetVisible(bool isVisible = true) => throw null;

  public bool IsVisible
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MissionTrackerTooltip() => throw null;
}
