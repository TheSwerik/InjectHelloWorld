﻿dotnet publish -p:PublishProfile=InjectHelloWorldConsole/InjectHelloWorldConsole.csproj -c:Release -o:Publish\bin\64bit -v:m -r:win-x64 --self-contained:true -p:PublishSingleFile=true -p:PublishTrimmed=true