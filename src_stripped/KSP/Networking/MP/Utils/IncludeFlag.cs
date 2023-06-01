// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.IncludeFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Networking.MP.Utils
{
  [Flags]
  public enum IncludeFlag
  {
    None = 0,
    FilePath = 1,
    LineNumber = 2,
    MemberName = 4,
  }
}
