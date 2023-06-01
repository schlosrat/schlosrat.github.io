// Decompiled with JetBrains decompiler
// Type: TechnologyContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Research;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class TechnologyContextData : ApiDataContext
{
  [DataList("technologies")]
  public List<TechnologyNode> technologyNodesList;
  [DataList("technologiesOrder")]
  public List<TechnologyNode> technologyNodesOrderList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TechnologyContextData() => throw null;
}
