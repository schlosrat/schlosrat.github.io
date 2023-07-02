// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartOwnerStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartOwnerState), "PartOwnerState", new string[] {"KSP.Sim.State.PartOwnerState"})]
  public class PartOwnerStateConverter : 
    IStructConverter<PartOwnerState>,
    IValueConverter<PartOwnerState>,
    IValueConverter<PartOwnerState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartOwnerState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartOwnerState IValueConverter<PartOwnerState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartOwnerState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartOwnerState clrValue, Script script) => throw null;
  }
}
