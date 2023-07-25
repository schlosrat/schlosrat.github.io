// Decompiled with JetBrains decompiler
// Type: KSP.IO.FileMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.IO
{
  [Flags]
  public enum FileMode
  {
    CreateNew = 1,
    Create = 2,
    Open = Create | CreateNew, // 0x00000003
    OpenOrCreate = 4,
    Truncate = OpenOrCreate | CreateNew, // 0x00000005
    Append = OpenOrCreate | Create, // 0x00000006
  }
}
