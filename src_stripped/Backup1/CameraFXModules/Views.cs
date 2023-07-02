// Decompiled with JetBrains decompiler
// Type: CameraFXModules.Views
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
