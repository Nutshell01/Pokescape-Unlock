set unity=C:\Program Files\2020.3.20f1\Editor\Unity.exe
set butler=C:\Users\Suzan\Desktop\Butler\butler.exe
git pull
"%unity%" -quit -batchmode -executeMethod BuildWebGL.Build
cd Builds
tar -cvzf "WebGL.zip" "WebGL"
"%butler%" push "WebGL.zip" iesnihS/pokescape:html --userversion 0.1