// Decompiled with JetBrains decompiler
// Type: KSP.UI.HighlightType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.UI
{
  [Flags]
  public enum HighlightType
  {
    PART = 1,
    ATTACHNODE = 2,
    SPOT = 4,
    NAVBALL = 8,
    MANEUVERGIZMO = 16, // 0x00000010
    ORBITNODE = 32, // 0x00000020
  }
}
