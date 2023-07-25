// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.MotionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  [DebuggerDisplay("MotionModel= {_Value_ForDebuggerOnly}")]
  public class MotionModel : IMotionModelInternal, IMotionModel, IMotionRelative
  {
    private ILinearMotionDriver linearMotionDriver;
    private IAngularMotionDriver angularMotionDriver;

    public ITransformModel transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotionFrame bodyMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotionFrame celestialMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotionFrame launchMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotionFrame parentMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IMotionFrame GetSimObjectParentMotionFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IMotionFrame GetSimSOIBodyParentMotionFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeRelativeTo(
      IMotionFrame newParent,
      Position withPosition,
      Velocity withVelocity,
      AngularVelocity withAngularVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVelocity(Velocity newVelocity) => throw null;

    [DebuggerDisplay("Velocity = {relativeVelocity.vector.x},{relativeVelocity.vector.y},{relativeVelocity.vector.z}")]
    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAngularVelocity(AngularVelocity angularVelocity) => throw null;

    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ILinearMotionDriver LinearMotionDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void driver_onVelocityUpdated(Velocity newVelocity) => throw null;

    public IAngularMotionDriver AngularMotionDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void driver_onAngularVelocityUpdated(AngularVelocity angularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionModel(ITransformModel transform) => throw null;
  }
}
