
Shader "Gradient Camera" {

	Properties {
		_Color ("Top Color", Color) = (1,1,1,1)

		_ColorOne ("Bottom Color", Color) = (1,1,1,1)

		_MainTex ("Albedo", 2D) = "white" {}

		_Glossiness ("Smoothness", Range(0,1)) = 0.5

		_Metallic ("Metallic", Range(0,1)) = 0.0
	}

	SubShader {
		Tags { "RenderType"="Opaque" }
		
		LOD 200

		CGPROGRAM

		#pragma surface surf Standard fullforwardshadows

		#pragma target 3.0

		sampler2D _MainTex;

		fixed4 _Color;

		fixed4 _ColorOne;

		struct Input {
			float2 uv_MainTex;
			
			float4 screenPos;
		};

		void surf (Input IN, inout SurfaceOutputStandard o) {
			float2 screenUv = IN.screenPos.xy / IN.screenPos.w;

			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * lerp(_Color, _ColorOne, screenUv.y);

			o.Albedo = c.rgb;

			o.Alpha = c.a;
		}

		ENDCG
	}

	FallBack "VertexLit"
}