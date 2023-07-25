// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Logging;
using KSP.Messages;
using KSP.OAB;
using KSP.UI.Binding;
using KSP.UserInterface;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  [PrefabName("KSCMenu.prefab")]
  public class KSCMenuManager : UIModule
  {
    private const string PREFIX = "[GlobalEscapeMenu] ";
    private const LogFilter LOGTAG = (LogFilter) 2097152;
    private const string KSC_MENU_PREFIX = "Menu/KSC/";
    private const string DEFAULT_COLONY_NAME = "Menu/KSC/KSC";
    private const string KSC_SELECTABLE_BUILDINGS_TAG = "KSCSelectableBuilding";
    private const string RUNWAY_1 = "Runway_1";
    private const string RUNWAY_2 = "Runway_2";
    private const string LAUNCHPAD_1 = "Launchpad_1";
    private const string LAUNCHPAD_2 = "Launchpad_2";
    private const string LAUNCHPAD_3 = "Launchpad_3";
    private const string LAUNCHPAD_4 = "Launchpad_4";
    private const string BOAT_LAUNCH = "Boat_Launch";
    [SerializeField]
    private ContextBindRoot _landingPanelBindRoot;
    [SerializeField]
    private ToggleFlyout _launchpadToggle;
    private List<KSCButton> _kscButtons;
    private DataContext _dataContext;
    private Property<string> _agencyName;
    private Property<string> _colonyName;
    private SubscriptionHandle _handleGameStateChanged;

    private Property<Sprite> _agencyFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameObject[] KSCSelectableBuildings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLandingViewHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToLauchpad(string launchLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToLaunchLocation(string launchSiteName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToRDCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToVehicleAssemblyBuilding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UserOAB(OABVariant variant, OABEnvironmentType environmentType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QuitTutorial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterKSCButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RetrieveSelectableBuildings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AttachKSCSelectableBuilding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCButton HandleOutlinedBuilding(
      KSCTargetableBuilding targetBuilding,
      PointerEventData eventData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCButton FindCorrespondingButton(
      KSCTargetableBuilding targetBuilding,
      bool ignoreHiddenButtons)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayAudioButtonClick(KSCNavEnum targetBuilding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBuildingClick(KSCNavEnum targetBuilding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCMenuManager() => throw null;
  }
}
