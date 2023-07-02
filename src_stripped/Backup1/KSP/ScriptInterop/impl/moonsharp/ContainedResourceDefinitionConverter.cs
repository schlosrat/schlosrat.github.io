// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ContainedResourceDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ContainedResourceDefinition), "ContainedResourceDefinition", new string[] {"KSP.Sim.Definitions.ContainedResourceDefinition"})]
  public class ContainedResourceDefinitionConverter : IValueConverter<ContainedResourceDefinition>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Class<ContainedResourceDefinition> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceDefinitionConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceDefinition ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ContainedResourceDefinition clrValue, Script script) => throw null;
  }
}
