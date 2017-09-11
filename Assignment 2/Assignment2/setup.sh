
# Source this file! (from bash)
# Helge Stenström
# 2017-09-08


# Setup useful aliases

nunit="/Users/helge/hack/NUnit.Framework-3.8.0/bin/net-4.5"

alias kompilera="csc test.cs MainProgram.cs Menu.cs WholeNumbersForAdd.cs FloatingPointsNumberWhileAdd.cs CurrencyConverter.cs WorkingSchedule.cs Input.cs TempTable.cs NullAction.cs Startable.cs -reference:$nunit/nunit.framework.dll "
alias run="mono MainProgram.exe"
alias testa="mono $nunit/nunitlite-runner.exe MainProgram.exe "
