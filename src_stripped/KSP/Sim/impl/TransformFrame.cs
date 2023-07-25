// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.TransformFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public abstract class TransformFrame : ITransformFrameInternal, ITransformFrame, ICoordinateSystem
  {
    protected Matrix4x4D _localMatrix;
    protected Matrix4x4D _localMatrixInverse;
    protected bool _isLocalMatrixDirty;
    private ICoordinateSystem _mostRecentCoordinateSystemRequest;
    private Matrix4x4D _mostRecentInverseMatrix;
    private Vector _forward;
    private Vector _back;
    private Vector _up;
    private Vector _down;
    private Vector _right;
    private Vector _left;

    public abstract TransformFrameType type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformModel transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformModelInternal _transformInternal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotionFrame motionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsLocalMatrixDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector forward
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector back
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector down
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector left
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TransformFrame(ITransformModelInternal transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AttachMotionFrame(IMotionFrame motionFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddChild(ITransformModel youngChild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveChild(ITransformModel oldChild) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD ToLocalRotation(Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD ToLocalRotation(
      ICoordinateSystem coordinateSystem,
      QuaternionD coordinateSystemRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Matrix4x4D ToLocalTransformationMatrix(ICoordinateSystem coordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalPosition(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalPosition(
      ICoordinateSystem coordinateSystem,
      Vector3d coordinateSystemPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVector(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVector(
      ICoordinateSystem coordinateSystem,
      Vector3d coordinateSystemVector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ITransformFrameInternal FindCommonParent(ITransformFrameInternal otherFrameInternal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matrix4x4D ComputeTransformFromOther(ITransformFrame other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GetConcatenatedLocalInverseMatrix(
      ref Matrix4x4D totalInverseMatrix,
      ITransformFrameInternal current,
      ITransformFrameInternal other)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GetConcatenatedLocalMatrix(
      ref Matrix4x4D totalLocalMatrix,
      ITransformFrameInternal current,
      ITransformFrameInternal other)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsHierarchyDirty(
      ITransformFrameInternal current,
      ITransformFrameInternal other)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuaternionD ComputeRotationFromOther(ITransformFrame other) => throw null;

    public ref Matrix4x4D localMatrix
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ref Matrix4x4D localMatrixInverse
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecalculateLocalMatricies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLocalMatrixDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITransformFrame GetNonInternalCoordinateSystem(ICoordinateSystem coordinateSystem) => throw null;
  }
}
