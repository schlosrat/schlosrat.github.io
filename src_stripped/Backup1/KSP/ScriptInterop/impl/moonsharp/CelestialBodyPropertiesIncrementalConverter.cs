// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CelestialBodyPropertiesIncrementalConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
