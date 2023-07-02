// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.AutoExposureProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [Serializable]
  public class AutoExposureProperties
  {
    [SerializeField]
    public float minLuminance;
    [SerializeField]
    public float maxLuminance;
    [SerializeField]
    public float keyValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutoExposureProperties() => throw null;
  }
}
