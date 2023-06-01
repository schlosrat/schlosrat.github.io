// Decompiled with JetBrains decompiler
// Type: SubdivisionHeuristic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

[Flags]
public enum SubdivisionHeuristic
{
  TriangleArea = 2,
  ScreenSizeRatio = 4,
  SquaredPerimeter = 8,
  Default = SquaredPerimeter | ScreenSizeRatio | TriangleArea, // 0x0000000E
}
