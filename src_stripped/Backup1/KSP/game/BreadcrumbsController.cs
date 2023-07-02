// Decompiled with JetBrains decompiler
// Type: KSP.Game.BreadcrumbsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  [RequireComponent(typeof (CanvasGroup))]
  public class BreadcrumbsController : KerbalMonoBehaviour
  {
    private const string CELESTIALBODY_LOC_PREFIX = "CelestialBody/";
    private const string LAUNCHPAD_BREADCRUMB_LOC_PREFIX = "Menu/KSC/";
    private const string KERBOL_LOC_BREADCRUMBS = "CelestialBody/Kerbol";
    private const string KERBIN_LOC_BREADCRUMBS = "CelestialBody/Kerbin";
    private const string KSC_LOC_BREADCRUMBS = "Menu/KSC/KSC";
    private const string BAE_LOC_BREADCRUMBS = "Menu/KSC/BaseAssemblyEditor";
    private const string VAB_LOC_BREADCRUMBS = "Menu/KSC/VAB";
    private const string RESEARCH_LOC_BREADCRUMBS = "Menu/KSC/ResearchandDevelopment";
    private const string MISSION_CONTROL_LOC_BREADCRUMBS = "Menu/KSC/MissionControl";
    private const string TRAINING_CENTER_LOC_BREADCRUMBS = "Menu/KSC/TrainingCenter";
    private const string SEPARATION_BREADCRUMBS_STRING = " \\";
    [SerializeField]
    private BreadcrumbsIcon[] _breadcrumbsIconsContainer;
    [Header("Prefabs")]
    [SerializeField]
    private ContextBindRoot _breadcrumbsItemPrefab;
    [Header("BindRoot")]
    [SerializeField]
    private ContextBindRoot _uiRoot;
    [SerializeField]
    private ButtonExtended _backButton;
    private BreadcrumbContextData _data;
    private SubscriptionHandle _handleGameStateChanged;
    private SubscriptionHandle _handleLaunchpadChanged;
    private SubscriptionHandle _handleControlSelectedVessel;
    private SubscriptionHandle _handleVesselChangedMessage;
    private SubscriptionHandle _handleTrainingCenterLoaded;
    private SubscriptionHandle _handleTrainingCenterLeft;
    private SubscriptionHandle _handleTrackingStationLoaded;
    private SubscriptionHandle _handleSOIEnteredVesselChanged;
    private SubscriptionHandle _handleBackToKSCMessage;
    private Dictionary<BreadcrumbsType, Sprite> _breadcrumbsIcons;
    private GameState _currentBreadcrumbsGameState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchpadChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTrainingCenterLeft(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTrackingStation(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ControlVessel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselSOIEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBackToKSC(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBreadcrumbs(GameState currentState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlightViewBreadcrumbs(List<BreadcrumbsContextElement> elements) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KSCBuildingBreadcrumbs(
      List<BreadcrumbsContextElement> elements,
      BreadcrumbsContextElement buildingElement)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrackingStationBreadcrumbs(List<BreadcrumbsContextElement> elements) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BackToPreviousState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBreadcrumbsToPreviousState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBackButtonActive(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BreadcrumbsController() => throw null;
  }
}
