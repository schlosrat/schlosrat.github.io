// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.RigidbodyStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (RigidbodyState), "RigidbodyState", new string[] {"KSP.Sim.State.RigidbodyState"})]
  public class RigidbodyStateConverter : 
    IStructConverter<RigidbodyState>,
    IValueConverter<RigidbodyState>,
    IValueConverter<RigidbodyState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<RigidbodyState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RigidbodyStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    RigidbodyState IValueConverter<RigidbodyState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(RigidbodyState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RigidbodyState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(RigidbodyState clrValue, Script script) => throw null;
  }
}
