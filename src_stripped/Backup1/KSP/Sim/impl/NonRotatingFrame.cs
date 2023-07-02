// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.NonRotatingFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  [DebuggerDisplay("NonRotatingFrame= {_Value_ForDebuggerOnly}")]
  public class NonRotatingFrame : TransformFrame
  {
    public override TransformFrameType type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonRotatingFrame(ITransformModelInternal transform) => throw null;
  }
}
