// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRotationArcFillFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
