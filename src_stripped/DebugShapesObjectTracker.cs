// Decompiled with JetBrains decompiler
// Type: DebugShapesObjectTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugShapesObjectTracker : MonoBehaviour
{
  public ITransformModel ModelTransform;
  public SimulationObjectModel ObjectModel;
  public Quaternion RotationOffset;
  public Vector3 PositionOffset;
  public bool IsTracking;
  private GameInstance _game;
  private ViewController _view;
  private UniverseView _universe;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Setup(SimulationObjectModel o, string transformSuffix, bool startTracking = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateTransform(bool overrideIsTracking = false) => throw null;

  public event Action<ITransformModel, SimulationObjectModel> OnUpdate
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugShapesObjectTracker() => throw null;
}
