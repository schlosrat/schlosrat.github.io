// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.IO.BinaryEncoding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.CoreLib.IO
{
  internal class BinaryEncoding : Encoding
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BinaryEncoding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetByteCount(char[] chars, int index, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetBytes(
      char[] chars,
      int charIndex,
      int charCount,
      byte[] bytes,
      int byteIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetCharCount(byte[] bytes, int index, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetChars(
      byte[] bytes,
      int byteIndex,
      int byteCount,
      char[] chars,
      int charIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetMaxByteCount(int charCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetMaxCharCount(int byteCount) => throw null;
  }
}
