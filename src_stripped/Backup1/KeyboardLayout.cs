// Decompiled with JetBrains decompiler
// Type: KeyboardLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
