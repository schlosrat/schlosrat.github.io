// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MessageDiscovery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public static class MessageDiscovery
  {
    private static readonly BiDirectionalDictionary<string, System.Type> _discoveryNameTypeCache;
    public static string[] DiscoveryNamesSorted;
    public static bool _initialized;

    public static IReadOnlyBiDirectionalDictionary<string, System.Type> DiscoveryNameTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static System.Type GetMessageTypeForDiscoveryName(string discoveryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDiscoveryNameForMessageType(System.Type messageType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDiscoveryNameForMessageType<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetSortedIndexOfDiscoveryName(string discoveryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool ValidateInitialization() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MessageDiscovery() => throw null;
  }
}
