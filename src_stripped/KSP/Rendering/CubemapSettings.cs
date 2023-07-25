// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CubemapSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [CreateAssetMenu(fileName = "cubemap_settings", menuName = "KSP/Settings/Cubemap Settings")]
  public class CubemapSettings : ScriptableObject
  {
    public CubemapConfig cubemapConfig;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CubemapSettings() => throw null;
  }
}
