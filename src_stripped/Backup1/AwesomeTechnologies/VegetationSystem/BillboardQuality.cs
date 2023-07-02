// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.BillboardQuality
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public enum BillboardQuality
  {
    Normal = 0,
    High = 1,
    Max = 2,
    Normal3D = 4,
    High3D = 5,
    Max3D = 6,
    HighSample3D = 7,
    HighSample2D = 8,
    NormalSingle = 9,
    HighSingle = 10, // 0x0000000A
    MaxSingle = 11, // 0x0000000B
    NormalQuad = 12, // 0x0000000C
    HighQuad = 13, // 0x0000000D
    MaxQuad = 14, // 0x0000000E
  }
}
