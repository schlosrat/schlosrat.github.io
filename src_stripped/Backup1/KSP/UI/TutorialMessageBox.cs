// Decompiled with JetBrains decompiler
// Type: KSP.UI.TutorialMessageBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [SerializeField]
    [Header("Positioning")]
    private Vector2 _defaultPosition;
    [SerializeField]
    private Vector2 _defaultPivot;
    [SerializeField]
    private Vector2 _defaultAnchorMin;
    [SerializeField]
    private Vector2 _defaultAnchorMax;
    [SerializeField]
    [Header("Text components")]
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
    private Vector2 _overriddenCurrentPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWindowMoved(RectTransform rectTransform) => throw null;

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
      MessageDescriptions messageDescriptions = null,
      bool resetPositionToDefault = false,
      bool useCustomPosition = false,
      Vector2 customPosition = default (Vector2),
      bool useCustomAnchor = false,
      Vector2 customAnchorMin = default (Vector2),
      Vector2 customAnchorMax = default (Vector2),
      bool useCustomPivot = false,
      Vector2 customPivot = default (Vector2))
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
