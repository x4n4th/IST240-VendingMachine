using Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        //How many elements in a row
        private int vendWidth = 4;

        List<ItemFormElement> formElementList;

        decimal moneyEntered;

        VendingMachinType state;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                Image image = System.Drawing.Image.FromFile(@"../../pictures/dollar.jpg");
                btnDollar.Image = ScaleImage(image, 207, 100);

                image = System.Drawing.Image.FromFile(@"../../pictures/quarter.jpg");
                btnQuarter.Image = ScaleImage(image, 100, 100);

                image = System.Drawing.Image.FromFile(@"../../pictures/dime.jpg");
                btnDime.Image = ScaleImage(image, 100, 100);

                image = System.Drawing.Image.FromFile(@"../../pictures/nickel.jpg");
                btnNickel.Image = ScaleImage(image, 100, 100);

                image = System.Drawing.Image.FromFile(@"../../pictures/penny.jpg");
                btnPenny.Image = ScaleImage(image, 100, 100);
            }
            catch {
                //Nothing Serious If the User wants to fix the pictures that didnt load they can
                MessageBox.Show("Could not locate a Picture for Currency");
            }

            formElementList = new List<ItemFormElement>();
            loadDrinks();

            moneyEntered = 0;
        }

        private void onMoneyClick(object sender, EventArgs e) {
            Button btn = (Button)sender;

            string name = btn.Name;

            if (name == "btnDollar") {
                moneyEntered += 1.00M;
            }
            else if (name == "btnQuarter") {
                moneyEntered += 0.25M;
            }
            else if (name == "btnDime") {
                moneyEntered += 0.10M;
            }
            else if (name == "btnNickel") {
                moneyEntered += 0.05M;
            }
            else if (name == "btnPenny") {
                moneyEntered += 0.01M;
            }
            txtMoney.Text = "Amount: " + moneyEntered.ToString("C");
        }

        /// <summary>
        /// Clears the board of all item form elements
        /// </summary>
        private void clearBoard() {
            foreach (ItemFormElement element in formElementList) {
                element.destroy();
            }
            formElementList = new List<ItemFormElement>();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void setInfo(String message) {
            txtInfo.Text = message;
        }

        /// <summary>
        /// Scales an image proportionally.  Returns a bitmap.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="maxWidth"></param>
        /// <param name="maxHeight"></param>
        /// <returns></returns>
        static public Bitmap ScaleImage(Image image, int maxWidth, int maxHeight) {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            Bitmap bmp = new Bitmap(newImage);

            return bmp;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            clearBoard();
        }

        public void loadDrinks() {
            this.state = VendingMachinType.DRINK;
            Drink[] obj = (Drink[])readXML(typeof(Drink[]), "DrinkItems.xml");

            draw(obj);
        }

        public void loadCandy() {
            this.state = VendingMachinType.CANDY;
            Candy[] obj = (Candy[])readXML(typeof(Candy[]), "CandyItems.xml");

            draw(obj);
        }

        public void loadSnacks() {
            this.state = VendingMachinType.SNACK;
            Snack[] obj = (Snack[])readXML(typeof(Snack[]), "SnackItems.xml");

            draw(obj);
        }

        public Item[] readXML(Type itemType, string location) {
            XmlSerializer serializer = new XmlSerializer(itemType);
            Stream stream = new FileStream
                  (location, FileMode.Open, FileAccess.Read, FileShare.None);
            Item[] obj = (Item[])serializer.Deserialize(stream);
            stream.Close();

            return obj;
        }

        private void draw(Item[] items) {
            int cursor = 0;

            for (int i = 0; i < (int)Math.Ceiling((double)(items.Length / vendWidth)) + 1; i++) {
                for (int r = 0; r < vendWidth; r++) {
                    Item item = items[cursor];
                    formElementList.Add(new ItemFormElement(this, new Point(r * 140 + 10, i * 140 + 30), item));

                    cursor++;
                    if (cursor == items.Length) {
                        break;
                    }

                }
                if (cursor == items.Length) {
                    break;
                }
            }
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e) {
            clearBoard();
            loadDrinks();
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e) {
            clearBoard();
            loadSnacks();
        }

        private void candyToolStripMenuItem_Click(object sender, EventArgs e) {
            clearBoard();
            loadCandy();
        }

        public bool tryVend(decimal amount){
            if (amount <= moneyEntered) {
                CoinChange cc = Service.TotalChange(amount, moneyEntered);
                MessageBox.Show("Refund amount: " + Environment.NewLine +
                    "Dollars: " + cc.Dollar.ToString() + Environment.NewLine +
                    "Quarters: " + cc.Quarter.ToString() + Environment.NewLine +
                    "Dimes: " + cc.Dime.ToString() + Environment.NewLine +
                    "Nickels: " + cc.Nickel.ToString() + Environment.NewLine +
                    "Pennies: " + cc.penny.ToString()
                    );
                this.moneyEntered = 0;
                txtMoney.Text = "Amount: " + moneyEntered.ToString("C");
                return true;
            }
            return false;
        }

        public void save(Item[] items, string location) {
            XmlSerializer serializer = new XmlSerializer(items.GetType());
            Stream stream = new FileStream
                  (location, FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(stream, items);
            stream.Close();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e) {
            clearBoard();
            vendWidth = (int)(this.Width / 210);
            if (state == VendingMachinType.SNACK) {
                loadSnacks();
            } 
            else if (state == VendingMachinType.DRINK){
                loadDrinks();
            }
            else if (state == VendingMachinType.CANDY) {
                loadCandy();
            }
        }
    }
}
