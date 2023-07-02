// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.BodyMotionFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  [DebuggerDisplay("BodyMotionFrame= {_Value_ForDebuggerOnly}")]
  public class BodyMotionFrame : MotionFrame
  {
    public override Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BodyMotionFrame(IMotionModel motion, ITransformFrame frame) => throw null;
  }
}
