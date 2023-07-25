// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.PartSizeHighlightScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  [Serializable]
  public class PartSizeHighlightScale
  {
    public MetaAssemblySizeFilterType sizeFilterType;
    public float highlightScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartSizeHighlightScale() => throw null;
  }
}
