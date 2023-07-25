// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.TEdge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
