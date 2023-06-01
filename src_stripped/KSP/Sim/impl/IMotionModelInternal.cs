// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.IMotionModelInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim.impl
{
  public interface IMotionModelInternal : IMotionModel, IMotionRelative
  {
    void MakeRelativeTo(
      IMotionFrame newParent,
      Position position,
      Velocity velocity,
      AngularVelocity angularVelocity);

    void SetVelocity(Velocity velocity);

    void SetAngularVelocity(AngularVelocity angularVelocity);
  }
}
