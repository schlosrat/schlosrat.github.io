// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ResourceContainerChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
