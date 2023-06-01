// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.EdgeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Rendering.Planets
{
  [Flags]
  public enum EdgeState
  {
    Reset = -1, // 0xFFFFFFFF
    NoLerps = 0,
    NorthLerp = 1,
    SouthLerp = 2,
    EastLerp = 4,
    WestLerp = 8,
  }
}
