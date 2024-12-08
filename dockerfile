# Указываем базовый образ .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Копируем все файлы проекта и выполняем сборку
COPY . ./
RUN dotnet publish Calculator/Calculator.csproj -c Release -o out

# Указываем базовый образ .NET Runtime для запуска
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Запуск приложения
ENTRYPOINT ["dotnet", "Calculator.dll"]
