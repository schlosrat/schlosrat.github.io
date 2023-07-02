// Decompiled with JetBrains decompiler
// Type: CameraFXModules.WobbleFXParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace CameraFXModules
{
  [Serializable]
  public class WobbleFXParams
  {
    public MinMaxFloat amplitude;
    public MinMaxFloat frequency;
    public float slope;
    public FXModuleParams fxPars;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WobbleFXParams() => throw null;
  }
}
