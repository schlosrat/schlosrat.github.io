// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.UniverseStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
