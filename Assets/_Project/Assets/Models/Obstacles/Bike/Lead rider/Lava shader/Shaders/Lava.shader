Shader "Shader Graphs/Lava" {
	Properties {
		_Mask_Texture ("Mask Texture", 2D) = "white" {}
		[HDR] _Masked_color ("Masked color", Vector) = (1,0.3823665,0,0)
		_Rock_Color ("Rock Color", Vector) = (0.3098039,0.227451,0.172549,1)
		_Rock_Texture ("Rock Texture", 2D) = "white" {}
		[HDR] _Lava_Color ("Lava Color", Vector) = (32,1.581884,0,0)
		_Lava_Texture ("Lava Texture", 2D) = "white" {}
		_Island_Density ("Island Density", Float) = 5
		_Angle_Offset ("Angle Offset", Float) = 2
		_Angle_Change_Speed ("Angle Change Speed", Float) = 1
		_Thickness ("Thickness", Range(0, 1)) = 0.1
		_Thickness_Falloff ("Thickness Falloff", Range(0, 0.1)) = 0.02
		_Flow_Map ("Flow Map", 2D) = "white" {}
		_Flow_Strength ("Flow Strength", Range(0, 1)) = 0.5
		_Flow_Speed ("Flow Speed", Range(0, 0.1)) = 0.02
		_Lava_Speed ("Lava Speed", Vector) = (0,0,0,0)
		_Heightmap_Strength ("Heightmap Strength", Range(0, 1)) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}