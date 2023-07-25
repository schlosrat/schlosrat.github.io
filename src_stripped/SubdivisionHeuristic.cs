// Decompiled with JetBrains decompiler
// Type: SubdivisionHeuristic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

[Flags]
public enum SubdivisionHeuristic
{
  TriangleArea = 2,
  ScreenSizeRatio = 4,
  SquaredPerimeter = 8,
  Default = SquaredPerimeter | ScreenSizeRatio | TriangleArea, // 0x0000000E
}
