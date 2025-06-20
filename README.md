# 🧠 C# ile Abstraction (Soyutlama) Uygulaması

Bu mini projede, C# dilinde abstraction (soyutlama) konusunu anlamaya çalıştım. Bir şirkette çalışan farklı pozisyonlardaki kişileri temsil eden sınıflar oluşturarak, her çalışanın kendi görevini ayrı ayrı tanımlamasını sağladım.

---

## 💡 Proje Ne Yapıyor?

- Ortak özelliklere sahip `Calisan` adında bir soyut sınıf oluşturdum.
- Her çalışanın görevi farklı olduğu için `Gorev()` metodunu soyut (abstract) olarak tanımladım.
- Yazılımcı, Proje Yöneticisi ve Satış Temsilcisi sınıfları `Calisan` sınıfından türedi ve kendi görev metotlarını `override` ederek tanımladı.

---

## 🧩 Kullanılan OOP Kavramları

| Özellik         | Açıklama |
|----------------|----------|
| `abstract class` | Ortak yapı: Ad, Soyad, Departman gibi bilgileri taşıyor |
| `abstract method` | Her sınıfın kendi görevini tanımlaması için zorunlu metot |
| `override` | Alt sınıfların `Gorev()` metodunu kendi işine göre yeniden yazması |
| `base(...)` | Alt sınıfların constructor'dan üst sınıfa parametre göndermesi |

---

## ⚠️ Zorlandığım Yerler & Nedenleri

Açık söylemek gerekirse bu projeyi yaparken bazı yerlerde gerçekten kafam karıştı. Öğrenirken en çok zorlandığım satırları ve mantığını buraya yazdım:

### 1. `public abstract void Gorev();`

```csharp
public abstract void Gorev();
