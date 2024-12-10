# Используем базовый образ .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Копируем файлы проекта
COPY . .

# Восстанавливаем зависимости и собираем проект
RUN dotnet restore
RUN dotnet build -c Release -o /app/build

# Создаем образ для выполнения
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/build .

# Команда для запуска приложения
ENTRYPOINT ["dotnet", "Calculator.dll"]