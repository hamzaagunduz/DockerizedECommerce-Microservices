# ECommerce Microservices


## Proje Hakkında

ECommerce Microservices projesi, modern mikro hizmet mimarisi kullanarak geliştirilmiştir. Bu proje, esnek ve ölçeklenebilir bir e-ticaret sistemi oluşturmayı hedeflemektedir. Aşağıda kullanılan teknolojiler ve mimari detaylar bulunmaktadır.

## Kullanılan Teknolojiler

- **Veritabanları:**
  - **MongoDB**: NoSQL veritabanı olarak kullanılır.
  - **PostgreSQL**: İlişkisel veritabanı yönetim sistemi.
  - **MSSQL**: Microsoft SQL Server.
  - **SQLite**: Hafif bir veritabanı çözümü.
  
- **Docker**: Uygulamaların konteynerleştirilmesi için kullanılır.
- **Redis**: Veri önbellekleme ve hızlı erişim için kullanılır.
  
- **Identity Server**: Kimlik doğrulama ve yetkilendirme süreçlerini yönetir.
- **API Gateway**: Mikro hizmetler arasındaki iletişimi yönetmek için Ocelot kullanılır.
  
- **Dapper**: Mikro ORM, veritabanı işlemleri için kullanılır.
  
- **SignalR**: Gerçek zamanlı web uygulamaları için kullanılır.
- **Ajax**: Asenkron web istekleri için kullanılır.
  
- **Postman**: API test ve dokümantasyonu için kullanılır.
- **Swagger**: API dokümantasyonu ve test için kullanılır.

## Mimariler

- **Onion Architecture**: Uygulama mimarisi.
- **CQRS Design Pattern**: Komut ve sorguların ayrılması.
- **Mediator Design Pattern**: Komut ve sorguların iletişimini yönetir.
- **Repository Design Pattern**: Veri erişim katmanını soyutlar.

## Özellikler

- **Kullanıcı Kimlik Doğrulama ve Yetkilendirme**: JWT ve Bearer token kullanarak güvenli bir kullanıcı deneyimi sağlar.
- **Fotoğraf Yükleme**: Google Drive entegrasyonu ile fotoğraf yükleme özelliği.
- **API Tüketimi**: Mikro hizmetlerin birbirleriyle iletişim kurması için RESTful API'ler.
- **Hızlı API**: Hızlı API tüketimi için entegrasyonlar.

## Başlangıç Kılavuzu

1. **Docker Kurulumu**: Projeyi çalıştırmak için Docker'ı kurun.
2. **Veritabanı Ayarları**: Kullanmak istediğiniz veritabanının ayarlarını yapılandırın.
3. **Proje Çalıştırma**: Aşağıdaki komutları kullanarak projeyi başlatın.

```bash
docker-compose up --build
