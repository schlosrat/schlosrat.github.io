// Decompiled with JetBrains decompiler
// Type: RTG.Object2ObjectSnapDataDb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
