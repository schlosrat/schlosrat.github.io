// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.StringBuilderPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Networking.MP.Utils
{
  public class StringBuilderPool
  {
    private const int INITIAL_AVAILABLE_COUNT = 16;
    private static object gLockObject;
    private static Pool<StringBuilder> gPool;
    private static Bootstrap gBootstrap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static StringBuilder Acquire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Pool<StringBuilder>.ReturnableHandle AcquireHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Return(ref StringBuilder stringBuilder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Flush() => throw null;

    public static int AvailableCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringBuilderPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static StringBuilderPool() => throw null;
  }
}
