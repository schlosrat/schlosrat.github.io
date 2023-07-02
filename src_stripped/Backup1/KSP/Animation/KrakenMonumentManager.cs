// Decompiled with JetBrains decompiler
// Type: KSP.Animation.KrakenMonumentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class KrakenMonumentManager : KerbalMonoBehaviour, ILateUpdate
  {
    [SerializeField]
    private double ViewDistance;
    [Space(10f)]
    [Tooltip("In Degrees Per Second")]
    [SerializeField]
    private float LookSpeed;
    [SerializeField]
    private float EyeRotationOffsetLimit;
    [SerializeField]
    private Transform LeftEye;
    [SerializeField]
    private Transform _LeftEyeDefaultState;
    [SerializeField]
    private Transform RightEye;
    [SerializeField]
    private Transform _RightEyeDefaultState;
    [SerializeField]
    [Space(10f)]
    private int MaxPartCountBeforeShakingStarts;
    [SerializeField]
    private int MaximumShakePartCount;
    [SerializeField]
    private float MaximumShakeAngleAmount;
    [SerializeField]
    [Space(25f)]
    private bool _debugMode;
    [SerializeField]
    private Transform _debugTargetVessel;
    [SerializeField]
    [Range(0.0f, 1000f)]
    private int _debugPartCount;
    private bool _isActive;
    private int _targetVesselPartCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<VesselBehavior> CollectVesselsInRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AimEyesAtTargetOverTime(Transform target, int partCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLimitedEyeRotationOverTime(
      Transform eye,
      float rotLimit,
      Transform target,
      Transform defaultTransformState,
      int partCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetEyePositionsOverTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KrakenMonumentManager() => throw null;
  }
}
