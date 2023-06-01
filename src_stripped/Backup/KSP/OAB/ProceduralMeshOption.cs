// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralMeshOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class ProceduralMeshOption
  {
    public string Name;
    [HideInInspector]
    public string ProceduralPartTypeName;
    public List<ProceduralPartAttribute> Attributes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralMeshOption() => throw null;
  }
}
