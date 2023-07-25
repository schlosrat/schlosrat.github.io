// Decompiled with JetBrains decompiler
// Type: LibNoise.IModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace LibNoise
{
  public interface IModule
  {
    double GetValue(double x, double y, double z);

    double GetValue(Vector3d coordinate);

    double GetValue(Vector3 coordinate);
  }
}
