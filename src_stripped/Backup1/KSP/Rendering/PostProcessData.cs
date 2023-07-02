// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering
{
  [CreateAssetMenu(fileName = "body_postProcessData", menuName = "ScriptableObjects/PostProcessData", order = 1)]
  [Serializable]
  public class PostProcessData : ScriptableObject
  {
    [SerializeField]
    [Tooltip("Post processing profile in celestial body's lighting folder")]
    public PostProcessProfile profile;
    [SerializeField]
    public double innerAltitude;
    [SerializeField]
    public double outerAltitude;
    [SerializeField]
    public bool autoExposureEnabled;
    [SerializeField]
    public PostPropertyBlendMode autoExposureBlendMode;
    [SerializeField]
    public AutoExposureProperties autoExposurePropertiesDay;
    [SerializeField]
    public AutoExposureProperties autoExposurePropertiesSunset;
    [SerializeField]
    public AutoExposureProperties autoExposurePropertiesNight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessData() => throw null;
  }
}
