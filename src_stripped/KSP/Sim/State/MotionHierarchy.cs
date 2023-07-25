// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.MotionHierarchy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
