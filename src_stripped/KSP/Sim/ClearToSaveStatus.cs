// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ClearToSaveStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim
{
  public enum ClearToSaveStatus
  {
    CLEAR,
    NOT_IN_ATMOSPHERE,
    NOT_UNDER_ACCELERATION,
    NOT_WHILE_MOVING_OVER_SURFACE,
    NOT_WHILE_ABOUT_TO_CRASH,
    NOT_WHILE_ON_A_LADDER,
    NOT_WHILE_THROTTLED_UP,
    ORBIT_EVENT_IMMINENT,
  }
}
