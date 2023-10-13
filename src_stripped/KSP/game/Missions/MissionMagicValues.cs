// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionMagicValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
