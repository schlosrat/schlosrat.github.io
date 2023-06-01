// Decompiled with JetBrains decompiler
// Type: KSP.UI.TutorialMessageBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UserInterface;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace KSP.UI
{
  [PrefabName("TutorialMessageBox.prefab")]
  public class TutorialMessageBox : KSP2UIWindow
  {
    [SerializeField]
    [Space(5f)]
    private Image smallImage;
    [SerializeField]
    private Transform gifTextArea;
    [SerializeField]
    private VideoPlayer player;
    [Header("Text components")]
    [SerializeField]
    private TextMeshProUGUI windowTitleText;
    [SerializeField]
    private TextMeshProUGUI tittleText;
    [SerializeField]
    private TextMeshProUGUI messageBoxText;
    [Header("Buttons")]
    [SerializeField]
    private Transform buttonArea;
    [SerializeField]
    private ButtonExtended endTutorialButton;
    [SerializeField]
    private ButtonExtended continueButton;
    [SerializeField]
    private ButtonExtended replayButton;
    [SerializeField]
    private ButtonExtended continueToNextTutorial;
    [SerializeField]
    [Header("Other Summary Settings")]
    private Image windowTitleBackground;
    [SerializeField]
    private Transform descriptionsContainer;
    [SerializeField]
    private MessageDescription messageDescriptionPrefab;
    [SerializeField]
    private string nextMissionID;
    [SerializeField]
    private bool isMissionSummary;
    private List<MessageDescription> instancedMessageDescriptions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show(
      string windowTitle,
      string title,
      string descriptionText,
      System.Type eventTypeDismiss = null,
      TutorialMessageBoxButtonType buttonType = TutorialMessageBoxButtonType.None,
      string imageKey = null,
      string playerClip = null,
      string nextMissionID = "",
      bool isMissionSummary = false,
      MessageDescriptions messageDescriptions = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReplayTutorial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayNextTutorial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnContinue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MissionSummaryDismissed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEndTutorialButtonSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MessageDescription InstanceNewDescription() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleCursorEnabled(bool var) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TutorialMessageBox() => throw null;
  }
}
