// Decompiled with JetBrains decompiler
// Type: RTG.Object2ObjectSnapDataDb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class Object2ObjectSnapDataDb : Singleton<Object2ObjectSnapDataDb>
  {
    private Dictionary<GameObject, Object2ObjectSnapData> _objectToSnapData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Object2ObjectSnapData GetObject2ObjectSnapData(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Object2ObjectSnapDataDb() => throw null;
  }
}
