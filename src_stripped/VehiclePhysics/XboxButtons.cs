// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.XboxButtons
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace VehiclePhysics
{
  [Flags]
  public enum XboxButtons
  {
    NONE = 0,
    DPAD_UP = 1,
    DPAD_DOWN = 2,
    DPAD_LEFT = 4,
    DPAD_RIGHT = 8,
    START = 16, // 0x00000010
    BACK = 32, // 0x00000020
    LEFT_THUMB = 64, // 0x00000040
    RIGHT_THUMB = 128, // 0x00000080
    LEFT_SHOULDER = 256, // 0x00000100
    RIGHT_SHOULDER = 512, // 0x00000200
    A = 4096, // 0x00001000
    B = 8192, // 0x00002000
    X = 16384, // 0x00004000
    Y = 32768, // 0x00008000
  }
}
