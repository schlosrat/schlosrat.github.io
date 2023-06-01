// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartDefinitionContainerConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartDefinitionContainer), "partcontainer", new string[] {"PartDefinitionContainer", "KSP.Sim.Definitions.PartDefinitionContainer"})]
  public class PartDefinitionContainerConverter : 
    IStructConverter<PartDefinitionContainer>,
    IValueConverter<PartDefinitionContainer>,
    IValueConverter<PartDefinitionContainer?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartDefinitionContainer> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinitionContainerConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartDefinitionContainer IValueConverter<PartDefinitionContainer>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinitionContainer? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartDefinitionContainer? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartDefinitionContainer clrValue, Script script) => throw null;
  }
}
