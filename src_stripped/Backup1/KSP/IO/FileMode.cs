// Decompiled with JetBrains decompiler
// Type: KSP.IO.FileMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
