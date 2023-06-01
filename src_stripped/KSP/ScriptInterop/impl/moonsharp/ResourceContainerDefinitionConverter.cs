// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceContainerDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ResourceContainerComponentDefinition), "ResourceContainer", new string[] {"ResourceContainerDefinition", "KSP.Sim.Definitions.ResourceContainerDefinition"})]
  public class ResourceContainerDefinitionConverter : 
    NullableConverter<ResourceContainerComponentDefinition>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerDefinitionConverter(TypeInterop typeInterop) => throw null;
  }
}
