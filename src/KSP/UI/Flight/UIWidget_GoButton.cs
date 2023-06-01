// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIWidget_GoButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class UIWidget_GoButton : UIDependendsOn<StagingDataProvider>
  {
    [SerializeField]
    private Button GoButton;
    [SerializeField]
    private TMP_Text GoButtonText;
    [SerializeField]
    private TMP_Text StageNumberDisplay;
    [SerializeField]
    private TMP_Text TotalDVDisplay;
    private static string flightHUD_GO;
    private static string flightHUD_NoStages;
    private static string flightHUD_SkipCountdown;
    private SubscriptionHandle _handleOnVesselChanged;
    private SubscriptionHandle _handleOnPreLaunchSequenceStart;
    private SubscriptionHandle _handleOnLaunchSequenceInitiated;
    private bool _onVesselChangedSubscribed;

    protected override StagingDataProvider Dependency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Frontend_OnGoClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetBackendCallbacks(StagingDataProvider backend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ClearBackendCallbacks(StagingDataProvider backend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreLaunchSequenceStart(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchSequenceInitiated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWidget(IVehicle vehicle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Backend_StageCountChanged(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Backend_HasReadyStageChanged(bool hasReadyStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Backend_TotalDVChanged(double totalDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateButtonState(bool hasReadyStage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageNumberDisplay(int stageCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTotalDV(double totalDV) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_GoButton() => throw null;
  }
}
