@echo off
call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsDevCmd.bat"
set fileName=%1
set fileName=%fileName:.cs=.exe%
echo %fileName%
echo %1
csc %1 -debug:full -out:%fileName%