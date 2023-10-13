// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IMotionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
