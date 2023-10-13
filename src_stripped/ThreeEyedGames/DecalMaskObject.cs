// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecalMaskObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
