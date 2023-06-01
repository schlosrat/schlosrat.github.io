// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.NonRotatingFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
