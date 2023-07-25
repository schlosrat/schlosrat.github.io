// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.IMotionModelInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
