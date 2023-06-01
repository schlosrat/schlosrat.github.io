// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.ObjectReferenceProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Timeline
{
  [Serializable]
  public class ObjectReferenceProxy : TrackAsset
  {
    [Header("Used to resolve all track bindings in its group")]
    public string tagToConnect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual GameObject ResolveTargetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectReferenceProxy() => throw null;
  }
}
