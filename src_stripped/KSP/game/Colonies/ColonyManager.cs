// Decompiled with JetBrains decompiler
// Type: KSP.Game.Colonies.ColonyManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.ScriptInterop;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Colonies
{
  public class ColonyManager : IUpdate
  {
    public const string DIALOG_PREFAB = "ColonyManagerDialog.prefab";
    private List<ActiveFlight> _activeFlights;
    private List<DeliveryRoute> _deliveryRoutes;
    private int _currentFlightID;
    private int _currentRouteID;
    private SubscriptionHandle _onVesselDockedHandle;
    private SubscriptionHandle _onVesselCreatedHandle;
    private SubscriptionHandle _onVesselUndockedHandle;
    private SubscriptionHandle _onVesselRecoveredHandle;
    private SubscriptionHandle _onVesselDestroyedHandle;
    private SubscriptionHandle _onRevertToLaunchHandle;
    private SubscriptionHandle _onRevertToVABHandle;
    private SubscriptionHandle _onColonyDeployedHandle;
    private SubscriptionHandle _onColonyEstablishedHandle;
    private SubscriptionHandle _onColonyDialogToggleHandle;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<ActiveFlight> ActiveFlights
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<DeliveryRoute> DeliveryRoutes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load(SerializedColonyData colonyDataFromSave) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(SerializedColonyData newSaveData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float elapsedTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveFlight GetFlightFromGUID(IGGuid vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveFlightByGUID(IGGuid vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDocked(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselUndocked(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRecovered(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRevertToLaunch(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRevertToVAB(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnColonyEstablished(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnColonyDeployed(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnColonyDialogToggle(MessageCenterMessage mess) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConvertFlightToDeliveryRoute(ActiveFlight flight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NotifyDataUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void script_ToggleColonyDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void script_LaunchTestGroundBAE() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void script_LaunchGroundColonyVariant1() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void script_LaunchGroundColonyVariant2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void script_LaunchGroundColonyVariant3() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyManager() => throw null;
  }
}
