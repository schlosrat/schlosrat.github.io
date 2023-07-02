// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.MotionHierarchyConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (MotionHierarchy), "MotionHierarchy", new string[] {"KSP.Sim.State.MotionHierarchy"})]
  public class MotionHierarchyConverter : 
    IStructConverter<MotionHierarchy>,
    IValueConverter<MotionHierarchy>,
    IValueConverter<MotionHierarchy?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<MotionHierarchy> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionHierarchyConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    MotionHierarchy IValueConverter<MotionHierarchy>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(MotionHierarchy? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionHierarchy? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(MotionHierarchy clrValue, Script script) => throw null;
  }
}
