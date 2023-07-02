// Decompiled with JetBrains decompiler
// Type: TutorialDescription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
