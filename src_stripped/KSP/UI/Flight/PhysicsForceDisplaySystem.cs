// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.PhysicsForceDisplaySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class PhysicsForceDisplaySystem : KerbalMonoBehaviour, ILateUpdate
  {
    public static readonly System.Type MODULE_DRAG_DRAG_TYPE;
    public static readonly System.Type MODULE_DRAG_BODY_LIFT_TYPE;
    public static readonly System.Type MODULE_LIFTINGSURFACE_DRAG_TYPE;
    public static readonly System.Type MODULE_LIFTINGSURFACE_LIFT_TYPE;
    public static readonly System.Type MODULE_ENGINE_ENGINE_FORCE;
    public static readonly Dictionary<System.Type, Color> ColorLookupTable;
    public static readonly HashSet<System.Type> AeroForceTypes;
    private VesselComponent _activeVessel;
    private PartOwnerComponent _activeVesselPartOwner;
    private readonly List<PhysicsForceDisplayVector> _displayForces;
    private GameObject _forceContainer;
    private bool _isInitialized;
    private bool _isDirty;
    private bool _isDisplayed;
    private bool _showModuleDrag;
    private bool _showModuleLiftingSurface;
    private bool _showModuleEngine;
    private SubscriptionHandle _gameStateChangedHandle;
    private SubscriptionHandle _vesselChangedHandle;
    private SubscriptionHandle _vesselDestroyedHandle;
    private SubscriptionHandle _partDestroyedHandle;

    public bool IsDisplayed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAllForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetAllForces(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsForceDisplayable(IForce force, PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateDisplayForces(int number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetArrowDisplay(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TogglePhysicsForceDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValidGameState(GameState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PhysicsForceDisplaySystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PhysicsForceDisplaySystem() => throw null;
  }
}
