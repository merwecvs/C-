# Görev Takip API'si

## Proje Amacı
Bu proje, kullanıcıların görev (to-do) oluşturabildiği, listeleyebildiği, güncelleyebildiği ve silebildiği basit ve işlevsel bir RESTful Web API sağlar.

## Kullanılan Teknolojiler
- **Backend:** ASP.NET Core Web API (.NET 8)
- **ORM:** Entity Framework Core (Code First)
- **Veritabanı:** SQLite (`gorevler.db`)
- **Dokümantasyon:** Swagger (OpenAPI)

## Nasıl Çalıştırılır?

1️⃣ Gerekli .NET SDK kurulu olduğundan emin olun.  
2️⃣ Terminal veya VS Code üzerinden proje klasörüne gidin.  
3️⃣ Gerekirse veritabanını oluşturmak için:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
