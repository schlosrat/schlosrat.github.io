// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.OrbitDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (KeplerOrbitState), "Orbit", new string[] {"OrbitState", "KSP.Sim.State.OrbitState"})]
  public class OrbitDefinitionConverter : 
    IStructConverter<KeplerOrbitState>,
    IValueConverter<KeplerOrbitState>,
    IValueConverter<KeplerOrbitState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<KeplerOrbitState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrbitDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    KeplerOrbitState IValueConverter<KeplerOrbitState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(KeplerOrbitState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeplerOrbitState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(KeplerOrbitState clrValue, Script script) => throw null;
  }
}
