// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
