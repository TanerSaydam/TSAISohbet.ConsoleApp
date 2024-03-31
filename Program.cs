
Console.ForegroundColor = ConsoleColor.Green;



List<string> questions = new()
{    
    "Hobilerin neler?",
    "Hayatında yapmak istediğin ama henüz yapamadığın bir şey var mı?",
    "En son izlediğin film ya da dizi neydi ve nasıl buldun?",
    "Okuduğun en son kitap hangisiydi ve üzerinde nasıl bir etki bıraktı?",
    "En çok hangi müzik türlerini seversin?",
    "Bugüne kadar gittiğin en güzel yer neresiydi?",
    "Hayatında en çok değer verdiğin şey nedir?",
    "Bir hayvan olsaydın, hangisi olurdun ve neden?",
    "En büyük hayalin nedir?",
    "Yaşamak istediğin bir ülke veya şehir var mı? Neden orası?",
    "Çocukken ne olmak istiyordun?",
    "Günlük rutinin nasıl? Bir gününü nasıl geçirirsin?",
    "En sevdiğin yemek nedir ve neden?",
    "Bir süper gücün olsa ne olmasını isterdin?",
    "Hayatını en çok etkileyen kişi kimdir ve neden?",
    "Bir zaman makinen olsa hangi döneme gitmek isterdin?",
    "Kendini en iyi hissettiğin aktivite nedir?",
    "Hayatta en çok neyden keyif alırsın?",
    "Başkalarına nasıl bir ilk izlenim bıraktığını düşünüyorsun?",
    "Öğrenmek istediğin bir yetenek var mı? Eğer varsa, bu ne?"
};

List<string> prologues = new()
    {
        "Merhaba benim adım TS AI",
        "Size bugün birkaç soru yönelterek sizi tanımaya çalışacağım",
        "Hazırsanız başlayalım"
    };

foreach (var pro in prologues)
{
    await TypeWriteLine(pro);
    await Task.Delay(1000);
}


Console.ForegroundColor = ConsoleColor.White;

foreach (var question in questions)
{
    await TypeWriteLine(question);
    Console.ReadLine();    
}

Console.ReadLine();



static async Task TypeWriteLine(string text)
{
    for (int i = 0; i <= text.Length; i++)
    {
        Console.SetCursorPosition(0, Console.CursorTop); // İmleci satırın başına getir
        Console.Write(text.Substring(0, i)); // Metnin bir kısmını yazdır
        await Task.Delay(20); // Bir sonraki harfe geçmeden önce kısa bir süre bekle
    }
    Console.WriteLine(); // Satırı bitir
}