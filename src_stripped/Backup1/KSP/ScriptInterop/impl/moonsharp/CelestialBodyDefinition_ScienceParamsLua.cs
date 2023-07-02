// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.CelestialBodyDefinition_ScienceParamsLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (CelestialBodyProperties.ScienceParams), "ScienceParams", new string[] {"KSP.Sim.Definitions.CelestialBodyProperty.ScienceParams"})]
  public class CelestialBodyDefinition_ScienceParamsLua : 
    IStructConverter<CelestialBodyProperties.ScienceParams>,
    IValueConverter<CelestialBodyProperties.ScienceParams>,
    IValueConverter<CelestialBodyProperties.ScienceParams?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<CelestialBodyProperties.ScienceParams> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDefinition_ScienceParamsLua(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyProperties.ScienceParams IValueConverter<CelestialBodyProperties.ScienceParams>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyProperties.ScienceParams? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    CelestialBodyProperties.ScienceParams? IValueConverter<CelestialBodyProperties.ScienceParams?>.ToValue(
      DynValue from)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(CelestialBodyProperties.ScienceParams definition, Script script) => throw null;
  }
}
