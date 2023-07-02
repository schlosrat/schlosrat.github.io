// Decompiled with JetBrains decompiler
// Type: TechnologyContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
