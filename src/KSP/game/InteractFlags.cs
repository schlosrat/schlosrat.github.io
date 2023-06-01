// Decompiled with JetBrains decompiler
// Type: KSP.Game.InteractFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
