// Decompiled with JetBrains decompiler
// Type: KSP.UI.ESCMenuActionElementsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Header("Quit To Main Menu Button")]
    [SerializeField]
    private GameObject _quitToMainMenu;
    [Header("Recover Vessel Button")]
    [SerializeField]
    private GameObject _recoverVesselButton;
    [Header("Revert to Launchpad Button")]
    [SerializeField]
    private CanvasGroup _revertToLaunchpadCanvasGroup;
    [SerializeField]
    private Image _revertToLaunchpadIcon;
    [SerializeField]
    private TextMeshProUGUI _revertToLaunchpadText;
    [SerializeField]
    [Header("Revert to VAB Button")]
    private CanvasGroup _revertToVABCanvasGroup;
    [SerializeField]
    private Image _revertToVABIcon;
    [SerializeField]
    private TextMeshProUGUI _revertToVABText;
    [Header("Tracking Station Button")]
    [SerializeField]
    private CanvasGroup _trackingStationCanvasGroup;
    [SerializeField]
    private Image _trackingStationIcon;
    [SerializeField]
    private TextMeshProUGUI _trackingStationText;
    [Header("Mission Control Button")]
    [SerializeField]
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
    [Header("Build Version Text")]
    [SerializeField]
    private TextMeshProUGUI _buildVersionText;
    [SerializeField]
    private GameObject _emptyLineToHide;
    [Header("Button Status Settings")]
    [SerializeField]
    [Range(0.0f, 255f)]
    private byte _enabledOpacity;
    [SerializeField]
    [Range(0.0f, 255f)]
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
