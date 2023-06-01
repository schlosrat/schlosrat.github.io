// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.OverrideMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
