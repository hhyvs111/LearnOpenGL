#version 330 core
out vec4 FragColor;
//顶点颜色

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;

void main()
{
    //纹理颜色与顶点颜色在片段着色器中相乘
	FragColor = texture(texture1, TexCoord);
}