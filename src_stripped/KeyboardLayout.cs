// Decompiled with JetBrains decompiler
// Type: KeyboardLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
