// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CelestialBodyPropertiesConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (CelestialBodyProperties), "CelestialBodyProperties", new string[] {"KSP.Sim.Definitions.CelestialBodyProperties"})]
  public class CelestialBodyPropertiesConverter : 
    IStructConverter<CelestialBodyProperties>,
    IValueConverter<CelestialBodyProperties>,
    IValueConverter<CelestialBodyProperties?>
  {
    private TypeInterop typeInterop;
    private CelestialBodyProperties defaults;
    private MoonSharpBinding.Struct<CelestialBodyProperties> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyPropertiesConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyProperties? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyProperties IValueConverter<CelestialBodyProperties>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyProperties? IValueConverter<CelestialBodyProperties?>.ToValue(DynValue from) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyProperties definition, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WriteFloatCurveIfDifferent(
      Script script,
      Table table,
      string name,
      FloatCurve floatCurve,
      FloatCurve defaultCurve)
    {
      throw null;
    }
  }
}
