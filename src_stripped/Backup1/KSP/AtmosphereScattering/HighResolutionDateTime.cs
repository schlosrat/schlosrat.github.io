// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.HighResolutionDateTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KSP.AtmosphereScattering
{
  public static class HighResolutionDateTime
  {
    public static bool IsAvailable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [DllImport("Kernel32.dll")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void GetSystemTimePreciseAsFileTime(out long filetime) => throw null;

    public static DateTime UtcNow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static HighResolutionDateTime() => throw null;
  }
}
