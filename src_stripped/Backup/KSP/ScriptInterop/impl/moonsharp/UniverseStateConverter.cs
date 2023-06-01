// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.UniverseStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (UniverseState), "UniverseState", new string[] {"KSP.Sim.State.UniverseState"})]
  public class UniverseStateConverter : 
    IStructConverter<UniverseState>,
    IValueConverter<UniverseState>,
    IValueConverter<UniverseState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<UniverseState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    UniverseState IValueConverter<UniverseState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(UniverseState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniverseState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(UniverseState clrValue, Script script) => throw null;
  }
}
