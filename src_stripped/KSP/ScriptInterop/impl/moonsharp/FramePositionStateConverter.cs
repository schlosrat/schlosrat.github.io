// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.FramePositionStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (FramePositionState), "FramePositionState", new string[] {"KSP.Sim.State.FramePositionState"})]
  public class FramePositionStateConverter : 
    IStructConverter<FramePositionState>,
    IValueConverter<FramePositionState>,
    IValueConverter<FramePositionState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<FramePositionState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FramePositionStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    FramePositionState IValueConverter<FramePositionState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(FramePositionState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FramePositionState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(FramePositionState clrValue, Script script) => throw null;
  }
}
