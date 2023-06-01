// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Tools
{
  [Serializable]
  public class PQSFreeCamState
  {
    public float latitude;
    public float longitude;
    public float altitude;
    public AltitudeMode altitudeMode;
    public float heading;
    public float pitch;
    public float speedMultiplier;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyValues(PQSFreeCamState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSFreeCamState() => throw null;
  }
}
