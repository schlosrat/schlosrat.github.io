// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SimulationObjectDefinitionContainerConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SimulationObjectDefinitionContainer), "DefinitionContainer", new string[] {"SimulationObjectDefinitionContainer", "KSP.Sim.Definitions.SimulationObjectDefinitionContainer"})]
  public class SimulationObjectDefinitionContainerConverter : 
    IStructConverter<SimulationObjectDefinitionContainer>,
    IValueConverter<SimulationObjectDefinitionContainer>,
    IValueConverter<SimulationObjectDefinitionContainer?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<SimulationObjectDefinitionContainer> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectDefinitionContainerConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SimulationObjectDefinitionContainer IValueConverter<SimulationObjectDefinitionContainer>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SimulationObjectDefinitionContainer? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectDefinitionContainer? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SimulationObjectDefinitionContainer clrValue, Script script) => throw null;
  }
}
