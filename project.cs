        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random random = new Random();
                listBox1.Items.Clear();

                int toplam = 0;

                for (int i = 0; i < 10; i++)
                {
                    int rastgeleSayi = random.Next(0, 50);
                    listBox1.Items.Add(rastgeleSayi);
                }

                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    toplam += Convert.ToInt32(listBox1.Items[j]);
                }

                MessageBox.Show("Sayıların Toplamı: " + toplam);
            }
        }
    }
}
