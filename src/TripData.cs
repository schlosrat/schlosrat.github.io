// Decompiled with JetBrains decompiler
// Type: TripData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class TripData
{
  public List<NodeData> TripNodes;
  public List<EdgeData> TripEdges;
  public List<AngleData> TripAngles;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TripData() => throw null;
}
