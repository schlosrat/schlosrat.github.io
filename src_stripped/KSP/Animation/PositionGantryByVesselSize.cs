// Decompiled with JetBrains decompiler
// Type: KSP.Animation.PositionGantryByVesselSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class PositionGantryByVesselSize : KerbalMonoBehaviour
  {
    private const string GANTRY_FRONT_NODE_NAME = "gantry_front_node";
    public static bool RevertedToLaunch;
    [Tooltip("Used for multiplayer sessions to roll the gantry to its new launch position. False for single player because the player launching wouldn't get to see the roll anyway.")]
    public bool RepositionGantryOverTime;
    public bool RepositionGantryOnEnable;
    [Space(10f)]
    public GameObject GantrySinglePlayer;
    public GameObject GantryMultiplayer;
    public Transform VesselLaunchTransform;
    public Transform GantryTransformMin;
    public Transform GantryTransformMax;
    private float _curVesselExtent;
    private float _distMinMaxPos;
    private Transform _gantryFrontNode;
    private Transform _gantry;
    private VesselBehavior _targetVesselBehavior;
    private SubscriptionHandle _vesselCreatedHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator InitAndUpdateCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeAndUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetBoundingBoxExtentThatFacesGantry(VesselBehavior vesselBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetSignedOffsetBetweenVesselLocalAndBBFacingGantry(VesselBehavior vesselBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleRevertToLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselBehaviourInit(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGantryPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionGantryByVesselSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PositionGantryByVesselSize() => throw null;
  }
}
