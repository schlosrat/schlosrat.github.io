// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
