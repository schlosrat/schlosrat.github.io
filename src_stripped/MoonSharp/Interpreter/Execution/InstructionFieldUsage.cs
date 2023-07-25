// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.InstructionFieldUsage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Execution
{
  [Flags]
  internal enum InstructionFieldUsage
  {
    None = 0,
    Symbol = 1,
    SymbolList = 2,
    Name = 4,
    Value = 8,
    NumVal = 16, // 0x00000010
    NumVal2 = 32, // 0x00000020
    NumValAsCodeAddress = 32784, // 0x00008010
  }
}
