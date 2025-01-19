
# SignalChess

SignalChess, SignalR ve Blazor teknolojilerini kullanarak geliştirilen, gerçek zamanlı bir projedir. Bu uygulama, iki oyuncunun anlık olarak birbirleriyle etkileşimde bulunabileceği, hamlelerin ve mesajların anında iletildiği bir oyun deneyimi sunmaktadır. MudBlazor kullanarak modern ve şık bir kullanıcı arayüzü sağlanmıştır.


## Özellikler

- Gerçek Zamanlı Oyun: SignalR ile sunucu ve istemciler arasında anlık iletişim sağlanır, böylece oyun hamleleri ve mesajlar diğer oyuncuya anında iletilir.
- MudBlazor UI: Modern ve kullanıcı dostu bir arayüz için MudBlazor bileşenleri kullanılmıştır.
- Oyun Durumu Güncellemesi: Oyun tahtası, her hamlede anında güncellenir.
- Mesajlaşma Sistemi: Oyuncular arasında metin mesajları gönderilebilir.
- Yüksek Performans: Blazor Server ve SignalR entegrasyonu sayesinde hızlı ve etkili bir oyun deneyimi sağlanır.

  
## Kullanılan Teknolojiler

Blazor WebApp: WebAssembly yerine server-side Blazor kullanılarak daha hızlı ve verimli bir uygulama deneyimi elde edilmiştir.

SignalR: Gerçek zamanlı iletişim için SignalR kütüphanesi kullanılarak, sunucu ve istemci arasındaki veri senkronizasyonu sağlanmıştır.

MudBlazor: Şık ve modern kullanıcı arayüzü bileşenleri için MudBlazor kullanılmıştır.

.NET 8: Uygulama .NET 8 üzerinde geliştirilmiştir.

## Ekran Görüntüleri
![image](https://github.com/user-attachments/assets/3037efc2-096d-48e9-848c-d6ee3c77d632)
![image](https://github.com/user-attachments/assets/d748b5d9-e6f3-431a-b7b2-1c44a627349f)
![image](https://github.com/user-attachments/assets/2c2c4b8a-cabc-4716-ac8c-1fbccb0078d3)

## Signal R Kullanımı

#### Mesaj gönderme

```http
  /chessHub/sendMessage
```

| Parametre | Tip     | Açıklama                |
| :-------- | :------- | :------------------------- |
| `username` | `string` | **Gerekli**. Kullanıcı adı. |
| `mesage` | `string` | **Gerekli**. Kullanıcı mesajı. |

#### Hamle gönderme

```http
  /chessHub/PlayItem
```

| Parametre | Tip     | Açıklama                       |
| :-------- | :------- | :-------------------------------- |
| `items`      | `List<DropItem>` | **Gerekli**. Itemların son hali |

  
## İlişkili Projeler

İşte bazı ilgili projeler

[NotificationApp](https://github.com/ufukgulec/NotificationApp)

  
## Katkıda Bulunma

Katkı sağlamak isterseniz, lütfen aşağıdaki adımları izleyin:

1. Repo'yu fork'layın.

2. Yeni bir feature branch oluşturun (git checkout -b feature-name).

3. Değişikliklerinizi yapın ve commit edin (git commit -am 'Add new feature').

4. Push yapın (git push origin feature-name).
Pull request oluşturun.
  
## Destek

Destek için orhanufukgulec@gmail.com adresine e-posta gönderin.

  
