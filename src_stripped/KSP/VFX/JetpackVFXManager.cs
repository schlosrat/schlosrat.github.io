// Decompiled with JetBrains decompiler
// Type: KSP.VFX.JetpackVFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [DisallowMultipleComponent]
  public class JetpackVFXManager : KerbalMonoBehaviour
  {
    private const float FRONT_DOT_PRODUCT_THRESHOLD = 0.5f;
    [Tooltip("Collection of Move X, Y, Z effects. Here, the Local +Y-axis Direction (per RCS effect convention) represents a Nozzle Direction, but along the -ve/+ve Cardinal Axes, not angled. This Direction is always -opposite- to the Force Direction!")]
    public List<JetpackVFXManager.EffectObject> MoveEffectObjects;
    [Tooltip("Collection of Rotate Yaw, Pitch, Roll effects. Here, the Local +Y-axis Direction (per RCS effect convention) represents a Torque Axis, along the -ve/+ve Cardinal Axes, not angled. E.g., Positive Yaw is represented by Local +Y-axis pointing upwards. Positive Pitch is represented by Local +Y-axis pointing right.")]
    public List<JetpackVFXManager.EffectObject> RotateEffectObjects;
    public bool DebugMode;
    private PartBehavior _partBehavior;
    private VesselComponent _vesselComponent;
    private AtmosphereTransitionVFXHandling _atmoTransVFXHandler;
    private bool _isInitialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(PartBehavior partBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMoveVector(Vector3 moveWorldSpace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRotateVector(Vector3 rotateWorldSpace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitAtmosphereTransitionVFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEffects(List<JetpackVFXManager.EffectObject> effectObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void FindEffectEngineObjects(List<JetpackVFXManager.EffectObject> effectObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void InitEffectEngineObjects(List<JetpackVFXManager.EffectObject> effectObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetEffectVisible(
      bool isVisible,
      JetpackVFXManager.EffectObject vfxObject,
      bool force = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JetpackVFXManager() => throw null;

    [Serializable]
    public class EffectObject
    {
      [HideInInspector]
      public string Name;
      [Tooltip("Local +Y-axis (per RCS effect convention) is used for Move Direction or Rotate Direction vector which will be compared against player input vectors. Typically, this should be along the -ve/+ve Cardinal Axes, not angled.")]
      public Transform Direction;
      [Tooltip("Local +Y-axis (per RCS effect convention) is used for Thruster Effect containing one or more IEngineFXData as children. This may be angled to match the Thruster socket visuals, giving the artist complete freedom to disconnect Player Input Direction from Visual Direction, essentially.")]
      public Transform Visual;
      [NonSerialized]
      public List<IEngineFXData> EngineObjects;
      [NonSerialized]
      public float Magnitude;
      [NonSerialized]
      public bool IsVisible;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EffectObject() => throw null;
    }
  }
}
