# CSE-4202-Graphics-and-Animation

This repo contains codes and related files for the course CSE4202: Computer Graphics and Animations Sessional.

# Setup for Windows

*  Download glfw libray from https://www.glfw.org/download.html. Download *64-bit Windows binaries* from *Windows pre-compiled binaries*.   
*  Create **build** and **lib** folder inside code repo. Copy *glfw3.dll* from *lib-mingw-w64* folder of glfw library to **build** and **lib** folder.  
* For C++ compiler and make, Download MSYS2 Package Manager from https://www.msys2.org/ .  
* Run following commands in MSYS2 terminal: ```pacman -S base-devel``` and ```pacman -S gcc``` . 
* Add your bin folder (which includes g++.exe and make.exe) path of msys64 installation directory (default **C:\msys64\usr\bin**) in your environment variable.
* Run ```make win``` in Terminal.
* ```.exe``` file will be in **build** folder.
* For **khplatform.h** header file error, download the [file](https://registry.khronos.org/EGL/api/KHR/khrplatform.h) and keep it inside **C:\msys64\usr\include\KHR** folder. Create **KHR** folder if you have to.
* For errors regarding not recognizing **.dll** file format, change your compiler path inside **c_cpp_properties.json** file as ```"compilerPath": "C:\\msys64\\usr\\bin\\x86_64-pc-msys-g++.exe"``` inside **configuration** block. Update MakeFile command accordingly: use ***x86_64-pc-msys-g++.exe*** instead of ***g++.exe***. 
* If your code still does not run, then you have to check openGL version by installing GLview from http://www.realtech-vr.com/home/glview . If your openGL version is below 3.3, then update windows. 
