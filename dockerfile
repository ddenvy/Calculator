# Используем официальный образ .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Копируем все файлы проекта
COPY . ./

# Восстанавливаем зависимости
RUN dotnet restore

# Строим приложение
RUN dotnet publish -c Release -o out

# Используем официальный образ .NET runtime для выполнения
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Настроим переменную среды для приложения
ENV ASPNETCORE_URLS=http://*:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "CalculatorApp.dll"]
