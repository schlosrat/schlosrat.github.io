// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_CrewedInterior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  public class Module_CrewedInterior : PartBehaviourModule
  {
    [SerializeField]
    [FormerlySerializedAs("data")]
    protected Data_CrewedInterior dataCrewedInterior;
    private List<(Camera, int)> _portraitCameras;
    private GameObject _interiorInstance;
    private Kerbal3DModel[] _crew;
    private KerbalRosterManager _rosterManager;
    private IGGuid _partId;
    private bool _firstCameraLoadComplete;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private event Action<List<(Camera, int)>> _onOccupancyChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool IsProbe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalDied(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalLocationChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadInteriorPrefabForOAB(string prefabName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadInteriorPrefab(string prefabName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayedPortraitCameraInitialization() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendCamerasToVessel(List<(Camera, int)> cameras) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNewVessel(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_CrewedInterior() => throw null;
  }
}
