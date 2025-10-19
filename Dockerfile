FROM mcr.microsoft.com/dotnet/framework/sdk:4.8-windowsservercore-ltsc2022 AS builder

COPY . .

RUN nuget restore -NonInteractive
RUN xbuild /property:Configuration=Release /property:OutDir=/usr/src/app/build/
RUN ls -lA *

FROM mono:5.12

RUN mkdir -p /usr/src/app/build
COPY --from=builder /usr/src/app/build/ /usr/src/app/build/
WORKDIR /usr/src/app/build

ENTRYPOINT ["mono", "BDInfo.exe"]