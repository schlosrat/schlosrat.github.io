// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecalMaskObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ThreeEyedGames
{
  public class DecalMaskObject
  {
    public GameObject MaskObj;
    public int ID;
    public bool IncludePQS;
    public List<Decal> Decals;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DecalMaskObject() => throw null;
  }
}
