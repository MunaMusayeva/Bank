namespace ConsoleApp7;

public class User
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }
    public User(string ad, string soyad, string email, string telefon)
    {
        Ad = ad;
        Soyad = soyad;
        Email = email;
        Telefon = telefon;
    }



}
