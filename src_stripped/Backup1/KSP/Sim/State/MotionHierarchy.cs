// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.MotionHierarchy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct MotionHierarchy
  {
    public string motionGuid;
    public TransformFrameType motionFrameType;
    public Vector3d relativeVelocity;
    public Vector3d relativeAngularVelocity;
    public List<MotionHierarchy> children;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MotionHierarchy FromMotion(IMotionModel motionModel) => throw null;
  }
}
