// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.IO.FileUserDataBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib.IO
{
  internal abstract class FileUserDataBase : RefIdObject
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue read(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue write(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue close(ScriptExecutionContext executionContext, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double? ReadNumber() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsNumericChar(char c, string numAsFar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool Eof() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract string ReadLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract string ReadBuffer(int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract string ReadToEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract char Peek() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void Write(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal abstract bool isopen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract string Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool flush() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract long seek(string whence, long offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool setvbuf(string mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FileUserDataBase() => throw null;
  }
}
