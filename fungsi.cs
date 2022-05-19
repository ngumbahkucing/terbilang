public string Terbilang(decimal xx)
{
  int x; int koma;
  string[] angka;
  string strXX = xx.ToString();
  if (strXX.Contains('.'))
  {
      angka = strXX.Split('.');
      x = int.Parse(angka[0]);
      koma = int.Parse(angka[1]);
  }
  else
  {
      x = int.Parse(strXX);
      koma = 0;
  }

  string[] bilangan = { "", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas" };
  string temp = "";

  if (x < 12)
  {
      temp = " " + bilangan[x];
  }
  else if (x < 20)
  {
      temp = Terbilang(x - 10).ToString() + " belas";
  }
  else if (x < 100)
  {
      temp = Terbilang(x / 10) + " puluh" + Terbilang(x % 10);
  }
  else if (x < 200)
  {
      temp = " seratus" + Terbilang(x - 100);
  }
  else if (x < 1000)
  {
      temp = Terbilang(x / 100) + " ratus" + Terbilang(x % 100);
  }
  else if (x < 2000)
  {
      temp = " seribu" + Terbilang(x - 1000);
  }
  else if (x < 1000000)
  {
      temp = Terbilang(x / 1000) + " ribu" + Terbilang(x % 1000);
  }
  else if (x < 1000000000)
  {
      temp = Terbilang(x / 1000000) + " juta" + Terbilang(x % 1000000);
  }

  if (koma > 0)
  {
      string sen = " koma" + Terbilang(koma);
      temp = temp + sen;
  }
  return temp;
}
