// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IMotionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim
{
  public interface IMotionModel : IMotionRelative
  {
    ITransformModel transform { get; }

    IMotionFrame bodyMotionFrame { get; }

    IMotionFrame celestialMotionFrame { get; }

    IMotionFrame launchMotionFrame { get; }

    IMotionFrame parentMotionFrame { get; }

    IMotionFrame GetSimObjectParentMotionFrame();

    IMotionFrame GetSimSOIBodyParentMotionFrame();

    Vector relativeVelocity { get; set; }

    Vector relativeAngularVelocity { get; set; }

    Velocity Velocity { get; }

    AngularVelocity AngularVelocity { get; }

    ILinearMotionDriver LinearMotionDriver { get; set; }

    IAngularMotionDriver AngularMotionDriver { get; set; }
  }
}
