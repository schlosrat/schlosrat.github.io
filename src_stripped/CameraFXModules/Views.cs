// Decompiled with JetBrains decompiler
// Type: CameraFXModules.Views
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
