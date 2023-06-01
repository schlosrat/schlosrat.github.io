// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SimulationObjectStateContainerConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SimulationObjectStateContainer), "StateContainer", new string[] {"SimulationObjectStateContainer", "KSP.Sim.State.SimulationObjectStateContainer"})]
  public class SimulationObjectStateContainerConverter : 
    IStructConverter<SimulationObjectStateContainer>,
    IValueConverter<SimulationObjectStateContainer>,
    IValueConverter<SimulationObjectStateContainer?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<SimulationObjectStateContainer> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectStateContainerConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SimulationObjectStateContainer IValueConverter<SimulationObjectStateContainer>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SimulationObjectStateContainer? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectStateContainer? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SimulationObjectStateContainer clrValue, Script script) => throw null;
  }
}
