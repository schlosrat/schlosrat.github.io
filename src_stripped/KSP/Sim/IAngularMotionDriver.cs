// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IAngularMotionDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace KSP.Sim
{
  public interface IAngularMotionDriver
  {
    AngularVelocity AngularVelocity { get; }

    void UpdateAngularVelocity(AngularVelocity newAngularVelocity);

    event Action<AngularVelocity> AngularVelocityUpdated;
  }
}
