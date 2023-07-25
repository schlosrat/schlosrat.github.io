// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralMeshOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
