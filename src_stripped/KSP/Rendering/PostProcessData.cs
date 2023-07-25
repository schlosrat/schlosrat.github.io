// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
    [Tooltip("Post processing profile in celestial body's lighting folder")]
    [SerializeField]
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
