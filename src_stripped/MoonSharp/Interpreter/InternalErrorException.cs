// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.InternalErrorException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [Serializable]
  public class InternalErrorException : InterpreterException
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InternalErrorException(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal InternalErrorException(string format, params object[] args) => throw null;
  }
}
