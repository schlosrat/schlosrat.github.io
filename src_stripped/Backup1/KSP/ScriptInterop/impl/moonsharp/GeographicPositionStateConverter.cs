// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.GeographicPositionStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (GeographicPositionState), "GeographicPositionState", new string[] {"KSP.Sim.State.GeographicPositionState"})]
  public class GeographicPositionStateConverter : 
    IStructConverter<GeographicPositionState>,
    IValueConverter<GeographicPositionState>,
    IValueConverter<GeographicPositionState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<GeographicPositionState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GeographicPositionStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    GeographicPositionState IValueConverter<GeographicPositionState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(GeographicPositionState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GeographicPositionState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(GeographicPositionState clrValue, Script script) => throw null;
  }
}
