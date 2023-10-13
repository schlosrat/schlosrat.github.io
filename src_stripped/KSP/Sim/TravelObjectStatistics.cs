// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectStatistics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace KSP.Sim
{
  [Serializable]
  public struct TravelObjectStatistics
  {
    public double DistanceTravelled;
    public double GroundDistanceTravelled;
    public double MaxAltitude;
    public double MaxGeeForce;
    public double MaxSpeed;
    public double MaxSpeedOverGround;
    public double MaxGroundSpeed;
  }
}
