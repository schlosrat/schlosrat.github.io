// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
