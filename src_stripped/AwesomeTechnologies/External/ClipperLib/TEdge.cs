// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.TEdge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.External.ClipperLib
{
  internal class TEdge
  {
    internal IntPoint Bot;
    internal IntPoint Curr;
    internal IntPoint Top;
    internal IntPoint Delta;
    internal double Dx;
    internal PolyType PolyTyp;
    internal EdgeSide Side;
    internal int WindDelta;
    internal int WindCnt;
    internal int WindCnt2;
    internal int OutIdx;
    internal TEdge Next;
    internal TEdge Prev;
    internal TEdge NextInLML;
    internal TEdge NextInAEL;
    internal TEdge PrevInAEL;
    internal TEdge NextInSEL;
    internal TEdge PrevInSEL;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TEdge() => throw null;
  }
}
