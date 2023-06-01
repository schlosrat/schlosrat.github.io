// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ITransformFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim
{
  public interface ITransformFrame : ICoordinateSystem
  {
    TransformFrameType type { get; }

    ITransformModel transform { get; }

    IMotionFrame motionFrame { get; }
  }
}
