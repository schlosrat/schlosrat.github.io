// Decompiled with JetBrains decompiler
// Type: KSP.Game.UIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Logging;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.UI;
using KSP.UI.Binding;
using KSP.UI.Flight;
using KSP.UserInterface;
using KSP.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class UIManager : KerbalMonoBehaviour
  {
    private const LogFilter LOGTAG = (LogFilter) 2097152;
    private const string LOGPREFIX = "[UIManager] ";
    [Header("UI Canvases")]
    [SerializeField]
    private GameObject _canvasPrefab;
    [SerializeField]
    private Canvas _mainCanvas;
    [SerializeField]
    private Canvas _popupCanvas;
    [SerializeField]
    private Canvas _scaledMainCanvas;
    [SerializeField]
    private Canvas _scaledPopupCanvas;
    [SerializeField]
    private Canvas _researchDevelopmentCanvas;
    [SerializeField]
    private Canvas _curtainCanvas;
    [SerializeField]
    private DebugPanelManager _debugCanvas;
    [SerializeField]
    private GameObject _orthographicCollection;
    [SerializeField]
    [Space]
    private TooltipProvider _tooltipProvider;
    [SerializeField]
    private NotificationUIProvider _notificationUIProvider;
    [SerializeField]
    private IndicatorProvider _indicatorProvider;
    [SerializeField]
    private HighlightProvider _highlightProvider;
    [SerializeField]
    [Space]
    private ContextPanelController _contextPanelController;
    [SerializeField]
    internal Canvas _betaMark;
    [Header("Loading and Meta")]
    public LoadingBar LoadingBar;
    public Curtain Curtain;
    public TextMeshProUGUI TextVersionNumber;
    [Space]
    [SerializeField]
    private ContextBindRoot _contextBindRoot;
    [Header("Zoom Mode")]
    public ZoomModeInfo ZoomModeInfo;
    [SerializeField]
    [Header("Part Outlines and MouseOver")]
    private string _outlinesLayerName;
    [SerializeField]
    private float mouseOverRaycastDistance;
    [SerializeField]
    private ObjectOutlinesManager _outlineManager;
    private List<KSP2UIWindow> _windows;
    public Property<Sprite> PropertyPlayerFlag;
    public Property<GameState> PropertyGameState;
    public Property<string> PropertyPlayerName;
    public Property<string> PropertyPlayerAgency;
    public Property<float> PropertyPlayerScience;
    public Property<long> PropertyPlayerPlayTime;
    public Property<string> PropertyGameMode;
    public Property<bool> PropertyIsMultiplayer;
    public Property<string> PropertyServerName;
    public Property<string> PropertyAdmin;
    [Header("Notification Debug")]
    public Sprite NotificationWarningIcon;
    public Sprite NotificationDeliveryIcon;
    public Sprite NotificationRocketIcon;
    public Sprite NotificationDotsIcon;
    public Sprite NotificationPlanetIcon;
    private readonly Dictionary<System.Type, UIModule> _activeModules;
    private readonly Dictionary<System.Type, List<UIModule>> _cachedModules;
    private UIViewController _viewController;
    private UIScaleController _scaleController;
    private SubscriptionHandle _gameStateChangeHandle;
    private SubscriptionHandle _cameraChangeHandle;
    private GlobalEscapeMenu _escapeMenu;
    private UIFlightHud _flightHud;
    private KSCMenuManager _kscMenu;
    private KSP2MessageBox _messageBox;
    private TutorialMessageBox _tutorialMessageBox;
    private TutorialFullScreenVideo _tutorialFullScreenVideoPlayer;
    private GlobalHeaderManager _globalHeader;
    private bool _initialized;
    private List<KeyValuePair<PartBehavior, float>> _partsUnderMouseRay;
    private PartBehavior _partUnderMouse;
    private PartBehavior _lastPartUnderMouse;
    private Camera _mouseOverRayCastCamera;

    public DebugPanelManager DebugPanel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TooltipProvider TooltipProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IndicatorProvider IndicatorProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public HighlightProvider HighlightProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public NotificationUIProvider NotificationProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextPanelController ContextPanelController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Initialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectOutlinesManager OutlineManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string OutlinesLayerName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DataContext GlobalDataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartBehavior PartUnderMouse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GlobalEscapeMenu EscapeMenu
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIFlightHud FlightHud
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSCMenuManager KSCMenu
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIViewController ViewController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIScaleController ScaleController
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GlobalHeaderManager GlobalHeader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeSystems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnApplicationQuit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadUI(Action onComplete) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadKSCTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionAwayFromMapState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideMapIfVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleEscapeMenu_performed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleUIVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEscapeVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPauseVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowPause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HidePause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleEscapeVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleButtonStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas CreateCanvas(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pool(UIModule module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TModule Get<TModule>() where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas GetRootCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetViewportPositionFromUITransformInOverlayCanvas(Transform t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas GetPopupCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas GetScaledMainCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas GetScaledPopupCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Canvas GetResearchDevelopmentCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject GetOrthographicCollection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugPanelManager GetDebugPanelManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetFullscreenRectTransform(UIModule target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TModule GetOrCreatePopup<TModule>() where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TModule GetOrCreate<TModule>() where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TModule GetOrCreate<TModule>(Canvas targetCanvas) where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TModule GetOrCreateSpecific<TModule>(bool isPopup) where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TModule GetOrCreateSpecific<TModule>(bool isPopup, Canvas targetCanvas) where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TModule Create<TModule>(Transform parent) where TModule : UIModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurtainContext(CurtainContext curtainContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurtainContextData(CurtainContextData curtainContextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurtainContextOrSpectatedContext(CurtainContext curtainContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurtainVisibility(bool isVisible, Action onTransitionFinished = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadingBarVisibility(bool isVisible, Action onTransitionFinished = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLoadingBarAndCurtainVisibility(
      bool isScreenVisible,
      bool isBarVisible,
      Action onTransitionFinished = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurtainContextForLaunchLocation(SerializedLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CurtainContext GetCurtainContextByLocation(SerializedLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadingBarPercentComplete(float percent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadingBarText(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissMessageBox() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissTutorialMessageBox() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissTutorialFullScreenVideo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVersionNumberVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadAndShowMessageBox(
      string title,
      string text,
      Image icon,
      List<ButtonData> buttonData,
      bool modal = true,
      bool cancelButton = false,
      string cancelButtonText = "",
      bool showCloseIcon = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowMessageBox(
      string title,
      string text,
      Image icon,
      List<ButtonData> buttonData,
      bool modal = true,
      bool cancelButton = false,
      string cancelButtonText = "",
      bool showCloseIcon = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowTutorialMessageBox(
      string windowTitle,
      string title,
      string description,
      System.Type eventTypeDismiss,
      TutorialMessageBoxButtonType buttonType,
      string imageName,
      string playerClip,
      string nextMissionID,
      bool isMissionSummary,
      MessageDescriptions messageDescriptions,
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
    public void ShowTutorialFullScreenVideo(
      string scriptablePath,
      System.Type eventTypeOnClose,
      bool showControls = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdateMouseOverLogic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseSecondaryTapPerformed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseDoubleTapPerformed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreatePartOutlinesManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePartOutlinesCameraReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RegisterWindow(KSP2UIWindow newWindow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UnregisterWindow(KSP2UIWindow newWindow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIManager() => throw null;
  }
}
