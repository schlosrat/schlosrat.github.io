// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ForceStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ForceState), "ForceState", new string[] {"KSP.Sim.State.ForceState"})]
  public class ForceStateConverter : 
    IStructConverter<ForceState>,
    IValueConverter<ForceState>,
    IValueConverter<ForceState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ForceState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ForceStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ForceState IValueConverter<ForceState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ForceState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ForceState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ForceState clrValue, Script script) => throw null;
  }
}
