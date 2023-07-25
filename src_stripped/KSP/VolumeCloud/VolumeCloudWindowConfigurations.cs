// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.VolumeCloudWindowConfigurations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  public class VolumeCloudWindowConfigurations : ScriptableObject
  {
    public CurlNoiseGenerator curlGenerator;
    public BasicShape3dGenerator basicShape3dGenerator;
    public string basicShape3dTexSaveName;
    public Texture3dGenerator texture3dGenerator;
    public string texture3dTexSaveName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumeCloudWindowConfigurations() => throw null;
  }
}
