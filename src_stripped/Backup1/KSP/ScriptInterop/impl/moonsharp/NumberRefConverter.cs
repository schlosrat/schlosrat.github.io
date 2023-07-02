// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.NumberRefConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (float?), "Float", new string[] {"Single", "System.Single"})]
  [TypeInterop(typeof (double?), "Double", new string[] {"System.Double"})]
  [TypeInterop(typeof (int?), "Int", new string[] {"int32", "System.Int32"})]
  [TypeInterop(typeof (uint?), "Uint", new string[] {"uint32", "System.UInt32"})]
  [TypeInterop(typeof (ulong?), "Ulong", new string[] {"uint64", "System.UInt64"})]
  [TypeInterop(typeof (long?), "Long", new string[] {"int64", "System.Int64"})]
  public class NumberRefConverter : 
    IValueConverter<float?>,
    IValueConverter<double?>,
    IValueConverter<int?>,
    IValueConverter<long?>,
    IValueConverter<uint?>,
    IValueConverter<ulong?>
  {
    private TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberRefConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    float? IValueConverter<float?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    int? IValueConverter<int?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    uint? IValueConverter<uint?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    long? IValueConverter<long?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ulong? IValueConverter<ulong?>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(double? value, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(float? value, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(int? value, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(uint? value, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(long? value, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ulong? value, Script script) => throw null;
  }
}
