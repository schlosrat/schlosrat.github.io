// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtPoolComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [AddComponentMenu("")]
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
