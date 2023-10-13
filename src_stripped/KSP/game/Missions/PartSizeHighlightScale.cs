// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.PartSizeHighlightScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
