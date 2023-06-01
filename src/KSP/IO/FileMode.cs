// Decompiled with JetBrains decompiler
// Type: KSP.IO.FileMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
