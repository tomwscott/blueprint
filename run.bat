@echo off
SET NANT_HOME=%CD%\tools\nant-0.91-alpha2
SET NANT_OPTS=-Xmx1024m
CALL tools\nant-0.91-alpha2\bin\nant %*
IF ERRORLEVEL 1 goto RedBuild
IF ERRORLEVEL 0 goto GreenBuild

:RedBuild
color 4f
more tools\buildflags\failed.txt
goto TheEnd

:GreenBuild
more tools\buildflags\passed.txt
color 2F

:TheEnd
pause

color 07