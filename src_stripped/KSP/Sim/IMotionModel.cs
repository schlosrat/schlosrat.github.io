// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IMotionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
