set unity=C:\Program Files\2020.3.20f1\Editor\Unity.exe
set butler=C:\Users\Suzan\Desktop\Butler\butler.exe
git pull
"%unity%" -quit -batchmode -executeMethod BuildWebGL.Build
cd Builds
tar -a -c -f "WebGL.zip" "WebGL"
"%butler%" push "WebGL.zip" darkbuilder646/pokescape:html --userversion 0.1