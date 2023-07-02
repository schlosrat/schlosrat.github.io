// Decompiled with JetBrains decompiler
// Type: KSP.IO.FileAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.InteropServices;

namespace KSP.IO
{
  [ComVisible(true)]
  [Flags]
  [Serializable]
  public enum FileAccess
  {
    Read = 1,
    Write = 2,
    ReadWrite = Write | Read, // 0x00000003
  }
}
