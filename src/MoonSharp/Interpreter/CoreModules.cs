// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreModules
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter
{
  [Flags]
  public enum CoreModules
  {
    None = 0,
    Basic = 64, // 0x00000040
    GlobalConsts = 1,
    TableIterators = 2,
    Metatables = 4,
    String = 8,
    LoadMethods = 16, // 0x00000010
    Table = 32, // 0x00000020
    ErrorHandling = 128, // 0x00000080
    Math = 256, // 0x00000100
    Coroutine = 512, // 0x00000200
    Bit32 = 1024, // 0x00000400
    OS_Time = 2048, // 0x00000800
    OS_System = 4096, // 0x00001000
    IO = 8192, // 0x00002000
    Debug = 16384, // 0x00004000
    Dynamic = 32768, // 0x00008000
    Json = 65536, // 0x00010000
    Preset_HardSandbox = Bit32 | Math | Table | String | TableIterators | GlobalConsts | Basic, // 0x0000056B
    Preset_SoftSandbox = Preset_HardSandbox | Json | Dynamic | OS_Time | Coroutine | ErrorHandling | Metatables, // 0x00018FEF
    Preset_Default = Preset_SoftSandbox | IO | OS_System | LoadMethods, // 0x0001BFFF
    Preset_Complete = Preset_Default | Debug, // 0x0001FFFF
  }
}
