// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CelestialBodyPropertiesIncrementalConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (CelestialBodyPropertiesIncremental), "CelestialBodyPropertiesIncremental", new string[] {"KSP.Sim.Definitions.CelestialBodyPropertiesIncremental"})]
  public class CelestialBodyPropertiesIncrementalConverter : 
    IStructConverter<CelestialBodyPropertiesIncremental>,
    IValueConverter<CelestialBodyPropertiesIncremental>,
    IValueConverter<CelestialBodyPropertiesIncremental?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<CelestialBodyPropertiesIncremental> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyPropertiesIncrementalConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyPropertiesIncremental? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyPropertiesIncremental IValueConverter<CelestialBodyPropertiesIncremental>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyPropertiesIncremental? IValueConverter<CelestialBodyPropertiesIncremental?>.ToValue(
      DynValue from)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyPropertiesIncremental definition, Script script) => throw null;
  }
}
