// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VFXInstanceSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.VFX
{
  [Serializable]
  public class VFXInstanceSetting
  {
    public VFXEventType Type;
    public float CellSize;
    public int MaxInstances;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXInstanceSetting() => throw null;
  }
}
