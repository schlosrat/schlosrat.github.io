// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ScaledSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ScaledSpaceProvider : MonoBehaviour, IScaledSpaceProvider, IScaledSpaceFrame
  {
    public const double DEFAULT_SCALE_FACTOR = 6000.0;
    [SerializeField]
    private double scaleFactor;

    public ITransformFrame ReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReferenceFrame(ITransformFrame referenceFrame) => throw null;

    public IUniverseView UniverseView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double SceneToUniverseScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double UniverseToSceneScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position ScaledToPosition(Vector3d scenePoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ScaledToPosition(Vector3d scenePoint, ICoordinateSystem outputFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d PositionToScaled(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d PositionToScaled(ICoordinateSystem referenceFrame, Vector3d localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PositionsToScaled(
      ICoordinateSystem referenceFrame,
      Vector3d[] localPositions,
      List<Vector3> scenePoints)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ScaledToPositions(
      Vector3d[] scenePoints,
      ICoordinateSystem referenceFrame,
      List<Vector3> localPositions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation ScaledToRotation(QuaternionD sceneRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD ScaledToRotation(QuaternionD sceneRotation, ICoordinateSystem outputFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD RotationToScaled(Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD RotationToScaled(ICoordinateSystem referenceFrame, QuaternionD localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector ScaledToVector(Vector3d sceneVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ScaledToVector(Vector3d sceneVector, ICoordinateSystem referenceFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d VectorToScaled(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d VectorToScaled(ICoordinateSystem referenceFrame, Vector3d localVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaledSpaceProvider() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Transform IScaledSpaceProvider.get_transform() => throw null;
  }
}
