// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.OverrideMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
