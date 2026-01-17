# 🚗 AutodjaOmanikud - Autohoolduse Haldussüsteem

Kaasaegne Windows Forms rakendus autohoolduse haldamiseks, kasutades Entity Framework Core'i, modulaarset arhitektuuri ja mitmekeelset tuge.

## 🎯 Omadused

- **Modulaarne arhitektuur** - eraldi UserControl igale funktsioonile
- **Entity Framework Core** - kaasaegne ORM Code First lähenemisega
- **SQLite andmebaas** - kerge ja usaldusväärne
- **Mitmekeelsus** - vene ja eesti keele tugi
- **Professionaalne UI** - kaasaegne disain emojidega
- **Automaatsed uuendused** - andmete sünkroniseerimine moodulite vahel

## 🏗️ Arhitektuur

```
📁 AutodjaOmanikud/
├── 📁 Controls/           # Modulaarsed kasutajaliidese kontrollid
│   ├── OwnerControl.cs    # Omanike haldamine
│   ├── CarControl.cs      # Autode haldamine
│   ├── ServiceControl.cs  # Hoolduse haldamine
│   └── ServiceTypeControl.cs # Teenuste tüüpide haldamine
├── 📁 Data/               # Entity Framework kontekst
├── 📁 Models/             # Andmemudelid
├── 📁 Services/           # Äriloogika
├── 📁 Migrations/         # Andmebaasi migratsioonid
├── Localization.cs        # Lokaliseerimise süsteem
└── Form1.cs               # Peamine vorm
```

## 🌍 Mitmekeelsus

Rakendus toetab kahte keelt:
- **Vene keel** - peamine liidese keel
- **Eesti keel** - täielik tõlge kõigist elementidest

### Keele vahetamine
- Nupp **RU/ET** paremas ülanurgas
- Kohene kogu liidese uuendamine
- Valitud keele säilitamine sessioonis

## 🚀 Tehnoloogiad

- **C# .NET 8.0** - kaasaegne arendusplatvorm
- **Windows Forms** - natiivne UI Windowsile
- **Entity Framework Core 8.0** - ORM andmebaasiga töötamiseks
- **SQLite** - sisseehitatud andmebaas
- **Visual Studio 2022** - arenduskeskkond

## 📊 Andmemudelid

### Owner (Omanik)
```csharp
public class Owner
{
    public int Id { get; set; }
    public string FullName { get; set; }    // Täisnimi
    public string Phone { get; set; }       // Telefon
    public ICollection<Car> Cars { get; set; } // Autod
}
```

### Car (Auto)
```csharp
public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }           // Mark
    public string Model { get; set; }           // Mudel
    public string RegistrationNumber { get; set; } // Registreerimisnumber
    public int OwnerId { get; set; }            // Omaniku ID
    public Owner Owner { get; set; }            // Omanik
    public ICollection<Service> Services { get; set; } // Teenused
}
```

### ServiceType (Teenuse tüüp)
```csharp
public class ServiceType
{
    public int Id { get; set; }
    public string Name { get; set; }        // Teenuse nimi
    public decimal Price { get; set; }      // Hind
    public ICollection<Service> Services { get; set; } // Hoolduskirjed
}
```

### Service (Hoolduskirje)
```csharp
public class Service
{
    public int Id { get; set; }
    public int CarId { get; set; }          // Auto ID
    public int ServiceTypeId { get; set; }  // Teenuse tüübi ID
    public DateTime Time { get; set; }      // Hoolduse aeg
    public bool IsPaid { get; set; }        // Kas makstud
    public Car Car { get; set; }            // Auto
    public ServiceType ServiceType { get; set; } // Teenuse tüüp
}
```

## 🔧 Installimine ja käivitamine

### Nõuded
- Windows 10/11
- .NET 8.0 Runtime
- Visual Studio 2022 (arendamiseks)

### Installimise sammud

1. **Repositooriumi kloonimine**
```bash
git clone https://github.com/[kasutajanimi]/AutodjaOmanikud.git
cd AutodjaOmanikud
```

2. **Pakettide taastamine**
```bash
dotnet restore
```

3. **Migratsioonide rakendamine**
```bash
dotnet ef database update
```

4. **Rakenduse käivitamine**
```bash
dotnet run
```

## 📱 Kasutamine

### 👥 Omanike haldamine
1. Avage vahekaart "Omanikud" / "Владельцы"
2. Sisestage nimi ja telefon
3. Klõpsake "Lisa" / "Добавить"
4. Muutmiseks valige rida ja klõpsake "Muuda" / "Изменить"
5. Kustutamiseks valige rida ja klõpsake "Kustuta" / "Удалить"

### 🚗 Autode haldamine
1. Avage vahekaart "Autod" / "Автомобили"
2. Valige omanik nimekirjast
3. Sisestage mark, mudel ja registreerimisnumber
4. Klõpsake "Lisa" / "Добавить"

### 🔧 Hoolduse haldamine
1. Avage vahekaart "Hooldus" / "Обслуживание"
2. Valige auto ja teenuse tüüp
3. Määrake kuupäev ja maksestaatus
4. Klõpsake "Lisa" / "Добавить"
5. Maksestaatuse muutmiseks kasutage nuppu "Muuda maksestaatust"

### ⚙️ Teenuste haldamine
1. Avage vahekaart "Teenused" / "Услуги"
2. Sisestage teenuse nimi ja hind
3. Klõpsake "Lisa" / "Добавить"
4. Muutmiseks valige rida ja klõpsake "Muuda" / "Изменить"

### 📊 Statistika
Statistika kuvatakse akna pealkirjas:
- Klientide / omanike arv
- Autode arv
- Teenuste arv
- Kogutulu eurodes

## 🏆 Modulaarse arhitektuuri eelised

- **Vastutuse jaotamine** - iga kontroll vastutab oma valdkonna eest
- **Koodi taaskasutamine** - kontrolle saab kasutada teistes vormides
- **Lihtne testimine** - iga moodulit testitakse eraldi
- **Skaleeritavus** - uute funktsioonide lisamine on lihtne
- **Hooldus** - vigade leidmine ja parandamine on lihtsam
- **Lokaliseerimine** - tsentraliseeritud tõlkesüsteem

## 🔄 Sündmuste süsteem

Kontrollid kasutavad sündmusi andmete sünkroniseerimiseks:

```csharp
// Kontrollis
public event Action DataChanged;

// Andmete muutmisel
DataChanged?.Invoke();

// Peamises vormis
ownerControl.DataChanged += OnDataChanged;
```

## 🌍 Lokaliseerimise süsteem

```csharp
public static class Localization
{
    public static string CurrentLanguage { get; set; } = "ru";
    
    public static string GetString(string key)
    {
        return CurrentLanguage switch
        {
            "et" => GetEstonian(key),
            "ru" => GetRussian(key),
            _ => GetRussian(key)
        };
    }
}
```

## 🛠️ Arendamine

### Uue kontrolli lisamine

1. Looge uus UserControl kaustas `Controls/`
2. Rakendage liides sündmusega `DataChanged`
3. Lisage meetod `UpdateLocalization()`
4. Lisage kontroll peamisele vormile
5. Tellige andmete muutmise sündmus

### Kontrolli struktuur
```csharp
public partial class UusKontroll : UserControl
{
    private AutoDbContext _context;
    public event Action DataChanged;

    public UusKontroll()
    {
        InitializeComponent();
        _context = new AutoDbContext();
        LaaeAndmed();
    }

    private void AndmedMuutunud()
    {
        DataChanged?.Invoke();
    }

    public void VärskendaAndmeid() => LaaeAndmed();
    
    public void UpdateLocalization()
    {
        // Liidese elementide tekstide uuendamine
        buttonAdd.Text = Localization.GetString("Add");
        buttonEdit.Text = Localization.GetString("Edit");
        buttonDelete.Text = Localization.GetString("Delete");
    }
}
```

### Uue tõlke lisamine

1. Avage fail `Localization.cs`
2. Lisage uus võti meetoditesse `GetRussian()` ja `GetEstonian()`
3. Kasutage koodis `Localization.GetString("TeieVõti")`

## 📈 Arendusplaanid

- [ ] Inglise keele toe lisamine
- [ ] Aruannete süsteemi realiseerimine
- [ ] Otsingu ja filtreerimise lisamine
- [ ] Varundamise süsteemi loomine
- [ ] Excel/PDF ekspordi lisamine
- [ ] Mitme kasutaja režiimi realiseerimine
- [ ] Eelseisvate hoolduste meeldetuletuste lisamine

## 🤝 Panustamine projekti

1. Tehke repositooriumist fork
2. Looge uue funktsiooni jaoks haru (`git checkout -b feature/UusFunktsioon`)
3. Kinnitage muudatused (`git commit -m 'Lisa uus funktsioon'`)
4. Lükake harusse (`git push origin feature/UusFunktsioon`)
5. Avage Pull Request

## 📄 Litsents

See projekt on litsentseeritud MIT litsentsi all - vaadake faili [LICENSE](LICENSE) detailide jaoks.

## 👨💻 Autor

**[Teie nimi]**
- GitHub: [@teiekasutajanimi](https://github.com/teiekasutajanimi)
- E-post: teie.email@example.com

## 🙏 Tänuavaldused

- Microsoftile .NET-i ja Entity Framework Core eest
- Arendajate kogukonnale inspiratsiooni ja toe eest
- Kõigile, kes testisid ja pakkusid täiustusi

---

⭐ Pange täht, kui projekt oli kasulik!