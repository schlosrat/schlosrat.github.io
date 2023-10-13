// Decompiled with JetBrains decompiler
// Type: TechnologyContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
