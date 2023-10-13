// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuActionElementsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class ESCMenuActionElementsController : KerbalMonoBehaviour
  {
    private const string STOP_MULTIPLAYER_SESSION_LOCALIZATION_KEY = "Stop Multiplayer Session";
    private const string LEAVE_MULTIPLAYER_SESSION_LOCALIZATION_KEY = "Leave Multiplayer Session";
    [SerializeField]
    [Header("Remove For MP-Only Modes")]
    private GameObject[] _hideForMPOnly;
    [SerializeField]
    [Header("Remove For Read-Only Modes")]
    private GameObject[] _hideForReadOnly;
    [SerializeField]
    [Header("Quit To Main Menu Button")]
    private GameObject _quitToMainMenu;
    [SerializeField]
    [Header("Recover Vessel Button")]
    private GameObject _recoverVesselButton;
    [Header("Revert to Launchpad Button")]
    [SerializeField]
    private CanvasGroup _revertToLaunchpadCanvasGroup;
    [SerializeField]
    private Image _revertToLaunchpadIcon;
    [SerializeField]
    private TextMeshProUGUI _revertToLaunchpadText;
    [Header("Revert to VAB Button")]
    [SerializeField]
    private CanvasGroup _revertToVABCanvasGroup;
    [SerializeField]
    private Image _revertToVABIcon;
    [SerializeField]
    private TextMeshProUGUI _revertToVABText;
    [SerializeField]
    [Header("Tracking Station Button")]
    private CanvasGroup _trackingStationCanvasGroup;
    [SerializeField]
    private Image _trackingStationIcon;
    [SerializeField]
    private TextMeshProUGUI _trackingStationText;
    [SerializeField]
    [Header("Mission Control Button")]
    private GameObject _missionControlGameObject;
    [SerializeField]
    private CanvasGroup _missionControlCanvasGroup;
    [SerializeField]
    private Image _missionControlIcon;
    [SerializeField]
    private TextMeshProUGUI _missionControlText;
    [Header("R&D Button")]
    [SerializeField]
    private GameObject _researchGameObject;
    [SerializeField]
    private CanvasGroup _researchCanvasGroup;
    [SerializeField]
    private Image _researchIcon;
    [SerializeField]
    private TextMeshProUGUI _researchText;
    [Header("Training Center Button")]
    [SerializeField]
    private CanvasGroup _trainingCenterCanvasGroup;
    [SerializeField]
    private Image _trainingCenterIcon;
    [SerializeField]
    private TextMeshProUGUI _trainingCenterText;
    [SerializeField]
    [Header("Build Version Text")]
    private TextMeshProUGUI _buildVersionText;
    [SerializeField]
    private GameObject _emptyLineToHide;
    [Range(0.0f, 255f)]
    [SerializeField]
    [Header("Button Status Settings")]
    private byte _enabledOpacity;
    [Range(0.0f, 255f)]
    [SerializeField]
    private byte _disabledOpacity;
    private ESCMenuActionElements _escMenuActionElements;
    private bool _prevHasValidLaunchRevision;
    private bool _prevHasValidVABRevision;
    private ESCMenuActionElements[] _actionElements;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideActionsForMPOnlyModes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideActionsForReadOnlyModes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleShowHideButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetQuittingActionButtonNames(bool isHost) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetButtonAvailability(
      bool isAvailable,
      CanvasGroup canvas,
      Image image,
      TextMeshProUGUI text)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRevertAvailability(bool isLaunchRevertable, bool isVABRevertable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTrackingStationAvailability(bool isAvailable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionControlAvailability(bool isAvailable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetResearchAvailability(bool isAvailable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTrainingCenterAvailability(bool isAvailable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetIDsForAvaiableActionElements(ESCMenuActionElements[] actionElements) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ESCMenuActionElementsController() => throw null;
  }
}
