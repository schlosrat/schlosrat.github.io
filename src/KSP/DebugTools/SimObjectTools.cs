// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.SimObjectTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class SimObjectTools : KerbalMonoBehaviour
  {
    private const string SIM_OBJECT_TOOLS_WINDOW_ADDRESSABLE_NAME = "SimObjectWindow.prefab";
    [SerializeField]
    private SimObjectItem _simObjectItemPrefab;
    [SerializeField]
    private Transform _simObjectListParent;
    [SerializeField]
    private Toggle _toggleProximityLoadUnload;
    [SerializeField]
    private Toggle _toggleCelestialBodyCollisionApproximation;
    [SerializeField]
    private Toggle _toggleShowPhysicsOwners;
    [SerializeField]
    private Toggle _toggleShowCelestialBodies;
    private static GameObject s_instance;
    private GameObjectPool<SimObjectItem> _simObjectItemPool;
    private bool _forceRefresh;
    private bool _showPhysicsOwners;
    private bool _showCelestialBodies;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidSimObject(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnItemReset(SimObjectItem simObjectItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimulationObjectCountChanged(SimulationObjectModel obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleProximityLoadUnloadValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleCelestialBodyCollisionApproximationValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleShowPhysicsOwnersValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleShowCelestialBodiesValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimObjectTools() => throw null;
  }
}
