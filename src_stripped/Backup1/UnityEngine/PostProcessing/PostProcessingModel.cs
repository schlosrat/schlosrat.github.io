// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  [Serializable]
  public abstract class PostProcessingModel
  {
    [GetSet("enabled")]
    [SerializeField]
    private bool m_Enabled;

    public bool enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PostProcessingModel() => throw null;
  }
}
