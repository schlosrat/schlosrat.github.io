// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceContainerStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ResourceContainerComponentState), "ResourceContainerState", new string[] {"KSP.Sim.State.ResourceContainerState"})]
  public class ResourceContainerStateConverter : 
    IStructConverter<ResourceContainerComponentState>,
    IValueConverter<ResourceContainerComponentState>,
    IValueConverter<ResourceContainerComponentState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ResourceContainerComponentState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ResourceContainerComponentState IValueConverter<ResourceContainerComponentState>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ResourceContainerComponentState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerComponentState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ResourceContainerComponentState clrValue, Script script) => throw null;
  }
}
