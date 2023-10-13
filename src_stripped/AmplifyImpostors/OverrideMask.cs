// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.OverrideMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
