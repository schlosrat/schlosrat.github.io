// Decompiled with JetBrains decompiler
// Type: KSP.Animation.PositionGantryByVesselSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private const string DEFAULT_COLLIDER_LAYER = "Local.Scenery";
    private const string PHYSX_IGNORE_COLLIDER_LAYER = "Physx.Invisible";
    [Tooltip("Used for multiplayer sessions to roll the gantry to its new launch position. False for single player because the player launching wouldn't get to see the roll anyway.")]
    public bool RepositionGantryOverTime;
    private bool _gantryRepositioned;
    [Space(10f)]
    public GameObject GantrySinglePlayer;
    public GameObject GantrySinglePlayerCollider;
    public GameObject GantryMultiplayer;
    public Transform VesselLaunchTransform;
    public Transform GantryTransformMin;
    public Transform GantryTransformMax;
    private float _curVesselExtent;
    private float _distMinMaxPos;
    private Transform _gantryFrontNode;
    private Transform _gantry;
    private VesselBehavior _targetVesselBehavior;
    private VesselComponent _initVesselComponent;
    private SubscriptionHandle _vesselCreatedHandle;
    private SubscriptionHandle _vesselChangedHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

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
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBasedOnLastSerializedAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselBehaviourInit(MessageCenterMessage curMCM) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGantryPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCollidersLayer(bool defaultLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionGantryByVesselSize() => throw null;
  }
}
