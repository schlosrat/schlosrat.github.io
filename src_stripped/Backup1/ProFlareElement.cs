// Decompiled with JetBrains decompiler
// Type: ProFlareElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ProFlareElement
{
  public bool Editing;
  public bool Visible;
  public int elementTextureID;
  public string SpriteName;
  public ProFlare flare;
  public ProFlareAtlas flareAtlas;
  public float Brightness;
  public float Scale;
  public float ScaleRandom;
  public float ScaleFinal;
  public Vector4 RandomColorAmount;
  public float position;
  public bool useRangeOffset;
  public float SubElementPositionRange_Min;
  public float SubElementPositionRange_Max;
  public float SubElementAngleRange_Min;
  public float SubElementAngleRange_Max;
  public Vector3 OffsetPosition;
  public Vector3 Anamorphic;
  public Vector3 OffsetPostion;
  public float angle;
  public float FinalAngle;
  public bool useRandomAngle;
  public bool useStarRotation;
  public float AngleRandom_Min;
  public float AngleRandom_Max;
  public bool OrientToSource;
  public bool rotateToFlare;
  public float rotationSpeed;
  public float rotationOverTime;
  public bool useColorRange;
  public Color ElementFinalColor;
  public Color ElementTint;
  public Color SubElementColor_Start;
  public Color SubElementColor_End;
  public bool useScaleCurve;
  public AnimationCurve ScaleCurve;
  public bool OverrideDynamicEdgeBoost;
  public float DynamicEdgeBoostOverride;
  public bool OverrideDynamicCenterBoost;
  public float DynamicCenterBoostOverride;
  public bool OverrideDynamicEdgeBrightness;
  public float DynamicEdgeBrightnessOverride;
  public bool OverrideDynamicCenterBrightness;
  public float DynamicCenterBrightnessOverride;
  public List<SubElement> subElements;
  public Vector2 size;
  public ProFlareElement.Type type;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProFlareElement() => throw null;

  public enum Type
  {
    Single,
    Multi,
  }
}
