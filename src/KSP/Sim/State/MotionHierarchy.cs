// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.MotionHierarchy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
