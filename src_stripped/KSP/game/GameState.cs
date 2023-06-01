// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Game
{
  public enum GameState : byte
  {
    Invalid = 0,
    WarmUpLoading = 1,
    MainMenu = 2,
    KerbalSpaceCenter = 3,
    VehicleAssemblyBuilder = 10, // 0x0A
    BaseAssemblyEditor = 11, // 0x0B
    FlightView = 20, // 0x14
    ColonyView = 21, // 0x15
    Map3DView = 22, // 0x16
    PhotoMode = 30, // 0x1E
    MetricsMode = 31, // 0x1F
    PlanetViewer = 32, // 0x20
    Loading = 33, // 0x21
    TrainingCenter = 40, // 0x28
    MissionControl = 41, // 0x29
    TrackingStation = 42, // 0x2A
    ResearchAndDevelopment = 43, // 0x2B
    Launchpad = 44, // 0x2C
    Runway = 45, // 0x2D
    Flag = 46, // 0x2E
  }
}
