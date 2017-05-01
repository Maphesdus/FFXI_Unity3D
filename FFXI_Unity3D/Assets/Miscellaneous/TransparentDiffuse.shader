Shader "Custom/TransparentDiffuse" {
        Properties {
                _Color ("Main Color", Color) = (1,1,1,1)
                _MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
        }
 
        SubShader {
                Tags {"Queue"="AlphaTest" "IgnoreProjector"="True" "RenderType"="TransparentCutout"}
                blend SrcAlpha OneMinusSrcAlpha
               
                LOD 200
                ZWrite Off
                CGPROGRAM
                #pragma surface surf Lambert exclude_path:prepass
               
                sampler2D _MainTex;
                fixed4 _Color;
               
                struct Input {
                        float2 uv_MainTex;
                };
               
                void surf (Input IN, inout SurfaceOutput o) {
                        fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
                        o.Albedo = c.rgb;
                        o.Alpha = c.a;
                }
                ENDCG
        }
       
       
        SubShader {
                Pass {
                        Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
                        ZWrite Off
                        Blend SrcAlpha OneMinusSrcAlpha
                        Material {
                                Diffuse [_Color]
                                Ambient [_Color]      
                        }
                        Lighting On
                        SetTexture [_MainTex] {
                                Combine texture * primary DOUBLE, texture * primary
                        }
                }
        }
 
	Fallback "VertexLit"
}