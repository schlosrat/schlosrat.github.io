// Decompiled with JetBrains decompiler
// Type: KSP.EnumInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class EnumInfo
  {
    private static readonly Dictionary<Type, EnumInfo> enumInfoCache;
    private Type underlyingType;
    private bool isSigned;
    private FloatInt64 minValue;
    private FloatInt64 maxValue;

    public Type UnderlyingType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSigned
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SignedMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public long SignedMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ulong UnsignedMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ulong UnsignedMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EnumInfo(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static EnumInfo GetCachedInfo(Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static EnumInfo() => throw null;
  }
}
