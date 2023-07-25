// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.LuaStateInterop.CharPtr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
  public class CharPtr
  {
    public char[] chars;
    public int index;

    public char this[int offset]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public char this[uint offset]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public char this[long offset]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CharPtr(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CharPtr(char[] chars) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CharPtr(byte[] bytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(CharPtr ptr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(CharPtr ptr, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(char[] chars) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(char[] chars, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(byte[] bytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr(IntPtr ptr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CharPtr operator +(CharPtr ptr, int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CharPtr operator -(CharPtr ptr, int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CharPtr operator +(CharPtr ptr, uint offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CharPtr operator -(CharPtr ptr, uint offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void inc() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void dec() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr next() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr prev() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr add(int ofs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CharPtr sub(int ofs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(CharPtr ptr, char ch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(char ch, CharPtr ptr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(CharPtr ptr, char ch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(char ch, CharPtr ptr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CharPtr operator +(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int operator -(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator <(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator <=(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator >(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator >=(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(CharPtr ptr1, CharPtr ptr2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToString(int length) => throw null;
  }
}
