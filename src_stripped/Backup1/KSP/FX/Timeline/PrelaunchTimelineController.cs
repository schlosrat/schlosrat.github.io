// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.PrelaunchTimelineController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.Data;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace KSP.FX.Timeline
{
  public class PrelaunchTimelineController : KerbalMonoBehaviour
  {
    [FormerlySerializedAs("timelineAdapterPrefab")]
    public TimelineAdapter prelaunchTimeline;
    public TimelineAdapter launchTimeline;
    private TimelineAdapter _prelaunchTimelineInstance;
    private TimelineAdapter _launchTimelineInstance;
    private VesselPrelaunchData _vesselPrelaunchData;
    private int _currentStage;
    private SubscriptionHandle _handleVesselCreated;
    private SubscriptionHandle _handleVesselInitialized;
    private SubscriptionHandle _handleOnRevertToLaunch;
    private ISimulationObjectView _vesselSimObjectView;
    private VesselBehavior _vesselBehavior;
    public static Action OnPrelaunch;
    public static Action OnLaunch;
    public static Action OnReset;
    public static Action OnStop;
    public static bool AlreadyLaunched;

    public bool IsLocallyAuthorized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrackModelVesselCreation(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselInitialized(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRevertToLaunch(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineGetVesselPrelaunchData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetVesselPrelaunchData(ISimulationObjectView simObjView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopSpawnedFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopSpawnedFX(ref TimelineAdapter curTimeline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SpawnPrelaunchTimeline() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopPrelaunchAudioForLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LaunchIfUnlaunched() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SpawnLaunchTimeline() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup(ref TimelineAdapter curTimeline) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrelaunchTimelineController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PrelaunchTimelineController() => throw null;
  }
}
