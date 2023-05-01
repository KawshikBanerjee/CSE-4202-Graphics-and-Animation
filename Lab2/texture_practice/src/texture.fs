#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
	// for one single texture item
	// FragColor = texture(texture1, TexCoord);

	// for extra color in texture 
	// FragColor = texture(texture1, TexCoord) * vec4(ourColor, 1.0); 

	// for combined texture
	FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.5); 
}