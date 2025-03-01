FROM mcr.microsoft.com/dotnet/sdk:8.0

RUN apt update && apt install git -y
RUN git config --global --add safe.directory /workspace

WORKDIR /workspace

CMD ["dotnet", "run"]