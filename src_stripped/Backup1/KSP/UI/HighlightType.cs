// Decompiled with JetBrains decompiler
// Type: KSP.UI.HighlightType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
