// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.GeographicPositionStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
