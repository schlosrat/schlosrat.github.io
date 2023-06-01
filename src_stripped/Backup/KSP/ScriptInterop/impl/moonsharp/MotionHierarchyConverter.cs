// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.MotionHierarchyConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
