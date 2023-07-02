// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ILinearMotionDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Sim
{
  public interface ILinearMotionDriver
  {
    Velocity Velocity { get; }

    void UpdateVelocity(Velocity newVelocity);

    event Action<Velocity> VelocityUpdated;
  }
}
