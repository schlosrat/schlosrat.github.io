// Decompiled with JetBrains decompiler
// Type: RTG.TexturePool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class TexturePool : Singleton<TexturePool>
  {
    private Texture2D _xAxisLabel;
    private Texture2D _yAxisLabel;
    private Texture2D _zAxisLabel;
    private Texture2D _camPerspMode;
    private Texture2D _camOrthoMode;
    private const string X_AXIS_LABEL_KEY = "RuntimeGizmos/XAxisLabel.png";
    private const string Y_AXIS_LABEL_KEY = "RuntimeGizmos/YAxisLabel.png";
    private const string Z_AXIS_LABEL_KEY = "RuntimeGizmos/ZAxisLabel.png";
    private const string PERSP_TEX_KEY = "RuntimeGizmos/CamPerspMode.png";
    private const string ORTHO_TEX_KEY = "RuntimeGizmos/CamOrthoMode.png";

    public Texture2D XAxisLabel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D YAxisLabel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D ZAxisLabel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D CamPerspMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D CamOrthoMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TexturePool() => throw null;
  }
}
