@echo off
REM Deletes and recreates the git repo in the folder
SET gitFolder=".git"
IF EXIST %gitFolder% (
	echo Deleing git folder: %gitFolder%...
	rd /S /Q %gitFolder%
	echo Deleted
	echo.
)
git init
git add -A
git commit -m "Initial version"