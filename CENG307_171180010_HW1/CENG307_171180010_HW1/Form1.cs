using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CENG307_171180010_HW1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        static Table[] table;
        Table[] blischTable;
        Table[] lichTable;
        Table[] reischTable;
        Table[] eischTable;
        public static int packingFactor;

        private void Form1_Load(object sender, EventArgs e)
        {
            lstView_blisch.View = View.Details;
            lstView_eisch.View = View.Details;
            lstView_lich.View = View.Details;
            lstView_reisch.View = View.Details;
            lstView_table.View = View.Details;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtKeysize.Text) < 901 && Convert.ToInt32(txtKeysize.Text) > 0)
            {
                table = Insert(Convert.ToInt32(txtKeysize.Text));
                AddToList(table);
            }
            else
            {
                MessageBox.Show("Please enter a value between 0 and 901.");
                txtKeysize.Text = "";
            }
        }
        static Table[] Insert(int number)
        {
            table = CreateItem(number);
            return table;

        }
        private void AddToList(Table[] tablo)
        {
            lstView_table.Items.Clear();
            for (int i = 0; i < tablo.Length; i++)
            {
                string[] item = new string[] { i.ToString(), tablo[i].val.ToString() };
                lstView_table.Items.Add(new ListViewItem(item));
            }
        }
        private void AddToList2(Table[] tablo, ListView list)
        {
            list.Items.Clear();
            for (int i = 0; i < tablo.Length; i++)
            {
                string[] item = new string[] { i.ToString(), tablo[i].val.ToString(), tablo[i].link.ToString(), tablo[i].probeNum.ToString() };
                list.Items.Add(new ListViewItem(item));
            }
        }
        static Table[] CreateItem(int number)
        {

            Table[] tablo = new Table[number];

             Random rnd = new Random();
             for (int i = 0; i < number; i++)
             {
             newItem:
                 Table item = new Table();
                 item.val = rnd.Next(0, 10000);
                 for (int j = 0; j < i; j++) //aynı sayı çıkmasın
                 {
                     if (tablo[j].val == item.val)
                         goto newItem;
                 }
                 item.link = -1;
                 tablo[i] = item;
             }
             return tablo;
            
        }

        private void btnEisch_Click(object sender, EventArgs e)
        {
            lblEisch_perf.Text = "";
            lblPackingFactor.Text = "Packing Factor: ";          
            lblHashSize.Text = "Hash Table: ";
            lblPrimaryArea.Text = "Primary Area for Lich (0.86): ";
            int num = table.Length;
            int hashSize;

            hashSize = Prime(num * 100 / 90);
            lblPackingFactor.Text += ((float)table.Length * 100 / (float)hashSize).ToString() + "%";
            lblHashSize.Text += hashSize.ToString() + " ";
            Table[] nullTable = ResetTable(hashSize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            eischTable = EISCH(table, nullTable, hashSize, table.Length);
            watch.Stop();

            var time4 = watch.Elapsed.TotalMilliseconds;
            lblEisch_perf.Text = "EISCH Performance: " + time4.ToString();
            AddToList2(eischTable, lstView_eisch);
        }
        Table[] EISCH(Table[] table, Table[] sirali, int tableSize, int number)
        {
            for (int i = 0; i < number; i++)
            {
                int id = table[i].val % tableSize;
                int r = tableSize - 1;
                if (sirali[id].val == -1) //mod fonksiyonuna göre çıkan değer tabloda boşsa yerleştir
                {
                    sirali[id].val = table[i].val;
                    sirali[id].probeNum++;
                }
                else //boş değilse
                {
                    while (sirali[r].val != -1) //sondan boş yer ara
                        r--;

                    if (sirali[id].link == -1)  //id sinin denk geldiği tabloda link boşsa r yi o linke atıyor ve sayıyı da bu boş bulduğu yere yerleştiriyor
                    {
                        sirali[r].val = table[i].val;
                        sirali[id].link = r;
                        sirali[r].probeNum += 2;
                    }
                    else if (sirali[id].link != -1) //id sinin denk geldiği link doluysa id deki link değerini cepte tutup bu link değerine bulduğu r değerini yazıyo kendi link değerine de cepte tuttuğu değeri atarız
                    {
                        int cepte = sirali[id].link;
                        sirali[id].link = r;
                        sirali[r].link = cepte;
                        sirali[r].probeNum += 2;
                        sirali[r].val = table[i].val;
                        while (sirali[r].link != -1)
                        {
                            sirali[sirali[r].link].probeNum++;
                            r = sirali[r].link;
                        }
                    }
                }

            }
            Probe(sirali, table, tableSize);
            return sirali;
        }
        static void Probe(Table[] sirali, Table[] tablo, int mod) 
        {
            for (int i = 0; i < tablo.Length; i++)
            {
                int idx = table[i].val % mod;
                int link = sirali[idx].link;
                if (sirali[idx].val == tablo[i].val)
                    sirali[idx].probeNum = 1;
                else
                {
                    int probe = 2;
                    while (true)
                    {
                        if (sirali[link].val == tablo[i].val)
                        {
                            sirali[link].probeNum = probe;
                            break;
                        }
                        else
                        {
                            link = sirali[link].link;
                            probe++;
                        }
                    }
                }
            }
        }
        static Table[] ResetTable(int number)
        {
            Table[] sirali = new Table[number];
            for (int i = 0; i < number; i++)
            {
                Table item = new Table();
                item.val = -1;
                item.link = -1;
                item.probeNum = 0;
                sirali[i] = item;
            }
            return sirali;
        }

        private void btnResich_Click(object sender, EventArgs e)
        {
            //int hashSatir = (tablo.Length * 100) / packingFactor;
            lblReisch_perf.Text = "";
            lblPackingFactor.Text = "Packing Factor: ";
            lblHashSize.Text = "Hash Table: ";
            int num = table.Length;
            int hashSize = Prime(num * 100 / 90);
            lblPackingFactor.Text += ((float)table.Length * 100 / (float)hashSize).ToString() + "%";
            lblHashSize.Text += hashSize.ToString() + " ";
            Table[] nullTable = ResetTable(hashSize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            reischTable = REISCH(table, nullTable, hashSize, table.Length);
            watch.Stop();

            var time3 = watch.Elapsed.TotalMilliseconds;
            lblReisch_perf.Text = "REISCH Performance: " + time3.ToString();
            AddToList2(reischTable, lstView_reisch);


        }
        Table[] REISCH(Table[] table, Table[] sirali, int tableSize, int number)//ekleme yapılacak yer random seçilir
        {

            Random rnd = new Random();
            int randomPlace = rnd.Next(0, tableSize);
            for (int i = 0; i < number; i++)
            {                
                int id = table[i].val % tableSize;
                if (sirali[id].val == -1) //ilk satır boşsa ekler.
                {
                    sirali[id].val = table[i].val;
                    sirali[id].probeNum++;
                }
                else //değilse
                {
                    while (sirali[randomPlace].val != -1)
                    {
                        randomPlace = rnd.Next(0, tableSize);

                    }
                    if (sirali[id].link != -1)
                    {
                        int cepte = sirali[id].link;
                        sirali[randomPlace].link = cepte;
                        sirali[id].link = randomPlace;
                        sirali[randomPlace].val = table[i].val;
                        sirali[randomPlace].probeNum += 2;

                        while (sirali[randomPlace].link != -1)
                        {
                            sirali[sirali[randomPlace].link].probeNum++;
                            randomPlace = sirali[randomPlace].link;
                        }
                    }
                    else
                    {
                        sirali[id].link = randomPlace;
                        sirali[randomPlace].val = table[i].val;
                        sirali[randomPlace].probeNum += 2;
                    }
                }
            }
            Probe(sirali, table, tableSize);
            return sirali;
        }
        Table[] LICH(Table[] table, Table[] sirali, int tableSize, int number)
        {

            int priArea = (int)(tableSize * 0.86); //best performance primary alanın 0.86, overflow alanın 0.14 olması ile
            lblPrimaryArea.Text += " " + priArea.ToString();
            int overflowArea = (int)(tableSize * 0.14);
            for (int i = 0; i < number; i++)
            {
                int id = table[i].val % priArea;
                if (sirali[id].val == -1) //id nin belirtildiği yer hash tablosunda boşsa yerleştir
                {
                    sirali[id].val = table[i].val;
                    sirali[id].probeNum++;
                }
                else
                {
                    int r = sirali.Length - 1;
                    while (sirali[r].val != -1)
                    {
                        r--;
                    }
                    sirali[r].probeNum += 2; //eklenenin en az 2 probe u olacağı kesin
                    while (sirali[id].link != -1)
                    {
                        id = sirali[id].link;
                        sirali[r].probeNum++;
                    }
                    sirali[r].val = table[i].val;
                    sirali[id].link = r;

                }
            }
            return sirali;

        }
        static Table[] BLISCH(Table[] table, Table[] sirali, int tableSize, int number)
        {
            bool control = true;
            for (int i = 0; i < number; i++)
            {
                int id = table[i].val % tableSize;
                if (sirali[id].val == -1)
                {
                    sirali[id].val = table[i].val;
                    sirali[id].probeNum++;
                }
                else
                {
                    int top = 0;
                    int bottom = sirali.Length - 1;
                    if (control) //üst için
                    {
                        while (sirali[top].val != -1 && top != bottom) //üstte boş yer ara aşağıya doğru
                        {
                            top++;
                        }
                        sirali[top].probeNum += 2;
                        if (sirali[id].link == -1) //mod değerinin denk geldiği link boşsa
                        {
                            sirali[top].val = table[i].val;
                            sirali[id].link = top;
                        }
                        else if (sirali[id].link != -1) //mod değerinin denk geldiği link doluysa 
                        {
                            while (sirali[id].link != -1)
                            {
                                id = sirali[id].link;
                                sirali[top].probeNum++;
                            }
                            sirali[id].link = top;
                            sirali[top].val = table[i].val;
                        }
                        control = false;
                    }
                    else //alt için
                    {
                        while (sirali[bottom].val != -1 && bottom != -1)
                        {
                            bottom -= 1;
                        }
                        sirali[bottom].probeNum += 2;
                        if (sirali[id].link == -1) //mod değerinin denk geldiği link boşsa
                        {
                            sirali[bottom].val = table[i].val;
                            sirali[id].link = bottom;
                        }
                        else if (sirali[id].link != -1) //mod değerinin denk geldiği link doluysa 
                        {
                            while (sirali[id].link != -1)
                            {
                                id = sirali[id].link;
                                sirali[bottom].probeNum++;
                            }
                            sirali[id].link = bottom;
                            sirali[bottom].val = table[i].val;
                        }
                        control = true;
                    }
                }
            }
            return sirali;

        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            lblLich_perf.Text = "";
            lblPackingFactor.Text = "Packing Factor: ";
            lblHashSize.Text = "Hash Table: ";
            lblPrimaryArea.Text = "Primary Area for Lich (0.86): ";
            int num = table.Length;

            int hashSize = Prime(num * 100 / 90); ;
            lblPackingFactor.Text += ((float)table.Length * 100 / (float)hashSize).ToString() + "%";
            lblHashSize.Text += hashSize.ToString() + " ";
            Table[] nullTable = ResetTable(hashSize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            lichTable = LICH(table, nullTable, hashSize, table.Length);
            watch.Stop();

            var time2 = watch.Elapsed.TotalMilliseconds;
            lblLich_perf.Text = "LICH Performance: " + time2.ToString();
            AddToList2(lichTable, lstView_lich);


        }

        private void btnBlisch_Click(object sender, EventArgs e)
        {
            lblBlisch_perf.Text = "";
            lblPackingFactor.Text = "Packing Factor: ";
            lblHashSize.Text = "Hash Table: ";
            int num = table.Length;

            int hashSize = Prime(num * 100 / 90);
            lblPackingFactor.Text += ((float)table.Length * 100 / (float)hashSize).ToString() + "%";
            lblHashSize.Text += hashSize.ToString() + " ";
            Table[] nullTable = ResetTable(hashSize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            blischTable = BLISCH(table, nullTable, hashSize, table.Length);
            watch.Stop();

            var time1 = watch.Elapsed.TotalMilliseconds;
            lblBlisch_perf.Text = "BLISCH Performance: " + time1.ToString();
            AddToList2(blischTable, lstView_blisch);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblBlischSearch.Text = "";
            lblLichSearch.Text = "";
            lblReischSearch.Text = "";
            lblEischSearch.Text = "";

            int val = Convert.ToInt32(txtSearch.Text);
            lblBlischSearch.Text = "BLISCH: " + Search(blischTable, val);
            lblLichSearch.Text = "LICH: " + Search(lichTable, val);
            lblReischSearch.Text = "RESICH: " + Search(reischTable, val);
            lblEischSearch.Text = "EISCH: " + Search(eischTable, val);
        }
        static string Search(Table[] table, int val)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (val == table[i].val)
                    return "Index:" + i + "  Probe:" + table[i].probeNum;
            }
            return " Value " + val + " is not found";
        }
        static int Prime(int value) //sayının sonrasında gelen, sayıya en yakın asal sayıyı bulacak
        {
            int i, d;
            int last = 0;
            for (i = value + 1; i > value; i++) //i=9; i>8;i++
            {
                d = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) //9%2 giremedi 9%3 girdi d=0
                    {
                        d = 0;
                        break;
                    }
                }
                if (d == 1) //d değişmediyse yani if e girilmesiyse bölünebildiği sayı yok o zaman asal
                {
                    last = i;
                    i = 0;
                }
            }
            return last;
        }
    }
}
