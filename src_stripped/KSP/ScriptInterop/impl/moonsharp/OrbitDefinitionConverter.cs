// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.OrbitDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
