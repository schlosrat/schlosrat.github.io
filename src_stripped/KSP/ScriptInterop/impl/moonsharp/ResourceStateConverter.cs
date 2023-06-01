// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ContainedResourceState), "ResourceState", new string[] {"KSP.Sim.State.ResourceState"})]
  public class ResourceStateConverter : 
    IStructConverter<ContainedResourceState>,
    IValueConverter<ContainedResourceState>,
    IValueConverter<ContainedResourceState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ContainedResourceState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ContainedResourceState IValueConverter<ContainedResourceState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ContainedResourceState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ContainedResourceState clrValue, Script script) => throw null;
  }
}
