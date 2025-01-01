@echo off
rem A batch file for SimpleCSharpApp.exe
rem which captures the app's return value.

dotnet run
@if "%ERRORLEVEL%" == "0" goto success

:fail 
	echo This application failed
	echo return value = %ERRORLEVEL%
	goto end
:success
	echo This applicationhas succeeded!
	echo return value = %ERRORLEVEL%
	goto end
:end
	echo All Done.