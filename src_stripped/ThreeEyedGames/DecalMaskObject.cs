// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecalMaskObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
