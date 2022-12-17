#!/bin/bash
serviceName="LAC"

# ====================
# 
# ====================
dotnet publish "src/LAC/LAC.csproj" --output "bin" --runtime linux-x64 --self-contained \
  "-p:Configuration=Release" \
  "-p:DebugType=None" \
  "-p:GenerateRuntimeConfigurationFiles=true" \
  "-p:PublishSingleFile=true"

# ====================
# 
# ====================
if [ $serviceName != "LAC" ]; then
  mv "bin/LAC" "bin/${serviceName}"
fi

# ====================
# 
# ====================
"bin/${serviceName}"
