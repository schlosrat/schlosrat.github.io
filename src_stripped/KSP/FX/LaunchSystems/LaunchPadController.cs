// Decompiled with JetBrains decompiler
// Type: KSP.FX.LaunchSystems.LaunchPadController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.FX.Timeline;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.FX.LaunchSystems
{
  [RequireComponent(typeof (SequenceControllerComponent))]
  public class LaunchPadController : KerbalMonoBehaviour
  {
    private static Dictionary<OABProvider.LaunchLocation, LaunchPadController> RegisteredLaunchLocations;
    [HideInInspector]
    public LaunchPadController.LaunchSequenceState LaunchStatus;
    public OABProvider.LaunchLocation LaunchPadLocation;
    public VesselComponent spawnedVessel;
    private SequenceControllerComponent sequenceController;
    private SubscriptionHandle prelaunchMessageSubscription;
    private SubscriptionHandle launchMessageSubscription;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RegisterLaunchLocation(
      OABProvider.LaunchLocation location,
      LaunchPadController controller)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UnregisterLaunchLocation(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static LaunchPadController GetLaunchControllerForLocation(
      OABProvider.LaunchLocation location)
    {
      throw null;
    }

    private int LocationToInstanceIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselComponent GetVesselOnLaunchpad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator RegisterMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiatePrelaunch(VesselComponent vessel = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitiateLaunch(bool ignorePrelaunch = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDoneStaging() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrelaunchSequenceInitiated(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchSequenceInitiated(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClipEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchPadController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LaunchPadController() => throw null;

    public enum LaunchSequenceState : byte
    {
      Invalid,
      NotStarted,
      InPrelaunch,
      InPostLaunch,
      Complete,
    }
  }
}
