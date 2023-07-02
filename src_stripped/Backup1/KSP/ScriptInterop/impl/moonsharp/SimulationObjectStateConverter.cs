// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SimulationObjectStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SimulationObjectState), "State", new string[] {"SimulationObjectState", "KSP.Sim.State.SimulationObjectState"})]
  public class SimulationObjectStateConverter : 
    IStructConverter<SimulationObjectState>,
    IValueConverter<SimulationObjectState>,
    IValueConverter<SimulationObjectState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<SimulationObjectState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SimulationObjectState IValueConverter<SimulationObjectState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SimulationObjectState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimulationObjectState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SimulationObjectState clrValue, Script script) => throw null;
  }
}
