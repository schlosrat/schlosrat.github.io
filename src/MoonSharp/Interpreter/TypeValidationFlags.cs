// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.TypeValidationFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter
{
  [Flags]
  public enum TypeValidationFlags
  {
    None = 0,
    AllowNil = 1,
    AutoConvert = 2,
    Default = AutoConvert, // 0x00000002
  }
}
