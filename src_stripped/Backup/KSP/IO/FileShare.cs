// Decompiled with JetBrains decompiler
// Type: KSP.IO.FileShare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.InteropServices;

namespace KSP.IO
{
  [ComVisible(true)]
  [Flags]
  [Serializable]
  public enum FileShare
  {
    None = 0,
    Read = 1,
    Write = 2,
    ReadWrite = Write | Read, // 0x00000003
    Delete = 4,
    Inheritable = 16, // 0x00000010
  }
}
