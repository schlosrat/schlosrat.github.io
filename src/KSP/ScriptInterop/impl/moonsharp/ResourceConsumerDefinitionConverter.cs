// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceConsumerDefinitionConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ResourceConsumerComponentDefinition), "ResourceConsumer", new string[] {"ResourceConsumerDefinition", "KSP.Sim.Definitions.ResourceConsumerDefinition"})]
  public class ResourceConsumerDefinitionConverter : 
    NullableConverter<ResourceConsumerComponentDefinition>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceConsumerDefinitionConverter(TypeInterop typeInterop) => throw null;
  }
}
