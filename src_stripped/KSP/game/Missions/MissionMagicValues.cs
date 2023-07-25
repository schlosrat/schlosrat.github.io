// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionMagicValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
