// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.NumberConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (int), "Int", new string[] {"int32", "System.Int32"})]
  [TypeInterop(typeof (uint), "Uint", new string[] {"uint32", "System.UInt32"})]
  [TypeInterop(typeof (ulong), "Ulong", new string[] {"uint64", "System.UInt64"})]
  [TypeInterop(typeof (long), "Long", new string[] {"int64", "System.Int64"})]
  [TypeInterop(typeof (float), "Float", new string[] {"Single", "System.Single"})]
  [TypeInterop(typeof (double), "Double", new string[] {"System.Double"})]
  public class NumberConverter : 
    IValueConverter<float>,
    IValueConverter<double>,
    IValueConverter<int>,
    IValueConverter<long>,
    IValueConverter<uint>,
    IValueConverter<ulong>
  {
    private TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    float IValueConverter<float>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IValueConverter<int>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    uint IValueConverter<uint>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    long IValueConverter<long>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ulong IValueConverter<ulong>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(double definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(float definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(int definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(uint definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(long definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ulong definition, Script script) => throw null;
  }
}
