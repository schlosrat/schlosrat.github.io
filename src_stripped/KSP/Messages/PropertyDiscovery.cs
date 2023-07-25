﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyDiscovery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public static class PropertyDiscovery
  {
    private static readonly BiDirectionalDictionary<string, System.Type> _discoveryNameTypeCache;
    public static readonly string[] DiscoveryNamesSorted;

    public static IReadOnlyBiDirectionalDictionary<string, System.Type> DiscoveryNameTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PropertyDiscovery() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static System.Type GetPropertyTypeForDiscoveryName(string discoveryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDiscoveryNameForPropertyType(System.Type messageType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDiscoveryNameForPropertyType<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetSortedIndexOfDiscoveryName(string discoveryName) => throw null;
  }
}
