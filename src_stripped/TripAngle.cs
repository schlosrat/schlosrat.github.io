// Decompiled with JetBrains decompiler
// Type: TripAngle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;

[Serializable]
public struct TripAngle
{
  public CelestialBodyComponent StartBody;
  public CelestialBodyComponent EndBody;
  public double PhaseAngle;
  public double EjectionAngle;
}
