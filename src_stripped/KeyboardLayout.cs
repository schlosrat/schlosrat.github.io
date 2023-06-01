// Decompiled with JetBrains decompiler
// Type: KeyboardLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class KeyboardLayout
{
  public CultureInfo Locale;
  public KeyboardLayoutType Type;

  [DllImport("user32.dll", SetLastError = true)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private static uint GetKeyboardLayout(uint idThread) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static KeyboardLayout GetKeyboardLayout() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected static KeyboardLayoutType GetKeyboardLayoutType(long layoutCode) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyboardLayout() => throw null;
}
