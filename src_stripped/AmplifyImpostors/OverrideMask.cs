// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.OverrideMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace AmplifyImpostors
{
  [Flags]
  public enum OverrideMask
  {
    OutputToggle = 1,
    NameSuffix = 2,
    RelativeScale = 4,
    ColorSpace = 8,
    QualityCompression = 16, // 0x00000010
    FileFormat = 32, // 0x00000020
  }
}
