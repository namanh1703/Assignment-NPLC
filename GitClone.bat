@echo off
set /p commit_message=Enter link: 
start cmd /k "cd /d %cd% & git clone %commit_message% & exit"
