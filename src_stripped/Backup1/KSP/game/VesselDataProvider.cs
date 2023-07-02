// Decompiled with JetBrains decompiler
// Type: KSP.Game.VesselDataProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class VesselDataProvider : DataBus<VesselComponent>, IUpdate
  {
    public event Action<IReadOnlyList<(Camera Camera, int SeatIndex)>> UpdatePortraitUI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public PropertyExternal<string> MainBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> Throttle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> Roll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> Pitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> Yaw
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> InputRoll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> InputPitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> InputYaw
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> TranslateX
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> TranslateY
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> TranslateZ
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> LandedOrSplashed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSP.Sim.Position> Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<IReadOnlyList<(Camera Camera, int SeatIndex)>> LiveInternalCameras
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> MissionElapsedTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> Roll_HorizonRelative_Degrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> Pitch_HorizonRelative_Degrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> Yaw_HorizonRelative_Degrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> TrimRoll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> TrimPitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<double> TrimYaw
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<ActionBarDisplayMode> CurrentActionBarDisplayMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> ActionBarVisibleVessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> ActionBarVisibleKerbal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> ActionBarVisibleColony
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> ActionBarVisibleVesselAndColony
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSPActionGroupState> ActionAbort
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSPActionGroupState> ActionBrakes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSPActionGroupState> ActionLights
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSPActionGroupState> ActionGear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSPActionGroupState> ActionSolar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<KSPActionGroupState> ActionRadiator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> CanContainCommandCrew
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<bool> CanShowPortraitUI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<string> PartActivated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDataProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ValidateProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(VesselComponent dataSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLiveCamerasUpdated(IReadOnlyList<(Camera, int)> cameras) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetMainBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetMainThrottle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetRoll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetYaw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetPitch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTranslateX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTranslateY() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTranslateZ() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetInputRoll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetInputYaw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetInputPitch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetIsLandedOrSplashed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSP.Sim.Position GetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IReadOnlyList<(Camera, int)> GetLiveInternalCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCanShowPortraitUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetRoll_HorizonRelative_Degrees() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetYaw_HorizonRelative_Degrees() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetPitch_HorizonRelative_Degrees() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetTrimRoll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetTrimYaw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetTrimPitch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCanContainCommandCrew() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetThrottleInternal(float throttle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSPActionGroupState GetActionGroupState_Abort() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSPActionGroupState GetActionGroupState_Brakes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSPActionGroupState GetActionGroupState_Lights() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSPActionGroupState GetActionGroupState_Gear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSPActionGroupState GetActionGroupState_Solar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KSPActionGroupState GetActionGroupState_Radiator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ActionBarDisplayMode GetCurrentActionBarDisplayMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetActionBarVisibleKerbal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetActionBarVisibleVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetActionBarVisibleColony() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetActionBarVisibleVesselAndColony() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetPartActivated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetMissionElapsedTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup_Abort() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup_Brakes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup_Lights() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup_Gear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup_Solar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup_Radiator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TriggerActionGroup(KSPActionGroup group) => throw null;
  }
}
