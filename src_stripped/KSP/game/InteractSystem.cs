// Decompiled with JetBrains decompiler
// Type: KSP.Game.InteractSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class InteractSystem : SpatialRegistrySystem
  {
    public Vector3 LocalPlayerOffset;
    public float PlayerInteractRange;
    private InteractFlags _playerFlags;
    private InteractBehavior _behavior;
    private Position _interactFromPosition;
    private Vector _positionOffset;
    private int _interactPriority;
    private float _interactDistance;
    private InteractInstance _bestInteractInstance;
    private float _bestInteractDistance;
    private IVehicle _activeVehicle;
    private VesselComponent _activeVessel;
    private KerbalBehavior _activeKerbalBehavior;
    private List<InteractSystem.InteractPresetRegistry> _interactPresetRegistry;
    private Dictionary<InteractAction, InteractInstance> _bestInteracts;

    public Dictionary<InteractAction, InteractInstance> BestInteracts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterInteractPresetUsedCallback(
      SimulationObjectModel interactUser,
      InteractPreset interactPreset,
      Action<InteractBehavior, InteractInstance, InteractPreset> interactOnUsedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterInteractPresetUsedCallback(
      SimulationObjectModel interactUser,
      InteractPreset interactPreset,
      Action<InteractBehavior, InteractInstance, InteractPreset> interactOnUsedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteract(bool pressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractAlt(bool pressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractAlt2(bool pressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformInteract(InteractAction interactAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<InteractAction, InteractInstance> CreateBestInteractsDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteInteractPresetUsedCallbacks(
      SimulationObjectModel interactUser,
      InteractBehavior interactBehavior,
      InteractInstance interactInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildPlayerFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DoesPassPlayerFlags(InteractFlags instanceFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float GetInteractDistance(
      Vector3 playerPosition,
      InteractInstance interactInstance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InteractSystem() => throw null;

    private class InteractPresetRegistry
    {
      public SimulationObjectModel InteractUser;
      public InteractPreset InteractPreset;
      public Action<InteractBehavior, InteractInstance, InteractPreset> OnInteractUsed;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InteractPresetRegistry(
        SimulationObjectModel interactUser,
        InteractPreset interactPreset,
        Action<InteractBehavior, InteractInstance, InteractPreset> onInteractUsed)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool DoesMatch(SimulationObjectModel interactUser, InteractPreset interactPreset) => throw null;
    }
  }
}
