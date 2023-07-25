// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.ClipperLib.LocalMinima
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.External.ClipperLib
{
  internal class LocalMinima
  {
    internal long Y;
    internal TEdge LeftBound;
    internal TEdge RightBound;
    internal LocalMinima Next;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalMinima() => throw null;
  }
}
