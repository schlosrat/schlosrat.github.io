// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectStatistics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
