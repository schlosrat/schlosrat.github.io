// Decompiled with JetBrains decompiler
// Type: PQSTestCameraScaledSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PQSTestCameraScaledSpaceProvider : IScaledSpaceProvider, IScaledSpaceFrame
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSTestCameraScaledSpaceProvider(ITransformFrame referenceFrame) => throw null;

  public Transform transform
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public IUniverseView UniverseView
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public ITransformFrame ReferenceFrame
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public double ScaleFactor
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
  public void PositionsToScaled(
    ICoordinateSystem frame,
    Vector3d[] localPosition,
    List<Vector3> scenePoints)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d PositionToScaled(Position position) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d PositionToScaled(ICoordinateSystem referenceFrame, Vector3d localPosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD RotationToScaled(Rotation rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD RotationToScaled(ICoordinateSystem referenceFrame, QuaternionD localRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Position ScaledToPosition(Vector3d scaledSpacePosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d ScaledToPosition(Vector3d scaledSpacePosition, ICoordinateSystem outputFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ScaledToPositions(
    Vector3d[] scenePositions,
    ICoordinateSystem frame,
    List<Vector3> framePoints)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Rotation ScaledToRotation(QuaternionD scaledSpaceRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD ScaledToRotation(QuaternionD sceneRotation, ICoordinateSystem outputFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector ScaledToVector(Vector3d sceneVector) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d ScaledToVector(Vector3d sceneVector, ICoordinateSystem referenceFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d VectorToScaled(Vector vector) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d VectorToScaled(ICoordinateSystem referenceFrame, Vector3d localVector) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetReferenceFrame(ITransformFrame referenceFrame) => throw null;
}
