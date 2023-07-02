// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CelestialMotionFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  [DebuggerDisplay("CelestialMotionFrame= {_Value_ForDebuggerOnly}")]
  public class CelestialMotionFrame : MotionFrame
  {
    public override Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialMotionFrame(IMotionModel motion, ITransformFrame frame) => throw null;

    private Vector3d vector
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
