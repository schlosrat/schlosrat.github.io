// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.ObjectReferenceProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
