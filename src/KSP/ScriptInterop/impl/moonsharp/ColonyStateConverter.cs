// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ColonyStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ColonyState), "ColonyState", new string[] {"KSP.Sim.State.ColonyState"})]
  public class ColonyStateConverter : 
    IStructConverter<ColonyState>,
    IValueConverter<ColonyState>,
    IValueConverter<ColonyState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ColonyState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ColonyState IValueConverter<ColonyState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ColonyState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ColonyState clrValue, Script script) => throw null;
  }
}
