// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtPoolComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("")]
  [ExecuteInEditMode]
  public class SgtPoolComponent : SgtLinkedBehaviour<SgtPoolComponent>
  {
    public string TypeName;
    public List<Component> Elements;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtPoolComponent() => throw null;
  }
}
