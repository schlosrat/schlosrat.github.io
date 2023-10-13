// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ClearToSaveStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
