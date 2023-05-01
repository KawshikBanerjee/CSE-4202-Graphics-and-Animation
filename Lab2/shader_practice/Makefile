win:
	x86_64-pc-msys-g++.exe -fdiagnostics-color=always -I./include ./src/shader_class.cpp ./src/glad.c -o ./build/main.exe -Llib -lglfw3 -lopengl32 -lgdi32
	./build/main.exe

linux:
	x86_64-pc-msys-g++ -fdiagnostics-color=always -I./include ./src/main.cpp ./src/glad.c -o ./build/main -Llib -lglfw -lGL -lXrandr -lX11 -lrt -ldl
	./build/main