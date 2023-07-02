// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRotationArcFillFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace RTG
{
  [Flags]
  public enum GizmoRotationArcFillFlags
  {
    None = 0,
    Area = 1,
    ExtremitiesBorder = 2,
    ArcBorder = 4,
    All = ArcBorder | ExtremitiesBorder | Area, // 0x00000007
  }
}
