// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.AttachNodeDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (AttachNodeDefinition), "AttachNode", new string[] {"KSP.Sim.Definitions.AttachNodeDefinition"})]
  public class AttachNodeDefinitionConverter : 
    IStructConverter<AttachNodeDefinition>,
    IValueConverter<AttachNodeDefinition>,
    IValueConverter<AttachNodeDefinition?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<AttachNodeDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    AttachNodeDefinition IValueConverter<AttachNodeDefinition>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AttachNodeDefinition? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeDefinition? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AttachNodeDefinition clrValue, Script script) => throw null;
  }
}
