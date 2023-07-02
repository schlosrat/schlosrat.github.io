// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectStatistics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
