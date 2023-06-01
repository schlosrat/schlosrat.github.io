// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VirtualConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public struct VirtualConnection
  {
    public PartComponent host;
    public PartComponent target;
    public PartRelationshipType relationshipType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VirtualConnection(
      PartComponent host,
      PartComponent target,
      PartRelationshipType relationshipType)
    {
      throw null;
    }
  }
}
