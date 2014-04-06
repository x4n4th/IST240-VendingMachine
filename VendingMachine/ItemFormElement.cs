using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    class ItemFormElement
    {
        Label lblCost, lblName, lblQuantity;
        Button btnSelect, btnInfo;
        Form1 form;

        int x, y;

        Item item;
        /// <summary>
        ///     Represents the location and elemnts of an item on the form
        /// </summary>
        /// <param name="form">Form that the item will be appended to</param>
        /// <param name="point">Location to append the element</param>
        /// <param name="item">Item to be represented</param>
        public ItemFormElement(Form1 form, Point point, Item item) {
            this.form = form;
            this.x = point.X;
            this.y = point.Y;
            this.item = item;

            /*
             * Now we will setup the item object on the form
             */
             
            lblCost = new Label();
            lblName = new Label();
            lblQuantity = new Label();
            btnSelect = new Button();
            btnInfo = new Button();

            btnSelect.Location = new Point(x, y);
            btnSelect.Width = 140;
            btnSelect.Height = 100;
            
            try {
                Image itemImage = System.Drawing.Image.FromFile(@item.picture);
                btnSelect.Image = ScaleImage(itemImage, 140, 100);
            }
            catch {
                //The image was not found
                MessageBox.Show("Picture for " + item.name + " was not found.");
            }  
            
            btnSelect.Name = item.name;
            btnSelect.Click += btnSelect_Click;
            form.Controls.Add(btnSelect);

            btnInfo.Location = new Point(x, y + 100);
            btnInfo.Width = 140;
            btnInfo.Height = 20;
            btnInfo.Text = "Info";
            btnInfo.Click += btnInfo_Click;
            form.Controls.Add(btnInfo);

            lblName.Location = new Point(x, y + 120);
            lblName.Width = 88;
            lblName.Height = 14;
            //lblName.BackColor = Color.Orange;
            lblName.Text = item.name.ToString();
            form.Controls.Add(lblName);

            lblCost.Location = new Point(x + 85, y + 120);
            lblCost.Width = 35;
            lblCost.Height = 12;
            //lblCost.BackColor = Color.LightSkyBlue;
            lblCost.Text = item.cost.ToString("C");
            form.Controls.Add(lblCost);

            lblQuantity.Location = new Point(x + 120, y + 120);
            lblQuantity.Width = 20;
            //lblQuantity.BackColor = Color.LightGreen;
            lblQuantity.Height = 12;
            lblQuantity.Text = item.count.ToString();
            form.Controls.Add(lblQuantity);
        }

        /// <summary>
        /// On click this function shows the detailed information of that item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e) {
            string info = item.name + " Details" + Environment.NewLine;

            foreach(string detail in item.info){
                info += detail + Environment.NewLine;
            }

            MessageBox.Show(info);
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

        /// <summary>
        /// Called When Item button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSelect_Click(object sender, EventArgs e) {
            if (form.tryVend((decimal)this.item.cost)) {
                this.form.setInfo("Vending: " + ((Button)sender).Name);
                item.count = item.count - 1;
                lblQuantity.Text = (Int16.Parse(lblQuantity.Text) - 1).ToString();
            }
            else {
                this.form.setInfo("Please enter more money for that item");
            }
        }

        /// <summary>
        /// Removes the form element from the form.
        /// </summary>
        public void destroy(){
            this.btnInfo.Dispose();
            this.btnSelect.Dispose();
            this.lblCost.Dispose();
            this.lblName.Dispose();
            this.lblQuantity.Dispose();
        }
    }
}
