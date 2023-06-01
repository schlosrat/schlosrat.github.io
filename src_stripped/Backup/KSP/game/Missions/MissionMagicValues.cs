// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionMagicValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Map;
using KSP.Sim.impl;

namespace KSP.Game.Missions
{
  public static class MissionMagicValues
  {
    public static CelestialBodyComponent DestinationCelestialBody;
    public static MapManeuverGizmo MapManueverGizmo;
    public static Vector3d DestinationCoordinates;
    public const double AlignmentThreshold = 0.9994;
    public static bool CheckOrbitClick;
  }
}
