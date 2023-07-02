// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.CallStackItemFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Execution.VM
{
  [Flags]
  internal enum CallStackItemFlags
  {
    None = 0,
    EntryPoint = 1,
    ResumeEntryPoint = 3,
    CallEntryPoint = 5,
    TailCall = 16, // 0x00000010
    MethodCall = 32, // 0x00000020
  }
}
