// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.MotionFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public abstract class MotionFrame : IMotionFrame, IMotion, IMotionRelative
  {
    private ITransformFrameInternal _localFrameInternal;
    private Stack<ITransformFrame> _toWalkAngularVelocity;
    private Stack<ITransformFrame> _toWalkVelocity;

    public TransformFrameType type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformFrame localFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IMotionModel motion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [DebuggerDisplay("IVector = {vector.x},{vector.y},{vector.z}")]
    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [DebuggerDisplay("Velocity = {relativeVelocity.vector.x},{relativeVelocity.vector.y},{relativeVelocity.vector.z}")]
    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [DebuggerDisplay("IAngularVelocity = {relativeAngularVelocity.vector.x},{relativeAngularVelocity.vector.y},{relativeAngularVelocity.vector.z}")]
    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool EnableLocalFrameCache
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionFrame(IMotionModel motion, ITransformFrame transformFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IRigidbodyDriver atRestDriver(Position position, Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector ToRelativeVelocity(Velocity velocity, Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector ToRelativeAngularVelocity(AngularVelocity angularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d ToLocalVelocityFast(
      IMotion velocityRelativeToMotion,
      Vector velocityVector,
      Position position)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d ToLocalAngularVelocityFast(IMotion relativeMotion, Vector inputAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVelocity(Velocity otherVelocity, Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalAngularVelocity(AngularVelocity otherAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVelocity(IMotion relativeTo, Vector3d localVelocity, Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalAngularVelocity(IMotion relativeTo, Vector3d localAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IMotionFrame GetNonInternalMotionFrame(IMotion frame) => throw null;
  }
}
