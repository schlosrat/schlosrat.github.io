// Decompiled with JetBrains decompiler
// Type: MissionToggleTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (MissionToggleExtended))]
public class MissionToggleTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
{
  [SerializeField]
  private MissionToggleTooltip _tooltipPrefab;
  private MissionToggleTooltip _currentTooltip;
  private MissionToggleTooltipData _tooltipData;
  private MissionToggleExtended _missionToggle;

  public int Priority
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Initialize(string name, string description, string missionStages) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnExit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MissionToggleTooltipTarget() => throw null;
}
