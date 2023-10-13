// Decompiled with JetBrains decompiler
// Type: KSP.Game.InteractFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace KSP.Game
{
  [Flags]
  public enum InteractFlags
  {
    OnFoot = 1,
    Swim = 2,
    Vessel = 4,
    Ladder = 8,
    Jetpack = 16, // 0x00000010
  }
}
