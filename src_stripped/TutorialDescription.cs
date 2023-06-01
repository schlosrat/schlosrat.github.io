// Decompiled with JetBrains decompiler
// Type: TutorialDescription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialDescription : KerbalMonoBehaviour, ITooltipTarget
{
  [SerializeField]
  private TrainingCentreTooltip tooltipPrefab;
  private TrainingCentreTooltip currentTooltip;
  private TutorialElementData tooltipData;

  public int Priority
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize(string description) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnEnter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnExit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TutorialDescription() => throw null;
}
