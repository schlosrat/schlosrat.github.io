// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
