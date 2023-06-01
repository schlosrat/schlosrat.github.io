// Decompiled with JetBrains decompiler
// Type: CameraFXModules.Views
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace CameraFXModules
{
  [Flags]
  public enum Views
  {
    None = 0,
    FlightExternal = 1,
    FlightInternal = 2,
    FlightMap = 4,
    KSC = 8,
    TrackingStation = 16, // 0x00000010
    Editors = 32, // 0x00000020
    All = -1, // 0xFFFFFFFF
  }
}
