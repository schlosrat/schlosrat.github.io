// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ResourceContainerChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Resources/ResourceContainerChanged", false, "When a containers resources change", "")]
  public class ResourceContainerChangedMessage : ResourceMessageBase
  {
    public ResourceContainer Container;
    public ResourceDefinitionID ResourceId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerChangedMessage() => throw null;
  }
}
